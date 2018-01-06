using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIProject
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            var ab = new aboutBox();
            ab.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void identifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var wc = new wine_color();
            wc.Show();
        }

        private void iIIdentifyPeriodsOfMaximMinimumInTermsOfSalesOfWineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ps = new periods_sale();
            ps.Show();
        }

        private void iVTheRecordOfMaximumMinimumInAPeriodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pr = new period_record();
            pr.Show();
        }
    }
}
