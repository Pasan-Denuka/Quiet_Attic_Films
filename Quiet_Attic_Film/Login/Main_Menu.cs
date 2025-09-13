using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult reaEx = MessageBox.Show("Are you sure, you want to Exit???","Exit!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (reaEx == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult reslogout = MessageBox.Show("Are you sure you want to logout from the system???", "Logout!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (reslogout == DialogResult.Yes)
            {
                frmLogin log = new frmLogin();
                log.Show();
                this.Hide();
            }
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            frmClient frm = new frmClient();
            frm.Show();
            this.Hide();
        }

        private void btnProduction_Click(object sender, EventArgs e)
        {
            frmProduction frm = new frmProduction();
            frm.Show();
            this.Hide();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            frmStaff frm = new frmStaff();
            frm.Show();
            this.Hide();
        }

        private void btnProperties_Click(object sender, EventArgs e)
        {
            frmProperties frm = new frmProperties();
            frm.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
