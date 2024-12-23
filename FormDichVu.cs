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
using static QLDVSC.FormThongTinKH;

namespace QLDVSC
{
    public partial class FormDichVu : Form
    {
        private string connectionString = "server=localhost;database=QuanLySuaChua1;uid=root;pwd=123456789;";
        public FormDichVu()
        {
            InitializeComponent();
        }
        public class DichVu
        {
            public int ID { get; set; }
            public string TenDichVu { get; set; }
            public string GiaDV { get; set; }

        }
        private DichVu dvInfor;

        private void FormDichVu_Load(object sender, EventArgs e)
        {
            if (DVInfor != null)
            {
                // Điền thông tin khách hàng lên form (chỉ khi chỉnh sửa)
                txtTenDichVu.Text = DVInfor.TenDichVu;
                txtGiaDV.Text = DVInfor.GiaDV;

            }
        }

        private void btbSave3_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query;

                    // Nếu đang sửa thông tin khách hàng
                    if (DVInfor != null && DVInfor.ID > 0)
                    {
                        query = @"UPDATE DichVu 
                          SET Ten_dich_vu = @TenDichVu, Gia = @GiaDV 
                          WHERE ID_dich_vu = @ID";
                    }
                    else
                    {
                        // Nếu đang thêm mới khách hàng
                        query = "INSERT INTO DichVu (Ten_dich_vu, Gia) VALUES (@TenDichVu, @GiaDV)";
                    }

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        // Truyền giá trị từ các TextBox vào tham số
                        cmd.Parameters.AddWithValue("@TenDichVu", txtTenDichVu.Text);
                        cmd.Parameters.AddWithValue("@GiaDV", txtGiaDV.Text);
                        

                        if (DVInfor != null && DVInfor.ID > 0)
                        {
                            cmd.Parameters.AddWithValue("@ID", DVInfor.ID);
                        }

                        // Thực thi lệnh SQL
                        cmd.ExecuteNonQuery();
                    }
                }

                // Hiển thị thông báo thành công
                MessageBox.Show(DVInfor != null && DVInfor.ID > 0
                    ? "Thông tin dịch vụ đã được cập nhật thành công!"
                    : "Dịch vụ đã được thêm thành công!");

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

        public DichVu DVInfor
        {

            get => dvInfor;
            set
            {
                dvInfor = value;
                // Hiển thị thông tin khách hàng lên form khi được gán giá trị
                if (dvInfor != null)
                {
                    txtTenDichVu.Text = dvInfor.TenDichVu;
                    txtGiaDV.Text = dvInfor.GiaDV;

                }
            }
        }



    }
}
