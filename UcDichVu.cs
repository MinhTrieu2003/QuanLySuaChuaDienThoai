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
    public partial class UcDichVu : UserControl
    {
        string connectionString = "server=localhost;database=QuanLySuaChua1;uid=root;pwd=123456789;";
        public UcDichVu()
        {
            InitializeComponent();
        }

        private void LoadDichVu()
        {


            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM dichvu";
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgvDichVu.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}");
                }
            }
        }

        private void UcDichVu_Load(object sender, EventArgs e)
        {
            LoadDichVu();
        }

        private void btnAddDichVu_Click(object sender, EventArgs e)
        {
            using (var form = new FormDichVu())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    // Sau khi form lưu vào database, gọi lại LoadCustomers để tải dữ liệu mới nhất
                    LoadDichVu();
                }
            }
        }

        private void btnEditDichVu_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn dòng nào trong DataGridView chưa
            if (dgvDichVu.SelectedRows.Count > 0)
            {
                // Lấy thông tin khách hàng từ dòng được chọn
                var selectedRow = dgvDichVu.SelectedRows[0];
                var dichVu = new FormDichVu.DichVu
                {
                    ID = Convert.ToInt32(selectedRow.Cells["ID_dich_vu"].Value),
                    TenDichVu = selectedRow.Cells["Ten_dich_vu"].Value?.ToString(),
                    GiaDV = selectedRow.Cells["Gia"].Value?.ToString(),

                };

                // Mở form thông tin khách hàng với dữ liệu đã có
                using (var form = new FormDichVu())
                {
                    form.DVInfor = dichVu; // Truyền thông tin khách hàng vào form

                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        // Sau khi form lưu xong vào database, tải lại danh sách khách hàng
                        LoadDichVu();
                    }
                }
            }
            else
            {
                // Hiển thị thông báo nếu không có dòng nào được chọn
                MessageBox.Show("Vui lòng chọn một dichj vụ để chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void btnDeleteDichVu_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn dòng nào trong DataGridView chưa
            if (dgvDichVu.SelectedRows.Count > 0)
            {
                var selectedRow = dgvDichVu.SelectedRows[0];
                int dichvuId = Convert.ToInt32(selectedRow.Cells["ID_dich_vu"].Value);

                // Xác nhận trước khi xóa
                var confirmResult = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa dịch vụ này không?",
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
                            string query = "DELETE FROM DichVu WHERE ID_dich_vu = @dichvuID";
                            using (MySqlCommand cmd = new MySqlCommand(query, connection))
                            {
                                cmd.Parameters.AddWithValue("@dichvuID", dichvuId);
                                cmd.ExecuteNonQuery();
                            }

                            MessageBox.Show("Xóa dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


                            LoadDichVu();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Lỗi khi xóa dịch vụ: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {

                MessageBox.Show("Vui lòng chọn một dịch vụ để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void SearchDichVu(string keyword)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"SELECT ID_dich_vu, Ten_dich_vu, Gia 
                             FROM DichVu 
                             WHERE ID_dich_vu LIKE @Keyword 
                                OR Ten_dich_vu LIKE @Keyword
                                OR Gia LIKE @Keyword";
                                

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dgvDichVu.DataSource = dataTable;

                        // Hiển thị thông báo nếu không tìm thấy kết quả
                        if (dataTable.Rows.Count == 0)
                        {
                            MessageBox.Show("Không tìm thấy kết quả nào phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tìm kiếm dịch vụ: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void toolStripbtnSearch3_Click(object sender, EventArgs e)
        {
            string keyword = toolStriptxtSearch3.Text.Trim();

            if (!string.IsNullOrEmpty(keyword))
            {
                SearchDichVu(keyword);
            }
            else
            {
                // Nếu từ khóa trống, tải lại toàn bộ danh sách khách hàng
                LoadDichVu();
            }
        }

        private void toolStriptxtSearch3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string keyword = toolStriptxtSearch3.Text.Trim();

                if (!string.IsNullOrEmpty(keyword))
                {
                    SearchDichVu(keyword);
                }
                else
                {
                    // Nếu không có từ khóa, tải lại toàn bộ danh sách
                    LoadDichVu();
                }

                e.Handled = true; // Ngăn chặn âm thanh "ding" khi nhấn Enter
            }
        }
    }
}
