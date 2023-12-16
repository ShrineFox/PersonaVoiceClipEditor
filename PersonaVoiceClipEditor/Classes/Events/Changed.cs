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
        }

        private void UseEncKey_CheckedChanged(object sender, EventArgs e)
        {
            ToggleKey();
        }

        private void LoopAll_CheckedChanged(object sender, EventArgs e)
        {
            settings.LoopAll = chk_LoopAll.Checked;
            EnableLoopEntry();
        }

        private void LoopStartValue_Changed(object sender, EventArgs e)
        {
            settings.LoopStart = num_LoopStart.Value;
        }

        private void LoopEndValue_Changed(object sender, EventArgs e)
        {
            settings.LoopEnd = num_LoopEnd.Value;
        }

        private void EncKeyValue_Changed(object sender, EventArgs e)
        {
            settings.Key = num_EncryptionKey.Value;
        }

        private void RenameSourcePath_Changed(object sender, EventArgs e)
        {
            settings.RenameDir = txt_RenameSourcePath.Text;
        }

        private void RenameOutputPath_Changed(object sender, EventArgs e)
        {
            settings.RenameOutDir = txt_RenameOutputPath.Text;
        }

        private void LeftPaddingValue_Changed(object sender, EventArgs e)
        {
            settings.LeftPadding = num_LeftPadding.Value;
        }

        private void StartIDValue_Changed(object sender, EventArgs e)
        {
            settings.StartIndex = num_StartID.Value;
        }

        private void Suffix_Changed(object sender, EventArgs e)
        {
            settings.TxtSuffix = txt_RenameSuffix.Text;
        }

        private void AppendOGName_CheckedChanged(object sender, EventArgs e)
        {
            settings.AppendFilename = chk_AppendOGName.Checked;
        }

        private void Preset_Changed(object sender, EventArgs e)
        {
            switch (comboBox_EncryptionPreset.ComboBox.SelectedItem.ToString())
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
            Output.Log($"[INFO] Loaded Preset: \"{comboBox_EncryptionPreset.ComboBox.SelectedItem}\"");
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
            num_EncryptionKey.Value = 0;
            txt_RenameSuffix.Text = "_streaming";
            num_LeftPadding.Value = 5;
            comboBox_ArchiveFormat.SelectedItem = ".acb";
        }


        private void ArchiveFormat_Changed(object sender, EventArgs e)
        {
            settings.ArchiveFormat = comboBox_ArchiveFormat.ComboBox.SelectedItem.ToString();
            Output.Log($"[INFO] Changed Archive Format: \"{comboBox_ArchiveFormat.ComboBox.SelectedItem}\"");
        }

        private void SoundFormat_Changed(object sender, EventArgs e)
        {
            settings.OutFormat = comboBox_SoundFormat.ComboBox.SelectedItem.ToString();
            Output.Log($"[INFO] Changed Sound Format: \"{comboBox_SoundFormat.ComboBox.SelectedItem}\"");
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
    }
}