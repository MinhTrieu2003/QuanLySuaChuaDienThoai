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
    public partial class UcLinhKien : UserControl
    {
        string connectionString = "server=localhost;database=QuanLySuaChua1;uid=root;pwd=123456789;";
        public UcLinhKien()
        {
            InitializeComponent();
        }

        private void LoadLinhKien()
        {


            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM LinhKien";
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgvLinhKien.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}");
                }
            }
        }

        private void UcLinhKien_Load(object sender, EventArgs e)
        {
            LoadLinhKien();
        }

        private void btnAddLinhKien_Click(object sender, EventArgs e)
        {
            using (var form = new FormLinhKien())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    // Sau khi form lưu vào database, gọi lại LoadCustomers để tải dữ liệu mới nhất
                    LoadLinhKien();
                }
            }
        }

        private void btnEditLinhKien_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn dòng nào trong DataGridView chưa
            if (dgvLinhKien.SelectedRows.Count > 0)
            {
                // Lấy thông tin khách hàng từ dòng được chọn
                var selectedRow = dgvLinhKien.SelectedRows[0];
                var linhKien = new FormLinhKien.LinhKien
                {
                    ID = Convert.ToInt32(selectedRow.Cells["ID_linh_kien"].Value),
                    TenLinhKien = selectedRow.Cells["Ten_linh_kien"].Value?.ToString(),
                    LoaiLK = selectedRow.Cells["Loai_linh_kien"].Value?.ToString(),
                    GiaNhap = selectedRow.Cells["Gia_nhap"].Value?.ToString(),
                    GiaBan = selectedRow.Cells["Gia_ban"].Value?.ToString(),
                    Sltk = selectedRow.Cells["So_luong_ton_kho"].Value?.ToString()
                };

                // Mở form thông tin khách hàng với dữ liệu đã có
                using (var form = new FormLinhKien())
                {
                    form.LKInfor = linhKien; // Truyền thông tin khách hàng vào form

                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        // Sau khi form lưu xong vào database, tải lại danh sách khách hàng
                        LoadLinhKien();
                    }
                }
            }
            else
            {
                // Hiển thị thông báo nếu không có dòng nào được chọn
                MessageBox.Show("Vui lòng chọn một linh kiện để chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btndeleteLiLinhKien_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn dòng nào trong DataGridView chưa
            if (dgvLinhKien.SelectedRows.Count > 0)
            {
                var selectedRow = dgvLinhKien.SelectedRows[0];
                int linhkienId = Convert.ToInt32(selectedRow.Cells["ID_linh_kien"].Value);

                // Xác nhận trước khi xóa
                var confirmResult = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa linh kiện này không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {

                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();
                            string query = "DELETE FROM LinhKien WHERE ID_linh_kien = @linhkienID";
                            using (MySqlCommand cmd = new MySqlCommand(query, connection))
                            {
                                cmd.Parameters.AddWithValue("@linhkienID", linhkienId);
                                cmd.ExecuteNonQuery();
                            }

                            MessageBox.Show("Xóa linh kiện thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


                            LoadLinhKien();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Lỗi khi xóa linh kiện: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {

                MessageBox.Show("Vui lòng chọn một linh kiện để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SearchLinhKien(string keyword)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();


                    string query;

                    if (int.TryParse(keyword, out int LinhKienID))
                    {
                        query = @"SELECT ID_linh_kien, Ten_linh_kien, Loai_linh_kien, Gia_nhap, Gia_ban, So_luong_ton_kho 
                          FROM LinhKien 
                          WHERE ID_linh_kien = @LinhKienID";
                    }
                    else
                    {
                        query = @"SELECT ID_linh_kien, Ten_linh_kien, Loai_linh_kien, Gia_nhap, Gia_ban, So_luong_ton_kho 
                          FROM LinhKien 
                          WHERE Ten_linh_kien LIKE @Keyword 
                             OR Loai_linh_kien LIKE @Keyword 
                             OR Gia_nhap LIKE @Keyword 
                             OR Gia_ban LIKE @Keyword";
                    }

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        // Thêm tham số phù hợp
                        if (int.TryParse(keyword, out LinhKienID))
                        {
                            cmd.Parameters.AddWithValue("@LinhKienID", LinhKienID);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                        }

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Gán kết quả tìm kiếm vào DataGridView
                        dgvLinhKien.DataSource = dataTable;

                        // Hiển thị thông báo nếu không tìm thấy kết quả
                        if (dataTable.Rows.Count == 0)
                        {
                            MessageBox.Show("Không tìm thấy kết quả nào phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tìm kiếm linh kiện: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void toolStriptxtSearch4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string keyword = toolStriptxtSearch4.Text.Trim();

                if (!string.IsNullOrEmpty(keyword))
                {
                    SearchLinhKien(keyword);
                }
                else
                {
                    // Nếu không có từ khóa, tải lại toàn bộ danh sách
                    LoadLinhKien();
                }

                e.Handled = true; // Ngăn chặn âm thanh "ding" khi nhấn Enter
            }
        }

        private void toolStripbtnSearch4_Click(object sender, EventArgs e)
        {
            string keyword = toolStriptxtSearch4.Text.Trim();

            if (!string.IsNullOrEmpty(keyword))
            {
                SearchLinhKien(keyword);
            }
            else
            {
                // Nếu từ khóa trống, tải lại toàn bộ danh sách khách hàng
                LoadLinhKien();
            }
        }
    }
}
