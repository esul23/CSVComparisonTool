using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComparisonTool
{
    public class FileHandler
    {
        public string RetrieveFilePath()
        {
            string filePath = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"C:\Users\ericn\Desktop\Target";
            openFileDialog.Filter = "CSV Files (*.csv)|*.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
            }

            return filePath;
        }

        public List<string> GetFileDataRows(string filePath)
        {
            List<string> rowsToReturn = new List<string>();

            rowsToReturn.AddRange(File.ReadAllLines(filePath));
            
            return rowsToReturn;
        }
    }
}
