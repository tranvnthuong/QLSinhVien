using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLSinhVien.Forms
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtPassword2.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu không trùng khớp", "Thông báo");
                return;
            }

            try
            {
                var exists = DB.Scalar($"SELECT * FROM Users WHERE Username = @username",
                    new SqlParameter("@username", username)
                );

                if (exists != null)
                {
                    MessageBox.Show("Tên tài bị trùng", "Thông báo");
                }
                else
                {
                    int result = DB.Execute("INSERT INTO Users (Username, PasswordHash, Role) VALUES (@username, @password, @role)",
                        new SqlParameter("@username", username),
                        new SqlParameter("@password", Helper.PasswordHashing(password)),
                        new SqlParameter("@role", "Giảng viên")
                    );
                    if (result > 0)
                    {
                        MessageBox.Show("Đăng ký tài khoản thành công", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Đăng ký tài khoản thất bại", "Thông báo");
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Có lỗi xảy ra khi đăng ký tài khoản {ex.Message}", "Thông báo");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
