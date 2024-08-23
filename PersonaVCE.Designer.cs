using MetroSet_UI.Forms;

namespace PersonaVCE
{
    partial class PersonaVCE : MetroSetForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonaVCE));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptionPresetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox_EncryptionPreset = new System.Windows.Forms.ToolStripComboBox();
            this.archiveFormatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox_ArchiveFormat = new System.Windows.Forms.ToolStripComboBox();
            this.soundFormatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox_SoundFormat = new System.Windows.Forms.ToolStripComboBox();
            this.splitContainer_Main = new System.Windows.Forms.SplitContainer();
            this.metroSetTabControl_Main = new MetroSet_UI.Controls.MetroSetTabControl();
            this.tabPage_Encoding = new System.Windows.Forms.TabPage();
            this.tlp_EncodingTab = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_Encryption = new System.Windows.Forms.GroupBox();
            this.tlp_Encryption = new System.Windows.Forms.TableLayoutPanel();
            this.num_EncryptionKey = new System.Windows.Forms.NumericUpDown();
            this.chk_UseEncryption = new System.Windows.Forms.CheckBox();
            this.btn_Decode = new System.Windows.Forms.Button();
            this.btn_Encode = new System.Windows.Forms.Button();
            this.groupBox_LoopPoints = new System.Windows.Forms.GroupBox();
            this.tlp_LoopSettings = new System.Windows.Forms.TableLayoutPanel();
            this.num_LoopStart = new System.Windows.Forms.NumericUpDown();
            this.num_LoopEnd = new System.Windows.Forms.NumericUpDown();
            this.chk_LoopAll = new System.Windows.Forms.CheckBox();
            this.chk_UseLoopPoints = new System.Windows.Forms.CheckBox();
            this.lbl_Loop = new System.Windows.Forms.Label();
            this.tabPage_Renaming = new System.Windows.Forms.TabPage();
            this.splitContainer_Renaming = new System.Windows.Forms.SplitContainer();
            this.tlp_RenamingDGV = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_RenamePaths = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_InputTxtFile = new System.Windows.Forms.GroupBox();
            this.tlp_InputTxtFile = new System.Windows.Forms.TableLayoutPanel();
            this.btn_InputTxtFile = new System.Windows.Forms.Button();
            this.txt_InputTxtFile = new System.Windows.Forms.TextBox();
            this.groupBox_RenameOutputPath = new System.Windows.Forms.GroupBox();
            this.tlp_RenameOutputPath = new System.Windows.Forms.TableLayoutPanel();
            this.btn_RenameOutput = new System.Windows.Forms.Button();
            this.txt_RenameOutputPath = new System.Windows.Forms.TextBox();
            this.groupBox_RenameSourcePath = new System.Windows.Forms.GroupBox();
            this.tlp_RenameSourcePath = new System.Windows.Forms.TableLayoutPanel();
            this.btn_RenameSource = new System.Windows.Forms.Button();
            this.txt_RenameSourcePath = new System.Windows.Forms.TextBox();
            this.groupBox_RenameTxt = new System.Windows.Forms.GroupBox();
            this.dgv_RenameTxt = new System.Windows.Forms.DataGridView();
            this.Filename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlp_RenamingSettings = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_Ryo = new System.Windows.Forms.GroupBox();
            this.tlp_Ryo = new System.Windows.Forms.TableLayoutPanel();
            this.chk_RyoPlayerVol = new System.Windows.Forms.CheckBox();
            this.chk_RyoCueNames = new System.Windows.Forms.CheckBox();
            this.groupBox_RyoFolderSuffix = new System.Windows.Forms.GroupBox();
            this.txt_RyoFolderSuffix = new System.Windows.Forms.TextBox();
            this.groupBox_RyoCategory = new System.Windows.Forms.GroupBox();
            this.num_RyoCategory = new System.Windows.Forms.NumericUpDown();
            this.comboBox_Ryo = new System.Windows.Forms.ComboBox();
            this.chk_Streaming = new System.Windows.Forms.CheckBox();
            this.groupBox_RyoVolume = new System.Windows.Forms.GroupBox();
            this.tlp_Volume = new System.Windows.Forms.TableLayoutPanel();
            this.chk_RyoOverrideVolume = new System.Windows.Forms.CheckBox();
            this.num_RyoVolume = new System.Windows.Forms.NumericUpDown();
            this.btn_Rename = new System.Windows.Forms.Button();
            this.groupBox_RenamingStartID = new System.Windows.Forms.GroupBox();
            this.num_StartID = new System.Windows.Forms.NumericUpDown();
            this.groupBox_RenamingLeftPadding = new System.Windows.Forms.GroupBox();
            this.num_LeftPadding = new System.Windows.Forms.NumericUpDown();
            this.groupBox_RenamingSuffix = new System.Windows.Forms.GroupBox();
            this.tlp_Suffix = new System.Windows.Forms.TableLayoutPanel();
            this.chk_AppendOGName = new System.Windows.Forms.CheckBox();
            this.txt_RenameSuffix = new System.Windows.Forms.TextBox();
            this.tabPage_Archives = new System.Windows.Forms.TabPage();
            this.tlp_Archives = new System.Windows.Forms.TableLayoutPanel();
            this.btn_ExtractArchive = new System.Windows.Forms.Button();
            this.btn_RepackArchive = new System.Windows.Forms.Button();
            this.rtb_Log = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Main)).BeginInit();
            this.splitContainer_Main.Panel1.SuspendLayout();
            this.splitContainer_Main.Panel2.SuspendLayout();
            this.splitContainer_Main.SuspendLayout();
            this.metroSetTabControl_Main.SuspendLayout();
            this.tabPage_Encoding.SuspendLayout();
            this.tlp_EncodingTab.SuspendLayout();
            this.groupBox_Encryption.SuspendLayout();
            this.tlp_Encryption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_EncryptionKey)).BeginInit();
            this.groupBox_LoopPoints.SuspendLayout();
            this.tlp_LoopSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_LoopStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_LoopEnd)).BeginInit();
            this.tabPage_Renaming.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Renaming)).BeginInit();
            this.splitContainer_Renaming.Panel1.SuspendLayout();
            this.splitContainer_Renaming.Panel2.SuspendLayout();
            this.splitContainer_Renaming.SuspendLayout();
            this.tlp_RenamingDGV.SuspendLayout();
            this.tlp_RenamePaths.SuspendLayout();
            this.groupBox_InputTxtFile.SuspendLayout();
            this.tlp_InputTxtFile.SuspendLayout();
            this.groupBox_RenameOutputPath.SuspendLayout();
            this.tlp_RenameOutputPath.SuspendLayout();
            this.groupBox_RenameSourcePath.SuspendLayout();
            this.tlp_RenameSourcePath.SuspendLayout();
            this.groupBox_RenameTxt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RenameTxt)).BeginInit();
            this.tlp_RenamingSettings.SuspendLayout();
            this.groupBox_Ryo.SuspendLayout();
            this.tlp_Ryo.SuspendLayout();
            this.groupBox_RyoFolderSuffix.SuspendLayout();
            this.groupBox_RyoCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_RyoCategory)).BeginInit();
            this.groupBox_RyoVolume.SuspendLayout();
            this.tlp_Volume.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_RyoVolume)).BeginInit();
            this.groupBox_RenamingStartID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_StartID)).BeginInit();
            this.groupBox_RenamingLeftPadding.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_LeftPadding)).BeginInit();
            this.groupBox_RenamingSuffix.SuspendLayout();
            this.tlp_Suffix.SuspendLayout();
            this.tabPage_Archives.SuspendLayout();
            this.tlp_Archives.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowDrop = true;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toggleThemeToolStripMenuItem,
            this.encryptionPresetToolStripMenuItem,
            this.archiveFormatToolStripMenuItem,
            this.soundFormatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(2, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(778, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadProjectToolStripMenuItem,
            this.saveProjectToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadProjectToolStripMenuItem
            // 
            this.loadProjectToolStripMenuItem.Name = "loadProjectToolStripMenuItem";
            this.loadProjectToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.loadProjectToolStripMenuItem.Text = "Load Project";
            this.loadProjectToolStripMenuItem.Click += new System.EventHandler(this.LoadProject_Click);
            // 
            // saveProjectToolStripMenuItem
            // 
            this.saveProjectToolStripMenuItem.Name = "saveProjectToolStripMenuItem";
            this.saveProjectToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.saveProjectToolStripMenuItem.Text = "Save Project";
            this.saveProjectToolStripMenuItem.Click += new System.EventHandler(this.SaveSettings_Click);
            // 
            // toggleThemeToolStripMenuItem
            // 
            this.toggleThemeToolStripMenuItem.Name = "toggleThemeToolStripMenuItem";
            this.toggleThemeToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.toggleThemeToolStripMenuItem.Text = "Toggle Theme";
            this.toggleThemeToolStripMenuItem.Click += new System.EventHandler(this.ToggleTheme_Click);
            // 
            // encryptionPresetToolStripMenuItem
            // 
            this.encryptionPresetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comboBox_EncryptionPreset});
            this.encryptionPresetToolStripMenuItem.Name = "encryptionPresetToolStripMenuItem";
            this.encryptionPresetToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.encryptionPresetToolStripMenuItem.Text = "Encryption Preset";
            // 
            // comboBox_EncryptionPreset
            // 
            this.comboBox_EncryptionPreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_EncryptionPreset.DropDownWidth = 161;
            this.comboBox_EncryptionPreset.Name = "comboBox_EncryptionPreset";
            this.comboBox_EncryptionPreset.Size = new System.Drawing.Size(161, 28);
            this.comboBox_EncryptionPreset.SelectedIndexChanged += new System.EventHandler(this.Preset_Changed);
            // 
            // archiveFormatToolStripMenuItem
            // 
            this.archiveFormatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comboBox_ArchiveFormat});
            this.archiveFormatToolStripMenuItem.Name = "archiveFormatToolStripMenuItem";
            this.archiveFormatToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.archiveFormatToolStripMenuItem.Text = "Archive Format";
            // 
            // comboBox_ArchiveFormat
            // 
            this.comboBox_ArchiveFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ArchiveFormat.Name = "comboBox_ArchiveFormat";
            this.comboBox_ArchiveFormat.Size = new System.Drawing.Size(161, 28);
            this.comboBox_ArchiveFormat.SelectedIndexChanged += new System.EventHandler(this.ArchiveFormat_Changed);
            // 
            // soundFormatToolStripMenuItem
            // 
            this.soundFormatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comboBox_SoundFormat});
            this.soundFormatToolStripMenuItem.Name = "soundFormatToolStripMenuItem";
            this.soundFormatToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.soundFormatToolStripMenuItem.Text = "Sound Format";
            // 
            // comboBox_SoundFormat
            // 
            this.comboBox_SoundFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_SoundFormat.Name = "comboBox_SoundFormat";
            this.comboBox_SoundFormat.Size = new System.Drawing.Size(161, 28);
            this.comboBox_SoundFormat.SelectedIndexChanged += new System.EventHandler(this.SoundFormat_Changed);
            // 
            // splitContainer_Main
            // 
            this.splitContainer_Main.AllowDrop = true;
            this.splitContainer_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Main.Location = new System.Drawing.Point(2, 28);
            this.splitContainer_Main.Name = "splitContainer_Main";
            this.splitContainer_Main.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_Main.Panel1
            // 
            this.splitContainer_Main.Panel1.AllowDrop = true;
            this.splitContainer_Main.Panel1.Controls.Add(this.metroSetTabControl_Main);
            // 
            // splitContainer_Main.Panel2
            // 
            this.splitContainer_Main.Panel2.AllowDrop = true;
            this.splitContainer_Main.Panel2.Controls.Add(this.rtb_Log);
            this.splitContainer_Main.Size = new System.Drawing.Size(778, 573);
            this.splitContainer_Main.SplitterDistance = 508;
            this.splitContainer_Main.TabIndex = 2;
            // 
            // metroSetTabControl_Main
            // 
            this.metroSetTabControl_Main.AllowDrop = true;
            this.metroSetTabControl_Main.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            this.metroSetTabControl_Main.AnimateTime = 200;
            this.metroSetTabControl_Main.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroSetTabControl_Main.Controls.Add(this.tabPage_Encoding);
            this.metroSetTabControl_Main.Controls.Add(this.tabPage_Renaming);
            this.metroSetTabControl_Main.Controls.Add(this.tabPage_Archives);
            this.metroSetTabControl_Main.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroSetTabControl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroSetTabControl_Main.IsDerivedStyle = true;
            this.metroSetTabControl_Main.ItemSize = new System.Drawing.Size(100, 38);
            this.metroSetTabControl_Main.Location = new System.Drawing.Point(0, 0);
            this.metroSetTabControl_Main.Name = "metroSetTabControl_Main";
            this.metroSetTabControl_Main.SelectedIndex = 0;
            this.metroSetTabControl_Main.SelectedTextColor = System.Drawing.Color.White;
            this.metroSetTabControl_Main.Size = new System.Drawing.Size(778, 508);
            this.metroSetTabControl_Main.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.metroSetTabControl_Main.Speed = 100;
            this.metroSetTabControl_Main.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetTabControl_Main.StyleManager = null;
            this.metroSetTabControl_Main.TabIndex = 2;
            this.metroSetTabControl_Main.TabStyle = MetroSet_UI.Enums.TabStyle.Style2;
            this.metroSetTabControl_Main.ThemeAuthor = "Narwin";
            this.metroSetTabControl_Main.ThemeName = "MetroDark";
            this.metroSetTabControl_Main.UnselectedTextColor = System.Drawing.Color.Gray;
            this.metroSetTabControl_Main.UseAnimation = false;
            // 
            // tabPage_Encoding
            // 
            this.tabPage_Encoding.AllowDrop = true;
            this.tabPage_Encoding.Controls.Add(this.tlp_EncodingTab);
            this.tabPage_Encoding.Location = new System.Drawing.Point(4, 42);
            this.tabPage_Encoding.Name = "tabPage_Encoding";
            this.tabPage_Encoding.Size = new System.Drawing.Size(770, 462);
            this.tabPage_Encoding.TabIndex = 0;
            this.tabPage_Encoding.Text = "Encoding";
            // 
            // tlp_EncodingTab
            // 
            this.tlp_EncodingTab.AllowDrop = true;
            this.tlp_EncodingTab.ColumnCount = 2;
            this.tlp_EncodingTab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_EncodingTab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_EncodingTab.Controls.Add(this.groupBox_Encryption, 1, 1);
            this.tlp_EncodingTab.Controls.Add(this.btn_Decode, 1, 0);
            this.tlp_EncodingTab.Controls.Add(this.btn_Encode, 0, 0);
            this.tlp_EncodingTab.Controls.Add(this.groupBox_LoopPoints, 0, 1);
            this.tlp_EncodingTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_EncodingTab.Location = new System.Drawing.Point(0, 0);
            this.tlp_EncodingTab.Name = "tlp_EncodingTab";
            this.tlp_EncodingTab.RowCount = 2;
            this.tlp_EncodingTab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tlp_EncodingTab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tlp_EncodingTab.Size = new System.Drawing.Size(770, 462);
            this.tlp_EncodingTab.TabIndex = 3;
            // 
            // groupBox_Encryption
            // 
            this.groupBox_Encryption.Controls.Add(this.tlp_Encryption);
            this.groupBox_Encryption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Encryption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox_Encryption.Location = new System.Drawing.Point(388, 210);
            this.groupBox_Encryption.Name = "groupBox_Encryption";
            this.groupBox_Encryption.Size = new System.Drawing.Size(379, 249);
            this.groupBox_Encryption.TabIndex = 3;
            this.groupBox_Encryption.TabStop = false;
            this.groupBox_Encryption.Text = "Encryption Key";
            // 
            // tlp_Encryption
            // 
            this.tlp_Encryption.ColumnCount = 1;
            this.tlp_Encryption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.50848F));
            this.tlp_Encryption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.49153F));
            this.tlp_Encryption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tlp_Encryption.Controls.Add(this.num_EncryptionKey, 0, 1);
            this.tlp_Encryption.Controls.Add(this.chk_UseEncryption, 0, 0);
            this.tlp_Encryption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Encryption.Location = new System.Drawing.Point(3, 22);
            this.tlp_Encryption.Name = "tlp_Encryption";
            this.tlp_Encryption.RowCount = 2;
            this.tlp_Encryption.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.81356F));
            this.tlp_Encryption.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.18644F));
            this.tlp_Encryption.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_Encryption.Size = new System.Drawing.Size(373, 224);
            this.tlp_Encryption.TabIndex = 0;
            // 
            // num_EncryptionKey
            // 
            this.num_EncryptionKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.num_EncryptionKey.Location = new System.Drawing.Point(3, 131);
            this.num_EncryptionKey.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.num_EncryptionKey.Name = "num_EncryptionKey";
            this.num_EncryptionKey.Size = new System.Drawing.Size(367, 26);
            this.num_EncryptionKey.TabIndex = 1;
            this.num_EncryptionKey.ValueChanged += new System.EventHandler(this.EncKeyValue_Changed);
            // 
            // chk_UseEncryption
            // 
            this.chk_UseEncryption.AutoSize = true;
            this.chk_UseEncryption.ForeColor = System.Drawing.Color.DimGray;
            this.chk_UseEncryption.Location = new System.Drawing.Point(3, 3);
            this.chk_UseEncryption.Name = "chk_UseEncryption";
            this.chk_UseEncryption.Size = new System.Drawing.Size(216, 24);
            this.chk_UseEncryption.TabIndex = 0;
            this.chk_UseEncryption.Text = "Use New Encryption Key";
            this.chk_UseEncryption.UseVisualStyleBackColor = true;
            this.chk_UseEncryption.CheckedChanged += new System.EventHandler(this.UseEncKey_CheckedChanged);
            // 
            // btn_Decode
            // 
            this.btn_Decode.AllowDrop = true;
            this.btn_Decode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Decode.ForeColor = System.Drawing.Color.DimGray;
            this.btn_Decode.Location = new System.Drawing.Point(388, 3);
            this.btn_Decode.Name = "btn_Decode";
            this.btn_Decode.Size = new System.Drawing.Size(379, 201);
            this.btn_Decode.TabIndex = 1;
            this.btn_Decode.Text = "Drag Files to Decode";
            this.btn_Decode.UseVisualStyleBackColor = true;
            this.btn_Decode.Click += new System.EventHandler(this.Decode_Click);
            this.btn_Decode.DragDrop += new System.Windows.Forms.DragEventHandler(this.Decode_DragDrop);
            this.btn_Decode.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            // 
            // btn_Encode
            // 
            this.btn_Encode.AllowDrop = true;
            this.btn_Encode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Encode.ForeColor = System.Drawing.Color.DimGray;
            this.btn_Encode.Location = new System.Drawing.Point(3, 3);
            this.btn_Encode.Name = "btn_Encode";
            this.btn_Encode.Size = new System.Drawing.Size(379, 201);
            this.btn_Encode.TabIndex = 0;
            this.btn_Encode.Text = "Drag Files to Encode";
            this.btn_Encode.UseVisualStyleBackColor = true;
            this.btn_Encode.Click += new System.EventHandler(this.Encode_Click);
            this.btn_Encode.DragDrop += new System.Windows.Forms.DragEventHandler(this.Encode_DragDrop);
            this.btn_Encode.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            // 
            // groupBox_LoopPoints
            // 
            this.groupBox_LoopPoints.Controls.Add(this.tlp_LoopSettings);
            this.groupBox_LoopPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_LoopPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox_LoopPoints.Location = new System.Drawing.Point(3, 210);
            this.groupBox_LoopPoints.Name = "groupBox_LoopPoints";
            this.groupBox_LoopPoints.Size = new System.Drawing.Size(379, 249);
            this.groupBox_LoopPoints.TabIndex = 2;
            this.groupBox_LoopPoints.TabStop = false;
            this.groupBox_LoopPoints.Text = "Loop Points";
            // 
            // tlp_LoopSettings
            // 
            this.tlp_LoopSettings.ColumnCount = 3;
            this.tlp_LoopSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tlp_LoopSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_LoopSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tlp_LoopSettings.Controls.Add(this.num_LoopStart, 0, 2);
            this.tlp_LoopSettings.Controls.Add(this.num_LoopEnd, 2, 2);
            this.tlp_LoopSettings.Controls.Add(this.chk_LoopAll, 0, 1);
            this.tlp_LoopSettings.Controls.Add(this.chk_UseLoopPoints, 0, 0);
            this.tlp_LoopSettings.Controls.Add(this.lbl_Loop, 1, 2);
            this.tlp_LoopSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_LoopSettings.Location = new System.Drawing.Point(3, 22);
            this.tlp_LoopSettings.Name = "tlp_LoopSettings";
            this.tlp_LoopSettings.RowCount = 3;
            this.tlp_LoopSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlp_LoopSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlp_LoopSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlp_LoopSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_LoopSettings.Size = new System.Drawing.Size(373, 224);
            this.tlp_LoopSettings.TabIndex = 0;
            // 
            // num_LoopStart
            // 
            this.num_LoopStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.num_LoopStart.Location = new System.Drawing.Point(3, 166);
            this.num_LoopStart.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.num_LoopStart.Name = "num_LoopStart";
            this.num_LoopStart.Size = new System.Drawing.Size(161, 26);
            this.num_LoopStart.TabIndex = 6;
            this.num_LoopStart.ValueChanged += new System.EventHandler(this.LoopStartValue_Changed);
            // 
            // num_LoopEnd
            // 
            this.num_LoopEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.num_LoopEnd.Location = new System.Drawing.Point(207, 166);
            this.num_LoopEnd.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.num_LoopEnd.Name = "num_LoopEnd";
            this.num_LoopEnd.Size = new System.Drawing.Size(163, 26);
            this.num_LoopEnd.TabIndex = 5;
            this.num_LoopEnd.ValueChanged += new System.EventHandler(this.LoopEndValue_Changed);
            // 
            // chk_LoopAll
            // 
            this.chk_LoopAll.AutoSize = true;
            this.tlp_LoopSettings.SetColumnSpan(this.chk_LoopAll, 3);
            this.chk_LoopAll.ForeColor = System.Drawing.Color.DimGray;
            this.chk_LoopAll.Location = new System.Drawing.Point(3, 70);
            this.chk_LoopAll.Name = "chk_LoopAll";
            this.chk_LoopAll.Size = new System.Drawing.Size(164, 24);
            this.chk_LoopAll.TabIndex = 4;
            this.chk_LoopAll.Text = "Loop Entire Track";
            this.chk_LoopAll.UseVisualStyleBackColor = true;
            this.chk_LoopAll.CheckedChanged += new System.EventHandler(this.LoopAll_CheckedChanged);
            // 
            // chk_UseLoopPoints
            // 
            this.chk_UseLoopPoints.AutoSize = true;
            this.tlp_LoopSettings.SetColumnSpan(this.chk_UseLoopPoints, 3);
            this.chk_UseLoopPoints.ForeColor = System.Drawing.Color.DimGray;
            this.chk_UseLoopPoints.Location = new System.Drawing.Point(3, 3);
            this.chk_UseLoopPoints.Name = "chk_UseLoopPoints";
            this.chk_UseLoopPoints.Size = new System.Drawing.Size(193, 24);
            this.chk_UseLoopPoints.TabIndex = 0;
            this.chk_UseLoopPoints.Text = "Use New Loop Points";
            this.chk_UseLoopPoints.UseVisualStyleBackColor = true;
            this.chk_UseLoopPoints.CheckedChanged += new System.EventHandler(this.UseLoops_Checked);
            // 
            // lbl_Loop
            // 
            this.lbl_Loop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Loop.AutoSize = true;
            this.lbl_Loop.ForeColor = System.Drawing.Color.Black;
            this.lbl_Loop.Location = new System.Drawing.Point(170, 169);
            this.lbl_Loop.Name = "lbl_Loop";
            this.lbl_Loop.Size = new System.Drawing.Size(31, 20);
            this.lbl_Loop.TabIndex = 1;
            this.lbl_Loop.Text = " - ";
            this.lbl_Loop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage_Renaming
            // 
            this.tabPage_Renaming.AllowDrop = true;
            this.tabPage_Renaming.Controls.Add(this.splitContainer_Renaming);
            this.tabPage_Renaming.Location = new System.Drawing.Point(4, 42);
            this.tabPage_Renaming.Name = "tabPage_Renaming";
            this.tabPage_Renaming.Size = new System.Drawing.Size(770, 462);
            this.tabPage_Renaming.TabIndex = 1;
            this.tabPage_Renaming.Text = "Renaming";
            // 
            // splitContainer_Renaming
            // 
            this.splitContainer_Renaming.AllowDrop = true;
            this.splitContainer_Renaming.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Renaming.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_Renaming.Name = "splitContainer_Renaming";
            // 
            // splitContainer_Renaming.Panel1
            // 
            this.splitContainer_Renaming.Panel1.AllowDrop = true;
            this.splitContainer_Renaming.Panel1.Controls.Add(this.tlp_RenamingDGV);
            // 
            // splitContainer_Renaming.Panel2
            // 
            this.splitContainer_Renaming.Panel2.AllowDrop = true;
            this.splitContainer_Renaming.Panel2.Controls.Add(this.tlp_RenamingSettings);
            this.splitContainer_Renaming.Size = new System.Drawing.Size(770, 462);
            this.splitContainer_Renaming.SplitterDistance = 467;
            this.splitContainer_Renaming.TabIndex = 4;
            // 
            // tlp_RenamingDGV
            // 
            this.tlp_RenamingDGV.AllowDrop = true;
            this.tlp_RenamingDGV.ColumnCount = 1;
            this.tlp_RenamingDGV.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_RenamingDGV.Controls.Add(this.tlp_RenamePaths, 0, 1);
            this.tlp_RenamingDGV.Controls.Add(this.groupBox_RenameTxt, 0, 0);
            this.tlp_RenamingDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_RenamingDGV.Location = new System.Drawing.Point(0, 0);
            this.tlp_RenamingDGV.Name = "tlp_RenamingDGV";
            this.tlp_RenamingDGV.RowCount = 2;
            this.tlp_RenamingDGV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tlp_RenamingDGV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tlp_RenamingDGV.Size = new System.Drawing.Size(467, 462);
            this.tlp_RenamingDGV.TabIndex = 0;
            // 
            // tlp_RenamePaths
            // 
            this.tlp_RenamePaths.AllowDrop = true;
            this.tlp_RenamePaths.ColumnCount = 1;
            this.tlp_RenamingDGV.SetColumnSpan(this.tlp_RenamePaths, 3);
            this.tlp_RenamePaths.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_RenamePaths.Controls.Add(this.groupBox_InputTxtFile, 0, 2);
            this.tlp_RenamePaths.Controls.Add(this.groupBox_RenameOutputPath, 0, 1);
            this.tlp_RenamePaths.Controls.Add(this.groupBox_RenameSourcePath, 0, 0);
            this.tlp_RenamePaths.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_RenamePaths.Location = new System.Drawing.Point(3, 257);
            this.tlp_RenamePaths.Name = "tlp_RenamePaths";
            this.tlp_RenamePaths.RowCount = 3;
            this.tlp_RenamePaths.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_RenamePaths.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_RenamePaths.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_RenamePaths.Size = new System.Drawing.Size(461, 202);
            this.tlp_RenamePaths.TabIndex = 8;
            // 
            // groupBox_InputTxtFile
            // 
            this.groupBox_InputTxtFile.AllowDrop = true;
            this.groupBox_InputTxtFile.Controls.Add(this.tlp_InputTxtFile);
            this.groupBox_InputTxtFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_InputTxtFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox_InputTxtFile.Location = new System.Drawing.Point(3, 137);
            this.groupBox_InputTxtFile.Name = "groupBox_InputTxtFile";
            this.groupBox_InputTxtFile.Size = new System.Drawing.Size(455, 62);
            this.groupBox_InputTxtFile.TabIndex = 2;
            this.groupBox_InputTxtFile.TabStop = false;
            this.groupBox_InputTxtFile.Text = "Txt File With Filenames In Order Path";
            // 
            // tlp_InputTxtFile
            // 
            this.tlp_InputTxtFile.AllowDrop = true;
            this.tlp_InputTxtFile.ColumnCount = 2;
            this.tlp_InputTxtFile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tlp_InputTxtFile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlp_InputTxtFile.Controls.Add(this.btn_InputTxtFile, 0, 0);
            this.tlp_InputTxtFile.Controls.Add(this.txt_InputTxtFile, 0, 0);
            this.tlp_InputTxtFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_InputTxtFile.Location = new System.Drawing.Point(3, 22);
            this.tlp_InputTxtFile.Name = "tlp_InputTxtFile";
            this.tlp_InputTxtFile.RowCount = 1;
            this.tlp_InputTxtFile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_InputTxtFile.Size = new System.Drawing.Size(449, 37);
            this.tlp_InputTxtFile.TabIndex = 0;
            // 
            // btn_InputTxtFile
            // 
            this.btn_InputTxtFile.AllowDrop = true;
            this.btn_InputTxtFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_InputTxtFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_InputTxtFile.ForeColor = System.Drawing.Color.DimGray;
            this.btn_InputTxtFile.Location = new System.Drawing.Point(384, 3);
            this.btn_InputTxtFile.Name = "btn_InputTxtFile";
            this.btn_InputTxtFile.Size = new System.Drawing.Size(62, 31);
            this.btn_InputTxtFile.TabIndex = 7;
            this.btn_InputTxtFile.Text = "...";
            this.btn_InputTxtFile.UseVisualStyleBackColor = true;
            this.btn_InputTxtFile.Click += new System.EventHandler(this.InputTxtFile_Click);
            // 
            // txt_InputTxtFile
            // 
            this.txt_InputTxtFile.AllowDrop = true;
            this.txt_InputTxtFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_InputTxtFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_InputTxtFile.Location = new System.Drawing.Point(3, 5);
            this.txt_InputTxtFile.Name = "txt_InputTxtFile";
            this.txt_InputTxtFile.Size = new System.Drawing.Size(375, 26);
            this.txt_InputTxtFile.TabIndex = 6;
            this.txt_InputTxtFile.TextChanged += new System.EventHandler(this.InputTxtFilePath_Changed);
            this.txt_InputTxtFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.RenameTxt_DragDrop);
            this.txt_InputTxtFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            // 
            // groupBox_RenameOutputPath
            // 
            this.groupBox_RenameOutputPath.AllowDrop = true;
            this.groupBox_RenameOutputPath.Controls.Add(this.tlp_RenameOutputPath);
            this.groupBox_RenameOutputPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_RenameOutputPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox_RenameOutputPath.Location = new System.Drawing.Point(3, 70);
            this.groupBox_RenameOutputPath.Name = "groupBox_RenameOutputPath";
            this.groupBox_RenameOutputPath.Size = new System.Drawing.Size(455, 61);
            this.groupBox_RenameOutputPath.TabIndex = 1;
            this.groupBox_RenameOutputPath.TabStop = false;
            this.groupBox_RenameOutputPath.Text = "Renamed Files Output Path";
            // 
            // tlp_RenameOutputPath
            // 
            this.tlp_RenameOutputPath.AllowDrop = true;
            this.tlp_RenameOutputPath.ColumnCount = 2;
            this.tlp_RenameOutputPath.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tlp_RenameOutputPath.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlp_RenameOutputPath.Controls.Add(this.btn_RenameOutput, 0, 0);
            this.tlp_RenameOutputPath.Controls.Add(this.txt_RenameOutputPath, 0, 0);
            this.tlp_RenameOutputPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_RenameOutputPath.Location = new System.Drawing.Point(3, 22);
            this.tlp_RenameOutputPath.Name = "tlp_RenameOutputPath";
            this.tlp_RenameOutputPath.RowCount = 1;
            this.tlp_RenameOutputPath.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_RenameOutputPath.Size = new System.Drawing.Size(449, 36);
            this.tlp_RenameOutputPath.TabIndex = 0;
            // 
            // btn_RenameOutput
            // 
            this.btn_RenameOutput.AllowDrop = true;
            this.btn_RenameOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_RenameOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_RenameOutput.ForeColor = System.Drawing.Color.DimGray;
            this.btn_RenameOutput.Location = new System.Drawing.Point(384, 3);
            this.btn_RenameOutput.Name = "btn_RenameOutput";
            this.btn_RenameOutput.Size = new System.Drawing.Size(62, 30);
            this.btn_RenameOutput.TabIndex = 7;
            this.btn_RenameOutput.Text = "...";
            this.btn_RenameOutput.UseVisualStyleBackColor = true;
            this.btn_RenameOutput.Click += new System.EventHandler(this.RenameOutput_Click);
            // 
            // txt_RenameOutputPath
            // 
            this.txt_RenameOutputPath.AllowDrop = true;
            this.txt_RenameOutputPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_RenameOutputPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_RenameOutputPath.Location = new System.Drawing.Point(3, 5);
            this.txt_RenameOutputPath.Name = "txt_RenameOutputPath";
            this.txt_RenameOutputPath.Size = new System.Drawing.Size(375, 26);
            this.txt_RenameOutputPath.TabIndex = 6;
            this.txt_RenameOutputPath.TextChanged += new System.EventHandler(this.RenameOutputPath_Changed);
            this.txt_RenameOutputPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.RenameOutDir_DragDrop);
            this.txt_RenameOutputPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            // 
            // groupBox_RenameSourcePath
            // 
            this.groupBox_RenameSourcePath.AllowDrop = true;
            this.groupBox_RenameSourcePath.Controls.Add(this.tlp_RenameSourcePath);
            this.groupBox_RenameSourcePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_RenameSourcePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox_RenameSourcePath.Location = new System.Drawing.Point(3, 3);
            this.groupBox_RenameSourcePath.Name = "groupBox_RenameSourcePath";
            this.groupBox_RenameSourcePath.Size = new System.Drawing.Size(455, 61);
            this.groupBox_RenameSourcePath.TabIndex = 0;
            this.groupBox_RenameSourcePath.TabStop = false;
            this.groupBox_RenameSourcePath.Text = "Source Sound Files Path";
            // 
            // tlp_RenameSourcePath
            // 
            this.tlp_RenameSourcePath.AllowDrop = true;
            this.tlp_RenameSourcePath.ColumnCount = 2;
            this.tlp_RenameSourcePath.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tlp_RenameSourcePath.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlp_RenameSourcePath.Controls.Add(this.btn_RenameSource, 0, 0);
            this.tlp_RenameSourcePath.Controls.Add(this.txt_RenameSourcePath, 0, 0);
            this.tlp_RenameSourcePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_RenameSourcePath.Location = new System.Drawing.Point(3, 22);
            this.tlp_RenameSourcePath.Name = "tlp_RenameSourcePath";
            this.tlp_RenameSourcePath.RowCount = 1;
            this.tlp_RenameSourcePath.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_RenameSourcePath.Size = new System.Drawing.Size(449, 36);
            this.tlp_RenameSourcePath.TabIndex = 0;
            // 
            // btn_RenameSource
            // 
            this.btn_RenameSource.AllowDrop = true;
            this.btn_RenameSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_RenameSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_RenameSource.ForeColor = System.Drawing.Color.DimGray;
            this.btn_RenameSource.Location = new System.Drawing.Point(384, 3);
            this.btn_RenameSource.Name = "btn_RenameSource";
            this.btn_RenameSource.Size = new System.Drawing.Size(62, 30);
            this.btn_RenameSource.TabIndex = 7;
            this.btn_RenameSource.Text = "...";
            this.btn_RenameSource.UseVisualStyleBackColor = true;
            this.btn_RenameSource.Click += new System.EventHandler(this.RenameDir_Click);
            // 
            // txt_RenameSourcePath
            // 
            this.txt_RenameSourcePath.AllowDrop = true;
            this.txt_RenameSourcePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_RenameSourcePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_RenameSourcePath.Location = new System.Drawing.Point(3, 5);
            this.txt_RenameSourcePath.Name = "txt_RenameSourcePath";
            this.txt_RenameSourcePath.Size = new System.Drawing.Size(375, 26);
            this.txt_RenameSourcePath.TabIndex = 6;
            this.txt_RenameSourcePath.TextChanged += new System.EventHandler(this.RenameSourcePath_Changed);
            this.txt_RenameSourcePath.DragDrop += new System.Windows.Forms.DragEventHandler(this.RenameDir_DragDrop);
            this.txt_RenameSourcePath.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            // 
            // groupBox_RenameTxt
            // 
            this.groupBox_RenameTxt.AllowDrop = true;
            this.tlp_RenamingDGV.SetColumnSpan(this.groupBox_RenameTxt, 3);
            this.groupBox_RenameTxt.Controls.Add(this.dgv_RenameTxt);
            this.groupBox_RenameTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_RenameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox_RenameTxt.Location = new System.Drawing.Point(3, 3);
            this.groupBox_RenameTxt.Name = "groupBox_RenameTxt";
            this.groupBox_RenameTxt.Size = new System.Drawing.Size(461, 248);
            this.groupBox_RenameTxt.TabIndex = 1;
            this.groupBox_RenameTxt.TabStop = false;
            this.groupBox_RenameTxt.Text = "Ordered Filenames From Txt File";
            this.groupBox_RenameTxt.DragDrop += new System.Windows.Forms.DragEventHandler(this.Dgv_DragDrop);
            this.groupBox_RenameTxt.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            // 
            // dgv_RenameTxt
            // 
            this.dgv_RenameTxt.AllowDrop = true;
            this.dgv_RenameTxt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_RenameTxt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_RenameTxt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_RenameTxt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Filename});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_RenameTxt.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_RenameTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_RenameTxt.Location = new System.Drawing.Point(3, 22);
            this.dgv_RenameTxt.Name = "dgv_RenameTxt";
            this.dgv_RenameTxt.ReadOnly = true;
            this.dgv_RenameTxt.RowHeadersWidth = 51;
            this.dgv_RenameTxt.RowTemplate.Height = 24;
            this.dgv_RenameTxt.Size = new System.Drawing.Size(455, 223);
            this.dgv_RenameTxt.TabIndex = 0;
            this.dgv_RenameTxt.DragDrop += new System.Windows.Forms.DragEventHandler(this.Dgv_DragDrop);
            this.dgv_RenameTxt.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            // 
            // Filename
            // 
            this.Filename.HeaderText = "Input Filename";
            this.Filename.MinimumWidth = 6;
            this.Filename.Name = "Filename";
            this.Filename.ReadOnly = true;
            // 
            // tlp_RenamingSettings
            // 
            this.tlp_RenamingSettings.AllowDrop = true;
            this.tlp_RenamingSettings.ColumnCount = 2;
            this.tlp_RenamingSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.4382F));
            this.tlp_RenamingSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.5618F));
            this.tlp_RenamingSettings.Controls.Add(this.groupBox_Ryo, 0, 2);
            this.tlp_RenamingSettings.Controls.Add(this.btn_Rename, 0, 3);
            this.tlp_RenamingSettings.Controls.Add(this.groupBox_RenamingStartID, 0, 1);
            this.tlp_RenamingSettings.Controls.Add(this.groupBox_RenamingLeftPadding, 1, 1);
            this.tlp_RenamingSettings.Controls.Add(this.groupBox_RenamingSuffix, 0, 0);
            this.tlp_RenamingSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_RenamingSettings.Location = new System.Drawing.Point(0, 0);
            this.tlp_RenamingSettings.Name = "tlp_RenamingSettings";
            this.tlp_RenamingSettings.RowCount = 4;
            this.tlp_RenamingSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_RenamingSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlp_RenamingSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tlp_RenamingSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_RenamingSettings.Size = new System.Drawing.Size(299, 462);
            this.tlp_RenamingSettings.TabIndex = 0;
            // 
            // groupBox_Ryo
            // 
            this.tlp_RenamingSettings.SetColumnSpan(this.groupBox_Ryo, 2);
            this.groupBox_Ryo.Controls.Add(this.tlp_Ryo);
            this.groupBox_Ryo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Ryo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox_Ryo.Location = new System.Drawing.Point(3, 164);
            this.groupBox_Ryo.Name = "groupBox_Ryo";
            this.groupBox_Ryo.Size = new System.Drawing.Size(293, 248);
            this.groupBox_Ryo.TabIndex = 12;
            this.groupBox_Ryo.TabStop = false;
            this.groupBox_Ryo.Text = "Ryo Output Settings";
            // 
            // tlp_Ryo
            // 
            this.tlp_Ryo.ColumnCount = 2;
            this.tlp_Ryo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Ryo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Ryo.Controls.Add(this.chk_RyoPlayerVol, 1, 1);
            this.tlp_Ryo.Controls.Add(this.chk_RyoCueNames, 1, 3);
            this.tlp_Ryo.Controls.Add(this.groupBox_RyoFolderSuffix, 0, 3);
            this.tlp_Ryo.Controls.Add(this.groupBox_RyoCategory, 1, 2);
            this.tlp_Ryo.Controls.Add(this.comboBox_Ryo, 0, 0);
            this.tlp_Ryo.Controls.Add(this.chk_Streaming, 0, 1);
            this.tlp_Ryo.Controls.Add(this.groupBox_RyoVolume, 0, 2);
            this.tlp_Ryo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Ryo.Location = new System.Drawing.Point(3, 22);
            this.tlp_Ryo.Name = "tlp_Ryo";
            this.tlp_Ryo.RowCount = 4;
            this.tlp_Ryo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.9499F));
            this.tlp_Ryo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.9499F));
            this.tlp_Ryo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.66012F));
            this.tlp_Ryo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.44008F));
            this.tlp_Ryo.Size = new System.Drawing.Size(287, 223);
            this.tlp_Ryo.TabIndex = 0;
            // 
            // chk_RyoPlayerVol
            // 
            this.chk_RyoPlayerVol.AutoSize = true;
            this.chk_RyoPlayerVol.Checked = true;
            this.chk_RyoPlayerVol.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_RyoPlayerVol.Enabled = false;
            this.chk_RyoPlayerVol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.chk_RyoPlayerVol.ForeColor = System.Drawing.Color.DimGray;
            this.chk_RyoPlayerVol.Location = new System.Drawing.Point(146, 40);
            this.chk_RyoPlayerVol.Name = "chk_RyoPlayerVol";
            this.chk_RyoPlayerVol.Size = new System.Drawing.Size(125, 22);
            this.chk_RyoPlayerVol.TabIndex = 8;
            this.chk_RyoPlayerVol.Text = "Player Volume";
            this.chk_RyoPlayerVol.UseVisualStyleBackColor = true;
            this.chk_RyoPlayerVol.CheckedChanged += new System.EventHandler(this.RyoPlayerVolume_CheckedChanged);
            // 
            // chk_RyoCueNames
            // 
            this.chk_RyoCueNames.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_RyoCueNames.AutoSize = true;
            this.chk_RyoCueNames.Checked = true;
            this.chk_RyoCueNames.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_RyoCueNames.Enabled = false;
            this.chk_RyoCueNames.ForeColor = System.Drawing.Color.DimGray;
            this.chk_RyoCueNames.Location = new System.Drawing.Point(146, 180);
            this.chk_RyoCueNames.Name = "chk_RyoCueNames";
            this.chk_RyoCueNames.Size = new System.Drawing.Size(138, 24);
            this.chk_RyoCueNames.TabIndex = 7;
            this.chk_RyoCueNames.Text = "Cue Names";
            this.chk_RyoCueNames.UseVisualStyleBackColor = true;
            this.chk_RyoCueNames.CheckedChanged += new System.EventHandler(this.RyoCueNames_CheckedChanged);
            // 
            // groupBox_RyoFolderSuffix
            // 
            this.groupBox_RyoFolderSuffix.Controls.Add(this.txt_RyoFolderSuffix);
            this.groupBox_RyoFolderSuffix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_RyoFolderSuffix.Location = new System.Drawing.Point(3, 165);
            this.groupBox_RyoFolderSuffix.Name = "groupBox_RyoFolderSuffix";
            this.groupBox_RyoFolderSuffix.Size = new System.Drawing.Size(137, 55);
            this.groupBox_RyoFolderSuffix.TabIndex = 5;
            this.groupBox_RyoFolderSuffix.TabStop = false;
            this.groupBox_RyoFolderSuffix.Text = "Folder Suffix";
            // 
            // txt_RyoFolderSuffix
            // 
            this.txt_RyoFolderSuffix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_RyoFolderSuffix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_RyoFolderSuffix.Enabled = false;
            this.txt_RyoFolderSuffix.Location = new System.Drawing.Point(6, 23);
            this.txt_RyoFolderSuffix.Name = "txt_RyoFolderSuffix";
            this.txt_RyoFolderSuffix.Size = new System.Drawing.Size(125, 26);
            this.txt_RyoFolderSuffix.TabIndex = 5;
            this.txt_RyoFolderSuffix.TextChanged += new System.EventHandler(this.RyoFolderSuffix_TextChanged);
            // 
            // groupBox_RyoCategory
            // 
            this.groupBox_RyoCategory.Controls.Add(this.num_RyoCategory);
            this.groupBox_RyoCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_RyoCategory.Location = new System.Drawing.Point(146, 77);
            this.groupBox_RyoCategory.Name = "groupBox_RyoCategory";
            this.groupBox_RyoCategory.Size = new System.Drawing.Size(138, 82);
            this.groupBox_RyoCategory.TabIndex = 4;
            this.groupBox_RyoCategory.TabStop = false;
            this.groupBox_RyoCategory.Text = "Category";
            // 
            // num_RyoCategory
            // 
            this.num_RyoCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.num_RyoCategory.Enabled = false;
            this.num_RyoCategory.Location = new System.Drawing.Point(6, 31);
            this.num_RyoCategory.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.num_RyoCategory.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.num_RyoCategory.Name = "num_RyoCategory";
            this.num_RyoCategory.Size = new System.Drawing.Size(126, 26);
            this.num_RyoCategory.TabIndex = 1;
            this.num_RyoCategory.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.num_RyoCategory.ValueChanged += new System.EventHandler(this.RyoCategory_ValueChanged);
            // 
            // comboBox_Ryo
            // 
            this.comboBox_Ryo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_Ryo.SetColumnSpan(this.comboBox_Ryo, 2);
            this.comboBox_Ryo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Ryo.FormattingEnabled = true;
            this.comboBox_Ryo.Location = new System.Drawing.Point(3, 6);
            this.comboBox_Ryo.Name = "comboBox_Ryo";
            this.comboBox_Ryo.Size = new System.Drawing.Size(281, 28);
            this.comboBox_Ryo.TabIndex = 1;
            this.comboBox_Ryo.SelectedIndexChanged += new System.EventHandler(this.RyoOutput_SelectedIndexChanged);
            // 
            // chk_Streaming
            // 
            this.chk_Streaming.AutoSize = true;
            this.chk_Streaming.Checked = true;
            this.chk_Streaming.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_Streaming.Enabled = false;
            this.chk_Streaming.ForeColor = System.Drawing.Color.DimGray;
            this.chk_Streaming.Location = new System.Drawing.Point(3, 40);
            this.chk_Streaming.Name = "chk_Streaming";
            this.chk_Streaming.Size = new System.Drawing.Size(107, 24);
            this.chk_Streaming.TabIndex = 2;
            this.chk_Streaming.Text = "Streaming";
            this.chk_Streaming.UseVisualStyleBackColor = true;
            this.chk_Streaming.CheckedChanged += new System.EventHandler(this.RyoStreaming_CheckedChanged);
            // 
            // groupBox_RyoVolume
            // 
            this.groupBox_RyoVolume.Controls.Add(this.tlp_Volume);
            this.groupBox_RyoVolume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_RyoVolume.Location = new System.Drawing.Point(3, 77);
            this.groupBox_RyoVolume.Name = "groupBox_RyoVolume";
            this.groupBox_RyoVolume.Size = new System.Drawing.Size(137, 82);
            this.groupBox_RyoVolume.TabIndex = 3;
            this.groupBox_RyoVolume.TabStop = false;
            this.groupBox_RyoVolume.Text = "Volume";
            // 
            // tlp_Volume
            // 
            this.tlp_Volume.ColumnCount = 1;
            this.tlp_Volume.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Volume.Controls.Add(this.chk_RyoOverrideVolume, 0, 1);
            this.tlp_Volume.Controls.Add(this.num_RyoVolume, 0, 0);
            this.tlp_Volume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Volume.Location = new System.Drawing.Point(3, 22);
            this.tlp_Volume.Name = "tlp_Volume";
            this.tlp_Volume.RowCount = 2;
            this.tlp_Volume.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Volume.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Volume.Size = new System.Drawing.Size(131, 57);
            this.tlp_Volume.TabIndex = 0;
            // 
            // chk_RyoOverrideVolume
            // 
            this.chk_RyoOverrideVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_RyoOverrideVolume.AutoSize = true;
            this.chk_RyoOverrideVolume.Checked = true;
            this.chk_RyoOverrideVolume.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_RyoOverrideVolume.Enabled = false;
            this.chk_RyoOverrideVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.chk_RyoOverrideVolume.ForeColor = System.Drawing.Color.DimGray;
            this.chk_RyoOverrideVolume.Location = new System.Drawing.Point(3, 33);
            this.chk_RyoOverrideVolume.Name = "chk_RyoOverrideVolume";
            this.chk_RyoOverrideVolume.Size = new System.Drawing.Size(125, 19);
            this.chk_RyoOverrideVolume.TabIndex = 8;
            this.chk_RyoOverrideVolume.Text = "Override Volume";
            this.chk_RyoOverrideVolume.UseVisualStyleBackColor = true;
            this.chk_RyoOverrideVolume.CheckedChanged += new System.EventHandler(this.RyoOverrideVolume_CheckedChanged);
            // 
            // num_RyoVolume
            // 
            this.num_RyoVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.num_RyoVolume.DecimalPlaces = 1;
            this.num_RyoVolume.Enabled = false;
            this.num_RyoVolume.Location = new System.Drawing.Point(3, 3);
            this.num_RyoVolume.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_RyoVolume.Name = "num_RyoVolume";
            this.num_RyoVolume.Size = new System.Drawing.Size(125, 26);
            this.num_RyoVolume.TabIndex = 2;
            this.num_RyoVolume.Value = new decimal(new int[] {
            4,
            0,
            0,
            65536});
            this.num_RyoVolume.ValueChanged += new System.EventHandler(this.RyoVolume_ValueChanged);
            // 
            // btn_Rename
            // 
            this.tlp_RenamingSettings.SetColumnSpan(this.btn_Rename, 2);
            this.btn_Rename.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Rename.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_Rename.ForeColor = System.Drawing.Color.DimGray;
            this.btn_Rename.Location = new System.Drawing.Point(3, 418);
            this.btn_Rename.Name = "btn_Rename";
            this.btn_Rename.Size = new System.Drawing.Size(293, 41);
            this.btn_Rename.TabIndex = 10;
            this.btn_Rename.Text = "Copy and Rename Files";
            this.btn_Rename.UseVisualStyleBackColor = true;
            this.btn_Rename.Click += new System.EventHandler(this.Rename_Click);
            // 
            // groupBox_RenamingStartID
            // 
            this.groupBox_RenamingStartID.Controls.Add(this.num_StartID);
            this.groupBox_RenamingStartID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_RenamingStartID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox_RenamingStartID.Location = new System.Drawing.Point(3, 95);
            this.groupBox_RenamingStartID.Name = "groupBox_RenamingStartID";
            this.groupBox_RenamingStartID.Size = new System.Drawing.Size(141, 63);
            this.groupBox_RenamingStartID.TabIndex = 8;
            this.groupBox_RenamingStartID.TabStop = false;
            this.groupBox_RenamingStartID.Text = "Start ID";
            // 
            // num_StartID
            // 
            this.num_StartID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num_StartID.Location = new System.Drawing.Point(3, 22);
            this.num_StartID.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.num_StartID.Name = "num_StartID";
            this.num_StartID.Size = new System.Drawing.Size(135, 26);
            this.num_StartID.TabIndex = 0;
            this.num_StartID.ValueChanged += new System.EventHandler(this.StartIDValue_Changed);
            // 
            // groupBox_RenamingLeftPadding
            // 
            this.groupBox_RenamingLeftPadding.Controls.Add(this.num_LeftPadding);
            this.groupBox_RenamingLeftPadding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_RenamingLeftPadding.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox_RenamingLeftPadding.Location = new System.Drawing.Point(150, 95);
            this.groupBox_RenamingLeftPadding.Name = "groupBox_RenamingLeftPadding";
            this.groupBox_RenamingLeftPadding.Size = new System.Drawing.Size(146, 63);
            this.groupBox_RenamingLeftPadding.TabIndex = 7;
            this.groupBox_RenamingLeftPadding.TabStop = false;
            this.groupBox_RenamingLeftPadding.Text = "Left Padding";
            // 
            // num_LeftPadding
            // 
            this.num_LeftPadding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num_LeftPadding.Location = new System.Drawing.Point(3, 22);
            this.num_LeftPadding.Name = "num_LeftPadding";
            this.num_LeftPadding.Size = new System.Drawing.Size(140, 26);
            this.num_LeftPadding.TabIndex = 0;
            this.num_LeftPadding.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.num_LeftPadding.ValueChanged += new System.EventHandler(this.LeftPaddingValue_Changed);
            // 
            // groupBox_RenamingSuffix
            // 
            this.tlp_RenamingSettings.SetColumnSpan(this.groupBox_RenamingSuffix, 2);
            this.groupBox_RenamingSuffix.Controls.Add(this.tlp_Suffix);
            this.groupBox_RenamingSuffix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_RenamingSuffix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox_RenamingSuffix.Location = new System.Drawing.Point(3, 3);
            this.groupBox_RenamingSuffix.Name = "groupBox_RenamingSuffix";
            this.groupBox_RenamingSuffix.Size = new System.Drawing.Size(293, 86);
            this.groupBox_RenamingSuffix.TabIndex = 1;
            this.groupBox_RenamingSuffix.TabStop = false;
            this.groupBox_RenamingSuffix.Text = "Suffix";
            // 
            // tlp_Suffix
            // 
            this.tlp_Suffix.ColumnCount = 1;
            this.tlp_Suffix.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Suffix.Controls.Add(this.chk_AppendOGName, 0, 1);
            this.tlp_Suffix.Controls.Add(this.txt_RenameSuffix, 0, 0);
            this.tlp_Suffix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Suffix.Location = new System.Drawing.Point(3, 22);
            this.tlp_Suffix.Name = "tlp_Suffix";
            this.tlp_Suffix.RowCount = 2;
            this.tlp_Suffix.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Suffix.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Suffix.Size = new System.Drawing.Size(287, 61);
            this.tlp_Suffix.TabIndex = 0;
            // 
            // chk_AppendOGName
            // 
            this.chk_AppendOGName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_AppendOGName.AutoSize = true;
            this.chk_AppendOGName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.chk_AppendOGName.ForeColor = System.Drawing.Color.DimGray;
            this.chk_AppendOGName.Location = new System.Drawing.Point(3, 35);
            this.chk_AppendOGName.Name = "chk_AppendOGName";
            this.chk_AppendOGName.Size = new System.Drawing.Size(281, 21);
            this.chk_AppendOGName.TabIndex = 5;
            this.chk_AppendOGName.Text = "Append OG Name";
            this.chk_AppendOGName.UseVisualStyleBackColor = true;
            this.chk_AppendOGName.CheckedChanged += new System.EventHandler(this.AppendOGName_CheckedChanged);
            // 
            // txt_RenameSuffix
            // 
            this.txt_RenameSuffix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_RenameSuffix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_RenameSuffix.Location = new System.Drawing.Point(3, 3);
            this.txt_RenameSuffix.Name = "txt_RenameSuffix";
            this.txt_RenameSuffix.Size = new System.Drawing.Size(281, 26);
            this.txt_RenameSuffix.TabIndex = 4;
            this.txt_RenameSuffix.Text = "_streaming";
            this.txt_RenameSuffix.TextChanged += new System.EventHandler(this.Suffix_Changed);
            // 
            // tabPage_Archives
            // 
            this.tabPage_Archives.Controls.Add(this.tlp_Archives);
            this.tabPage_Archives.Location = new System.Drawing.Point(4, 42);
            this.tabPage_Archives.Name = "tabPage_Archives";
            this.tabPage_Archives.Size = new System.Drawing.Size(770, 462);
            this.tabPage_Archives.TabIndex = 2;
            this.tabPage_Archives.Text = "Archives";
            // 
            // tlp_Archives
            // 
            this.tlp_Archives.ColumnCount = 2;
            this.tlp_Archives.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Archives.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Archives.Controls.Add(this.btn_ExtractArchive, 0, 0);
            this.tlp_Archives.Controls.Add(this.btn_RepackArchive, 1, 0);
            this.tlp_Archives.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Archives.Location = new System.Drawing.Point(0, 0);
            this.tlp_Archives.Name = "tlp_Archives";
            this.tlp_Archives.RowCount = 1;
            this.tlp_Archives.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Archives.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Archives.Size = new System.Drawing.Size(770, 462);
            this.tlp_Archives.TabIndex = 3;
            // 
            // btn_ExtractArchive
            // 
            this.btn_ExtractArchive.AllowDrop = true;
            this.btn_ExtractArchive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ExtractArchive.ForeColor = System.Drawing.Color.DimGray;
            this.btn_ExtractArchive.Location = new System.Drawing.Point(3, 3);
            this.btn_ExtractArchive.Name = "btn_ExtractArchive";
            this.btn_ExtractArchive.Size = new System.Drawing.Size(379, 456);
            this.btn_ExtractArchive.TabIndex = 1;
            this.btn_ExtractArchive.Text = "Drag Archive to Extract";
            this.btn_ExtractArchive.UseVisualStyleBackColor = true;
            this.btn_ExtractArchive.Click += new System.EventHandler(this.ExtractArchive_Click);
            this.btn_ExtractArchive.DragDrop += new System.Windows.Forms.DragEventHandler(this.Extract_DragDrop);
            this.btn_ExtractArchive.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            // 
            // btn_RepackArchive
            // 
            this.btn_RepackArchive.AllowDrop = true;
            this.btn_RepackArchive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_RepackArchive.ForeColor = System.Drawing.Color.DimGray;
            this.btn_RepackArchive.Location = new System.Drawing.Point(388, 3);
            this.btn_RepackArchive.Name = "btn_RepackArchive";
            this.btn_RepackArchive.Size = new System.Drawing.Size(379, 456);
            this.btn_RepackArchive.TabIndex = 2;
            this.btn_RepackArchive.Text = "Drag Folder to Repack";
            this.btn_RepackArchive.UseVisualStyleBackColor = true;
            this.btn_RepackArchive.Click += new System.EventHandler(this.RepackArchive_Click);
            this.btn_RepackArchive.DragDrop += new System.Windows.Forms.DragEventHandler(this.Repack_DragDrop);
            this.btn_RepackArchive.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            // 
            // rtb_Log
            // 
            this.rtb_Log.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.rtb_Log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_Log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_Log.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rtb_Log.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.rtb_Log.Location = new System.Drawing.Point(0, 0);
            this.rtb_Log.Name = "rtb_Log";
            this.rtb_Log.ReadOnly = true;
            this.rtb_Log.Size = new System.Drawing.Size(778, 61);
            this.rtb_Log.TabIndex = 0;
            this.rtb_Log.Text = "";
            // 
            // PersonaVCE
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(782, 603);
            this.Controls.Add(this.splitContainer_Main);
            this.Controls.Add(this.menuStrip1);
            this.DropShadowEffect = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.HeaderHeight = -40;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 650);
            this.Name = "PersonaVCE";
            this.Opacity = 0.99D;
            this.Padding = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.ShowHeader = true;
            this.ShowLeftRect = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Style = MetroSet_UI.Enums.Style.Dark;
            this.Text = "PersonaVCE v2.3.1";
            this.TextColor = System.Drawing.Color.White;
            this.ThemeName = "MetroDark";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer_Main.Panel1.ResumeLayout(false);
            this.splitContainer_Main.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Main)).EndInit();
            this.splitContainer_Main.ResumeLayout(false);
            this.metroSetTabControl_Main.ResumeLayout(false);
            this.tabPage_Encoding.ResumeLayout(false);
            this.tlp_EncodingTab.ResumeLayout(false);
            this.groupBox_Encryption.ResumeLayout(false);
            this.tlp_Encryption.ResumeLayout(false);
            this.tlp_Encryption.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_EncryptionKey)).EndInit();
            this.groupBox_LoopPoints.ResumeLayout(false);
            this.tlp_LoopSettings.ResumeLayout(false);
            this.tlp_LoopSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_LoopStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_LoopEnd)).EndInit();
            this.tabPage_Renaming.ResumeLayout(false);
            this.splitContainer_Renaming.Panel1.ResumeLayout(false);
            this.splitContainer_Renaming.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Renaming)).EndInit();
            this.splitContainer_Renaming.ResumeLayout(false);
            this.tlp_RenamingDGV.ResumeLayout(false);
            this.tlp_RenamePaths.ResumeLayout(false);
            this.groupBox_InputTxtFile.ResumeLayout(false);
            this.tlp_InputTxtFile.ResumeLayout(false);
            this.tlp_InputTxtFile.PerformLayout();
            this.groupBox_RenameOutputPath.ResumeLayout(false);
            this.tlp_RenameOutputPath.ResumeLayout(false);
            this.tlp_RenameOutputPath.PerformLayout();
            this.groupBox_RenameSourcePath.ResumeLayout(false);
            this.tlp_RenameSourcePath.ResumeLayout(false);
            this.tlp_RenameSourcePath.PerformLayout();
            this.groupBox_RenameTxt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RenameTxt)).EndInit();
            this.tlp_RenamingSettings.ResumeLayout(false);
            this.groupBox_Ryo.ResumeLayout(false);
            this.tlp_Ryo.ResumeLayout(false);
            this.tlp_Ryo.PerformLayout();
            this.groupBox_RyoFolderSuffix.ResumeLayout(false);
            this.groupBox_RyoFolderSuffix.PerformLayout();
            this.groupBox_RyoCategory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_RyoCategory)).EndInit();
            this.groupBox_RyoVolume.ResumeLayout(false);
            this.tlp_Volume.ResumeLayout(false);
            this.tlp_Volume.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_RyoVolume)).EndInit();
            this.groupBox_RenamingStartID.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_StartID)).EndInit();
            this.groupBox_RenamingLeftPadding.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_LeftPadding)).EndInit();
            this.groupBox_RenamingSuffix.ResumeLayout(false);
            this.tlp_Suffix.ResumeLayout(false);
            this.tlp_Suffix.PerformLayout();
            this.tabPage_Archives.ResumeLayout(false);
            this.tlp_Archives.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toggleThemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encryptionPresetToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox comboBox_EncryptionPreset;
        private System.Windows.Forms.ToolStripMenuItem archiveFormatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soundFormatToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox comboBox_ArchiveFormat;
        private System.Windows.Forms.ToolStripComboBox comboBox_SoundFormat;
        private System.Windows.Forms.SplitContainer splitContainer_Main;
        private MetroSet_UI.Controls.MetroSetTabControl metroSetTabControl_Main;
        private System.Windows.Forms.TabPage tabPage_Encoding;
        private System.Windows.Forms.TableLayoutPanel tlp_EncodingTab;
        private System.Windows.Forms.GroupBox groupBox_Encryption;
        private System.Windows.Forms.TableLayoutPanel tlp_Encryption;
        private System.Windows.Forms.CheckBox chk_UseEncryption;
        private System.Windows.Forms.Button btn_Decode;
        private System.Windows.Forms.Button btn_Encode;
        private System.Windows.Forms.GroupBox groupBox_LoopPoints;
        private System.Windows.Forms.TableLayoutPanel tlp_LoopSettings;
        private System.Windows.Forms.CheckBox chk_UseLoopPoints;
        private System.Windows.Forms.Label lbl_Loop;
        private System.Windows.Forms.TabPage tabPage_Renaming;
        private System.Windows.Forms.TabPage tabPage_Archives;
        private System.Windows.Forms.TableLayoutPanel tlp_Archives;
        private System.Windows.Forms.Button btn_ExtractArchive;
        private System.Windows.Forms.Button btn_RepackArchive;
        private System.Windows.Forms.RichTextBox rtb_Log;
        private System.Windows.Forms.CheckBox chk_LoopAll;
        private System.Windows.Forms.NumericUpDown num_EncryptionKey;
        private System.Windows.Forms.NumericUpDown num_LoopEnd;
        private System.Windows.Forms.NumericUpDown num_LoopStart;
        private System.Windows.Forms.SplitContainer splitContainer_Renaming;
        private System.Windows.Forms.TableLayoutPanel tlp_RenamingDGV;
        private System.Windows.Forms.TableLayoutPanel tlp_RenamePaths;
        private System.Windows.Forms.GroupBox groupBox_InputTxtFile;
        private System.Windows.Forms.TableLayoutPanel tlp_InputTxtFile;
        private System.Windows.Forms.Button btn_InputTxtFile;
        private System.Windows.Forms.TextBox txt_InputTxtFile;
        private System.Windows.Forms.GroupBox groupBox_RenameOutputPath;
        private System.Windows.Forms.TableLayoutPanel tlp_RenameOutputPath;
        private System.Windows.Forms.Button btn_RenameOutput;
        private System.Windows.Forms.TextBox txt_RenameOutputPath;
        private System.Windows.Forms.GroupBox groupBox_RenameSourcePath;
        private System.Windows.Forms.TableLayoutPanel tlp_RenameSourcePath;
        private System.Windows.Forms.Button btn_RenameSource;
        private System.Windows.Forms.TextBox txt_RenameSourcePath;
        private System.Windows.Forms.GroupBox groupBox_RenameTxt;
        private System.Windows.Forms.DataGridView dgv_RenameTxt;
        private System.Windows.Forms.TableLayoutPanel tlp_RenamingSettings;
        private System.Windows.Forms.GroupBox groupBox_Ryo;
        private System.Windows.Forms.TableLayoutPanel tlp_Ryo;
        private System.Windows.Forms.ComboBox comboBox_Ryo;
        private System.Windows.Forms.CheckBox chk_Streaming;
        private System.Windows.Forms.Button btn_Rename;
        private System.Windows.Forms.GroupBox groupBox_RenamingStartID;
        private System.Windows.Forms.NumericUpDown num_StartID;
        private System.Windows.Forms.GroupBox groupBox_RenamingLeftPadding;
        private System.Windows.Forms.NumericUpDown num_LeftPadding;
        private System.Windows.Forms.GroupBox groupBox_RenamingSuffix;
        private System.Windows.Forms.TableLayoutPanel tlp_Suffix;
        private System.Windows.Forms.CheckBox chk_AppendOGName;
        private System.Windows.Forms.TextBox txt_RenameSuffix;
        private System.Windows.Forms.GroupBox groupBox_RyoVolume;
        private System.Windows.Forms.GroupBox groupBox_RyoCategory;
        private System.Windows.Forms.NumericUpDown num_RyoCategory;
        private System.Windows.Forms.GroupBox groupBox_RyoFolderSuffix;
        private System.Windows.Forms.TextBox txt_RyoFolderSuffix;
        private System.Windows.Forms.CheckBox chk_RyoCueNames;
        private System.Windows.Forms.CheckBox chk_RyoPlayerVol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Filename;
        private System.Windows.Forms.TableLayoutPanel tlp_Volume;
        private System.Windows.Forms.CheckBox chk_RyoOverrideVolume;
        private System.Windows.Forms.NumericUpDown num_RyoVolume;
    }
}