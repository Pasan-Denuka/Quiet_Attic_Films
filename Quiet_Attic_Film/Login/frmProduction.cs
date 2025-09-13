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
    public partial class frmProduction : Form
    {
        public frmProduction()
        {
            InitializeComponent();
        }
        SqlDataAdapter sqlda = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NNVO0OT;Initial Catalog=Quiet_Attic;Integrated Security=True");
        private void frmProduction_Load(object sender, EventArgs e)
        {
            try
            {
                cmbPrdID.Items.Clear();
                conn.Open();
                string getProdID = "SELECT ProdID FROM Production ORDER BY ProdID";
                sqlda = new SqlDataAdapter(getProdID, conn);
                DataTable DTtb = new DataTable();
                sqlda.Fill(DTtb);
                conn.Close();
                cmbPrdID.Items.Add("---SELECT---");
                foreach (DataRow row in DTtb.Rows)
                {
                    cmbPrdID.Items.Add(row["ProdID"]);
                }
                cmbPrdID.SelectedIndex = 0;
                cmbClID.Items.Clear();
                conn.Open();
                string getClient = "SELECT ClID FROM Client ORDER BY ClID";
                sqlda = new SqlDataAdapter(getClient, conn);
                DataTable DTcid = new DataTable();
                sqlda.Fill(DTcid);
                conn.Close();
                cmbClID.Items.Add("---SELECT---");
                foreach (DataRow row in DTcid.Rows)
                {
                    cmbClID.Items.Add(row["ClID"]);
                }
                cmbClID.SelectedIndex = 0;
            }
            catch (Exception AdErr)
            {
                MessageBox.Show("Error While Loading Production Data" + Environment.NewLine + AdErr);
            }

        }

        private void cmbPrdID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbPrdID.SelectedIndex > 0)
                {
                    string PROID = cmbPrdID.SelectedItem.ToString();
                    string queProID = "SELECT * FROM Production WHERE ProdID='" + PROID + "'";
                    conn.Open();
                    cmd = new SqlCommand(queProID, conn);
                    SqlDataReader r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        txtPrdName.Text = r.GetValue(1).ToString();
                        txtPrdType.Text = r.GetValue(2).ToString();
                        txtPrdDur.Text = r.GetValue(3).ToString();
                        txtBud.Text = r.GetValue(4).ToString();
                        txtLoc.Text = r.GetValue(5).ToString();
                        cmbClID.SelectedItem = r.GetValue(6).ToString();
                    }
                    conn.Close();
                }
                else
                {
                    txtPrdName.Text = "";
                    txtPrdType.Text = "";
                    txtPrdDur.Text = "";
                    txtBud.Text = "";
                    txtLoc.Text = "";
                    cmbClID.SelectedItem = "--SELECT--";

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
                string ProID = cmbPrdID.SelectedItem.ToString();
                string queSel = "SELECT ProdID FROM Production";
                conn.Open();
                sqlda = new SqlDataAdapter(queSel, conn);
                DataTable DaTb = new DataTable();
                sqlda.Fill(DaTb);
                cmbPrdID.Items.Clear();
                cmbPrdID.Items.Add("---SELECT---");
                foreach (DataRow row in DaTb.Rows)
                {
                    cmbPrdID.Items.Add(row["ProdID"]);
                }
                cmbPrdID.SelectedIndex = 0;
                conn.Close();
                txtPrdID.Visible = false;
                cmbPrdID.Visible = true;
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
            txtPrdID.Text = "";
            cmbPrdID.SelectedIndex = 0;
            txtPrdName.Text = "";
            txtPrdType.Text = "";
            txtPrdDur.Text = "";
            txtBud.Text = "";
            cmbClID.SelectedIndex = 0;
            txtLoc.Text = "";
            txtPrdID.Visible = true;
            cmbPrdID.Visible = false;
            btnReg.Visible = true;
            btnUp.Visible = false;
            btnDel.Visible = false;
            txtPrdID.Focus();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            try
            {
                string queReg = "INSERT INTO Production VALUES ('" + txtPrdID.Text + "','" + txtPrdName.Text + "','" + txtPrdType.Text + "','" + txtPrdDur.Text + "','" + txtBud.Text + "','" + txtLoc.Text + "','" + cmbClID.SelectedItem + "')";
                conn.Open();
                cmd = new SqlCommand(queReg, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Production: " + txtPrdID.Text + " have successfully added to the Database!", "Production!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                makanna();

            }
            catch (Exception RegErr)
            {
                MessageBox.Show("Error While Add Production..." + Environment.NewLine + RegErr);
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            try
            {
                string Up = "UPDATE Production SET ProdName='" + txtPrdName.Text + "',ProdType='" + txtPrdType.Text + "',ProdDuration='" + txtPrdDur.Text + "',Budget='" + txtBud.Text + "',Location='" + txtLoc.Text + "',CliID='" + cmbClID.SelectedItem + "'WHERE ProdID='" + cmbPrdID.SelectedItem + "'";
                conn.Open();
                cmd = new SqlCommand(Up, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Production ID: " + cmbPrdID.Text + " details have updated successfully!", "Update!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string prod = cmbPrdID.SelectedItem.ToString();
                DialogResult DelQue = MessageBox.Show("Are you sure you want to delete this Record ??? ", "Delete Record!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DelQue == DialogResult.Yes)
                {
                    string queDel = "DELETE FROM Production WHERE ProdID='" + prod +"'";
                    conn.Open();
                    cmd = new SqlCommand(queDel, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Production ID: " + prod + " Details deleted Successfully!", "Delete!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    makanna();
                }
            }
            catch (Exception DelErr)
            {
                MessageBox.Show("Error while delete" + Environment.NewLine + DelErr);
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
            DialogResult reslogout = MessageBox.Show("Are you sure you want to logout from the system? ", "Logout!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (reslogout == DialogResult.Yes)
            {
                frmLogin login = new frmLogin();
                login.Show();
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

        private void btnPayment_Click(object sender, EventArgs e)
        {
            frmPayment frm = new frmPayment();
            frm.Show();
            this.Hide();
        }

        private void cmbClID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
