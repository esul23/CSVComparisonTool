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
            List<string> fileData = new List<string>();

            using (StreamReader str = new StreamReader(filePath))
            {
                
                while (!str.EndOfStream)
                {
                    fileData.Add(str.ReadLine());
                    
                }
            }
            return fileData;
        }

        public static List<string> CompareData(List<string> file1Data, List<string> file2Data)
        {
            List<string> dataDifferences = new List<string>();




            return dataDifferences;

        }
    }
}
