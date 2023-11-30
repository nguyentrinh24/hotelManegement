namespace hotelManegements
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.frmDangNhap = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txAccount = new System.Windows.Forms.TextBox();
            this.txPassWord = new System.Windows.Forms.TextBox();
            this.linkLabel1_dangKy = new System.Windows.Forms.LinkLabel();
            this.ptLogo = new System.Windows.Forms.PictureBox();
            this.linkLabel1_ = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // frmDangNhap
            // 
            this.frmDangNhap.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            resources.ApplyResources(this.frmDangNhap, "frmDangNhap");
            this.frmDangNhap.Name = "frmDangNhap";
            this.frmDangNhap.UseVisualStyleBackColor = false;
            this.frmDangNhap.Click += new System.EventHandler(this.frmDangNhap_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.ForeColor = System.Drawing.Color.Lime;
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::hotelManegements.Properties.Resources.tải_xuống;
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::hotelManegements.Properties.Resources.jw_marriott_ha_noi_30_1;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // txAccount
            // 
            resources.ApplyResources(this.txAccount, "txAccount");
            this.txAccount.Name = "txAccount";
            // 
            // txPassWord
            // 
            resources.ApplyResources(this.txPassWord, "txPassWord");
            this.txPassWord.Name = "txPassWord";
            // 
            // linkLabel1_dangKy
            // 
            resources.ApplyResources(this.linkLabel1_dangKy, "linkLabel1_dangKy");
            this.linkLabel1_dangKy.Name = "linkLabel1_dangKy";
            this.linkLabel1_dangKy.TabStop = true;
            this.linkLabel1_dangKy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_dangKy_LinkClicked_1);
            // 
            // ptLogo
            // 
            this.ptLogo.Image = global::hotelManegements.Properties.Resources.Welcome_Hotels_Logo_Ohne_Claim_jpg;
            resources.ApplyResources(this.ptLogo, "ptLogo");
            this.ptLogo.Name = "ptLogo";
            this.ptLogo.TabStop = false;
            // 
            // linkLabel1_
            // 
            resources.ApplyResources(this.linkLabel1_, "linkLabel1_");
            this.linkLabel1_.Name = "linkLabel1_";
            this.linkLabel1_.TabStop = true;
            this.linkLabel1_.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1__LinkClicked);
            // 
            // frmLogin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.linkLabel1_);
            this.Controls.Add(this.linkLabel1_dangKy);
            this.Controls.Add(this.txPassWord);
            this.Controls.Add(this.txAccount);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ptLogo);
            this.Controls.Add(this.frmDangNhap);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button frmDangNhap;
        private System.Windows.Forms.PictureBox ptLogo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txAccount;
        private System.Windows.Forms.TextBox txPassWord;
        private System.Windows.Forms.LinkLabel linkLabel1_dangKy;
        private System.Windows.Forms.LinkLabel linkLabel1_;
    }
}

