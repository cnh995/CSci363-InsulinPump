using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsulinPump
{
    public partial class frmReadingHistory : Form
    {
        public frmReadingHistory()
        {
            InitializeComponent();
            dataGridView1.Rows.Add(Convert.ToDateTime("12/6/2017").ToShortDateString(), Convert.ToDateTime("3:00 PM").ToShortTimeString(), Convert.ToInt32(110));
            dataGridView1.Rows.Add(Convert.ToDateTime("12/6/2017").ToShortDateString(), Convert.ToDateTime("3:30 PM").ToShortTimeString(), Convert.ToInt32(94));
            dataGridView1.Rows.Add(Convert.ToDateTime("12/6/2017").ToShortDateString(), Convert.ToDateTime("4:00 PM").ToShortTimeString(), Convert.ToInt32(83));
            dataGridView1.Rows.Add(Convert.ToDateTime("12/6/2017").ToShortDateString(), Convert.ToDateTime("4:30 PM").ToShortTimeString(), Convert.ToInt32(75));
            dataGridView1.Rows.Add(Convert.ToDateTime("12/6/2017").ToShortDateString(), Convert.ToDateTime("5:00 PM").ToShortTimeString(), Convert.ToInt32(120));
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain lfrmMain = new frmMain();
            lfrmMain.Show();
            lfrmMain.Location = this.Location;
            this.Hide();
        }
    }
}
