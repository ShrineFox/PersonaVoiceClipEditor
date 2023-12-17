using MetroSet_UI.Forms;
using Newtonsoft.Json;
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
        public static Settings settings = new Settings();

        public class RenameTxt
        {
            public string FileName { get; set; } = "";
            public string Transcription { get; set; } = "";
        }

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
            public List<RenameTxt> RenameTxtList { get; set; } = new List<RenameTxt>();
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
            SaveDGVCellsToSettings();
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

            chk_UseEncryption.Checked = settings.UseKey;
            num_EncryptionKey.Value = settings.Key;
            chk_UseLoopPoints.Checked = settings.UseLoops;
            chk_LoopAll.Checked = settings.LoopAll;
            num_LoopStart.Value = settings.LoopStart;
            num_LoopEnd.Value = settings.LoopEnd;

            txt_RenameSourcePath.Text = settings.RenameDir;
            txt_RenameOutputPath.Text = settings.RenameOutDir;
            txt_RenameSuffix.Text = settings.TxtSuffix;
            chk_AppendOGName.Checked = settings.AppendFilename;
            num_LeftPadding.Value = settings.LeftPadding;
            num_StartID.Value = settings.StartIndex;

            LoadDGVCellsFromSettings();

            Output.VerboseLog("[INFO] Done applying settings to form.");
        }

        private void SaveDGVCellsToSettings()
        {
            List<RenameTxt> renameTxtList = new List<RenameTxt>();
            foreach (DataGridViewRow row in dgv_RenameTxt.Rows)
            {
                if (row.Cells[0].Value == null)
                    break;

                if (row.Cells[1].Value != null)
                    renameTxtList.Add(new RenameTxt() { FileName = row.Cells[0].Value.ToString(), Transcription = row.Cells[1].Value.ToString() });
                else
                    renameTxtList.Add(new RenameTxt() { FileName = row.Cells[0].Value.ToString() });
            }
            settings.RenameTxtList = renameTxtList;
        }

        private void LoadDGVCellsFromSettings()
        {
            dgv_RenameTxt.Rows.Clear();

            for (int i = 0; i < settings.RenameTxtList.Count; i++)
            {
                dgv_RenameTxt.Rows.Insert(i, settings.RenameTxtList[i].FileName, settings.RenameTxtList[i].Transcription);
            }
        }
    }
}