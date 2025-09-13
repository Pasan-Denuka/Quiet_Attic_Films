using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login
{
    public partial class frmStaffType : Form
    {
        public frmStaffType()
        {
            InitializeComponent();
        }
        SqlDataAdapter sqlda = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NNVO0OT;Initial Catalog=Quiet_Attic;Integrated Security=True");
        private void frmStaffType_Load(object sender, EventArgs e)
        {
            try
            {
                cmbStTID.Items.Clear();
                conn.Open();
                string getSTID = "SELECT StaTID FROM StaffType ORDER BY StaTID";
                sqlda = new SqlDataAdapter(getSTID, conn);
                DataTable datb = new DataTable();
                sqlda.Fill(datb);
                conn.Close();
                cmbStTID.Items.Add("--SELECT--");
                foreach (DataRow row in datb.Rows)
                {
                    cmbStTID.Items.Add(row["StaTID"]);
                }
                cmbStTID.SelectedIndex = 0;
            }
            catch (Exception DataErr)
            {
                MessageBox.Show("Error while loading Client data" + Environment.NewLine + DataErr);
            }
        }

        private void cmbStTID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbStTID.SelectedIndex > 0)
                {
                    string STID = cmbStTID.SelectedItem.ToString();
                    string queGetSTID = "SELECT * FROM StaffType WHERE StaTID='" + STID + "'";
                    conn.Open();
                    cmd = new SqlCommand(queGetSTID, conn);
                    SqlDataReader r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        txtSTName.Text = r.GetValue(1).ToString();
                        txtBSal.Text = r.GetString(2).ToString();
                    }
                    conn.Close();
                }
                else
                {
                    txtSTName.Text = "";
                    txtBSal.Text = "";
                }

            }
            catch (Exception DataErr)
            {
                MessageBox.Show("Error while loading Client Details..." + Environment.NewLine + DataErr);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string stID = cmbStTID.SelectedItem.ToString();
                string queSel = "SELECT StaTID FROM StaffType";
                conn.Open();
                sqlda = new SqlDataAdapter(queSel, conn);
                DataTable IDdt = new DataTable();
                sqlda.Fill(IDdt);
                cmbStTID.Items.Clear();
                cmbStTID.Items.Add("---SELECT---");
                foreach (DataRow row in IDdt.Rows)
                {
                    cmbStTID.Items.Add(row["StaTID"]);
                }
                cmbStTID.SelectedIndex = 0;
                conn.Close();
                txtStTID.Visible = false;
                cmbStTID.Visible = true;
                btnReg.Visible = false;
                btnUp.Visible = true;
                btnDel.Visible = true;
            }
            catch (Exception SearchErr)
            {
                MessageBox.Show("Error While loading IDs from the Data Table..." + Environment.NewLine + SearchErr);
            }

        }
        private void makanna()
        {
            txtStTID.Text = "";
            cmbStTID.SelectedIndex = 0;
            txtSTName.Text = "";
            txtBSal.Text = "";
            txtStTID.Visible = true;
            cmbStTID.Visible = false;
            btnReg.Visible = true;
            btnDel.Visible = false;
            btnUp.Visible = false;
            txtStTID.Focus();

        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            try
            {
                string queAdd = "INSERT INTO StaffType VALUES('" + txtStTID.Text + "','" + txtSTName.Text + "','" + txtBSal.Text + "')";
                conn.Open();
                cmd = new SqlCommand(queAdd, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Staff Type ID: " + txtStTID.Text + " have successfully Register!","Register StaffType!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                makanna();
            }
            catch (Exception regErr)
            {
                MessageBox.Show("Error while Register..." + Environment.NewLine + regErr);
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            try
            {
                string UpQue = "UPDATE StaffType SET StaTName='" + txtSTName.Text + "',SalaryScale='" + txtBSal.Text + "'WHERE StaTID='" + cmbStTID.SelectedItem + "'";
                conn.Open();
                cmd = new SqlCommand(UpQue, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Staff Type ID: " + cmbStTID.SelectedIndex + " details have  updated successfully!", "Update!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                makanna();
            }
            catch (Exception UpErr)
            {
                MessageBox.Show("Error While Update..." + Environment.NewLine + UpErr);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                string StID = cmbStTID.SelectedItem.ToString();
                DialogResult DelReg = MessageBox.Show("Are you sure you want to delete  Staff Type ID: " + StID + "from the database ??? ", "Delete Confirmation !!!",  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DelReg == DialogResult.Yes)
                {
                    string queDel = "DELETE FROM StaffType WHERE StaTID='" + StID + "'";
                    conn.Open();
                    cmd = new SqlCommand(queDel, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Staff Type ID :" + StID + " Details deleted Successfully!", "Delete!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    makanna();
                }
            }
            catch (Exception DelErr)
            {
                MessageBox.Show("Error while Delete..." + Environment.NewLine + DelErr);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult reaEx = MessageBox.Show("Are you sure, you want to Exit?","Exit!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (reaEx == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult reslogout = MessageBox.Show("Are you sure you want to logout from the system ??? ", "Logout !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (reslogout == DialogResult.Yes)
            {
                frmLogin frm = new frmLogin();
                frm.Show();
                this.Hide();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Main_Menu frm = new Main_Menu();
            frm.Show();
            this.Hide();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            frmStaff frm = new frmStaff();
            frm.Show();
            this.Hide();
        }

        private void btnCl_Click(object sender, EventArgs e)
        {
            makanna();
        }
    }
}
