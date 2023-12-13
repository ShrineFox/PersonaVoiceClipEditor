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
            this.chk_UseEncryption = new System.Windows.Forms.CheckBox();
            this.txt_EncryptionKey = new System.Windows.Forms.TextBox();
            this.btn_Decode = new System.Windows.Forms.Button();
            this.btn_Encode = new System.Windows.Forms.Button();
            this.groupBox_LoopPoints = new System.Windows.Forms.GroupBox();
            this.tlp_LoopSettings = new System.Windows.Forms.TableLayoutPanel();
            this.txt_LoopEnd = new System.Windows.Forms.TextBox();
            this.chk_UseLoopPoints = new System.Windows.Forms.CheckBox();
            this.lbl_Loop = new System.Windows.Forms.Label();
            this.txt_LoopStart = new System.Windows.Forms.TextBox();
            this.tabPage_Renaming = new System.Windows.Forms.TabPage();
            this.tlp_RenameTxt = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_RenameStartID = new System.Windows.Forms.GroupBox();
            this.num_StartID = new System.Windows.Forms.NumericUpDown();
            this.btn_Rename = new System.Windows.Forms.Button();
            this.btn_RenameOutput = new System.Windows.Forms.Button();
            this.btn_RenameSource = new System.Windows.Forms.Button();
            this.groupBox_RenameTxt = new System.Windows.Forms.GroupBox();
            this.dgv_RenameTxt = new System.Windows.Forms.DataGridView();
            this.tlp_RenameTxtSettings = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_LeftPadding = new System.Windows.Forms.GroupBox();
            this.num_LeftPadding = new System.Windows.Forms.NumericUpDown();
            this.chk_AppendOGName = new System.Windows.Forms.CheckBox();
            this.groupBox_Suffix = new System.Windows.Forms.GroupBox();
            this.txt_RenameSuffix = new System.Windows.Forms.TextBox();
            this.tabPage_Archives = new System.Windows.Forms.TabPage();
            this.tlp_Archives = new System.Windows.Forms.TableLayoutPanel();
            this.btn_ExtractArchive = new System.Windows.Forms.Button();
            this.btn_RepackArchive = new System.Windows.Forms.Button();
            this.rtb_Log = new System.Windows.Forms.RichTextBox();
            this.chk_LoopAll = new System.Windows.Forms.CheckBox();
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
            this.groupBox_LoopPoints.SuspendLayout();
            this.tlp_LoopSettings.SuspendLayout();
            this.tabPage_Renaming.SuspendLayout();
            this.tlp_RenameTxt.SuspendLayout();
            this.groupBox_RenameStartID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_StartID)).BeginInit();
            this.groupBox_RenameTxt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RenameTxt)).BeginInit();
            this.tlp_RenameTxtSettings.SuspendLayout();
            this.groupBox_LeftPadding.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_LeftPadding)).BeginInit();
            this.groupBox_Suffix.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(626, 28);
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
            this.comboBox_EncryptionPreset.Name = "comboBox_EncryptionPreset";
            this.comboBox_EncryptionPreset.Size = new System.Drawing.Size(121, 28);
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
            this.comboBox_ArchiveFormat.Name = "comboBox_ArchiveFormat";
            this.comboBox_ArchiveFormat.Size = new System.Drawing.Size(121, 28);
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
            this.comboBox_SoundFormat.Name = "comboBox_SoundFormat";
            this.comboBox_SoundFormat.Size = new System.Drawing.Size(121, 28);
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
            this.splitContainer_Main.Size = new System.Drawing.Size(626, 438);
            this.splitContainer_Main.SplitterDistance = 330;
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
            this.metroSetTabControl_Main.SelectedIndex = 0;
            this.metroSetTabControl_Main.SelectedTextColor = System.Drawing.Color.White;
            this.metroSetTabControl_Main.Size = new System.Drawing.Size(626, 330);
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
            this.tabPage_Encoding.Size = new System.Drawing.Size(618, 284);
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
            this.tlp_EncodingTab.Size = new System.Drawing.Size(618, 284);
            this.tlp_EncodingTab.TabIndex = 3;
            // 
            // groupBox_Encryption
            // 
            this.groupBox_Encryption.Controls.Add(this.tlp_Encryption);
            this.groupBox_Encryption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Encryption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox_Encryption.Location = new System.Drawing.Point(312, 130);
            this.groupBox_Encryption.Name = "groupBox_Encryption";
            this.groupBox_Encryption.Size = new System.Drawing.Size(303, 151);
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
            this.tlp_Encryption.Controls.Add(this.chk_UseEncryption, 0, 0);
            this.tlp_Encryption.Controls.Add(this.txt_EncryptionKey, 0, 1);
            this.tlp_Encryption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Encryption.Location = new System.Drawing.Point(3, 22);
            this.tlp_Encryption.Name = "tlp_Encryption";
            this.tlp_Encryption.RowCount = 2;
            this.tlp_Encryption.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.81356F));
            this.tlp_Encryption.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.18644F));
            this.tlp_Encryption.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_Encryption.Size = new System.Drawing.Size(297, 126);
            this.tlp_Encryption.TabIndex = 0;
            // 
            // chk_UseEncryption
            // 
            this.chk_UseEncryption.AutoSize = true;
            this.chk_UseEncryption.ForeColor = System.Drawing.Color.DimGray;
            this.chk_UseEncryption.Location = new System.Drawing.Point(3, 3);
            this.chk_UseEncryption.Name = "chk_UseEncryption";
            this.chk_UseEncryption.Size = new System.Drawing.Size(183, 24);
            this.chk_UseEncryption.TabIndex = 0;
            this.chk_UseEncryption.Text = "Use New Encryption";
            this.chk_UseEncryption.UseVisualStyleBackColor = true;
            // 
            // txt_EncryptionKey
            // 
            this.txt_EncryptionKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_EncryptionKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_EncryptionKey.Location = new System.Drawing.Point(3, 68);
            this.txt_EncryptionKey.Name = "txt_EncryptionKey";
            this.txt_EncryptionKey.Size = new System.Drawing.Size(291, 26);
            this.txt_EncryptionKey.TabIndex = 2;
            // 
            // btn_Decode
            // 
            this.btn_Decode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Decode.ForeColor = System.Drawing.Color.DimGray;
            this.btn_Decode.Location = new System.Drawing.Point(312, 3);
            this.btn_Decode.Name = "btn_Decode";
            this.btn_Decode.Size = new System.Drawing.Size(303, 121);
            this.btn_Decode.TabIndex = 1;
            this.btn_Decode.Text = "Drag Files to Decode";
            this.btn_Decode.UseVisualStyleBackColor = true;
            // 
            // btn_Encode
            // 
            this.btn_Encode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Encode.ForeColor = System.Drawing.Color.DimGray;
            this.btn_Encode.Location = new System.Drawing.Point(3, 3);
            this.btn_Encode.Name = "btn_Encode";
            this.btn_Encode.Size = new System.Drawing.Size(303, 121);
            this.btn_Encode.TabIndex = 0;
            this.btn_Encode.Text = "Drag Files to Encode";
            this.btn_Encode.UseVisualStyleBackColor = true;
            // 
            // groupBox_LoopPoints
            // 
            this.groupBox_LoopPoints.Controls.Add(this.tlp_LoopSettings);
            this.groupBox_LoopPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_LoopPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox_LoopPoints.Location = new System.Drawing.Point(3, 130);
            this.groupBox_LoopPoints.Name = "groupBox_LoopPoints";
            this.groupBox_LoopPoints.Size = new System.Drawing.Size(303, 151);
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
            this.tlp_LoopSettings.Controls.Add(this.chk_LoopAll, 0, 1);
            this.tlp_LoopSettings.Controls.Add(this.chk_UseLoopPoints, 0, 0);
            this.tlp_LoopSettings.Controls.Add(this.txt_LoopStart, 0, 2);
            this.tlp_LoopSettings.Controls.Add(this.lbl_Loop, 1, 2);
            this.tlp_LoopSettings.Controls.Add(this.txt_LoopEnd, 2, 2);
            this.tlp_LoopSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_LoopSettings.Location = new System.Drawing.Point(3, 22);
            this.tlp_LoopSettings.Name = "tlp_LoopSettings";
            this.tlp_LoopSettings.RowCount = 3;
            this.tlp_LoopSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlp_LoopSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlp_LoopSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlp_LoopSettings.Size = new System.Drawing.Size(297, 126);
            this.tlp_LoopSettings.TabIndex = 0;
            // 
            // txt_LoopEnd
            // 
            this.txt_LoopEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_LoopEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_LoopEnd.Location = new System.Drawing.Point(165, 87);
            this.txt_LoopEnd.Name = "txt_LoopEnd";
            this.txt_LoopEnd.Size = new System.Drawing.Size(129, 26);
            this.txt_LoopEnd.TabIndex = 3;
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
            // 
            // lbl_Loop
            // 
            this.lbl_Loop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Loop.AutoSize = true;
            this.lbl_Loop.ForeColor = System.Drawing.Color.Black;
            this.lbl_Loop.Location = new System.Drawing.Point(136, 90);
            this.lbl_Loop.Name = "lbl_Loop";
            this.lbl_Loop.Size = new System.Drawing.Size(23, 20);
            this.lbl_Loop.TabIndex = 1;
            this.lbl_Loop.Text = " - ";
            this.lbl_Loop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_LoopStart
            // 
            this.txt_LoopStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_LoopStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_LoopStart.Location = new System.Drawing.Point(3, 87);
            this.txt_LoopStart.Name = "txt_LoopStart";
            this.txt_LoopStart.Size = new System.Drawing.Size(127, 26);
            this.txt_LoopStart.TabIndex = 2;
            // 
            // tabPage_Renaming
            // 
            this.tabPage_Renaming.Controls.Add(this.tlp_RenameTxt);
            this.tabPage_Renaming.Location = new System.Drawing.Point(4, 42);
            this.tabPage_Renaming.Name = "tabPage_Renaming";
            this.tabPage_Renaming.Size = new System.Drawing.Size(618, 284);
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
            this.tlp_RenameTxt.Controls.Add(this.groupBox_RenameStartID, 3, 1);
            this.tlp_RenameTxt.Controls.Add(this.btn_Rename, 2, 1);
            this.tlp_RenameTxt.Controls.Add(this.btn_RenameOutput, 1, 1);
            this.tlp_RenameTxt.Controls.Add(this.btn_RenameSource, 0, 1);
            this.tlp_RenameTxt.Controls.Add(this.groupBox_RenameTxt, 0, 0);
            this.tlp_RenameTxt.Controls.Add(this.tlp_RenameTxtSettings, 3, 0);
            this.tlp_RenameTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_RenameTxt.Location = new System.Drawing.Point(0, 0);
            this.tlp_RenameTxt.Name = "tlp_RenameTxt";
            this.tlp_RenameTxt.RowCount = 2;
            this.tlp_RenameTxt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlp_RenameTxt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlp_RenameTxt.Size = new System.Drawing.Size(618, 284);
            this.tlp_RenameTxt.TabIndex = 3;
            // 
            // groupBox_RenameStartID
            // 
            this.groupBox_RenameStartID.Controls.Add(this.num_StartID);
            this.groupBox_RenameStartID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_RenameStartID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox_RenameStartID.Location = new System.Drawing.Point(434, 201);
            this.groupBox_RenameStartID.Name = "groupBox_RenameStartID";
            this.groupBox_RenameStartID.Size = new System.Drawing.Size(181, 80);
            this.groupBox_RenameStartID.TabIndex = 6;
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
            this.num_StartID.Size = new System.Drawing.Size(175, 26);
            this.num_StartID.TabIndex = 0;
            // 
            // btn_Rename
            // 
            this.btn_Rename.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Rename.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_Rename.ForeColor = System.Drawing.Color.DimGray;
            this.btn_Rename.Location = new System.Drawing.Point(249, 201);
            this.btn_Rename.Name = "btn_Rename";
            this.btn_Rename.Size = new System.Drawing.Size(179, 80);
            this.btn_Rename.TabIndex = 3;
            this.btn_Rename.Text = "Copy and Rename Files";
            this.btn_Rename.UseVisualStyleBackColor = true;
            // 
            // btn_RenameOutput
            // 
            this.btn_RenameOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_RenameOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_RenameOutput.ForeColor = System.Drawing.Color.DimGray;
            this.btn_RenameOutput.Location = new System.Drawing.Point(126, 201);
            this.btn_RenameOutput.Name = "btn_RenameOutput";
            this.btn_RenameOutput.Size = new System.Drawing.Size(117, 80);
            this.btn_RenameOutput.TabIndex = 2;
            this.btn_RenameOutput.Text = "Choose Output Folder";
            this.btn_RenameOutput.UseVisualStyleBackColor = true;
            // 
            // btn_RenameSource
            // 
            this.btn_RenameSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_RenameSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_RenameSource.ForeColor = System.Drawing.Color.DimGray;
            this.btn_RenameSource.Location = new System.Drawing.Point(3, 201);
            this.btn_RenameSource.Name = "btn_RenameSource";
            this.btn_RenameSource.Size = new System.Drawing.Size(117, 80);
            this.btn_RenameSource.TabIndex = 1;
            this.btn_RenameSource.Text = "Choose Source Sound Files Folder";
            this.btn_RenameSource.UseVisualStyleBackColor = true;
            // 
            // groupBox_RenameTxt
            // 
            this.tlp_RenameTxt.SetColumnSpan(this.groupBox_RenameTxt, 3);
            this.groupBox_RenameTxt.Controls.Add(this.dgv_RenameTxt);
            this.groupBox_RenameTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_RenameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox_RenameTxt.Location = new System.Drawing.Point(3, 3);
            this.groupBox_RenameTxt.Name = "groupBox_RenameTxt";
            this.groupBox_RenameTxt.Size = new System.Drawing.Size(425, 192);
            this.groupBox_RenameTxt.TabIndex = 0;
            this.groupBox_RenameTxt.TabStop = false;
            this.groupBox_RenameTxt.Text = "Drag .txt w/ Ordered Filenames";
            // 
            // dgv_RenameTxt
            // 
            this.dgv_RenameTxt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_RenameTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_RenameTxt.Location = new System.Drawing.Point(3, 22);
            this.dgv_RenameTxt.Name = "dgv_RenameTxt";
            this.dgv_RenameTxt.RowHeadersWidth = 51;
            this.dgv_RenameTxt.RowTemplate.Height = 24;
            this.dgv_RenameTxt.Size = new System.Drawing.Size(419, 167);
            this.dgv_RenameTxt.TabIndex = 0;
            // 
            // tlp_RenameTxtSettings
            // 
            this.tlp_RenameTxtSettings.ColumnCount = 1;
            this.tlp_RenameTxtSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_RenameTxtSettings.Controls.Add(this.groupBox_LeftPadding, 0, 2);
            this.tlp_RenameTxtSettings.Controls.Add(this.chk_AppendOGName, 0, 1);
            this.tlp_RenameTxtSettings.Controls.Add(this.groupBox_Suffix, 0, 0);
            this.tlp_RenameTxtSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_RenameTxtSettings.Location = new System.Drawing.Point(434, 3);
            this.tlp_RenameTxtSettings.Name = "tlp_RenameTxtSettings";
            this.tlp_RenameTxtSettings.RowCount = 3;
            this.tlp_RenameTxtSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_RenameTxtSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_RenameTxtSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_RenameTxtSettings.Size = new System.Drawing.Size(181, 192);
            this.tlp_RenameTxtSettings.TabIndex = 4;
            // 
            // groupBox_LeftPadding
            // 
            this.groupBox_LeftPadding.Controls.Add(this.num_LeftPadding);
            this.groupBox_LeftPadding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_LeftPadding.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox_LeftPadding.Location = new System.Drawing.Point(3, 131);
            this.groupBox_LeftPadding.Name = "groupBox_LeftPadding";
            this.groupBox_LeftPadding.Size = new System.Drawing.Size(175, 58);
            this.groupBox_LeftPadding.TabIndex = 5;
            this.groupBox_LeftPadding.TabStop = false;
            this.groupBox_LeftPadding.Text = "Left Padding";
            // 
            // num_LeftPadding
            // 
            this.num_LeftPadding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num_LeftPadding.Location = new System.Drawing.Point(3, 22);
            this.num_LeftPadding.Name = "num_LeftPadding";
            this.num_LeftPadding.Size = new System.Drawing.Size(169, 26);
            this.num_LeftPadding.TabIndex = 0;
            this.num_LeftPadding.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // chk_AppendOGName
            // 
            this.chk_AppendOGName.AutoSize = true;
            this.chk_AppendOGName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chk_AppendOGName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.chk_AppendOGName.ForeColor = System.Drawing.Color.DimGray;
            this.chk_AppendOGName.Location = new System.Drawing.Point(3, 67);
            this.chk_AppendOGName.Name = "chk_AppendOGName";
            this.chk_AppendOGName.Size = new System.Drawing.Size(175, 58);
            this.chk_AppendOGName.TabIndex = 4;
            this.chk_AppendOGName.Text = "Append OG Name";
            this.chk_AppendOGName.UseVisualStyleBackColor = true;
            // 
            // groupBox_Suffix
            // 
            this.groupBox_Suffix.Controls.Add(this.txt_RenameSuffix);
            this.groupBox_Suffix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Suffix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox_Suffix.Location = new System.Drawing.Point(3, 3);
            this.groupBox_Suffix.Name = "groupBox_Suffix";
            this.groupBox_Suffix.Size = new System.Drawing.Size(175, 58);
            this.groupBox_Suffix.TabIndex = 0;
            this.groupBox_Suffix.TabStop = false;
            this.groupBox_Suffix.Text = "Suffix";
            // 
            // txt_RenameSuffix
            // 
            this.txt_RenameSuffix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_RenameSuffix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_RenameSuffix.Location = new System.Drawing.Point(3, 22);
            this.txt_RenameSuffix.Name = "txt_RenameSuffix";
            this.txt_RenameSuffix.Size = new System.Drawing.Size(169, 26);
            this.txt_RenameSuffix.TabIndex = 3;
            this.txt_RenameSuffix.Text = "_streaming";
            // 
            // tabPage_Archives
            // 
            this.tabPage_Archives.Controls.Add(this.tlp_Archives);
            this.tabPage_Archives.Location = new System.Drawing.Point(4, 42);
            this.tabPage_Archives.Name = "tabPage_Archives";
            this.tabPage_Archives.Size = new System.Drawing.Size(618, 284);
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
            this.tlp_Archives.Size = new System.Drawing.Size(618, 284);
            this.tlp_Archives.TabIndex = 3;
            // 
            // btn_ExtractArchive
            // 
            this.btn_ExtractArchive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ExtractArchive.ForeColor = System.Drawing.Color.DimGray;
            this.btn_ExtractArchive.Location = new System.Drawing.Point(3, 3);
            this.btn_ExtractArchive.Name = "btn_ExtractArchive";
            this.btn_ExtractArchive.Size = new System.Drawing.Size(303, 278);
            this.btn_ExtractArchive.TabIndex = 1;
            this.btn_ExtractArchive.Text = "Drag Archive to Extract";
            this.btn_ExtractArchive.UseVisualStyleBackColor = true;
            // 
            // btn_RepackArchive
            // 
            this.btn_RepackArchive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_RepackArchive.ForeColor = System.Drawing.Color.DimGray;
            this.btn_RepackArchive.Location = new System.Drawing.Point(312, 3);
            this.btn_RepackArchive.Name = "btn_RepackArchive";
            this.btn_RepackArchive.Size = new System.Drawing.Size(303, 278);
            this.btn_RepackArchive.TabIndex = 2;
            this.btn_RepackArchive.Text = "Drag Folder to Repack";
            this.btn_RepackArchive.UseVisualStyleBackColor = true;
            // 
            // rtb_Log
            // 
            this.rtb_Log.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.rtb_Log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_Log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_Log.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.rtb_Log.Location = new System.Drawing.Point(0, 0);
            this.rtb_Log.Name = "rtb_Log";
            this.rtb_Log.ReadOnly = true;
            this.rtb_Log.Size = new System.Drawing.Size(626, 104);
            this.rtb_Log.TabIndex = 0;
            this.rtb_Log.Text = "";
            // 
            // chk_LoopAll
            // 
            this.chk_LoopAll.AutoSize = true;
            this.chk_LoopAll.ForeColor = System.Drawing.Color.DimGray;
            this.chk_LoopAll.Location = new System.Drawing.Point(3, 40);
            this.chk_LoopAll.Name = "chk_LoopAll";
            this.chk_LoopAll.Size = new System.Drawing.Size(92, 24);
            this.chk_LoopAll.TabIndex = 4;
            this.chk_LoopAll.Text = "Loop All";
            this.chk_LoopAll.UseVisualStyleBackColor = true;
            // 
            // PersonaVCE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(630, 468);
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
            this.groupBox_LoopPoints.ResumeLayout(false);
            this.tlp_LoopSettings.ResumeLayout(false);
            this.tlp_LoopSettings.PerformLayout();
            this.tabPage_Renaming.ResumeLayout(false);
            this.tlp_RenameTxt.ResumeLayout(false);
            this.groupBox_RenameStartID.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_StartID)).EndInit();
            this.groupBox_RenameTxt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RenameTxt)).EndInit();
            this.tlp_RenameTxtSettings.ResumeLayout(false);
            this.tlp_RenameTxtSettings.PerformLayout();
            this.groupBox_LeftPadding.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_LeftPadding)).EndInit();
            this.groupBox_Suffix.ResumeLayout(false);
            this.groupBox_Suffix.PerformLayout();
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
        private System.Windows.Forms.TextBox txt_EncryptionKey;
        private System.Windows.Forms.Button btn_Decode;
        private System.Windows.Forms.Button btn_Encode;
        private System.Windows.Forms.GroupBox groupBox_LoopPoints;
        private System.Windows.Forms.TableLayoutPanel tlp_LoopSettings;
        private System.Windows.Forms.TextBox txt_LoopEnd;
        private System.Windows.Forms.CheckBox chk_UseLoopPoints;
        private System.Windows.Forms.Label lbl_Loop;
        private System.Windows.Forms.TextBox txt_LoopStart;
        private System.Windows.Forms.TabPage tabPage_Renaming;
        private System.Windows.Forms.TableLayoutPanel tlp_RenameTxt;
        private System.Windows.Forms.Button btn_Rename;
        private System.Windows.Forms.Button btn_RenameOutput;
        private System.Windows.Forms.Button btn_RenameSource;
        private System.Windows.Forms.GroupBox groupBox_RenameTxt;
        private System.Windows.Forms.DataGridView dgv_RenameTxt;
        private System.Windows.Forms.TableLayoutPanel tlp_RenameTxtSettings;
        private System.Windows.Forms.GroupBox groupBox_RenameStartID;
        private System.Windows.Forms.NumericUpDown num_StartID;
        private System.Windows.Forms.GroupBox groupBox_LeftPadding;
        private System.Windows.Forms.NumericUpDown num_LeftPadding;
        private System.Windows.Forms.CheckBox chk_AppendOGName;
        private System.Windows.Forms.GroupBox groupBox_Suffix;
        private System.Windows.Forms.TextBox txt_RenameSuffix;
        private System.Windows.Forms.TabPage tabPage_Archives;
        private System.Windows.Forms.TableLayoutPanel tlp_Archives;
        private System.Windows.Forms.Button btn_ExtractArchive;
        private System.Windows.Forms.Button btn_RepackArchive;
        private System.Windows.Forms.RichTextBox rtb_Log;
        private System.Windows.Forms.CheckBox chk_LoopAll;
    }
}