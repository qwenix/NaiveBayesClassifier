using Microsoft.VisualBasic.FileIO;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace BayesSpamFiltering.Data {

    public struct Paths {
        public const string CSV_TABLE = "data_table.csv";
        public const string TEXT_CLASS1 = "class1.txt";
        public const string TEXT_CLASS2 = "class2.txt";
    }
    public static class DataManipulator {
        public static void Open(string path) {    
            Process.Start(path);
        }

        public static DataTable ReadCSV(string path) {
            var table = new DataTable();

            using (var reader = new TextFieldParser(path, Encoding.Unicode)) {
                reader.SetDelimiters(new string[] { "\t" });
                reader.HasFieldsEnclosedInQuotes = true;

                string[] columns = reader.ReadFields();
                foreach (string c in columns) {
                    DataColumn column = new DataColumn(c);
                    column.AllowDBNull = true;
                    table.Columns.Add(column);
                }

                while (!reader.EndOfData) {
                    string[] data = reader.ReadFields();
                    table.Rows.Add(data);
                }
            }

            return table;
        }

        public static string Read(string path) {
            string result = null;
            using (var sr = new StreamReader(path)) {
                result = sr.ReadToEnd();
            }
            return result;
        }

        public static void Write(string path, string data) {
            using (var sw = new StreamWriter(path, false)) {
                sw.Write(data);
            }
        }
    }

}
