using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace QLDVSC
{
    public partial class UcDonhang : UserControl
    {
        string connectionString = "server=localhost;database=QuanLySuaChua1;uid=root;pwd=123456789;";

        public UcDonhang()
        {
            InitializeComponent();
        }

        private void UcDonhang_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        private void LoadDataGrid()
        {
            string query = @"
                SELECT 
                    psc.ID_phieu_sua_chua AS IDPhieuSuaChua,
                    psc.Ngay_tiep_nhan AS NgayTiepNhan,
                    kh.Ho_ten AS TenKhachHang,
                    kh.So_dien_thoai AS SoDienThoai,
                    tb.Hang AS TenThietBi,
                    psc.Mo_ta_loi AS MoTaLoi,
                    psc.Tinh_trang AS TinhTrangSuaChua,
                    nv.Ho_ten AS NhanVienSuaChua,
                    dv.Ten_dich_vu AS TenDichVu,
                    ctsc.So_luong_linh_kien_su_dung AS SoLuongLinhKien,
                    ctsc.Tong_chi_phi AS GiaTien
                FROM 
                    PhieuSuaChua psc
                JOIN 
                    PhieuTiepNhanThietBi ptn ON psc.ID_phieu_tiep_nhan = ptn.ID_phieu_tiep_nhan
                JOIN 
                    KhachHang kh ON ptn.ID_khach_hang = kh.ID_khach_hang
                JOIN 
                    ThietBi tb ON ptn.ID_thiet_bi = tb.ID_thiet_bi
                JOIN 
                    NhanVien nv ON ptn.ID_nhan_vien = nv.ID_nhan_vien
                JOIN 
                    ChiTietSuaChua ctsc ON psc.ID_phieu_sua_chua = ctsc.ID_phieu_sua_chua
                JOIN 
                    DichVu dv ON ctsc.ID_dich_vu = dv.ID_dich_vu";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    // Gán DataTable vào DataGridView
                    dataGridView1.DataSource = table;

                    // Kiểm tra số lượng dòng sau khi gán
                    if (dataGridView1.Rows.Count == 0)
                    {
                        MessageBox.Show("Không có dữ liệu để hiển thị.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
                }
            }
        }

        private void btnTaoPhieuTiepNhan_Click(object sender, EventArgs e)
        {
            // Mở form tiếp nhận
            FormTiepNhan formTiepNhan = new FormTiepNhan();

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

        private void button1_Click(object sender, EventArgs e)
        {
            string searchID = txtSearch.Text.Trim(); // Lấy giá trị từ TextBox
            if (string.IsNullOrEmpty(searchID))
            {
                MessageBox.Show("Vui lòng nhập ID phiếu sửa chữa!");
                return;
            }

            string connectionString = "server=localhost;database=QuanLySuaChua1;uid=root;pwd=123456789;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT 
                    psc.ID_phieu_sua_chua AS IDPhieuSuaChua,
                    psc.Ngay_tiep_nhan AS NgayTiepNhan,
                    kh.Ho_ten AS TenKhachHang,
                    kh.So_dien_thoai AS SoDienThoai,
                    tb.Hang AS TenThietBi,
                    psc.Mo_ta_loi AS MoTaLoi,
                    psc.Tinh_trang AS TinhTrangSuaChua,
                    nv.Ho_ten AS NhanVienSuaChua,
                    dv.Ten_dich_vu AS TenDichVu,
                    ctsc.So_luong_linh_kien_su_dung AS SoLuongLinhKien,
                    ctsc.Tong_chi_phi AS GiaTien
                FROM 
                    PhieuSuaChua psc
                JOIN 
                    PhieuTiepNhanThietBi ptn ON psc.ID_phieu_tiep_nhan = ptn.ID_phieu_tiep_nhan
                JOIN 
                    KhachHang kh ON ptn.ID_khach_hang = kh.ID_khach_hang
                JOIN 
                    ThietBi tb ON ptn.ID_thiet_bi = tb.ID_thiet_bi
                JOIN 
                    NhanVien nv ON ptn.ID_nhan_vien = nv.ID_nhan_vien
                JOIN 
                    ChiTietSuaChua ctsc ON psc.ID_phieu_sua_chua = ctsc.ID_phieu_sua_chua
                JOIN 
                    DichVu dv ON ctsc.ID_dich_vu = dv.ID_dich_vu
                WHERE psc.ID_phieu_sua_chua = @IDPhieuSuaChua";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@IDPhieuSuaChua", searchID); // Thêm tham số vào câu truy vấn

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt; // Gắn dữ liệu kết quả vào DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
                }
            }

        }

        private void btnSuaTinhTrang_Click(object sender, EventArgs e)
        {
            FormSuaTinhTrang form = new FormSuaTinhTrang();
            form.ShowDialog();

        }
        private void XuatPhieuSuaChua(string idPhieuSuaChua)
        {
            // Kết nối tới MySQL và lấy dữ liệu
            string connectionString = "server=localhost;database=QuanLySuaChua1;uid=root;pwd=123456789;";
            string query = @"
        SELECT 
            psc.ID_phieu_sua_chua AS IDPhieuSuaChua,
            psc.Ngay_tiep_nhan AS NgayTiepNhan,
            kh.Ho_ten AS TenKhachHang,
            kh.So_dien_thoai AS SoDienThoai,
            tb.Hang AS TenThietBi,
            psc.Mo_ta_loi AS MoTaLoi,
            psc.Tinh_trang AS TinhTrangSuaChua,
            nv.Ho_ten AS NhanVienSuaChua,
            dv.Ten_dich_vu AS TenDichVu,
            ctsc.So_luong_linh_kien_su_dung AS SoLuongLinhKien,
            ctsc.Tong_chi_phi AS GiaTien
        FROM 
            PhieuSuaChua psc
        JOIN 
            PhieuTiepNhanThietBi ptn ON psc.ID_phieu_tiep_nhan = ptn.ID_phieu_tiep_nhan
        JOIN 
            KhachHang kh ON ptn.ID_khach_hang = kh.ID_khach_hang
        JOIN 
            ThietBi tb ON ptn.ID_thiet_bi = tb.ID_thiet_bi
        JOIN 
            NhanVien nv ON ptn.ID_nhan_vien = nv.ID_nhan_vien
        JOIN 
            ChiTietSuaChua ctsc ON psc.ID_phieu_sua_chua = ctsc.ID_phieu_sua_chua
        JOIN 
            DichVu dv ON ctsc.ID_dich_vu = dv.ID_dich_vu
        WHERE psc.ID_phieu_sua_chua = @IDPhieuSuaChua";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IDPhieuSuaChua", idPhieuSuaChua); // Thêm tham số vào câu truy vấn

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy phiếu sửa chữa với ID này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Lấy thông tin từ DataTable
                    DataRow row = dataTable.Rows[0];

                    // Đường dẫn file TXT
                    string outputPath = $"PhieuSuaChua_{idPhieuSuaChua}.txt";

                    // Ghi dữ liệu vào file TXT
                    using (StreamWriter writer = new StreamWriter(outputPath))
                    {
                        writer.WriteLine("=========================================");
                        writer.WriteLine("              PHIẾU SỬA CHỮA");
                        writer.WriteLine("=========================================");
                        writer.WriteLine();

                        writer.WriteLine($"ID Phiếu: {row["IDPhieuSuaChua"]}");
                        writer.WriteLine($"Ngày Tiếp Nhận: {row["NgayTiepNhan"]}");
                        writer.WriteLine($"Khách Hàng: {row["TenKhachHang"]}");
                        writer.WriteLine($"Số Điện Thoại: {row["SoDienThoai"]}");
                        writer.WriteLine($"Hãng Thiết Bị: {row["TenThietBi"]}");
                        writer.WriteLine($"Mô Tả Lỗi: {row["MoTaLoi"]}");
                        writer.WriteLine($"Tình Trạng Sửa Chữa: {row["TinhTrangSuaChua"]}");
                        writer.WriteLine($"Nhân Viên Sửa Chữa: {row["NhanVienSuaChua"]}");
                        writer.WriteLine($"Dịch Vụ: {row["TenDichVu"]}");
                        writer.WriteLine($"Số Lượng Linh Kiện: {row["SoLuongLinhKien"]}");
                        writer.WriteLine($"Giá Tiền: {row["GiaTien"]}");
                        writer.WriteLine();
                        writer.WriteLine("=========================================");
                    }

                    MessageBox.Show($"Xuất TXT thành công! File đã lưu tại: {outputPath}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Mở file TXT với Notepad
                    System.Diagnostics.Process.Start("notepad.exe", outputPath);  // Mở với Notepad
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xuất phiếu sửa chữa: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //Debug.WriteLine(ex.StackTrace); // Ghi log chi tiết lỗi ra console            
                }
            }
        }

        private void btnXuatPhieuSuaChua_Click(object sender, EventArgs e)
        {
            // Tạo dialog
            Form dialog = new Form();
            dialog.Text = "Nhập ID Phiếu Sửa Chữa";
            dialog.Width = 400;
            dialog.Height = 200;
            dialog.StartPosition = FormStartPosition.CenterParent;

            // Label hướng dẫn
            Label lblInstruction = new Label();
            lblInstruction.Text = "Nhập ID Phiếu Sửa Chữa:";
            lblInstruction.AutoSize = true;
            lblInstruction.Location = new Point(20, 20);
            dialog.Controls.Add(lblInstruction);

            // TextBox để nhập ID
            TextBox txtIDPhieuSuaChua = new TextBox();
            txtIDPhieuSuaChua.Location = new Point(20, 50);
            txtIDPhieuSuaChua.Width = 340;
            dialog.Controls.Add(txtIDPhieuSuaChua);

            // Button Xác nhận
            Button btnConfirm = new Button();
            btnConfirm.Text = "Xác nhận";
            btnConfirm.Location = new Point(220, 100);
            btnConfirm.DialogResult = DialogResult.OK;
            dialog.Controls.Add(btnConfirm);

            // Button Hủy
            Button btnCancel = new Button();
            btnCancel.Text = "Hủy";
            btnCancel.Location = new Point(100, 100);
            btnCancel.DialogResult = DialogResult.Cancel;
            dialog.Controls.Add(btnCancel);

            // Hiển thị dialog
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Lấy ID Phiếu Sửa Chữa từ TextBox
                string idPhieuSuaChua = txtIDPhieuSuaChua.Text.Trim();

                if (!string.IsNullOrEmpty(idPhieuSuaChua))
                {
                    // Kiểm tra ID và xuất phiếu sửa chữa
                    XuatPhieuSuaChua(idPhieuSuaChua);
                }
                else
                {
                    MessageBox.Show("ID Phiếu Sửa Chữa không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaPhieuSuaChua_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox(
                "Nhập ID Phiếu Sửa Chữa cần xóa:",
                "Xóa Phiếu Sửa Chữa",
                "",
                -1,
                -1);
            string connectionString = "server=localhost;database=QuanLySuaChua1;uid=root;pwd=123456789;";


            if (!string.IsNullOrWhiteSpace(input) && int.TryParse(input, out int idPhieuSuaChua))
            {
                MySqlConnection connection = new MySqlConnection(connectionString);

                try
                {
                    connection.Open();

                    // Xóa dữ liệu trong bảng HoaDon liên quan
                    string deleteHoaDon = @"
                DELETE FROM HoaDon
                WHERE ID_phieu_sua_chua = @IDPhieuSuaChua";
                    using (MySqlCommand cmd = new MySqlCommand(deleteHoaDon, connection))
                    {
                        cmd.Parameters.AddWithValue("@IDPhieuSuaChua", idPhieuSuaChua);
                        cmd.ExecuteNonQuery();
                    }

                    // Xóa dữ liệu trong bảng PhieuSuaChua_ThongTinLoi liên quan
                    string deleteThongTinLoi = @"
                DELETE FROM PhieuSuaChua_ThongTinLoi
                WHERE ID_phieu_sua_chua = @IDPhieuSuaChua";
                    using (MySqlCommand cmd = new MySqlCommand(deleteThongTinLoi, connection))
                    {
                        cmd.Parameters.AddWithValue("@IDPhieuSuaChua", idPhieuSuaChua);
                        cmd.ExecuteNonQuery();
                    }

                    // Xóa dữ liệu trong bảng ChiTietSuaChua liên quan
                    string deleteChiTietSuaChua = @"
                DELETE FROM ChiTietSuaChua
                WHERE ID_phieu_sua_chua = @IDPhieuSuaChua";
                    using (MySqlCommand cmd = new MySqlCommand(deleteChiTietSuaChua, connection))
                    {
                        cmd.Parameters.AddWithValue("@IDPhieuSuaChua", idPhieuSuaChua);
                        cmd.ExecuteNonQuery();
                    }

                    // Xóa dữ liệu trong bảng PhieuSuaChua
                    string deletePhieuSuaChua = @"
                DELETE FROM PhieuSuaChua
                WHERE ID_phieu_sua_chua = @IDPhieuSuaChua";
                    using (MySqlCommand cmd = new MySqlCommand(deletePhieuSuaChua, connection))
                    {
                        cmd.Parameters.AddWithValue("@IDPhieuSuaChua", idPhieuSuaChua);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Đã xóa phiếu sửa chữa và các dữ liệu liên quan thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa phiếu sửa chữa: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

    }
}
