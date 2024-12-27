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
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

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
            Output.LogControl = rtb_Log;

#if DEBUG
            Output.VerboseLogging = true;
#endif
        }

        private void StartEncode(string[] inputFiles)
        {
            if (inputFiles.Length == 0 || string.IsNullOrEmpty(inputFiles[0]))
                return;

            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;

                Output.Log($"[INFO] Encoding supported files to format \"{settings.OutFormat}\".");

                string outputDir = FileSys.CreateUniqueDir(Path.Combine(Path.GetDirectoryName(inputFiles[0]), "Encoded"));

                // Convert files to target format, output to specified directory
                foreach (var file in inputFiles.Where(x => supportedFormats.Any(y => y.Equals(Path.GetExtension(x.ToLower())))))
                {
                    EncodeFile(file, outputDir);
                }

                SystemSounds.Exclamation.Play();
            }).Start();
            Output.Log($"[INFO] Done encoding files to \"{comboBox_SoundFormat.SelectedItem}\".", ConsoleColor.Green);
        }

        private void EncodeFile(string inputFile, string outputDir)
        {
            string ogInputFile = inputFile;
            string inputExtension = Path.GetExtension(inputFile).ToLower();

            string vgAudioPath = Path.Combine(Exe.Directory(), "Dependencies\\VGAudio.exe");
            string args = $"\"{inputFile}\"";

            // If volume does not equal 1.0, convert to WAV and adjust volume
            string tempAdx = Path.Combine(outputDir, Path.GetFileNameWithoutExtension(inputFile) + "_temp.adx");
            string tempWav = Path.Combine(outputDir, Path.GetFileNameWithoutExtension(inputFile) + "_temp.wav");
            string volAdjustedWav = Path.Combine(outputDir, Path.GetFileNameWithoutExtension(inputFile) + ".wav");

            if (Convert.ToSingle(num_Volume.Value) != 1.0f)
            {
                if (inputExtension == ".adx")
                {
                    // If ADX is encrypted, remove encryption using keycode
                    if (num_EncryptionKey.Value == 0 || CheckADXEncryption(inputFile))
                    {
                        args = $"\"{inputFile}\" \"{tempAdx}\" --keycode {num_EncryptionKey.Value}";

                        Output.Log("Decrypting temporary ADX...", ConsoleColor.Yellow);
                        Output.VerboseLog(args);
                        Exe.Run(vgAudioPath, args);
                        using (FileSys.WaitForFile(tempAdx)) { };

                        // Set input file to decrypted ADX
                        inputFile = tempAdx;
                    }

                    // Create temporary WAV from input ADX
                    args = $"\"{inputFile}\" \"{tempWav}\"";

                    Output.Log($"Creating temp WAV: \"{tempWav}\"", ConsoleColor.Yellow);
                    Output.VerboseLog(args);
                    Exe.Run(vgAudioPath, args);
                    using (FileSys.WaitForFile(tempWav)) { };

                    // Delete temp ADX if it was made from a separate input file
                    if (tempAdx != ogInputFile && File.Exists(tempAdx))
                    {
                        Output.Log($"Deleting temporary ADX: \"{tempAdx}\"", ConsoleColor.Yellow);
                        File.Delete(tempAdx);
                    }

                    // Use temp WAV as input file
                    inputFile = tempWav;
                }

                // Change temp WAV volume and output as new WAV
                using (var wavReader = new AudioFileReader(inputFile))
                {
                    wavReader.Volume = Convert.ToSingle(num_Volume.Value);
                    SampleChannel channel = new SampleChannel(wavReader);
                    WaveFileWriter.CreateWaveFile16(volAdjustedWav, channel);
                    Output.Log($"Created volume adjusted WAV: \"{volAdjustedWav}\"", ConsoleColor.Yellow);
                }

                using (FileSys.WaitForFile(volAdjustedWav)) { };
                // Delete non-volume adjusted WAV if it was made from a separate input file
                if (tempWav != ogInputFile && File.Exists(tempWav))
                {
                    Output.Log($"Deleting temporary WAV: \"{tempWav}\"", ConsoleColor.Yellow);
                    File.Delete(tempWav);
                }

                // Set input file to volume adjusted WAV
                inputFile = volAdjustedWav;
                args = $"\"{inputFile}\"";
            }

            string outPath = Path.Combine(outputDir, Path.GetFileNameWithoutExtension(ogInputFile) + settings.OutFormat);
            args += $" \"{outPath}\"";

            // If file is encrypted and user wants output decrypted, use keycode to decrypt.
            // Otherwise, output will be encrypted using keycode as long as it's not 0.
            if (num_EncryptionKey.Value != 0 && CheckADXEncryption(inputFile) && settings.Decrypt ||
                num_EncryptionKey.Value != 0 && !CheckADXEncryption(inputFile) && !settings.Decrypt)
                args += $" --keycode {num_EncryptionKey.Value}";

            // If loops are specified, use loops
            if (settings.UseLoops)
            {
                string loopArgs = " -l";

                if (settings.LoopAll)
                    loopArgs += $" 0-{GetSampleCount(ogInputFile) - 1}";
                else
                {
                    if (inputExtension == ".adx" && settings.UseExistingLoop)
                    {
                        var loopPoints = GetADXLoopPoints(ogInputFile);
                        loopArgs += $" {Convert.ToInt32(loopPoints.Item1)}-{Convert.ToInt32(loopPoints.Item2)}";
                    }
                    else
                        loopArgs += $" {Convert.ToInt32(settings.LoopStart)}-{Convert.ToInt32(settings.LoopEnd)}";
                }

                args += loopArgs;
            }

            Output.Log($"[INFO] Encoding \"{Path.GetFileName(inputFile)}\" to \"{Path.GetFileName(outPath)}\"...");
            Output.VerboseLog(args);
            Exe.Run(vgAudioPath, args);
            using (FileSys.WaitForFile(outPath)) { };
            
            // Delete volume adjusted WAV
            if (File.Exists(volAdjustedWav) && outPath != volAdjustedWav)
            {
                Output.Log($"Deleting volume-adjusted WAV: \"{volAdjustedWav}\"", ConsoleColor.Yellow);
                File.Delete(volAdjustedWav);
            }

            // Set ADX Type 9 encryption flag if output file exists and is encrypted
            if (File.Exists(outPath))
            {
                if (settings.OutFormat == ".adx" && !settings.Decrypt && num_EncryptionKey.Value != 0)
                    SetADXEncryptionFlag(outPath);
                Output.Log($"[INFO] Encoded file successfully!", ConsoleColor.DarkGreen);
            }
            else
                Output.Log($"[INFO] Failed to encode file: \"{inputFile}\"", ConsoleColor.DarkRed);
        }

        private Tuple<int, int> GetADXLoopPoints(string file)
        {
            Tuple<int, int> loopPoints = new Tuple<int, int>(0, 0);

            using (FileStream fs = new FileStream(file, FileMode.Open))
            {
                using (EndianBinaryReader reader = new EndianBinaryReader(fs, Endianness.BigEndian))
                {
                    reader.BaseStream.Position = 34;

                    if (reader.ReadByte() == Convert.ToByte(0)
                        && reader.ReadByte() == Convert.ToByte(1))
                    {
                        reader.BaseStream.Position = 40;
                        var startSample = reader.ReadInt32();

                        reader.BaseStream.Position = 48;
                        var endSample = reader.ReadInt32();

                        loopPoints = new Tuple<int, int>(startSample, endSample);
                    }
                }
            }

            return loopPoints;
        }

        private bool CheckADXEncryption(string file)
        {
            if (Path.GetExtension(file).ToLower() == ".wav")
                return false;

            using (FileStream fs = new FileStream(file, FileMode.Open))
            {
                using (BinaryReader reader = new BinaryReader(fs))
                {
                    reader.BaseStream.Position = 19;

                    if (reader.ReadByte() == Convert.ToByte(9))
                        return true;

                    return false;
                }
            }
        }

        private void SetADXEncryptionFlag(string outPath, bool encryptType9 = true)
        {
            using (FileStream fs = new FileStream(outPath, FileMode.Open))
            {
                using (BinaryWriter writer = new BinaryWriter(fs))
                {
                    // Add encryption flag to adx file if using keycode
                    writer.BaseStream.Position = 19;
                    byte newByte = Convert.ToByte(9);
                    // Remove encryption flag if decrypting
                    if (!encryptType9)
                        newByte = Convert.ToByte(0);
                    Output.VerboseLog($"[INFO] Setting encryption byte to: {newByte.ToString("x2")}");
                    writer.Write(newByte);
                };
            }
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
            int i = Convert.ToInt32(settings.StartIndex);
            foreach (var line in lines)
            {
                string[] splitLine = line.Split('\t');
                dgv_RenameTxt.Rows.Add(i, splitLine[0]);
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
                var files = Directory.GetFiles(settings.RenameDir);
                for (int i = 0; i < settings.DGVCells.Count; i++)
                {
                    // Add input file paths to each adx entry that matches wave ID and cue type
                    if (files.Any(x => Path.GetFileNameWithoutExtension(x).Equals(settings.DGVCells[i])))
                    {
                        foreach (var adx in AdxFiles.Where(x => x.WaveID == (Convert.ToInt32(settings.StartIndex) + i)
                            && x.Streaming == settings.RyoStreaming))
                            adx.Path = files.First(x => Path.GetFileNameWithoutExtension(x).Equals(settings.DGVCells[i]));
                    }
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
                    Output.VerboseLog($"[INFO] Copied \"{adx.Path}\" to:\n\t\"{outFile}\"", ConsoleColor.Green);
                    // Encode to ADX
                    if (settings.EncodeRenameOutput)
                        EncodeAndDelete(outFile);

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

                        // Encode to ADX
                        if (settings.EncodeRenameOutput)
                            EncodeAndDelete(outPath);
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

        private void EncodeAndDelete(string outPath)
        {
            if (File.Exists(outPath) && Path.GetExtension(outPath).ToLower() == ".wav")
            {
                EncodeFile(outPath, Path.GetDirectoryName(outPath));
                using (FileSys.WaitForFile(outPath)) { };
                File.Delete(outPath);
            }
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
                {
                    Output.Log($"[ERROR] Could not extract archive, not a supported format: \"{archivePath}\"", ConsoleColor.Red);
                    return;
                }

                if (chk_RepackArchiveSilenced.Checked)
                    RepackArchiveSilenced(archivePath);
            }
            else
                Output.Log($"[ERROR] Could not unpack archive, file doesn't exist: \"{archivePath}\"", ConsoleColor.Red);
        }

        private void RepackArchiveSilenced(string archivePath)
        {
            string archiveDir = "";
            bool isAcb = true;

            if (Path.GetExtension(archivePath).ToLower() == ".afs")
            {
                isAcb = false;
                archiveDir += "_extracted";
            }
            else
                archiveDir = Path.Combine(Path.GetDirectoryName(archivePath), Path.GetFileNameWithoutExtension(archivePath));

            FileSys.WaitForDirectory(archiveDir);
            if (!Directory.Exists(archiveDir))
                return;

            foreach (var file in Directory.GetFiles(archiveDir))
            {
                using (FileSys.WaitForFile(file)) { };
                string silentAdx = Path.Combine(Exe.Directory(), "Dependencies/silence.adx");
                File.Copy(silentAdx, file, true);
            }

            foreach (var file in Directory.GetFiles(archiveDir))
            {
                using (FileSys.WaitForFile(file)) { };
            }
            FileSys.WaitForDirectory(archiveDir);

            using (FileSys.WaitForFile(archivePath)) { };

            if (isAcb)
                RepackACB(archiveDir);
            else
                RepackAFS(archiveDir);
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

                new Thread(() =>
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
                ).Start();
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
                new Thread(() =>
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
                ).Start();
                Output.Log($"[INFO] Done creating AFS archive at: \"{outputFile}\"", ConsoleColor.Green);
            }
            else
                Output.Log($"[ERROR] AFS repack failed, extracted archive directory doesn't exist: \"{afsDir}\"", ConsoleColor.Red);
        }

        private void ExtractACB(string acbPath)
        {
            if (File.Exists(acbPath))
            {
                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;

                    // Extract ADX from ACB
                    // In order to make this workk, make AcbEditor Program procedure public
                    // and add return; to start of OnProgressChanged()
                    AcbEditor.Program.Main(new string[] { acbPath });
                    Output.Log($"[INFO] Done extracting archive contents from: \"{acbPath}\"", ConsoleColor.Green);
                    
                    SystemSounds.Exclamation.Play();
                }
                ).Start();
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
                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;

                    // Repack ACB
                    Output.Log($"[INFO] Repacking ACB/AWB file with files from: \"{acbDir}\"");
                    // In order to make this workk, make AcbEditor Program procedure public
                    // and add return; to start of OnProgressChanged()
                    AcbEditor.Program.Main(new string[] { acbDir });
                    Output.Log($"[INFO] Done repacking ACB archive: \"{acbFile}\"", ConsoleColor.Green);
                    SystemSounds.Exclamation.Play();
                }
                ).Start();
            }
            else
                Output.Log($"[ERROR] ACB repack failed, extracted archive directory doesn't exist: \"{acbDir}\"", ConsoleColor.Red);
        }

        private static int Clamp(int value, int min, int max)
        {
            if (value < min) return min;
            if (value > max) return max;
            return value;
        }

        public static bool ChangeVolume(string inputFilePath, string outputFilePath, float volumeFactor)
        {
            if (volumeFactor < 0)
            {
                Output.Log($"[ERROR] Volume change failed, volume factor must be a non-negative number.", ConsoleColor.Red);
                return false;
            }

            using (var inputFile = new FileStream(inputFilePath, FileMode.Open, FileAccess.Read))
            using (var outputFile = new FileStream(outputFilePath, FileMode.Create, FileAccess.Write))
            using (var reader = new BinaryReader(inputFile))
            using (var writer = new BinaryWriter(outputFile))
            {
                // Read WAV header (first 44 bytes)
                byte[] header = reader.ReadBytes(44);
                writer.Write(header);

                // Determine bit depth from header (e.g., 16-bit, 24-bit, etc.)
                int bitsPerSample = BitConverter.ToInt16(header, 34);
                int bytesPerSample = bitsPerSample / 8;

                if (bytesPerSample != 2)
                {
                    Output.Log($"[ERROR] Volume change failed, only 16-bit PCM WAV files are supported..", ConsoleColor.Red);
                    return false;
                }

                // Process audio data
                while (reader.BaseStream.Position < reader.BaseStream.Length)
                {
                    // Read a sample (16-bit signed integer)
                    short sample = reader.ReadInt16();

                    // Adjust the sample by the volume factor
                    int newSample = (int)(sample * volumeFactor);

                    // Clamp to avoid overflow
                    newSample = Clamp(newSample, short.MinValue, short.MaxValue);

                    // Write the adjusted sample
                    writer.Write((short)newSample);
                }
            }

            if (File.Exists(outputFilePath))
            {
                Output.Log($"[INFO] Volume change succeeded: \"{outputFilePath}\"", ConsoleColor.Green);
                return true;
            }

            return false;
        }
    }
}
