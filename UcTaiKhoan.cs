using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDVSC
{
    public partial class UcTaiKhoan : UserControl
    {

        public event EventHandler<string> TenDangNhapChanged;
        string connectionString = "server=localhost;database=QuanLySuaChua1;uid=root;pwd=123456789;";
        public UcTaiKhoan()
        {
            InitializeComponent();
        }
        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {
            // Gửi sự kiện khi tên đăng nhập thay đổi
            TenDangNhapChanged?.Invoke(this, txtHo_ten.Text);
        }
        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0)
            {
                pictureBox1.Image = Image.FromFile(files[0]);
            }
        }

        private void btnSelectPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            
            FormMatKhau frmDoiMatKhau = new FormMatKhau(txtUssername.Text);
            
            frmDoiMatKhau.ShowDialog();
        }

        private void UcTaiKhoan_Load(object sender, EventArgs e)
        {
            string username = FormDangNhap.LoggedInUser.TenTaiKhoan; // Lấy tên đăng nhập từ biến toàn cục

            // Truy vấn cơ sở dữ liệu để lấy thông tin tài khoản dựa trên tên đăng nhập
            
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM NhanVien WHERE Ten_dang_nhap = @tenDangNhap";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@tenDangNhap", username); // Truyền tên đăng nhập vào câu lệnh SQL

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtHo_ten.Text = reader["Ho_ten"].ToString();
                    txtVai_tro.Text = reader["Vai_tro"].ToString();
                    txtUssername.Text = reader["Ten_dang_nhap"].ToString();
                    txtPasswword.Text = reader["Mat_khau"].ToString();
                    // Cập nhật các thông tin khác nếu cần
                }
                reader.Close();
            }
        }

    }
    
}
