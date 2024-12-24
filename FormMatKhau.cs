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
    public partial class FormMatKhau : Form
    {
        string connectionString = "server=localhost;database=QuanLySuaChua1;uid=root;pwd=123456789;charset=utf8;";
        public FormMatKhau(string tenDangNhap)
        {
            InitializeComponent();
            txtTenTaiKhoan.Text = tenDangNhap;
        }

        

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu
            if (string.IsNullOrEmpty(txtMatKhauCu.Text) ||
                string.IsNullOrEmpty(txtMatKhauMoi.Text) ||
                string.IsNullOrEmpty(txtXacNhanMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            if (txtMatKhauMoi.Text != txtXacNhanMatKhau.Text)
            {
                MessageBox.Show("Mật khẩu mới không trùng khớp.");
                return;
            }

            // Kiểm tra mật khẩu cũ (sử dụng MySQL)
            
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Kiểm tra mật khẩu cũ
                    using (MySqlCommand cmd = new MySqlCommand("SELECT Mat_khau FROM NhanVien WHERE Ten_dang_nhap = @TenTaiKhoan", conn))
                    {
                        cmd.Parameters.Add("@TenTaiKhoan", MySqlDbType.VarChar).Value = txtTenTaiKhoan.Text.Trim();

                        // Lấy mật khẩu cũ từ database
                        object result = cmd.ExecuteScalar();

                        // Kiểm tra xem mật khẩu cũ có tồn tại trong database không
                        if (result == null)
                        {
                            MessageBox.Show("Tên đăng nhập không tồn tại.");
                            return;
                        }

                        // So sánh mật khẩu
                        string matKhauCuTrongDB = result.ToString().Trim();
                        if (matKhauCuTrongDB != txtMatKhauCu.Text.Trim())
                        {
                            MessageBox.Show("Mật khẩu cũ không đúng.");
                            return;
                        }
                    }

                    // Cập nhật mật khẩu mới
                    using (MySqlCommand cmdUpdate = new MySqlCommand("UPDATE NhanVien SET Mat_khau = @MatKhauMoi WHERE Ten_dang_nhap = @TenTaiKhoan", conn))
                    {
                        cmdUpdate.Parameters.AddWithValue("@TenTaiKhoan", txtTenTaiKhoan.Text);
                        cmdUpdate.Parameters.AddWithValue("@MatKhauMoi", txtMatKhauMoi.Text);

                        int rowsAffected = cmdUpdate.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Đổi mật khẩu thành công.");
                        }
                        else
                        {
                            MessageBox.Show("Có lỗi khi cập nhật mật khẩu.");
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Lỗi kết nối đến cơ sở dữ liệu: " + ex.Message);
                }
                
            }
        }


    }
}
