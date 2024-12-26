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
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Font;
using System.Diagnostics;

namespace QLDVSC
{
    public partial class UcTiepNhan : UserControl
    {
        public UcTiepNhan()
        {
            InitializeComponent();
        }

        private void btnTaoPhieuTiepNhan_Click(object sender, EventArgs e)
        {

        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user id=root;password=123456789;database=QuanLySuaChua1;";
            string query = @"SELECT 
                        ptn.ID_phieu_tiep_nhan AS 'ID Phiếu Tiếp Nhận',
                        ptn.Ngay_tiep_nhan AS 'Ngày Tiếp Nhận',
                        kh.Ho_ten AS 'Khách Hàng',
                        tb.Hang AS 'Hãng Thiết Bị',
                        tb.Model AS 'Model Thiết Bị',
                        nv.Ho_ten AS 'Nhân Viên Tiếp Nhận'
                    FROM PhieuTiepNhanThietBi ptn
                    INNER JOIN KhachHang kh ON ptn.ID_khach_hang = kh.ID_khach_hang
                    INNER JOIN ThietBi tb ON ptn.ID_thiet_bi = tb.ID_thiet_bi
                    INNER JOIN NhanVien nv ON ptn.ID_nhan_vien = nv.ID_nhan_vien";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Gán dữ liệu cho DataGridView
                    dgvPhieuTiepNhan.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSearchPhieuTiepNhan_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user id=root;password=123456789;database=QuanLySuaChua1;";
            string searchID = txtSearchPhieuTiepNhan.Text.Trim();

            // Kiểm tra ID hợp lệ
            if (string.IsNullOrEmpty(searchID) || !int.TryParse(searchID, out _))
            {
                MessageBox.Show("Vui lòng nhập ID hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = @"SELECT 
                        ptn.ID_phieu_tiep_nhan AS 'ID Phiếu Tiếp Nhận',
                        ptn.Ngay_tiep_nhan AS 'Ngày Tiếp Nhận',
                        kh.Ho_ten AS 'Khách Hàng',
                        tb.Hang AS 'Hãng Thiết Bị',
                        tb.Model AS 'Model Thiết Bị',
                        nv.Ho_ten AS 'Nhân Viên Tiếp Nhận'
                    FROM PhieuTiepNhanThietBi ptn
                    INNER JOIN KhachHang kh ON ptn.ID_khach_hang = kh.ID_khach_hang
                    INNER JOIN ThietBi tb ON ptn.ID_thiet_bi = tb.ID_thiet_bi
                    INNER JOIN NhanVien nv ON ptn.ID_nhan_vien = nv.ID_nhan_vien
                    WHERE ptn.ID_phieu_tiep_nhan = @SearchID";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@SearchID", searchID);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Gán dữ liệu cho DataGridView
                    dgvPhieuTiepNhan.DataSource = dataTable;

                    // Thông báo nếu không có kết quả
                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy phiếu tiếp nhận với ID này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXuatPhieuTiepNhan_Click(object sender, EventArgs e)
        {
            // Hiển thị dialog để nhập ID
            string inputID = Microsoft.VisualBasic.Interaction.InputBox(
                "Nhập ID Phiếu Tiếp Nhận cần xuất:",
                "Xuất Phiếu Tiếp Nhận",
                "",
                -1, -1);

            // Kiểm tra ID hợp lệ
            if (string.IsNullOrEmpty(inputID) || !int.TryParse(inputID, out int idPhieuTiepNhan))
            {
                MessageBox.Show("Vui lòng nhập ID hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kết nối MySQL và lấy dữ liệu
            string connectionString = "server=localhost;user id=root;password=123456789;database=QuanLySuaChua1;";
            string query = @"SELECT 
                    ptn.ID_phieu_tiep_nhan AS 'ID Phiếu',
                    ptn.Ngay_tiep_nhan AS 'Ngày Tiếp Nhận',
                    kh.Ho_ten AS 'Khách Hàng',
                    kh.So_dien_thoai AS 'Số Điện Thoại',
                    tb.Hang AS 'Hãng Thiết Bị',
                    tb.Model AS 'Model Thiết Bị',
                    nv.Ho_ten AS 'Nhân Viên Tiếp Nhận'
                FROM PhieuTiepNhanThietBi ptn
                INNER JOIN KhachHang kh ON ptn.ID_khach_hang = kh.ID_khach_hang
                INNER JOIN ThietBi tb ON ptn.ID_thiet_bi = tb.ID_thiet_bi
                INNER JOIN NhanVien nv ON ptn.ID_nhan_vien = nv.ID_nhan_vien
                WHERE ptn.ID_phieu_tiep_nhan = @IDPhieuTiepNhan";

            DataTable dataTable = new DataTable();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IDPhieuTiepNhan", idPhieuTiepNhan);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy phiếu tiếp nhận với ID này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi truy vấn dữ liệu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Xuất TXT
            string outputPath = $"PhieuTiepNhan_{idPhieuTiepNhan}.txt";
            try
            {
                // Mở file để ghi
                using (StreamWriter writer = new StreamWriter(outputPath))
                {
                    // Viết Tiêu đề
                    writer.WriteLine("=========================================");
                    writer.WriteLine("              PHIẾU TIẾP NHẬN");
                    writer.WriteLine("=========================================");
                    writer.WriteLine();

                    // Dữ liệu từ DataTable
                    DataRow row = dataTable.Rows[0];
                    writer.WriteLine($"ID Phiếu: {row["ID Phiếu"]}");
                    writer.WriteLine($"Ngày Tiếp Nhận: {row["Ngày Tiếp Nhận"]}");
                    writer.WriteLine($"Khách Hàng: {row["Khách Hàng"]}");
                    writer.WriteLine($"Số Điện Thoại: {row["Số Điện Thoại"]}");
                    writer.WriteLine($"Hãng Thiết Bị: {row["Hãng Thiết Bị"]}");
                    writer.WriteLine($"Model Thiết Bị: {row["Model Thiết Bị"]}");
                    writer.WriteLine($"Nhân Viên Tiếp Nhận: {row["Nhân Viên Tiếp Nhận"]}");
                    writer.WriteLine();
                    writer.WriteLine("=========================================");
                }

                MessageBox.Show($"Xuất TXT thành công! File đã lưu tại: {outputPath}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Mở file TXT bằng Notepad hoặc ứng dụng mặc định
                System.Diagnostics.Process.Start("notepad.exe", outputPath);  // Mở với Notepad
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất TXT: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine(ex.StackTrace); // Ghi log chi tiết lỗi ra console            
            }
        }

        private void txtSearchPhieuTiepNhan_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXoaPhieuTiepNhan_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox(
                "Nhập ID Phiếu Tiếp Nhận cần xóa:",
                "Xóa Phiếu Tiếp Nhận",
                "",
                -1,
                -1);
            string connectionString = "server=localhost;user id=root;password=123456789;database=QuanLySuaChua1;";


            if (!string.IsNullOrWhiteSpace(input) && int.TryParse(input, out int idPhieuTiepNhan))
            {
                MySqlConnection connection = new MySqlConnection(connectionString);

                try
                {
                    connection.Open();

                    // Xóa dữ liệu trong bảng HoaDon
                    string deleteHoaDon = @"
                DELETE FROM HoaDon
                WHERE ID_phieu_sua_chua IN (
                    SELECT ID_phieu_sua_chua 
                    FROM PhieuSuaChua 
                    WHERE ID_phieu_tiep_nhan = @IDPhieuTiepNhan)";
                    using (MySqlCommand cmd = new MySqlCommand(deleteHoaDon, connection))
                    {
                        cmd.Parameters.AddWithValue("@IDPhieuTiepNhan", idPhieuTiepNhan);
                        cmd.ExecuteNonQuery();
                    }

                    // Xóa dữ liệu trong bảng PhieuSuaChua_ThongTinLoi
                    string deletePhieuSuaChuaThongTinLoi = @"
                DELETE FROM PhieuSuaChua_ThongTinLoi
                WHERE ID_phieu_sua_chua IN (
                    SELECT ID_phieu_sua_chua 
                    FROM PhieuSuaChua 
                    WHERE ID_phieu_tiep_nhan = @IDPhieuTiepNhan)";
                    using (MySqlCommand cmd = new MySqlCommand(deletePhieuSuaChuaThongTinLoi, connection))
                    {
                        cmd.Parameters.AddWithValue("@IDPhieuTiepNhan", idPhieuTiepNhan);
                        cmd.ExecuteNonQuery();
                    }

                    // Xóa dữ liệu trong bảng ChiTietSuaChua
                    string deleteChiTietSuaChua = @"
                DELETE FROM ChiTietSuaChua
                WHERE ID_phieu_sua_chua IN (
                    SELECT ID_phieu_sua_chua 
                    FROM PhieuSuaChua 
                    WHERE ID_phieu_tiep_nhan = @IDPhieuTiepNhan)";
                    using (MySqlCommand cmd = new MySqlCommand(deleteChiTietSuaChua, connection))
                    {
                        cmd.Parameters.AddWithValue("@IDPhieuTiepNhan", idPhieuTiepNhan);
                        cmd.ExecuteNonQuery();
                    }

                    // Xóa dữ liệu trong bảng PhieuSuaChua
                    string deletePhieuSuaChua = @"
                DELETE FROM PhieuSuaChua 
                WHERE ID_phieu_tiep_nhan = @IDPhieuTiepNhan";
                    using (MySqlCommand cmd = new MySqlCommand(deletePhieuSuaChua, connection))
                    {
                        cmd.Parameters.AddWithValue("@IDPhieuTiepNhan", idPhieuTiepNhan);
                        cmd.ExecuteNonQuery();
                    }

                    // Xóa dữ liệu trong bảng PhieuTiepNhanThietBi
                    string deletePhieuTiepNhan = @"
                DELETE FROM PhieuTiepNhanThietBi 
                WHERE ID_phieu_tiep_nhan = @IDPhieuTiepNhan";
                    using (MySqlCommand cmd = new MySqlCommand(deletePhieuTiepNhan, connection))
                    {
                        cmd.Parameters.AddWithValue("@IDPhieuTiepNhan", idPhieuTiepNhan);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Đã xóa phiếu tiếp nhận và các dữ liệu liên quan thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa phiếu tiếp nhận: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("ID không hợp lệ hoặc bạn đã hủy thao tác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTaoPhieuTiepNhan_Click_1(object sender, EventArgs e)
        {
            // Mở form tiếp nhận
            FormTiepNhan formTiepNhan = new FormTiepNhan();
            string connectionString = "server=localhost;user id=root;password=123456789;database=QuanLySuaChua1;";


            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Truy vấn lấy ngẫu nhiên 1 nhân viên
                    string query = "SELECT Ho_ten FROM NhanVien ORDER BY RAND() LIMIT 1";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // Thực thi truy vấn và lấy tên nhân viên
                    object result = cmd.ExecuteScalar();

                    // Gán tên nhân viên vào lbNhanVienSuaChua trong FormTiepNhan
                    if (result != null)
                    {
                        // Truyền tên nhân viên vào FormTiepNhan
                        formTiepNhan.SetNhanVienSuaChua(result.ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message);
                }
            }

            // Mở form tiếp nhận
            formTiepNhan.Show();
        }
    }
}
