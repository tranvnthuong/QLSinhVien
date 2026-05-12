using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLSinhVien.Forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void lblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmRegister().ShowDialog();
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
                return;
            }

            try
            {
                var result = DB.Scalar("SELECT * FROM Users WHERE Username = @username AND PasswordHash = @password",
                    new SqlParameter("@username", username),
                    new SqlParameter("@password", Helper.PasswordHashing(password))
                );
                if (result != null)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu sai", "Thông báo");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Có lỗi xảy ra khi đăng nhập {ex}", "Thông báo");
            }
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
