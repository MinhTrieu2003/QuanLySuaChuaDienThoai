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

using static QLDVSC.FormDangNhap;

namespace QLDVSC
{
    public partial class UcDonHangNV : UserControl
    {
        private string connectionString = "server=localhost;database=QuanLySuaChua1;uid=root;pwd=123456789;";
        public UcDonHangNV()
        {
            InitializeComponent();
        }
        private void LoadDonSuaChua()
        {
            string username = LoggedInUser.TenTaiKhoan;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Lấy ID_nhan_vien từ Ten_dang_nhap
                string queryGetStaffId = "SELECT ID_nhan_vien FROM NhanVien WHERE Ten_dang_nhap = @username";
                int staffId;

                using (MySqlCommand cmd = new MySqlCommand(queryGetStaffId, connection))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    staffId = Convert.ToInt32(cmd.ExecuteScalar());
                }

                // Lấy danh sách đơn sửa chữa
                string query = @"
                SELECT 
                    psc.ID_phieu_sua_chua ,
                    psc.Ngay_tiep_nhan AS NgayTiepNhan,
                    kh.Ho_ten AS TenKhachHang,
                    kh.So_dien_thoai AS SoDienThoai,
                    tb.Hang AS TenThietBi,
                    psc.Mo_ta_loi AS MoTaLoi,
                    psc.Tinh_trang AS TinhTrangSuaChua,
                    nv.Ho_ten AS NhanVienSuaChua,
                    dv.Ten_dich_vu AS TenDichVu,
                    
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
                WHERE ptn.ID_nhan_vien = @staffId";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@staffId", staffId);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgvDonSuaChua.DataSource = dataTable;
                }
            }
        }

        private void UcDonHangNV_Load(object sender, EventArgs e)
        {
            
            LoadDonSuaChua();
        }

        private void dgvDonSuaChua_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvDonSuaChua.Columns["colCapNhat"].Index && e.RowIndex >= 0)
            {
                int idPhieuSuaChua = Convert.ToInt32(dgvDonSuaChua.Rows[e.RowIndex].Cells["ID_phieu_sua_chua"].Value);
                FormCapNhatDonHang form = new FormCapNhatDonHang(idPhieuSuaChua);
                form.FormClosed += (s, args) => LoadDonSuaChua(); // Tải lại dữ liệu sau khi form đóng
                form.ShowDialog();
            }
        }


















    }
}
