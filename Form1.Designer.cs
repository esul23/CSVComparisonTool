namespace ComparisonTool
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
            this.comboBoxComparisonType = new System.Windows.Forms.ComboBox();
            this.labelFirstFile = new System.Windows.Forms.Label();
            this.textBoxFirstFileEntry = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelSecondFile = new System.Windows.Forms.Label();
            this.textBoxSecondFileEntry = new System.Windows.Forms.TextBox();
            this.buttonFirstFileBrowse = new System.Windows.Forms.Button();
            this.buttonSecondFileBrowse = new System.Windows.Forms.Button();
            this.buttonCompare = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxComparisonType
            // 
            this.comboBoxComparisonType.FormattingEnabled = true;
            this.comboBoxComparisonType.Items.AddRange(new object[] {
            "csv",
            "pdf"});
            this.comboBoxComparisonType.Location = new System.Drawing.Point(17, 25);
            this.comboBoxComparisonType.Name = "comboBoxComparisonType";
            this.comboBoxComparisonType.Size = new System.Drawing.Size(121, 24);
            this.comboBoxComparisonType.TabIndex = 0;
            // 
            // labelFirstFile
            // 
            this.labelFirstFile.AutoSize = true;
            this.labelFirstFile.Location = new System.Drawing.Point(14, 84);
            this.labelFirstFile.Name = "labelFirstFile";
            this.labelFirstFile.Size = new System.Drawing.Size(133, 16);
            this.labelFirstFile.TabIndex = 1;
            this.labelFirstFile.Text = "First File to Compare:";
            // 
            // textBoxFirstFileEntry
            // 
            this.textBoxFirstFileEntry.Location = new System.Drawing.Point(17, 103);
            this.textBoxFirstFileEntry.Name = "textBoxFirstFileEntry";
            this.textBoxFirstFileEntry.Size = new System.Drawing.Size(577, 22);
            this.textBoxFirstFileEntry.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonClear);
            this.tabPage1.Controls.Add(this.buttonCompare);
            this.tabPage1.Controls.Add(this.buttonSecondFileBrowse);
            this.tabPage1.Controls.Add(this.buttonFirstFileBrowse);
            this.tabPage1.Controls.Add(this.labelSecondFile);
            this.tabPage1.Controls.Add(this.textBoxSecondFileEntry);
            this.tabPage1.Controls.Add(this.labelFirstFile);
            this.tabPage1.Controls.Add(this.textBoxFirstFileEntry);
            this.tabPage1.Controls.Add(this.comboBoxComparisonType);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 71);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelSecondFile
            // 
            this.labelSecondFile.AutoSize = true;
            this.labelSecondFile.Location = new System.Drawing.Point(14, 139);
            this.labelSecondFile.Name = "labelSecondFile";
            this.labelSecondFile.Size = new System.Drawing.Size(155, 16);
            this.labelSecondFile.TabIndex = 3;
            this.labelSecondFile.Text = "Second File to Compare:";
            // 
            // textBoxSecondFileEntry
            // 
            this.textBoxSecondFileEntry.Location = new System.Drawing.Point(17, 158);
            this.textBoxSecondFileEntry.Name = "textBoxSecondFileEntry";
            this.textBoxSecondFileEntry.Size = new System.Drawing.Size(577, 22);
            this.textBoxSecondFileEntry.TabIndex = 4;
            // 
            // buttonFirstFileBrowse
            // 
            this.buttonFirstFileBrowse.Location = new System.Drawing.Point(600, 103);
            this.buttonFirstFileBrowse.Name = "buttonFirstFileBrowse";
            this.buttonFirstFileBrowse.Size = new System.Drawing.Size(96, 23);
            this.buttonFirstFileBrowse.TabIndex = 5;
            this.buttonFirstFileBrowse.Text = "Browse";
            this.buttonFirstFileBrowse.UseVisualStyleBackColor = true;
            // 
            // buttonSecondFileBrowse
            // 
            this.buttonSecondFileBrowse.Location = new System.Drawing.Point(600, 158);
            this.buttonSecondFileBrowse.Name = "buttonSecondFileBrowse";
            this.buttonSecondFileBrowse.Size = new System.Drawing.Size(96, 23);
            this.buttonSecondFileBrowse.TabIndex = 6;
            this.buttonSecondFileBrowse.Text = "Browse";
            this.buttonSecondFileBrowse.UseVisualStyleBackColor = true;
            // 
            // buttonCompare
            // 
            this.buttonCompare.Location = new System.Drawing.Point(17, 196);
            this.buttonCompare.Name = "buttonCompare";
            this.buttonCompare.Size = new System.Drawing.Size(122, 38);
            this.buttonCompare.TabIndex = 7;
            this.buttonCompare.Text = "Compare";
            this.buttonCompare.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(161, 196);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(122, 38);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxComparisonType;
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
    }
}

