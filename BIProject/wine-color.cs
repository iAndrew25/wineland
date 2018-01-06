using System;
using System.Collections;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BIProject
{
    public partial class wine_color : Form
    {
        public OleDbConnection conn;

        public wine_color()
        {
            InitializeComponent();
        }

        public void ConnectToAccess()
        {
            DataTable results = new DataTable();
            conn = new OleDbConnection();

                conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data source= C:\Users\Andy\Desktop\BI\BIProject\WinesDatabase.accdb";
            try
            {
                conn.Open();
                displayData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to data source" + ex);
            }
        }

        private void displayData(String str = null) {
            String query = "";
            if(str == "All" || str == null) {
                query = "SELECT * FROM client_segments";
            } else {
                query = $"SELECT * FROM client_segments where sex = '{str}' order by age";
            }

            OleDbCommand cmd = new OleDbCommand(query, conn);
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            DataTable scores = new DataTable();
            adapter.Fill(scores);

            dataGridView1.DataSource = scores;
            drawChart(str);
        }

        private ArrayList getDataChart(String str = null) {
            String query = "";
            var listOfPreferences = new ArrayList();

            for(int i = 1; i <= 3; i++) {
                if (str == "All" || str == null) {
                    query = $"SELECT  color, Count(*) FROM((color inner join wines on color.[id_color] = wines.[id_color]) inner join client_segments on client_segments.[Preference{i}] = wines.[id_wine]) GROUP BY color;";
                } else {
                    query = $"SELECT  color, Count(*) FROM((color inner join wines on color.[id_color] = wines.[id_color]) inner join client_segments on client_segments.[Preference{i}] = wines.[id_wine]) where sex = '{str}' GROUP BY color;";
                }

                OleDbCommand cmd = new OleDbCommand(query, conn);
                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                DataTable result = new DataTable();
                adapter.Fill(result);

                listOfPreferences.Add(result);
            }

            return listOfPreferences;
        }

        private void drawChart(String str) {
            foreach (var series in chart.Series) {
                series.Points.Clear();
            }

            var res = getDataChart(str);
            int k = 0;

            foreach(DataTable dt in res) {
                string[] N = new string[dt.Rows.Count];
                int[] M = new int[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    N[i] = dt.Rows[i][0].ToString();
                    M[i] = Convert.ToInt32(dt.Rows[i][1]);
                }
                chart.Series[k].Points.DataBindXY(N, M);

                k++;
            }
        }

        private void wine_color_Load(object sender, EventArgs e) {
            ConnectToAccess();
            chart.Hide();
        }

        private void winesDatabaseDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void genderCbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayData(genderCbBox.Text);
        }

        private void chartBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Visible)
            {
                dataGridView1.Hide();
                chart.Show();
                chartBtn.Text = "Table";
            }
            else
            {
                dataGridView1.Show();
                chart.Hide();
                chartBtn.Text = "Chart";
            }
        }
    }
}
