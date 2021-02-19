using BayesSpamFiltering.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BayesSpamFiltering.Models {
    public class MainFormModel {

        private const char SEPARATOR = '#';

        private string spamText;
        private string hamText;

        public MainFormModel() {
            ConcatSpamText();
            hamText = DataManipulator.Read(Paths.TEXT_CLASS2);

            List<Document> documents = new List<Document>() {
                new Document("#1", spamText),
                new Document("#2", hamText)
            };

            Classifier = new BayesClassifier(documents);
        }

        public BayesClassifier Classifier { get; private set; }

        private void ConcatSpamText() {
            DataTable table = DataManipulator.ReadCSV(Paths.CSV_TABLE);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < table.Rows.Count; i++) {
                string[] arr = table.Rows[i]["Text"].ToString().Split(SEPARATOR);
                string str = string.Empty;
                foreach (string s in arr) {
                    if (s != SEPARATOR.ToString())
                        str += s;
                }
                sb.Append(str + Environment.NewLine);
            }

            spamText = sb.ToString();
            DataManipulator.Write(Paths.TEXT_CLASS1, spamText);
        }
    }
}
