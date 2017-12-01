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
    public partial class frmScheduleDose : Form
    {
        public frmScheduleDose()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
            frmMain.gfrmMain.Show();
            frmMain.gfrmMain.Location = this.Location;
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            frmMain.dosage = Convert.ToInt32(nudDosage.Value);
            frmMain.doseDate = dtpDate.Text;
            frmMain.doseTime = dtpTime.Text;
        }
    }
}
