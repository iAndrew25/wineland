namespace BIProject
{
    partial class wine_color
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.winesDatabaseDataSet = new BIProject.WinesDatabaseDataSet();
            this.winesDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.winesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.winesTableAdapter = new BIProject.WinesDatabaseDataSetTableAdapters.winesTableAdapter();
            this.client_preference = new BIProject.client_preference();
            this.clientsegmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.client_segmentsTableAdapter = new BIProject.client_preferenceTableAdapters.client_segmentsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcountyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preference1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preference2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preference3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderCbBox = new System.Windows.Forms.ComboBox();
            this.chartBtn = new System.Windows.Forms.Button();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winesDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winesDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_preference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsegmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.idcountyDataGridViewTextBoxColumn,
            this.preference1DataGridViewTextBoxColumn,
            this.preference2DataGridViewTextBoxColumn,
            this.preference3DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clientsegmentsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(768, 290);
            this.dataGridView1.TabIndex = 0;
            // 
            // winesDatabaseDataSet
            // 
            this.winesDatabaseDataSet.DataSetName = "WinesDatabaseDataSet";
            this.winesDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // winesDatabaseDataSetBindingSource
            // 
            this.winesDatabaseDataSetBindingSource.DataSource = this.winesDatabaseDataSet;
            this.winesDatabaseDataSetBindingSource.Position = 0;
            this.winesDatabaseDataSetBindingSource.CurrentChanged += new System.EventHandler(this.winesDatabaseDataSetBindingSource_CurrentChanged);
            // 
            // winesBindingSource
            // 
            this.winesBindingSource.DataMember = "wines";
            this.winesBindingSource.DataSource = this.winesDatabaseDataSetBindingSource;
            // 
            // winesTableAdapter
            // 
            this.winesTableAdapter.ClearBeforeFill = true;
            // 
            // client_preference
            // 
            this.client_preference.DataSetName = "client_preference";
            this.client_preference.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsegmentsBindingSource
            // 
            this.clientsegmentsBindingSource.DataMember = "client_segments";
            this.clientsegmentsBindingSource.DataSource = this.client_preference;
            // 
            // client_segmentsTableAdapter
            // 
            this.client_segmentsTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "sex";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            // 
            // idcountyDataGridViewTextBoxColumn
            // 
            this.idcountyDataGridViewTextBoxColumn.DataPropertyName = "id_county";
            this.idcountyDataGridViewTextBoxColumn.HeaderText = "id_county";
            this.idcountyDataGridViewTextBoxColumn.Name = "idcountyDataGridViewTextBoxColumn";
            // 
            // preference1DataGridViewTextBoxColumn
            // 
            this.preference1DataGridViewTextBoxColumn.DataPropertyName = "Preference1";
            this.preference1DataGridViewTextBoxColumn.HeaderText = "Preference1";
            this.preference1DataGridViewTextBoxColumn.Name = "preference1DataGridViewTextBoxColumn";
            // 
            // preference2DataGridViewTextBoxColumn
            // 
            this.preference2DataGridViewTextBoxColumn.DataPropertyName = "Preference2";
            this.preference2DataGridViewTextBoxColumn.HeaderText = "Preference2";
            this.preference2DataGridViewTextBoxColumn.Name = "preference2DataGridViewTextBoxColumn";
            // 
            // preference3DataGridViewTextBoxColumn
            // 
            this.preference3DataGridViewTextBoxColumn.DataPropertyName = "Preference3";
            this.preference3DataGridViewTextBoxColumn.HeaderText = "Preference3";
            this.preference3DataGridViewTextBoxColumn.Name = "preference3DataGridViewTextBoxColumn";
            // 
            // genderCbBox
            // 
            this.genderCbBox.FormattingEnabled = true;
            this.genderCbBox.Items.AddRange(new object[] {
            "All",
            "M",
            "F"});
            this.genderCbBox.Location = new System.Drawing.Point(12, 12);
            this.genderCbBox.Name = "genderCbBox";
            this.genderCbBox.Size = new System.Drawing.Size(68, 21);
            this.genderCbBox.TabIndex = 1;
            this.genderCbBox.Text = "Gender";
            this.genderCbBox.SelectedIndexChanged += new System.EventHandler(this.genderCbBox_SelectedIndexChanged);
            // 
            // chartBtn
            // 
            this.chartBtn.Location = new System.Drawing.Point(705, 10);
            this.chartBtn.Name = "chartBtn";
            this.chartBtn.Size = new System.Drawing.Size(75, 23);
            this.chartBtn.TabIndex = 2;
            this.chartBtn.Text = "Chart";
            this.chartBtn.UseVisualStyleBackColor = true;
            this.chartBtn.Click += new System.EventHandler(this.chartBtn_Click);
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.DataSource = this.clientsegmentsBindingSource;
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(12, 39);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Preference 1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Preference 2";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Preference 3";
            this.chart.Series.Add(series1);
            this.chart.Series.Add(series2);
            this.chart.Series.Add(series3);
            this.chart.Size = new System.Drawing.Size(768, 290);
            this.chart.TabIndex = 3;
            this.chart.Text = "chart1";
            // 
            // wine_color
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 341);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.chartBtn);
            this.Controls.Add(this.genderCbBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "wine_color";
            this.Text = "Identify customer preference by wine color";
            this.Load += new System.EventHandler(this.wine_color_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winesDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winesDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_preference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsegmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource winesDatabaseDataSetBindingSource;
        private WinesDatabaseDataSet winesDatabaseDataSet;
        private System.Windows.Forms.BindingSource winesBindingSource;
        private WinesDatabaseDataSetTableAdapters.winesTableAdapter winesTableAdapter;
        private client_preference client_preference;
        private System.Windows.Forms.BindingSource clientsegmentsBindingSource;
        private client_preferenceTableAdapters.client_segmentsTableAdapter client_segmentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcountyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preference1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preference2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preference3DataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox genderCbBox;
        private System.Windows.Forms.Button chartBtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
    }
}