namespace SwissFile.GUI
{
    partial class SwissFileGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SwissFileGUI));
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabCopy = new System.Windows.Forms.TabPage();
            this.chk_Copy_CloseOnSuccess = new System.Windows.Forms.CheckBox();
            this.chk_Copy_OverwriteDest = new System.Windows.Forms.CheckBox();
            this.chk_Copy_DeletSrcAfterCopy = new System.Windows.Forms.CheckBox();
            this.btn_Copy_Start = new System.Windows.Forms.Button();
            this.txt_Copy_FnOverride = new System.Windows.Forms.TextBox();
            this.lbl_Copy_FnOverride = new System.Windows.Forms.Label();
            this.btn_Copy_SelectDestFolder = new System.Windows.Forms.Button();
            this.txt_Copy_DestFolder = new System.Windows.Forms.TextBox();
            this.lbl_Copy_DestFolder = new System.Windows.Forms.Label();
            this.btn_Copy_SelectSrcFile = new System.Windows.Forms.Button();
            this.lbl_Copy_SrcFile = new System.Windows.Forms.Label();
            this.txt_Copy_SrcFile = new System.Windows.Forms.TextBox();
            this.tabSplit = new System.Windows.Forms.TabPage();
            this.lbl_Split_MaxBytes = new System.Windows.Forms.Label();
            this.num_Split_MaxBytes = new System.Windows.Forms.NumericUpDown();
            this.btn_Split_SelectDestFolder = new System.Windows.Forms.Button();
            this.txt_Split_DestFolder = new System.Windows.Forms.TextBox();
            this.lbl_Split_DestFolder = new System.Windows.Forms.Label();
            this.btn_Split_SelectSrcFile = new System.Windows.Forms.Button();
            this.lbl_Split_SrcFile = new System.Windows.Forms.Label();
            this.txt_Split_SrcFile = new System.Windows.Forms.TextBox();
            this.chk_Split_PreserveTextLines = new System.Windows.Forms.CheckBox();
            this.txt_Split_ExtOverride = new System.Windows.Forms.TextBox();
            this.lbl_Split_ExtOverride = new System.Windows.Forms.Label();
            this.btn_Split_Start = new System.Windows.Forms.Button();
            this.tabs.SuspendLayout();
            this.tabCopy.SuspendLayout();
            this.tabSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Split_MaxBytes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabs.Controls.Add(this.tabCopy);
            this.tabs.Controls.Add(this.tabSplit);
            this.tabs.Location = new System.Drawing.Point(12, 12);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(460, 142);
            this.tabs.TabIndex = 0;
            // 
            // tabCopy
            // 
            this.tabCopy.BackColor = System.Drawing.SystemColors.Control;
            this.tabCopy.Controls.Add(this.chk_Copy_CloseOnSuccess);
            this.tabCopy.Controls.Add(this.chk_Copy_OverwriteDest);
            this.tabCopy.Controls.Add(this.chk_Copy_DeletSrcAfterCopy);
            this.tabCopy.Controls.Add(this.btn_Copy_Start);
            this.tabCopy.Controls.Add(this.txt_Copy_FnOverride);
            this.tabCopy.Controls.Add(this.lbl_Copy_FnOverride);
            this.tabCopy.Controls.Add(this.btn_Copy_SelectDestFolder);
            this.tabCopy.Controls.Add(this.txt_Copy_DestFolder);
            this.tabCopy.Controls.Add(this.lbl_Copy_DestFolder);
            this.tabCopy.Controls.Add(this.btn_Copy_SelectSrcFile);
            this.tabCopy.Controls.Add(this.lbl_Copy_SrcFile);
            this.tabCopy.Controls.Add(this.txt_Copy_SrcFile);
            this.tabCopy.Location = new System.Drawing.Point(4, 22);
            this.tabCopy.Name = "tabCopy";
            this.tabCopy.Padding = new System.Windows.Forms.Padding(3);
            this.tabCopy.Size = new System.Drawing.Size(452, 116);
            this.tabCopy.TabIndex = 0;
            this.tabCopy.Text = "Copy File";
            // 
            // chk_Copy_CloseOnSuccess
            // 
            this.chk_Copy_CloseOnSuccess.AutoSize = true;
            this.chk_Copy_CloseOnSuccess.Location = new System.Drawing.Point(234, 88);
            this.chk_Copy_CloseOnSuccess.Name = "chk_Copy_CloseOnSuccess";
            this.chk_Copy_CloseOnSuccess.Size = new System.Drawing.Size(111, 17);
            this.chk_Copy_CloseOnSuccess.TabIndex = 11;
            this.chk_Copy_CloseOnSuccess.Text = "Close on Success";
            this.chk_Copy_CloseOnSuccess.UseVisualStyleBackColor = true;
            // 
            // chk_Copy_OverwriteDest
            // 
            this.chk_Copy_OverwriteDest.AutoSize = true;
            this.chk_Copy_OverwriteDest.Location = new System.Drawing.Point(157, 88);
            this.chk_Copy_OverwriteDest.Name = "chk_Copy_OverwriteDest";
            this.chk_Copy_OverwriteDest.Size = new System.Drawing.Size(71, 17);
            this.chk_Copy_OverwriteDest.TabIndex = 10;
            this.chk_Copy_OverwriteDest.Text = "Overwrite";
            this.chk_Copy_OverwriteDest.UseVisualStyleBackColor = true;
            // 
            // chk_Copy_DeletSrcAfterCopy
            // 
            this.chk_Copy_DeletSrcAfterCopy.AutoSize = true;
            this.chk_Copy_DeletSrcAfterCopy.Location = new System.Drawing.Point(9, 88);
            this.chk_Copy_DeletSrcAfterCopy.Name = "chk_Copy_DeletSrcAfterCopy";
            this.chk_Copy_DeletSrcAfterCopy.Size = new System.Drawing.Size(142, 17);
            this.chk_Copy_DeletSrcAfterCopy.TabIndex = 9;
            this.chk_Copy_DeletSrcAfterCopy.Text = "Delete source after copy";
            this.chk_Copy_DeletSrcAfterCopy.UseVisualStyleBackColor = true;
            // 
            // btn_Copy_Start
            // 
            this.btn_Copy_Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Copy_Start.Location = new System.Drawing.Point(371, 84);
            this.btn_Copy_Start.Name = "btn_Copy_Start";
            this.btn_Copy_Start.Size = new System.Drawing.Size(75, 23);
            this.btn_Copy_Start.TabIndex = 8;
            this.btn_Copy_Start.Text = "Start";
            this.btn_Copy_Start.UseVisualStyleBackColor = true;
            this.btn_Copy_Start.Click += new System.EventHandler(this.btn_Copy_Start_Click);
            // 
            // txt_Copy_FnOverride
            // 
            this.txt_Copy_FnOverride.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Copy_FnOverride.Location = new System.Drawing.Point(72, 58);
            this.txt_Copy_FnOverride.Name = "txt_Copy_FnOverride";
            this.txt_Copy_FnOverride.Size = new System.Drawing.Size(374, 20);
            this.txt_Copy_FnOverride.TabIndex = 7;
            // 
            // lbl_Copy_FnOverride
            // 
            this.lbl_Copy_FnOverride.AutoSize = true;
            this.lbl_Copy_FnOverride.Location = new System.Drawing.Point(6, 61);
            this.lbl_Copy_FnOverride.Name = "lbl_Copy_FnOverride";
            this.lbl_Copy_FnOverride.Size = new System.Drawing.Size(60, 13);
            this.lbl_Copy_FnOverride.TabIndex = 6;
            this.lbl_Copy_FnOverride.Text = "Fn override";
            // 
            // btn_Copy_SelectDestFolder
            // 
            this.btn_Copy_SelectDestFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Copy_SelectDestFolder.Location = new System.Drawing.Point(412, 30);
            this.btn_Copy_SelectDestFolder.Name = "btn_Copy_SelectDestFolder";
            this.btn_Copy_SelectDestFolder.Size = new System.Drawing.Size(34, 23);
            this.btn_Copy_SelectDestFolder.TabIndex = 5;
            this.btn_Copy_SelectDestFolder.Text = "...";
            this.btn_Copy_SelectDestFolder.UseVisualStyleBackColor = true;
            this.btn_Copy_SelectDestFolder.Click += new System.EventHandler(this.btn_Copy_DestFolder_Click);
            // 
            // txt_Copy_DestFolder
            // 
            this.txt_Copy_DestFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Copy_DestFolder.Location = new System.Drawing.Point(72, 32);
            this.txt_Copy_DestFolder.Name = "txt_Copy_DestFolder";
            this.txt_Copy_DestFolder.Size = new System.Drawing.Size(334, 20);
            this.txt_Copy_DestFolder.TabIndex = 4;
            // 
            // lbl_Copy_DestFolder
            // 
            this.lbl_Copy_DestFolder.AutoSize = true;
            this.lbl_Copy_DestFolder.Location = new System.Drawing.Point(6, 35);
            this.lbl_Copy_DestFolder.Name = "lbl_Copy_DestFolder";
            this.lbl_Copy_DestFolder.Size = new System.Drawing.Size(58, 13);
            this.lbl_Copy_DestFolder.TabIndex = 3;
            this.lbl_Copy_DestFolder.Text = "Dest folder";
            // 
            // btn_Copy_SelectSrcFile
            // 
            this.btn_Copy_SelectSrcFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Copy_SelectSrcFile.Location = new System.Drawing.Point(412, 4);
            this.btn_Copy_SelectSrcFile.Name = "btn_Copy_SelectSrcFile";
            this.btn_Copy_SelectSrcFile.Size = new System.Drawing.Size(34, 23);
            this.btn_Copy_SelectSrcFile.TabIndex = 2;
            this.btn_Copy_SelectSrcFile.Text = "...";
            this.btn_Copy_SelectSrcFile.UseVisualStyleBackColor = true;
            this.btn_Copy_SelectSrcFile.Click += new System.EventHandler(this.btn_Copy_SrcFile_Click);
            // 
            // lbl_Copy_SrcFile
            // 
            this.lbl_Copy_SrcFile.AutoSize = true;
            this.lbl_Copy_SrcFile.Location = new System.Drawing.Point(6, 9);
            this.lbl_Copy_SrcFile.Name = "lbl_Copy_SrcFile";
            this.lbl_Copy_SrcFile.Size = new System.Drawing.Size(57, 13);
            this.lbl_Copy_SrcFile.TabIndex = 1;
            this.lbl_Copy_SrcFile.Text = "Source file";
            // 
            // txt_Copy_SrcFile
            // 
            this.txt_Copy_SrcFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Copy_SrcFile.Location = new System.Drawing.Point(72, 6);
            this.txt_Copy_SrcFile.Name = "txt_Copy_SrcFile";
            this.txt_Copy_SrcFile.Size = new System.Drawing.Size(334, 20);
            this.txt_Copy_SrcFile.TabIndex = 0;
            // 
            // tabSplit
            // 
            this.tabSplit.BackColor = System.Drawing.SystemColors.Control;
            this.tabSplit.Controls.Add(this.btn_Split_Start);
            this.tabSplit.Controls.Add(this.lbl_Split_ExtOverride);
            this.tabSplit.Controls.Add(this.txt_Split_ExtOverride);
            this.tabSplit.Controls.Add(this.chk_Split_PreserveTextLines);
            this.tabSplit.Controls.Add(this.lbl_Split_MaxBytes);
            this.tabSplit.Controls.Add(this.num_Split_MaxBytes);
            this.tabSplit.Controls.Add(this.btn_Split_SelectDestFolder);
            this.tabSplit.Controls.Add(this.txt_Split_DestFolder);
            this.tabSplit.Controls.Add(this.lbl_Split_DestFolder);
            this.tabSplit.Controls.Add(this.btn_Split_SelectSrcFile);
            this.tabSplit.Controls.Add(this.lbl_Split_SrcFile);
            this.tabSplit.Controls.Add(this.txt_Split_SrcFile);
            this.tabSplit.Location = new System.Drawing.Point(4, 22);
            this.tabSplit.Name = "tabSplit";
            this.tabSplit.Padding = new System.Windows.Forms.Padding(3);
            this.tabSplit.Size = new System.Drawing.Size(452, 116);
            this.tabSplit.TabIndex = 1;
            this.tabSplit.Text = "Split File";
            // 
            // lbl_Split_MaxBytes
            // 
            this.lbl_Split_MaxBytes.AutoSize = true;
            this.lbl_Split_MaxBytes.Location = new System.Drawing.Point(158, 61);
            this.lbl_Split_MaxBytes.Name = "lbl_Split_MaxBytes";
            this.lbl_Split_MaxBytes.Size = new System.Drawing.Size(59, 13);
            this.lbl_Split_MaxBytes.TabIndex = 13;
            this.lbl_Split_MaxBytes.Text = "Chunk size";
            // 
            // num_Split_MaxBytes
            // 
            this.num_Split_MaxBytes.Location = new System.Drawing.Point(223, 59);
            this.num_Split_MaxBytes.Maximum = new decimal(new int[] {
            1073741824,
            0,
            0,
            0});
            this.num_Split_MaxBytes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Split_MaxBytes.Name = "num_Split_MaxBytes";
            this.num_Split_MaxBytes.Size = new System.Drawing.Size(125, 20);
            this.num_Split_MaxBytes.TabIndex = 12;
            this.num_Split_MaxBytes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.num_Split_MaxBytes.ThousandsSeparator = true;
            this.num_Split_MaxBytes.Value = new decimal(new int[] {
            1048576,
            0,
            0,
            0});
            // 
            // btn_Split_SelectDestFolder
            // 
            this.btn_Split_SelectDestFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Split_SelectDestFolder.Location = new System.Drawing.Point(412, 30);
            this.btn_Split_SelectDestFolder.Name = "btn_Split_SelectDestFolder";
            this.btn_Split_SelectDestFolder.Size = new System.Drawing.Size(34, 23);
            this.btn_Split_SelectDestFolder.TabIndex = 11;
            this.btn_Split_SelectDestFolder.Text = "...";
            this.btn_Split_SelectDestFolder.UseVisualStyleBackColor = true;
            this.btn_Split_SelectDestFolder.Click += new System.EventHandler(this.btn_Split_SelectDestFolder_Click);
            // 
            // txt_Split_DestFolder
            // 
            this.txt_Split_DestFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Split_DestFolder.Location = new System.Drawing.Point(72, 32);
            this.txt_Split_DestFolder.Name = "txt_Split_DestFolder";
            this.txt_Split_DestFolder.Size = new System.Drawing.Size(334, 20);
            this.txt_Split_DestFolder.TabIndex = 10;
            // 
            // lbl_Split_DestFolder
            // 
            this.lbl_Split_DestFolder.AutoSize = true;
            this.lbl_Split_DestFolder.Location = new System.Drawing.Point(6, 35);
            this.lbl_Split_DestFolder.Name = "lbl_Split_DestFolder";
            this.lbl_Split_DestFolder.Size = new System.Drawing.Size(58, 13);
            this.lbl_Split_DestFolder.TabIndex = 9;
            this.lbl_Split_DestFolder.Text = "Dest folder";
            // 
            // btn_Split_SelectSrcFile
            // 
            this.btn_Split_SelectSrcFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Split_SelectSrcFile.Location = new System.Drawing.Point(412, 4);
            this.btn_Split_SelectSrcFile.Name = "btn_Split_SelectSrcFile";
            this.btn_Split_SelectSrcFile.Size = new System.Drawing.Size(34, 23);
            this.btn_Split_SelectSrcFile.TabIndex = 8;
            this.btn_Split_SelectSrcFile.Text = "...";
            this.btn_Split_SelectSrcFile.UseVisualStyleBackColor = true;
            this.btn_Split_SelectSrcFile.Click += new System.EventHandler(this.btn_Split_SelectSrcFile_Click);
            // 
            // lbl_Split_SrcFile
            // 
            this.lbl_Split_SrcFile.AutoSize = true;
            this.lbl_Split_SrcFile.Location = new System.Drawing.Point(6, 9);
            this.lbl_Split_SrcFile.Name = "lbl_Split_SrcFile";
            this.lbl_Split_SrcFile.Size = new System.Drawing.Size(57, 13);
            this.lbl_Split_SrcFile.TabIndex = 7;
            this.lbl_Split_SrcFile.Text = "Source file";
            // 
            // txt_Split_SrcFile
            // 
            this.txt_Split_SrcFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Split_SrcFile.Location = new System.Drawing.Point(72, 6);
            this.txt_Split_SrcFile.Name = "txt_Split_SrcFile";
            this.txt_Split_SrcFile.Size = new System.Drawing.Size(334, 20);
            this.txt_Split_SrcFile.TabIndex = 6;
            // 
            // chk_Split_PreserveTextLines
            // 
            this.chk_Split_PreserveTextLines.AutoSize = true;
            this.chk_Split_PreserveTextLines.Location = new System.Drawing.Point(354, 61);
            this.chk_Split_PreserveTextLines.Name = "chk_Split_PreserveTextLines";
            this.chk_Split_PreserveTextLines.Size = new System.Drawing.Size(92, 17);
            this.chk_Split_PreserveTextLines.TabIndex = 14;
            this.chk_Split_PreserveTextLines.Text = "Preserve lines";
            this.chk_Split_PreserveTextLines.UseVisualStyleBackColor = true;
            // 
            // txt_Split_ExtOverride
            // 
            this.txt_Split_ExtOverride.Location = new System.Drawing.Point(72, 59);
            this.txt_Split_ExtOverride.Name = "txt_Split_ExtOverride";
            this.txt_Split_ExtOverride.Size = new System.Drawing.Size(80, 20);
            this.txt_Split_ExtOverride.TabIndex = 15;
            // 
            // lbl_Split_ExtOverride
            // 
            this.lbl_Split_ExtOverride.AutoSize = true;
            this.lbl_Split_ExtOverride.Location = new System.Drawing.Point(6, 62);
            this.lbl_Split_ExtOverride.Name = "lbl_Split_ExtOverride";
            this.lbl_Split_ExtOverride.Size = new System.Drawing.Size(63, 13);
            this.lbl_Split_ExtOverride.TabIndex = 16;
            this.lbl_Split_ExtOverride.Text = "Ext override";
            // 
            // btn_Split_Start
            // 
            this.btn_Split_Start.Location = new System.Drawing.Point(371, 83);
            this.btn_Split_Start.Name = "btn_Split_Start";
            this.btn_Split_Start.Size = new System.Drawing.Size(75, 23);
            this.btn_Split_Start.TabIndex = 17;
            this.btn_Split_Start.Text = "Start";
            this.btn_Split_Start.UseVisualStyleBackColor = true;
            this.btn_Split_Start.Click += new System.EventHandler(this.btn_Split_Start_Click);
            // 
            // SwissFileGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 166);
            this.Controls.Add(this.tabs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 205);
            this.Name = "SwissFileGUI";
            this.Text = "Swiss File";
            this.tabs.ResumeLayout(false);
            this.tabCopy.ResumeLayout(false);
            this.tabCopy.PerformLayout();
            this.tabSplit.ResumeLayout(false);
            this.tabSplit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Split_MaxBytes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabCopy;
        private System.Windows.Forms.TabPage tabSplit;
        private System.Windows.Forms.Button btn_Copy_SelectSrcFile;
        private System.Windows.Forms.Label lbl_Copy_SrcFile;
        private System.Windows.Forms.TextBox txt_Copy_SrcFile;
        private System.Windows.Forms.Button btn_Copy_Start;
        private System.Windows.Forms.TextBox txt_Copy_FnOverride;
        private System.Windows.Forms.Label lbl_Copy_FnOverride;
        private System.Windows.Forms.Button btn_Copy_SelectDestFolder;
        private System.Windows.Forms.TextBox txt_Copy_DestFolder;
        private System.Windows.Forms.Label lbl_Copy_DestFolder;
        private System.Windows.Forms.CheckBox chk_Copy_CloseOnSuccess;
        private System.Windows.Forms.CheckBox chk_Copy_OverwriteDest;
        private System.Windows.Forms.CheckBox chk_Copy_DeletSrcAfterCopy;
        private System.Windows.Forms.Button btn_Split_SelectDestFolder;
        private System.Windows.Forms.TextBox txt_Split_DestFolder;
        private System.Windows.Forms.Label lbl_Split_DestFolder;
        private System.Windows.Forms.Button btn_Split_SelectSrcFile;
        private System.Windows.Forms.Label lbl_Split_SrcFile;
        private System.Windows.Forms.TextBox txt_Split_SrcFile;
        private System.Windows.Forms.Label lbl_Split_MaxBytes;
        private System.Windows.Forms.NumericUpDown num_Split_MaxBytes;
        private System.Windows.Forms.Button btn_Split_Start;
        private System.Windows.Forms.Label lbl_Split_ExtOverride;
        private System.Windows.Forms.TextBox txt_Split_ExtOverride;
        private System.Windows.Forms.CheckBox chk_Split_PreserveTextLines;
    }
}

