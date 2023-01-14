﻿using ShrineFox.IO;
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
        private bool RecreateDirectory(string outputDir, bool usePrompt = true)
        {
            if (Directory.Exists(outputDir) &&
                (Directory.GetFiles(outputDir).Count() > 0 || Directory.GetDirectories(outputDir).Count() > 0))
            {
                if (usePrompt)
                {
                    bool userResponse = WinFormsDialogs.YesNoMsgBox("Delete directory?",
                    $"Any existing contents of the following directory will be deleted. " +
                    $"Are you sure you want to continue?\n\n\"{outputDir}\"");
                    if (!userResponse)
                    {
                        Output.Log($"[INFO] Operation cancelled by user.");
                        return false;
                    }
                }
                Output.Log($"[INFO] Deleting existing directory: \"{outputDir}\"");
                Directory.Delete(outputDir, true);
            }
            Output.Log($"[INFO] Creating directory: \"{outputDir}\"");
            Directory.CreateDirectory(outputDir);
            return true;
        }

        private void BackupArchive(string file)
        {
            if (!File.Exists(file + ".bak"))
            {
                Output.Log($"[INFO] Creating backup of original archive: \"{file}.bak\"");
                File.Copy(file, file + ".bak");
            }
        }
    }
}