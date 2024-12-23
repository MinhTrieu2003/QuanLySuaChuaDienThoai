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
    public partial class FormLoiTG : Form
    {
        private string connectionString = "server=localhost;database=QuanLySuaChua1;uid=root;pwd=123456789;";
        public FormLoiTG()
        {
            InitializeComponent();
        }

        public class LoiTG
        {
            public int ID { get; set; }
            public string MotaLoi { get; set; }

        }
        private LoiTG ltgInfor;

        private void FormLoiTG_Load(object sender, EventArgs e)
        {
            if (LTGInfor != null)
            {
                // Điền thông tin khách hàng lên form (chỉ khi chỉnh sửa)
                txtLoiTG.Text = ltgInfor.MotaLoi;

            }
        }

        private void btnSave6_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query;

                    // Nếu đang sửa thông tin khách hàng
                    if (LTGInfor != null && LTGInfor.ID > 0)
                    {
                        query = @"UPDATE danhmucloi 
                          SET Mo_ta_loi = @Name 
                          WHERE ID_Loi = @ID";
                    }
                    else
                    {
                        // Nếu đang thêm mới khách hàng
                        query = "INSERT INTO danhmucloi (Mo_ta_loi) VALUES (@Name)";
                    }

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        // Truyền giá trị từ các TextBox vào tham số
                        cmd.Parameters.AddWithValue("@Name", txtLoiTG.Text);
                        

                        if (LTGInfor != null && LTGInfor.ID > 0)
                        {
                            cmd.Parameters.AddWithValue("@ID", LTGInfor.ID);
                        }

                        // Thực thi lệnh SQL
                        cmd.ExecuteNonQuery();
                    }
                }

                // Hiển thị thông báo thành công
                MessageBox.Show(LTGInfor != null && LTGInfor.ID > 0
                    ? "Thông tin lỗi thường gặp đã được cập nhật thành công!"
                    : "Lỗi thường gặp đã được thêm thành công!");

                // Đóng form và gửi kết quả trở về
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có vấn đề xảy ra
                MessageBox.Show($"Lỗi khi lưu dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public LoiTG LTGInfor
        {

            get => ltgInfor;
            set
            {
                ltgInfor = value;
                // Hiển thị thông tin khách hàng lên form khi được gán giá trị
                if (ltgInfor != null)
                {
                    txtLoiTG.Text = ltgInfor.MotaLoi;

                }
            }

        }


    }
}
