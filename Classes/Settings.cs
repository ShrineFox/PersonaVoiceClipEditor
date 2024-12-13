using MetroSet_UI.Forms;
using Newtonsoft.Json;
using ShrineFox.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonaVCE
{
    public partial class PersonaVCE : MetroSetForm
    {
        public static Settings settings = new Settings();

        public class Settings
        {
            public string Preset { get; set; } = "None";
            public string InputDir { get; set; } = "";
            public string OutputDir { get; set; } = "";
            public string OutFormat { get; set; } = ".adx";
            public bool Decrypt { get; set; } = false;
            public decimal Key { get; set; } = 0;
            public bool UseLoops { get; set; } = false;
            public bool UseExistingLoop { get; set; } = false;
            public bool LoopAll { get; set; } = false;
            public decimal LoopStart { get; set; } = 0;
            public decimal LoopEnd { get; set; } = 0;
            public string InputTxtPath { get; set; } = "";
            public string RenameDir { get; set; } = "";
            public string RenameOutDir { get; set; } = "";
            public string TxtSuffix { get; set; } = "_streaming";
            public bool AppendFilename { get; set; } = false;
            public decimal LeftPadding { get; set; } = 5;
            public decimal StartIndex { get; set; } = 0;
            public string InputArchive { get; set; } = "";
            public string ArchiveDir { get; set; } = "";
            public string OutputArchive { get; set; } = "";
            public string ArchiveFormat { get; set; } = ".afs";
            public List<string> DGVCells { get; set; } = new List<string>();
            public string RyoOutputMode { get; set; } = "Don't Output For Ryo";
            public string RyoSuffix { get; set; } = "";
            public float RyoVolume { get; set; } = 0.4f;
            public bool RyoOverrideVolume { get; set; } = false;
            public int RyoCategory { get; set; } = -1;
            public bool RyoStreaming { get; set; } = true;
            public bool RyoPlayerVolume { get; set; } = false;
            public bool RyoCueNames { get; set; } = true;
            public bool EncodeRenameOutput { get; set; } = true;

        }

        private void SaveSettings()
        {
            // Get output path from file select prompt
            var outPaths = WinFormsDialogs.SelectFile("Save Project...", true, new string[] { "Project JSON (.json)" }, true);
            if (outPaths == null || outPaths.Count == 0 || string.IsNullOrEmpty(outPaths.First()))
                return;

            // Ensure output path ends with .json
            string outPath = outPaths.First();
            if (!outPath.ToLower().EndsWith(".json"))
                outPath += ".json";

            // Save to .json file
            string jsonText = JsonConvert.SerializeObject(settings, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(outPath, jsonText);
            MessageBox.Show($"Saved project file to:\n{outPath}", "Project Saved");
        }

        public void LoadSettings()
        {
            var filePaths = WinFormsDialogs.SelectFile("Load Project...", true, new string[] { "Project JSON (.json)" });
            if (filePaths == null || filePaths.Count == 0 || string.IsNullOrEmpty(filePaths.First()))
                return;

            settings = JsonConvert.DeserializeObject<Settings>(File.ReadAllText(filePaths.First()));

            ApplySettingsToForm();
        }

        private void ApplySettingsToForm()
        {
            comboBox_EncryptionPreset.SelectedItem = settings.Preset;
            comboBox_SoundFormat.SelectedItem = settings.OutFormat;
            comboBox_ArchiveFormat.SelectedItem = settings.ArchiveFormat;

            chk_Decrypt.Checked = settings.Decrypt;
            num_EncryptionKey.Value = settings.Key;
            chk_UseLoopPoints.Checked = settings.UseLoops;
            chk_LoopAll.Checked = settings.LoopAll;
            chk_UseExistingLoop.Checked = settings.UseExistingLoop;
            num_LoopStart.Value = settings.LoopStart;
            num_LoopEnd.Value = settings.LoopEnd;

            txt_InputTxtFile.Text = settings.InputTxtPath;
            txt_RenameSourcePath.Text = settings.RenameDir;
            txt_RenameOutputPath.Text = settings.RenameOutDir;
            txt_RenameSuffix.Text = settings.TxtSuffix;
            chk_AppendOGName.Checked = settings.AppendFilename;
            num_LeftPadding.Value = settings.LeftPadding;
            num_StartID.Value = settings.StartIndex;

            if (comboBox_Ryo.Items.Contains(settings.RyoOutputMode))
                comboBox_Ryo.SelectedIndex = comboBox_Ryo.Items.IndexOf(settings.RyoOutputMode);
            txt_RyoFolderSuffix.Text = settings.RyoSuffix;
            num_RyoVolume.Value = Convert.ToDecimal(settings.RyoVolume);
            num_RyoCategory.Value = settings.RyoCategory;
            chk_Streaming.Checked = settings.RyoStreaming;
            chk_RyoPlayerVol.Checked = settings.RyoPlayerVolume;
            chk_RyoCueNames.Checked = settings.RyoCueNames;
            chk_RyoOverrideVolume.Checked = settings.RyoOverrideVolume;

            chk_EncodeRename.Checked = settings.EncodeRenameOutput;

            foreach (var line in settings.DGVCells)
                dgv_RenameTxt.Rows.Add(line);

            Output.VerboseLog("[INFO] Done applying settings to form.");
        }
    }
}