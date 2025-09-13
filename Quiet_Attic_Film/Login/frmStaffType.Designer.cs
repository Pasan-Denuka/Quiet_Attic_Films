namespace Login
{
    partial class frmStaffType
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStaffType));
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnCl = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.txtBSal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSTName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbStTID = new System.Windows.Forms.ComboBox();
            this.txtStTID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.PictureBox();
            this.btnStaff = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.Location = new System.Drawing.Point(12, 385);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(90, 33);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "LogOut";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnCl
            // 
            this.btnCl.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCl.Location = new System.Drawing.Point(609, 348);
            this.btnCl.Name = "btnCl";
            this.btnCl.Size = new System.Drawing.Size(90, 30);
            this.btnCl.TabIndex = 4;
            this.btnCl.Text = "Clear";
            this.btnCl.UseVisualStyleBackColor = false;
            this.btnCl.Click += new System.EventHandler(this.btnCl_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDel.Location = new System.Drawing.Point(469, 350);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(90, 30);
            this.btnDel.TabIndex = 8;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Visible = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnUp.Location = new System.Drawing.Point(340, 348);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(90, 30);
            this.btnUp.TabIndex = 7;
            this.btnUp.Text = "Update";
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Visible = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnReg
            // 
            this.btnReg.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnReg.Location = new System.Drawing.Point(469, 348);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(90, 32);
            this.btnReg.TabIndex = 3;
            this.btnReg.Text = "Register";
            this.btnReg.UseVisualStyleBackColor = false;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // txtBSal
            // 
            this.txtBSal.Location = new System.Drawing.Point(252, 276);
            this.txtBSal.MaxLength = 10;
            this.txtBSal.Name = "txtBSal";
            this.txtBSal.Size = new System.Drawing.Size(296, 30);
            this.txtBSal.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(203, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 22);
            this.label7.TabIndex = 58;
            this.label7.Text = "Basic Salary:";
            // 
            // txtSTName
            // 
            this.txtSTName.Location = new System.Drawing.Point(252, 184);
            this.txtSTName.Name = "txtSTName";
            this.txtSTName.Size = new System.Drawing.Size(296, 30);
            this.txtSTName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 22);
            this.label3.TabIndex = 50;
            this.label3.Text = "Staff Type Name:";
            // 
            // cmbStTID
            // 
            this.cmbStTID.FormattingEnabled = true;
            this.cmbStTID.Location = new System.Drawing.Point(252, 97);
            this.cmbStTID.Name = "cmbStTID";
            this.cmbStTID.Size = new System.Drawing.Size(296, 30);
            this.cmbStTID.TabIndex = 59;
            this.cmbStTID.Visible = false;
            this.cmbStTID.SelectedIndexChanged += new System.EventHandler(this.cmbStTID_SelectedIndexChanged);
            // 
            // txtStTID
            // 
            this.txtStTID.Location = new System.Drawing.Point(252, 97);
            this.txtStTID.Name = "txtStTID";
            this.txtStTID.Size = new System.Drawing.Size(296, 30);
            this.txtStTID.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 22);
            this.label2.TabIndex = 48;
            this.label2.Text = "Staff Type ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(179, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 32);
            this.label1.TabIndex = 46;
            this.label1.Text = "Staff Type";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(609, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 34);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.btnStaff);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 462);
            this.panel1.TabIndex = 44;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.Image = global::Login.Properties.Resources.Awicons_Vista_Artistic_Search_256;
            this.btnSearch.Location = new System.Drawing.Point(591, 83);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(72, 58);
            this.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSearch.TabIndex = 62;
            this.btnSearch.TabStop = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.Image = global::Login.Properties.Resources.Aha_Soft_People_Engineer_256;
            this.btnStaff.Location = new System.Drawing.Point(38, 157);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(82, 73);
            this.btnStaff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnStaff.TabIndex = 25;
            this.btnStaff.TabStop = false;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Image = global::Login.Properties.Resources.Icojam_Blue_Bits_Arrow_left_256;
            this.btnBack.Location = new System.Drawing.Point(12, 11);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(74, 66);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBack.TabIndex = 24;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmStaffType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 462);
            this.ControlBox = false;
            this.Controls.Add(this.btnCl);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtBSal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSTName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbStTID);
            this.Controls.Add(this.txtStTID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmStaffType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiet attic Films";
            this.Load += new System.EventHandler(this.frmStaffType_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.PictureBox btnStaff;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnCl;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.PictureBox btnSearch;
        private System.Windows.Forms.TextBox txtBSal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSTName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbStTID;
        private System.Windows.Forms.TextBox txtStTID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
    }
}