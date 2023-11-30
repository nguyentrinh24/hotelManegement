using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace hotelManegements
{
    public partial class fDangKy : Form
    {
        // Lưu trữ placeholder cho các ô
        private string accountPlaceholder = "Nhập tài khoản";
        private string idPlaceholder = "Nhập email nhân viên";
        private string passwordPlaceholder = "Nhập mật khẩu";
        private string confirmPasswordPlaceholder = "Nhập lại mật khẩu";

        public fDangKy()
        {
            InitializeComponent();

            // Thiết lập sự kiện cho ô tài khoản
            textBox1_tendangnhap.Enter += TextBox_Enter;
            textBox1_tendangnhap.Leave += TextBox_Leave;
            textBox1_tendangnhap.Text = accountPlaceholder;
            textBox1_tendangnhap.ForeColor = SystemColors.GrayText;

            // Thiết lập sự kiện cho ô mã ID nhân viên
            textBox2_email.Enter += TextBox_Enter;
            textBox2_email.Leave += TextBox_Leave;
            textBox2_email.Text = idPlaceholder;
            textBox2_email.ForeColor = SystemColors.GrayText;

            // Thiết lập sự kiện cho ô mật khẩu
            textBox3_matkhau.Enter += TextBox_Enter;
            textBox3_matkhau.Leave += TextBox_Leave;
            textBox3_matkhau.Text = passwordPlaceholder;
            textBox3_matkhau.ForeColor = SystemColors.GrayText;
            textBox3_matkhau.UseSystemPasswordChar = false;

            // Thiết lập sự kiện cho ô nhập lại mật khẩu
            textBox4_nhapmatkhau.Enter += TextBox_Enter;
            textBox4_nhapmatkhau.Leave += TextBox_Leave;
            textBox4_nhapmatkhau.Text = confirmPasswordPlaceholder;
            textBox4_nhapmatkhau.ForeColor = SystemColors.GrayText;
            textBox4_nhapmatkhau.UseSystemPasswordChar = false;
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textBox = (TextBox)sender;

            // Xóa văn bản placeholder khi ô được tập trung
            if (textBox.Text == accountPlaceholder ||
                textBox.Text == idPlaceholder ||
                textBox.Text == passwordPlaceholder ||
                textBox.Text == confirmPasswordPlaceholder)
            {
                textBox.Text = "";
                textBox.ForeColor = SystemColors.WindowText;

                // Nếu là ô mật khẩu hoặc nhập lại mật khẩu, ẩn ký tự
                if (textBox == textBox3_matkhau || textBox == textBox4_nhapmatkhau)
                {
                    textBox.UseSystemPasswordChar = true;
                }
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;


            // Thiết lập văn bản placeholder khi ô không còn được tập trung và không có văn bản
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                if (textBox == textBox1_tendangnhap)
                {
                    textBox.Text = accountPlaceholder;
                }
                else if (textBox == textBox2_email)
                {
                    textBox.Text = idPlaceholder;
                }
                else if (textBox == textBox3_matkhau)
                {
                    textBox.Text = passwordPlaceholder;
                    textBox3_matkhau.UseSystemPasswordChar = false; // Hiển thị văn bản trong ô mật khẩu khi là placeholder
                }
                else if (textBox == textBox4_nhapmatkhau)
                {
                    textBox.Text = confirmPasswordPlaceholder;
                    textBox4_nhapmatkhau.UseSystemPasswordChar = false; // Hiển thị văn bản trong ô nhập lại mật khẩu khi là placeholder
                }

                textBox.ForeColor = SystemColors.GrayText;
            }
        }
        

        // check tai khoan, mat khau, emal
        // Hàm kiểm tra tính hợp lệ của tài khoản sử dụng regex
        private bool checkAccount(string account)
        {
            // Chỉ cho phép ký tự chữ và số (0-9, a-z, A-Z)
            string pattern = @"^[a-zA-Z0-9]{5,20}$";
            return Regex.IsMatch(account, pattern);
        }

        // Hàm kiểm tra tính hợp lệ của mật khẩu sử dụng regex
        private bool checkPassword(string password)
        {
            // Chỉ cho phép ký tự chữ và số (0-9, a-z, A-Z)
            string pattern = @"^[a-zA-Z0-9]{8,}$";
            return Regex.IsMatch(password, pattern);
        }

        // Hàm kiểm tra tính hợp lệ của email sử dụng regex
        private bool checkEmail(string email)
        {
            // This regex pattern is more comprehensive for validating email addresses
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }



        // Các sự kiện khác của form
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Xử lý sự kiện TextChanged cho textBox1 nếu cần
        }


        Modify modify = new Modify();
        private void button1_dangki_Click(object sender, EventArgs e)
        {
            string tenTaiKhoan = textBox1_tendangnhap.Text;
            string email = textBox2_email.Text;
            string matKhau = textBox3_matkhau.Text;
            string xacNhanMatKhau = textBox4_nhapmatkhau.Text;

            // Kiểm tra tính hợp lệ của tài khoản, mật khẩu và email trước khi tiến hành đăng ký
            if (!checkAccount(tenTaiKhoan))
            {
                MessageBox.Show("Tài khoản không hợp lệ");
                return;
            }

            if (!checkPassword(matKhau))
            {
                MessageBox.Show("Mật khẩu không hợp lệ (ít nhất 8 ký tự)");
                return;
            }

            if (!checkEmail(email))
            {
                MessageBox.Show("Email không hợp lệ");
                return;
            }

            // Kiểm tra tính hợp lệ của việc nhập lại mật khẩu
            if (matKhau != xacNhanMatKhau)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp");
                return;
            }

            //kiem tra email
            if (modify.taiKhoans("Select * from taiKhoan where email ='" + email + "'").Count != 0)
            {
                MessageBox.Show("Email này đã tồn tại");
                return;
            }

            try
            {
                string query = "Insert into taiKhoan values ('" + tenTaiKhoan + "','" + matKhau + "','" + email + "')";
                modify.commands(query);
                if(MessageBox.Show("Đăng ký thành công!Bạn có muốn đăng nhập không?", "Thông báo ",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
                {
                    this.Close();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }


        }
    }
}
