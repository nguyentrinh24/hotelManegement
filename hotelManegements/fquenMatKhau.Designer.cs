namespace hotelManegements
{
    partial class fquenMatKhau
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1_email = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1_matKhauMoi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Location = new System.Drawing.Point(211, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(384, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Lấy Mật Khẩu Ngay";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(319, 263);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(276, 29);
            this.textBox1.TabIndex = 1;
            // 
            // label1_email
            // 
            this.label1_email.AutoSize = true;
            this.label1_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1_email.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1_email.Location = new System.Drawing.Point(206, 267);
            this.label1_email.Name = "label1_email";
            this.label1_email.Size = new System.Drawing.Size(65, 22);
            this.label1_email.TabIndex = 2;
            this.label1_email.Text = "Email:";
            this.label1_email.Click += new System.EventHandler(this.label1_maID_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::hotelManegements.Properties.Resources.pngtree_company_employee_avatar_icon_wearing_a_suit_png_image_6133899;
            this.pictureBox1.Location = new System.Drawing.Point(211, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(384, 226);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1_matKhauMoi
            // 
            this.label1_matKhauMoi.AutoSize = true;
            this.label1_matKhauMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1_matKhauMoi.Location = new System.Drawing.Point(207, 317);
            this.label1_matKhauMoi.Name = "label1_matKhauMoi";
            this.label1_matKhauMoi.Size = new System.Drawing.Size(100, 22);
            this.label1_matKhauMoi.TabIndex = 4;
            this.label1_matKhauMoi.Text = "Mật Khẩu:";
            // 
            // fquenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1_matKhauMoi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1_email);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "fquenMatKhau";
            this.Text = "fquenMatKhau";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1_email;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1_matKhauMoi;
    }
}