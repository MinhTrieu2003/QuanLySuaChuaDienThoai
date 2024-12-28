using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace QLDVSC
{
    public partial class UcHoaDon : UserControl
    {
        string connectionString = "server=localhost;database=QuanLySuaChua1;uid=root;pwd=123456789;";

        public UcHoaDon()
        {
            InitializeComponent();
        }

        private Image GetImageFromResources(byte[] imageBytes)
        {
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                return Image.FromStream(ms);
            }
        }


        private void UcHoaDon_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }


        // Nút xóa hóa đơn
        private void btnXoaHoaDon_Click(object sender, EventArgs e)
        {
            string maHoaDon = txtMaHoaDon.Text.Trim();

            if (string.IsNullOrEmpty(maHoaDon))
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "DELETE FROM hoadon WHERE ID_hoa_don = @MaHoaDon";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaHoaDon", maHoaDon);

                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Xóa hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDataGrid(); // Tải lại dữ liệu
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy hóa đơn với mã đã nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa hóa đơn: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            string maHoaDon = txtMaHoaDon.Text.Trim();

            if (string.IsNullOrEmpty(maHoaDon))
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = @"
        SELECT 
            ID_hoa_don AS MaHoaDon,
            Tong_tien AS TongTien,
            Ngay_lap AS NgaySuaChua
        FROM 
            hoadon
        WHERE 
            ID_hoa_don = @MaHoaDon";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Lấy dữ liệu hóa đơn
                                string ma = reader["MaHoaDon"].ToString();
                                string tongTien = reader["TongTien"].ToString();
                                string ngaySuaChua = reader["NgaySuaChua"].ToString();

                                // Tạo nội dung file txt
                                string noiDungHoaDon = $"HÓA ĐƠN\n" +
                                                       $"Mã Hóa Đơn: {ma}\n" +
                                                       $"Tổng Tiền: {tongTien}\n" +
                                                       $"Ngày Sửa Chữa: {ngaySuaChua}\n";

                                // Ghi file .txt
                                string filePath = $"HoaDon_{ma}.txt";
                                System.IO.File.WriteAllText(filePath, noiDungHoaDon);

                                MessageBox.Show($"In hóa đơn thành công! File lưu tại: {filePath}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy hóa đơn với mã đã nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi in hóa đơn: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadDataGrid()
        {
            string query = @"
        SELECT 
            ID_hoa_don AS IDHoaDon,
            ID_phieu_sua_chua AS IDPhieuSuaChua,
            Ngay_lap AS NgayLap,
            Tong_tien AS TongTien,
            Phuong_thuc_thanh_toan AS PhuongThucThanhToan
        FROM 
            hoadon";

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

                    // Đổi tên các cột
                    dataGridView1.Columns["IDHoaDon"].HeaderText = "Mã hóa đơn";
                    dataGridView1.Columns["IDPhieuSuaChua"].HeaderText = "Mã phiếu";
                    dataGridView1.Columns["NgayLap"].HeaderText = "Ngày sửa chữa";
                    dataGridView1.Columns["TongTien"].HeaderText = "Tổng tiền";
                    dataGridView1.Columns["PhuongThucThanhToan"].HeaderText = "Phương thức thanh toán";

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

        
    }
}
