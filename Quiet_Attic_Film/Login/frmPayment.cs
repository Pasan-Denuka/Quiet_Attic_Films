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
    public partial class frmPayment : Form
    {
        public frmPayment()
        {
            InitializeComponent();
        }
        SqlDataAdapter sqlda = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NNVO0OT;Initial Catalog=Quiet_Attic;Integrated Security=True");

        private void frmPayment_Load(object sender, EventArgs e)
        {
            try
            {
                cmbInvNo.Items.Clear();
                conn.Open();
                string getInvoiceNo = "SELECT InvoiceNo FROM Payment ORDER BY InvoiceNo";
                sqlda = new SqlDataAdapter(getInvoiceNo, conn);
                DataTable DTtb = new DataTable();
                sqlda.Fill(DTtb);
                conn.Close();
                cmbInvNo.Items.Add("---SELECT---");
                foreach (DataRow row in DTtb.Rows)
                {
                    cmbInvNo.Items.Add(row["InvoiceNo"]);
                }
                cmbInvNo.SelectedIndex = 0;
                cmbProdID.Items.Clear();
                conn.Open();
                string getProID = "SELECT ProdID FROM Production ORDER BY ProdID";
                sqlda = new SqlDataAdapter(getProID, conn);
                DataTable DTcd = new DataTable();
                sqlda.Fill(DTcd);
                conn.Close();
                cmbProdID.Items.Add("---SELECT---");
                foreach (DataRow row in DTcd.Rows)
                {
                    cmbProdID.Items.Add(row["ProdID"]);
                }
                cmbProdID.SelectedIndex = 0;
            }
            catch (Exception AddErr)
            {
                MessageBox.Show("Error While Loading Production Data" + Environment.NewLine + AddErr);
            }
        }

        private void cmbInvNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbInvNo.SelectedIndex > 0)
                {
                    string InNo = cmbInvNo.SelectedItem.ToString();
                    string queInNo = "SELECT * FROM Payment WHERE InvoiceNo='" + InNo + "'";
                    conn.Open();
                    cmd = new SqlCommand(queInNo, conn);
                    SqlDataReader r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        txtAmount.Text = r.GetValue(1).ToString();
                        dtpDate.Text = r.GetValue(2).ToString();
                        cmbPMethod.SelectedItem = r.GetValue(3).ToString();
                        cmbProdID.SelectedItem = r.GetValue(4).ToString();
                    }
                    conn.Close();
                }
                else
                {
                    txtAmount.Text = "";
                    dtpDate.Text = "";
                    cmbPMethod.SelectedItem = 0;
                    cmbProdID.SelectedItem = 0;
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
                string queSel = "SELECT InvoiceNo FROM Payment";
                conn.Open();
                sqlda = new SqlDataAdapter(queSel, conn);
                DataTable DaTb = new DataTable();
                sqlda.Fill(DaTb);
                cmbInvNo.Items.Clear();
                cmbInvNo.Items.Add("---SELECT---");
                foreach (DataRow row in DaTb.Rows)
                {
                    cmbInvNo.Items.Add(row["InvoiceNo"]);
                }
                cmbInvNo.SelectedIndex = 0;
                conn.Close();
                txtInvNo.Visible = false;
                cmbInvNo.Visible = true;
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
            txtInvNo.Text = "";
            cmbInvNo.SelectedItem = "---SELECT---";
            txtAmount.Text = "";
            cmbPMethod.SelectedIndex = 0;
            cmbProdID.SelectedIndex = 0;
            txtInvNo.Visible = true;
            cmbInvNo.Visible = false;
            btnReg.Visible = true;
            btnUp.Visible = false;
            btnDel.Visible = false;
            txtInvNo.Focus();

        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            try
            {
                 
                double amou;
                amou = double.Parse(txtAmount.Text);
                string queAdd = "INSERT INTO Payment VALUES ('" + txtInvNo.Text + "','" + amou + "','" + dtpDate.Text + "','" + cmbPMethod.SelectedItem + "','" + cmbProdID.SelectedItem + "')";
                conn.Open();
                cmd = new SqlCommand(queAdd, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Invoice No: " + txtInvNo.Text + " have successfully added to the Database!", "Payment!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                makanna();
            }
            catch (Exception AddErr)
            {
                MessageBox.Show("Error While Add Production..." + Environment.NewLine + AddErr);
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            try
            {
                string UpQue = "UPDATE Payment SET Amount='" + txtAmount.Text + "',PayDate='" + dtpDate.Text + "',Method='" + cmbPMethod.SelectedItem + "',PdID='" + cmbProdID.SelectedItem + "'WHERE InvoiceNo = '" + cmbInvNo.SelectedItem + "'";
                conn.Open();
                cmd = new SqlCommand(UpQue, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Invoice No: " + cmbInvNo.Text + " details have updated successfully!", "Update!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string Invoi = cmbInvNo.SelectedItem.ToString();
                DialogResult DelQue = MessageBox.Show("Are you sure you want to delete this Record ??? ", "Delete Record !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DelQue == DialogResult.Yes)
                {
                    string queDel = "DELETE FROM Payment WHERE InvoiceNo='" + Invoi + "'";
                    conn.Open();
                    cmd = new SqlCommand(queDel, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Invoice No: " + Invoi + " Details deleted Successfully!", "Delete!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    makanna();

                }
            }
            catch (Exception DelErr)
            {
                MessageBox.Show("Error while delete" + Environment.NewLine + DelErr);

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

        private void btnProduction_Click(object sender, EventArgs e)
        {
            frmProduction frm = new frmProduction();
            frm.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult reslogout = MessageBox.Show("Are you sure you want to logout from the system ??? ", "Logout !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (reslogout == DialogResult.Yes)
            {
                frmLogin login = new frmLogin();
                login.Show();
                this.Hide();

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult resEx = MessageBox.Show("Are you sure, you want to Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resEx == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
