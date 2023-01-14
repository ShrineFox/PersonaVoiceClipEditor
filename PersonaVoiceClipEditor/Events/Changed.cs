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
        private void EncodeDir_Changed(object sender, EventArgs e)
        {
            EnableEncodeBtn();
        }

        private void EnableEncodeBtn()
        {
            ValidateTextCtrls(new List<Control>() { txt_InputDir, txt_OutputDir }, btn_Encode);
        }

        private void ToggleKey()
        {
            if (chk_UseEncKey.Checked)
                txt_Key.Enabled = true;
            else
                txt_Key.Enabled = false;

            UpdateSettings();
        }

        private void EnableRepackBtn()
        {
            ValidateTextCtrls(new List<Control>() { txt_OutputArchive, txt_ArchiveDir }, btn_Repack);
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
            // Enable repack if output archive & archive dir are filled out
            ValidateTextCtrls(new List<Control>() { txt_ArchiveDir, txt_OutputArchive }, btn_Repack);
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

            UpdateSettings();
        }

        private void UseKey_CheckedChanged(object sender, EventArgs e)
        {
            ToggleKey();
        }

        private void Preset_Changed(object sender, EventArgs e)
        {
            if (!updateSettings)
                return;

            switch (comboBox_Preset.SelectedItem.ToString())
            {
                case "P5R (PC/NX)":
                    SetP5Defaults();
                    txt_Key.Text = "9923540143823782";
                    break;
                case "P5R (ENG PS4)":
                    SetP5Defaults();
                    txt_Key.Text = "022759300";
                    break;
                case "P5R (JP PS4)":
                    SetP5Defaults();
                    txt_Key.Text = "10882899";
                    break;
                case "P5 (PS3)":
                    SetP5Defaults();
                    chk_UseEncKey.Checked = false;
                    break;
                default:
                    SetDefaults();
                    break;
            }
            Output.Log($"[INFO] Loaded Preset: \"{comboBox_Preset.SelectedItem.ToString()}\"");

            UpdateSettings();
        }

        private void SetDefaults()
        {
            chk_UseEncKey.Checked = false;
            txt_Key.Text = "";
            txt_Suffix.Text = "";
            num_Padding.Value = 0;
            comboBox_ArchiveFormat.SelectedIndex = comboBox_ArchiveFormat.Items.IndexOf(".afs");
        }

        private void SetP5Defaults()
        {
            chk_UseEncKey.Checked = true;
            txt_Key.Text = "";
            txt_Suffix.Text = "_streaming";
            num_Padding.Value = 5;
            comboBox_ArchiveFormat.SelectedIndex = comboBox_ArchiveFormat.Items.IndexOf(".acb");
        }

        private void ComboBox_Changed(object sender, EventArgs e)
        {
            UpdateSettings();
        }

        private void Txt_Changed(object sender, EventArgs e)
        {
            UpdateSettings();
        }

        private void Value_Changed(object sender, EventArgs e)
        {
            UpdateSettings();
        }
    }
}