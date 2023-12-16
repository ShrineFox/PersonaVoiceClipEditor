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
using YamlDotNet.Core;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace PersonaVCE
{
    public partial class PersonaVCE : MetroSetForm
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
            public decimal Key { get; set; } = 0;
            public bool UseLoops { get; set; } = false;
            public bool LoopAll { get; set; } = false;
            public decimal LoopStart { get; set; } = 0;
            public decimal LoopEnd { get; set; } = 0;

            public string TxtFile { get; set; } = "";
            public string RenameDir { get; set; } = "";
            public string RenameOutDir { get; set; } = "";
            public string TxtSuffix { get; set; } = "";
            public bool AppendFilename { get; set; } = false;
            public decimal LeftPadding { get; set; } = 0;
            public decimal StartIndex { get; set; } = 0;

            public string InputArchive { get; set; } = "";
            public string ArchiveDir { get; set; } = "";
            public string OutputArchive { get; set; } = "";
            public string ArchiveFormat { get; set; } = ".afs";
        }

        public void UpdateSettings()
        {
            if (!updateSettings)
                return;

            settings.Preset = comboBox_EncryptionPreset.SelectedText;
            settings.OutFormat = comboBox_SoundFormat.SelectedText;
            settings.ArchiveFormat = comboBox_ArchiveFormat.SelectedText;

            settings.UseKey = chk_UseEncryption.Checked;
            settings.Key = num_EncryptionKey.Value;
            settings.UseLoops = chk_UseLoopPoints.Checked;
            settings.LoopAll = chk_LoopAll.Checked;
            settings.LoopStart = num_LoopStart.Value;
            settings.LoopEnd = num_LoopEnd.Value;

            settings.TxtSuffix = txt_RenameSuffix.Text;
            settings.AppendFilename = chk_AppendOGName.Checked;
            settings.LeftPadding = num_LeftPadding.Value;
            settings.StartIndex = num_StartID.Value;

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
            comboBox_EncryptionPreset.SelectedItem = settings.Preset;
            comboBox_SoundFormat.SelectedItem = settings.OutFormat;
            comboBox_ArchiveFormat.SelectedItem = settings.ArchiveFormat;

            chk_UseEncryption.Checked = settings.UseKey;
            num_EncryptionKey.Value = settings.Key;
            chk_UseLoopPoints.Checked = settings.UseLoops;
            chk_LoopAll.Checked = settings.LoopAll;
            num_LoopStart.Value = settings.LoopStart;
            num_LoopEnd.Value = settings.LoopEnd;

            txt_RenameSuffix.Text = settings.TxtSuffix;
            chk_AppendOGName.Checked = settings.AppendFilename;
            num_LeftPadding.Value = settings.LeftPadding;
            num_StartID.Value = settings.StartIndex;

            Output.VerboseLog("[INFO] Done applying settings to form.");
        }
    }
}