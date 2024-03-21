using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            FileHandler firstFileInstance = new FileHandler();
            textBoxFirstFileEntry.Text = firstFileInstance.RetrieveFilePath();
        }

        private void buttonSecondFileBrowse_Click(object sender, EventArgs e)
        {
            FileHandler secondFileInstance = new FileHandler();
            textBoxSecondFileEntry.Text = secondFileInstance.RetrieveFilePath();
        }
    }
}
