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
        private void LoadProject_Click(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void SaveSettings_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void Encode_Click(object sender, EventArgs e)
        {
            string[] formats = new string[] { "ADX (.adx)", "HCA (.hca)", "WAV (.wav)" };
            var files = WinFormsDialogs.SelectFile("Choose files to encode", true, formats).ToArray();

            Encode(files);
        }


        private void Decode_Click(object sender, EventArgs e)
        {
            string[] formats = new string[] { "ADX (.adx)", "HCA (.hca)" };
            var files = WinFormsDialogs.SelectFile("Choose files to decode to WAV", true, formats).ToArray();

            Encode(files, ".wav");
        }

        private void Rename_Click(object sender, EventArgs e)
        {
            Rename();
        }

        private void ExtractArchive_Click(object sender, EventArgs e)
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

        private void RepackArchive_Click(object sender, EventArgs e)
        {
            string path = WinFormsDialogs.SelectFolder("Choose Input Audio Files Folder...");
            if (!string.IsNullOrEmpty(path))
                RepackArchive(path);
        }

        private void RenameDir_Click(object sender, EventArgs e)
        {
            string path = WinFormsDialogs.SelectFolder("Choose Directory of Files to Rename...");
            if (!string.IsNullOrEmpty(path))
            {
                txt_RenameSourcePath.Text = path;
            }
        }

        private void RenameOutput_Click(object sender, EventArgs e)
        {
            string path = WinFormsDialogs.SelectFolder("Choose Directory for Renamed Files...");
            if (!string.IsNullOrEmpty(path))
            {
                txt_RenameOutputPath.Text = path;
            }
        }

        private void Link_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ShrineFox/PersonaVoiceClipEditor");
        }


        private void ToggleTheme_Click(object sender, EventArgs e)
        {
            if (Theme.ThemeStyle == MetroSet_UI.Enums.Style.Dark)
                Theme.ThemeStyle = MetroSet_UI.Enums.Style.Light;
            else
                Theme.ThemeStyle = MetroSet_UI.Enums.Style.Dark;
            Theme.ApplyToForm(this);
        }
    }
}