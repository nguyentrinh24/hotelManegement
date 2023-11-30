using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace hotelManegements
{
    public partial class fquenMatKhau : Form
    {
        private Modify modify = new Modify();

        public fquenMatKhau()
        {
            InitializeComponent();
            label1_matKhauMoi.Text = "";

            // Subscribe to the KeyDown event when the form is loaded
            this.KeyDown += new KeyEventHandler(fquenMatKhau_KeyDown);
        }

        private void fquenMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the Enter key is pressed
            if (e.KeyCode == Keys.Enter)
            {
                // Trigger the button1_Click method
                button1_Click(sender, e);
            }
        }

        private void label1_maID_Click(object sender, EventArgs e)
        {
            // Whatever you want to do when label1_maID is clicked
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            if (email.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập email đăng ký");
            }
            else
            {
                string query = "SELECT * FROM taiKhoan WHERE email = '" + email + "'";
                var taiKhoanList = modify.taiKhoans(query);

                if (taiKhoanList.Count() != 0)
                {
                    label1_matKhauMoi.ForeColor = Color.BlueViolet;
                    label1_matKhauMoi.Text = "Mật khẩu: " + taiKhoanList[0].PassWord;
                }
                else
                {
                    label1_matKhauMoi.ForeColor = Color.Red;
                    label1_matKhauMoi.Text = "Email chưa được đăng ký!";
                }
            }
        }
    }
}
