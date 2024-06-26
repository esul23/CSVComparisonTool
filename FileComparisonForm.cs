﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace CSVComparisonTool
{
    public partial class FileComparisonForm : Form
    {
        public FileComparisonForm()
        {
            InitializeComponent();
        }

        public void buttonFirstFileBrowse_Click(object sender, EventArgs e)
        {
            textBoxFirstFileEntry.Text = FileHandler.GetFilePath();
        }

        private void buttonSecondFileBrowse_Click(object sender, EventArgs e)
        {
            textBoxSecondFileEntry.Text = FileHandler.GetFilePath();
        }

        private void buttonCompare_Click(object sender, EventArgs e)
        {
            if (!File.Exists(textBoxFirstFileEntry.Text) || !File.Exists(textBoxSecondFileEntry.Text))
            {
                MessageBox.Show("Please enter 2 valid paths before comparing");
                return;
            }
            
            List<string> firstFileData =  FileHandler.GetFileData(textBoxFirstFileEntry.Text);
            List<string> secondFileData = FileHandler.GetFileData(textBoxSecondFileEntry.Text);
            
            DataTable dt = FileHandler.CompareData(firstFileData, secondFileData);

            dataGridViewComparison.DataSource = dt;

            if (dt.Rows.Count == 0) { MessageBox.Show("Files are the same"); }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxFirstFileEntry.Clear();
            textBoxSecondFileEntry.Clear();
            dataGridViewComparison.DataSource = null;
        }
    }
}
