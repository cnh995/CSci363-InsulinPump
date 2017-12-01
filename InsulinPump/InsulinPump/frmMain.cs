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
    public partial class frmMain : Form
    {
        public static int dosage;
        public static string doseDate;
        public static string doseTime;
        public static frmMain gfrmMain = new frmMain();

        public frmMain()
        {
            InitializeComponent();

            MessageBox.Show(dosage.ToString() + doseDate + doseTime);
        }

        private void btnScheduleDose_Click(object sender, EventArgs e)
        {
            frmScheduleDose lfrmScheduleDose = new frmScheduleDose();
            lfrmScheduleDose.Show();
            lfrmScheduleDose.Location = this.Location;
            this.Hide();
        }

        private void btnReadingHistory_Click(object sender, EventArgs e)
        {
            frmReadingHistory lfrmReadingHistory = new frmReadingHistory();
            lfrmReadingHistory.Show();
            lfrmReadingHistory.Location = this.Location;
            this.Hide();
        }
    }
}
