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
    public partial class UcLoiTG : UserControl
    {
        string connectionString = "server=localhost;database=QuanLySuaChua1;uid=root;pwd=123456789;";
        public UcLoiTG()
        {
            InitializeComponent();
        }

        private void LoadLoiTG()
        {


            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM DanhMucLoi";
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgvLoiTG.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}");
                }
            }
        }

        private void UcLoiTG_Load(object sender, EventArgs e)
        {
            LoadLoiTG();
        }

        private void btnAddLoi_Click(object sender, EventArgs e)
        {
            using (var form = new FormLoiTG())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {

                    LoadLoiTG();
                }
            }
        }

        private void btnEditLoi_Click(object sender, EventArgs e)
        {

            if (dgvLoiTG.SelectedRows.Count > 0)
            {

                var selectedRow = dgvLoiTG.SelectedRows[0];
                var loiTG = new FormLoiTG.LoiTG
                {
                    ID = Convert.ToInt32(selectedRow.Cells["ID_loi"].Value),
                    MotaLoi = selectedRow.Cells["Mo_ta_loi"].Value?.ToString(),

                };


                using (var form = new FormLoiTG())
                {
                    form.LTGInfor = loiTG; // Truyền thông tin khách hàng vào form

                    if (form.ShowDialog() == DialogResult.OK)
                    {

                        LoadLoiTG();
                    }
                }
            }
            else
            {

                MessageBox.Show("Vui lòng chọn một lỗi thường gặp để chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btndeleteLLoi_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn dòng nào trong DataGridView chưa
            if (dgvLoiTG.SelectedRows.Count > 0)
            {
                var selectedRow = dgvLoiTG.SelectedRows[0];
                int loiId = Convert.ToInt32(selectedRow.Cells["ID_loi"].Value);

                // Xác nhận trước khi xóa
                var confirmResult = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa lỗi này không?",
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
                            string query = "DELETE FROM danhmucloi WHERE ID_loi = @loiID";
                            using (MySqlCommand cmd = new MySqlCommand(query, connection))
                            {
                                cmd.Parameters.AddWithValue("@loiID", loiId);
                                cmd.ExecuteNonQuery();
                            }

                            MessageBox.Show("Xóa lỗi thường gặp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


                            LoadLoiTG();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Lỗi khi xóa lỗi thường gặp: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {

                MessageBox.Show("Vui lòng chọn một lỗi thường gặp để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SearchLoi(string keyword)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"SELECT ID_loi, Mo_ta_loi 
                             FROM danhmucloi 
                             WHERE ID_loi LIKE @Keyword 
                                OR Mo_ta_loi LIKE @Keyword ";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dgvLoiTG.DataSource = dataTable;

                        // Hiển thị thông báo nếu không tìm thấy kết quả
                        if (dataTable.Rows.Count == 0)
                        {
                            MessageBox.Show("Không tìm thấy kết quả nào phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tìm kiếm Lỗi thường gặp: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void toolStriptxtSearch5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string keyword = toolStriptxtSearch5.Text.Trim();

                if (!string.IsNullOrEmpty(keyword))
                {
                    SearchLoi(keyword);
                }
                else
                {
                    // Nếu không có từ khóa, tải lại toàn bộ danh sách
                    LoadLoiTG();
                }

                e.Handled = true; // Ngăn chặn âm thanh "ding" khi nhấn Enter
            }
        }

        private void toolStriptxtSearch6_Click(object sender, EventArgs e)
        {
            string keyword = toolStriptxtSearch6.Text.Trim();

            if (!string.IsNullOrEmpty(keyword))
            {
                SearchLoi(keyword);
            }
            else
            {
                // Nếu từ khóa trống, tải lại toàn bộ danh sách khách hàng
                LoadLoiTG();
            }
        }
    }
}
