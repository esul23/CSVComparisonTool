using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSVComparisonTool
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

        public static DataTable CompareData(List<string> file1Data, List<string> file2Data)
        {
            // List<string> dataDifferences = new List<string>();
            DataTable dt = new DataTable();
            dt.Columns.Add("File 1 Unique Rows", typeof(string));
            dt.Columns.Add("File 2 Unique Rows", typeof(string));

            for (int i = file1Data.Count - 1; i >= 0; i--)
            {
                if (file2Data.Contains(file1Data[i]))
                {
                    file2Data.Remove(file1Data[i]);
                    file1Data.RemoveAt(i);
                }
            }

            foreach (var line in file1Data)
            {
                dt.Rows.Add(line, "");
            }
            foreach (var line in file2Data)
            {
                dt.Rows.Add("", line);
            }


            return dt;

        }
    }
}
