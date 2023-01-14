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
using PuyoTools.Formats.Archives;
using System.Threading;
using System.Diagnostics;
using PuyoTools.GUI;
using NAudio.Wave;
using Microsoft.WindowsAPICodePack.Dialogs;
using ShrineFox.IO;
using System.Security.Cryptography;
using DarkUI.Controls;

namespace PersonaVoiceClipEditor
{
    public partial class PersonaVoiceClipEditorForm : Form
    {
        public static List<string> supportedFormats = new List<string> { ".adx", ".hca", ".wav" };
        public static List<string> supportedArchives = new List<string> { ".acb", ".afs" };

        public PersonaVoiceClipEditorForm()
        {
            InitializeComponent();
            comboBox_OutFormat.DataSource = supportedFormats;
            comboBox_OutFormat.SelectedIndex = 0;
            comboBox_ArchiveFormat.DataSource = supportedArchives;
            comboBox_ArchiveFormat.SelectedIndex = 0;
            Output.Logging = true;
            Output.LogControl = rtb_Log;
#if DEBUG
            Output.VerboseLogging = true;
#endif
        }

        private void Encode_Click(object sender, EventArgs e)
        {

            Encode();
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
                    // TODO: If outformat is at9, use at9tool
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

        private bool RecreateDirectory(string outputDir, bool usePrompt = true)
        {
            if (Directory.Exists(outputDir) && 
                (Directory.GetFiles(outputDir).Count() > 0 || Directory.GetDirectories(outputDir).Count() > 0))
            {
                if (usePrompt)
                {
                    bool userResponse = WinFormsDialogs.YesNoMsgBox("Delete directory?",
                    $"Any existing contents of the following directory will be deleted. " +
                    $"Are you sure you want to continue?\n\n\"{outputDir}\"");
                    if (!userResponse)
                    {
                        Output.Log($"[INFO] Operation cancelled by user.");
                        return false;
                    }
                }
                Output.Log($"[INFO] Deleting existing directory: \"{outputDir}\"");
                Directory.Delete(outputDir, true);
            }
            Output.Log($"[INFO] Creating directory: \"{outputDir}\"");
            Directory.CreateDirectory(outputDir);
            return true;
        }

        private void ExtractAFS(string afs)
        {
            var settings = new PuyoTools.GUI.ArchiveExtractor.Settings();
            var dialog = new PuyoTools.GUI.ProgressDialog();
            string outputDir = txt_ArchiveDir.Text;

            if (File.Exists(afs) && RecreateDirectory(outputDir))
            {
                Output.Log($"[INFO] Extracting AFS archive: \"{afs}\"");

                // Create temp extraction path
                string tempPath = Path.Combine(Path.Combine(Path.GetDirectoryName(afs), "Extracted Files"), Path.GetFileNameWithoutExtension(afs));
                RecreateDirectory(tempPath, false);
                
                // Create List for PuyoTools Extraction
                List<string> files = new List<string>();
                files.Add(afs);
                PuyoTools.GUI.ToolForm.fileList = files;
                settings.ExtractToSourceDirectory = false;
                settings.ExtractToSameNameDirectory = false;
                settings.FileNumberAsFilename = true;
                
                //Extract AFS
                PuyoTools.GUI.ArchiveExtractor.Run(settings, dialog);
                
                // Move to Extracted Dir
                if (Directory.Exists(tempPath))
                {
                    FileSys.CopyDir(tempPath, outputDir);
                    Directory.Delete(Path.GetDirectoryName(tempPath), true);
                    Output.Log($"[INFO] Done extracting archive contents to: \"{outputDir}\"", ConsoleColor.Green);
                }
                else
                    Output.Log($"[ERROR] No files were extracted from AFS file: \"{afs}\"", ConsoleColor.Red);
            }
            else
                Output.Log($"[ERROR] AFS extraction failed, input archive doesn't exist: \"{afs}\"", ConsoleColor.Red);

        }

        private void RepackAFS(string afsDir)
        {
            var settings = new PuyoTools.GUI.ArchiveCreator.Settings();
            var dialog = new PuyoTools.GUI.ProgressDialog();

            if (Directory.Exists(afsDir))
            {
                List<string> files = Directory.GetFiles(afsDir).ToList();
                // TODO: Use settings.FileEntries.Add instead?
                PuyoTools.GUI.ToolForm.fileList = files;
                PuyoTools.GUI.ArchiveCreator.Run(settings, dialog);
                // TODO: Move to Output Archive Location
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

        private void BackupArchive(string file)
        {
            if (!File.Exists(file + ".bak"))
            {
                Output.Log($"[INFO] Creating backup of original archive: \"{file}.bak\"");
                File.Copy(file, file + ".bak");
            }
        }

        private void DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void Txt_DragDrop(object sender, DragEventArgs e)
        {
            DarkTextBox txtBox = (DarkTextBox)sender;
            var data = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (File.Exists(data[0]))
                txtBox.Text = data[0];
        }

        private void Encode_DragDrop(object sender, DragEventArgs e)
        {
            var data = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (Directory.Exists(data[0]))
                txt_InputDir.Text = data[0];
            EnableEncodeBtn();
            if (btn_Encode.Enabled)
                Encode();
        }

        private void Rename_DragDrop(object sender, DragEventArgs e)
        {
            var data = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (File.Exists(data[0]) && Path.GetExtension(data[0]).ToLower() == ".txt")
                txt_TxtFile.Text = data[0];
            else if (Directory.Exists(data[0]))
                txt_RenameDir.Text = data[0];
            EnableRenameBtn();
            if (btn_Rename.Enabled)
                Rename();
        }

        private void Unpack_DragDrop(object sender, DragEventArgs e)
        {
            var data = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (File.Exists(data[0]))
                txt_InputArchive.Text = data[0];
            ToggleArchiveBtns();
            if (btn_Unpack.Enabled)
                UnpackArchive();
        }

        private void Repack_DragDrop(object sender, DragEventArgs e)
        {
            var data = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (Directory.Exists(data[0]))
                txt_ArchiveDir.Text = data[0];
            EnableRepackBtn();
            if (btn_Repack.Enabled)
                RepackArchive();
        }

        private void InputArchive_Click(object sender, EventArgs e)
        {
            var files = WinFormsEvents.FilePath_Click("Choose Input Archive File...", false,
                new string[] { "ACB Archive (.acb)", "AFS Archive (.afs)" });
            if (files.Count > 0)
                txt_InputArchive.Text = files[0];
        }

        private void ExtractedArchiveDir_Click(object sender, EventArgs e)
        {
            string path = WinFormsEvents.FolderPath_Click("Choose Extracted Archive Folder...");
            if (!string.IsNullOrEmpty(path))
                txt_ArchiveDir.Text = path;
        }

        private void OutputArchive_Click(object sender, EventArgs e)
        {
            var files = WinFormsEvents.FilePath_Click("Choose Output Archive File Location...", false,
                new string[] { "ACB Archive (.acb)", "AFS Archive (.afs)" });
            if (files.Count > 0)
                txt_OutputArchive.Text = files[0];
        }

        private void InputDir_Click(object sender, EventArgs e)
        {
            string path = WinFormsEvents.FolderPath_Click("Choose Input Audio Files Folder...");
            if (!string.IsNullOrEmpty(path))
                txt_InputDir.Text = path;
        }

        private void OutputDir_Click(object sender, EventArgs e)
        {
            string path = WinFormsEvents.FolderPath_Click("Choose Output Audio Files Folder...");
            if (!string.IsNullOrEmpty(path))
                txt_OutputDir.Text = path;
        }

        private void Txt_Click(object sender, EventArgs e)
        {
            var files = WinFormsEvents.FilePath_Click("Choose Output Name Order File Location...", false,
                new string[] { "Text file (.txt)" });
            if (files.Count > 0)
                txt_TxtFile.Text = files[0];
        }

        private void RenameDir_Click(object sender, EventArgs e)
        {
            string path = WinFormsEvents.FolderPath_Click("Choose Directory of Files to Rename...");
            if (!string.IsNullOrEmpty(path))
                txt_RenameDir.Text = path;
        }

        private void RenameOutputDir_Click(object sender, EventArgs e)
        {
            string path = WinFormsEvents.FolderPath_Click("Choose Renamed Files Destination...");
            if (!string.IsNullOrEmpty(path))
                txt_RenameOutput.Text = path;
        }

        private void EncodeDir_Changed(object sender, EventArgs e)
        {
            EnableEncodeBtn();
        }

        private void EnableEncodeBtn()
        {
            ValidateTextCtrls(new List<Control>() { txt_InputDir, txt_OutputDir }, btn_Encode);
        }

        private void RenamePath_Changed(object sender, EventArgs e)
        {
            EnableRenameBtn();
        }

        private void EnableRenameBtn()
        {
            ValidateTextCtrls(new List<Control>() { txt_TxtFile, txt_RenameDir, txt_RenameOutput }, btn_Rename);
        }

        private void ArchivePath_Changed(object sender, EventArgs e)
        {
            // Update output archive format based on input archive extension
            DarkTextBox txtBox = (DarkTextBox)sender;
            if (Path.GetExtension(txtBox.Text).ToLower().Equals(".afs"))
                comboBox_ArchiveFormat.SelectedIndex = comboBox_ArchiveFormat.Items.IndexOf(".afs");
            else if (Path.GetExtension(txtBox.Text).ToLower().Equals(".acb"))
                comboBox_ArchiveFormat.SelectedIndex = comboBox_ArchiveFormat.Items.IndexOf(".acb");

            ToggleArchiveBtns();
        }

        private void ToggleArchiveBtns()
        {
            // Enable unpack if input archive & archive dir are filled out
            ValidateTextCtrls(new List<Control>() { txt_InputArchive, txt_ArchiveDir }, btn_Unpack);
            // enable repack if output archive & archive dir are filled out
            ValidateTextCtrls(new List<Control>() { txt_ArchiveDir, txt_OutputDir }, btn_Repack);
        }

        private void OutputArchive_Changed(object sender, EventArgs e)
        {
            EnableRepackBtn();
        }

        private void EnableRepackBtn()
        {
            ValidateTextCtrls(new List<Control>() { txt_OutputArchive, txt_ArchiveDir }, btn_Repack);
        }

        private void Unpack_Click(object sender, EventArgs e)
        {
            UnpackArchive();
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

        private void Repack_Click(object sender, EventArgs e)
        {
            RepackArchive();
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

        private void Rename_Click(object sender, EventArgs e)
        {
            Rename();
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

        private void ValidateTextCtrls(List<Control> ctrls, Control ctrlToToggle)
        {
            if (ctrls.All(x => !string.IsNullOrEmpty(x.Text)))
            {
                Output.VerboseLog($"[INFO] Enabling control: \"{ctrlToToggle.Name}\"");
                ctrlToToggle.Enabled = true;
            }
            else
            {
                Output.VerboseLog($"[INFO] Disabling control: \"{ctrlToToggle.Name}\"");
                ctrlToToggle.Enabled = false;
            }
        }
    }
}
