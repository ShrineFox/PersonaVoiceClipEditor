using ShrineFox.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonaVoiceClipEditor
{
    public partial class PersonaVoiceClipEditorForm : Form
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