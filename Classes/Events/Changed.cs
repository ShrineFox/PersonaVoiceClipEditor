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

        private void InputTxtFilePath_Changed(object sender, EventArgs e)
        {
            settings.InputTxtPath = txt_InputTxtFile.Text;
            AddTxtLinesToDGV();
        }

        private void LeftPaddingValue_Changed(object sender, EventArgs e)
        {
            settings.LeftPadding = num_LeftPadding.Value;
        }

        private void StartIDValue_Changed(object sender, EventArgs e)
        {
            settings.StartIndex = num_StartID.Value;
            int i = Convert.ToInt32(settings.StartIndex);
            foreach (DataGridViewRow row in dgv_RenameTxt.Rows)
            {
                row.Cells[0].Value = i;
                i++;
            }
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
                    num_EncryptionKey.Value = 0;
                    break;
                default:
                    SetDefaults();
                    break;
            }
            Output.Log($"[INFO] Loaded Preset: \"{comboBox_EncryptionPreset.ComboBox.SelectedItem}\"");
        }

        private void SetDefaults()
        {
            num_EncryptionKey.Value = 0;
            txt_RenameSuffix.Text = "";
            num_LeftPadding.Value = 0;
            comboBox_ArchiveFormat.SelectedItem = ".afs";
        }

        private void SetP5Defaults()
        {
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
            {
                chk_LoopAll.Enabled = true;
                chk_UseExistingLoop.Enabled = true;
                settings.UseLoops = true;
            }
            else
            {
                settings.UseLoops = false;
                chk_UseExistingLoop.Enabled = false;
                chk_LoopAll.Enabled = false;
            }

            EnableLoopEntry();
        }

        private void UseExistingLoop_CheckChanged(object sender, EventArgs e)
        {
            settings.UseExistingLoop = chk_UseExistingLoop.Checked;
        }

        private void LoopAll_Checked(object sender, EventArgs e)
        {
            if (chk_LoopAll.Checked)
                settings.LoopAll = true;
            else
                settings.LoopAll = false;

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

        private void RyoStreaming_CheckedChanged(object sender, EventArgs e)
        {
            settings.RyoStreaming = chk_Streaming.Checked;
        }

        private void RyoPlayerVolume_CheckedChanged(object sender, EventArgs e)
        {
            settings.RyoPlayerVolume = chk_RyoPlayerVol.Checked;
        }

        private void RyoVolume_ValueChanged(object sender, EventArgs e)
        {
            settings.RyoVolume = Convert.ToInt32(num_RyoVolume.Value);
        }

        private void RyoCategory_ValueChanged(object sender, EventArgs e)
        {
            settings.RyoCategory = Convert.ToInt32(num_RyoCategory.Value);
        }

        private void RyoFolderSuffix_TextChanged(object sender, EventArgs e)
        {
            settings.RyoSuffix = txt_RyoFolderSuffix.Text;
        }

        private void RyoCueNames_CheckedChanged(object sender, EventArgs e)
        {
            settings.RyoCueNames = chk_RyoCueNames.Checked;
        }

        private void RyoOverrideVolume_CheckedChanged(object sender, EventArgs e)
        {
            settings.RyoOverrideVolume = chk_RyoOverrideVolume.Checked;

            if (settings.RyoOverrideVolume)
                num_RyoVolume.Enabled = true;
            else
                num_RyoVolume.Enabled = false;
        }

        private void RyoOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            settings.RyoOutputMode = comboBox_Ryo.SelectedItem.ToString();
            
            if (settings.RyoOutputMode != "Don't Output For Ryo")
            {
                txt_RyoFolderSuffix.Enabled = true;
                chk_Streaming.Enabled = true;
                chk_RyoCueNames.Enabled = true;
                num_RyoCategory.Enabled = true;
                num_RyoVolume.Enabled = true;
                chk_RyoPlayerVol.Enabled = true;
                chk_RyoOverrideVolume.Enabled = true;
            }
            else
            {
                txt_RyoFolderSuffix.Enabled = false;
                chk_Streaming.Enabled = false;
                chk_RyoCueNames.Enabled = false;
                num_RyoCategory.Enabled = false;
                num_RyoVolume.Enabled = false;
                chk_RyoPlayerVol.Enabled = false;
                chk_RyoOverrideVolume.Enabled = false;
            }
        }

        private void EncodeRenameOutput_Changed(object sender, EventArgs e)
        {
            settings.EncodeRenameOutput = chk_EncodeRename.Checked;
        }

        private void DataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                string clipboardText = Clipboard.GetText(TextDataFormat.Text);
                if (clipboardText.Contains("\r\n"))
                {
                    settings.DGVCells = new List<string>();
                    dgv_RenameTxt.Rows.Clear();
                    int i = Convert.ToInt32(settings.StartIndex);
                    foreach (var line in clipboardText.Split('\n'))
                    {
                        string value = line.Split('\t')[0].Trim('\r');
                        dgv_RenameTxt.Rows.Add(i, value);
                        settings.DGVCells.Add(value);
                        i++;
                    }
                }
            }
        }
    }
}