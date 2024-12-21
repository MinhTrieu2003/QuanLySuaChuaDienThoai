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
    }
}
