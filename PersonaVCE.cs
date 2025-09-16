using AFSLib;
using MetroSet_UI.Forms;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using ShrineFox.IO;
using SonicAudioLib.IO;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Media;
using System.Threading;
using System.Windows.Forms;
using VGAudio.Codecs.CriAdx;
using VGAudio.Codecs.CriHca;
using VGAudio.Containers;
using VGAudio.Containers.Adx;
using VGAudio.Containers.Hca;
using VGAudio.Containers.Wave;
using VGAudio.Formats;
using VGAudio.Formats.Pcm16;

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

        public static MemoryStream LoadWavInMemory(string inputPath, float volumeFactor = 1.0f)
        {
            var memoryStream = new MemoryStream();

            using (var reader = new AudioFileReader(inputPath))
            {
                var sampleProvider = new VolumeSampleProvider(reader)
                {
                    Volume = volumeFactor
                };

                WaveFileWriter.WriteWavFileToStream(memoryStream, sampleProvider.ToWaveProvider16());
            }

            // Reset position so it can be read again
            memoryStream.Position = 0;

            return memoryStream;
        }

        private void EncodeFile(string inputFile, string outputDir)
        {
            float volume = Convert.ToSingle(num_Volume.Value);
            string outPath = Path.Combine(outputDir, Path.GetFileNameWithoutExtension(inputFile) + settings.OutFormat);
            Directory.CreateDirectory(Path.GetDirectoryName(outPath));

            AudioData audio;

            // Read audio data from input file
            switch (Path.GetExtension(inputFile))
            {
                case ".wav":
                    var wavReader = new WaveReader();
                    audio = wavReader.Read(LoadWavInMemory(inputFile, volume));
                    break;
                case ".adx":
                    var adxReader = new AdxReader();
                    if (num_EncryptionKey.Value != 0)
                        adxReader.EncryptionKey = new CriAdxKey((ulong)num_EncryptionKey.Value);
                    audio = AdjustVolumeInMemory(adxReader.Read(File.ReadAllBytes(inputFile)), volume);
                    break;
                case ".hca":
                    var hcaReader = new HcaReader();
                    if (num_EncryptionKey.Value != 0)
                        hcaReader.EncryptionKey = new CriHcaKey((ulong)num_EncryptionKey.Value);
                    audio = AdjustVolumeInMemory(hcaReader.Read(File.ReadAllBytes(inputFile)), volume);
                    break;
                default:
                    return;
            }

            // Write to output file in selected format
            switch (settings.OutFormat)
            {
                case ".wav":
                    using (var fs = File.Create(outPath))
                    {
                        var wavWriter = new WaveWriter();
                        wavWriter.WriteToStream(audio, fs);
                    }
                    break;
                case ".adx":
                    SetLoopsForAudioData(audio);
                    using (var fs = File.Create(outPath))
                    {
                        var adxWriter = new AdxWriter();
                        adxWriter.Configuration = new AdxConfiguration();

                        if (num_EncryptionKey.Value != 0)
                        {
                            adxWriter.Configuration.EncryptionType = 9;
                            adxWriter.Configuration.EncryptionKey = new CriAdxKey((ulong)num_EncryptionKey.Value);
                        }

                        adxWriter.WriteToStream(audio, fs);
                    }
                    break;
                case ".hca":
                    SetLoopsForAudioData(audio);
                    using (var fs = File.Create(outPath))
                    {
                        var hcaWriter = new HcaWriter();
                        hcaWriter.Configuration = new HcaConfiguration();
                        // Encrypt if encryption key isn't 0
                        if (num_EncryptionKey.Value != 0)
                        {
                            hcaWriter.Configuration.EncryptionKey = new CriHcaKey((ulong)num_EncryptionKey.Value);
                        }

                        hcaWriter.WriteToStream(audio, fs);
                    }
                    break;
                default:
                    return;
            }

            if (File.Exists(outPath))
                Output.Log($"[INFO] Encoded {Path.GetFileName(outPath)} successfully!", ConsoleColor.DarkGreen);
            else
                Output.Log($"[INFO] Failed to encode {outPath}", ConsoleColor.DarkRed);
        }

        private void SetLoopsForAudioData(AudioData audio)
        {
            if (chk_UseLoopPoints.Checked)
            {
                if (!chk_UseExistingLoop.Checked)
                {
                    if (chk_LoopAll.Checked)
                        audio.SetLoop(true);
                    else if ((long)num_LoopStart.Value != 0 || (long)num_LoopEnd.Value != 0)
                        audio.SetLoop(true, Convert.ToInt32(num_LoopStart.Value), Convert.ToInt32(num_LoopEnd.Value));
                }
            }
            else
                audio.SetLoop(false);
        }

        private AudioData AdjustVolumeInMemory(AudioData audio, float volume)
        {
            var pcm = audio.GetFormat<Pcm16Format>();
            short[][] samples = pcm.Channels;
            for (int ch = 0; ch < samples.Length; ch++)
            {
                var arr = samples[ch];
                for (int i = 0; i < arr.Length; i++)
                {
                    int scaled = (int)Math.Round(arr[i] * volume);

                    // Hard clip to Int16 range
                    if (scaled > short.MaxValue) scaled = short.MaxValue;
                    if (scaled < short.MinValue) scaled = short.MinValue;

                    arr[i] = (short)scaled;
                }
            }
            
            return new AudioData(pcm);
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
                    if (files.Any(x => Path.GetFileNameWithoutExtension(x).Equals(Path.GetFileNameWithoutExtension(settings.DGVCells[i]))))
                    {
                        foreach (var adx in AdxFiles.Where(x => x.WaveID == (Convert.ToInt32(settings.StartIndex) + i)
                            && x.Streaming == settings.RyoStreaming))
                            adx.Path = files.First(x => Path.GetFileNameWithoutExtension(x).Equals(Path.GetFileNameWithoutExtension(settings.DGVCells[i])));
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
                    // In order to make this work, make AcbEditor Program procedure public
                    // and add return; to start of OnProgressChanged()
                    // to prevent "Invalid Handle" error due to no Console window
                    AcbEditor.Program.Main(new string[] { acbDir });
                    Output.Log($"[INFO] Done repacking ACB archive: \"{acbFile}\"", ConsoleColor.Green);
                    SystemSounds.Exclamation.Play();
                }
                ).Start();
            }
            else
                Output.Log($"[ERROR] ACB repack failed, extracted archive directory doesn't exist: \"{acbDir}\"", ConsoleColor.Red);
        }
    }
}
