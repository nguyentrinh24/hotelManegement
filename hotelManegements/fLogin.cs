using System;
using System.Drawing;
using System.Windows.Forms;

namespace hotelManegements
{
    public partial class frmLogin : Form
    {
        private string accountPlaceholder = "Nhập tài khoản";
        private string passwordPlaceholder = "Nhập mật khẩu";

        public frmLogin()
        {
            InitializeComponent();

            txAccount.Enter += TextBox_Enter;
            txAccount.Leave += TextBox_Leave;
            txAccount.Text = accountPlaceholder;
            txAccount.ForeColor = SystemColors.GrayText;

            txPassWord.Enter += TextBox_Enter;
            txPassWord.Leave += TextBox_Leave;
            txPassWord.Text = passwordPlaceholder;
            txPassWord.ForeColor = SystemColors.GrayText;
            txPassWord.PasswordChar = '\0';
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (textBox.Text == accountPlaceholder || textBox.Text == passwordPlaceholder)
            {
                textBox.Text = "";
                textBox.ForeColor = SystemColors.WindowText;

                if (textBox == txPassWord)
                {
                    txPassWord.PasswordChar = '*';
                }
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                if (textBox == txAccount)
                {
                    textBox.Text = accountPlaceholder;
                }
                else if (textBox == txPassWord)
                {
                    textBox.Text = passwordPlaceholder;
                    txPassWord.PasswordChar = '\0';
                }

                textBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_dangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fDangKy dangKy = new fDangKy();
            dangKy.ShowDialog();
        }

        private void linkLabel1__LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fquenMatKhau quenMatKhau = new fquenMatKhau();
            quenMatKhau.ShowDialog();
        }





        Modify modify = new Modify();
        private void frmDangNhap_Click(object sender, EventArgs e)
        {
            string tenTaiKhoan = txAccount.Text;
            string matKhau = txPassWord.Text;
            if (tenTaiKhoan.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản ");
            }
            else if (matKhau.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu  ");
            }
            else
            {
                string query = "Select * from taiKhoan where tenDangNhap = '" + tenTaiKhoan + "' and matKhau= '" + matKhau + "'  ";
                if (modify.taiKhoans(query).Count != 0)
                {
                    MessageBox.Show("Đăng nhập thành công ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    fMain fMain = new fMain();
                    fMain.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void linkLabel1_dangKy_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fDangKy dangKy = new fDangKy();
            dangKy.ShowDialog();
        }
    }
}
