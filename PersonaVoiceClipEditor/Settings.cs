using DarkUI.Controls;
using ShrineFox.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YamlDotNet.Core;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace PersonaVoiceClipEditor
{
    public partial class PersonaVoiceClipEditorForm : Form
    {
        public static Settings settings = new Settings();
        public static bool updateSettings = false;

        public class Settings
        {
            public string Preset { get; set; } = "None";
            public string InputDir { get; set; } = "";
            public string OutputDir { get; set; } = "";
            public string OutFormat { get; set; } = ".adx";
            public bool UseKey { get; set; } = false;
            public string Key { get; set; } = "";

            public string TxtFile { get; set; } = "";
            public string RenameDir { get; set; } = "";
            public string RenameOutDir { get; set; } = "";
            public string TxtSuffix { get; set; } = "";
            public decimal LeftPadding { get; set; } = 0;

            public string InputArchive { get; set; } = "";
            public string ArchiveDir { get; set; } = "";
            public string OutputArchive { get; set; } = "";
            public string ArchiveFormat { get; set; } = ".afs";
        }

        public void UpdateSettings()
        {
            if (!updateSettings)
                return;

            settings.Preset = comboBox_Preset.SelectedItem.ToString();
            settings.InputDir = txt_InputDir.Text;
            settings.OutputDir = txt_OutputDir.Text;
            settings.OutFormat = comboBox_OutFormat.SelectedItem.ToString();
            settings.UseKey = chk_UseEncKey.Checked;
            settings.Key = txt_Key.Text;

            settings.TxtFile = txt_TxtFile.Text;
            settings.RenameDir = txt_RenameDir.Text;
            settings.RenameOutDir = txt_RenameOutput.Text;
            settings.TxtSuffix = txt_Suffix.Text;
            settings.LeftPadding = num_Padding.Value;

            settings.InputArchive = txt_InputArchive.Text;
            settings.ArchiveDir = txt_ArchiveDir.Text;
            settings.OutputArchive = txt_OutputArchive.Text;
            settings.ArchiveFormat = comboBox_ArchiveFormat.SelectedItem.ToString();

            Output.VerboseLog("[INFO] Updated settings object.");
            SaveSettings();
        }

        private void SaveSettings()
        {
            var serializer = new SerializerBuilder().Build();

            File.WriteAllText(".\\settings.yml", serializer.Serialize(settings));
            Output.VerboseLog("[INFO] Saved settings to \".\\settings.yml\".");
        }

        public void LoadSettings()
        {
            var deserializer = new DeserializerBuilder().Build();

            if (File.Exists(".\\settings.yml"))
            {
                settings = deserializer.Deserialize<Settings>(File.ReadAllText(".\\settings.yml"));
                Output.Log("[INFO] Loaded previous settings from \".\\settings.yml\".", ConsoleColor.Green);

                updateSettings = false;
                ApplySettingsToForm();
                updateSettings = true;
            }
            else
                Output.Log("[WARNING] Settings were not loaded since \".\\settings.yml\" was not found.", ConsoleColor.Yellow);

        }

        private void ApplySettingsToForm()
        {
            if (comboBox_Preset.Items.Contains(settings.Preset))
                comboBox_Preset.SelectedIndex = comboBox_Preset.Items.IndexOf(settings.Preset);
            txt_InputDir.Text = settings.InputDir;
            txt_OutputDir.Text = settings.OutputDir;
            if (comboBox_OutFormat.Items.Contains(settings.OutFormat))
                comboBox_OutFormat.SelectedIndex = comboBox_OutFormat.Items.IndexOf(settings.OutFormat);
            chk_UseEncKey.Checked = settings.UseKey;
            txt_Key.Text = settings.Key;

            txt_TxtFile.Text = settings.TxtFile;
            txt_RenameDir.Text = settings.RenameDir;
            txt_RenameOutput.Text = settings.RenameOutDir;
            txt_Suffix.Text = settings.TxtSuffix;
            num_Padding.Value = settings.LeftPadding;

            txt_InputArchive.Text = settings.InputArchive;
            txt_ArchiveDir.Text = settings.ArchiveDir;
            txt_OutputArchive.Text = settings.OutputArchive;
            if (comboBox_ArchiveFormat.Items.Contains(settings.ArchiveFormat))
                comboBox_ArchiveFormat.SelectedIndex = comboBox_ArchiveFormat.Items.IndexOf(settings.ArchiveFormat);

            Output.VerboseLog("[INFO] Done applying settings to form.");
        }
    }
}