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
            public string Key { get; set; } = "";
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
            settings.InputDir = txt_InputDir.Text;
            settings.OutputDir = txt_OutputDir.Text;
            settings.OutFormat = comboBox_SoundFormat.SelectedText;
            settings.UseKey = chk_UseEncryption.Checked;
            settings.Key = txt_EncryptionKey.Text;
            settings.UseLoops = chk_UseLoopPoints.Checked;
            settings.LoopAll = chk_LoopAll.Checked;
            settings.LoopStart = txt_LoopStart.Value;
            settings.LoopEnd = txt_LoopEnd.Value;

            settings.TxtFile = txt_TxtFile.Text;
            settings.RenameDir = txt_RenameDir.Text;
            settings.RenameOutDir = txt_RenameOutput.Text;
            settings.TxtSuffix = txt_RenameSuffix.Text;
            settings.AppendFilename = chk_AppendFilename.Checked;
            settings.LeftPadding = num_LeftPadding.Value;
            settings.StartIndex = num_StartIndex.Value;

            settings.InputArchive = txt_InputArchive.Text;
            settings.ArchiveDir = txt_ArchiveDir.Text;
            settings.OutputArchive = txt_OutputArchive.Text;
            settings.ArchiveFormat = comboBox_ArchiveFormat.SelectedText;

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
            txt_InputDir.Text = settings.InputDir;
            txt_OutputDir.Text = settings.OutputDir;
            comboBox_SoundFormat.SelectedItem = settings.OutFormat;
            chk_UseEncryption.Checked = settings.UseKey;
            txt_EncryptionKey.Text = settings.Key;
            chk_UseLoopPoints.Checked = settings.UseLoops;
            chk_LoopAll.Checked = settings.LoopAll;
            txt_LoopStart.Value = settings.LoopStart;
            txt_LoopEnd.Value = settings.LoopEnd;

            txt_TxtFile.Text = settings.TxtFile;
            txt_RenameDir.Text = settings.RenameDir;
            txt_RenameOutput.Text = settings.RenameOutDir;
            txt_RenameSuffix.Text = settings.TxtSuffix;
            chk_AppendFilename.Checked = settings.AppendFilename;
            num_LeftPadding.Value = settings.LeftPadding;
            num_StartIndex.Value = settings.StartIndex;

            txt_InputArchive.Text = settings.InputArchive;
            txt_ArchiveDir.Text = settings.ArchiveDir;
            txt_OutputArchive.Text = settings.OutputArchive;
            comboBox_ArchiveFormat.SelectedItem = settings.ArchiveFormat;

            Output.VerboseLog("[INFO] Done applying settings to form.");
        }
    }
}