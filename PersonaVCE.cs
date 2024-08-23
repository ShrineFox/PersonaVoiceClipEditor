using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading;
using ShrineFox.IO;
using AFSLib;
using System.Media;
using MetroSet_UI.Forms;
using System.Windows.Forms;
using static System.Windows.Forms.Design.AxImporter;
using System.Diagnostics.Eventing.Reader;
using NAudio.Wave;

namespace PersonaVCE
{
    public partial class PersonaVCE : MetroSetForm
    {
        public static List<string> supportedFormats = new List<string> { ".adx", ".hca", ".wav" };
        public static List<string> supportedArchives = new List<string> { ".acb", ".afs" };
        public static List<string> presets = new List<string> { "None",
            "P5R (PC/Switch)",
            "P5R (ENG PS4)",
            "P5R (JP PS4)",
            "P5 (PS3)",
            "P3/4" };

        public static List<string> ryoOutputModes = new List<string> { "Don't Output For Ryo" };

        public PersonaVCE()
        {
            InitializeComponent();

            SetupLogging();
            SetupDropdowns();
            SetupTheme();

            // Select P5R Switch/PC preset by default
            if (comboBox_EncryptionPreset.SelectedIndex == 0)
                comboBox_EncryptionPreset.SelectedIndex = 1;
        }

        private void SetupTheme()
        {
            Theme.ThemeStyle = MetroSet_UI.Enums.Style.Dark;
            Theme.ApplyToForm(this);
        }

        private void SetupDropdowns()
        {
            MenuStripHelper.SetMenuStripIcons(MenuStripHelper.GetMenuStripIconPairs(".\\Dependencies\\icons.txt"), this);

            comboBox_SoundFormat.ComboBox.DataSource = supportedFormats;
            comboBox_SoundFormat.ComboBox.BindingContext = this.BindingContext;

            comboBox_ArchiveFormat.ComboBox.BindingContext = this.BindingContext;
            comboBox_ArchiveFormat.ComboBox.DataSource = supportedArchives;

            comboBox_EncryptionPreset.ComboBox.DataSource = presets;
            comboBox_EncryptionPreset.ComboBox.BindingContext = this.BindingContext;

            if (Directory.Exists("./Dependencies/RyoText"))
                foreach (var tsv in Directory.GetFiles("./Dependencies/RyoText", "*.tsv", SearchOption.AllDirectories))
                    ryoOutputModes.Add(Path.GetFileNameWithoutExtension(tsv));
            comboBox_Ryo.DataSource = ryoOutputModes;
            comboBox_Ryo.BindingContext = this.BindingContext;
        }

        private void SetupLogging()
        {
            Output.Logging = true;
#if DEBUG
            Output.VerboseLogging = true;
            Output.LogControl = rtb_Log;
#endif
        }

        private void Encode(string[] inputFiles, string outFormat = "")
        {
            if (inputFiles.Length == 0 || string.IsNullOrEmpty(inputFiles[0]))
                return;

            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;

                if (outFormat == "")
                    outFormat = comboBox_SoundFormat.SelectedItem.ToString();
                Output.Log($"[INFO] Encoding supported files to format \"{outFormat}\".");

                string outputDir = FileSys.CreateUniqueDir(Path.Combine(Path.GetDirectoryName(inputFiles[0]), "Encoded"));

                // Convert files to target format, output to specified directory
                foreach (var file in inputFiles.Where(x => supportedFormats.Any(y => y.Equals(Path.GetExtension(x.ToLower())))))
                {
                    bool encrypted = false;
                    string extension = Path.GetExtension(file).ToLower();
                    // Check if adx is already encrypted
                    if (extension == ".adx")
                    {
                        using (FileStream fs = new FileStream(file, FileMode.Open))
                        {
                            using (BinaryReader reader = new BinaryReader(fs))
                            {
                                reader.BaseStream.Position = 19;
                                if (reader.ReadByte() == Convert.ToByte(9))
                                    encrypted = true;
                            }
                        }
                    }
                    string outPath = Path.Combine(outputDir, Path.GetFileNameWithoutExtension(file) + outFormat);
                    string args = $"\"{file}\" \"{outPath}\"";

                    // If file is encrypted, remove encryption with key.
                    // Otherwise, output will be encrypted with key
                    if (chk_UseEncryption.Checked && num_EncryptionKey.Value != 0 && num_EncryptionKey.Enabled)
                        args += $" --keycode {num_EncryptionKey.Value}";

                    // If loops are specified, use loops
                    if (chk_UseLoopPoints.Checked)
                    {
                        if (chk_LoopAll.Checked)
                            args += $" -l 0-{GetSampleCount(file) - 1}";
                        else
                            args += $" -l {Convert.ToInt32(num_LoopStart.Value)}-{Convert.ToInt32(num_LoopEnd.Value)}";
                    }

                    Output.VerboseLog($"[INFO] Encoding \"{Path.GetFileName(file)}\" to \"{Path.GetFileName(outPath)}\"...");
                    string vgAudioPath = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "Dependencies\\VGAudio.exe");
                    if (!File.Exists(vgAudioPath))
                    {
                        Output.VerboseLog($"[INFO] Failed to encode, could not find executable: \"{vgAudioPath}\"", ConsoleColor.DarkRed);
                        return;
                    }
                    Exe.Run(vgAudioPath, args);
                    using (FileSys.WaitForFile(outPath)) { };
                    if (File.Exists(outPath))
                    {
                        if (outFormat == ".adx" && args.Contains("--keycode"))
                        {
                            using (FileStream fs = new FileStream(outPath, FileMode.Open))
                            {
                                using (BinaryWriter writer = new BinaryWriter(fs))
                                {
                                    // Add encryption flag to file if using keycode
                                    writer.BaseStream.Position = 19;
                                    byte newByte = Convert.ToByte(9);
                                    // Remove encryption flag if input is encrypted,
                                    // and therefore output is no longer encrypted
                                    if (encrypted)
                                        newByte = Convert.ToByte(0);
                                    Output.VerboseLog($"[INFO] Setting encryption byte to: {newByte.ToString("x2")}");
                                    writer.Write(newByte);
                                };
                            }
                        }
                        Output.VerboseLog($"[INFO] Encoded file successfully!", ConsoleColor.DarkGreen);
                    }
                    else
                        Output.VerboseLog($"[INFO] Failed to encode file: \"{file}\"", ConsoleColor.DarkRed);
                }

                SystemSounds.Exclamation.Play();
            }).Start();
            Output.Log($"[INFO] Done encoding files to \"{comboBox_SoundFormat.SelectedItem}\".", ConsoleColor.Green);
        }

        private long GetSampleCount(string file)
        {
            long sampleCount = -1;

            if (File.Exists(file))
            {
                if (Path.GetExtension(file).ToLower() == ".adx")
                using (FileStream fs = new FileStream(file, FileMode.Open))
                {
                    using (EndianBinaryReader reader = new EndianBinaryReader(fs, Endianness.LittleEndian))
                    {
                        reader.BaseStream.Position = 12;
                        sampleCount = reader.ReadInt32();
                    }
                }
                else if (Path.GetExtension(file).ToLower() == ".wav")
                {
                    using (var waveFile = new WaveFileReader(file))
                    {
                        sampleCount = waveFile.SampleCount;
                    }
                }
            }

            return sampleCount;
        }

        private void AddTxtLinesToDGV()
        {
            if (!File.Exists(settings.InputTxtPath))
                return;

            settings.DGVCells = new List<string>();
            var lines = File.ReadAllLines(settings.InputTxtPath);
            dgv_RenameTxt.Rows.Clear();
            foreach (var line in lines)
            {
                string[] splitLine = line.Split('\t');
                dgv_RenameTxt.Rows.Add(splitLine[0]);
                settings.DGVCells.Add(splitLine[0]);
            }
        }

        private void Rename()
        {
            if (Directory.Exists(settings.RenameDir))
            {
                if (settings.RyoOutputMode != "Don't Output For Ryo")
                    RenameFilesForRyoFramework();
                else
                    RenameFilesForFEmulator();
            }
            else
                Output.Log($"[ERROR] Rename failed, could not find file: \"{settings.RenameDir}\"", ConsoleColor.Red);

        }

        public class Adx
        {
            public string Path = "";
            public string CueName = "";
            public int WaveID = -1;
            public int CueID = -1;
            public bool Streaming = false;
        }

        private List<Adx> GetADXInfoFromTSV()
        {
            // Get ADX data from .tsv file
            List<Adx> AdxFiles = new List<Adx>();
            var lines = File.ReadAllLines($"./Dependencies/RyoText/{settings.RyoOutputMode}.tsv");
            foreach (var line in lines)
            {
                var parts = line.Split('\t');
                var partsArray = new string[] { parts[0], parts[1], parts[22], parts[27] };

                if (!partsArray.Any(string.IsNullOrEmpty))
                {
                    Adx adx = new Adx()
                    {
                        CueName = parts[0],
                        CueID = Convert.ToInt32(parts[1]),
                        WaveID = Convert.ToInt32(parts[22]),
                        Streaming = Convert.ToBoolean(parts[27])
                    };
                    AdxFiles.Add(adx);
                }
            }
            return AdxFiles;
        }

        private void RenameFilesForRyoFramework()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;

                List<Adx> AdxFiles = GetADXInfoFromTSV();
                
                // Get files from input directory with a filename that matches a line in the DataGridView control
                var files = Directory.GetFiles(settings.RenameDir).Where(x => settings.DGVCells.Any(y => Path.GetFileNameWithoutExtension(x) == y)).ToList();


                // Add input file paths to each adx entry that matches wave ID and cue type
                int waveID = Convert.ToInt32(settings.StartIndex);
                for (int i = 0; i < files.Count(); i++)
                {
                    foreach (var adx in AdxFiles.Where(x => x.WaveID == waveID && x.Streaming == settings.RyoStreaming))
                        adx.Path = files[i];

                    waveID++;
                }

                // Move each file to destination that has an input path assigned
                foreach (var adx in AdxFiles.Where(x => !string.IsNullOrEmpty(x.Path)))
                {
                    string outFolder = Path.Combine(settings.RenameOutDir, adx.CueName);
                    if (!string.IsNullOrEmpty(settings.RyoSuffix))
                        outFolder += $"_{settings.RyoSuffix}";

                    if (!settings.RyoCueNames)
                        outFolder = Path.Combine(settings.RenameOutDir, adx.CueID.ToString() + ".cue");

                    Directory.CreateDirectory(outFolder);
                    // Copy adx to Cue folder
                    string outFile = Path.Combine(outFolder, Path.GetFileName(adx.Path));
                    File.Copy(adx.Path, outFile, true);
                    // Create config file for .adx
                    string configTxt = $"player_id: -1";
                    if (!settings.RyoCueNames)
                        configTxt += $"\ncue_name: '{adx.CueID}'";
                    else
                        configTxt += $"\ncue_name: '{adx.CueName}'";
                    if (settings.RyoCategory >= 0)
                        configTxt += $"\ncategory_ids: [{settings.RyoCategory}]";
                    if (settings.RyoOverrideVolume)
                        configTxt += $"\nvolume: {settings.RyoVolume}";
                    if (settings.RyoPlayerVolume)
                        configTxt += $"\nuse_player_volume: true";
                    string outFileConfigPath = Path.Combine(outFolder, Path.GetFileNameWithoutExtension(outFile) + ".yaml");
                    File.WriteAllText(outFileConfigPath, configTxt);
                }

            }).Start();
        }

        private void RenameFilesForFEmulator()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;

                Output.Log($"[INFO] Copying and renaming files based on order of filenames in: \"{settings.InputTxtPath}\"");

                // Re-order based on .txt file
                int i = Convert.ToInt32(settings.StartIndex);

                var files = Directory.GetFiles(settings.RenameDir);
                foreach (var line in settings.DGVCells)
                {
                    string fileName = Path.GetFileNameWithoutExtension(line.Trim());

                    // If file found, copy to output folder with new name
                    if (files.Any(x => Path.GetFileNameWithoutExtension(x).Equals(fileName)))
                    {
                        var file = files.First(x => Path.GetFileNameWithoutExtension(x).Equals(fileName));
                        var ext = Path.GetExtension(file);
                        string outPath = Path.Combine(settings.RenameOutDir, $"{i.ToString().PadLeft(Convert.ToInt32(settings.LeftPadding), '0')}{settings.TxtSuffix}");

                        if (settings.AppendFilename)
                            outPath += $"_{Path.GetFileNameWithoutExtension(file)}";
                        outPath += Path.GetExtension(file);

                        // Copy to output path once available
                        Directory.CreateDirectory(Path.GetDirectoryName(outPath));
                        File.Copy(file, outPath, true);
                        Output.VerboseLog($"[INFO] Copied \"{file}\" to:\n\t\"{outPath}\"", ConsoleColor.Green);
                    }
                    else
                        Output.VerboseLog($"[WARNING] File with name \"{fileName}\" not found in directory \"{settings.RenameDir}\", " +
                            $"skipping index {i}.", ConsoleColor.Yellow);
                    i++;
                }
                Output.Log($"[INFO] Done copying and renaming files to: \"{settings.RenameOutDir}\"", ConsoleColor.Green);
                SystemSounds.Exclamation.Play();
            }).Start();
        }

        private void ExtractArchive(string archivePath)
        {
            if (File.Exists(archivePath))
            {
                if (Path.GetExtension(archivePath).ToLower() == ".afs")
                    ExtractAFS(archivePath);
                else if (Path.GetExtension(archivePath).ToLower() == ".acb")
                    ExtractACB(archivePath);
                else
                    Output.Log($"[ERROR] Could not extract archive, not a supported format: \"{archivePath}\"", ConsoleColor.Red);
            }
            else
                Output.Log($"[ERROR] Could not unpack archive, file doesn't exist: \"{archivePath}\"", ConsoleColor.Red);
        }

        private void RepackArchive(string folderPath)
        {
            if (Directory.Exists(folderPath))
            {
                if (comboBox_ArchiveFormat.SelectedItem.ToString() == ".afs")
                    RepackAFS(folderPath);
                else if (comboBox_ArchiveFormat.SelectedItem.ToString() == ".acb")
                    RepackACB(folderPath);
                else
                    Output.Log($"[ERROR] Could not repack archive, not a supported format: \"{comboBox_ArchiveFormat.SelectedItem}\"", ConsoleColor.Red);
            }
            else
                Output.Log($"[ERROR] Could not repack archive, directory doesn't exist: \"{folderPath}\"", ConsoleColor.Red);
        }

        private void ExtractAFS(string afsPath)
        {
            if (File.Exists(afsPath))
            {
                string outputDir = FileSys.CreateUniqueDir(afsPath + "_extracted");
                Directory.CreateDirectory(outputDir);

                //new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;


                    Output.Log($"[INFO] Extracting AFS archive: \"{afsPath}\"");

                    //Extract AFS
                    using (AFS afs = new AFS(afsPath))
                    {
                        for (int i = 0; i < afs.EntryCount; i++)
                        {
                            if (!(afs.Entries[i] is NullEntry))
                            {
                                DataEntry dataEntry = afs.Entries[i] as DataEntry;
                                string outPath = Path.Combine(outputDir, i + Path.GetExtension(dataEntry.SanitizedName));
                                afs.ExtractEntryToFile(afs.Entries[i], outPath);
                                Output.VerboseLog($"[INFO] Extracted from AFS: \"{outPath}\"");
                            }
                            else
                                Output.VerboseLog($"[INFO] Skipping null entry in AFS: {i}");
                        }
                    }
                    SystemSounds.Exclamation.Play();
                }
                //).Start();
                Output.Log($"[INFO] Done extracting archive contents to: \"{outputDir}\"", ConsoleColor.Green);
            }
            else
                Output.Log($"[ERROR] AFS extraction failed, input archive doesn't exist: \"{afsPath}\"", ConsoleColor.Red);
        }

        private void RepackAFS(string afsDir)
        {
            string outputFile = afsDir + ".AFS";

            if (Directory.Exists(afsDir))
            {
                //new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;
                    // Get input files from AFS directory
                    List<string> files = Directory.GetFiles(afsDir).ToList();

                    // Create new AFS
                    using (AFS afs = new AFS())
                    {
                        for (int i = 0; i < files.Count; i++)
                        {
                            FileEntry entry = afs.AddEntryFromFile(files[i], i + Path.GetExtension(files[i]));
                            entry.CustomData = 7;
                            Output.VerboseLog($"[INFO] Added entry to AFS: \"{files[i]}\"");
                        }
                        afs.SaveToFile(outputFile);
                    }

                    SystemSounds.Exclamation.Play();
                }
                //).Start();
                Output.Log($"[INFO] Done creating AFS archive at: \"{outputFile}\"", ConsoleColor.Green);
            }
            else
                Output.Log($"[ERROR] AFS repack failed, extracted archive directory doesn't exist: \"{afsDir}\"", ConsoleColor.Red);
        }

        private void ExtractACB(string acbPath)
        {
            if (File.Exists(acbPath))
            {
                //new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;

                    // Extract ADX from ACB
                    AcbEditor.Program.Main(new string[] { acbPath });
                    Output.Log($"[INFO] Done extracting archive contents from: \"{acbPath}\"", ConsoleColor.Green);
                    
                    SystemSounds.Exclamation.Play();
                }
                //).Start();
            }
            else
                Output.Log($"[ERROR] ACB extract failed, input archive doesn't exist: \"{acbPath}\"", ConsoleColor.Red);

        }

        private void RepackACB(string acbDir)
        {
            string acbFile = acbDir + ".acb";
            string awbFile = acbFile.Replace(".acb", ".awb");

            if (!File.Exists(acbFile))
            {
                Output.Log($"[ERROR] ACB repack failed, original ACB doesn't exist: \"{acbFile}\"", ConsoleColor.Red);
                return;
            }
            if (!File.Exists(awbFile))
            {
                Output.Log($"[ERROR] ACB repack failed, original AWB doesn't exist: \"{awbFile}\"", ConsoleColor.Red);
                return;
            }
                
            if (Directory.Exists(acbDir))
            {
                //new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;

                    // Repack ACB
                    Output.Log($"[INFO] Repacking ACB/AWB file with files from: \"{acbDir}\"");
                    AcbEditor.Program.Main(new string[] { acbDir });
                    Output.Log($"[INFO] Done repacking ACB archive: \"{acbFile}\"", ConsoleColor.Green);
                    SystemSounds.Exclamation.Play();
                }
                //).Start();
            }
            else
                Output.Log($"[ERROR] ACB repack failed, extracted archive directory doesn't exist: \"{acbDir}\"", ConsoleColor.Red);
        }
    }
}
