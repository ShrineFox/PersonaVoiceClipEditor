using GrayIris.Utilities.UI.Controls;

namespace PersonaVoiceClipEditor
{
    partial class PersonaVCEForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonaVCEForm));
            this.tabControl_Main = new GrayIris.Utilities.UI.Controls.YaTabControl();
            this.tabPage_Encoding = new GrayIris.Utilities.UI.Controls.YaTabPage();
            this.tlp_Encoding = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_OutFormat = new System.Windows.Forms.TableLayoutPanel();
            this.dropDownList_OutFormat = new DarkUI.Controls.DarkDropdownList();
            this.lbl_OutFormat = new DarkUI.Controls.DarkLabel();
            this.tlp_OutputDir = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_OutputDir = new DarkUI.Controls.DarkLabel();
            this.txt_OutputDir = new DarkUI.Controls.DarkTextBox();
            this.btn_OutputDir = new DarkUI.Controls.DarkButton();
            this.tlp_InputDir = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_InputDir = new DarkUI.Controls.DarkLabel();
            this.txt_InputDir = new DarkUI.Controls.DarkTextBox();
            this.btn_InputDir = new DarkUI.Controls.DarkButton();
            this.btn_Encode = new DarkUI.Controls.DarkButton();
            this.tlp_Loop = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_LoopEnd = new System.Windows.Forms.TableLayoutPanel();
            this.num_LoopEnd = new DarkUI.Controls.DarkNumericUpDown();
            this.lbl_LoopEnd = new DarkUI.Controls.DarkLabel();
            this.chk_UseLoops = new DarkUI.Controls.DarkCheckBox();
            this.chk_LoopAll = new DarkUI.Controls.DarkCheckBox();
            this.tlp_LoopStart = new System.Windows.Forms.TableLayoutPanel();
            this.num_LoopStart = new DarkUI.Controls.DarkNumericUpDown();
            this.lbl_LoopStart = new DarkUI.Controls.DarkLabel();
            this.tlp_UseKey = new System.Windows.Forms.TableLayoutPanel();
            this.chk_UseEncKey = new DarkUI.Controls.DarkCheckBox();
            this.txt_Key = new DarkUI.Controls.DarkTextBox();
            this.tabPage_Renaming = new GrayIris.Utilities.UI.Controls.YaTabPage();
            this.tlp_Renaming = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_RenameOutput = new System.Windows.Forms.TableLayoutPanel();
            this.btn_RenameOutput = new DarkUI.Controls.DarkButton();
            this.lbl_RenameOutput = new DarkUI.Controls.DarkLabel();
            this.txt_RenameOutput = new DarkUI.Controls.DarkTextBox();
            this.tlp_RenameDir = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_RenameDir = new DarkUI.Controls.DarkLabel();
            this.txt_RenameDir = new DarkUI.Controls.DarkTextBox();
            this.btn_RenameDir = new DarkUI.Controls.DarkButton();
            this.tlp_Key = new System.Windows.Forms.TableLayoutPanel();
            this.num_StartIndex = new DarkUI.Controls.DarkNumericUpDown();
            this.lbl_Padding = new DarkUI.Controls.DarkLabel();
            this.num_Padding = new DarkUI.Controls.DarkNumericUpDown();
            this.lbl_StartIndex = new DarkUI.Controls.DarkLabel();
            this.tlp_Suffix = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_TxtSuffix = new DarkUI.Controls.DarkLabel();
            this.txt_Suffix = new DarkUI.Controls.DarkTextBox();
            this.chk_AppendFilename = new DarkUI.Controls.DarkCheckBox();
            this.tlp_TxtFile = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_TxtFile = new DarkUI.Controls.DarkLabel();
            this.txt_TxtFile = new DarkUI.Controls.DarkTextBox();
            this.btn_TxtFile = new DarkUI.Controls.DarkButton();
            this.btn_Rename = new DarkUI.Controls.DarkButton();
            this.tabPage_Archives = new GrayIris.Utilities.UI.Controls.YaTabPage();
            this.tlp_Archives = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_OutputArchive = new System.Windows.Forms.TableLayoutPanel();
            this.btn_OutputArchive = new DarkUI.Controls.DarkButton();
            this.lbl_OutputArchive = new DarkUI.Controls.DarkLabel();
            this.txt_OutputArchive = new DarkUI.Controls.DarkTextBox();
            this.tlp_ArchiveDir = new System.Windows.Forms.TableLayoutPanel();
            this.btn_ArchiveDir = new DarkUI.Controls.DarkButton();
            this.txt_ArchiveDir = new DarkUI.Controls.DarkTextBox();
            this.lbl_ArchiveDir = new DarkUI.Controls.DarkLabel();
            this.tlp_InputArchive = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_InputArchive = new DarkUI.Controls.DarkLabel();
            this.txt_InputArchive = new DarkUI.Controls.DarkTextBox();
            this.btn_InputArchive = new DarkUI.Controls.DarkButton();
            this.tlp_ArchiveFormat = new System.Windows.Forms.TableLayoutPanel();
            this.dropDownList_ArchiveFormat = new DarkUI.Controls.DarkDropdownList();
            this.lbl_ArchiveFormat = new DarkUI.Controls.DarkLabel();
            this.btn_Unpack = new DarkUI.Controls.DarkButton();
            this.btn_Repack = new DarkUI.Controls.DarkButton();
            this.rtb_Log = new System.Windows.Forms.RichTextBox();
            this.dropDownList_Preset = new DarkUI.Controls.DarkDropdownList();
            this.lbl_Preset = new DarkUI.Controls.DarkLabel();
            this.tlp_Main = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_GitHubLink = new System.Windows.Forms.LinkLabel();
            this.tabControl_Main.SuspendLayout();
            this.tabPage_Encoding.SuspendLayout();
            this.tlp_Encoding.SuspendLayout();
            this.tlp_OutFormat.SuspendLayout();
            this.tlp_OutputDir.SuspendLayout();
            this.tlp_InputDir.SuspendLayout();
            this.tlp_Loop.SuspendLayout();
            this.tlp_LoopEnd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_LoopEnd)).BeginInit();
            this.tlp_LoopStart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_LoopStart)).BeginInit();
            this.tlp_UseKey.SuspendLayout();
            this.tabPage_Renaming.SuspendLayout();
            this.tlp_Renaming.SuspendLayout();
            this.tlp_RenameOutput.SuspendLayout();
            this.tlp_RenameDir.SuspendLayout();
            this.tlp_Key.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_StartIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Padding)).BeginInit();
            this.tlp_Suffix.SuspendLayout();
            this.tlp_TxtFile.SuspendLayout();
            this.tabPage_Archives.SuspendLayout();
            this.tlp_Archives.SuspendLayout();
            this.tlp_OutputArchive.SuspendLayout();
            this.tlp_ArchiveDir.SuspendLayout();
            this.tlp_InputArchive.SuspendLayout();
            this.tlp_ArchiveFormat.SuspendLayout();
            this.tlp_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.tabControl_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.tabControl_Main.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.tabControl_Main.CloseButton = false;
            this.tabControl_Main.Controls.Add(this.tabPage_Encoding);
            this.tabControl_Main.Controls.Add(this.tabPage_Renaming);
            this.tabControl_Main.Controls.Add(this.tabPage_Archives);
            this.tabControl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Main.ForeColor = System.Drawing.Color.Silver;
            this.tabControl_Main.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.tabControl_Main.ImageIndex = -1;
            this.tabControl_Main.ImageList = null;
            this.tabControl_Main.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.tabControl_Main.Location = new System.Drawing.Point(3, 3);
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.NewTabButton = false;
            this.tabControl_Main.OverIndex = -1;
            this.tabControl_Main.ScrollButtonStyle = GrayIris.Utilities.UI.Controls.YaScrollButtonStyle.Always;
            this.tabControl_Main.SelectedIndex = 1;
            this.tabControl_Main.SelectedTab = this.tabPage_Renaming;
            this.tabControl_Main.Size = new System.Drawing.Size(676, 265);
            this.tabControl_Main.TabDock = System.Windows.Forms.DockStyle.Top;
            this.tabControl_Main.TabDrawer = null;
            this.tabControl_Main.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_Main.TabIndex = 0;
            // 
            // tabPage_Encoding
            // 
            this.tabPage_Encoding.Controls.Add(this.tlp_Encoding);
            this.tabPage_Encoding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPage_Encoding.ImageIndex = -1;
            this.tabPage_Encoding.Location = new System.Drawing.Point(4, 33);
            this.tabPage_Encoding.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_Encoding.Name = "tabPage_Encoding";
            this.tabPage_Encoding.Size = new System.Drawing.Size(668, 228);
            this.tabPage_Encoding.TabIndex = 1;
            this.tabPage_Encoding.Text = "Encoding";
            // 
            // tlp_Encoding
            // 
            this.tlp_Encoding.ColumnCount = 3;
            this.tlp_Encoding.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tlp_Encoding.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tlp_Encoding.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tlp_Encoding.Controls.Add(this.tlp_OutFormat, 2, 0);
            this.tlp_Encoding.Controls.Add(this.tlp_OutputDir, 0, 1);
            this.tlp_Encoding.Controls.Add(this.tlp_InputDir, 0, 0);
            this.tlp_Encoding.Controls.Add(this.btn_Encode, 2, 2);
            this.tlp_Encoding.Controls.Add(this.tlp_Loop, 0, 2);
            this.tlp_Encoding.Controls.Add(this.tlp_UseKey, 2, 1);
            this.tlp_Encoding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Encoding.Location = new System.Drawing.Point(0, 0);
            this.tlp_Encoding.Name = "tlp_Encoding";
            this.tlp_Encoding.RowCount = 3;
            this.tlp_Encoding.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tlp_Encoding.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tlp_Encoding.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tlp_Encoding.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_Encoding.Size = new System.Drawing.Size(668, 228);
            this.tlp_Encoding.TabIndex = 41;
            // 
            // tlp_OutFormat
            // 
            this.tlp_OutFormat.ColumnCount = 1;
            this.tlp_OutFormat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_OutFormat.Controls.Add(this.dropDownList_OutFormat, 0, 1);
            this.tlp_OutFormat.Controls.Add(this.lbl_OutFormat, 0, 0);
            this.tlp_OutFormat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_OutFormat.Location = new System.Drawing.Point(443, 3);
            this.tlp_OutFormat.Name = "tlp_OutFormat";
            this.tlp_OutFormat.RowCount = 2;
            this.tlp_OutFormat.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_OutFormat.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_OutFormat.Size = new System.Drawing.Size(222, 69);
            this.tlp_OutFormat.TabIndex = 46;
            // 
            // dropDownList_OutFormat
            // 
            this.dropDownList_OutFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dropDownList_OutFormat.Location = new System.Drawing.Point(3, 40);
            this.dropDownList_OutFormat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dropDownList_OutFormat.Name = "dropDownList_OutFormat";
            this.dropDownList_OutFormat.Size = new System.Drawing.Size(216, 22);
            this.dropDownList_OutFormat.TabIndex = 11;
            this.dropDownList_OutFormat.SelectedItemChanged += new System.EventHandler(this.dropDownList_Changed);
            // 
            // lbl_OutFormat
            // 
            this.lbl_OutFormat.AutoSize = true;
            this.lbl_OutFormat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_OutFormat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_OutFormat.Location = new System.Drawing.Point(3, 18);
            this.lbl_OutFormat.Name = "lbl_OutFormat";
            this.lbl_OutFormat.Size = new System.Drawing.Size(216, 16);
            this.lbl_OutFormat.TabIndex = 10;
            this.lbl_OutFormat.Text = "Output Format:";
            // 
            // tlp_OutputDir
            // 
            this.tlp_OutputDir.ColumnCount = 2;
            this.tlp_Encoding.SetColumnSpan(this.tlp_OutputDir, 2);
            this.tlp_OutputDir.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlp_OutputDir.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_OutputDir.Controls.Add(this.lbl_OutputDir, 0, 0);
            this.tlp_OutputDir.Controls.Add(this.txt_OutputDir, 0, 1);
            this.tlp_OutputDir.Controls.Add(this.btn_OutputDir, 1, 1);
            this.tlp_OutputDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_OutputDir.Location = new System.Drawing.Point(3, 78);
            this.tlp_OutputDir.Name = "tlp_OutputDir";
            this.tlp_OutputDir.RowCount = 2;
            this.tlp_OutputDir.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_OutputDir.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_OutputDir.Size = new System.Drawing.Size(434, 69);
            this.tlp_OutputDir.TabIndex = 45;
            // 
            // lbl_OutputDir
            // 
            this.lbl_OutputDir.AutoSize = true;
            this.lbl_OutputDir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_OutputDir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_OutputDir.Location = new System.Drawing.Point(3, 18);
            this.lbl_OutputDir.Name = "lbl_OutputDir";
            this.lbl_OutputDir.Size = new System.Drawing.Size(384, 16);
            this.lbl_OutputDir.TabIndex = 5;
            this.lbl_OutputDir.Text = "Output Files Directory:";
            // 
            // txt_OutputDir
            // 
            this.txt_OutputDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_OutputDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txt_OutputDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_OutputDir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txt_OutputDir.Location = new System.Drawing.Point(3, 40);
            this.txt_OutputDir.Name = "txt_OutputDir";
            this.txt_OutputDir.ReadOnly = true;
            this.txt_OutputDir.Size = new System.Drawing.Size(384, 22);
            this.txt_OutputDir.TabIndex = 6;
            this.txt_OutputDir.TextChanged += new System.EventHandler(this.EncodeDir_Changed);
            this.txt_OutputDir.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            // 
            // btn_OutputDir
            // 
            this.btn_OutputDir.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_OutputDir.Location = new System.Drawing.Point(393, 41);
            this.btn_OutputDir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_OutputDir.Name = "btn_OutputDir";
            this.btn_OutputDir.Padding = new System.Windows.Forms.Padding(4);
            this.btn_OutputDir.Size = new System.Drawing.Size(37, 21);
            this.btn_OutputDir.TabIndex = 7;
            this.btn_OutputDir.Text = "...";
            this.btn_OutputDir.Click += new System.EventHandler(this.OutputDir_Click);
            this.btn_OutputDir.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            // 
            // tlp_InputDir
            // 
            this.tlp_InputDir.ColumnCount = 2;
            this.tlp_Encoding.SetColumnSpan(this.tlp_InputDir, 2);
            this.tlp_InputDir.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlp_InputDir.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_InputDir.Controls.Add(this.lbl_InputDir, 0, 0);
            this.tlp_InputDir.Controls.Add(this.txt_InputDir, 0, 1);
            this.tlp_InputDir.Controls.Add(this.btn_InputDir, 1, 1);
            this.tlp_InputDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_InputDir.Location = new System.Drawing.Point(3, 3);
            this.tlp_InputDir.Name = "tlp_InputDir";
            this.tlp_InputDir.RowCount = 2;
            this.tlp_InputDir.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_InputDir.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_InputDir.Size = new System.Drawing.Size(434, 69);
            this.tlp_InputDir.TabIndex = 44;
            // 
            // lbl_InputDir
            // 
            this.lbl_InputDir.AutoSize = true;
            this.lbl_InputDir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_InputDir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_InputDir.Location = new System.Drawing.Point(3, 18);
            this.lbl_InputDir.Name = "lbl_InputDir";
            this.lbl_InputDir.Size = new System.Drawing.Size(384, 16);
            this.lbl_InputDir.TabIndex = 2;
            this.lbl_InputDir.Text = "Input Files Directory:";
            // 
            // txt_InputDir
            // 
            this.txt_InputDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_InputDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txt_InputDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_InputDir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txt_InputDir.Location = new System.Drawing.Point(3, 40);
            this.txt_InputDir.Name = "txt_InputDir";
            this.txt_InputDir.ReadOnly = true;
            this.txt_InputDir.Size = new System.Drawing.Size(384, 22);
            this.txt_InputDir.TabIndex = 3;
            this.txt_InputDir.TextChanged += new System.EventHandler(this.EncodeDir_Changed);
            this.txt_InputDir.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            // 
            // btn_InputDir
            // 
            this.btn_InputDir.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_InputDir.Location = new System.Drawing.Point(393, 41);
            this.btn_InputDir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_InputDir.Name = "btn_InputDir";
            this.btn_InputDir.Padding = new System.Windows.Forms.Padding(4);
            this.btn_InputDir.Size = new System.Drawing.Size(37, 21);
            this.btn_InputDir.TabIndex = 4;
            this.btn_InputDir.Text = "...";
            this.btn_InputDir.Click += new System.EventHandler(this.InputDir_Click);
            this.btn_InputDir.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            // 
            // btn_Encode
            // 
            this.btn_Encode.AllowDrop = true;
            this.btn_Encode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Encode.Enabled = false;
            this.btn_Encode.Location = new System.Drawing.Point(443, 153);
            this.btn_Encode.Name = "btn_Encode";
            this.btn_Encode.Padding = new System.Windows.Forms.Padding(5);
            this.btn_Encode.Size = new System.Drawing.Size(222, 72);
            this.btn_Encode.TabIndex = 12;
            this.btn_Encode.Text = "Encode Files";
            this.btn_Encode.Click += new System.EventHandler(this.Encode_Click);
            this.btn_Encode.DragDrop += new System.Windows.Forms.DragEventHandler(this.Encode_DragDrop);
            this.btn_Encode.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            // 
            // tlp_Loop
            // 
            this.tlp_Loop.ColumnCount = 2;
            this.tlp_Encoding.SetColumnSpan(this.tlp_Loop, 2);
            this.tlp_Loop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Loop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 215F));
            this.tlp_Loop.Controls.Add(this.tlp_LoopEnd, 1, 1);
            this.tlp_Loop.Controls.Add(this.chk_UseLoops, 0, 0);
            this.tlp_Loop.Controls.Add(this.chk_LoopAll, 1, 0);
            this.tlp_Loop.Controls.Add(this.tlp_LoopStart, 0, 1);
            this.tlp_Loop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Loop.Location = new System.Drawing.Point(3, 153);
            this.tlp_Loop.Name = "tlp_Loop";
            this.tlp_Loop.RowCount = 2;
            this.tlp_Loop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Loop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Loop.Size = new System.Drawing.Size(434, 72);
            this.tlp_Loop.TabIndex = 48;
            // 
            // tlp_LoopEnd
            // 
            this.tlp_LoopEnd.ColumnCount = 2;
            this.tlp_LoopEnd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_LoopEnd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_LoopEnd.Controls.Add(this.num_LoopEnd, 0, 0);
            this.tlp_LoopEnd.Controls.Add(this.lbl_LoopEnd, 0, 0);
            this.tlp_LoopEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_LoopEnd.Location = new System.Drawing.Point(222, 39);
            this.tlp_LoopEnd.Name = "tlp_LoopEnd";
            this.tlp_LoopEnd.RowCount = 1;
            this.tlp_LoopEnd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_LoopEnd.Size = new System.Drawing.Size(209, 30);
            this.tlp_LoopEnd.TabIndex = 25;
            // 
            // num_LoopEnd
            // 
            this.num_LoopEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.num_LoopEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_LoopEnd.Enabled = false;
            this.num_LoopEnd.Location = new System.Drawing.Point(107, 4);
            this.num_LoopEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.num_LoopEnd.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.num_LoopEnd.Name = "num_LoopEnd";
            this.num_LoopEnd.Size = new System.Drawing.Size(99, 22);
            this.num_LoopEnd.TabIndex = 24;
            // 
            // lbl_LoopEnd
            // 
            this.lbl_LoopEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_LoopEnd.AutoSize = true;
            this.lbl_LoopEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_LoopEnd.Location = new System.Drawing.Point(3, 7);
            this.lbl_LoopEnd.Name = "lbl_LoopEnd";
            this.lbl_LoopEnd.Size = new System.Drawing.Size(98, 16);
            this.lbl_LoopEnd.TabIndex = 3;
            this.lbl_LoopEnd.Text = "End Sample:";
            // 
            // chk_UseLoops
            // 
            this.chk_UseLoops.AutoSize = true;
            this.chk_UseLoops.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chk_UseLoops.Location = new System.Drawing.Point(3, 14);
            this.chk_UseLoops.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chk_UseLoops.Name = "chk_UseLoops";
            this.chk_UseLoops.Size = new System.Drawing.Size(213, 20);
            this.chk_UseLoops.TabIndex = 9;
            this.chk_UseLoops.Text = "Use New Loop Points:";
            this.chk_UseLoops.CheckedChanged += new System.EventHandler(this.UseLoops_Checked);
            // 
            // chk_LoopAll
            // 
            this.chk_LoopAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_LoopAll.AutoSize = true;
            this.chk_LoopAll.Enabled = false;
            this.chk_LoopAll.Location = new System.Drawing.Point(309, 14);
            this.chk_LoopAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chk_LoopAll.Name = "chk_LoopAll";
            this.chk_LoopAll.Size = new System.Drawing.Size(122, 20);
            this.chk_LoopAll.TabIndex = 10;
            this.chk_LoopAll.Text = "Loop Entire File";
            this.chk_LoopAll.Visible = false;
            this.chk_LoopAll.CheckedChanged += new System.EventHandler(this.LoopAll_Checked);
            // 
            // tlp_LoopStart
            // 
            this.tlp_LoopStart.ColumnCount = 2;
            this.tlp_LoopStart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_LoopStart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_LoopStart.Controls.Add(this.num_LoopStart, 0, 0);
            this.tlp_LoopStart.Controls.Add(this.lbl_LoopStart, 0, 0);
            this.tlp_LoopStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_LoopStart.Location = new System.Drawing.Point(3, 39);
            this.tlp_LoopStart.Name = "tlp_LoopStart";
            this.tlp_LoopStart.RowCount = 1;
            this.tlp_LoopStart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_LoopStart.Size = new System.Drawing.Size(213, 30);
            this.tlp_LoopStart.TabIndex = 11;
            // 
            // num_LoopStart
            // 
            this.num_LoopStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.num_LoopStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_LoopStart.Enabled = false;
            this.num_LoopStart.Location = new System.Drawing.Point(109, 4);
            this.num_LoopStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.num_LoopStart.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.num_LoopStart.Name = "num_LoopStart";
            this.num_LoopStart.Size = new System.Drawing.Size(101, 22);
            this.num_LoopStart.TabIndex = 24;
            // 
            // lbl_LoopStart
            // 
            this.lbl_LoopStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_LoopStart.AutoSize = true;
            this.lbl_LoopStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_LoopStart.Location = new System.Drawing.Point(3, 7);
            this.lbl_LoopStart.Name = "lbl_LoopStart";
            this.lbl_LoopStart.Size = new System.Drawing.Size(100, 16);
            this.lbl_LoopStart.TabIndex = 3;
            this.lbl_LoopStart.Text = "Start Sample:";
            // 
            // tlp_UseKey
            // 
            this.tlp_UseKey.ColumnCount = 1;
            this.tlp_UseKey.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlp_UseKey.Controls.Add(this.chk_UseEncKey, 0, 0);
            this.tlp_UseKey.Controls.Add(this.txt_Key, 0, 1);
            this.tlp_UseKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_UseKey.Location = new System.Drawing.Point(443, 78);
            this.tlp_UseKey.Name = "tlp_UseKey";
            this.tlp_UseKey.RowCount = 2;
            this.tlp_UseKey.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_UseKey.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_UseKey.Size = new System.Drawing.Size(222, 69);
            this.tlp_UseKey.TabIndex = 47;
            // 
            // chk_UseEncKey
            // 
            this.chk_UseEncKey.AutoSize = true;
            this.chk_UseEncKey.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chk_UseEncKey.Location = new System.Drawing.Point(3, 12);
            this.chk_UseEncKey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chk_UseEncKey.Name = "chk_UseEncKey";
            this.chk_UseEncKey.Size = new System.Drawing.Size(216, 20);
            this.chk_UseEncKey.TabIndex = 8;
            this.chk_UseEncKey.Text = "Use Encryption Key:";
            this.chk_UseEncKey.CheckedChanged += new System.EventHandler(this.UseKey_CheckedChanged);
            // 
            // txt_Key
            // 
            this.txt_Key.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Key.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txt_Key.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Key.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txt_Key.Location = new System.Drawing.Point(3, 40);
            this.txt_Key.Name = "txt_Key";
            this.txt_Key.ReadOnly = true;
            this.txt_Key.Size = new System.Drawing.Size(216, 22);
            this.txt_Key.TabIndex = 9;
            this.txt_Key.TextChanged += new System.EventHandler(this.Txt_Changed);
            // 
            // tabPage_Renaming
            // 
            this.tabPage_Renaming.Controls.Add(this.tlp_Renaming);
            this.tabPage_Renaming.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPage_Renaming.ImageIndex = -1;
            this.tabPage_Renaming.Location = new System.Drawing.Point(4, 33);
            this.tabPage_Renaming.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_Renaming.Name = "tabPage_Renaming";
            this.tabPage_Renaming.Size = new System.Drawing.Size(668, 228);
            this.tabPage_Renaming.TabIndex = 13;
            this.tabPage_Renaming.Text = "Renaming";
            this.tabPage_Renaming.DragDrop += new System.Windows.Forms.DragEventHandler(this.Txt_DragDrop);
            this.tabPage_Renaming.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            // 
            // tlp_Renaming
            // 
            this.tlp_Renaming.ColumnCount = 3;
            this.tlp_Renaming.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tlp_Renaming.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tlp_Renaming.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tlp_Renaming.Controls.Add(this.tlp_RenameOutput, 0, 2);
            this.tlp_Renaming.Controls.Add(this.tlp_RenameDir, 0, 1);
            this.tlp_Renaming.Controls.Add(this.tlp_Key, 2, 1);
            this.tlp_Renaming.Controls.Add(this.tlp_Suffix, 2, 0);
            this.tlp_Renaming.Controls.Add(this.tlp_TxtFile, 0, 0);
            this.tlp_Renaming.Controls.Add(this.btn_Rename, 2, 2);
            this.tlp_Renaming.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Renaming.Location = new System.Drawing.Point(0, 0);
            this.tlp_Renaming.Name = "tlp_Renaming";
            this.tlp_Renaming.RowCount = 3;
            this.tlp_Renaming.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tlp_Renaming.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tlp_Renaming.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tlp_Renaming.Size = new System.Drawing.Size(668, 228);
            this.tlp_Renaming.TabIndex = 42;
            // 
            // tlp_RenameOutput
            // 
            this.tlp_RenameOutput.ColumnCount = 2;
            this.tlp_Renaming.SetColumnSpan(this.tlp_RenameOutput, 2);
            this.tlp_RenameOutput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlp_RenameOutput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_RenameOutput.Controls.Add(this.btn_RenameOutput, 1, 1);
            this.tlp_RenameOutput.Controls.Add(this.lbl_RenameOutput, 0, 0);
            this.tlp_RenameOutput.Controls.Add(this.txt_RenameOutput, 0, 1);
            this.tlp_RenameOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_RenameOutput.Location = new System.Drawing.Point(3, 153);
            this.tlp_RenameOutput.Name = "tlp_RenameOutput";
            this.tlp_RenameOutput.RowCount = 2;
            this.tlp_RenameOutput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_RenameOutput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_RenameOutput.Size = new System.Drawing.Size(434, 72);
            this.tlp_RenameOutput.TabIndex = 47;
            // 
            // btn_RenameOutput
            // 
            this.btn_RenameOutput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_RenameOutput.Location = new System.Drawing.Point(393, 43);
            this.btn_RenameOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_RenameOutput.Name = "btn_RenameOutput";
            this.btn_RenameOutput.Padding = new System.Windows.Forms.Padding(4);
            this.btn_RenameOutput.Size = new System.Drawing.Size(37, 21);
            this.btn_RenameOutput.TabIndex = 21;
            this.btn_RenameOutput.Text = "...";
            this.btn_RenameOutput.Click += new System.EventHandler(this.RenameOutputDir_Click);
            this.btn_RenameOutput.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            // 
            // lbl_RenameOutput
            // 
            this.lbl_RenameOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_RenameOutput.AutoSize = true;
            this.lbl_RenameOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_RenameOutput.Location = new System.Drawing.Point(3, 10);
            this.lbl_RenameOutput.Name = "lbl_RenameOutput";
            this.lbl_RenameOutput.Size = new System.Drawing.Size(384, 16);
            this.lbl_RenameOutput.TabIndex = 19;
            this.lbl_RenameOutput.Text = "Output Directory:";
            // 
            // txt_RenameOutput
            // 
            this.txt_RenameOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_RenameOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txt_RenameOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_RenameOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txt_RenameOutput.Location = new System.Drawing.Point(3, 43);
            this.txt_RenameOutput.Name = "txt_RenameOutput";
            this.txt_RenameOutput.Size = new System.Drawing.Size(384, 22);
            this.txt_RenameOutput.TabIndex = 20;
            this.txt_RenameOutput.TextChanged += new System.EventHandler(this.RenamePath_Changed);
            this.txt_RenameOutput.DragDrop += new System.Windows.Forms.DragEventHandler(this.Txt_DragDrop);
            this.txt_RenameOutput.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            // 
            // tlp_RenameDir
            // 
            this.tlp_RenameDir.ColumnCount = 2;
            this.tlp_Renaming.SetColumnSpan(this.tlp_RenameDir, 2);
            this.tlp_RenameDir.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlp_RenameDir.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_RenameDir.Controls.Add(this.lbl_RenameDir, 0, 0);
            this.tlp_RenameDir.Controls.Add(this.txt_RenameDir, 0, 1);
            this.tlp_RenameDir.Controls.Add(this.btn_RenameDir, 1, 1);
            this.tlp_RenameDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_RenameDir.Location = new System.Drawing.Point(3, 78);
            this.tlp_RenameDir.Name = "tlp_RenameDir";
            this.tlp_RenameDir.RowCount = 2;
            this.tlp_RenameDir.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_RenameDir.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_RenameDir.Size = new System.Drawing.Size(434, 69);
            this.tlp_RenameDir.TabIndex = 47;
            // 
            // lbl_RenameDir
            // 
            this.lbl_RenameDir.AutoSize = true;
            this.lbl_RenameDir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_RenameDir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_RenameDir.Location = new System.Drawing.Point(3, 18);
            this.lbl_RenameDir.Name = "lbl_RenameDir";
            this.lbl_RenameDir.Size = new System.Drawing.Size(384, 16);
            this.lbl_RenameDir.TabIndex = 16;
            this.lbl_RenameDir.Text = "Directory of Files to Rename:";
            // 
            // txt_RenameDir
            // 
            this.txt_RenameDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_RenameDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txt_RenameDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_RenameDir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txt_RenameDir.Location = new System.Drawing.Point(3, 40);
            this.txt_RenameDir.Name = "txt_RenameDir";
            this.txt_RenameDir.Size = new System.Drawing.Size(384, 22);
            this.txt_RenameDir.TabIndex = 17;
            this.txt_RenameDir.TextChanged += new System.EventHandler(this.RenamePath_Changed);
            this.txt_RenameDir.DragDrop += new System.Windows.Forms.DragEventHandler(this.Txt_DragDrop);
            this.txt_RenameDir.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            // 
            // btn_RenameDir
            // 
            this.btn_RenameDir.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_RenameDir.Location = new System.Drawing.Point(393, 41);
            this.btn_RenameDir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_RenameDir.Name = "btn_RenameDir";
            this.btn_RenameDir.Padding = new System.Windows.Forms.Padding(4);
            this.btn_RenameDir.Size = new System.Drawing.Size(37, 21);
            this.btn_RenameDir.TabIndex = 18;
            this.btn_RenameDir.Text = "...";
            this.btn_RenameDir.Click += new System.EventHandler(this.RenameDir_Click);
            this.btn_RenameDir.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            // 
            // tlp_Key
            // 
            this.tlp_Key.ColumnCount = 2;
            this.tlp_Key.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Key.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Key.Controls.Add(this.num_StartIndex, 1, 1);
            this.tlp_Key.Controls.Add(this.lbl_Padding, 0, 0);
            this.tlp_Key.Controls.Add(this.num_Padding, 1, 0);
            this.tlp_Key.Controls.Add(this.lbl_StartIndex, 0, 1);
            this.tlp_Key.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Key.Location = new System.Drawing.Point(443, 78);
            this.tlp_Key.Name = "tlp_Key";
            this.tlp_Key.RowCount = 2;
            this.tlp_Key.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Key.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Key.Size = new System.Drawing.Size(222, 69);
            this.tlp_Key.TabIndex = 47;
            // 
            // num_StartIndex
            // 
            this.num_StartIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.num_StartIndex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_StartIndex.Location = new System.Drawing.Point(114, 40);
            this.num_StartIndex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.num_StartIndex.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.num_StartIndex.Name = "num_StartIndex";
            this.num_StartIndex.Size = new System.Drawing.Size(105, 22);
            this.num_StartIndex.TabIndex = 27;
            // 
            // lbl_Padding
            // 
            this.lbl_Padding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Padding.AutoSize = true;
            this.lbl_Padding.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_Padding.Location = new System.Drawing.Point(3, 9);
            this.lbl_Padding.Name = "lbl_Padding";
            this.lbl_Padding.Size = new System.Drawing.Size(105, 16);
            this.lbl_Padding.TabIndex = 23;
            this.lbl_Padding.Text = "Left Padding:";
            // 
            // num_Padding
            // 
            this.num_Padding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.num_Padding.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_Padding.Location = new System.Drawing.Point(114, 6);
            this.num_Padding.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.num_Padding.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.num_Padding.Name = "num_Padding";
            this.num_Padding.Size = new System.Drawing.Size(105, 22);
            this.num_Padding.TabIndex = 23;
            this.num_Padding.ValueChanged += new System.EventHandler(this.Value_Changed);
            // 
            // lbl_StartIndex
            // 
            this.lbl_StartIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_StartIndex.AutoSize = true;
            this.lbl_StartIndex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_StartIndex.Location = new System.Drawing.Point(3, 43);
            this.lbl_StartIndex.Name = "lbl_StartIndex";
            this.lbl_StartIndex.Size = new System.Drawing.Size(105, 16);
            this.lbl_StartIndex.TabIndex = 26;
            this.lbl_StartIndex.Text = "# Start Index:";
            // 
            // tlp_Suffix
            // 
            this.tlp_Suffix.ColumnCount = 1;
            this.tlp_Suffix.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Suffix.Controls.Add(this.lbl_TxtSuffix, 0, 0);
            this.tlp_Suffix.Controls.Add(this.txt_Suffix, 0, 1);
            this.tlp_Suffix.Controls.Add(this.chk_AppendFilename, 0, 2);
            this.tlp_Suffix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Suffix.Location = new System.Drawing.Point(443, 3);
            this.tlp_Suffix.Name = "tlp_Suffix";
            this.tlp_Suffix.RowCount = 3;
            this.tlp_Suffix.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.49876F));
            this.tlp_Suffix.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.75434F));
            this.tlp_Suffix.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.7469F));
            this.tlp_Suffix.Size = new System.Drawing.Size(222, 69);
            this.tlp_Suffix.TabIndex = 47;
            // 
            // lbl_TxtSuffix
            // 
            this.lbl_TxtSuffix.AutoSize = true;
            this.lbl_TxtSuffix.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_TxtSuffix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_TxtSuffix.Location = new System.Drawing.Point(3, 7);
            this.lbl_TxtSuffix.Name = "lbl_TxtSuffix";
            this.lbl_TxtSuffix.Size = new System.Drawing.Size(216, 16);
            this.lbl_TxtSuffix.TabIndex = 22;
            this.lbl_TxtSuffix.Text = ".Txt ID Suffix:";
            // 
            // txt_Suffix
            // 
            this.txt_Suffix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Suffix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txt_Suffix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Suffix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txt_Suffix.Location = new System.Drawing.Point(3, 26);
            this.txt_Suffix.Name = "txt_Suffix";
            this.txt_Suffix.Size = new System.Drawing.Size(216, 22);
            this.txt_Suffix.TabIndex = 23;
            this.txt_Suffix.TextChanged += new System.EventHandler(this.Txt_Changed);
            // 
            // chk_AppendFilename
            // 
            this.chk_AppendFilename.AutoSize = true;
            this.chk_AppendFilename.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chk_AppendFilename.Location = new System.Drawing.Point(3, 47);
            this.chk_AppendFilename.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chk_AppendFilename.Name = "chk_AppendFilename";
            this.chk_AppendFilename.Size = new System.Drawing.Size(216, 20);
            this.chk_AppendFilename.TabIndex = 25;
            this.chk_AppendFilename.Text = "Append Original Filename";
            this.chk_AppendFilename.CheckedChanged += new System.EventHandler(this.AppendFilename_CheckedChanged);
            // 
            // tlp_TxtFile
            // 
            this.tlp_TxtFile.ColumnCount = 2;
            this.tlp_Renaming.SetColumnSpan(this.tlp_TxtFile, 2);
            this.tlp_TxtFile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlp_TxtFile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_TxtFile.Controls.Add(this.lbl_TxtFile, 0, 0);
            this.tlp_TxtFile.Controls.Add(this.txt_TxtFile, 0, 1);
            this.tlp_TxtFile.Controls.Add(this.btn_TxtFile, 1, 1);
            this.tlp_TxtFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_TxtFile.Location = new System.Drawing.Point(3, 3);
            this.tlp_TxtFile.Name = "tlp_TxtFile";
            this.tlp_TxtFile.RowCount = 2;
            this.tlp_TxtFile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_TxtFile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_TxtFile.Size = new System.Drawing.Size(434, 69);
            this.tlp_TxtFile.TabIndex = 47;
            // 
            // lbl_TxtFile
            // 
            this.lbl_TxtFile.AutoSize = true;
            this.lbl_TxtFile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_TxtFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_TxtFile.Location = new System.Drawing.Point(3, 18);
            this.lbl_TxtFile.Name = "lbl_TxtFile";
            this.lbl_TxtFile.Size = new System.Drawing.Size(384, 16);
            this.lbl_TxtFile.TabIndex = 13;
            this.lbl_TxtFile.Text = ".Txt File With Filenames in Order:";
            // 
            // txt_TxtFile
            // 
            this.txt_TxtFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_TxtFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txt_TxtFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TxtFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txt_TxtFile.Location = new System.Drawing.Point(3, 40);
            this.txt_TxtFile.Name = "txt_TxtFile";
            this.txt_TxtFile.Size = new System.Drawing.Size(384, 22);
            this.txt_TxtFile.TabIndex = 14;
            this.txt_TxtFile.TextChanged += new System.EventHandler(this.RenamePath_Changed);
            this.txt_TxtFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.Txt_DragDrop);
            this.txt_TxtFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            // 
            // btn_TxtFile
            // 
            this.btn_TxtFile.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_TxtFile.Location = new System.Drawing.Point(393, 41);
            this.btn_TxtFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TxtFile.Name = "btn_TxtFile";
            this.btn_TxtFile.Padding = new System.Windows.Forms.Padding(4);
            this.btn_TxtFile.Size = new System.Drawing.Size(37, 21);
            this.btn_TxtFile.TabIndex = 15;
            this.btn_TxtFile.Text = "...";
            this.btn_TxtFile.Click += new System.EventHandler(this.Txt_Click);
            this.btn_TxtFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            // 
            // btn_Rename
            // 
            this.btn_Rename.AllowDrop = true;
            this.btn_Rename.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Rename.Enabled = false;
            this.btn_Rename.Location = new System.Drawing.Point(443, 153);
            this.btn_Rename.Name = "btn_Rename";
            this.btn_Rename.Padding = new System.Windows.Forms.Padding(5);
            this.btn_Rename.Size = new System.Drawing.Size(222, 72);
            this.btn_Rename.TabIndex = 24;
            this.btn_Rename.Text = "Rename Files";
            this.btn_Rename.Click += new System.EventHandler(this.Rename_Click);
            this.btn_Rename.DragDrop += new System.Windows.Forms.DragEventHandler(this.Rename_DragDrop);
            this.btn_Rename.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            // 
            // tabPage_Archives
            // 
            this.tabPage_Archives.Controls.Add(this.tlp_Archives);
            this.tabPage_Archives.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPage_Archives.ImageIndex = -1;
            this.tabPage_Archives.Location = new System.Drawing.Point(4, 33);
            this.tabPage_Archives.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_Archives.Name = "tabPage_Archives";
            this.tabPage_Archives.Size = new System.Drawing.Size(668, 228);
            this.tabPage_Archives.TabIndex = 25;
            this.tabPage_Archives.Text = "Archives";
            // 
            // tlp_Archives
            // 
            this.tlp_Archives.ColumnCount = 3;
            this.tlp_Archives.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tlp_Archives.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tlp_Archives.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tlp_Archives.Controls.Add(this.tlp_OutputArchive, 0, 2);
            this.tlp_Archives.Controls.Add(this.tlp_ArchiveDir, 0, 1);
            this.tlp_Archives.Controls.Add(this.tlp_InputArchive, 0, 0);
            this.tlp_Archives.Controls.Add(this.tlp_ArchiveFormat, 2, 0);
            this.tlp_Archives.Controls.Add(this.btn_Unpack, 2, 1);
            this.tlp_Archives.Controls.Add(this.btn_Repack, 2, 2);
            this.tlp_Archives.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Archives.Location = new System.Drawing.Point(0, 0);
            this.tlp_Archives.Name = "tlp_Archives";
            this.tlp_Archives.RowCount = 3;
            this.tlp_Archives.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tlp_Archives.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tlp_Archives.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tlp_Archives.Size = new System.Drawing.Size(668, 228);
            this.tlp_Archives.TabIndex = 43;
            // 
            // tlp_OutputArchive
            // 
            this.tlp_OutputArchive.ColumnCount = 2;
            this.tlp_Archives.SetColumnSpan(this.tlp_OutputArchive, 2);
            this.tlp_OutputArchive.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlp_OutputArchive.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_OutputArchive.Controls.Add(this.btn_OutputArchive, 1, 1);
            this.tlp_OutputArchive.Controls.Add(this.lbl_OutputArchive, 0, 0);
            this.tlp_OutputArchive.Controls.Add(this.txt_OutputArchive, 0, 1);
            this.tlp_OutputArchive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_OutputArchive.Location = new System.Drawing.Point(3, 153);
            this.tlp_OutputArchive.Name = "tlp_OutputArchive";
            this.tlp_OutputArchive.RowCount = 2;
            this.tlp_OutputArchive.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_OutputArchive.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_OutputArchive.Size = new System.Drawing.Size(434, 72);
            this.tlp_OutputArchive.TabIndex = 46;
            // 
            // btn_OutputArchive
            // 
            this.btn_OutputArchive.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_OutputArchive.Location = new System.Drawing.Point(393, 43);
            this.btn_OutputArchive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_OutputArchive.Name = "btn_OutputArchive";
            this.btn_OutputArchive.Padding = new System.Windows.Forms.Padding(4);
            this.btn_OutputArchive.Size = new System.Drawing.Size(37, 21);
            this.btn_OutputArchive.TabIndex = 34;
            this.btn_OutputArchive.Text = "...";
            this.btn_OutputArchive.Click += new System.EventHandler(this.OutputArchive_Click);
            this.btn_OutputArchive.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            // 
            // lbl_OutputArchive
            // 
            this.lbl_OutputArchive.AutoSize = true;
            this.lbl_OutputArchive.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_OutputArchive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_OutputArchive.Location = new System.Drawing.Point(3, 20);
            this.lbl_OutputArchive.Name = "lbl_OutputArchive";
            this.lbl_OutputArchive.Size = new System.Drawing.Size(384, 16);
            this.lbl_OutputArchive.TabIndex = 32;
            this.lbl_OutputArchive.Text = "Repacked Archive File:";
            // 
            // txt_OutputArchive
            // 
            this.txt_OutputArchive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_OutputArchive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txt_OutputArchive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_OutputArchive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txt_OutputArchive.Location = new System.Drawing.Point(3, 43);
            this.txt_OutputArchive.Name = "txt_OutputArchive";
            this.txt_OutputArchive.Size = new System.Drawing.Size(384, 22);
            this.txt_OutputArchive.TabIndex = 33;
            this.txt_OutputArchive.TextChanged += new System.EventHandler(this.ArchivePath_Changed);
            this.txt_OutputArchive.DragDrop += new System.Windows.Forms.DragEventHandler(this.Txt_DragDrop);
            this.txt_OutputArchive.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            // 
            // tlp_ArchiveDir
            // 
            this.tlp_ArchiveDir.ColumnCount = 2;
            this.tlp_Archives.SetColumnSpan(this.tlp_ArchiveDir, 2);
            this.tlp_ArchiveDir.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlp_ArchiveDir.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_ArchiveDir.Controls.Add(this.btn_ArchiveDir, 1, 1);
            this.tlp_ArchiveDir.Controls.Add(this.txt_ArchiveDir, 0, 1);
            this.tlp_ArchiveDir.Controls.Add(this.lbl_ArchiveDir, 0, 0);
            this.tlp_ArchiveDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_ArchiveDir.Location = new System.Drawing.Point(3, 78);
            this.tlp_ArchiveDir.Name = "tlp_ArchiveDir";
            this.tlp_ArchiveDir.RowCount = 2;
            this.tlp_ArchiveDir.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_ArchiveDir.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_ArchiveDir.Size = new System.Drawing.Size(434, 69);
            this.tlp_ArchiveDir.TabIndex = 47;
            // 
            // btn_ArchiveDir
            // 
            this.btn_ArchiveDir.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_ArchiveDir.Location = new System.Drawing.Point(393, 41);
            this.btn_ArchiveDir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ArchiveDir.Name = "btn_ArchiveDir";
            this.btn_ArchiveDir.Padding = new System.Windows.Forms.Padding(4);
            this.btn_ArchiveDir.Size = new System.Drawing.Size(37, 21);
            this.btn_ArchiveDir.TabIndex = 31;
            this.btn_ArchiveDir.Text = "...";
            this.btn_ArchiveDir.Click += new System.EventHandler(this.ExtractedArchiveDir_Click);
            this.btn_ArchiveDir.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            // 
            // txt_ArchiveDir
            // 
            this.txt_ArchiveDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ArchiveDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txt_ArchiveDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ArchiveDir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txt_ArchiveDir.Location = new System.Drawing.Point(3, 40);
            this.txt_ArchiveDir.Name = "txt_ArchiveDir";
            this.txt_ArchiveDir.Size = new System.Drawing.Size(384, 22);
            this.txt_ArchiveDir.TabIndex = 30;
            this.txt_ArchiveDir.TextChanged += new System.EventHandler(this.ArchivePath_Changed);
            this.txt_ArchiveDir.DragDrop += new System.Windows.Forms.DragEventHandler(this.Txt_DragDrop);
            this.txt_ArchiveDir.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            // 
            // lbl_ArchiveDir
            // 
            this.lbl_ArchiveDir.AutoSize = true;
            this.lbl_ArchiveDir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_ArchiveDir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_ArchiveDir.Location = new System.Drawing.Point(3, 18);
            this.lbl_ArchiveDir.Name = "lbl_ArchiveDir";
            this.lbl_ArchiveDir.Size = new System.Drawing.Size(384, 16);
            this.lbl_ArchiveDir.TabIndex = 29;
            this.lbl_ArchiveDir.Text = "Extracted Archive Directory:";
            // 
            // tlp_InputArchive
            // 
            this.tlp_InputArchive.ColumnCount = 2;
            this.tlp_Archives.SetColumnSpan(this.tlp_InputArchive, 2);
            this.tlp_InputArchive.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlp_InputArchive.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_InputArchive.Controls.Add(this.lbl_InputArchive, 0, 0);
            this.tlp_InputArchive.Controls.Add(this.txt_InputArchive, 0, 1);
            this.tlp_InputArchive.Controls.Add(this.btn_InputArchive, 1, 1);
            this.tlp_InputArchive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_InputArchive.Location = new System.Drawing.Point(3, 3);
            this.tlp_InputArchive.Name = "tlp_InputArchive";
            this.tlp_InputArchive.RowCount = 2;
            this.tlp_InputArchive.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_InputArchive.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_InputArchive.Size = new System.Drawing.Size(434, 69);
            this.tlp_InputArchive.TabIndex = 47;
            // 
            // lbl_InputArchive
            // 
            this.lbl_InputArchive.AutoSize = true;
            this.lbl_InputArchive.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_InputArchive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_InputArchive.Location = new System.Drawing.Point(3, 18);
            this.lbl_InputArchive.Name = "lbl_InputArchive";
            this.lbl_InputArchive.Size = new System.Drawing.Size(384, 16);
            this.lbl_InputArchive.TabIndex = 26;
            this.lbl_InputArchive.Text = "Input Archive File:";
            // 
            // txt_InputArchive
            // 
            this.txt_InputArchive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_InputArchive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txt_InputArchive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_InputArchive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txt_InputArchive.Location = new System.Drawing.Point(3, 40);
            this.txt_InputArchive.Name = "txt_InputArchive";
            this.txt_InputArchive.Size = new System.Drawing.Size(384, 22);
            this.txt_InputArchive.TabIndex = 27;
            this.txt_InputArchive.TextChanged += new System.EventHandler(this.ArchivePath_Changed);
            this.txt_InputArchive.DragDrop += new System.Windows.Forms.DragEventHandler(this.Txt_DragDrop);
            this.txt_InputArchive.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            // 
            // btn_InputArchive
            // 
            this.btn_InputArchive.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_InputArchive.Location = new System.Drawing.Point(393, 41);
            this.btn_InputArchive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_InputArchive.Name = "btn_InputArchive";
            this.btn_InputArchive.Padding = new System.Windows.Forms.Padding(4);
            this.btn_InputArchive.Size = new System.Drawing.Size(37, 21);
            this.btn_InputArchive.TabIndex = 28;
            this.btn_InputArchive.Text = "...";
            this.btn_InputArchive.Click += new System.EventHandler(this.InputArchive_Click);
            this.btn_InputArchive.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            // 
            // tlp_ArchiveFormat
            // 
            this.tlp_ArchiveFormat.ColumnCount = 1;
            this.tlp_ArchiveFormat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_ArchiveFormat.Controls.Add(this.dropDownList_ArchiveFormat, 0, 1);
            this.tlp_ArchiveFormat.Controls.Add(this.lbl_ArchiveFormat, 0, 0);
            this.tlp_ArchiveFormat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_ArchiveFormat.Location = new System.Drawing.Point(443, 3);
            this.tlp_ArchiveFormat.Name = "tlp_ArchiveFormat";
            this.tlp_ArchiveFormat.RowCount = 2;
            this.tlp_ArchiveFormat.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_ArchiveFormat.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_ArchiveFormat.Size = new System.Drawing.Size(222, 69);
            this.tlp_ArchiveFormat.TabIndex = 47;
            // 
            // dropDownList_ArchiveFormat
            // 
            this.dropDownList_ArchiveFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dropDownList_ArchiveFormat.Location = new System.Drawing.Point(3, 40);
            this.dropDownList_ArchiveFormat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dropDownList_ArchiveFormat.Name = "dropDownList_ArchiveFormat";
            this.dropDownList_ArchiveFormat.Size = new System.Drawing.Size(216, 22);
            this.dropDownList_ArchiveFormat.TabIndex = 36;
            this.dropDownList_ArchiveFormat.SelectedItemChanged += new System.EventHandler(this.dropDownList_Changed);
            // 
            // lbl_ArchiveFormat
            // 
            this.lbl_ArchiveFormat.AutoSize = true;
            this.lbl_ArchiveFormat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_ArchiveFormat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_ArchiveFormat.Location = new System.Drawing.Point(3, 18);
            this.lbl_ArchiveFormat.Name = "lbl_ArchiveFormat";
            this.lbl_ArchiveFormat.Size = new System.Drawing.Size(216, 16);
            this.lbl_ArchiveFormat.TabIndex = 35;
            this.lbl_ArchiveFormat.Text = "Archive Format:";
            // 
            // btn_Unpack
            // 
            this.btn_Unpack.AllowDrop = true;
            this.btn_Unpack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Unpack.Enabled = false;
            this.btn_Unpack.Location = new System.Drawing.Point(443, 78);
            this.btn_Unpack.Name = "btn_Unpack";
            this.btn_Unpack.Padding = new System.Windows.Forms.Padding(5);
            this.btn_Unpack.Size = new System.Drawing.Size(222, 69);
            this.btn_Unpack.TabIndex = 37;
            this.btn_Unpack.Text = "Unpack Archive";
            this.btn_Unpack.Click += new System.EventHandler(this.Unpack_Click);
            this.btn_Unpack.DragDrop += new System.Windows.Forms.DragEventHandler(this.Unpack_DragDrop);
            this.btn_Unpack.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            // 
            // btn_Repack
            // 
            this.btn_Repack.AllowDrop = true;
            this.btn_Repack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Repack.Enabled = false;
            this.btn_Repack.Location = new System.Drawing.Point(443, 153);
            this.btn_Repack.Name = "btn_Repack";
            this.btn_Repack.Padding = new System.Windows.Forms.Padding(5);
            this.btn_Repack.Size = new System.Drawing.Size(222, 72);
            this.btn_Repack.TabIndex = 38;
            this.btn_Repack.Text = "Repack Archive";
            this.btn_Repack.Click += new System.EventHandler(this.Repack_Click);
            this.btn_Repack.DragDrop += new System.Windows.Forms.DragEventHandler(this.Repack_DragDrop);
            this.btn_Repack.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            // 
            // rtb_Log
            // 
            this.rtb_Log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.rtb_Log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_Log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_Log.ForeColor = System.Drawing.Color.Silver;
            this.rtb_Log.Location = new System.Drawing.Point(3, 274);
            this.rtb_Log.Name = "rtb_Log";
            this.rtb_Log.ReadOnly = true;
            this.rtb_Log.Size = new System.Drawing.Size(676, 176);
            this.rtb_Log.TabIndex = 39;
            this.rtb_Log.Text = "";
            // 
            // dropDownList_Preset
            // 
            this.dropDownList_Preset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dropDownList_Preset.Location = new System.Drawing.Point(495, 8);
            this.dropDownList_Preset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dropDownList_Preset.Name = "dropDownList_Preset";
            this.dropDownList_Preset.Size = new System.Drawing.Size(175, 22);
            this.dropDownList_Preset.TabIndex = 0;
            this.dropDownList_Preset.SelectedItemChanged += new System.EventHandler(this.Preset_Changed);
            // 
            // lbl_Preset
            // 
            this.lbl_Preset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Preset.AutoSize = true;
            this.lbl_Preset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_Preset.Location = new System.Drawing.Point(443, 11);
            this.lbl_Preset.Name = "lbl_Preset";
            this.lbl_Preset.Size = new System.Drawing.Size(49, 16);
            this.lbl_Preset.TabIndex = 0;
            this.lbl_Preset.Text = "Preset:";
            // 
            // tlp_Main
            // 
            this.tlp_Main.ColumnCount = 1;
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Main.Controls.Add(this.rtb_Log, 0, 1);
            this.tlp_Main.Controls.Add(this.tabControl_Main, 0, 0);
            this.tlp_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Main.Location = new System.Drawing.Point(0, 0);
            this.tlp_Main.Name = "tlp_Main";
            this.tlp_Main.RowCount = 2;
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlp_Main.Size = new System.Drawing.Size(682, 453);
            this.tlp_Main.TabIndex = 40;
            // 
            // lbl_GitHubLink
            // 
            this.lbl_GitHubLink.ActiveLinkColor = System.Drawing.Color.Silver;
            this.lbl_GitHubLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_GitHubLink.AutoSize = true;
            this.lbl_GitHubLink.DisabledLinkColor = System.Drawing.Color.Gray;
            this.lbl_GitHubLink.LinkColor = System.Drawing.Color.Gray;
            this.lbl_GitHubLink.Location = new System.Drawing.Point(352, 11);
            this.lbl_GitHubLink.Name = "lbl_GitHubLink";
            this.lbl_GitHubLink.Size = new System.Drawing.Size(85, 16);
            this.lbl_GitHubLink.TabIndex = 41;
            this.lbl_GitHubLink.TabStop = true;
            this.lbl_GitHubLink.Text = "GitHub Repo";
            this.lbl_GitHubLink.VisitedLinkColor = System.Drawing.Color.Gray;
            this.lbl_GitHubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_Click);
            // 
            // PersonaVCEForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.lbl_GitHubLink);
            this.Controls.Add(this.lbl_Preset);
            this.Controls.Add(this.dropDownList_Preset);
            this.Controls.Add(this.tlp_Main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "PersonaVCEForm";
            this.Text = "PersonaVCE v2.0";
            this.tabControl_Main.ResumeLayout(false);
            this.tabPage_Encoding.ResumeLayout(false);
            this.tlp_Encoding.ResumeLayout(false);
            this.tlp_OutFormat.ResumeLayout(false);
            this.tlp_OutFormat.PerformLayout();
            this.tlp_OutputDir.ResumeLayout(false);
            this.tlp_OutputDir.PerformLayout();
            this.tlp_InputDir.ResumeLayout(false);
            this.tlp_InputDir.PerformLayout();
            this.tlp_Loop.ResumeLayout(false);
            this.tlp_Loop.PerformLayout();
            this.tlp_LoopEnd.ResumeLayout(false);
            this.tlp_LoopEnd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_LoopEnd)).EndInit();
            this.tlp_LoopStart.ResumeLayout(false);
            this.tlp_LoopStart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_LoopStart)).EndInit();
            this.tlp_UseKey.ResumeLayout(false);
            this.tlp_UseKey.PerformLayout();
            this.tabPage_Renaming.ResumeLayout(false);
            this.tlp_Renaming.ResumeLayout(false);
            this.tlp_RenameOutput.ResumeLayout(false);
            this.tlp_RenameOutput.PerformLayout();
            this.tlp_RenameDir.ResumeLayout(false);
            this.tlp_RenameDir.PerformLayout();
            this.tlp_Key.ResumeLayout(false);
            this.tlp_Key.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_StartIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Padding)).EndInit();
            this.tlp_Suffix.ResumeLayout(false);
            this.tlp_Suffix.PerformLayout();
            this.tlp_TxtFile.ResumeLayout(false);
            this.tlp_TxtFile.PerformLayout();
            this.tabPage_Archives.ResumeLayout(false);
            this.tlp_Archives.ResumeLayout(false);
            this.tlp_OutputArchive.ResumeLayout(false);
            this.tlp_OutputArchive.PerformLayout();
            this.tlp_ArchiveDir.ResumeLayout(false);
            this.tlp_ArchiveDir.PerformLayout();
            this.tlp_InputArchive.ResumeLayout(false);
            this.tlp_InputArchive.PerformLayout();
            this.tlp_ArchiveFormat.ResumeLayout(false);
            this.tlp_ArchiveFormat.PerformLayout();
            this.tlp_Main.ResumeLayout(false);
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
        private DarkUI.Controls.DarkDropdownList dropDownList_OutFormat;
        private GrayIris.Utilities.UI.Controls.YaTabControl tabControl_Main;
        private GrayIris.Utilities.UI.Controls.YaTabPage tabPage_Encoding;
        private GrayIris.Utilities.UI.Controls.YaTabPage tabPage_Renaming;
        private DarkUI.Controls.DarkButton btn_Rename;
        private DarkUI.Controls.DarkButton btn_RenameDir;
        private DarkUI.Controls.DarkTextBox txt_RenameDir;
        private DarkUI.Controls.DarkLabel lbl_RenameDir;
        private GrayIris.Utilities.UI.Controls.YaTabPage tabPage_Archives;
        private DarkUI.Controls.DarkButton btn_RenameOutput;
        private DarkUI.Controls.DarkLabel lbl_RenameOutput;
        private DarkUI.Controls.DarkTextBox txt_RenameOutput;
        private System.Windows.Forms.RichTextBox rtb_Log;
        private DarkUI.Controls.DarkLabel lbl_ArchiveFormat;
        private DarkUI.Controls.DarkDropdownList dropDownList_ArchiveFormat;
        private DarkUI.Controls.DarkLabel lbl_Padding;
        private DarkUI.Controls.DarkNumericUpDown num_Padding;
        private DarkUI.Controls.DarkDropdownList dropDownList_Preset;
        private DarkUI.Controls.DarkLabel lbl_Preset;
        private DarkUI.Controls.DarkCheckBox chk_AppendFilename;
        private DarkUI.Controls.DarkNumericUpDown num_StartIndex;
        private DarkUI.Controls.DarkLabel lbl_StartIndex;
        private System.Windows.Forms.TableLayoutPanel tlp_Main;
        private System.Windows.Forms.TableLayoutPanel tlp_Encoding;
        private System.Windows.Forms.TableLayoutPanel tlp_Renaming;
        private System.Windows.Forms.TableLayoutPanel tlp_Archives;
        private System.Windows.Forms.TableLayoutPanel tlp_InputDir;
        private System.Windows.Forms.TableLayoutPanel tlp_OutputDir;
        private System.Windows.Forms.TableLayoutPanel tlp_OutFormat;
        private System.Windows.Forms.TableLayoutPanel tlp_OutputArchive;
        private System.Windows.Forms.TableLayoutPanel tlp_UseKey;
        private System.Windows.Forms.TableLayoutPanel tlp_Suffix;
        private System.Windows.Forms.TableLayoutPanel tlp_TxtFile;
        private System.Windows.Forms.TableLayoutPanel tlp_RenameOutput;
        private System.Windows.Forms.TableLayoutPanel tlp_RenameDir;
        private System.Windows.Forms.TableLayoutPanel tlp_Key;
        private System.Windows.Forms.TableLayoutPanel tlp_InputArchive;
        private System.Windows.Forms.TableLayoutPanel tlp_ArchiveFormat;
        private System.Windows.Forms.TableLayoutPanel tlp_ArchiveDir;
        private System.Windows.Forms.TableLayoutPanel tlp_Loop;
        private System.Windows.Forms.TableLayoutPanel tlp_LoopEnd;
        private DarkUI.Controls.DarkNumericUpDown num_LoopEnd;
        private DarkUI.Controls.DarkLabel lbl_LoopEnd;
        private DarkUI.Controls.DarkCheckBox chk_UseLoops;
        private DarkUI.Controls.DarkCheckBox chk_LoopAll;
        private System.Windows.Forms.TableLayoutPanel tlp_LoopStart;
        private DarkUI.Controls.DarkNumericUpDown num_LoopStart;
        private DarkUI.Controls.DarkLabel lbl_LoopStart;
        private System.Windows.Forms.LinkLabel lbl_GitHubLink;
    }
}