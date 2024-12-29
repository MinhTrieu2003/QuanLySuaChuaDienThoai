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
using static QLDVSC.FormDichVu;
using static QLDVSC.FormLinhKien;

namespace QLDVSC
{
    public partial class FormCapNhatDonHang : Form
    {
        private readonly int idPhieuSuaChua;
        private string connectionString = "server=localhost;database=QuanLySuaChua1;uid=root;pwd=123456789;";

        public FormCapNhatDonHang(int idPhieuSuaChua)
        {
            InitializeComponent();
            this.idPhieuSuaChua = idPhieuSuaChua;
        }

        private void FormCapNhatDonHang_Load(object sender, EventArgs e)
        {
            LoadTinhTrang();
            LoadDichVu();
            LoadLinhKien();
            TinhTongChiPhi();
        }

        // Load Tình Trạng
        private void LoadTinhTrang()
        {
            cbTinhTrang.Items.AddRange(new string[] { "Đang xử lý", "Đang sửa chữa", "Đã hoàn thành" });
            cbTinhTrang.SelectedIndex = 0;
        }

        // Load danh sách dịch vụ vào CheckedListBox
        private void LoadDichVu()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT ID_dich_vu, Ten_dich_vu FROM DichVu";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    clbDichVu.Items.Add(new { ID = reader["ID_dich_vu"], Name = reader["Ten_dich_vu"] }, false);
                }
            }
        }

        // Load danh sách linh kiện vào CheckedListBox
        private void LoadLinhKien()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT ID_linh_kien, Ten_linh_kien FROM LinhKien";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    clbLinhKien.Items.Add(new { ID = reader["ID_linh_kien"], Name = reader["Ten_linh_kien"] }, false);
                }
            }
        }

        // Tính tổng chi phí
        private void TinhTongChiPhi()
        {
            decimal tongChiPhi = 0;

            // Tính chi phí dịch vụ
            foreach (var item in clbDichVu.CheckedItems)
            {
                var idDichVu = ((dynamic)item).ID;
                tongChiPhi += LayGiaDichVu(idDichVu);
            }

            // Tính chi phí linh kiện
            foreach (var item in clbLinhKien.CheckedItems)
            {
                var idLinhKien = ((dynamic)item).ID;
                tongChiPhi += LayGiaLinhKien(idLinhKien);
            }

            txtTongTien.Text = tongChiPhi.ToString("N0");
        }

        private decimal LayGiaDichVu(int idDichVu)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT Gia FROM DichVu WHERE ID_dich_vu = @ID_dich_vu";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ID_dich_vu", idDichVu);
                connection.Open();
                var result = cmd.ExecuteScalar();
                return result != null ? Convert.ToDecimal(result) : 0;
            }
        }

        private decimal LayGiaLinhKien(int idLinhKien)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT Gia_ban FROM LinhKien WHERE ID_linh_kien = @ID_linh_kien";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ID_linh_kien", idLinhKien);
                connection.Open();
                var result = cmd.ExecuteScalar();
                return result != null ? Convert.ToDecimal(result) : 0;
            }
        }

        private void clbDichVu_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Tính lại tổng chi phí khi chọn dịch vụ
            this.BeginInvoke((MethodInvoker)TinhTongChiPhi);
        }

        private void clbLinhKien_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Tính lại tổng chi phí khi chọn linh kiện
            this.BeginInvoke((MethodInvoker)TinhTongChiPhi);
        }

        // Cập nhật đơn hàng
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Cập nhật trạng thái đơn hàng
                string updateTinhTrangQuery = "UPDATE PhieuSuaChua SET Tinh_trang = @Tinh_trang WHERE ID_phieu_sua_chua = @ID_phieu_sua_chua";
                MySqlCommand updateCmd = new MySqlCommand(updateTinhTrangQuery, connection);
                updateCmd.Parameters.AddWithValue("@Tinh_trang", cbTinhTrang.SelectedItem.ToString());
                updateCmd.Parameters.AddWithValue("@ID_phieu_sua_chua", idPhieuSuaChua);
                updateCmd.ExecuteNonQuery();

                // Xóa chi tiết sửa chữa cũ
                string deleteChiTietQuery = "DELETE FROM ChiTietSuaChua WHERE ID_phieu_sua_chua = @ID_phieu_sua_chua";
                MySqlCommand deleteCmd = new MySqlCommand(deleteChiTietQuery, connection);
                deleteCmd.Parameters.AddWithValue("@ID_phieu_sua_chua", idPhieuSuaChua);
                deleteCmd.ExecuteNonQuery();

                decimal tongChiPhi = 0;

                // Thêm chi tiết dịch vụ mới
                foreach (var item in clbDichVu.CheckedItems)
                {
                    var idDichVu = ((dynamic)item).ID;
                    decimal giaDichVu = LayGiaDichVu(idDichVu);
                    tongChiPhi += giaDichVu;

                    string insertDichVuQuery = "INSERT INTO ChiTietSuaChua (ID_phieu_sua_chua, ID_dich_vu, tong_chi_phi) VALUES (@ID_phieu_sua_chua, @ID_dich_vu, @tong_chi_phi)";
                    MySqlCommand insertDichVuCmd = new MySqlCommand(insertDichVuQuery, connection);
                    insertDichVuCmd.Parameters.AddWithValue("@ID_phieu_sua_chua", idPhieuSuaChua);
                    insertDichVuCmd.Parameters.AddWithValue("@ID_dich_vu", idDichVu);
                    insertDichVuCmd.Parameters.AddWithValue("@tong_chi_phi", giaDichVu);
                    insertDichVuCmd.ExecuteNonQuery();
                }

                // Thêm chi tiết linh kiện mới
                foreach (var item in clbLinhKien.CheckedItems)
                {
                    var idLinhKien = ((dynamic)item).ID;
                    decimal giaLinhKien = LayGiaLinhKien(idLinhKien);
                    tongChiPhi += giaLinhKien;

                    string insertLinhKienQuery = "INSERT INTO ChiTietSuaChua (ID_phieu_sua_chua, ID_linh_kien, tong_chi_phi) VALUES (@ID_phieu_sua_chua, @ID_linh_kien, @tong_chi_phi)";
                    MySqlCommand insertLinhKienCmd = new MySqlCommand(insertLinhKienQuery, connection);
                    insertLinhKienCmd.Parameters.AddWithValue("@ID_phieu_sua_chua", idPhieuSuaChua);
                    insertLinhKienCmd.Parameters.AddWithValue("@ID_linh_kien", idLinhKien);
                    insertLinhKienCmd.Parameters.AddWithValue("@tong_chi_phi", giaLinhKien);
                    insertLinhKienCmd.ExecuteNonQuery();
                }

                // Cập nhật tổng chi phí vào TextBox
                txtTongTien.Text = tongChiPhi.ToString("N0");
            }

            MessageBox.Show("Cập nhật đơn hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
