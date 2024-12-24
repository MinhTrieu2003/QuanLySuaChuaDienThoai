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
    public partial class UcNhanVien : UserControl
    {
        string connectionString = "server=localhost;database=QuanLySuaChua1;uid=root;pwd=123456789;";
        public UcNhanVien()
        {
            InitializeComponent();
        }

        private void UcNhanVien_Load(object sender, EventArgs e)
        {
            LoadNhanVien();
        }

        private void LoadNhanVien()
        {


            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM NhanVien";
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgvNhanVien.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}");
                }
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            using (var form = new FormNhanVien())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    // Sau khi form lưu vào database, gọi lại LoadCustomers để tải dữ liệu mới nhất
                    LoadNhanVien();
                }
            }
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {

            if (dgvNhanVien.SelectedRows.Count > 0)
            {
                // Lấy thông tin khách hàng từ dòng được chọn
                var selectedRow = dgvNhanVien.SelectedRows[0];
                var nhanVien = new FormNhanVien.NhanVien
                {
                    ID = Convert.ToInt32(selectedRow.Cells["ID_nhan_vien"].Value),
                    TenNhanVien = selectedRow.Cells["Ho_ten"].Value?.ToString(),
                    VaiTro = selectedRow.Cells["Vai_tro"].Value?.ToString(),
                    TenDangNhap = selectedRow.Cells["Ten_dang_nhap"].Value?.ToString(),
                    MatKhau = selectedRow.Cells["Mat_khau"].Value?.ToString()
                };

                // Mở form thông tin khách hàng với dữ liệu đã có
                using (var form = new FormNhanVien())
                {
                    form.NVInfor = nhanVien; // Truyền thông tin khách hàng vào form

                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        // Sau khi form lưu xong vào database, tải lại danh sách khách hàng
                        LoadNhanVien();
                    }
                }
            }
            else
            {
                // Hiển thị thông báo nếu không có dòng nào được chọn
                MessageBox.Show("Vui lòng chọn một nhân viên để chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteEployee_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn dòng nào trong DataGridView chưa
            if (dgvNhanVien.SelectedRows.Count > 0)
            {
                var selectedRow = dgvNhanVien.SelectedRows[0];
                int nhanvienId = Convert.ToInt32(selectedRow.Cells["ID_nhan_vien"].Value);

                // Xác nhận trước khi xóa
                var confirmResult = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa nhân viên này không?",
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
                            string query = "DELETE FROM NhanVien WHERE ID_nhan_vien = @nhanvienID";
                            using (MySqlCommand cmd = new MySqlCommand(query, connection))
                            {
                                cmd.Parameters.AddWithValue("@nhanvienID", nhanvienId);
                                cmd.ExecuteNonQuery();
                            }

                            MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


                            LoadNhanVien();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Lỗi khi xóa nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {

                MessageBox.Show("Vui lòng chọn một nhân viên để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void SearchNhanVien(string keyword)
        {
            
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        
                        string query;

                        if (int.TryParse(keyword, out int nhanvienID))
                        {
                            query = @"SELECT ID_nhan_vien, Ho_ten, Vai_tro, Ten_dang_nhap, Mat_khau 
                          FROM NhanVien 
                          WHERE ID_nhan_vien = @nhanvienID";
                        }
                        else
                        {
                            query = @"SELECT ID_nhan_vien, Ho_ten, Vai_tro, Ten_dang_nhap, Mat_khau 
                          FROM NhanVien 
                          WHERE Ho_ten LIKE @Keyword 
                             OR Vai_tro LIKE @Keyword 
                             OR Ten_dang_nhap LIKE @Keyword 
                             OR Mat_khau LIKE @Keyword";
                        }

                        using (MySqlCommand cmd = new MySqlCommand(query, connection))
                        {
                            // Thêm tham số phù hợp
                            if (int.TryParse(keyword, out nhanvienID))
                            {
                                cmd.Parameters.AddWithValue("@nhanvienID", nhanvienID);
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                            }

                            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Gán kết quả tìm kiếm vào DataGridView
                            dgvNhanVien.DataSource = dataTable;

                            // Hiển thị thông báo nếu không tìm thấy kết quả
                            if (dataTable.Rows.Count == 0)
                            {
                                MessageBox.Show("Không tìm thấy kết quả nào phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi tìm kiếm nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            

        }

        private void toolStripTxtSearch2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string keyword = toolStripTxtSearch2.Text.Trim();

                if (!string.IsNullOrEmpty(keyword))
                {
                    SearchNhanVien(keyword);
                }
                else
                {
                    // Nếu không có từ khóa, tải lại toàn bộ danh sách
                    LoadNhanVien();
                }

                e.Handled = true; // Ngăn chặn âm thanh "ding" khi nhấn Enter
            }
        }

        private void toolStripbtnSearch2_Click(object sender, EventArgs e)
        {
            string keyword = toolStripTxtSearch2.Text.Trim();

            if (!string.IsNullOrEmpty(keyword))
            {
                SearchNhanVien(keyword);
            }
            else
            {
                // Nếu từ khóa trống, tải lại toàn bộ danh sách khách hàng
                LoadNhanVien();
            }
        }
    }
}
