namespace QLDVSC
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private bool AuthenticateUser(string username, string password)
        {
            // Kiểm tra thông tin đăng nhập tạm thời 
            // Trong thực tế, thay bằng truy vấn database
            return username == "admin" && password == "12345";
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Kiểm tra thông tin đăng nhập 
            if (AuthenticateUser(username, password))
            {
                //MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
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
    }
}
