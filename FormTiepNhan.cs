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
    public partial class FormTiepNhan : Form

    {
        string connectionString = "server=localhost;port=3306;database=QuanLySuaChua1;uid=root;pwd=123456789";
        public int GetLastInsertedId(string tableName)
        {
            string query = $"SELECT LAST_INSERT_ID() FROM {tableName}";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lấy ID cuối cùng: " + ex.Message);
                return 0;
            }
            finally
            {
                connection.Close();
            }
        }

        public FormTiepNhan()
        {
            InitializeComponent();
        }
        private void FormTiepNhan_Load(object sender, EventArgs e)
        {
            LoadComboBoxData();
        }
        private void LoadComboBoxData()
        {
            // Load Tên Dịch Vụ vào ComboBox
            string queryDichVu = "SELECT Ten_dich_vu FROM DichVu";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand commandDichVu = new MySqlCommand(queryDichVu, connection);

            try
            {
                connection.Open();
                MySqlDataReader readerDichVu = commandDichVu.ExecuteReader();
                while (readerDichVu.Read())
                {
                    cbTenDichVu.Items.Add(readerDichVu["Ten_dich_vu"].ToString());
                }
                readerDichVu.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading services: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            // Load Tên Linh Kiện vào ComboBox
            string queryLinhKien = "SELECT Ten_linh_kien FROM LinhKien";
            MySqlCommand commandLinhKien = new MySqlCommand(queryLinhKien, connection);

            try
            {
                connection.Open();
                MySqlDataReader readerLinhKien = commandLinhKien.ExecuteReader();
                while (readerLinhKien.Read())
                {
                    cbTenLinhKien.Items.Add(readerLinhKien["Ten_linh_kien"].ToString());
                }
                readerLinhKien.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading parts: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // private void FormTiepNhan_Load(object sender, EventArgs e)
        //{

        //}

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void btnLuuPhieuTiepNhan_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                // Kiểm tra và thêm khách hàng
                int idKhachHang = 0;
                string sqlCheckKhachHang = "SELECT ID_khach_hang FROM KhachHang WHERE So_dien_thoai = @SoDienThoai";
                using (MySqlCommand cmd = new MySqlCommand(sqlCheckKhachHang, connection))
                {
                    cmd.Parameters.AddWithValue("@SoDienThoai", txtSoDienThoai.Text);
                    connection.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        idKhachHang = Convert.ToInt32(result);
                    }
                    connection.Close();
                }

                // Thêm khách hàng nếu chưa có
                if (idKhachHang == 0)
                {
                    string sqlInsertKhachHang = "INSERT INTO KhachHang (Ho_ten, So_dien_thoai) VALUES (@HoTen, @SoDienThoai)";
                    using (MySqlCommand cmd = new MySqlCommand(sqlInsertKhachHang, connection))
                    {
                        cmd.Parameters.AddWithValue("@HoTen", txtTenKhachHang.Text);
                        cmd.Parameters.AddWithValue("@SoDienThoai", txtSoDienThoai.Text);
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        idKhachHang = (int)cmd.LastInsertedId;
                        connection.Close();
                    }
                }

                // Thêm thiết bị mới
                int idThietBi = 0;
                string sqlInsertThietBi = "INSERT INTO ThietBi (Hang, Model) VALUES (@TenThietBi, '')";
                using (MySqlCommand cmd = new MySqlCommand(sqlInsertThietBi, connection))
                {
                    cmd.Parameters.AddWithValue("@TenThietBi", txtTenThietBi.Text);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    idThietBi = (int)cmd.LastInsertedId;
                    connection.Close();
                }

                // Thêm phiếu tiếp nhận
                string sqlInsertPhieuTiepNhan = "INSERT INTO PhieuTiepNhanThietBi (Ngay_tiep_nhan, ID_khach_hang, ID_thiet_bi, ID_nhan_vien) " +
                                                "VALUES (@NgayTiepNhan, @IDKhachHang, @IDThietBi, @IDNhanVien)";
                int idNhanVien = 0;
                string sqlGetNhanVienId = "SELECT ID_nhan_vien FROM NhanVien WHERE Ho_ten = @HoTen";
                using (MySqlCommand cmd = new MySqlCommand(sqlGetNhanVienId, connection))
                {
                    cmd.Parameters.AddWithValue("@HoTen", lbNhanVienSuaChua.Text);
                    connection.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        idNhanVien = Convert.ToInt32(result);
                    }
                    else
                    {
                        throw new Exception("Không tìm thấy nhân viên có tên: " + lbNhanVienSuaChua.Text);
                    }
                    connection.Close();
                }

                using (MySqlCommand cmd = new MySqlCommand(sqlInsertPhieuTiepNhan, connection))
                {
                    cmd.Parameters.AddWithValue("@NgayTiepNhan", dtpNgayTiepNhan.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@IDKhachHang", idKhachHang);
                    cmd.Parameters.AddWithValue("@IDThietBi", idThietBi);
                    cmd.Parameters.AddWithValue("@IDNhanVien", idNhanVien);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }

                // Lấy ID của phiếu tiếp nhận vừa tạo
                int idPhieuTiepNhan = GetLastInsertedId("PhieuTiepNhanThietBi");

                // Thêm phiếu sửa chữa
                string sqlInsertPhieuSuaChua = "INSERT INTO PhieuSuaChua (Ngay_tiep_nhan, Mo_ta_loi, Tinh_trang, ID_phieu_tiep_nhan) " +
                                               "VALUES (@NgayTiepNhan, @MoTaLoi, 'đang sửa', @IDPhieuTiepNhan)";
                using (MySqlCommand cmd = new MySqlCommand(sqlInsertPhieuSuaChua, connection))
                {
                    cmd.Parameters.AddWithValue("@NgayTiepNhan", dtpNgayTiepNhan.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@MoTaLoi", txtMoTaLoi.Text);
                    cmd.Parameters.AddWithValue("@IDPhieuTiepNhan", idPhieuTiepNhan);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }

                // Thêm chi tiết sửa chữa
                string sqlInsertChiTietSuaChua = "INSERT INTO ChiTietSuaChua (ID_phieu_sua_chua, ID_dich_vu, ID_linh_kien, So_luong_linh_kien_su_dung, Tong_chi_phi) " +
                                                 "VALUES (@IDPhieuSuaChua, @IDDichVu, @IDLinhKien, @SoLuong, @TongChiPhi)";
                int idPhieuSuaChua = GetLastInsertedId("PhieuSuaChua");
                int idDichVu = 0;
                string sqlGetDichVuId = "SELECT ID_dich_vu FROM DichVu WHERE Ten_dich_vu = @TenDichVu";
                using (MySqlCommand cmd = new MySqlCommand(sqlGetDichVuId, connection))
                {
                    cmd.Parameters.AddWithValue("@TenDichVu", cbTenDichVu.SelectedItem.ToString());
                    connection.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        idDichVu = Convert.ToInt32(result);
                    }
                    else
                    {
                        throw new Exception("Không tìm thấy dịch vụ: " + cbTenDichVu.SelectedItem.ToString());
                    }
                    connection.Close();
                }
                // Lấy ID_linh_kien từ tên linh kiện trong ComboBox
                int idLinhKien = 0;
                string sqlGetLinhKienId = "SELECT ID_linh_kien FROM LinhKien WHERE Ten_linh_kien = @TenLinhKien";
                using (MySqlCommand cmd = new MySqlCommand(sqlGetLinhKienId, connection))
                {
                    cmd.Parameters.AddWithValue("@TenLinhKien", cbTenLinhKien.SelectedItem.ToString());
                    connection.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        idLinhKien = Convert.ToInt32(result);
                    }
                    else
                    {
                        throw new Exception("Không tìm thấy linh kiện: " + cbTenLinhKien.SelectedItem.ToString());
                    }
                    connection.Close();
                }

                using (MySqlCommand cmd = new MySqlCommand(sqlInsertChiTietSuaChua, connection))
                {
                    cmd.Parameters.AddWithValue("@IDPhieuSuaChua", idPhieuSuaChua);
                    cmd.Parameters.AddWithValue("@IDDichVu", idDichVu); // Bạn cần lấy giá trị từ ComboBox
                    cmd.Parameters.AddWithValue("@IDLinhKien", idLinhKien); // Bạn cần lấy giá trị từ ComboBox
                    cmd.Parameters.AddWithValue("@SoLuong", Convert.ToInt32(txtSoLuongLinhKien.Text));
                    cmd.Parameters.AddWithValue("@TongChiPhi", txtGiaTien.Text);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }

                MessageBox.Show("Phiếu tiếp nhận đã được lưu thành công!",
       "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTenKhachHang_TextChanged(object sender, EventArgs e)
        {

        }
    }
}