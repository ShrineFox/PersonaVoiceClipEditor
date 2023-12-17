using MetroSet_UI.Forms;
using ShrineFox.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PersonaVCE
{
    public partial class PersonaVCE : MetroSetForm
    {
        private void DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void Dgv_DragDrop(object sender, DragEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            var data = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (File.Exists(data[0]) && (Path.GetExtension(data[0]) == ".txt" || Path.GetExtension(data[0]) == ".tsv"))
            {
                AddTxtLinesToSettings(data[0]);
                LoadDGVCellsFromSettings();
            }
        }

        private void AddTxtLinesToSettings(string txtFilePath)
        {
            var lines = File.ReadAllLines(txtFilePath);
            settings.RenameTxtList.Clear();
            foreach (var line in lines)
            {
                string[] splitLine = line.Split('\t');
                if (splitLine.Length > 1)
                    settings.RenameTxtList.Add(new RenameTxt() { FileName = splitLine[0], Transcription = splitLine[1] });
                else
                    settings.RenameTxtList.Add(new RenameTxt() { FileName = line });
            }
        }

        private void Encode_DragDrop(object sender, DragEventArgs e)
        {
            // Encode dragged files or files in dragged folder
            var data = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (Directory.Exists(data[0]))
                Encode(Directory.GetFiles(data[0]).ToArray());
            else if (File.Exists(data[0]))
                Encode(data);
        }

        private void Decode_DragDrop(object sender, DragEventArgs e)
        {
            // Decode dragged files or files in dragged folder
            var data = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (Directory.Exists(data[0]))
                Encode(Directory.GetFiles(data[0]).ToArray(), ".wav");
            else if (File.Exists(data[0]))
                Encode(data, ".wav");
        }

        private void RenameDir_DragDrop(object sender, DragEventArgs e)
        {
            var data = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (Directory.Exists(data[0]))
            {
                Encode(Directory.GetFiles(data[0]).ToArray());
                txt_RenameSourcePath.Text = data[0];
                settings.RenameDir = data[0];
            }
        }

        private void RenameOutDir_DragDrop(object sender, DragEventArgs e)
        {
            var data = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (Directory.Exists(data[0]))
            {
                Encode(Directory.GetFiles(data[0]).ToArray());
                txt_RenameOutputPath.Text = data[0];
                settings.RenameOutDir = data[0];
            }
        }

        private void Extract_DragDrop(object sender, DragEventArgs e)
        {
            var data = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (File.Exists(data[0]))
                ExtractArchive(data[0]);
        }

        private void Repack_DragDrop(object sender, DragEventArgs e)
        {
            var data = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (Directory.Exists(data[0]))
                RepackArchive(data[0]);
        }
    }
}