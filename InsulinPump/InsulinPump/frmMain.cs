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
        public static int insulinRemaining;
        public static int bloodSugar;
        public static int batteryLevel;
        public static Boolean fromFrmScheduleDose = false;
        public static frmMain gfrmMain = new frmMain();

        public frmMain()
        {
            InitializeComponent();

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

        private void lowBatteryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your battery is low, please charge your device.", "Low Battery");
        }

        private void lowInsulinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your insulin cartridge is low, please refill your insulin.", "Low Insulin");
        }

        private void replaceNeedleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your needle must be replaced.", "Replace Needle");
        }

        private void highBloodSugarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your blood sugar is too high, please schedule an insulin dose.", "High Blood Sugar");
        }

        private void lowBloodSugarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your blood sugar is too low, please eat to increase your blood sugar.", "Low Blood Sugar");
        }

        private void disconnectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your device has disconnected, please reconnect or manually monitor your blood sugar.", "Device Disconnected");
        }

        private void insulinToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            if (fromFrmScheduleDose)
            {
                MessageBox.Show(dosage.ToString() + doseDate + doseTime);
                fromFrmScheduleDose = false;
            }
        }
    }
}
