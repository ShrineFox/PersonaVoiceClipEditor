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
            var data = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (File.Exists(data[0]) && 
                (Path.GetExtension(data[0]) == ".txt" || Path.GetExtension(data[0]) == ".tsv"))
            {
                txt_InputTxtFile.Text = data[0];
                AddTxtLinesToDGV();
            }
        }

        private void Encode_DragDrop(object sender, DragEventArgs e)
        {
            // Encode dragged files or files in dragged folder
            var data = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (Directory.Exists(data[0]))
                StartEncode(Directory.GetFiles(data[0]).ToArray(), Convert.ToSingle(num_Volume.Value));
            else if (File.Exists(data[0]))
                StartEncode(data, Convert.ToSingle(num_Volume.Value));
        }

        private void RenameDir_DragDrop(object sender, DragEventArgs e)
        {
            var data = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (Directory.Exists(data[0]))
            {
                StartEncode(Directory.GetFiles(data[0]).ToArray(), Convert.ToSingle(num_Volume.Value));
                txt_RenameSourcePath.Text = data[0];
                settings.RenameDir = data[0];
            }
        }

        private void RenameOutDir_DragDrop(object sender, DragEventArgs e)
        {
            var data = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (Directory.Exists(data[0]))
            {
                StartEncode(Directory.GetFiles(data[0]).ToArray(), Convert.ToSingle(num_Volume.Value));
                txt_RenameOutputPath.Text = data[0];
                settings.RenameOutDir = data[0];
            }
        }

        private void RenameTxt_DragDrop(object sender, DragEventArgs e)
        {
            var data = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (File.Exists(data[0]))
            {
                txt_InputTxtFile.Text = data[0];
                AddTxtLinesToDGV();
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