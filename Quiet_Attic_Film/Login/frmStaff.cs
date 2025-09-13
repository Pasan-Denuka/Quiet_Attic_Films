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
    public partial class frmStaff : Form
    {
        public frmStaff()
        {
            InitializeComponent();
        }
        SqlDataAdapter sqlda = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NNVO0OT;Initial Catalog=Quiet_Attic;Integrated Security=True");
        string gen;
        private void cmbStID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbStID.SelectedIndex > 0)
                {
                    string StNo = cmbStID.SelectedItem.ToString();
                    string questNo = "SELECT * FROM Staff WHERE StaffID='" + StNo + "'";
                    conn.Open();
                    cmd = new SqlCommand(questNo, conn);
                    SqlDataReader r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        txtSName.Text = r.GetValue(1).ToString();
                        gen = r.GetValue(2).ToString();
                        if (gen.Equals("M")) { rbnMale.Checked = true; }
                        else if (gen.Equals("F")) { rbnFemale.Checked = true; }
                        txtEmail.Text = r.GetValue(3).ToString();
                        txtConNo.Text = r.GetValue(4).ToString();
                        cmbStTID.SelectedItem = r.GetValue(5).ToString();
                    }
                    conn.Close();
                }
                else
                {
                    txtSName.Text = "";
                    rbnFemale.Checked = false;
                    rbnMale.Checked = false;
                    txtConNo.Text = "";
                    txtEmail.Text = "";
                    cmbStTID.SelectedItem = 0;
                }
            }
            catch (Exception DataErr)
            {
                MessageBox.Show("Error Wile Loading Production Details..." + Environment.NewLine + DataErr);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string STID = cmbStID.SelectedIndex.ToString();
                string queSel = "SELECT StaffID FROM Staff";
                conn.Open();
                sqlda = new SqlDataAdapter(queSel, conn);
                DataTable DaTb = new DataTable();
                sqlda.Fill(DaTb);
                cmbStID.Items.Clear();
                cmbStID.Items.Add("---SELECT---");
                foreach (DataRow row in DaTb.Rows)
                {
                    cmbStID.Items.Add(row["StaffID"]);
                }
                cmbStID.SelectedIndex = 0;
                conn.Close();
                txtStID.Visible = false;
                cmbStID.Visible = true;
                btnReg.Visible = false;
                btnUp.Visible = true;
                btnDel.Visible = true;
            }
            catch (Exception SearchErr)
            {
                MessageBox.Show("Error While Loading IDs from the Data Table..." + Environment.NewLine + SearchErr);
            }
        }
        private void makanna()
        {
            txtStID.Text = "";
            txtSName.Text = "";
            rbnFemale.Checked = false;
            rbnMale.Checked = false;
            txtConNo.Text = "";
            txtEmail.Text = "";
            cmbStTID.SelectedIndex = 0;
            cmbStID.SelectedIndex = 0;
            txtStID.Visible = true;
            cmbStID.Visible = false;
            btnReg.Visible = true;
            btnUp.Visible = false;
            btnDel.Visible = false;
            txtStID.Focus();

        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            try
            {
                cmbStID.Items.Clear();
                conn.Open();
                string getStID = "SELECT StaffID FROM Staff ORDER BY StaffID";
                sqlda = new SqlDataAdapter(getStID, conn);
                DataTable DTtb = new DataTable();
                sqlda.Fill(DTtb);
                conn.Close();
                cmbStID.Items.Add("---SELECT---");
                foreach (DataRow row in DTtb.Rows)
                {
                    cmbStID.Items.Add(row["StaffID"]);
                }
                cmbStID.SelectedIndex = 0;
                cmbStTID.Items.Clear();
                conn.Open();
                string getType = "SELECT StaTID FROM StaffType ORDER BY StaTID";
                sqlda = new SqlDataAdapter(getType, conn);
                DataTable DTcid = new DataTable();
                sqlda.Fill(DTcid);
                conn.Close();
                cmbStTID.Items.Add("---SELECT---");
                foreach (DataRow row in DTcid.Rows)
                {
                    cmbStTID.Items.Add(row["StaTID"]);
                }
                cmbStTID.SelectedIndex = 0;
            }
            catch (Exception AdErr)
            {
                MessageBox.Show("Error While Loading Staff Data" + Environment.NewLine + AdErr);
            }
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbnMale.Checked == true) { gen = "M"; }
                else if (rbnFemale.Checked == true) { gen = "F"; }
                string Tid = cmbStTID.ToString();
                string quereg = "INSERT INTO Staff VALUES('" + txtStID.Text + "','"+ txtSName.Text + "','" + gen + "','" + txtEmail.Text + "','" + txtConNo.Text +"','" + Tid + "'";
                conn.Open();
                cmd = new SqlCommand(quereg, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Staff ID: " + txtStID.Text + " Have successfully registered!", "Register!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                makanna();
            }
            catch (Exception RegErr)
            {
                MessageBox.Show("Error while Register..." + Environment.NewLine + RegErr);
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbnMale.Checked == true) { gen = "M"; }
                else if (rbnFemale.Checked == true) { gen = "F"; }
                string UpQue = "UPDATE Staff SET SName='" + txtSName.Text + "',Gender'" + gen + "',Email='" + txtEmail.Text + "',ConNo='" + txtConNo.Text + "',STpID='" + cmbStTID.SelectedIndex + "'WHERE S_ID ='" + cmbStID.SelectedItem + "'";
                conn.Open();
                cmd = new SqlCommand(UpQue, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Staff ID: " + cmbStID.Text + " details have updated successfully!", "Update!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string Sid = cmbStID.SelectedItem.ToString();
                DialogResult DelReg = MessageBox.Show("Are you sure you want to delete Staff ID: " + Sid + " from the database ??? ", "Delete Confirmation !!!", MessageBoxButtons.YesNo,  MessageBoxIcon.Question);
                if (DelReg == DialogResult.Yes)
                {
                    string queDel = "DELETE FROM Staff WHERE StaffID='" + Sid + "'";
                    conn.Open();
                    cmd = new SqlCommand(queDel, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Staff ID: " + Sid + " Details deleted Successfully!","Delete!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            DialogResult reaEx = MessageBox.Show("Are you sure, you want to Exit?", "Exit!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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

        private void btnCl_Click(object sender, EventArgs e)
        {
            makanna();
        }

        private void btnStType_Click(object sender, EventArgs e)
        {
            frmStaffType frm = new frmStaffType();
            frm.Show();
            this.Hide();
        }
    }
}
