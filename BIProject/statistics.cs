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
    public partial class statistics : Form
    {
        public OleDbConnection conn;
        public OleDbCommand cmd;
        public OleDbDataAdapter adapter;
        public DataTable result;

        public statistics()
        {
            InitializeComponent();
        }

        private void statistics_Load(object sender, EventArgs e)
        {
            ConnectToAccess();
        }

        public void ConnectToAccess()
        {
            conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data source= C:\Users\Andy\Desktop\BI\BIProject\WinesDatabase.accdb";

            try
            {
                conn.Open();
                populateWines();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to data source" + ex);
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

        private void populateWines()
        {
            foreach (DataRow row in getData("select * from wines order by wine_name").Rows)
            {
                comboBox1.Items.Add(row["wine_name"]);
            }
        }

        private void statWine_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idSelectedWine = getData($"SELECT id_wine FROM wines WHERE wine_name = '{comboBox1.Text}'").Rows[0][0];

            var dt = getData($"SELECT Preference1, Preference2, Preference3 FROM client_segments WHERE Preference1={idSelectedWine} or Preference2={idSelectedWine} or Preference3={idSelectedWine}");
            if(dt.Rows.Count == 0)
            {
                statWine.Text = "No record available";
                return;
            }
            List<DataRow> list = dt.AsEnumerable().ToList();
            var h = list.Select(x => x.ItemArray);
            var listOfValues = new List<String>();

            for (int i = 0; i < h.Count(); i++)
            {
                for(int j = 0; j < h.FirstOrDefault().Count(); j++)
                {
                    listOfValues.Add(h.ElementAt(i).ElementAt(j).ToString());
                }
            }

            var g = listOfValues.GroupBy(i => i);
            int popularOccurrence = 0;
            String idWine = "";
            foreach (var grp in g)
            {
                if(grp.Key.ToString() != idSelectedWine.ToString() && popularOccurrence < grp.Count())
                {
                    Console.WriteLine(grp.Count() + " - " + grp.Key);
                    popularOccurrence = grp.Count();
                    idWine = grp.Key;
                }
            }

            var wineName = getData($"SELECT wine_name FROM wines WHERE id_wine={idWine}").Rows[0][0];
            statWine.Text =  wineName.ToString();
        }
    }
}
