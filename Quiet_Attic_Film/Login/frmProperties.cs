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
    public partial class frmProperties : Form
    {
        public frmProperties()
        {
            InitializeComponent();
        }
        SqlDataAdapter sqlda = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NNVO0OT;Initial Catalog=Quiet_Attic;Integrated Security=True");
        private void frmProperties_Load(object sender, EventArgs e)
        {
            try
            {
                cmbPrID.Items.Clear();
                conn.Open();
                string getPropID = "SELECT PropID FROM Properties ORDER BY PropID";
                sqlda = new SqlDataAdapter(getPropID, conn);
                DataTable DTtb = new DataTable();
                sqlda.Fill(DTtb);
                conn.Close();
                cmbPrID.Items.Add("---SELECT---");
                foreach (DataRow row in DTtb.Rows)
                {
                    cmbPrID.Items.Add(row["PropID"]);
                }
                cmbPrID.SelectedIndex = 0;
                cmbPrTID.Items.Clear();
                conn.Open();
                string getProID = "SELECT PropTID FROM PropertyType ORDER BY PropTID";
                sqlda = new SqlDataAdapter(getProID, conn);
                DataTable DTcd = new DataTable();
                sqlda.Fill(DTcd);
                conn.Close();
                cmbPrTID.Items.Add("---SELECT---");
                foreach (DataRow row in DTcd.Rows)
                {
                    cmbPrTID.Items.Add(row["PropTID"]);
                }
                cmbPrTID.SelectedIndex = 0;
            }
            catch (Exception AddErr)
            {
                MessageBox.Show("Error While Loading Production Data" + Environment.NewLine + AddErr);
            }
        }

        private void cmbPrID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbPrID.SelectedIndex > 0)
                {
                    string PTID = cmbPrID.SelectedItem.ToString();
                    string queGetPTID = "SELECT * FROM Properties WHERE PropID='" + PTID + "'";
                    conn.Open();
                    cmd = new SqlCommand(queGetPTID, conn);
                    SqlDataReader r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        txtPName.Text = r.GetValue(1).ToString();
                        cmbPrTID.SelectedItem = r.GetString(2).ToString();
                    }
                    conn.Close();
                }
                else
                {
                    txtPName.Text = "";
                    cmbPrTID.SelectedItem = 0;
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
                string pID = cmbPrID.SelectedItem.ToString();
                string queSel = "SELECT PropID FROM Properties";
                conn.Open();
                sqlda = new SqlDataAdapter(queSel, conn);
                DataTable IDdt = new DataTable();
                sqlda.Fill(IDdt);
                cmbPrID.Items.Clear();
                cmbPrID.Items.Add("---SELECT---");
                foreach (DataRow row in IDdt.Rows)
                {
                    cmbPrID.Items.Add(row["PropID"]);
                }
                cmbPrID.SelectedIndex = 0;
                conn.Close();
                txtPrID.Visible = false;
                cmbPrID.Visible = true;
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
            txtPrID.Text = "";
            cmbPrID.SelectedIndex = 0;
            txtPName.Text = "";
            cmbPrTID.SelectedIndex = 0;
            txtPrID.Visible = true;
            cmbPrID.Visible = false;
            btnReg.Visible = true;
            btnUp.Visible = false;
            btnDel.Visible = false;
            txtPrID.Focus();

        }

        private void btnCl_Click(object sender, EventArgs e)
        {
            makanna();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Main_Menu frm = new Main_Menu();
            frm.Show();
            this.Hide();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            try
            {
                string queAdd = "INSERT INTO Properties VALUES('" + txtPrID.Text + "','" + txtPName.Text + "','" + cmbPrTID.SelectedItem + "')";
                conn.Open();
                cmd = new SqlCommand(queAdd, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Property ID: " + txtPrID.Text + " have successfully  Added to the Database!", "Add Property!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                makanna();
            }
            catch (Exception AddErr)
            {
                MessageBox.Show("Error while Register..." + Environment.NewLine + AddErr);
            }

        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            try
            {
                string UpQue = "UPDATE Properties SET PropName='" + txtPName.Text + "',PrTID='" + cmbPrTID.SelectedIndex.ToString() + "'WHERE PropID='" + cmbPrID.SelectedItem.ToString() + "'";
                conn.Open();
                cmd = new SqlCommand(UpQue, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Prperty ID: " + cmbPrID.SelectedIndex.ToString() + " details have updated successfully!", "Update!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string PID = cmbPrID.SelectedItem.ToString();
                DialogResult DelProp = MessageBox.Show("Are you sure you want to delete Propert ID: " + PID + " from the database ??? ", "Delete Confirmation !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DelProp == DialogResult.Yes)
                {
                    string queDel = "DELETE FROM Properties WHERE PropID='" + PID + "'";
                    conn.Open();
                    cmd = new SqlCommand(queDel, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Property ID: " + PID + " Details deleted Successfully!", "Delete!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnPropT_Click(object sender, EventArgs e)
        {
            frmPrpType frm = new frmPrpType();
            frm.Show();
            this.Hide();
        }
    }
}
