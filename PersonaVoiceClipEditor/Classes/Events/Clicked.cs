using MetroSet_UI.Forms;
using ShrineFox.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonaVCE
{
    public partial class PersonaVCE : MetroSetForm
    {
        private void Encode_Click(object sender, EventArgs e)
        {
            Encode();
        }

        private void Rename_Click(object sender, EventArgs e)
        {
            Rename();
        }

        private void Unpack_Click(object sender, EventArgs e)
        {
            UnpackArchive();
        }

        private void Repack_Click(object sender, EventArgs e)
        {
            RepackArchive();
        }

        private void InputArchive_Click(object sender, EventArgs e)
        {
            string[] formats = new string[] { "ACB Archive (.acb)", "AFS Archive (.afs)" };
            if (comboBox_ArchiveFormat.SelectedText == ".afs")
                formats = formats.Reverse().ToArray();

            var files = WinFormsDialogs.SelectFile("Choose Input Archive File...", false, formats);
            if (files.Count > 0)
            {
                ExtractArchive(files[0]);
            }
        }

        private void ExtractArchive(string v)
        {
            throw new NotImplementedException();
        }

        private void OutputArchive_Click(object sender, EventArgs e)
        {
            string path = WinFormsDialogs.SelectFolder("Choose Input Audio Files Folder...");
            if (!string.IsNullOrEmpty(path))
                RepackArchive(path);
        }

        private void RepackArchive(string path)
        {
            throw new NotImplementedException();
        }

        private void Txt_Click(object sender, EventArgs e)
        {
            var files = WinFormsDialogs.SelectFile("Choose Output Name Order File Location...", false,
                new string[] { "Text file (.txt)" });
            if (files.Count > 0)
            {
                LoadRenameTxt(files[0]);
            }
        }

        private void LoadRenameTxt(string v)
        {
            throw new NotImplementedException();
        }

        private void RenameDir_Click(object sender, EventArgs e)
        {
            string path = WinFormsDialogs.SelectFolder("Choose Directory of Files to Rename...");
            if (!string.IsNullOrEmpty(path))
            {
                // TODO: Set rename source dir in project settings
            }
        }

        private void Link_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ShrineFox/PersonaVoiceClipEditor");
        }
    }
}