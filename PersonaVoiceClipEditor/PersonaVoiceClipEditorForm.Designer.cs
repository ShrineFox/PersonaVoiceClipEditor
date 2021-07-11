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
            this.btn_ExtractAFS = new DarkUI.Controls.DarkButton();
            this.btn_RepackAFS = new DarkUI.Controls.DarkButton();
            this.btn_RepackCSB = new DarkUI.Controls.DarkButton();
            this.btn_ExtractCSB = new DarkUI.Controls.DarkButton();
            this.lbl_AFS = new DarkUI.Controls.DarkLabel();
            this.lbl_ACBPath = new DarkUI.Controls.DarkLabel();
            this.lbl_SourceWavFolder = new DarkUI.Controls.DarkLabel();
            this.lbl_ReplacementFolder = new DarkUI.Controls.DarkLabel();
            this.lbl_Txt = new DarkUI.Controls.DarkLabel();
            this.btn_Replace = new DarkUI.Controls.DarkButton();
            this.textBox_SourceWavFolder = new DarkUI.Controls.DarkTextBox();
            this.textBox_ReplaceAdxFolder = new DarkUI.Controls.DarkTextBox();
            this.textBox_Txt = new DarkUI.Controls.DarkTextBox();
            this.darkGroupBox_Replacement = new DarkUI.Controls.DarkGroupBox();
            this.darkLabel1 = new DarkUI.Controls.DarkLabel();
            this.darkNumericUpDown1 = new DarkUI.Controls.DarkNumericUpDown();
            this.linkLabel_Help = new System.Windows.Forms.LinkLabel();
            this.darkTextBox_ACBPath = new DarkUI.Controls.DarkTextBox();
            this.darkTextBox_AFSPath = new DarkUI.Controls.DarkTextBox();
            this.lbl_Status = new DarkUI.Controls.DarkLabel();
            this.darkGroupBox_Replacement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.darkNumericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ExtractAFS
            // 
            this.btn_ExtractAFS.AllowDrop = true;
            this.btn_ExtractAFS.Location = new System.Drawing.Point(258, 29);
            this.btn_ExtractAFS.Name = "btn_ExtractAFS";
            this.btn_ExtractAFS.Padding = new System.Windows.Forms.Padding(5);
            this.btn_ExtractAFS.Size = new System.Drawing.Size(80, 40);
            this.btn_ExtractAFS.TabIndex = 4;
            this.btn_ExtractAFS.Text = "Extract";
            this.btn_ExtractAFS.Click += new System.EventHandler(this.AFSExtract_Click);
            this.btn_ExtractAFS.DragDrop += new System.Windows.Forms.DragEventHandler(this.ExtractAFS_DragDrop);
            this.btn_ExtractAFS.DragEnter += new System.Windows.Forms.DragEventHandler(this.ExtractAFS_DragEnter);
            // 
            // btn_RepackAFS
            // 
            this.btn_RepackAFS.AllowDrop = true;
            this.btn_RepackAFS.Location = new System.Drawing.Point(346, 29);
            this.btn_RepackAFS.Name = "btn_RepackAFS";
            this.btn_RepackAFS.Padding = new System.Windows.Forms.Padding(5);
            this.btn_RepackAFS.Size = new System.Drawing.Size(80, 40);
            this.btn_RepackAFS.TabIndex = 5;
            this.btn_RepackAFS.Text = "Repack";
            this.btn_RepackAFS.Click += new System.EventHandler(this.AFSRepack_Click);
            this.btn_RepackAFS.DragDrop += new System.Windows.Forms.DragEventHandler(this.RepackAFS_DragDrop);
            this.btn_RepackAFS.DragEnter += new System.Windows.Forms.DragEventHandler(this.RepackAFS_DragEnter);
            // 
            // btn_RepackCSB
            // 
            this.btn_RepackCSB.AllowDrop = true;
            this.btn_RepackCSB.Location = new System.Drawing.Point(346, 78);
            this.btn_RepackCSB.Name = "btn_RepackCSB";
            this.btn_RepackCSB.Padding = new System.Windows.Forms.Padding(5);
            this.btn_RepackCSB.Size = new System.Drawing.Size(80, 40);
            this.btn_RepackCSB.TabIndex = 7;
            this.btn_RepackCSB.Text = "Repack";
            this.btn_RepackCSB.Click += new System.EventHandler(this.ACBRepack_Click);
            this.btn_RepackCSB.DragDrop += new System.Windows.Forms.DragEventHandler(this.RepackACB_DragDrop);
            this.btn_RepackCSB.DragEnter += new System.Windows.Forms.DragEventHandler(this.RepackACB_DragEnter);
            // 
            // btn_ExtractCSB
            // 
            this.btn_ExtractCSB.AllowDrop = true;
            this.btn_ExtractCSB.Location = new System.Drawing.Point(258, 78);
            this.btn_ExtractCSB.Name = "btn_ExtractCSB";
            this.btn_ExtractCSB.Padding = new System.Windows.Forms.Padding(5);
            this.btn_ExtractCSB.Size = new System.Drawing.Size(80, 40);
            this.btn_ExtractCSB.TabIndex = 6;
            this.btn_ExtractCSB.Text = "Extract";
            this.btn_ExtractCSB.Click += new System.EventHandler(this.ACBExtract_Click);
            this.btn_ExtractCSB.DragDrop += new System.Windows.Forms.DragEventHandler(this.ExtractACB_DragDrop);
            this.btn_ExtractCSB.DragEnter += new System.Windows.Forms.DragEventHandler(this.ExtractACB_DragEnter);
            // 
            // lbl_AFS
            // 
            this.lbl_AFS.AutoSize = true;
            this.lbl_AFS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_AFS.Location = new System.Drawing.Point(12, 19);
            this.lbl_AFS.Name = "lbl_AFS";
            this.lbl_AFS.Size = new System.Drawing.Size(71, 17);
            this.lbl_AFS.TabIndex = 0;
            this.lbl_AFS.Text = "AFS Path:";
            // 
            // lbl_ACBPath
            // 
            this.lbl_ACBPath.AutoSize = true;
            this.lbl_ACBPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_ACBPath.Location = new System.Drawing.Point(12, 68);
            this.lbl_ACBPath.Name = "lbl_ACBPath";
            this.lbl_ACBPath.Size = new System.Drawing.Size(72, 17);
            this.lbl_ACBPath.TabIndex = 2;
            this.lbl_ACBPath.Text = "ACB Path:";
            // 
            // lbl_SourceWavFolder
            // 
            this.lbl_SourceWavFolder.AutoSize = true;
            this.lbl_SourceWavFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_SourceWavFolder.Location = new System.Drawing.Point(6, 18);
            this.lbl_SourceWavFolder.Name = "lbl_SourceWavFolder";
            this.lbl_SourceWavFolder.Size = new System.Drawing.Size(140, 17);
            this.lbl_SourceWavFolder.TabIndex = 10;
            this.lbl_SourceWavFolder.Text = "Source .WAV Folder:";
            // 
            // lbl_ReplacementFolder
            // 
            this.lbl_ReplacementFolder.AutoSize = true;
            this.lbl_ReplacementFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_ReplacementFolder.Location = new System.Drawing.Point(6, 63);
            this.lbl_ReplacementFolder.Name = "lbl_ReplacementFolder";
            this.lbl_ReplacementFolder.Size = new System.Drawing.Size(151, 17);
            this.lbl_ReplacementFolder.TabIndex = 13;
            this.lbl_ReplacementFolder.Text = "Extracted .ADX Folder:";
            // 
            // lbl_Txt
            // 
            this.lbl_Txt.AutoSize = true;
            this.lbl_Txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_Txt.Location = new System.Drawing.Point(6, 109);
            this.lbl_Txt.Name = "lbl_Txt";
            this.lbl_Txt.Size = new System.Drawing.Size(250, 17);
            this.lbl_Txt.TabIndex = 15;
            this.lbl_Txt.Text = ".TXT file with ordered .WAV filenames:";
            // 
            // btn_Replace
            // 
            this.btn_Replace.AllowDrop = true;
            this.btn_Replace.Location = new System.Drawing.Point(273, 38);
            this.btn_Replace.Name = "btn_Replace";
            this.btn_Replace.Padding = new System.Windows.Forms.Padding(5);
            this.btn_Replace.Size = new System.Drawing.Size(139, 144);
            this.btn_Replace.TabIndex = 17;
            this.btn_Replace.Text = "Replace";
            this.btn_Replace.Click += new System.EventHandler(this.Replace_Click);
            // 
            // textBox_SourceWavFolder
            // 
            this.textBox_SourceWavFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.textBox_SourceWavFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_SourceWavFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.textBox_SourceWavFolder.Location = new System.Drawing.Point(6, 38);
            this.textBox_SourceWavFolder.Name = "textBox_SourceWavFolder";
            this.textBox_SourceWavFolder.ReadOnly = true;
            this.textBox_SourceWavFolder.Size = new System.Drawing.Size(257, 22);
            this.textBox_SourceWavFolder.TabIndex = 12;
            this.textBox_SourceWavFolder.Click += new System.EventHandler(this.SourceWAV_Click);
            // 
            // textBox_ReplaceAdxFolder
            // 
            this.textBox_ReplaceAdxFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.textBox_ReplaceAdxFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_ReplaceAdxFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.textBox_ReplaceAdxFolder.Location = new System.Drawing.Point(6, 84);
            this.textBox_ReplaceAdxFolder.Name = "textBox_ReplaceAdxFolder";
            this.textBox_ReplaceAdxFolder.ReadOnly = true;
            this.textBox_ReplaceAdxFolder.Size = new System.Drawing.Size(257, 22);
            this.textBox_ReplaceAdxFolder.TabIndex = 14;
            this.textBox_ReplaceAdxFolder.Click += new System.EventHandler(this.ReplaceAdxFolder_Click);
            // 
            // textBox_Txt
            // 
            this.textBox_Txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.textBox_Txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.textBox_Txt.Location = new System.Drawing.Point(6, 129);
            this.textBox_Txt.Name = "textBox_Txt";
            this.textBox_Txt.ReadOnly = true;
            this.textBox_Txt.Size = new System.Drawing.Size(257, 22);
            this.textBox_Txt.TabIndex = 16;
            this.textBox_Txt.Click += new System.EventHandler(this.Txt_Click);
            // 
            // darkGroupBox_Replacement
            // 
            this.darkGroupBox_Replacement.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.darkGroupBox_Replacement.Controls.Add(this.darkLabel1);
            this.darkGroupBox_Replacement.Controls.Add(this.darkNumericUpDown1);
            this.darkGroupBox_Replacement.Controls.Add(this.linkLabel_Help);
            this.darkGroupBox_Replacement.Controls.Add(this.textBox_SourceWavFolder);
            this.darkGroupBox_Replacement.Controls.Add(this.textBox_Txt);
            this.darkGroupBox_Replacement.Controls.Add(this.lbl_SourceWavFolder);
            this.darkGroupBox_Replacement.Controls.Add(this.textBox_ReplaceAdxFolder);
            this.darkGroupBox_Replacement.Controls.Add(this.lbl_ReplacementFolder);
            this.darkGroupBox_Replacement.Controls.Add(this.lbl_Txt);
            this.darkGroupBox_Replacement.Controls.Add(this.btn_Replace);
            this.darkGroupBox_Replacement.ForeColor = System.Drawing.Color.White;
            this.darkGroupBox_Replacement.Location = new System.Drawing.Point(12, 133);
            this.darkGroupBox_Replacement.Name = "darkGroupBox_Replacement";
            this.darkGroupBox_Replacement.Size = new System.Drawing.Size(414, 197);
            this.darkGroupBox_Replacement.TabIndex = 9;
            this.darkGroupBox_Replacement.TabStop = false;
            this.darkGroupBox_Replacement.Text = "Replacement by Filename Order";
            // 
            // darkLabel1
            // 
            this.darkLabel1.AutoSize = true;
            this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel1.Location = new System.Drawing.Point(6, 162);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(95, 17);
            this.darkLabel1.TabIndex = 19;
            this.darkLabel1.Text = "Start at Index:";
            // 
            // darkNumericUpDown1
            // 
            this.darkNumericUpDown1.Location = new System.Drawing.Point(107, 160);
            this.darkNumericUpDown1.Name = "darkNumericUpDown1";
            this.darkNumericUpDown1.Size = new System.Drawing.Size(55, 22);
            this.darkNumericUpDown1.TabIndex = 18;
            // 
            // linkLabel_Help
            // 
            this.linkLabel_Help.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLabel_Help.AutoSize = true;
            this.linkLabel_Help.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel_Help.LinkColor = System.Drawing.Color.White;
            this.linkLabel_Help.Location = new System.Drawing.Point(328, 18);
            this.linkLabel_Help.Name = "linkLabel_Help";
            this.linkLabel_Help.Size = new System.Drawing.Size(80, 17);
            this.linkLabel_Help.TabIndex = 11;
            this.linkLabel_Help.TabStop = true;
            this.linkLabel_Help.Text = "How to Use";
            this.linkLabel_Help.VisitedLinkColor = System.Drawing.Color.White;
            this.linkLabel_Help.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Help_LinkClicked);
            // 
            // darkTextBox_ACBPath
            // 
            this.darkTextBox_ACBPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.darkTextBox_ACBPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.darkTextBox_ACBPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkTextBox_ACBPath.Location = new System.Drawing.Point(12, 88);
            this.darkTextBox_ACBPath.Name = "darkTextBox_ACBPath";
            this.darkTextBox_ACBPath.ReadOnly = true;
            this.darkTextBox_ACBPath.Size = new System.Drawing.Size(237, 22);
            this.darkTextBox_ACBPath.TabIndex = 3;
            this.darkTextBox_ACBPath.Click += new System.EventHandler(this.ACBPath_Click);
            // 
            // darkTextBox_AFSPath
            // 
            this.darkTextBox_AFSPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.darkTextBox_AFSPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.darkTextBox_AFSPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkTextBox_AFSPath.Location = new System.Drawing.Point(12, 39);
            this.darkTextBox_AFSPath.Name = "darkTextBox_AFSPath";
            this.darkTextBox_AFSPath.ReadOnly = true;
            this.darkTextBox_AFSPath.Size = new System.Drawing.Size(237, 22);
            this.darkTextBox_AFSPath.TabIndex = 1;
            this.darkTextBox_AFSPath.Click += new System.EventHandler(this.AFSPath_Click);
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_Status.Location = new System.Drawing.Point(377, 335);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(49, 17);
            this.lbl_Status.TabIndex = 20;
            this.lbl_Status.Text = "Ready";
            this.lbl_Status.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // PersonaVoiceClipEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(440, 361);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.darkTextBox_AFSPath);
            this.Controls.Add(this.darkTextBox_ACBPath);
            this.Controls.Add(this.darkGroupBox_Replacement);
            this.Controls.Add(this.lbl_ACBPath);
            this.Controls.Add(this.lbl_AFS);
            this.Controls.Add(this.btn_RepackCSB);
            this.Controls.Add(this.btn_ExtractCSB);
            this.Controls.Add(this.btn_RepackAFS);
            this.Controls.Add(this.btn_ExtractAFS);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(450, 400);
            this.MinimumSize = new System.Drawing.Size(450, 400);
            this.Name = "PersonaVoiceClipEditorForm";
            this.Text = "Persona Voice Clip Editor v0.2";
            this.darkGroupBox_Replacement.ResumeLayout(false);
            this.darkGroupBox_Replacement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.darkNumericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DarkUI.Controls.DarkButton btn_ExtractAFS;
        private DarkUI.Controls.DarkButton btn_RepackAFS;
        private DarkUI.Controls.DarkButton btn_RepackCSB;
        private DarkUI.Controls.DarkButton btn_ExtractCSB;
        private DarkUI.Controls.DarkLabel lbl_AFS;
        private DarkUI.Controls.DarkLabel lbl_ACBPath;
        private DarkUI.Controls.DarkLabel lbl_SourceWavFolder;
        private DarkUI.Controls.DarkLabel lbl_ReplacementFolder;
        private DarkUI.Controls.DarkLabel lbl_Txt;
        private DarkUI.Controls.DarkButton btn_Replace;
        private DarkUI.Controls.DarkTextBox textBox_SourceWavFolder;
        private DarkUI.Controls.DarkTextBox textBox_ReplaceAdxFolder;
        private DarkUI.Controls.DarkTextBox textBox_Txt;
        private DarkUI.Controls.DarkGroupBox darkGroupBox_Replacement;
        private System.Windows.Forms.LinkLabel linkLabel_Help;
        private DarkUI.Controls.DarkTextBox darkTextBox_ACBPath;
        private DarkUI.Controls.DarkTextBox darkTextBox_AFSPath;
        private DarkUI.Controls.DarkLabel darkLabel1;
        private DarkUI.Controls.DarkNumericUpDown darkNumericUpDown1;
        private DarkUI.Controls.DarkLabel lbl_Status;
    }
}