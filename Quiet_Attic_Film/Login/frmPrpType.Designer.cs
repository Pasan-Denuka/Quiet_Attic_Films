namespace Login
{
    partial class frmPrpType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrpType));
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnCl = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrTName = new System.Windows.Forms.TextBox();
            this.btnUp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPrTID = new System.Windows.Forms.ComboBox();
            this.txtPrTID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.PictureBox();
            this.btnProp = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.Location = new System.Drawing.Point(12, 358);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(90, 33);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "LogOut";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnCl
            // 
            this.btnCl.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCl.Location = new System.Drawing.Point(618, 355);
            this.btnCl.Name = "btnCl";
            this.btnCl.Size = new System.Drawing.Size(102, 35);
            this.btnCl.TabIndex = 6;
            this.btnCl.Text = "Clear";
            this.btnCl.UseVisualStyleBackColor = false;
            this.btnCl.Click += new System.EventHandler(this.btnCl_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDel.Location = new System.Drawing.Point(504, 358);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(101, 35);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Visible = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnReg
            // 
            this.btnReg.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnReg.Location = new System.Drawing.Point(504, 358);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(98, 35);
            this.btnReg.TabIndex = 3;
            this.btnReg.Text = "Register";
            this.btnReg.UseVisualStyleBackColor = false;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(222, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 22);
            this.label7.TabIndex = 91;
            this.label7.Text = "Cost:";
            // 
            // txtPrTName
            // 
            this.txtPrTName.Location = new System.Drawing.Point(289, 200);
            this.txtPrTName.Name = "txtPrTName";
            this.txtPrTName.Size = new System.Drawing.Size(296, 30);
            this.txtPrTName.TabIndex = 1;
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnUp.Location = new System.Drawing.Point(390, 356);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(95, 35);
            this.btnUp.TabIndex = 4;
            this.btnUp.Text = "Update";
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Visible = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 22);
            this.label3.TabIndex = 90;
            this.label3.Text = "Property Type Name:";
            // 
            // cmbPrTID
            // 
            this.cmbPrTID.FormattingEnabled = true;
            this.cmbPrTID.Location = new System.Drawing.Point(289, 111);
            this.cmbPrTID.Name = "cmbPrTID";
            this.cmbPrTID.Size = new System.Drawing.Size(296, 30);
            this.cmbPrTID.TabIndex = 7;
            this.cmbPrTID.Visible = false;
            this.cmbPrTID.SelectedIndexChanged += new System.EventHandler(this.cmbPrTID_SelectedIndexChanged);
            // 
            // txtPrTID
            // 
            this.txtPrTID.Location = new System.Drawing.Point(289, 111);
            this.txtPrTID.Name = "txtPrTID";
            this.txtPrTID.Size = new System.Drawing.Size(296, 30);
            this.txtPrTID.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 22);
            this.label2.TabIndex = 89;
            this.label2.Text = "Property Type ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(190, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 32);
            this.label1.TabIndex = 88;
            this.label1.Text = "Property Type";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(630, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 34);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.btnProp);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 453);
            this.panel1.TabIndex = 87;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(309, 270);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(276, 30);
            this.txtCost.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.Image = global::Login.Properties.Resources.Awicons_Vista_Artistic_Search_256;
            this.btnSearch.Location = new System.Drawing.Point(623, 96);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(72, 58);
            this.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSearch.TabIndex = 92;
            this.btnSearch.TabStop = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnProp
            // 
            this.btnProp.Image = global::Login.Properties.Resources.Everaldo_Kids_Icons_Icons_128;
            this.btnProp.Location = new System.Drawing.Point(38, 157);
            this.btnProp.Name = "btnProp";
            this.btnProp.Size = new System.Drawing.Size(82, 73);
            this.btnProp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnProp.TabIndex = 25;
            this.btnProp.TabStop = false;
            this.btnProp.Click += new System.EventHandler(this.btnProp_Click);
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
            // frmPrpType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 453);
            this.ControlBox = false;
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.btnCl);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPrTName);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbPrTID);
            this.Controls.Add(this.txtPrTID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPrpType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiet Attic Films";
            this.Load += new System.EventHandler(this.frmPrpType_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox btnProp;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.Button btnCl;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrTName;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.PictureBox btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPrTID;
        private System.Windows.Forms.TextBox txtPrTID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCost;
    }
}