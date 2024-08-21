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
        private bool RecreateDirectory(string outputDir, bool usePrompt = true)
        {
            if (Directory.Exists(outputDir) &&
                (Directory.GetFiles(outputDir).Count() > 0))
            {
                if (usePrompt)
                {
                    bool userResponse = WinFormsDialogs.ShowMessageBox("Delete directory contents?",
                    $"Any existing files in the following directory will be deleted. " +
                    $"Are you sure you want to continue?\n\n\"{outputDir}\"", MessageBoxButtons.YesNo);
                    if (!userResponse)
                    {
                        Output.Log($"[INFO] Operation cancelled by user.");
                        return false;
                    }
                }
                Output.Log($"[INFO] Deleting existing directory contents: \"{outputDir}\"");
                foreach (var file in Directory.GetFiles(outputDir, "*", SearchOption.TopDirectoryOnly))
                    File.Delete(file);
            }
            else
            {
                Output.Log($"[INFO] Creating directory: \"{outputDir}\"");
                Directory.CreateDirectory(outputDir);
            }
            
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