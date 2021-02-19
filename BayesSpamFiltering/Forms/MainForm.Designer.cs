namespace BayesSpamFiltering {
    partial class MainForm {

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        private void InitializeComponent() {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.resLabel = new System.Windows.Forms.Label();
            this.resInfoLabel = new System.Windows.Forms.Label();
            this.testBtn = new System.Windows.Forms.Button();
            this.testTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.spamChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cohChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.spamLength = new System.Windows.Forms.Label();
            this.openTextBtn1 = new System.Windows.Forms.Button();
            this.freqTable = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cohLength = new System.Windows.Forms.Label();
            this.openTextBtn2 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spamChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cohChart)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.freqTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.testBtn);
            this.tabPage3.Controls.Add(this.testTextBox);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1323, 702);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Наївний Байєсівський класифікатор";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.infoLabel);
            this.groupBox2.Controls.Add(this.resLabel);
            this.groupBox2.Controls.Add(this.resInfoLabel);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(965, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 153);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Результат";
            // 
            // infoLabel
            // 
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoLabel.Location = new System.Drawing.Point(12, 53);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(301, 41);
            this.infoLabel.TabIndex = 7;
            this.infoLabel.Text = "Введіть текст, та натисніть кнопку \"Перевірити на спам\"";
            // 
            // resLabel
            // 
            this.resLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resLabel.Location = new System.Drawing.Point(12, 94);
            this.resLabel.Name = "resLabel";
            this.resLabel.Size = new System.Drawing.Size(301, 23);
            this.resLabel.TabIndex = 6;
            this.resLabel.Text = "99";
            this.resLabel.Visible = false;
            // 
            // resInfoLabel
            // 
            this.resInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resInfoLabel.Location = new System.Drawing.Point(12, 33);
            this.resInfoLabel.Name = "resInfoLabel";
            this.resInfoLabel.Size = new System.Drawing.Size(301, 41);
            this.resInfoLabel.TabIndex = 5;
            this.resInfoLabel.Text = "Текст являє собою спам-повідомлення з ймовірністю:";
            this.resInfoLabel.Visible = false;
            // 
            // testBtn
            // 
            this.testBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.testBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.testBtn.Location = new System.Drawing.Point(777, 629);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(154, 33);
            this.testBtn.TabIndex = 2;
            this.testBtn.Text = "Перевірити на спам";
            this.testBtn.UseVisualStyleBackColor = true;
            this.testBtn.Click += new System.EventHandler(this.TestBtn_Click);
            // 
            // testTextBox
            // 
            this.testTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.testTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.testTextBox.Location = new System.Drawing.Point(23, 67);
            this.testTextBox.Multiline = true;
            this.testTextBox.Name = "testTextBox";
            this.testTextBox.Size = new System.Drawing.Size(908, 545);
            this.testTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(19, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Текст для перевірки:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.spamChart);
            this.tabPage1.Controls.Add(this.cohChart);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.freqTable);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1323, 702);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Частотна таблиця";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // spamChart
            // 
            this.spamChart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.spamChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.spamChart.Legends.Add(legend1);
            this.spamChart.Location = new System.Drawing.Point(474, 6);
            this.spamChart.Name = "spamChart";
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series1.IsVisibleInLegend = false;
            series1.LabelAngle = 45;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.spamChart.Series.Add(series1);
            this.spamChart.Size = new System.Drawing.Size(841, 336);
            this.spamChart.TabIndex = 12;
            this.spamChart.Text = "chart2";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.IsDockedInsideChartArea = false;
            title1.Name = "Title1";
            title1.Text = "Гістограма топ-30 слів (Клас #1)";
            title2.DockedToChartArea = "ChartArea1";
            title2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title2.IsDockedInsideChartArea = false;
            title2.Name = "Title2";
            title2.Text = "Частота";
            title3.DockedToChartArea = "ChartArea1";
            title3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title3.IsDockedInsideChartArea = false;
            title3.Name = "Title3";
            title3.Text = "Слово";
            this.spamChart.Titles.Add(title1);
            this.spamChart.Titles.Add(title2);
            this.spamChart.Titles.Add(title3);
            // 
            // cohChart
            // 
            this.cohChart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.cohChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.cohChart.Legends.Add(legend2);
            this.cohChart.Location = new System.Drawing.Point(474, 348);
            this.cohChart.Name = "cohChart";
            series2.ChartArea = "ChartArea1";
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.cohChart.Series.Add(series2);
            this.cohChart.Size = new System.Drawing.Size(841, 354);
            this.cohChart.TabIndex = 13;
            this.cohChart.Text = "chart3";
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title4.IsDockedInsideChartArea = false;
            title4.Name = "Title1";
            title4.Text = "Гістограма топ-30 слів (Клас #2)";
            title5.DockedToChartArea = "ChartArea1";
            title5.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            title5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title5.IsDockedInsideChartArea = false;
            title5.Name = "Title2";
            title5.Text = "Частота";
            title6.DockedToChartArea = "ChartArea1";
            title6.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title6.IsDockedInsideChartArea = false;
            title6.Name = "Title3";
            title6.Text = "Слово";
            this.cohChart.Titles.Add(title4);
            this.cohChart.Titles.Add(title5);
            this.cohChart.Titles.Add(title6);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.spamLength);
            this.groupBox1.Controls.Add(this.openTextBtn1);
            this.groupBox1.Location = new System.Drawing.Point(20, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 98);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Клас #1 (спам)";
            // 
            // spamLength
            // 
            this.spamLength.AutoSize = true;
            this.spamLength.Location = new System.Drawing.Point(19, 30);
            this.spamLength.Name = "spamLength";
            this.spamLength.Size = new System.Drawing.Size(79, 13);
            this.spamLength.TabIndex = 8;
            this.spamLength.Text = "Кількість слів:";
            // 
            // openTextBtn1
            // 
            this.openTextBtn1.Location = new System.Drawing.Point(20, 55);
            this.openTextBtn1.Name = "openTextBtn1";
            this.openTextBtn1.Size = new System.Drawing.Size(115, 23);
            this.openTextBtn1.TabIndex = 1;
            this.openTextBtn1.Text = "Відкрити текст .txt";
            this.openTextBtn1.UseVisualStyleBackColor = true;
            this.openTextBtn1.Click += new System.EventHandler(this.OpenTextBtn1_Click);
            // 
            // freqTable
            // 
            this.freqTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.freqTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.freqTable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.freqTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.freqTable.Location = new System.Drawing.Point(20, 163);
            this.freqTable.Name = "freqTable";
            this.freqTable.Size = new System.Drawing.Size(442, 531);
            this.freqTable.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 696);
            this.panel1.TabIndex = 14;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cohLength);
            this.groupBox3.Controls.Add(this.openTextBtn2);
            this.groupBox3.Location = new System.Drawing.Point(240, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(219, 98);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Клас #2 (не спам)";
            // 
            // cohLength
            // 
            this.cohLength.AutoSize = true;
            this.cohLength.Location = new System.Drawing.Point(19, 30);
            this.cohLength.Name = "cohLength";
            this.cohLength.Size = new System.Drawing.Size(79, 13);
            this.cohLength.TabIndex = 8;
            this.cohLength.Text = "Кількість слів:";
            // 
            // openTextBtn2
            // 
            this.openTextBtn2.Location = new System.Drawing.Point(20, 55);
            this.openTextBtn2.Name = "openTextBtn2";
            this.openTextBtn2.Size = new System.Drawing.Size(113, 23);
            this.openTextBtn2.TabIndex = 1;
            this.openTextBtn2.Text = "Відкрити текст .txt";
            this.openTextBtn2.UseVisualStyleBackColor = true;
            this.openTextBtn2.Click += new System.EventHandler(this.OpenTextBtn2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1331, 728);
            this.tabControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 728);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Фільтрація спам-повідомлень";
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spamChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cohChart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.freqTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataVisualization.Charting.Chart spamChart;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label cohLength;
        private System.Windows.Forms.Button openTextBtn2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label spamLength;
        private System.Windows.Forms.Button openTextBtn1;
        private System.Windows.Forms.DataGridView freqTable;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataVisualization.Charting.Chart cohChart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox testTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label resLabel;
        private System.Windows.Forms.Label resInfoLabel;
        private System.Windows.Forms.Button testBtn;
        private System.Windows.Forms.Label infoLabel;
    }
}

