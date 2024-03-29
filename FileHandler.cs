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
        public static string GetFilePath()
        {
            string filePath = "";

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {

                openFileDialog.InitialDirectory = @"C:\Users\ericn\Desktop\Target";
                openFileDialog.Filter = "CSV Files (*.csv)|*.csv";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                }
            }
            
            

            return filePath;
        }

        public static List<string> GetFileData(string filePath)
        {
            List<string> rowsToReturn = new List<string>();
            
            string fileExtension = Path.GetExtension(filePath);

            switch (fileExtension)
            {
                case ("pdf"):

                    break;

                case ("csv"):
                    rowsToReturn.AddRange(File.ReadAllLines(filePath));
                    break;
            }

            return rowsToReturn;
        }
    }
}
