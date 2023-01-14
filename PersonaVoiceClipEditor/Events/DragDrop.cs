using DarkUI.Controls;
using ShrineFox.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonaVoiceClipEditor
{
    public partial class PersonaVoiceClipEditorForm : Form
    {
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
    }
}