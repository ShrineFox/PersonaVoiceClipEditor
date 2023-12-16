﻿using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading;
using ShrineFox.IO;
using DarkUI.Controls;
using AFSLib;
using System.Media;
using MetroSet_UI.Forms;
using System.Windows.Forms;

namespace PersonaVCE
{
    public partial class PersonaVCE : MetroSetForm
    {
        public static List<string> supportedFormats = new List<string> { ".adx", ".hca" };
        public static List<string> supportedArchives = new List<string> { ".acb", ".afs" };
        public static List<string> presets = new List<string> { "None",
            "P5R (PC/Switch)",
            "P5R (ENG PS4)",
            "P5R (JP PS4)",
            "P5 (PS3)",
            "P3/4" };

        public PersonaVCE()
        {
            InitializeComponent();

            SetupLogging();
            SetupDropdowns();
            SetupTheme();

            LoadSettings();
            // Allow settings.yml to be updated by user changes
            updateSettings = true;
        }

        private void SetupTheme()
        {
            Theme.ThemeStyle = MetroSet_UI.Enums.Style.Dark;
            Theme.ApplyToForm(this);
        }

        private void SetupDropdowns()
        {
            comboBox_SoundFormat.ComboBox.DataSource = supportedFormats;
            comboBox_SoundFormat.ComboBox.BindingContext = this.BindingContext;

            comboBox_ArchiveFormat.ComboBox.BindingContext = this.BindingContext;
            comboBox_ArchiveFormat.ComboBox.DataSource = supportedArchives;

            comboBox_EncryptionPreset.ComboBox.DataSource = presets;
            comboBox_EncryptionPreset.ComboBox.BindingContext = this.BindingContext;
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
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;

                if (outFormat == "")
                    outFormat = comboBox_SoundFormat.SelectedText;
                Output.Log($"[INFO] Encoding supported files to format \"{outFormat}\".");

                // Convert files to target format, output to specified directory
                foreach (var file in inputFiles.Where(x => supportedFormats.Any(y => y.Equals(Path.GetExtension(x.ToLower())))))
                {
                    string outputDir = FileSys.CreateUniqueDir(Path.Combine(Path.GetDirectoryName(file), "Encoded"));
                    
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
                        args += $" -l {Convert.ToInt32(num_LoopStart.Value)}-{Convert.ToInt32(num_LoopEnd.Value)}";
                    }

                    Output.VerboseLog($"[INFO] Encoding \"{Path.GetFileName(file)}\" to \"{Path.GetFileName(outPath)}\"...");
                    Exe.Run(".\\VGAudio.exe", args);
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
                Output.Log($"[INFO] Done encoding {comboBox_SoundFormat.Text} files.", ConsoleColor.Green);

                SystemSounds.Exclamation.Play();
            }).Start();
            
        }

        private void Rename()
        {
            if (Directory.Exists(settings.RenameDir))
            {
                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;

                    // Delete and recreate output directory
                    string outFolder = settings.RenameOutDir;
                    Directory.CreateDirectory(outFolder);

                    Output.Log($"[INFO] Copying and renaming files based on order of filenames in: \"{settings.TxtFile}\"");

                    // Re-order based on .txt file
                    int i = Convert.ToInt32(num_StartID.Value);

                    var files = Directory.GetFiles(settings.RenameDir);
                    foreach (DataGridViewRow row in dgv_RenameTxt.Rows)
                    {
                        string fileName = Path.GetFileNameWithoutExtension(row.Cells[0].Value.ToString().Trim());
                        // If file found, copy to output folder with new name
                        if (files.Any(x => Path.GetFileNameWithoutExtension(x).Equals(fileName)))
                        {
                            var file = files.First(x => Path.GetFileNameWithoutExtension(x).Equals(fileName));
                            var ext = Path.GetExtension(file);
                            string outPath = Path.Combine(outFolder, $"{i.ToString().PadLeft(Convert.ToInt32(num_LeftPadding.Value), '0')}{txt_RenameSuffix.Text}");

                            if (chk_AppendOGName.Checked)
                                outPath += $"_{Path.GetFileNameWithoutExtension(file)}";
                            outPath += Path.GetExtension(file);

                            // Delete existing file
                            if (File.Exists(outPath))
                            {
                                Output.VerboseLog($"[INFO] Deleting existing file at output path: {outPath}");
                                File.Delete(outPath);
                                using (FileSys.WaitForFile(outPath)) { };
                            }
                            // Copy to output path once available
                            File.Copy(file, outPath, true);
                            Output.VerboseLog($"[INFO] Copied \"{file}\" to:\n\t\"{outPath}\"", ConsoleColor.Green);
                        }
                        else
                            Output.VerboseLog($"[WARNING] File with name \"{fileName}\" not found in directory \"{settings.RenameDir}\", " +
                                $"skipping index {i}.", ConsoleColor.Yellow);
                        i++;
                    }
                    Output.Log($"[INFO] Done copying and renaming files to: \"{outFolder}\"", ConsoleColor.Green);
                    SystemSounds.Exclamation.Play();
                }).Start();
            }
            else
                Output.Log($"[ERROR] Rename failed, could not find file: \"{settings.RenameDir}\"", ConsoleColor.Red);

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
                if (comboBox_ArchiveFormat.SelectedText == ".afs")
                    RepackAFS(folderPath);
                else if (comboBox_ArchiveFormat.SelectedText == ".acb")
                    RepackACB(folderPath);
                else
                    Output.Log($"[ERROR] Could not repack archive, not a supported format: \"{comboBox_ArchiveFormat.Text}\"", ConsoleColor.Red);
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
                }).Start();
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
                }).Start();
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
                    AcbEditor.Program.Main(new string[] { acbPath });
                    Output.Log($"[INFO] Done extracting archive contents from: \"{acbPath}\"", ConsoleColor.Green);
                    
                    SystemSounds.Exclamation.Play();
                }).Start();
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
                    AcbEditor.Program.Main(new string[] { acbDir });
                    Output.Log($"[INFO] Done repacking ACB archive: \"{acbFile}\"", ConsoleColor.Green);
                    SystemSounds.Exclamation.Play();
                }).Start();
            }
            else
                Output.Log($"[ERROR] ACB repack failed, extracted archive directory doesn't exist: \"{acbDir}\"", ConsoleColor.Red);
        }
    }
}
