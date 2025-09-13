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
    public partial class frmClient : Form
    {
        public frmClient()
        {
            InitializeComponent();
        }
        SqlDataAdapter sqlda = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NNVO0OT;Initial Catalog=Quiet_Attic;Integrated Security=True");
        string gen;

        private void frmClient_Load(object sender, EventArgs e)
        {
            try
            {
                cmbClID.Items.Clear();
                conn.Open();
                string getClID = "SELECT ClID FROM Client ORDER BY ClID";
                sqlda = new SqlDataAdapter(getClID, conn);
                DataTable datb = new DataTable();
                sqlda.Fill(datb);
                conn.Close();
                cmbClID.Items.Add("--SELECT--");
                foreach (DataRow row in datb.Rows)
                {
                    cmbClID.Items.Add(row["ClID"]);
                }
                cmbClID.SelectedIndex = 0;
            }
            catch (Exception DataErr)
            {
                MessageBox.Show("Error while loading Client data" +
               Environment.NewLine + DataErr);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string cid = cmbClID.SelectedItem.ToString();
                string queSel = "SELECT ClID FROM Client";
                conn.Open();
                sqlda = new SqlDataAdapter(queSel, conn);
                DataTable IDdt = new DataTable();
                sqlda.Fill(IDdt);
                cmbClID.Items.Clear();
                cmbClID.Items.Add("---SELECT---");
                foreach (DataRow row in IDdt.Rows)
                {
                    cmbClID.Items.Add(row["ClID"]);
                }
                cmbClID.SelectedIndex = 0;
                conn.Close();
                txtClID.Visible = false;
                cmbClID.Visible = true;
                btnReg.Visible = false;
                btnUp.Visible = true;
                btnDel.Visible = true;
            }
            catch (Exception SearchErr)
            {
                MessageBox.Show("Error While loading IDs from the Data Table..." +
               Environment.NewLine + SearchErr);
            }

        }
        private void makanna()
        {
            txtClID.Text = "";
            cmbClID.SelectedIndex = 0;
            txtClName.Text = "";
            rbnMale.Checked = false;
            rbnFemale.Checked = false;
            txtAdd.Text = "";
            txtConNo.Text = "";
            txtNIC.Text = "";
            txtEmail.Text = "";
            txtClID.Visible = true;
            cmbClID.Visible = false;
            btnReg.Visible = true;
            btnUp.Visible = false;
            btnDel.Visible = false;
            txtClID.Focus();
        }

        private void cmbClID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbClID.SelectedIndex > 0)
                {
                    string CID = cmbClID.SelectedItem.ToString();
                    string queGetCID = "SELECT* FROM Client WHERE ClID='" + CID +"'";
                    conn.Open();
                    cmd = new SqlCommand(queGetCID, conn);
                    SqlDataReader r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        txtClName.Text = r.GetValue(1).ToString();
                        dtpDOB.Text = r.GetValue(2).ToString();
                        txtConNo.Text = r.GetValue(3).ToString();
                        gen = r.GetValue(4).ToString();
                        if (gen.Equals("M")) { rbnMale.Checked = true; }
                        else if (gen.Equals("F")) { rbnFemale.Checked = true; }
                        txtNIC.Text = r.GetValue(5).ToString();
                        txtAdd.Text = r.GetValue(6).ToString();
                        txtEmail.Text = r.GetValue(7).ToString();       
                     }
                     conn.Close();
                }
                else
                {
                    txtClName.Text = "";
                    dtpDOB.Text = "";
                    rbnFemale.Checked = false;
                    rbnMale.Checked = false;
                    txtEmail.Text = "";
                    txtAdd.Text = "";
                    txtConNo.Text = "";
                    txtNIC.Text = "";
                }

            }
            catch (Exception DataErr)
            {
                MessageBox.Show("Error while loading Client Details..." +Environment.NewLine + DataErr);

            }

        }

        private void btnCl_Click(object sender, EventArgs e)
        {
            makanna();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbnMale.Checked == true) { gen = "M"; }
                else if (rbnFemale.Checked == true) { gen = "F"; }
                string quereg = "INSERT INTO Client VALUES('" + txtClID.Text +"','" + txtClName.Text + "','" + dtpDOB.Text + "','" + txtConNo.Text + "','" + gen + "','" + txtNIC.Text + "','" + txtAdd.Text + "','" + txtEmail.Text + "')";
                conn.Open();
                cmd = new SqlCommand(quereg, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Client: " + txtClID.Text + " have successfully Registered!", "Register!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                makanna();
            }
            catch (Exception RegErr)
            {
                MessageBox.Show("Error while Register..." + Environment.NewLine +RegErr);
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbnMale.Checked == true) { gen = "M"; }
                else if (rbnFemale.Checked == true) { gen = "F"; }
                string UpQue = "UPDATE Client SET ClName='" + txtClName.Text +"',DOB='" + dtpDOB.Text + "',ConNo='" + txtConNo.Text + "',Gender='" + gen +"', NIC='" + txtNIC.Text + "',CAddress='" + txtAdd.Text + "',Email='" +txtEmail.Text + "' WHERE ClID='" + cmbClID.SelectedItem + "'";
                conn.Open();
                cmd = new SqlCommand(UpQue, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Client: " + cmbClID.Text + " details have updated successfully!", "Update!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                makanna();
            }
            catch (Exception UpErr)
            {
                MessageBox.Show("Error While Update..." + Environment.NewLine +UpErr);
            }

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                string CID = cmbClID.SelectedItem.ToString();
                DialogResult DelReg = MessageBox.Show("Are you sure you want to delete Client: " + CID + " from the database??? ", "Delete Confirmation!!!", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (DelReg == DialogResult.Yes)
                {
                    string queDel = "DELETE FROM Client WHERE ClID='" + CID + "'";
                    conn.Open();
                    cmd = new SqlCommand(queDel, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Client: " + CID + " Details deleted Successfully!","Delete!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    makanna();
                }
            }
            catch (Exception DelErr)
            {
                MessageBox.Show("Error while Delete..." + Environment.NewLine +DelErr);
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Main_Menu frm = new Main_Menu();
            frm.Show();
            this.Hide();
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
            DialogResult resEx = MessageBox.Show("Are you sure you want to logout? ", "Logout!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resEx == DialogResult.Yes)
            {
                frmLogin frm = new frmLogin();
                frm.Show();
                this.Hide();
            }
        }
    }
}