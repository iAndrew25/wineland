using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIProject
{
    public partial class period_record : Form
    {
        public OleDbConnection conn;
        public OleDbCommand cmd;
        public OleDbDataAdapter adapter;
        public DataTable result;


        public period_record()
        {
            InitializeComponent();
        }

        private void period_record_Load(object sender, EventArgs e)
        {
            ConnectToAccess();
        }

        private void populateWines()
        {
            foreach (DataRow row in getData("select * from wines order by wine_name").Rows)
            {
                comboBox1.Items.Add(row["wine_name"]);
            }
        }

        private DataTable getData(String query)
        {
            cmd = new OleDbCommand(query, conn);
            adapter = new OleDbDataAdapter(cmd);
            result = new DataTable();

            adapter.Fill(result);
            return result;
        }

        public void ConnectToAccess()
        {
            conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data source= C:\Users\Andy\Desktop\BI\BIProject\WinesDatabase.accdb";

            try
            {
                conn.Open();
                populateWines();

                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "MMMM / yyyy";
                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.CustomFormat = "MMMM / yyyy";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to data source" + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String wineName = comboBox1.Text;
            String startDate = dateTimePicker1.Text;
            String endDate = dateTimePicker2.Text;

            if (!string.IsNullOrEmpty(comboBox1.Text) && !string.IsNullOrEmpty(startDate) && !string.IsNullOrEmpty(endDate))
            {
                String startDateYear = dateTimePicker1.Value.Year.ToString();
                String startDateMonth = dateTimePicker1.Value.Month.ToString();
                String endDateYear = dateTimePicker2.Value.Year.ToString();
                String endDateMonth = dateTimePicker2.Value.Month.ToString();

                drawChart(getData($"SELECT SUM(sales.quantity), sales.month, sales.year FROM sales inner join wines on sales.id_wine = wines.id_wine WHERE sales.year >= {startDateYear} and sales.year <= {endDateYear} and wines.wine_name='{wineName}' GROUP BY sales.month, sales.year ORDER BY sales.year, sales.month"));
            }
        }

        private void drawChart(DataTable res)
        {
            foreach (var series in chart.Series)
            {
                series.Points.Clear();
            }

            string[] N = new string[res.Rows.Count];
            int[] M = new int[res.Rows.Count];
            for (int i = 0; i < res.Rows.Count; i++)
            {
                N[i] = res.Rows[i][1].ToString() + "/" + res.Rows[i][2].ToString();
                M[i] = Convert.ToInt32(res.Rows[i][0]);
            }
            chart.Series[0].Points.DataBindXY(N, M);
            chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        }
    }
}
