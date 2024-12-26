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
    public partial class FormSuaTinhTrang : Form
    {
        public FormSuaTinhTrang()
        {
            InitializeComponent();
        }

        private void btnLuuThongTin_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ TextBox và ComboBox
            string idPhieuSuaChua = txtIDPhieuSuaChua.Text.Trim();
            string tinhTrangMoi = txtTinhTrangMoi.Text.Trim();

            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrEmpty(idPhieuSuaChua) || string.IsNullOrEmpty(tinhTrangMoi))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
                return;
            }

            // Kết nối đến cơ sở dữ liệu
            string connectionString = "server=localhost;database=QuanLySuaChua1;uid=root;pwd=123456789;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Cập nhật tình trạng phiếu sửa chữa
                    string query = "UPDATE PhieuSuaChua SET Tinh_trang = @TinhTrang WHERE ID_phieu_sua_chua = @ID";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TinhTrang", tinhTrangMoi);
                    cmd.Parameters.AddWithValue("@ID", idPhieuSuaChua);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cập nhật tình trạng thành công!", "Thông báo");
                        this.Close(); // Đóng form
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy ID phiếu sửa chữa!", "Thông báo");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật: " + ex.Message, "Lỗi");
                }
            }
        }

        private void txtHuy_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng form
        }

        
    }
}
