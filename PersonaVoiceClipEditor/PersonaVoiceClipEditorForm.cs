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

namespace PersonaVoiceClipEditor
{
    public partial class PersonaVoiceClipEditorForm : Form
    {
        public static List<string> supportedFormats = new List<string> { ".adx", ".hca", ".wav" };
        public static List<string> supportedArchives = new List<string> { ".acb", ".afs" };

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
            comboBox_OutFormat.DataSource = supportedFormats;
            comboBox_OutFormat.SelectedIndex = 0;
            comboBox_ArchiveFormat.DataSource = supportedArchives;
            comboBox_ArchiveFormat.SelectedIndex = 0;
            comboBox_Preset.SelectedIndex = 0;
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
                string outFormat = comboBox_OutFormat.Text;
                Output.Log($"[INFO] Encoding supported files in directory \"{inputDir}\" to format \"{outFormat}\" and outputting to directory: \"{outputDir}\"");

                // Convert files to target format, output to specified directory
                foreach (var file in Directory.GetFiles(inputDir).Where(x => supportedFormats.Any(y => y.Equals(Path.GetExtension(x.ToLower())))))
                {
                    string outPath = Path.Combine(outputDir, Path.GetFileNameWithoutExtension(file) + outFormat);
                    string args = $"\"{file}\" \"{outPath}\"";

                    if (chk_UseEncKey.Checked && txt_Key.Text != "" && txt_Key.Enabled)
                        args += $" --keycode {txt_Key.Text}";

                    Output.VerboseLog($"[INFO] Encoding \"{Path.GetFileName(file)}\" to \"{Path.GetFileName(outPath)}\"...");
                    Exe.Run(".\\Dependencies\\VGAudioCli.exe", args);
                    if (File.Exists(outPath))
                        Output.VerboseLog($"[INFO] Encoded file successfully!", ConsoleColor.DarkGreen);
                    else
                        Output.VerboseLog($"[INFO] Failed to encode file: \"{file}\"", ConsoleColor.DarkRed);
                }
                Output.Log($"[INFO] Done encoding {comboBox_OutFormat.Text} files to directory: \"{txt_OutputDir.Text}\"", ConsoleColor.Green);
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
                        string outPath = Path.Combine(outFolder, $"{i.ToString().PadLeft(5, '0')}{txt_Suffix}");
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
                if (comboBox_ArchiveFormat.Text == ".afs")
                    RepackAFS(archiveDir);
                else if (comboBox_ArchiveFormat.Text == ".acb")
                    RepackACB(archiveDir);
                else
                    Output.Log($"[ERROR] Could not repack archive, not a supported format: \"{comboBox_ArchiveFormat.Text}\"", ConsoleColor.Red);
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

        private void ExtractACB(string acb)
        {
            if (File.Exists(acb))
            {
                // Extract ADX from ACB
                Exe.Run($".\\Dependencies\\AcbEditor.exe \"{acb}\"");
                // Set ACB Path to extracted path for Repacking
                string acbPath = Path.Combine(Path.GetDirectoryName(acb), Path.GetFileNameWithoutExtension(acb));
                txt_ArchiveDir.Text = acbPath;
                comboBox_ArchiveFormat.SelectedIndex = comboBox_ArchiveFormat.Items.IndexOf(".acb");
                txt_OutputArchive.Text = acb;
            }
            else
                Output.Log($"[ERROR] ACB extract failed, input archive doesn't exist: \"{acb}\"", ConsoleColor.Red);

        }

        private void RepackACB(string acbDir)
        {
            string acbFile = Path.Combine(Path.GetDirectoryName(acbDir), Path.GetFileName(acbDir) + ".acb");
            string awbFile = acbFile.Replace(".acb",".awb");
            if (File.Exists(acbFile))
            {
                if (File.Exists(awbFile))
                {
                    if (Directory.Exists(acbDir))
                    {
                        // Create Backup ACB/AWB
                        BackupArchive(acbFile);
                        BackupArchive(awbFile);
                        // Repack ACB
                        Output.Log($"[INFO] Repacking ACB/AWB file with files from: \"{acbDir}\"");
                        Exe.Run($".\\Dependencies\\AcbEditor.exe \"{acbDir}\"");
                        Output.Log($"[INFO] Done repacking!", ConsoleColor.Green);
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
