using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using static QLDVSC.FormThongTinKH;

namespace QLDVSC
{
    public partial class UcKhachHang : UserControl
    {

        string connectionString = "server=localhost;database=QuanLySuaChua1;uid=root;pwd=123456789;";
        public UcKhachHang()
        {


            InitializeComponent();

        }

        private void LoadCustomers()
        {


            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM KhachHang";
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgvKhachHang.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}");
                }
            }
        }

        private void UcKhachHang_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            using (var form = new FormThongTinKH())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    // Sau khi form lưu vào database, gọi lại LoadCustomers để tải dữ liệu mới nhất
                    LoadCustomers();
                }
            }
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn dòng nào trong DataGridView chưa
            if (dgvKhachHang.SelectedRows.Count > 0)
            {
                // Lấy thông tin khách hàng từ dòng được chọn
                var selectedRow = dgvKhachHang.SelectedRows[0];
                var khachHang = new FormThongTinKH.KhachHang
                {
                    ID = Convert.ToInt32(selectedRow.Cells["ID_khach_hang"].Value),
                    CustomerName = selectedRow.Cells["Ho_ten"].Value?.ToString(),
                    PhoneNumber = selectedRow.Cells["So_dien_thoai"].Value?.ToString(),
                    Email = selectedRow.Cells["Email"].Value?.ToString(),
                    Address = selectedRow.Cells["Dia_chi"].Value?.ToString()
                };

                // Mở form thông tin khách hàng với dữ liệu đã có
                using (var form = new FormThongTinKH())
                {
                    form.KHInfor = khachHang; // Truyền thông tin khách hàng vào form

                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        // Sau khi form lưu xong vào database, tải lại danh sách khách hàng
                        LoadCustomers();
                    }
                }
            }
            else
            {
                // Hiển thị thông báo nếu không có dòng nào được chọn
                MessageBox.Show("Vui lòng chọn một khách hàng để chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn dòng nào trong DataGridView chưa
            if (dgvKhachHang.SelectedRows.Count > 0)
            {
                var selectedRow = dgvKhachHang.SelectedRows[0];
                int customerId = Convert.ToInt32(selectedRow.Cells["ID_khach_hang"].Value);

                // Xác nhận trước khi xóa
                var confirmResult = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa khách hàng này không?",
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
                            string query = "DELETE FROM KhachHang WHERE ID_khach_hang = @CustomerID";
                            using (MySqlCommand cmd = new MySqlCommand(query, connection))
                            {
                                cmd.Parameters.AddWithValue("@CustomerID", customerId);
                                cmd.ExecuteNonQuery();
                            }

                            MessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            
                            LoadCustomers();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Lỗi khi xóa khách hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                
                MessageBox.Show("Vui lòng chọn một khách hàng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SearchCustomers(string keyword)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"SELECT ID_khach_hang, Ho_ten, So_dien_thoai, Email, Dia_chi 
                             FROM KhachHang 
                             WHERE Ho_ten LIKE @Keyword 
                                OR So_dien_thoai LIKE @Keyword 
                                OR Email LIKE @Keyword 
                                OR Dia_chi LIKE @Keyword";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dgvKhachHang.DataSource = dataTable;

                        // Hiển thị thông báo nếu không tìm thấy kết quả
                        if (dataTable.Rows.Count == 0)
                        {
                            MessageBox.Show("Không tìm thấy kết quả nào phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tìm kiếm khách hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void toolStripTxtSearch1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string keyword = toolStripTxtSearch1.Text.Trim();

                if (!string.IsNullOrEmpty(keyword))
                {
                    SearchCustomers(keyword);
                }
                else
                {
                    // Nếu không có từ khóa, tải lại toàn bộ danh sách
                    LoadCustomers();
                }

                e.Handled = true; // Ngăn chặn âm thanh "ding" khi nhấn Enter
            }
        }
        private void toolStripbtnSearch1_Click(object sender, EventArgs e)
        {
            string keyword = toolStripTxtSearch1.Text.Trim();

            if (!string.IsNullOrEmpty(keyword))
            {
                SearchCustomers(keyword);
            }
            else
            {
                // Nếu từ khóa trống, tải lại toàn bộ danh sách khách hàng
                LoadCustomers();
            }
        }

        private void dgvKhachHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu click vào một hàng hợp lệ
            if (e.RowIndex >= 0)
            {
                // Lấy ID khách hàng từ cột "ID_khach_hang"
                int customerId = Convert.ToInt32(dgvKhachHang.Rows[e.RowIndex].Cells["ID_khach_hang"].Value);

                // Mở form lịch sử sửa chữa
                using (var historyForm = new FormLichSuSuaChua(customerId))
                {
                    historyForm.ShowDialog();
                }
            }
        }
    }
}
