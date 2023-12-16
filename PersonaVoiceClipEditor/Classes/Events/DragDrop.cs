using DarkUI.Controls;
using MetroSet_UI.Forms;
using ShrineFox.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            if (File.Exists(data[0]) && Path.GetExtension(data[0]) == ".txt")
            {
                settings.TxtFile = data[0];
                dgv.Rows.Clear();
                dgv.Columns.Clear();
                dgv.Columns.Add(new DataGridViewColumn() { HeaderText = "Filename" });
                dgv.Columns.Add(new DataGridViewColumn() { HeaderText = "Transcription" });
                foreach (var line in File.ReadAllLines(data[0]))
                {
                    dgv.Rows.Add(new DataGridViewRow().Cells[0].Value = line);
                }
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
                settings.RenameDir = data[0];
            }
        }

        private void RenameOutDir_DragDrop(object sender, DragEventArgs e)
        {
            var data = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (Directory.Exists(data[0]))
            {
                Encode(Directory.GetFiles(data[0]).ToArray());
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