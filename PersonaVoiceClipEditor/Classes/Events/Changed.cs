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

namespace PersonaVCE
{
    public partial class PersonaVCE : MetroSetForm
    {
        private void ToggleKey()
        {
            if (chk_UseEncryption.Checked)
                txt_EncryptionKey.Enabled = true;
            else
                txt_EncryptionKey.Enabled = false;

            UpdateSettings();
        }

        private void ArchivePath_Changed(object sender, EventArgs e)
        {
            // Update output archive format based on input archive extension
            DarkTextBox txtBox = (DarkTextBox)sender;
            if (Path.GetExtension(txtBox.Text).ToLower().Equals(".afs"))
                comboBox_ArchiveFormat.SelectedItem = ".afs";
            else if (Path.GetExtension(txtBox.Text).ToLower().Equals(".acb"))
                comboBox_ArchiveFormat.SelectedItem = ".acb";
        }

        private void UseKey_CheckedChanged(object sender, EventArgs e)
        {
            ToggleKey();
        }

        private void AppendFilename_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSettings();
        }

        private void Preset_Changed(object sender, EventArgs e)
        {
            if (!updateSettings)
                return;

            switch (comboBox_EncryptionPreset.SelectedText)
            {
                case "P5R (PC/Switch)":
                    SetP5Defaults();
                    txt_EncryptionKey.Text = "9923540143823782";
                    break;
                case "P5R (ENG PS4)":
                    SetP5Defaults();
                    txt_EncryptionKey.Text = "022759300";
                    break;
                case "P5R (JP PS4)":
                    SetP5Defaults();
                    txt_EncryptionKey.Text = "10882899";
                    break;
                case "P5 (PS3)":
                    SetP5Defaults();
                    chk_UseEncryption.Checked = false;
                    break;
                default:
                    SetDefaults();
                    break;
            }
            Output.Log($"[INFO] Loaded Preset: \"{comboBox_EncryptionPreset.SelectedText}\"");

            UpdateSettings();
        }

        private void SetDefaults()
        {
            chk_UseEncryption.Checked = false;
            txt_EncryptionKey.Text = "";
            txt_RenameSuffix.Text = "";
            num_LeftPadding.Value = 0;
            comboBox_ArchiveFormat.SelectedItem = ".afs";
        }

        private void SetP5Defaults()
        {
            chk_UseEncryption.Checked = true;
            txt_EncryptionKey.Text = "";
            txt_RenameSuffix.Text = "_streaming";
            num_LeftPadding.Value = 5;
            comboBox_ArchiveFormat.SelectedItem = ".acb";
        }

        private void UseLoops_Checked(object sender, EventArgs e)
        {
            if (chk_UseLoopPoints.Checked)
                chk_LoopAll.Enabled = true;
            else
                chk_LoopAll.Enabled = false;
            EnableLoopEntry();
        }

        private void LoopAll_Checked(object sender, EventArgs e)
        {
            EnableLoopEntry();
        }

        private void EnableLoopEntry()
        {
            if (!chk_LoopAll.Checked && chk_UseLoopPoints.Checked)
            {
                txt_LoopStart.Enabled = true;
                txt_LoopEnd.Enabled = true;
            }
            else
            {
                txt_LoopStart.Enabled = false;
                txt_LoopEnd.Enabled = false;
            }
        }

        private void dropDownList_Changed(object sender, EventArgs e)
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