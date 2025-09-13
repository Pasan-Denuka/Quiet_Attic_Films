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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void rbnShowPassword_CheckedChanged(object sender, EventArgs e)
        {
             
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult resEx = MessageBox.Show("Are you sure you want to Exit?","Exit!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resEx == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void CBShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (CBShowPassword.Checked == false)
            {
                txtPassword.PasswordChar = '*';
            }
            else
            {
                txtPassword.PasswordChar = default(char);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string un, pw;
            un = txtUName.Text;
            pw = txtPassword.Text;
            if (un == "admin" && pw == "quiet@123")
            {
                MessageBox.Show("Successfuly Login!", "Login!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Main_Menu main = new Main_Menu();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid email or password", "Login Fali!",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtUName.Text = "";
            txtPassword.Text = "";
            txtUName.Focus();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
