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

namespace PersonaVoiceClipEditor
{
    public partial class PersonaVoiceClipEditorForm : Form
    {
        public static List<string> supportedFormats = new List<string> { ".adx", ".hca", ".wav" };
        public PersonaVoiceClipEditorForm()
        {
            InitializeComponent();
            comboBox_OutFormat.DataSource = supportedFormats;
            comboBox_OutFormat.SelectedIndex = 0;
            // TODO: Add commandline options?
            // TODO: Add log?
        }

        private void ExtractAFS(string afs)
        {
            var settings = new PuyoTools.GUI.ArchiveExtractor.Settings();
            var dialog = new PuyoTools.GUI.ProgressDialog();

            if (File.Exists(afs))
            {
                // Create List for PuyoTools Extraction
                List<string> files = new List<string>();
                files.Add(afs);
                PuyoTools.GUI.ToolForm.fileList = files;
                settings.ExtractToSameNameDirectory = true;
                settings.ExtractToSourceDirectory = false;
                //Extract AFS
                PuyoTools.GUI.ArchiveExtractor.Run(settings, dialog);
                // TODO: Move to Extracted Dir
            }
        }

        private void RepackAFS(string afs)
        {
            var settings = new PuyoTools.GUI.ArchiveCreator.Settings();
            var dialog = new PuyoTools.GUI.ProgressDialog();

            if (Directory.Exists(afs))
            {
                List<string> files = Directory.GetFiles(afs).ToList();
                // TODO: Use settings.FileEntries.Add instead?
                PuyoTools.GUI.ToolForm.fileList = files;
                PuyoTools.GUI.ArchiveCreator.Run(settings, dialog);
                // TODO: Move to Output Archive Location
            }
        }

        private void ExtractACB(string acb)
        {
            if (File.Exists(acb))
            {
                // Extract ADX from ACB
                Exe.Run($".\\Dependencies\\AcbEditor.exe \"{acb}\"");
                // Set ACB Path to extracted path for Repacking
                string acbPath = Path.Combine(Path.GetDirectoryName(acb), Path.GetFileNameWithoutExtension(acb));
                if (txt_ArchiveDir.Text == "")
                    txt_ArchiveDir.Text = acbPath;
                else
                    Directory.Move(acbPath, txt_ArchiveDir.Text);
            }
        }

        private void RepackACB(string acb)
        {
            if (Directory.Exists(acb))
            {
                //Repack ACB
                Exe.Run($".\\Dependencies\\AcbEditor.exe \"{acb}\"");
                string acbPath = Path.Combine(Path.GetDirectoryName(acb), Path.GetFileNameWithoutExtension(acb) + ".acb");
                string awbPath = acbPath.Replace(".acb", ".awb");
                if (txt_OutputArchive.Text == "")
                    txt_OutputArchive.Text = acbPath;
                else if (File.Exists(acbPath))
                {
                    File.Move(acbPath, txt_OutputArchive.Text);
                    if (File.Exists(awbPath))
                        File.Move(awbPath, txt_OutputArchive.Text.Replace(".acb", ".awb"));
                }
            }
        }

        private void Encode_Click(object sender, EventArgs e)
        {

            if (Directory.Exists(txt_InputDir.Text))
            {
                if (Directory.Exists(txt_OutputDir.Text))
                {
                    // Convert files to target format, output to specified directory
                    foreach (var file in Directory.GetFiles(txt_InputDir.Text).Where(x => supportedFormats.Any(y => y.Equals(Path.GetExtension(x.ToLower())))))
                    {
                        string outPath = Path.Combine(txt_OutputDir.Text, Path.GetFileNameWithoutExtension(file) + comboBox_OutFormat.Text);
                        string args = $"\"{file}\" \"{outPath}\"";
                        if (chk_UseEncKey.Checked && txt_Key.Text != "" && txt_Key.Enabled)
                            args += $" --keycode {txt_Key.Text}";
                        // TODO: If outformat is at9, use at9tool
                        Exe.Run(".\\Dependencies\\VGAudioCli.exe", args);
                    }
                    // Re-order based on .txt file
                    if (File.Exists(txt_TxtFile.Text))
                    {
                        string tempFolder = Path.Combine(Path.GetDirectoryName(txt_OutputDir.Text), "PVE_Temp");
                        if (Directory.Exists(tempFolder))
                            Directory.Delete(tempFolder, true);
                        Directory.CreateDirectory(tempFolder);
                        int i = 0;
                        foreach (var line in File.ReadLines(txt_TxtFile.Text))
                        {
                            var files = Directory.GetFiles(txt_OutputDir.Text, $"*{comboBox_OutFormat.Text}", SearchOption.TopDirectoryOnly);
                            if (files.Any(x => Path.GetFileNameWithoutExtension(x).Equals(line.Trim())))
                            {
                                var file = files.Single(x => Path.GetFileNameWithoutExtension(x).Equals(line.Trim()));
                                string outPath = Path.Combine(tempFolder, $"{i.ToString().PadLeft(5, '0')}{txt_Suffix}");
                                File.Copy(file, outPath);
                            }
                        }
                    }
                }
            }
        }

        private void DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void Txt_DragDrop(object sender, DragEventArgs e)
        {
            var data = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (File.Exists(data[0]))
                this.Text = data[0];
        }

        private void Extract_DragDrop(object sender, DragEventArgs e)
        {
            var data = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            // TODO: If directory, do each file in directory (use separate UI thread)
            if (Path.GetExtension(data[0]).ToLower() == ".afs")
                ExtractAFS(data[0]);
            else if (Path.GetExtension(data[0]).ToLower() == ".acb")
                ExtractACB(data[0]);
        }

        private void RepackACB_DragDrop(object sender, DragEventArgs e)
        {
            var data = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            RepackACB(data[0]);
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
    }
}
