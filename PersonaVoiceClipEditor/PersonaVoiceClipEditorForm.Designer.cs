using GrayIris.Utilities.UI.Controls;

namespace PersonaVoiceClipEditor
{
    partial class PersonaVoiceClipEditorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonaVoiceClipEditorForm));
            this.progressBar_Main = new System.Windows.Forms.ProgressBar();
            this.tabControl_Main = new GrayIris.Utilities.UI.Controls.YaTabControl();
            this.tabPage_Encoding = new GrayIris.Utilities.UI.Controls.YaTabPage();
            this.lbl_OutFormat = new DarkUI.Controls.DarkLabel();
            this.comboBox_OutFormat = new DarkUI.Controls.DarkComboBox();
            this.lbl_InputDir = new DarkUI.Controls.DarkLabel();
            this.btn_Encode = new DarkUI.Controls.DarkButton();
            this.txt_Key = new DarkUI.Controls.DarkTextBox();
            this.lbl_OutputDir = new DarkUI.Controls.DarkLabel();
            this.chk_UseEncKey = new DarkUI.Controls.DarkCheckBox();
            this.txt_InputDir = new DarkUI.Controls.DarkTextBox();
            this.btn_InputDir = new DarkUI.Controls.DarkButton();
            this.btn_OutputDir = new DarkUI.Controls.DarkButton();
            this.txt_OutputDir = new DarkUI.Controls.DarkTextBox();
            this.tabPage_Renaming = new GrayIris.Utilities.UI.Controls.YaTabPage();
            this.num_Padding = new DarkUI.Controls.DarkNumericUpDown();
            this.lbl_Padding = new DarkUI.Controls.DarkLabel();
            this.btn_RenameOutput = new DarkUI.Controls.DarkButton();
            this.lbl_RenameOutput = new DarkUI.Controls.DarkLabel();
            this.txt_RenameOutput = new DarkUI.Controls.DarkTextBox();
            this.lbl_TxtFile = new DarkUI.Controls.DarkLabel();
            this.lbl_TxtSuffix = new DarkUI.Controls.DarkLabel();
            this.btn_Rename = new DarkUI.Controls.DarkButton();
            this.btn_TxtFile = new DarkUI.Controls.DarkButton();
            this.txt_TxtFile = new DarkUI.Controls.DarkTextBox();
            this.btn_RenameDir = new DarkUI.Controls.DarkButton();
            this.txt_Suffix = new DarkUI.Controls.DarkTextBox();
            this.lbl_RenameDir = new DarkUI.Controls.DarkLabel();
            this.txt_RenameDir = new DarkUI.Controls.DarkTextBox();
            this.Archives = new GrayIris.Utilities.UI.Controls.YaTabPage();
            this.lbl_ArchiveFormat = new DarkUI.Controls.DarkLabel();
            this.comboBox_ArchiveFormat = new DarkUI.Controls.DarkComboBox();
            this.lbl_ArchiveDir = new DarkUI.Controls.DarkLabel();
            this.txt_ArchiveDir = new DarkUI.Controls.DarkTextBox();
            this.lbl_InputArchive = new DarkUI.Controls.DarkLabel();
            this.btn_ArchiveDir = new DarkUI.Controls.DarkButton();
            this.btn_Unpack = new DarkUI.Controls.DarkButton();
            this.lbl_OutputArchive = new DarkUI.Controls.DarkLabel();
            this.btn_InputArchive = new DarkUI.Controls.DarkButton();
            this.btn_OutputArchive = new DarkUI.Controls.DarkButton();
            this.btn_Repack = new DarkUI.Controls.DarkButton();
            this.txt_OutputArchive = new DarkUI.Controls.DarkTextBox();
            this.txt_InputArchive = new DarkUI.Controls.DarkTextBox();
            this.rtb_Log = new System.Windows.Forms.RichTextBox();
            this.comboBox_Preset = new DarkUI.Controls.DarkComboBox();
            this.lbl_Preset = new DarkUI.Controls.DarkLabel();
            this.tabControl_Main.SuspendLayout();
            this.tabPage_Encoding.SuspendLayout();
            this.tabPage_Renaming.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Padding)).BeginInit();
            this.Archives.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar_Main
            // 
            this.progressBar_Main.ForeColor = System.Drawing.Color.Chartreuse;
            this.progressBar_Main.Location = new System.Drawing.Point(-1, 486);
            this.progressBar_Main.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar_Main.Name = "progressBar_Main";
            this.progressBar_Main.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.progressBar_Main.Size = new System.Drawing.Size(578, 29);
            this.progressBar_Main.TabIndex = 40;
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.tabControl_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.tabControl_Main.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.tabControl_Main.CloseButton = false;
            this.tabControl_Main.Controls.Add(this.tabPage_Encoding);
            this.tabControl_Main.Controls.Add(this.tabPage_Renaming);
            this.tabControl_Main.Controls.Add(this.Archives);
            this.tabControl_Main.ForeColor = System.Drawing.Color.Silver;
            this.tabControl_Main.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.tabControl_Main.ImageIndex = -1;
            this.tabControl_Main.ImageList = null;
            this.tabControl_Main.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.tabControl_Main.Location = new System.Drawing.Point(-1, -2);
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.NewTabButton = false;
            this.tabControl_Main.OverIndex = -1;
            this.tabControl_Main.ScrollButtonStyle = GrayIris.Utilities.UI.Controls.YaScrollButtonStyle.Always;
            this.tabControl_Main.SelectedIndex = 1;
            this.tabControl_Main.SelectedTab = this.tabPage_Renaming;
            this.tabControl_Main.Size = new System.Drawing.Size(578, 275);
            this.tabControl_Main.TabDock = System.Windows.Forms.DockStyle.Top;
            this.tabControl_Main.TabDrawer = null;
            this.tabControl_Main.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_Main.TabIndex = 0;
            // 
            // tabPage_Encoding
            // 
            this.tabPage_Encoding.Controls.Add(this.lbl_OutFormat);
            this.tabPage_Encoding.Controls.Add(this.comboBox_OutFormat);
            this.tabPage_Encoding.Controls.Add(this.lbl_InputDir);
            this.tabPage_Encoding.Controls.Add(this.btn_Encode);
            this.tabPage_Encoding.Controls.Add(this.txt_Key);
            this.tabPage_Encoding.Controls.Add(this.lbl_OutputDir);
            this.tabPage_Encoding.Controls.Add(this.chk_UseEncKey);
            this.tabPage_Encoding.Controls.Add(this.txt_InputDir);
            this.tabPage_Encoding.Controls.Add(this.btn_InputDir);
            this.tabPage_Encoding.Controls.Add(this.btn_OutputDir);
            this.tabPage_Encoding.Controls.Add(this.txt_OutputDir);
            this.tabPage_Encoding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPage_Encoding.ImageIndex = -1;
            this.tabPage_Encoding.Location = new System.Drawing.Point(4, 36);
            this.tabPage_Encoding.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_Encoding.Name = "tabPage_Encoding";
            this.tabPage_Encoding.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_Encoding.Size = new System.Drawing.Size(570, 235);
            this.tabPage_Encoding.TabIndex = 1;
            this.tabPage_Encoding.Text = "Encoding";
            // 
            // lbl_OutFormat
            // 
            this.lbl_OutFormat.AutoSize = true;
            this.lbl_OutFormat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_OutFormat.Location = new System.Drawing.Point(407, 19);
            this.lbl_OutFormat.Name = "lbl_OutFormat";
            this.lbl_OutFormat.Size = new System.Drawing.Size(117, 20);
            this.lbl_OutFormat.TabIndex = 10;
            this.lbl_OutFormat.Text = "Output Format:";
            // 
            // comboBox_OutFormat
            // 
            this.comboBox_OutFormat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBox_OutFormat.FormattingEnabled = true;
            this.comboBox_OutFormat.Items.AddRange(new object[] {
            ".adx",
            ".hca",
            ".at9",
            ".wav"});
            this.comboBox_OutFormat.Location = new System.Drawing.Point(411, 44);
            this.comboBox_OutFormat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_OutFormat.Name = "comboBox_OutFormat";
            this.comboBox_OutFormat.Size = new System.Drawing.Size(151, 27);
            this.comboBox_OutFormat.TabIndex = 11;
            this.comboBox_OutFormat.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Changed);
            // 
            // lbl_InputDir
            // 
            this.lbl_InputDir.AutoSize = true;
            this.lbl_InputDir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_InputDir.Location = new System.Drawing.Point(11, 19);
            this.lbl_InputDir.Name = "lbl_InputDir";
            this.lbl_InputDir.Size = new System.Drawing.Size(154, 20);
            this.lbl_InputDir.TabIndex = 2;
            this.lbl_InputDir.Text = "Input Files Directory:";
            // 
            // btn_Encode
            // 
            this.btn_Encode.AllowDrop = true;
            this.btn_Encode.Enabled = false;
            this.btn_Encode.Location = new System.Drawing.Point(411, 135);
            this.btn_Encode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Encode.Name = "btn_Encode";
            this.btn_Encode.Padding = new System.Windows.Forms.Padding(6);
            this.btn_Encode.Size = new System.Drawing.Size(152, 81);
            this.btn_Encode.TabIndex = 12;
            this.btn_Encode.Text = "Encode Files";
            this.btn_Encode.Click += new System.EventHandler(this.Encode_Click);
            this.btn_Encode.DragDrop += new System.Windows.Forms.DragEventHandler(this.Encode_DragDrop);
            this.btn_Encode.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            // 
            // txt_Key
            // 
            this.txt_Key.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txt_Key.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Key.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txt_Key.Location = new System.Drawing.Point(107, 188);
            this.txt_Key.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Key.Name = "txt_Key";
            this.txt_Key.ReadOnly = true;
            this.txt_Key.Size = new System.Drawing.Size(269, 26);
            this.txt_Key.TabIndex = 9;
            this.txt_Key.TextChanged += new System.EventHandler(this.Txt_Changed);
            // 
            // lbl_OutputDir
            // 
            this.lbl_OutputDir.AutoSize = true;
            this.lbl_OutputDir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_OutputDir.Location = new System.Drawing.Point(11, 94);
            this.lbl_OutputDir.Name = "lbl_OutputDir";
            this.lbl_OutputDir.Size = new System.Drawing.Size(166, 20);
            this.lbl_OutputDir.TabIndex = 5;
            this.lbl_OutputDir.Text = "Output Files Directory:";
            // 
            // chk_UseEncKey
            // 
            this.chk_UseEncKey.AutoSize = true;
            this.chk_UseEncKey.Location = new System.Drawing.Point(14, 188);
            this.chk_UseEncKey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chk_UseEncKey.Name = "chk_UseEncKey";
            this.chk_UseEncKey.Size = new System.Drawing.Size(98, 24);
            this.chk_UseEncKey.TabIndex = 8;
            this.chk_UseEncKey.Text = "Use Key:";
            this.chk_UseEncKey.CheckedChanged += new System.EventHandler(this.UseKey_CheckedChanged);
            // 
            // txt_InputDir
            // 
            this.txt_InputDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txt_InputDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_InputDir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txt_InputDir.Location = new System.Drawing.Point(11, 42);
            this.txt_InputDir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_InputDir.Name = "txt_InputDir";
            this.txt_InputDir.ReadOnly = true;
            this.txt_InputDir.Size = new System.Drawing.Size(317, 26);
            this.txt_InputDir.TabIndex = 3;
            this.txt_InputDir.TextChanged += new System.EventHandler(this.EncodeDir_Changed);
            this.txt_InputDir.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            // 
            // btn_InputDir
            // 
            this.btn_InputDir.Location = new System.Drawing.Point(335, 42);
            this.btn_InputDir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_InputDir.Name = "btn_InputDir";
            this.btn_InputDir.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_InputDir.Size = new System.Drawing.Size(42, 26);
            this.btn_InputDir.TabIndex = 4;
            this.btn_InputDir.Text = "...";
            this.btn_InputDir.Click += new System.EventHandler(this.InputDir_Click);
            this.btn_InputDir.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            // 
            // btn_OutputDir
            // 
            this.btn_OutputDir.Location = new System.Drawing.Point(335, 119);
            this.btn_OutputDir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_OutputDir.Name = "btn_OutputDir";
            this.btn_OutputDir.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_OutputDir.Size = new System.Drawing.Size(42, 26);
            this.btn_OutputDir.TabIndex = 7;
            this.btn_OutputDir.Text = "...";
            this.btn_OutputDir.Click += new System.EventHandler(this.OutputDir_Click);
            this.btn_OutputDir.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            // 
            // txt_OutputDir
            // 
            this.txt_OutputDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txt_OutputDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_OutputDir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txt_OutputDir.Location = new System.Drawing.Point(11, 118);
            this.txt_OutputDir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_OutputDir.Name = "txt_OutputDir";
            this.txt_OutputDir.ReadOnly = true;
            this.txt_OutputDir.Size = new System.Drawing.Size(317, 26);
            this.txt_OutputDir.TabIndex = 6;
            this.txt_OutputDir.TextChanged += new System.EventHandler(this.EncodeDir_Changed);
            this.txt_OutputDir.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            // 
            // tabPage_Renaming
            // 
            this.tabPage_Renaming.Controls.Add(this.num_Padding);
            this.tabPage_Renaming.Controls.Add(this.lbl_Padding);
            this.tabPage_Renaming.Controls.Add(this.btn_RenameOutput);
            this.tabPage_Renaming.Controls.Add(this.lbl_RenameOutput);
            this.tabPage_Renaming.Controls.Add(this.txt_RenameOutput);
            this.tabPage_Renaming.Controls.Add(this.lbl_TxtFile);
            this.tabPage_Renaming.Controls.Add(this.lbl_TxtSuffix);
            this.tabPage_Renaming.Controls.Add(this.btn_Rename);
            this.tabPage_Renaming.Controls.Add(this.btn_TxtFile);
            this.tabPage_Renaming.Controls.Add(this.txt_TxtFile);
            this.tabPage_Renaming.Controls.Add(this.btn_RenameDir);
            this.tabPage_Renaming.Controls.Add(this.txt_Suffix);
            this.tabPage_Renaming.Controls.Add(this.lbl_RenameDir);
            this.tabPage_Renaming.Controls.Add(this.txt_RenameDir);
            this.tabPage_Renaming.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPage_Renaming.ImageIndex = -1;
            this.tabPage_Renaming.Location = new System.Drawing.Point(4, 36);
            this.tabPage_Renaming.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_Renaming.Name = "tabPage_Renaming";
            this.tabPage_Renaming.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_Renaming.Size = new System.Drawing.Size(570, 235);
            this.tabPage_Renaming.TabIndex = 13;
            this.tabPage_Renaming.Text = "Renaming";
            this.tabPage_Renaming.DragDrop += new System.Windows.Forms.DragEventHandler(this.Txt_DragDrop);
            this.tabPage_Renaming.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            // 
            // num_Padding
            // 
            this.num_Padding.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_Padding.Location = new System.Drawing.Point(411, 99);
            this.num_Padding.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.num_Padding.Name = "num_Padding";
            this.num_Padding.Size = new System.Drawing.Size(152, 26);
            this.num_Padding.TabIndex = 23;
            this.num_Padding.ValueChanged += new System.EventHandler(this.Value_Changed);
            // 
            // lbl_Padding
            // 
            this.lbl_Padding.AutoSize = true;
            this.lbl_Padding.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_Padding.Location = new System.Drawing.Point(407, 76);
            this.lbl_Padding.Name = "lbl_Padding";
            this.lbl_Padding.Size = new System.Drawing.Size(103, 20);
            this.lbl_Padding.TabIndex = 23;
            this.lbl_Padding.Text = "Left Padding:";
            // 
            // btn_RenameOutput
            // 
            this.btn_RenameOutput.Location = new System.Drawing.Point(335, 188);
            this.btn_RenameOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_RenameOutput.Name = "btn_RenameOutput";
            this.btn_RenameOutput.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_RenameOutput.Size = new System.Drawing.Size(42, 26);
            this.btn_RenameOutput.TabIndex = 21;
            this.btn_RenameOutput.Text = "...";
            this.btn_RenameOutput.Click += new System.EventHandler(this.RenameOutputDir_Click);
            this.btn_RenameOutput.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            // 
            // lbl_RenameOutput
            // 
            this.lbl_RenameOutput.AutoSize = true;
            this.lbl_RenameOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_RenameOutput.Location = new System.Drawing.Point(11, 164);
            this.lbl_RenameOutput.Name = "lbl_RenameOutput";
            this.lbl_RenameOutput.Size = new System.Drawing.Size(129, 20);
            this.lbl_RenameOutput.TabIndex = 19;
            this.lbl_RenameOutput.Text = "Output Directory:";
            // 
            // txt_RenameOutput
            // 
            this.txt_RenameOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txt_RenameOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_RenameOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txt_RenameOutput.Location = new System.Drawing.Point(11, 188);
            this.txt_RenameOutput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_RenameOutput.Name = "txt_RenameOutput";
            this.txt_RenameOutput.Size = new System.Drawing.Size(317, 26);
            this.txt_RenameOutput.TabIndex = 20;
            this.txt_RenameOutput.TextChanged += new System.EventHandler(this.Txt_Changed);
            this.txt_RenameOutput.DragDrop += new System.Windows.Forms.DragEventHandler(this.Txt_DragDrop);
            this.txt_RenameOutput.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            // 
            // lbl_TxtFile
            // 
            this.lbl_TxtFile.AutoSize = true;
            this.lbl_TxtFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_TxtFile.Location = new System.Drawing.Point(11, 19);
            this.lbl_TxtFile.Name = "lbl_TxtFile";
            this.lbl_TxtFile.Size = new System.Drawing.Size(240, 20);
            this.lbl_TxtFile.TabIndex = 13;
            this.lbl_TxtFile.Text = ".Txt File With Filenames in Order:";
            // 
            // lbl_TxtSuffix
            // 
            this.lbl_TxtSuffix.AutoSize = true;
            this.lbl_TxtSuffix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_TxtSuffix.Location = new System.Drawing.Point(407, 19);
            this.lbl_TxtSuffix.Name = "lbl_TxtSuffix";
            this.lbl_TxtSuffix.Size = new System.Drawing.Size(103, 20);
            this.lbl_TxtSuffix.TabIndex = 22;
            this.lbl_TxtSuffix.Text = ".Txt ID Suffix:";
            // 
            // btn_Rename
            // 
            this.btn_Rename.AllowDrop = true;
            this.btn_Rename.Enabled = false;
            this.btn_Rename.Location = new System.Drawing.Point(411, 135);
            this.btn_Rename.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Rename.Name = "btn_Rename";
            this.btn_Rename.Padding = new System.Windows.Forms.Padding(6);
            this.btn_Rename.Size = new System.Drawing.Size(152, 81);
            this.btn_Rename.TabIndex = 24;
            this.btn_Rename.Text = "Rename Files";
            this.btn_Rename.Click += new System.EventHandler(this.Rename_Click);
            this.btn_Rename.DragDrop += new System.Windows.Forms.DragEventHandler(this.Rename_DragDrop);
            this.btn_Rename.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            // 
            // btn_TxtFile
            // 
            this.btn_TxtFile.Location = new System.Drawing.Point(335, 42);
            this.btn_TxtFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TxtFile.Name = "btn_TxtFile";
            this.btn_TxtFile.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_TxtFile.Size = new System.Drawing.Size(42, 26);
            this.btn_TxtFile.TabIndex = 15;
            this.btn_TxtFile.Text = "...";
            this.btn_TxtFile.Click += new System.EventHandler(this.Txt_Click);
            this.btn_TxtFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            // 
            // txt_TxtFile
            // 
            this.txt_TxtFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txt_TxtFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TxtFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txt_TxtFile.Location = new System.Drawing.Point(11, 42);
            this.txt_TxtFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_TxtFile.Name = "txt_TxtFile";
            this.txt_TxtFile.Size = new System.Drawing.Size(317, 26);
            this.txt_TxtFile.TabIndex = 14;
            this.txt_TxtFile.TextChanged += new System.EventHandler(this.RenamePath_Changed);
            this.txt_TxtFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.Txt_DragDrop);
            this.txt_TxtFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            // 
            // btn_RenameDir
            // 
            this.btn_RenameDir.Location = new System.Drawing.Point(335, 119);
            this.btn_RenameDir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_RenameDir.Name = "btn_RenameDir";
            this.btn_RenameDir.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_RenameDir.Size = new System.Drawing.Size(42, 26);
            this.btn_RenameDir.TabIndex = 18;
            this.btn_RenameDir.Text = "...";
            this.btn_RenameDir.Click += new System.EventHandler(this.RenameDir_Click);
            this.btn_RenameDir.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            // 
            // txt_Suffix
            // 
            this.txt_Suffix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txt_Suffix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Suffix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txt_Suffix.Location = new System.Drawing.Point(411, 44);
            this.txt_Suffix.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Suffix.Name = "txt_Suffix";
            this.txt_Suffix.ReadOnly = true;
            this.txt_Suffix.Size = new System.Drawing.Size(152, 26);
            this.txt_Suffix.TabIndex = 23;
            this.txt_Suffix.TextChanged += new System.EventHandler(this.Txt_Changed);
            // 
            // lbl_RenameDir
            // 
            this.lbl_RenameDir.AutoSize = true;
            this.lbl_RenameDir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_RenameDir.Location = new System.Drawing.Point(11, 94);
            this.lbl_RenameDir.Name = "lbl_RenameDir";
            this.lbl_RenameDir.Size = new System.Drawing.Size(214, 20);
            this.lbl_RenameDir.TabIndex = 16;
            this.lbl_RenameDir.Text = "Directory of Files to Rename:";
            // 
            // txt_RenameDir
            // 
            this.txt_RenameDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txt_RenameDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_RenameDir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txt_RenameDir.Location = new System.Drawing.Point(11, 118);
            this.txt_RenameDir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_RenameDir.Name = "txt_RenameDir";
            this.txt_RenameDir.Size = new System.Drawing.Size(317, 26);
            this.txt_RenameDir.TabIndex = 17;
            this.txt_RenameDir.TextChanged += new System.EventHandler(this.Txt_Changed);
            this.txt_RenameDir.DragDrop += new System.Windows.Forms.DragEventHandler(this.Txt_DragDrop);
            this.txt_RenameDir.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            // 
            // Archives
            // 
            this.Archives.Controls.Add(this.lbl_ArchiveFormat);
            this.Archives.Controls.Add(this.comboBox_ArchiveFormat);
            this.Archives.Controls.Add(this.lbl_ArchiveDir);
            this.Archives.Controls.Add(this.txt_ArchiveDir);
            this.Archives.Controls.Add(this.lbl_InputArchive);
            this.Archives.Controls.Add(this.btn_ArchiveDir);
            this.Archives.Controls.Add(this.btn_Unpack);
            this.Archives.Controls.Add(this.lbl_OutputArchive);
            this.Archives.Controls.Add(this.btn_InputArchive);
            this.Archives.Controls.Add(this.btn_OutputArchive);
            this.Archives.Controls.Add(this.btn_Repack);
            this.Archives.Controls.Add(this.txt_OutputArchive);
            this.Archives.Controls.Add(this.txt_InputArchive);
            this.Archives.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Archives.ImageIndex = -1;
            this.Archives.Location = new System.Drawing.Point(4, 36);
            this.Archives.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Archives.Name = "Archives";
            this.Archives.Size = new System.Drawing.Size(570, 235);
            this.Archives.TabIndex = 25;
            this.Archives.Text = "Archives";
            // 
            // lbl_ArchiveFormat
            // 
            this.lbl_ArchiveFormat.AutoSize = true;
            this.lbl_ArchiveFormat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_ArchiveFormat.Location = new System.Drawing.Point(407, 19);
            this.lbl_ArchiveFormat.Name = "lbl_ArchiveFormat";
            this.lbl_ArchiveFormat.Size = new System.Drawing.Size(120, 20);
            this.lbl_ArchiveFormat.TabIndex = 35;
            this.lbl_ArchiveFormat.Text = "Archive Format:";
            // 
            // comboBox_ArchiveFormat
            // 
            this.comboBox_ArchiveFormat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBox_ArchiveFormat.FormattingEnabled = true;
            this.comboBox_ArchiveFormat.Location = new System.Drawing.Point(411, 44);
            this.comboBox_ArchiveFormat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_ArchiveFormat.Name = "comboBox_ArchiveFormat";
            this.comboBox_ArchiveFormat.Size = new System.Drawing.Size(151, 27);
            this.comboBox_ArchiveFormat.TabIndex = 36;
            this.comboBox_ArchiveFormat.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Changed);
            // 
            // lbl_ArchiveDir
            // 
            this.lbl_ArchiveDir.AutoSize = true;
            this.lbl_ArchiveDir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_ArchiveDir.Location = new System.Drawing.Point(11, 94);
            this.lbl_ArchiveDir.Name = "lbl_ArchiveDir";
            this.lbl_ArchiveDir.Size = new System.Drawing.Size(204, 20);
            this.lbl_ArchiveDir.TabIndex = 29;
            this.lbl_ArchiveDir.Text = "Extracted Archive Directory:";
            // 
            // txt_ArchiveDir
            // 
            this.txt_ArchiveDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txt_ArchiveDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ArchiveDir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txt_ArchiveDir.Location = new System.Drawing.Point(11, 118);
            this.txt_ArchiveDir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ArchiveDir.Name = "txt_ArchiveDir";
            this.txt_ArchiveDir.Size = new System.Drawing.Size(317, 26);
            this.txt_ArchiveDir.TabIndex = 30;
            this.txt_ArchiveDir.TextChanged += new System.EventHandler(this.ArchivePath_Changed);
            this.txt_ArchiveDir.DragDrop += new System.Windows.Forms.DragEventHandler(this.Txt_DragDrop);
            this.txt_ArchiveDir.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            // 
            // lbl_InputArchive
            // 
            this.lbl_InputArchive.AutoSize = true;
            this.lbl_InputArchive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_InputArchive.Location = new System.Drawing.Point(11, 19);
            this.lbl_InputArchive.Name = "lbl_InputArchive";
            this.lbl_InputArchive.Size = new System.Drawing.Size(135, 20);
            this.lbl_InputArchive.TabIndex = 26;
            this.lbl_InputArchive.Text = "Input Archive File:";
            // 
            // btn_ArchiveDir
            // 
            this.btn_ArchiveDir.Location = new System.Drawing.Point(335, 119);
            this.btn_ArchiveDir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ArchiveDir.Name = "btn_ArchiveDir";
            this.btn_ArchiveDir.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_ArchiveDir.Size = new System.Drawing.Size(42, 26);
            this.btn_ArchiveDir.TabIndex = 31;
            this.btn_ArchiveDir.Text = "...";
            this.btn_ArchiveDir.Click += new System.EventHandler(this.ExtractedArchiveDir_Click);
            this.btn_ArchiveDir.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            // 
            // btn_Unpack
            // 
            this.btn_Unpack.AllowDrop = true;
            this.btn_Unpack.Enabled = false;
            this.btn_Unpack.Location = new System.Drawing.Point(411, 84);
            this.btn_Unpack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Unpack.Name = "btn_Unpack";
            this.btn_Unpack.Padding = new System.Windows.Forms.Padding(6);
            this.btn_Unpack.Size = new System.Drawing.Size(151, 62);
            this.btn_Unpack.TabIndex = 37;
            this.btn_Unpack.Text = "Unpack Archive";
            this.btn_Unpack.Click += new System.EventHandler(this.Unpack_Click);
            this.btn_Unpack.DragDrop += new System.Windows.Forms.DragEventHandler(this.Unpack_DragDrop);
            this.btn_Unpack.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            // 
            // lbl_OutputArchive
            // 
            this.lbl_OutputArchive.AutoSize = true;
            this.lbl_OutputArchive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_OutputArchive.Location = new System.Drawing.Point(11, 164);
            this.lbl_OutputArchive.Name = "lbl_OutputArchive";
            this.lbl_OutputArchive.Size = new System.Drawing.Size(171, 20);
            this.lbl_OutputArchive.TabIndex = 32;
            this.lbl_OutputArchive.Text = "Repacked Archive File:";
            // 
            // btn_InputArchive
            // 
            this.btn_InputArchive.Location = new System.Drawing.Point(335, 42);
            this.btn_InputArchive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_InputArchive.Name = "btn_InputArchive";
            this.btn_InputArchive.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_InputArchive.Size = new System.Drawing.Size(42, 26);
            this.btn_InputArchive.TabIndex = 28;
            this.btn_InputArchive.Text = "...";
            this.btn_InputArchive.Click += new System.EventHandler(this.InputArchive_Click);
            this.btn_InputArchive.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            // 
            // btn_OutputArchive
            // 
            this.btn_OutputArchive.Location = new System.Drawing.Point(335, 188);
            this.btn_OutputArchive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_OutputArchive.Name = "btn_OutputArchive";
            this.btn_OutputArchive.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_OutputArchive.Size = new System.Drawing.Size(42, 26);
            this.btn_OutputArchive.TabIndex = 34;
            this.btn_OutputArchive.Text = "...";
            this.btn_OutputArchive.Click += new System.EventHandler(this.OutputArchive_Click);
            this.btn_OutputArchive.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            // 
            // btn_Repack
            // 
            this.btn_Repack.AllowDrop = true;
            this.btn_Repack.Enabled = false;
            this.btn_Repack.Location = new System.Drawing.Point(411, 154);
            this.btn_Repack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Repack.Name = "btn_Repack";
            this.btn_Repack.Padding = new System.Windows.Forms.Padding(6);
            this.btn_Repack.Size = new System.Drawing.Size(151, 62);
            this.btn_Repack.TabIndex = 38;
            this.btn_Repack.Text = "Repack Archive";
            this.btn_Repack.Click += new System.EventHandler(this.Repack_Click);
            this.btn_Repack.DragDrop += new System.Windows.Forms.DragEventHandler(this.Repack_DragDrop);
            this.btn_Repack.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            // 
            // txt_OutputArchive
            // 
            this.txt_OutputArchive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txt_OutputArchive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_OutputArchive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txt_OutputArchive.Location = new System.Drawing.Point(11, 188);
            this.txt_OutputArchive.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_OutputArchive.Name = "txt_OutputArchive";
            this.txt_OutputArchive.Size = new System.Drawing.Size(317, 26);
            this.txt_OutputArchive.TabIndex = 33;
            this.txt_OutputArchive.TextChanged += new System.EventHandler(this.ArchivePath_Changed);
            this.txt_OutputArchive.DragDrop += new System.Windows.Forms.DragEventHandler(this.Txt_DragDrop);
            this.txt_OutputArchive.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            // 
            // txt_InputArchive
            // 
            this.txt_InputArchive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txt_InputArchive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_InputArchive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txt_InputArchive.Location = new System.Drawing.Point(11, 42);
            this.txt_InputArchive.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_InputArchive.Name = "txt_InputArchive";
            this.txt_InputArchive.Size = new System.Drawing.Size(317, 26);
            this.txt_InputArchive.TabIndex = 27;
            this.txt_InputArchive.TextChanged += new System.EventHandler(this.ArchivePath_Changed);
            this.txt_InputArchive.DragDrop += new System.Windows.Forms.DragEventHandler(this.Txt_DragDrop);
            this.txt_InputArchive.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            // 
            // rtb_Log
            // 
            this.rtb_Log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.rtb_Log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_Log.ForeColor = System.Drawing.Color.Silver;
            this.rtb_Log.Location = new System.Drawing.Point(3, 274);
            this.rtb_Log.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtb_Log.Name = "rtb_Log";
            this.rtb_Log.ReadOnly = true;
            this.rtb_Log.Size = new System.Drawing.Size(569, 206);
            this.rtb_Log.TabIndex = 39;
            this.rtb_Log.Text = "";
            // 
            // comboBox_Preset
            // 
            this.comboBox_Preset.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBox_Preset.FormattingEnabled = true;
            this.comboBox_Preset.Items.AddRange(new object[] {
            "None",
            "P5R (PC/NX)",
            "P5R (ENG PS4)",
            "P5R (JP PS4)",
            "P5 (PS3)",
            "P3/4"});
            this.comboBox_Preset.Location = new System.Drawing.Point(414, 3);
            this.comboBox_Preset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_Preset.Name = "comboBox_Preset";
            this.comboBox_Preset.Size = new System.Drawing.Size(151, 27);
            this.comboBox_Preset.TabIndex = 0;
            this.comboBox_Preset.SelectedIndexChanged += new System.EventHandler(this.Preset_Changed);
            // 
            // lbl_Preset
            // 
            this.lbl_Preset.AutoSize = true;
            this.lbl_Preset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_Preset.Location = new System.Drawing.Point(349, 6);
            this.lbl_Preset.Name = "lbl_Preset";
            this.lbl_Preset.Size = new System.Drawing.Size(59, 20);
            this.lbl_Preset.TabIndex = 0;
            this.lbl_Preset.Text = "Preset:";
            // 
            // PersonaVoiceClipEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(578, 515);
            this.Controls.Add(this.lbl_Preset);
            this.Controls.Add(this.comboBox_Preset);
            this.Controls.Add(this.rtb_Log);
            this.Controls.Add(this.tabControl_Main);
            this.Controls.Add(this.progressBar_Main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(600, 571);
            this.MinimumSize = new System.Drawing.Size(600, 571);
            this.Name = "PersonaVoiceClipEditorForm";
            this.Text = "Persona Voice Clip Editor";
            this.tabControl_Main.ResumeLayout(false);
            this.tabPage_Encoding.ResumeLayout(false);
            this.tabPage_Encoding.PerformLayout();
            this.tabPage_Renaming.ResumeLayout(false);
            this.tabPage_Renaming.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Padding)).EndInit();
            this.Archives.ResumeLayout(false);
            this.Archives.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DarkUI.Controls.DarkLabel lbl_InputDir;
        private DarkUI.Controls.DarkButton btn_Encode;
        private DarkUI.Controls.DarkTextBox txt_InputDir;
        private DarkUI.Controls.DarkButton btn_InputDir;
        private DarkUI.Controls.DarkButton btn_InputArchive;
        private DarkUI.Controls.DarkTextBox txt_InputArchive;
        private DarkUI.Controls.DarkLabel lbl_InputArchive;
        private DarkUI.Controls.DarkButton btn_Unpack;
        private DarkUI.Controls.DarkButton btn_TxtFile;
        private DarkUI.Controls.DarkTextBox txt_TxtFile;
        private DarkUI.Controls.DarkLabel lbl_TxtFile;
        private DarkUI.Controls.DarkCheckBox chk_UseEncKey;
        private DarkUI.Controls.DarkTextBox txt_Key;
        private System.Windows.Forms.ProgressBar progressBar_Main;
        private DarkUI.Controls.DarkButton btn_Repack;
        private DarkUI.Controls.DarkTextBox txt_OutputDir;
        private DarkUI.Controls.DarkButton btn_OutputDir;
        private DarkUI.Controls.DarkLabel lbl_OutputDir;
        private DarkUI.Controls.DarkLabel lbl_OutputArchive;
        private DarkUI.Controls.DarkTextBox txt_OutputArchive;
        private DarkUI.Controls.DarkButton btn_OutputArchive;
        private DarkUI.Controls.DarkLabel lbl_ArchiveDir;
        private DarkUI.Controls.DarkTextBox txt_ArchiveDir;
        private DarkUI.Controls.DarkButton btn_ArchiveDir;
        private DarkUI.Controls.DarkLabel lbl_TxtSuffix;
        private DarkUI.Controls.DarkTextBox txt_Suffix;
        private DarkUI.Controls.DarkLabel lbl_OutFormat;
        private DarkUI.Controls.DarkComboBox comboBox_OutFormat;
        private GrayIris.Utilities.UI.Controls.YaTabControl tabControl_Main;
        private GrayIris.Utilities.UI.Controls.YaTabPage tabPage_Encoding;
        private GrayIris.Utilities.UI.Controls.YaTabPage tabPage_Renaming;
        private DarkUI.Controls.DarkButton btn_Rename;
        private DarkUI.Controls.DarkButton btn_RenameDir;
        private DarkUI.Controls.DarkTextBox txt_RenameDir;
        private DarkUI.Controls.DarkLabel lbl_RenameDir;
        private GrayIris.Utilities.UI.Controls.YaTabPage Archives;
        private DarkUI.Controls.DarkButton btn_RenameOutput;
        private DarkUI.Controls.DarkLabel lbl_RenameOutput;
        private DarkUI.Controls.DarkTextBox txt_RenameOutput;
        private System.Windows.Forms.RichTextBox rtb_Log;
        private DarkUI.Controls.DarkLabel lbl_ArchiveFormat;
        private DarkUI.Controls.DarkComboBox comboBox_ArchiveFormat;
        private DarkUI.Controls.DarkLabel lbl_Padding;
        private DarkUI.Controls.DarkNumericUpDown num_Padding;
        private DarkUI.Controls.DarkComboBox comboBox_Preset;
        private DarkUI.Controls.DarkLabel lbl_Preset;
    }
}