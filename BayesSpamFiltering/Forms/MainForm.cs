using BayesSpamFiltering.Data;
using BayesSpamFiltering.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using DataManipulator = BayesSpamFiltering.Data.DataManipulator;

namespace BayesSpamFiltering {
    public partial class MainForm : Form {
        private MainFormModel table;

        public MainForm(MainFormModel t) {
            table = t;

            InitializeComponent();
            freqTable.DataSource = table.Classifier.WordsReport;

            SetupChart(spamChart);
            FillChart(spamChart, table.Classifier.GetTop("#1", 30));

            SetupChart(cohChart);
            FillChart(cohChart, table.Classifier.GetTop("#2", 30));

            spamLength.Text += table.Classifier.GetWordsCount("#1").ToString();
            cohLength.Text += table.Classifier.GetWordsCount("#2").ToString();
        }

        private void FillChart<XType, YType>(Chart chart, 
            IEnumerable<KeyValuePair<XType, YType>> data) {
            foreach (var p in data) {
                chart.Series[0].Points.AddXY(p.Key, p.Value);
            }
        }

        private void SetupChart(Chart chart) {
            chart.ChartAreas[0].AxisX.Interval = 1;
        }

        private void OpenFile(string file) {
            try {
                DataManipulator.Open(file);
            }
            catch (FileNotFoundException) {
                ShowError("File not found");
            }
            catch (DirectoryNotFoundException) {
                ShowError("Directory not found");
            }
        }

        private void ShowError(string info) {
            MessageBox.Show(info, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EnableResultLabels() {
            resLabel.Visible = true;
            resInfoLabel.Visible = true;
            infoLabel.Visible = false;
        }

        #region Обробники подій

        private void OpenTextBtn1_Click(object sender, EventArgs e) {
            OpenFile(Paths.TEXT_CLASS1);
        }

        private void OpenCSVBtn_Click(object sender, EventArgs e) {
            OpenFile(Paths.CSV_TABLE);
        }

        private void OpenTextBtn2_Click(object sender, EventArgs e) {
            OpenFile(Paths.TEXT_CLASS2);
        }

        private void TestBtn_Click(object sender, EventArgs e) {
            string text = testTextBox.Text;
            if (text.Length > 0) {
                double p = table.Classifier.Test("#1", text);
                EnableResultLabels();
                if (double.IsNaN(p))
                    resLabel.Text = "Занадто великий текст";
                else
                    resLabel.Text = p.ToString();
            }
        }

        #endregion
    }
}
