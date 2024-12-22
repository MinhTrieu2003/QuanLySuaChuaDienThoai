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
    public partial class FormLichSuSuaChua : Form
    {
        private string connectionString = "server=localhost;database=QuanLySuaChua1;uid=root;pwd=123456789;";
        private int customerId;

        

        public FormLichSuSuaChua(int customerId)
        {
            InitializeComponent();
            this.customerId = customerId;
        }


        private void LoadRepairHistory()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
            SELECT 
                ps.ID_phieu_sua_chua, 
                tb.Model,
                ps.Mo_ta_loi, 
                dv.Ten_dich_vu, 
                lk.Ten_linh_kien, 
                hd.Tong_tien
            FROM PhieuSuaChua ps
            INNER JOIN PhieuTiepNhanThietBi ptt ON ps.ID_phieu_tiep_nhan = ptt.ID_phieu_tiep_nhan
            LEFT JOIN ThietBi tb ON ptt.ID_thiet_bi = tb.ID_thiet_bi
            INNER JOIN ChiTietSuaChua ctsc ON ps.ID_phieu_sua_chua = ctsc.ID_phieu_sua_chua
            INNER JOIN DichVu dv ON ctsc.ID_dich_vu = dv.ID_dich_vu
            INNER JOIN LinhKien lk ON ctsc.ID_linh_kien = lk.ID_linh_kien
            INNER JOIN HoaDon hd ON ps.ID_phieu_sua_chua = hd.ID_phieu_sua_chua
            INNER JOIN KhachHang kh ON ptt.ID_khach_hang = kh.ID_khach_hang
            WHERE kh.ID_khach_hang = @CustomerID;";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@CustomerId", customerId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgvLichSuSuaChua.DataSource = dataTable;
                }
            }
        }

        private void FormLichSuSuaChua_Load_1(object sender, EventArgs e)
        {
            LoadRepairHistory();
        }
    }
}
