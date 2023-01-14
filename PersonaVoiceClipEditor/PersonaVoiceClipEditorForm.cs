using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using NAudio.Wave;
using Microsoft.WindowsAPICodePack.Dialogs;
using ShrineFox.IO;
using System.Security.Cryptography;
using DarkUI.Controls;
using AFSLib;
using AcbEditor;

namespace PersonaVoiceClipEditor
{
    public partial class PersonaVoiceClipEditorForm : Form
    {
        public static List<string> supportedFormats = new List<string> { ".adx", ".hca", ".wav" };
        public static List<string> supportedArchives = new List<string> { ".acb", ".afs" };
        public static List<string> presets = new List<string> { "None",
            "P5R (PC/Switch)",
            "P5R (ENG PS4)",
            "P5R (JP PS4)",
            "P5 (PS3)",
            "P3/4" };

        public PersonaVoiceClipEditorForm()
        {
            InitializeComponent();
            // Set up log
            Output.Logging = true;
            Output.LogControl = rtb_Log;
#if DEBUG
            Output.VerboseLogging = true;
#endif
            // Set up dropdown lists
            foreach (var item in supportedFormats)
                dropDownList_OutFormat.Items.Add(new DarkDropdownItem() { Text = item });
            foreach (var item in supportedArchives)
                dropDownList_ArchiveFormat.Items.Add(new DarkDropdownItem() { Text = item });
            foreach (var item in presets)
                dropDownList_Preset.Items.Add(new DarkDropdownItem() { Text = item });

            // Load settings from settings.yml
            LoadSettings();
            // Allow settings.yml to be updated by user changes
            updateSettings = true;
        }

        private void Encode()
        {
            string inputDir = txt_InputDir.Text;

            if (Directory.Exists(inputDir))
            {
                string outputDir = txt_OutputDir.Text;
                bool createdOutputDir = RecreateDirectory(outputDir);
                if (!createdOutputDir)
                    return;
                string outFormat = dropDownList_OutFormat.SelectedItem.Text;
                Output.Log($"[INFO] Encoding supported files in directory \"{inputDir}\" to format \"{outFormat}\" and outputting to directory: \"{outputDir}\"");

                // Convert files to target format, output to specified directory
                foreach (var file in Directory.GetFiles(inputDir).Where(x => supportedFormats.Any(y => y.Equals(Path.GetExtension(x.ToLower())))))
                {
                    bool encrypted = false;
                    string extension = Path.GetExtension(file).ToLower();
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

                    if (chk_UseEncKey.Checked && txt_Key.Text != "" && txt_Key.Enabled)
                        args += $" --keycode {txt_Key.Text}";

                    Output.VerboseLog($"[INFO] Encoding \"{Path.GetFileName(file)}\" to \"{Path.GetFileName(outPath)}\"...");
                    Exe.Run(".\\Dependencies\\VGAudio.exe", args);
                    if (File.Exists(outPath))
                    {
                        if (outFormat == ".adx")
                        {
                            using (FileStream fs = new FileStream(outPath, FileMode.Open))
                            {
                                using (BinaryWriter writer = new BinaryWriter(fs))
                                {
                                    writer.BaseStream.Position = 19;
                                    byte newByte = Convert.ToByte(9);
                                    if (args.Contains("--keycode") && encrypted)
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
                Output.Log($"[INFO] Done encoding {dropDownList_OutFormat.Text} files to directory: \"{txt_OutputDir.Text}\"", ConsoleColor.Green);
            }
            else
                Output.Log($"[ERROR] Encoding failed, input directory doesn't exist: \"{txt_InputDir.Text}\"", ConsoleColor.Red);

        }

        private void Rename()
        {
            string txtFile = txt_TxtFile.Text;

            if (File.Exists(txtFile))
            {
                // Delete and recreate output directory
                string outFolder = txt_RenameOutput.Text;
                bool createDir = RecreateDirectory(outFolder);
                if (!createDir)
                    return;

                Output.Log($"[INFO] Copying and renaming files based on order of filenames in: \"{txtFile}\"");

                // Re-order based on .txt file
                int i = 0;
                foreach (var line in File.ReadLines(txtFile))
                {
                    var files = Directory.GetFiles(txt_RenameDir.Text);
                    // If file found, copy to output folder with new name
                    if (files.Any(x => Path.GetFileNameWithoutExtension(x).Equals(line.Trim())))
                    {
                        var file = files.Single(x => Path.GetFileNameWithoutExtension(x).Equals(line.Trim()));
                        var ext = Path.GetExtension(file);
                        string outPath = Path.Combine(outFolder, $"{i.ToString().PadLeft(Convert.ToInt32(num_Padding.Value), '0')}{txt_Suffix}");
                        File.Copy(file, outPath);
                        Output.VerboseLog($"[INFO] Copied \"{file}\" to:\n\t\"{outPath}\"", ConsoleColor.Green);
                    }
                    else
                        Output.VerboseLog($"[WARNING] File with name \"{line}\" not found in directory \"{txt_RenameDir.Text}\", " +
                            $"skipping index {i}.", ConsoleColor.Yellow);
                    i++;
                }
                Output.Log($"[INFO] Done copying and renaming files to: \"{outFolder}\"", ConsoleColor.Green);
            }
            else
                Output.Log($"[ERROR] Rename failed, could not find file: \"{txtFile}\"", ConsoleColor.Red);

        }

        private void UnpackArchive()
        {
            string archive = txt_InputArchive.Text;
            if (File.Exists(archive))
            {
                if (Path.GetExtension(archive).ToLower() == ".afs")
                    ExtractAFS(archive);
                else if (Path.GetExtension(archive).ToLower() == ".acb")
                    ExtractACB(archive);
                else
                    Output.Log($"[ERROR] Could not extract archive, not a supported format: \"{archive}\"", ConsoleColor.Red);
            }
            else
                Output.Log($"[ERROR] Could not unpack archive, file doesn't exist: \"{archive}\"", ConsoleColor.Red);
        }

        private void RepackArchive()
        {
            string archiveDir = txt_ArchiveDir.Text;
            if (Directory.Exists(archiveDir))
            {
                if (dropDownList_ArchiveFormat.SelectedItem.Text == ".afs")
                    RepackAFS(archiveDir);
                else if (dropDownList_ArchiveFormat.SelectedItem.Text == ".acb")
                    RepackACB(archiveDir);
                else
                    Output.Log($"[ERROR] Could not repack archive, not a supported format: \"{dropDownList_ArchiveFormat.Text}\"", ConsoleColor.Red);
            }
            else
                Output.Log($"[ERROR] Could not repack archive, directory doesn't exist: \"{archiveDir}\"", ConsoleColor.Red);
        }

        private void ExtractAFS(string afsPath)
        {
            string outputDir = txt_ArchiveDir.Text;

            if (File.Exists(afsPath))
            {
                // Prompt user to recreate output directory
                if (!RecreateDirectory(outputDir))
                    return;

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

                Output.Log($"[INFO] Done extracting archive contents to: \"{outputDir}\"", ConsoleColor.Green);
            }
            else
                Output.Log($"[ERROR] AFS extraction failed, input archive doesn't exist: \"{afsPath}\"", ConsoleColor.Red);
        }

        private void RepackAFS(string afsDir)
        {
            string outputFile = txt_OutputArchive.Text;
            
            if (Directory.Exists(afsDir))
            {
                // Get input files from AFS directory
                List<string> files = Directory.GetFiles(afsDir).ToList();

                // Create new AFS
                using (AFS afs = new AFS())
                {
                    for (int i = 0; i < files.Count; i++)
                    {
                        FileEntry entry = afs.AddEntryFromFile(files[i], i + Path.GetExtension(files[i]));
                        entry.UnknownAttribute = 7;
                        Output.VerboseLog($"[INFO] Added entry to AFS: \"{files[i]}\"");
                    }
                    afs.SaveToFile(outputFile);
                }

                Output.Log($"[INFO] Done creating AFS archive at: \"{outputFile}\"", ConsoleColor.Green);
            }
            else
                Output.Log($"[ERROR] AFS repack failed, extracted archive directory doesn't exist: \"{afsDir}\"", ConsoleColor.Red);
        }

        private void ExtractACB(string acbPath)
        {
            string outputDir = txt_ArchiveDir.Text;

            if (File.Exists(acbPath))
            {
                // Prompt user to recreate output directory
                if (!RecreateDirectory(outputDir))
                    return;

                // Extract ADX from ACB
                AcbEditor.Program.Main(new string[] { acbPath });

                // Move Files to Output Dir from Temp Path
                string acbDir = Path.Combine(Path.GetDirectoryName(acbPath), Path.GetFileNameWithoutExtension(acbPath));
                if (Directory.Exists(acbDir) && Directory.GetFiles(acbDir).Count() > 0)
                {
                    FileSys.CopyDir(acbDir, outputDir);
                    Directory.Delete(acbDir, true);
                    Output.Log($"[INFO] Done extracting archive contents to: \"{outputDir}\"", ConsoleColor.Green);
                }
                else
                {
                    Output.Log($"[ERROR] No files were extracted from ACB: \"{acbPath}\"", ConsoleColor.Red);
                    if (Directory.Exists(acbDir))
                        Directory.Delete(acbDir);
                }
            }
            else
                Output.Log($"[ERROR] ACB extract failed, input archive doesn't exist: \"{acbPath}\"", ConsoleColor.Red);

        }

        private void RepackACB(string acbDir)
        {
            string outputFile = txt_OutputArchive.Text;
            string outputDir = Path.GetDirectoryName(outputFile);
            string acbFile = txt_InputArchive.Text;
            string awbFile = acbFile.Replace(".acb",".awb");

            if (File.Exists(acbFile))
            {
                if (File.Exists(awbFile))
                {
                    if (Directory.Exists(acbDir))
                    {
                        // Prompt user to recreate output directory
                        if (!RecreateDirectory(outputDir))
                            return;

                        // Copy input files to output dir
                        string newAcbName = Path.Combine(outputDir, Path.GetFileName(outputFile));
                        string newAwbName = Path.Combine(outputDir, Path.GetFileNameWithoutExtension(outputFile) + ".awb");
                        File.Copy(acbFile, newAcbName, true);
                        File.Copy(awbFile, newAwbName, true);
                        // Copy extracted dir to temp output dir named after acb
                        string extDirCopy = Path.Combine(outputDir, Path.GetFileNameWithoutExtension(outputFile));
                        FileSys.CopyDir(acbDir, extDirCopy);
                        // Repack ACB
                        Output.Log($"[INFO] Repacking ACB/AWB file with files from: \"{acbDir}\"");
                        AcbEditor.Program.Main(new string[] { extDirCopy });
                        // Delete temp output dir
                        if (Directory.Exists(extDirCopy))
                            Directory.Delete(extDirCopy, true);
                        Output.Log($"[INFO] Done repacking AFS archive at: \"{newAcbName}\"", ConsoleColor.Green);
                    }
                    else
                        Output.Log($"[ERROR] ACB repack failed, extracted archive directory doesn't exist: \"{acbDir}\"", ConsoleColor.Red);
                }
                else
                    Output.Log($"[ERROR] ACB repack failed, original AWB doesn't exist: \"{awbFile}\"", ConsoleColor.Red);
            }
            else
                Output.Log($"[ERROR] ACB repack failed, original ACB doesn't exist: \"{acbFile}\"", ConsoleColor.Red);
        }

        
    }
}
