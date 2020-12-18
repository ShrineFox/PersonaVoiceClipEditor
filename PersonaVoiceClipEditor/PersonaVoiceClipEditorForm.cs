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
using PuyoTools.Modules.Archive;
using PuyoTools.Formats.Archives;
using System.Threading;
using System.Diagnostics;
using PuyoTools.GUI;
using NAudio.Wave;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace PersonaVoiceClipEditor
{
    public partial class PersonaVoiceClipEditorForm : Form
    {
        string afsPath = "";
        string acbPath = "";
        string sourcePath = "";
        string replacePath = "";
        string txtPath = "";

        public PersonaVoiceClipEditorForm()
        {
            InitializeComponent();
            linkLabel_Help.Links.Add(0, 10, "https://amicitia-team.tumblr.com/post/176979497616");
        }

        private void ExtractAFS_DragDrop(object sender, DragEventArgs e)
        {
            var data = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            ExtractAFS(data[0]);
        }

        private void ExtractAFS(string afs)
        {
            var settings = new PuyoTools.GUI.ArchiveExtractor.Settings();
            if (File.Exists(afs))
            {
                //Create List for PuyoTools Extraction
                List<string> files = new List<string>();
                files.Add(afs);
                //Set AFS Path to extracted path for Repacking
                afsPath = Path.Combine(Path.GetDirectoryName(afs), Path.GetFileNameWithoutExtension(afs));
                textBox_ReplaceAdxFolder.Text = afsPath;
                //Extract AFS
                PuyoTools.GUI.ArchiveExtractor.Run(settings, files);
            }
        }

        private void RepackAFS_DragDrop(object sender, DragEventArgs e)
        {
            var data = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            RepackAFS(data[0]);
        }

        private void RepackAFS(string afs)
        {
            if (Directory.Exists(afs))
            {
                //Convert WAV to ADX
                foreach (var file in Directory.GetFiles(afs))
                {
                    if (Path.GetExtension(file).ToLower() == ".wav")
                        RunCMD($"adxencd.exe \"{file}\" \"{Path.Combine(Path.GetDirectoryName(file), Path.GetFileNameWithoutExtension(file) + ".adx")}\"");
                }
                //Repack AFS
                List<string> files = Directory.GetFiles(afsPath).ToList();
                PuyoTools.GUI.ArchiveCreator.Run(files);
            }
        }

        private void ExtractACB_DragDrop(object sender, DragEventArgs e)
        {
            var data = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            ExtractACB(data[0]);
        }

        private void ExtractACB(string acb)
        {
            if (File.Exists(acb))
            {
                //Extract ADX from ACB
                RunCMD($"AcbEditor.exe \"{acb}\"");
                //Set ACB Path to extracted path for Repacking
                acbPath = Path.Combine(Path.GetDirectoryName(acbPath), Path.GetFileNameWithoutExtension(acbPath));
                darkTextBox_ACBPath.Text = acbPath;
            }
        }

        private void RunCMD(string args, bool hidden = true)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = "cmd";
            start.Arguments = $"/K {args}";
            start.UseShellExecute = true;
            start.RedirectStandardOutput = false;
            if (hidden)
                start.WindowStyle = ProcessWindowStyle.Hidden;
            using (Process process = Process.Start(start))
            {

            }
        }

        private void RepackACB_DragDrop(object sender, DragEventArgs e)
        {
            var data = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            RepackACB(data[0]);
        }

        private void RepackACB(string acb)
        {
            if (Directory.Exists(acb))
            {
                //Convert WAV to ADX
                foreach (var file in Directory.GetFiles(acb))
                {
                    if (Path.GetExtension(file).ToLower() == ".wav")
                        RunCMD($"adxencd.exe \"{file}\" \"{Path.Combine(Path.GetDirectoryName(file), Path.GetFileNameWithoutExtension(file) + ".adx")}\"");
                }
                //Repack ACB
                List<string> files = Directory.GetFiles(acbPath).ToList();
                RunCMD($"AcbEditor.exe \"{acbPath}\"");
            }
        }

        private void ExtractAFS_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void RepackAFS_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void ExtractACB_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void RepackACB_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        public static void RecursiveDelete(DirectoryInfo baseDir)
        {
            if (!baseDir.Exists)
                return;

            foreach (var dir in baseDir.EnumerateDirectories())
            {
                RecursiveDelete(dir);
                dir.Delete(true);
            }
            //baseDir.Delete(true);
        }

        FileStream WaitForFile(string fullPath, FileMode mode, FileAccess access, FileShare share)
        {
            for (int numTries = 0; numTries < 10; numTries++)
            {
                FileStream fs = null;
                try
                {
                    fs = new FileStream(fullPath, mode, access, share);
                    return fs;
                }
                catch (IOException)
                {
                    if (fs != null)
                    {
                        fs.Dispose();
                    }
                    Thread.Sleep(100);
                }
            }

            return null;
        }

        public static void StereoToMono(string sourceFile, string outputFile)
        {
            using (var waveFileReader = new WaveFileReader(sourceFile))
            {
                var outFormat = new WaveFormat(waveFileReader.WaveFormat.SampleRate, 1);
                using (var resampler = new MediaFoundationResampler(waveFileReader, outFormat))
                {
                    WaveFileWriter.CreateWaveFile(outputFile, resampler);
                }
            }
        }

        private void linkLabel_Help_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }

        private void AFSPath_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = false;
            dialog.Filters.Add(new CommonFileDialogFilter("AFS Archives", "afs"));
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                afsPath = dialog.FileName;
                darkTextBox_AFSPath.Text = afsPath;
            }
        }

        private void ACBPath_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.Filters.Add(new CommonFileDialogFilter("ACB Archives", "acb"));
            dialog.IsFolderPicker = false;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                acbPath = dialog.FileName;
                darkTextBox_ACBPath.Text = acbPath;
            }
        }

        private void SourceWAV_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                sourcePath = dialog.FileName;
                textBox_SourceWavFolder.Text = sourcePath;
            }
        }

        private void ReplaceAdxFolder_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                replacePath = dialog.FileName;
                textBox_ReplaceAdxFolder.Text = replacePath;
            }
        }

        private void Txt_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.Filters.Add(new CommonFileDialogFilter("Text Files","txt"));
            dialog.IsFolderPicker = false;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                txtPath = dialog.FileName;
                textBox_Txt.Text = txtPath;
            }
        }

        private void Replace_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtPath))
            {
                int i = Convert.ToInt32(darkNumericUpDown1.Value);
                foreach (var line in File.ReadAllLines(txtPath))
                {
                    //Convert WAV to ADX
                    RunCMD($"adxencd.exe \"{$"{sourcePath}\\{line}.wav"}\" \"{sourcePath}\\{line}.adx\"");
                    //Overwrite ADX in matching list order
                    File.Copy($"{sourcePath}\\{line}.adx", $"{replacePath}\\{i.ToString().PadLeft(5,'0')}_streaming.adx", true);
                    i++;
                }
            }
            else
                MessageBox.Show($"Specified Text file could not be found: {txtPath}");
        }

        private void AFSExtract_Click(object sender, EventArgs e)
        {
            ExtractAFS(afsPath);
        }

        private void AFSRepack_Click(object sender, EventArgs e)
        {
            RepackAFS(afsPath);
        }

        private void ACBExtract_Click(object sender, EventArgs e)
        {
            ExtractACB(acbPath);
        }

        private void ACBRepack_Click(object sender, EventArgs e)
        {
            RepackACB(acbPath);
        }
    }
}
