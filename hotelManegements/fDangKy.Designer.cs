namespace hotelManegements
{
    partial class fDangKy
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1_tendangnhap = new System.Windows.Forms.TextBox();
            this.textBox2_email = new System.Windows.Forms.TextBox();
            this.textBox3_matkhau = new System.Windows.Forms.TextBox();
            this.textBox4_nhapmatkhau = new System.Windows.Forms.TextBox();
            this.button1_dangki = new System.Windows.Forms.Button();
            this.label1_dangky = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::hotelManegements.Properties.Resources.Welcome_Hotels_Logo_Ohne_Claim1;
            this.pictureBox1.Location = new System.Drawing.Point(231, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(366, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1_tendangnhap
            // 
            this.textBox1_tendangnhap.Location = new System.Drawing.Point(231, 263);
            this.textBox1_tendangnhap.Multiline = true;
            this.textBox1_tendangnhap.Name = "textBox1_tendangnhap";
            this.textBox1_tendangnhap.Size = new System.Drawing.Size(366, 35);
            this.textBox1_tendangnhap.TabIndex = 1;
            this.textBox1_tendangnhap.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2_email
            // 
            this.textBox2_email.Location = new System.Drawing.Point(231, 319);
            this.textBox2_email.Multiline = true;
            this.textBox2_email.Name = "textBox2_email";
            this.textBox2_email.Size = new System.Drawing.Size(366, 35);
            this.textBox2_email.TabIndex = 2;
            // 
            // textBox3_matkhau
            // 
            this.textBox3_matkhau.Location = new System.Drawing.Point(231, 370);
            this.textBox3_matkhau.Multiline = true;
            this.textBox3_matkhau.Name = "textBox3_matkhau";
            this.textBox3_matkhau.Size = new System.Drawing.Size(366, 35);
            this.textBox3_matkhau.TabIndex = 3;
            // 
            // textBox4_nhapmatkhau
            // 
            this.textBox4_nhapmatkhau.Location = new System.Drawing.Point(231, 419);
            this.textBox4_nhapmatkhau.Multiline = true;
            this.textBox4_nhapmatkhau.Name = "textBox4_nhapmatkhau";
            this.textBox4_nhapmatkhau.Size = new System.Drawing.Size(366, 35);
            this.textBox4_nhapmatkhau.TabIndex = 4;
            // 
            // button1_dangki
            // 
            this.button1_dangki.BackColor = System.Drawing.Color.White;
            this.button1_dangki.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1_dangki.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1_dangki.Location = new System.Drawing.Point(231, 490);
            this.button1_dangki.Name = "button1_dangki";
            this.button1_dangki.Size = new System.Drawing.Size(366, 49);
            this.button1_dangki.TabIndex = 5;
            this.button1_dangki.Text = "Đăng Ký";
            this.button1_dangki.UseVisualStyleBackColor = false;
            this.button1_dangki.Click += new System.EventHandler(this.button1_dangki_Click);
            // 
            // label1_dangky
            // 
            this.label1_dangky.AutoSize = true;
            this.label1_dangky.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1_dangky.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1_dangky.Location = new System.Drawing.Point(355, 209);
            this.label1_dangky.Name = "label1_dangky";
            this.label1_dangky.Size = new System.Drawing.Size(133, 29);
            this.label1_dangky.TabIndex = 6;
            this.label1_dangky.Text = "ĐĂNG KÝ ";
            // 
            // fDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 551);
            this.Controls.Add(this.label1_dangky);
            this.Controls.Add(this.button1_dangki);
            this.Controls.Add(this.textBox4_nhapmatkhau);
            this.Controls.Add(this.textBox3_matkhau);
            this.Controls.Add(this.textBox2_email);
            this.Controls.Add(this.textBox1_tendangnhap);
            this.Controls.Add(this.pictureBox1);
            this.Name = "fDangKy";
            this.Text = "fDangKy";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1_tendangnhap;
        private System.Windows.Forms.TextBox textBox2_email;
        private System.Windows.Forms.TextBox textBox3_matkhau;
        private System.Windows.Forms.TextBox textBox4_nhapmatkhau;
        private System.Windows.Forms.Button button1_dangki;
        private System.Windows.Forms.Label label1_dangky;
    }
}