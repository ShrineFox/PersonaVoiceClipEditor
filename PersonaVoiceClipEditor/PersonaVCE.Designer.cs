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
            this.tlp_RenameTxt = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Rename = new System.Windows.Forms.Button();
            this.groupBox_RenameTxt = new System.Windows.Forms.GroupBox();
            this.dgv_RenameTxt = new System.Windows.Forms.DataGridView();
            this.tlp_RenameTxtSettings = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_RenameStartID = new System.Windows.Forms.GroupBox();
            this.num_StartID = new System.Windows.Forms.NumericUpDown();
            this.groupBox_LeftPadding = new System.Windows.Forms.GroupBox();
            this.num_LeftPadding = new System.Windows.Forms.NumericUpDown();
            this.groupBox_Suffix = new System.Windows.Forms.GroupBox();
            this.tlp_Suffix = new System.Windows.Forms.TableLayoutPanel();
            this.chk_AppendOGName = new System.Windows.Forms.CheckBox();
            this.txt_RenameSuffix = new System.Windows.Forms.TextBox();
            this.tlp_RenamePaths = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_RenameOutputPath = new System.Windows.Forms.GroupBox();
            this.tlp_RenameOutputPath = new System.Windows.Forms.TableLayoutPanel();
            this.btn_RenameOutput = new System.Windows.Forms.Button();
            this.txt_RenameOutputPath = new System.Windows.Forms.TextBox();
            this.groupBox_RenameSourcePath = new System.Windows.Forms.GroupBox();
            this.tlp_RenameSourcePath = new System.Windows.Forms.TableLayoutPanel();
            this.btn_RenameSource = new System.Windows.Forms.Button();
            this.txt_RenameSourcePath = new System.Windows.Forms.TextBox();
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
            this.tlp_RenameTxt.SuspendLayout();
            this.groupBox_RenameTxt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RenameTxt)).BeginInit();
            this.tlp_RenameTxtSettings.SuspendLayout();
            this.groupBox_RenameStartID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_StartID)).BeginInit();
            this.groupBox_LeftPadding.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_LeftPadding)).BeginInit();
            this.groupBox_Suffix.SuspendLayout();
            this.tlp_Suffix.SuspendLayout();
            this.tlp_RenamePaths.SuspendLayout();
            this.groupBox_RenameOutputPath.SuspendLayout();
            this.tlp_RenameOutputPath.SuspendLayout();
            this.groupBox_RenameSourcePath.SuspendLayout();
            this.tlp_RenameSourcePath.SuspendLayout();
            this.tabPage_Archives.SuspendLayout();
            this.tlp_Archives.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toggleThemeToolStripMenuItem,
            this.encryptionPresetToolStripMenuItem,
            this.archiveFormatToolStripMenuItem,
            this.soundFormatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(2, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(735, 28);
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
            // 
            // saveProjectToolStripMenuItem
            // 
            this.saveProjectToolStripMenuItem.Name = "saveProjectToolStripMenuItem";
            this.saveProjectToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.saveProjectToolStripMenuItem.Text = "Save Project";
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
            this.comboBox_ArchiveFormat.SelectedIndexChanged += new System.EventHandler(this.DropDownList_Changed);
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
            this.comboBox_SoundFormat.SelectedIndexChanged += new System.EventHandler(this.DropDownList_Changed);
            // 
            // splitContainer_Main
            // 
            this.splitContainer_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Main.Location = new System.Drawing.Point(2, 28);
            this.splitContainer_Main.Name = "splitContainer_Main";
            this.splitContainer_Main.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_Main.Panel1
            // 
            this.splitContainer_Main.Panel1.Controls.Add(this.metroSetTabControl_Main);
            // 
            // splitContainer_Main.Panel2
            // 
            this.splitContainer_Main.Panel2.Controls.Add(this.rtb_Log);
            this.splitContainer_Main.Size = new System.Drawing.Size(735, 592);
            this.splitContainer_Main.SplitterDistance = 446;
            this.splitContainer_Main.TabIndex = 2;
            // 
            // metroSetTabControl_Main
            // 
            this.metroSetTabControl_Main.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            this.metroSetTabControl_Main.AnimateTime = 200;
            this.metroSetTabControl_Main.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroSetTabControl_Main.Controls.Add(this.tabPage_Encoding);
            this.metroSetTabControl_Main.Controls.Add(this.tabPage_Renaming);
            this.metroSetTabControl_Main.Controls.Add(this.tabPage_Archives);
            this.metroSetTabControl_Main.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroSetTabControl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroSetTabControl_Main.IsDerivedStyle = true;
            this.metroSetTabControl_Main.ItemSize = new System.Drawing.Size(100, 38);
            this.metroSetTabControl_Main.Location = new System.Drawing.Point(0, 0);
            this.metroSetTabControl_Main.Name = "metroSetTabControl_Main";
            this.metroSetTabControl_Main.SelectedIndex = 1;
            this.metroSetTabControl_Main.SelectedTextColor = System.Drawing.Color.White;
            this.metroSetTabControl_Main.Size = new System.Drawing.Size(735, 446);
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
            this.tabPage_Encoding.Controls.Add(this.tlp_EncodingTab);
            this.tabPage_Encoding.Location = new System.Drawing.Point(4, 42);
            this.tabPage_Encoding.Name = "tabPage_Encoding";
            this.tabPage_Encoding.Size = new System.Drawing.Size(727, 400);
            this.tabPage_Encoding.TabIndex = 0;
            this.tabPage_Encoding.Text = "Encoding";
            // 
            // tlp_EncodingTab
            // 
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
            this.tlp_EncodingTab.Size = new System.Drawing.Size(727, 400);
            this.tlp_EncodingTab.TabIndex = 3;
            // 
            // groupBox_Encryption
            // 
            this.groupBox_Encryption.Controls.Add(this.tlp_Encryption);
            this.groupBox_Encryption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Encryption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox_Encryption.Location = new System.Drawing.Point(366, 183);
            this.groupBox_Encryption.Name = "groupBox_Encryption";
            this.groupBox_Encryption.Size = new System.Drawing.Size(358, 214);
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
            this.tlp_Encryption.Size = new System.Drawing.Size(352, 189);
            this.tlp_Encryption.TabIndex = 0;
            // 
            // num_EncryptionKey
            // 
            this.num_EncryptionKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.num_EncryptionKey.Location = new System.Drawing.Point(3, 108);
            this.num_EncryptionKey.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.num_EncryptionKey.Name = "num_EncryptionKey";
            this.num_EncryptionKey.Size = new System.Drawing.Size(346, 26);
            this.num_EncryptionKey.TabIndex = 1;
            this.num_EncryptionKey.ValueChanged += new System.EventHandler(this.Value_Changed);
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
            this.chk_UseEncryption.CheckedChanged += new System.EventHandler(this.UseKey_CheckedChanged);
            // 
            // btn_Decode
            // 
            this.btn_Decode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Decode.ForeColor = System.Drawing.Color.DimGray;
            this.btn_Decode.Location = new System.Drawing.Point(366, 3);
            this.btn_Decode.Name = "btn_Decode";
            this.btn_Decode.Size = new System.Drawing.Size(358, 174);
            this.btn_Decode.TabIndex = 1;
            this.btn_Decode.Text = "Drag Files to Decode";
            this.btn_Decode.UseVisualStyleBackColor = true;
            this.btn_Decode.Click += new System.EventHandler(this.Decode_Click);
            this.btn_Decode.DragDrop += new System.Windows.Forms.DragEventHandler(this.Decode_DragDrop);
            this.btn_Decode.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            // 
            // btn_Encode
            // 
            this.btn_Encode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Encode.ForeColor = System.Drawing.Color.DimGray;
            this.btn_Encode.Location = new System.Drawing.Point(3, 3);
            this.btn_Encode.Name = "btn_Encode";
            this.btn_Encode.Size = new System.Drawing.Size(357, 174);
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
            this.groupBox_LoopPoints.Location = new System.Drawing.Point(3, 183);
            this.groupBox_LoopPoints.Name = "groupBox_LoopPoints";
            this.groupBox_LoopPoints.Size = new System.Drawing.Size(357, 214);
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
            this.tlp_LoopSettings.Size = new System.Drawing.Size(351, 189);
            this.tlp_LoopSettings.TabIndex = 0;
            // 
            // num_LoopStart
            // 
            this.num_LoopStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.num_LoopStart.Location = new System.Drawing.Point(3, 137);
            this.num_LoopStart.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.num_LoopStart.Name = "num_LoopStart";
            this.num_LoopStart.Size = new System.Drawing.Size(151, 26);
            this.num_LoopStart.TabIndex = 6;
            this.num_LoopStart.ValueChanged += new System.EventHandler(this.Value_Changed);
            // 
            // num_LoopEnd
            // 
            this.num_LoopEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.num_LoopEnd.Location = new System.Drawing.Point(195, 137);
            this.num_LoopEnd.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.num_LoopEnd.Name = "num_LoopEnd";
            this.num_LoopEnd.Size = new System.Drawing.Size(153, 26);
            this.num_LoopEnd.TabIndex = 5;
            this.num_LoopEnd.ValueChanged += new System.EventHandler(this.Value_Changed);
            // 
            // chk_LoopAll
            // 
            this.chk_LoopAll.AutoSize = true;
            this.chk_LoopAll.ForeColor = System.Drawing.Color.DimGray;
            this.chk_LoopAll.Location = new System.Drawing.Point(3, 59);
            this.chk_LoopAll.Name = "chk_LoopAll";
            this.chk_LoopAll.Size = new System.Drawing.Size(92, 24);
            this.chk_LoopAll.TabIndex = 4;
            this.chk_LoopAll.Text = "Loop All";
            this.chk_LoopAll.UseVisualStyleBackColor = true;
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
            this.lbl_Loop.Location = new System.Drawing.Point(160, 140);
            this.lbl_Loop.Name = "lbl_Loop";
            this.lbl_Loop.Size = new System.Drawing.Size(29, 20);
            this.lbl_Loop.TabIndex = 1;
            this.lbl_Loop.Text = " - ";
            this.lbl_Loop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage_Renaming
            // 
            this.tabPage_Renaming.Controls.Add(this.tlp_RenameTxt);
            this.tabPage_Renaming.Location = new System.Drawing.Point(4, 42);
            this.tabPage_Renaming.Name = "tabPage_Renaming";
            this.tabPage_Renaming.Size = new System.Drawing.Size(727, 400);
            this.tabPage_Renaming.TabIndex = 1;
            this.tabPage_Renaming.Text = "Renaming";
            // 
            // tlp_RenameTxt
            // 
            this.tlp_RenameTxt.ColumnCount = 4;
            this.tlp_RenameTxt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_RenameTxt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_RenameTxt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlp_RenameTxt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlp_RenameTxt.Controls.Add(this.btn_Rename, 2, 1);
            this.tlp_RenameTxt.Controls.Add(this.groupBox_RenameTxt, 0, 0);
            this.tlp_RenameTxt.Controls.Add(this.tlp_RenameTxtSettings, 3, 0);
            this.tlp_RenameTxt.Controls.Add(this.tlp_RenamePaths, 0, 1);
            this.tlp_RenameTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_RenameTxt.Location = new System.Drawing.Point(0, 0);
            this.tlp_RenameTxt.Name = "tlp_RenameTxt";
            this.tlp_RenameTxt.RowCount = 2;
            this.tlp_RenameTxt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tlp_RenameTxt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tlp_RenameTxt.Size = new System.Drawing.Size(727, 400);
            this.tlp_RenameTxt.TabIndex = 3;
            // 
            // btn_Rename
            // 
            this.btn_Rename.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Rename.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_Rename.ForeColor = System.Drawing.Color.DimGray;
            this.btn_Rename.Location = new System.Drawing.Point(511, 223);
            this.btn_Rename.Name = "btn_Rename";
            this.btn_Rename.Size = new System.Drawing.Size(213, 174);
            this.btn_Rename.TabIndex = 8;
            this.btn_Rename.Text = "Copy and Rename Files";
            this.btn_Rename.UseVisualStyleBackColor = true;
            // 
            // groupBox_RenameTxt
            // 
            this.tlp_RenameTxt.SetColumnSpan(this.groupBox_RenameTxt, 3);
            this.groupBox_RenameTxt.Controls.Add(this.dgv_RenameTxt);
            this.groupBox_RenameTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_RenameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox_RenameTxt.Location = new System.Drawing.Point(3, 3);
            this.groupBox_RenameTxt.Name = "groupBox_RenameTxt";
            this.groupBox_RenameTxt.Size = new System.Drawing.Size(502, 214);
            this.groupBox_RenameTxt.TabIndex = 0;
            this.groupBox_RenameTxt.TabStop = false;
            this.groupBox_RenameTxt.Text = "Drag .txt w/ Ordered Filenames";
            // 
            // dgv_RenameTxt
            // 
            this.dgv_RenameTxt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_RenameTxt.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_RenameTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_RenameTxt.Location = new System.Drawing.Point(3, 22);
            this.dgv_RenameTxt.Name = "dgv_RenameTxt";
            this.dgv_RenameTxt.RowHeadersWidth = 51;
            this.dgv_RenameTxt.RowTemplate.Height = 24;
            this.dgv_RenameTxt.Size = new System.Drawing.Size(496, 189);
            this.dgv_RenameTxt.TabIndex = 0;
            this.dgv_RenameTxt.DragDrop += new System.Windows.Forms.DragEventHandler(this.Dgv_DragDrop);
            this.dgv_RenameTxt.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            // 
            // tlp_RenameTxtSettings
            // 
            this.tlp_RenameTxtSettings.ColumnCount = 1;
            this.tlp_RenameTxtSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_RenameTxtSettings.Controls.Add(this.groupBox_RenameStartID, 0, 2);
            this.tlp_RenameTxtSettings.Controls.Add(this.groupBox_LeftPadding, 0, 1);
            this.tlp_RenameTxtSettings.Controls.Add(this.groupBox_Suffix, 0, 0);
            this.tlp_RenameTxtSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_RenameTxtSettings.Location = new System.Drawing.Point(511, 3);
            this.tlp_RenameTxtSettings.Name = "tlp_RenameTxtSettings";
            this.tlp_RenameTxtSettings.RowCount = 3;
            this.tlp_RenameTxtSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlp_RenameTxtSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlp_RenameTxtSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlp_RenameTxtSettings.Size = new System.Drawing.Size(213, 214);
            this.tlp_RenameTxtSettings.TabIndex = 4;
            // 
            // groupBox_RenameStartID
            // 
            this.groupBox_RenameStartID.Controls.Add(this.num_StartID);
            this.groupBox_RenameStartID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_RenameStartID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox_RenameStartID.Location = new System.Drawing.Point(3, 152);
            this.groupBox_RenameStartID.Name = "groupBox_RenameStartID";
            this.groupBox_RenameStartID.Size = new System.Drawing.Size(207, 59);
            this.groupBox_RenameStartID.TabIndex = 7;
            this.groupBox_RenameStartID.TabStop = false;
            this.groupBox_RenameStartID.Text = "Start ID";
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
            this.num_StartID.Size = new System.Drawing.Size(201, 26);
            this.num_StartID.TabIndex = 0;
            // 
            // groupBox_LeftPadding
            // 
            this.groupBox_LeftPadding.Controls.Add(this.num_LeftPadding);
            this.groupBox_LeftPadding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_LeftPadding.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox_LeftPadding.Location = new System.Drawing.Point(3, 88);
            this.groupBox_LeftPadding.Name = "groupBox_LeftPadding";
            this.groupBox_LeftPadding.Size = new System.Drawing.Size(207, 58);
            this.groupBox_LeftPadding.TabIndex = 6;
            this.groupBox_LeftPadding.TabStop = false;
            this.groupBox_LeftPadding.Text = "Left Padding";
            // 
            // num_LeftPadding
            // 
            this.num_LeftPadding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num_LeftPadding.Location = new System.Drawing.Point(3, 22);
            this.num_LeftPadding.Name = "num_LeftPadding";
            this.num_LeftPadding.Size = new System.Drawing.Size(201, 26);
            this.num_LeftPadding.TabIndex = 0;
            this.num_LeftPadding.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // groupBox_Suffix
            // 
            this.groupBox_Suffix.Controls.Add(this.tlp_Suffix);
            this.groupBox_Suffix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Suffix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox_Suffix.Location = new System.Drawing.Point(3, 3);
            this.groupBox_Suffix.Name = "groupBox_Suffix";
            this.groupBox_Suffix.Size = new System.Drawing.Size(207, 79);
            this.groupBox_Suffix.TabIndex = 0;
            this.groupBox_Suffix.TabStop = false;
            this.groupBox_Suffix.Text = "Suffix";
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
            this.tlp_Suffix.Size = new System.Drawing.Size(201, 54);
            this.tlp_Suffix.TabIndex = 0;
            // 
            // chk_AppendOGName
            // 
            this.chk_AppendOGName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_AppendOGName.AutoSize = true;
            this.chk_AppendOGName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.chk_AppendOGName.ForeColor = System.Drawing.Color.DimGray;
            this.chk_AppendOGName.Location = new System.Drawing.Point(3, 30);
            this.chk_AppendOGName.Name = "chk_AppendOGName";
            this.chk_AppendOGName.Size = new System.Drawing.Size(195, 21);
            this.chk_AppendOGName.TabIndex = 5;
            this.chk_AppendOGName.Text = "Append OG Name";
            this.chk_AppendOGName.UseVisualStyleBackColor = true;
            // 
            // txt_RenameSuffix
            // 
            this.txt_RenameSuffix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_RenameSuffix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_RenameSuffix.Location = new System.Drawing.Point(3, 3);
            this.txt_RenameSuffix.Name = "txt_RenameSuffix";
            this.txt_RenameSuffix.Size = new System.Drawing.Size(195, 26);
            this.txt_RenameSuffix.TabIndex = 4;
            this.txt_RenameSuffix.Text = "_streaming";
            // 
            // tlp_RenamePaths
            // 
            this.tlp_RenamePaths.ColumnCount = 1;
            this.tlp_RenameTxt.SetColumnSpan(this.tlp_RenamePaths, 3);
            this.tlp_RenamePaths.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_RenamePaths.Controls.Add(this.groupBox_RenameOutputPath, 0, 1);
            this.tlp_RenamePaths.Controls.Add(this.groupBox_RenameSourcePath, 0, 0);
            this.tlp_RenamePaths.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_RenamePaths.Location = new System.Drawing.Point(3, 223);
            this.tlp_RenamePaths.Name = "tlp_RenamePaths";
            this.tlp_RenamePaths.RowCount = 2;
            this.tlp_RenamePaths.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_RenamePaths.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_RenamePaths.Size = new System.Drawing.Size(502, 174);
            this.tlp_RenamePaths.TabIndex = 7;
            // 
            // groupBox_RenameOutputPath
            // 
            this.groupBox_RenameOutputPath.Controls.Add(this.tlp_RenameOutputPath);
            this.groupBox_RenameOutputPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_RenameOutputPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox_RenameOutputPath.Location = new System.Drawing.Point(3, 90);
            this.groupBox_RenameOutputPath.Name = "groupBox_RenameOutputPath";
            this.groupBox_RenameOutputPath.Size = new System.Drawing.Size(496, 81);
            this.groupBox_RenameOutputPath.TabIndex = 1;
            this.groupBox_RenameOutputPath.TabStop = false;
            this.groupBox_RenameOutputPath.Text = "Renamed Files Output Path";
            // 
            // tlp_RenameOutputPath
            // 
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
            this.tlp_RenameOutputPath.Size = new System.Drawing.Size(490, 56);
            this.tlp_RenameOutputPath.TabIndex = 0;
            // 
            // btn_RenameOutput
            // 
            this.btn_RenameOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_RenameOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_RenameOutput.ForeColor = System.Drawing.Color.DimGray;
            this.btn_RenameOutput.Location = new System.Drawing.Point(419, 15);
            this.btn_RenameOutput.Name = "btn_RenameOutput";
            this.btn_RenameOutput.Size = new System.Drawing.Size(68, 26);
            this.btn_RenameOutput.TabIndex = 7;
            this.btn_RenameOutput.Text = "...";
            this.btn_RenameOutput.UseVisualStyleBackColor = true;
            // 
            // txt_RenameOutputPath
            // 
            this.txt_RenameOutputPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_RenameOutputPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_RenameOutputPath.Location = new System.Drawing.Point(3, 15);
            this.txt_RenameOutputPath.Name = "txt_RenameOutputPath";
            this.txt_RenameOutputPath.Size = new System.Drawing.Size(410, 26);
            this.txt_RenameOutputPath.TabIndex = 6;
            this.txt_RenameOutputPath.TextChanged += new System.EventHandler(this.Txt_Changed);
            // 
            // groupBox_RenameSourcePath
            // 
            this.groupBox_RenameSourcePath.Controls.Add(this.tlp_RenameSourcePath);
            this.groupBox_RenameSourcePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_RenameSourcePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox_RenameSourcePath.Location = new System.Drawing.Point(3, 3);
            this.groupBox_RenameSourcePath.Name = "groupBox_RenameSourcePath";
            this.groupBox_RenameSourcePath.Size = new System.Drawing.Size(496, 81);
            this.groupBox_RenameSourcePath.TabIndex = 0;
            this.groupBox_RenameSourcePath.TabStop = false;
            this.groupBox_RenameSourcePath.Text = "Source Sound Files Path";
            // 
            // tlp_RenameSourcePath
            // 
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
            this.tlp_RenameSourcePath.Size = new System.Drawing.Size(490, 56);
            this.tlp_RenameSourcePath.TabIndex = 0;
            // 
            // btn_RenameSource
            // 
            this.btn_RenameSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_RenameSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_RenameSource.ForeColor = System.Drawing.Color.DimGray;
            this.btn_RenameSource.Location = new System.Drawing.Point(419, 15);
            this.btn_RenameSource.Name = "btn_RenameSource";
            this.btn_RenameSource.Size = new System.Drawing.Size(68, 26);
            this.btn_RenameSource.TabIndex = 7;
            this.btn_RenameSource.Text = "...";
            this.btn_RenameSource.UseVisualStyleBackColor = true;
            // 
            // txt_RenameSourcePath
            // 
            this.txt_RenameSourcePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_RenameSourcePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_RenameSourcePath.Location = new System.Drawing.Point(3, 15);
            this.txt_RenameSourcePath.Name = "txt_RenameSourcePath";
            this.txt_RenameSourcePath.Size = new System.Drawing.Size(410, 26);
            this.txt_RenameSourcePath.TabIndex = 6;
            this.txt_RenameSourcePath.TextChanged += new System.EventHandler(this.Txt_Changed);
            // 
            // tabPage_Archives
            // 
            this.tabPage_Archives.Controls.Add(this.tlp_Archives);
            this.tabPage_Archives.Location = new System.Drawing.Point(4, 42);
            this.tabPage_Archives.Name = "tabPage_Archives";
            this.tabPage_Archives.Size = new System.Drawing.Size(727, 400);
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
            this.tlp_Archives.Size = new System.Drawing.Size(727, 400);
            this.tlp_Archives.TabIndex = 3;
            // 
            // btn_ExtractArchive
            // 
            this.btn_ExtractArchive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ExtractArchive.ForeColor = System.Drawing.Color.DimGray;
            this.btn_ExtractArchive.Location = new System.Drawing.Point(3, 3);
            this.btn_ExtractArchive.Name = "btn_ExtractArchive";
            this.btn_ExtractArchive.Size = new System.Drawing.Size(357, 394);
            this.btn_ExtractArchive.TabIndex = 1;
            this.btn_ExtractArchive.Text = "Drag Archive to Extract";
            this.btn_ExtractArchive.UseVisualStyleBackColor = true;
            this.btn_ExtractArchive.Click += new System.EventHandler(this.ExtractArchive_Click);
            this.btn_ExtractArchive.DragDrop += new System.Windows.Forms.DragEventHandler(this.Extract_DragDrop);
            this.btn_ExtractArchive.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            // 
            // btn_RepackArchive
            // 
            this.btn_RepackArchive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_RepackArchive.ForeColor = System.Drawing.Color.DimGray;
            this.btn_RepackArchive.Location = new System.Drawing.Point(366, 3);
            this.btn_RepackArchive.Name = "btn_RepackArchive";
            this.btn_RepackArchive.Size = new System.Drawing.Size(358, 394);
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
            this.rtb_Log.Size = new System.Drawing.Size(735, 142);
            this.rtb_Log.TabIndex = 0;
            this.rtb_Log.Text = "";
            // 
            // PersonaVCE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(739, 622);
            this.Controls.Add(this.splitContainer_Main);
            this.Controls.Add(this.menuStrip1);
            this.DropShadowEffect = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.HeaderHeight = -40;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PersonaVCE";
            this.Opacity = 0.99D;
            this.Padding = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.ShowHeader = true;
            this.ShowLeftRect = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Style = MetroSet_UI.Enums.Style.Dark;
            this.Text = "PersonaVCE";
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
            this.tlp_RenameTxt.ResumeLayout(false);
            this.groupBox_RenameTxt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RenameTxt)).EndInit();
            this.tlp_RenameTxtSettings.ResumeLayout(false);
            this.groupBox_RenameStartID.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_StartID)).EndInit();
            this.groupBox_LeftPadding.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_LeftPadding)).EndInit();
            this.groupBox_Suffix.ResumeLayout(false);
            this.tlp_Suffix.ResumeLayout(false);
            this.tlp_Suffix.PerformLayout();
            this.tlp_RenamePaths.ResumeLayout(false);
            this.groupBox_RenameOutputPath.ResumeLayout(false);
            this.tlp_RenameOutputPath.ResumeLayout(false);
            this.tlp_RenameOutputPath.PerformLayout();
            this.groupBox_RenameSourcePath.ResumeLayout(false);
            this.tlp_RenameSourcePath.ResumeLayout(false);
            this.tlp_RenameSourcePath.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel tlp_RenameTxt;
        private System.Windows.Forms.GroupBox groupBox_RenameTxt;
        private System.Windows.Forms.DataGridView dgv_RenameTxt;
        private System.Windows.Forms.TableLayoutPanel tlp_RenameTxtSettings;
        private System.Windows.Forms.GroupBox groupBox_Suffix;
        private System.Windows.Forms.TabPage tabPage_Archives;
        private System.Windows.Forms.TableLayoutPanel tlp_Archives;
        private System.Windows.Forms.Button btn_ExtractArchive;
        private System.Windows.Forms.Button btn_RepackArchive;
        private System.Windows.Forms.RichTextBox rtb_Log;
        private System.Windows.Forms.CheckBox chk_LoopAll;
        private System.Windows.Forms.NumericUpDown num_EncryptionKey;
        private System.Windows.Forms.NumericUpDown num_LoopEnd;
        private System.Windows.Forms.NumericUpDown num_LoopStart;
        private System.Windows.Forms.TableLayoutPanel tlp_RenamePaths;
        private System.Windows.Forms.GroupBox groupBox_RenameSourcePath;
        private System.Windows.Forms.GroupBox groupBox_RenameStartID;
        private System.Windows.Forms.NumericUpDown num_StartID;
        private System.Windows.Forms.GroupBox groupBox_LeftPadding;
        private System.Windows.Forms.NumericUpDown num_LeftPadding;
        private System.Windows.Forms.TableLayoutPanel tlp_Suffix;
        private System.Windows.Forms.CheckBox chk_AppendOGName;
        private System.Windows.Forms.TextBox txt_RenameSuffix;
        private System.Windows.Forms.TableLayoutPanel tlp_RenameSourcePath;
        private System.Windows.Forms.Button btn_RenameSource;
        private System.Windows.Forms.TextBox txt_RenameSourcePath;
        private System.Windows.Forms.GroupBox groupBox_RenameOutputPath;
        private System.Windows.Forms.TableLayoutPanel tlp_RenameOutputPath;
        private System.Windows.Forms.TextBox txt_RenameOutputPath;
        private System.Windows.Forms.Button btn_RenameOutput;
        private System.Windows.Forms.Button btn_Rename;
    }
}