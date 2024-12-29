using MySql.Data.MySqlClient;

namespace QLDVSC
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        public static class LoggedInUser
        {
            public static string TenTaiKhoan { get; set; }
        }
        private string AuthenticateUser(string username, string password)
        {
            string connectionString = "server=localhost;database=QuanLySuaChua1;uid=root;pwd=123456789;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Truy vấn kiểm tra thông tin đăng nhập
                    string query = @"
                        SELECT Vai_tro 
                        FROM NhanVien 
                        WHERE Ten_dang_nhap = @Username AND Mat_khau = @Password";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        var role = cmd.ExecuteScalar();

                        if (role != null)
                        {
                            return role.ToString(); // Trả về vai trò nếu đăng nhập thành công
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi kiểm tra đăng nhập: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return null; // Trả về null nếu đăng nhập thất bại
        }


        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            string role = AuthenticateUser(username, password);

            if (role != null) // Đăng nhập thành công
            {
                // Lưu thông tin ghi nhớ nếu checkbox được chọn
                if (chkRememberMe.Checked)
                {
                    Properties.Settings.Default.RememberUsername = username;
                    Properties.Settings.Default.RememberPassword = password; // Lưu ý: nên mã hóa mật khẩu trước khi lưu
                    Properties.Settings.Default.IsRememberMeChecked = true;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    // Xóa thông tin đã lưu
                    Properties.Settings.Default.RememberUsername = string.Empty;
                    Properties.Settings.Default.RememberPassword = string.Empty;
                    Properties.Settings.Default.IsRememberMeChecked = false;
                    Properties.Settings.Default.Save();
                }
                LoggedInUser.TenTaiKhoan = username;
                // Mở form tương ứng với vai trò
                if (role == "Quản trị")
                {
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                }
                else if (role == "Nhân viên")
                {
                    MainForm2 mainForm2 = new MainForm2();
                    mainForm2.Show();
                }
                // Nếu đăng nhập thành công, lưu tên đăng nhập
                
                this.Hide(); // Ẩn form đăng nhập
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            // Tải thông tin từ Settings
            txtUsername.Text = Properties.Settings.Default.RememberUsername;
            txtPassword.Text = Properties.Settings.Default.RememberPassword;
            chkRememberMe.Checked = Properties.Settings.Default.IsRememberMeChecked;
        }
    }
}
