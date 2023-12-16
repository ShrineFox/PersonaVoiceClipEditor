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
                num_EncryptionKey.Enabled = true;
            else
                num_EncryptionKey.Enabled = false;

            UpdateSettings();
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
            updateSettings = false;

            switch (comboBox_EncryptionPreset.SelectedText)
            {
                case "P5R (PC/Switch)":
                    SetP5Defaults();
                    num_EncryptionKey.Value = 9923540143823782;
                    break;
                case "P5R (ENG PS4)":
                    SetP5Defaults();
                    num_EncryptionKey.Value = 022759300;
                    break;
                case "P5R (JP PS4)":
                    SetP5Defaults();
                    num_EncryptionKey.Value = 10882899;
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

            updateSettings = true;

            UpdateSettings();
        }

        private void SetDefaults()
        {
            chk_UseEncryption.Checked = false;
            num_EncryptionKey.Value = 0;
            txt_RenameSuffix.Text = "";
            num_LeftPadding.Value = 0;
            comboBox_ArchiveFormat.SelectedItem = ".afs";
        }

        private void SetP5Defaults()
        {
            chk_UseEncryption.Checked = true;
            num_EncryptionKey.Enabled = true;
            num_EncryptionKey.Value = 0;
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
                num_LoopStart.Enabled = true;
                num_LoopEnd.Enabled = true;
            }
            else
            {
                num_LoopStart.Enabled = false;
                num_LoopEnd.Enabled = false;
            }
        }

        private void DropDownList_Changed(object sender, EventArgs e)
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