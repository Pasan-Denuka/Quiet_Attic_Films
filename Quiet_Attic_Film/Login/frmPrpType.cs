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
    public partial class frmPrpType : Form
    {
        public frmPrpType()
        {
            InitializeComponent();
        }
        SqlDataAdapter sqlda = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NNVO0OT;Initial Catalog=Quiet_Attic;Integrated Security=True");
        private void frmPrpType_Load(object sender, EventArgs e)
        {
            try
            {
                cmbPrTID.Items.Clear();
                conn.Open();
                string getPID = "SELECT PropTID FROM PropertyType ORDER BY PropTID";
                sqlda = new SqlDataAdapter(getPID, conn);
                DataTable datb = new DataTable();
                sqlda.Fill(datb);
                conn.Close();
                cmbPrTID.Items.Add("--SELECT--");
                foreach (DataRow row in datb.Rows)
                {
                    cmbPrTID.Items.Add(row["PropTID"]);
                }
                cmbPrTID.SelectedIndex = 0;
            }
            catch (Exception DataErr)
            {
                MessageBox.Show("Error while loading Client data" + Environment.NewLine + DataErr);
            }

        }

        private void cmbPrTID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbPrTID.SelectedIndex > 0)
                {
                    string PTID = cmbPrTID.SelectedItem.ToString();
                    string queGetPTID = "SELECT * FROM PropertyType WHERE PropTID='" + PTID + "'";
                    conn.Open();
                    cmd = new SqlCommand(queGetPTID, conn);
                    SqlDataReader r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        txtPrTName.Text = r.GetValue(1).ToString();
                        txtCost.Text = r.GetValue(2).ToString();
                    }
                    conn.Close();
                }
                else
                {
                    txtPrTName.Text = "";
                    txtCost.Text = "";
                }
            }
            catch (Exception DataErr)
            {
                MessageBox.Show("Error while loading PropertyType Details..." + Environment.NewLine + DataErr);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string PTid = cmbPrTID.SelectedItem.ToString();
                string queSel = "SELECT PropTID FROM PropertyType";
                conn.Open();
                sqlda = new SqlDataAdapter(queSel, conn);
                DataTable IDdt = new DataTable();
                sqlda.Fill(IDdt);
                cmbPrTID.Items.Clear();
                cmbPrTID.Items.Add("---SELECT---");
                foreach (DataRow row in IDdt.Rows)
                {
                    cmbPrTID.Items.Add(row["PropTID"]);
                }
                cmbPrTID.SelectedIndex = 0;
                conn.Close();
                txtPrTID.Visible = false;
                cmbPrTID.Visible = true;
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
            txtPrTID.Text = "";
            txtPrTName.Text = "";
            txtCost.Text = "";
            cmbPrTID.SelectedIndex = 0;
            txtPrTID.Visible = true;
            cmbPrTID.Visible = false;
            btnReg.Visible = true;
            btnDel.Visible = false;
            btnUp.Visible = false;
            txtPrTID.Focus();
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

        private void btnProp_Click(object sender, EventArgs e)
        {
            frmProperties frm = new frmProperties();
            frm.Show();
            this.Hide();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            try
            {
                string queAdd = "INSERT INTO PropertyType VALUES('" + txtPrTID.Text + "','" + txtPrTName.Text + "','" + txtCost.Text + "')";
                conn.Open();
                cmd = new SqlCommand(queAdd, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Property Type ID: " + txtPrTID.Text + " have successfully Added!", "Save!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string UpQue = "UPDATE PropertyType SET PropTName='" + txtPrTName.Text + "',Cost='" + txtCost.Text + "'WHERE Pt_ID='" + cmbPrTID.SelectedItem + "'";
                conn.Open();
                cmd = new SqlCommand(UpQue, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Propert Type ID: " + cmbPrTID.Text + " details have updated successfully!", "Update!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string PtID = cmbPrTID.SelectedItem.ToString();
                DialogResult DelAdd = MessageBox.Show("Are you sure you want to delete Propert Type ID: " +PtID + " from the database ??? ", "Delete Confirmation !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DelAdd == DialogResult.Yes)
                {
                    string queDel = "DELETE FROM PropertyType WHERE PropTID='" + PtID + "'";
                    conn.Open();
                    cmd = new SqlCommand(queDel, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("property Type ID: " + PtID + " Details deleted Successfully!", "Delete!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
