using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace ComparisonTool
{
    public partial class Form1 : Form
    {
        public Form1()
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
            List<string> firstFileData =  FileHandler.GetFileData(textBoxFirstFileEntry.Text);
            List<string> secondFileData = FileHandler.GetFileData(textBoxSecondFileEntry.Text);
            
            DataTable dt = FileHandler.CompareData(firstFileData, secondFileData);

            dataGridViewComparison.DataSource = dt;

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxFirstFileEntry.Clear();
            textBoxSecondFileEntry.Clear();
            dataGridViewComparison.DataSource = null;
        }
    }
}
