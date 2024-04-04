namespace CSVComparisonTool
{
    partial class FileComparisonForm
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
            this.labelFirstFile = new System.Windows.Forms.Label();
            this.textBoxFirstFileEntry = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewComparison = new System.Windows.Forms.DataGridView();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonCompare = new System.Windows.Forms.Button();
            this.buttonSecondFileBrowse = new System.Windows.Forms.Button();
            this.buttonFirstFileBrowse = new System.Windows.Forms.Button();
            this.labelSecondFile = new System.Windows.Forms.Label();
            this.textBoxSecondFileEntry = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComparison)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFirstFile
            // 
            this.labelFirstFile.AutoSize = true;
            this.labelFirstFile.Location = new System.Drawing.Point(14, 32);
            this.labelFirstFile.Name = "labelFirstFile";
            this.labelFirstFile.Size = new System.Drawing.Size(133, 16);
            this.labelFirstFile.TabIndex = 1;
            this.labelFirstFile.Text = "First File to Compare:";
            // 
            // textBoxFirstFileEntry
            // 
            this.textBoxFirstFileEntry.Location = new System.Drawing.Point(17, 51);
            this.textBoxFirstFileEntry.Name = "textBoxFirstFileEntry";
            this.textBoxFirstFileEntry.Size = new System.Drawing.Size(577, 22);
            this.textBoxFirstFileEntry.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1025, 537);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewComparison);
            this.tabPage1.Controls.Add(this.buttonClear);
            this.tabPage1.Controls.Add(this.buttonCompare);
            this.tabPage1.Controls.Add(this.buttonSecondFileBrowse);
            this.tabPage1.Controls.Add(this.buttonFirstFileBrowse);
            this.tabPage1.Controls.Add(this.labelSecondFile);
            this.tabPage1.Controls.Add(this.textBoxSecondFileEntry);
            this.tabPage1.Controls.Add(this.labelFirstFile);
            this.tabPage1.Controls.Add(this.textBoxFirstFileEntry);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1017, 508);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Comparison";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewComparison
            // 
            this.dataGridViewComparison.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewComparison.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewComparison.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewComparison.Location = new System.Drawing.Point(17, 236);
            this.dataGridViewComparison.Name = "dataGridViewComparison";
            this.dataGridViewComparison.RowHeadersWidth = 51;
            this.dataGridViewComparison.RowTemplate.Height = 24;
            this.dataGridViewComparison.Size = new System.Drawing.Size(977, 245);
            this.dataGridViewComparison.TabIndex = 9;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(158, 158);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(122, 38);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonCompare
            // 
            this.buttonCompare.Location = new System.Drawing.Point(17, 158);
            this.buttonCompare.Name = "buttonCompare";
            this.buttonCompare.Size = new System.Drawing.Size(122, 38);
            this.buttonCompare.TabIndex = 7;
            this.buttonCompare.Text = "Compare";
            this.buttonCompare.UseVisualStyleBackColor = true;
            this.buttonCompare.Click += new System.EventHandler(this.buttonCompare_Click);
            // 
            // buttonSecondFileBrowse
            // 
            this.buttonSecondFileBrowse.Location = new System.Drawing.Point(600, 106);
            this.buttonSecondFileBrowse.Name = "buttonSecondFileBrowse";
            this.buttonSecondFileBrowse.Size = new System.Drawing.Size(96, 23);
            this.buttonSecondFileBrowse.TabIndex = 6;
            this.buttonSecondFileBrowse.Text = "Browse";
            this.buttonSecondFileBrowse.UseVisualStyleBackColor = true;
            this.buttonSecondFileBrowse.Click += new System.EventHandler(this.buttonSecondFileBrowse_Click);
            // 
            // buttonFirstFileBrowse
            // 
            this.buttonFirstFileBrowse.Location = new System.Drawing.Point(600, 51);
            this.buttonFirstFileBrowse.Name = "buttonFirstFileBrowse";
            this.buttonFirstFileBrowse.Size = new System.Drawing.Size(96, 23);
            this.buttonFirstFileBrowse.TabIndex = 5;
            this.buttonFirstFileBrowse.Text = "Browse";
            this.buttonFirstFileBrowse.UseVisualStyleBackColor = true;
            this.buttonFirstFileBrowse.Click += new System.EventHandler(this.buttonFirstFileBrowse_Click);
            // 
            // labelSecondFile
            // 
            this.labelSecondFile.AutoSize = true;
            this.labelSecondFile.Location = new System.Drawing.Point(14, 87);
            this.labelSecondFile.Name = "labelSecondFile";
            this.labelSecondFile.Size = new System.Drawing.Size(155, 16);
            this.labelSecondFile.TabIndex = 3;
            this.labelSecondFile.Text = "Second File to Compare:";
            // 
            // textBoxSecondFileEntry
            // 
            this.textBoxSecondFileEntry.Location = new System.Drawing.Point(17, 106);
            this.textBoxSecondFileEntry.Name = "textBoxSecondFileEntry";
            this.textBoxSecondFileEntry.Size = new System.Drawing.Size(577, 22);
            this.textBoxSecondFileEntry.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1017, 508);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // FileComparisonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 550);
            this.Controls.Add(this.tabControl1);
            this.Name = "FileComparisonForm";
            this.Text = "CSV File Comparison Tool";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComparison)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelFirstFile;
        private System.Windows.Forms.TextBox textBoxFirstFileEntry;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label labelSecondFile;
        private System.Windows.Forms.TextBox textBoxSecondFileEntry;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonCompare;
        private System.Windows.Forms.Button buttonSecondFileBrowse;
        private System.Windows.Forms.Button buttonFirstFileBrowse;
        private System.Windows.Forms.DataGridView dataGridViewComparison;
    }
}

