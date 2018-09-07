namespace FfmpegApp
{
    partial class Form1
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
			this.convertButton = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.addFilesButton = new System.Windows.Forms.Button();
			this.folderOpenButton = new System.Windows.Forms.Button();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.label1 = new System.Windows.Forms.Label();
			this.fileListBox = new System.Windows.Forms.ListBox();
			this.numberOfFilesLabel = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.ouputDirLabel = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.statusLabel = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.removeAllButton = new System.Windows.Forms.Button();
			this.removeSelectctedButton = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// convertButton
			// 
			this.convertButton.Location = new System.Drawing.Point(452, 12);
			this.convertButton.Name = "convertButton";
			this.convertButton.Size = new System.Drawing.Size(104, 23);
			this.convertButton.TabIndex = 0;
			this.convertButton.Text = "Convert";
			this.convertButton.UseVisualStyleBackColor = true;
			this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.Filter = "Video Files|*.flv";
			this.openFileDialog1.Multiselect = true;
			// 
			// addFilesButton
			// 
			this.addFilesButton.Location = new System.Drawing.Point(12, 12);
			this.addFilesButton.Name = "addFilesButton";
			this.addFilesButton.Size = new System.Drawing.Size(104, 23);
			this.addFilesButton.TabIndex = 1;
			this.addFilesButton.Text = "Add files";
			this.addFilesButton.UseVisualStyleBackColor = true;
			this.addFilesButton.Click += new System.EventHandler(this.openFileButton_Click);
			// 
			// folderOpenButton
			// 
			this.folderOpenButton.Location = new System.Drawing.Point(122, 12);
			this.folderOpenButton.Name = "folderOpenButton";
			this.folderOpenButton.Size = new System.Drawing.Size(104, 23);
			this.folderOpenButton.TabIndex = 5;
			this.folderOpenButton.Text = "Chenge output directory";
			this.folderOpenButton.UseVisualStyleBackColor = true;
			this.folderOpenButton.Click += new System.EventHandler(this.folderOpenButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Number of files";
			// 
			// fileListBox
			// 
			this.fileListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.fileListBox.FormattingEnabled = true;
			this.fileListBox.Location = new System.Drawing.Point(12, 124);
			this.fileListBox.Name = "fileListBox";
			this.fileListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.fileListBox.Size = new System.Drawing.Size(544, 316);
			this.fileListBox.TabIndex = 8;
			// 
			// numberOfFilesLabel
			// 
			this.numberOfFilesLabel.AutoSize = true;
			this.numberOfFilesLabel.Location = new System.Drawing.Point(92, 8);
			this.numberOfFilesLabel.Name = "numberOfFilesLabel";
			this.numberOfFilesLabel.Size = new System.Drawing.Size(13, 13);
			this.numberOfFilesLabel.TabIndex = 9;
			this.numberOfFilesLabel.Text = "0";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 31);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 13);
			this.label2.TabIndex = 10;
			this.label2.Text = "Ouput directory";
			// 
			// ouputDirLabel
			// 
			this.ouputDirLabel.AutoSize = true;
			this.ouputDirLabel.Location = new System.Drawing.Point(92, 31);
			this.ouputDirLabel.Name = "ouputDirLabel";
			this.ouputDirLabel.Size = new System.Drawing.Size(0, 13);
			this.ouputDirLabel.TabIndex = 11;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 54);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 13);
			this.label3.TabIndex = 12;
			this.label3.Text = "Status";
			// 
			// statusLabel
			// 
			this.statusLabel.AutoSize = true;
			this.statusLabel.Location = new System.Drawing.Point(92, 54);
			this.statusLabel.Name = "statusLabel";
			this.statusLabel.Size = new System.Drawing.Size(0, 13);
			this.statusLabel.TabIndex = 13;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.statusLabel);
			this.panel1.Controls.Add(this.numberOfFilesLabel);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.ouputDirLabel);
			this.panel1.Location = new System.Drawing.Point(12, 41);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(544, 77);
			this.panel1.TabIndex = 14;
			// 
			// removeAllButton
			// 
			this.removeAllButton.Location = new System.Drawing.Point(232, 12);
			this.removeAllButton.Name = "removeAllButton";
			this.removeAllButton.Size = new System.Drawing.Size(104, 23);
			this.removeAllButton.TabIndex = 15;
			this.removeAllButton.Text = "Remove all";
			this.removeAllButton.UseVisualStyleBackColor = true;
			this.removeAllButton.Click += new System.EventHandler(this.removeAllButton_Click);
			// 
			// removeSelectctedButton
			// 
			this.removeSelectctedButton.Location = new System.Drawing.Point(342, 12);
			this.removeSelectctedButton.Name = "removeSelectctedButton";
			this.removeSelectctedButton.Size = new System.Drawing.Size(104, 23);
			this.removeSelectctedButton.TabIndex = 16;
			this.removeSelectctedButton.Text = "Remove selected";
			this.removeSelectctedButton.UseVisualStyleBackColor = true;
			this.removeSelectctedButton.Click += new System.EventHandler(this.removeSelectctedButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(569, 450);
			this.Controls.Add(this.removeSelectctedButton);
			this.Controls.Add(this.removeAllButton);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.fileListBox);
			this.Controls.Add(this.folderOpenButton);
			this.Controls.Add(this.addFilesButton);
			this.Controls.Add(this.convertButton);
			this.Name = "Form1";
			this.Text = "Convert to mp4";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button addFilesButton;
        private System.Windows.Forms.Button folderOpenButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox fileListBox;
		private System.Windows.Forms.Label numberOfFilesLabel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label ouputDirLabel;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label statusLabel;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button removeAllButton;
		private System.Windows.Forms.Button removeSelectctedButton;
	}
}

