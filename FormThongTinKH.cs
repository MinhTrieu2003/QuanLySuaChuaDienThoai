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
    public partial class FormThongTinKH : Form
    {
        private string connectionString = "server=localhost;database=QuanLySuaChua1;uid=root;pwd=123456789;";

        public FormThongTinKH()
        {
            InitializeComponent();
        }

        public class KhachHang
        {
            public int ID { get; set; }
            public string CustomerName { get; set; }
            public string PhoneNumber { get; set; }
            public string Email { get; set; }
            public string Address { get; set; }
        }
        private KhachHang khInfor;

        public KhachHang KHInfor {

            get => khInfor;
            set
            {
                khInfor = value;
                // Hiển thị thông tin khách hàng lên form khi được gán giá trị
                if (khInfor != null)
                {
                    txtCustomerName.Text = khInfor.CustomerName;
                    txtPhoneNumber.Text = khInfor.PhoneNumber;
                    txtEmail.Text = khInfor.Email;
                    txtAddress.Text = khInfor.Address;
                }
            }

        }

        private void InforKhachHang_Load(object sender, EventArgs e)
        {
            if (KHInfor != null)
            {
                // Điền thông tin khách hàng lên form (chỉ khi chỉnh sửa)
                txtCustomerName.Text = KHInfor.CustomerName;
                txtPhoneNumber.Text = KHInfor.PhoneNumber;
                txtEmail.Text = KHInfor.Email;
                txtAddress.Text = KHInfor.Address;
            }
        }

        private void btnSave2_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query;

                    // Nếu đang sửa thông tin khách hàng
                    if (KHInfor != null && KHInfor.ID > 0)
                    {
                        query = @"UPDATE KhachHang 
                          SET Ho_ten = @Name, So_dien_thoai = @Phone, Email = @Email, Dia_chi = @Address 
                          WHERE ID_khach_hang = @ID";
                    }
                    else
                    {
                        // Nếu đang thêm mới khách hàng
                        query = "INSERT INTO KhachHang (Ho_ten, So_dien_thoai, Email, Dia_chi) VALUES (@Name, @Phone, @Email, @Address)";
                    }

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        // Truyền giá trị từ các TextBox vào tham số
                        cmd.Parameters.AddWithValue("@Name", txtCustomerName.Text);
                        cmd.Parameters.AddWithValue("@Phone", txtPhoneNumber.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@Address", txtAddress.Text);

                        if (KHInfor != null && KHInfor.ID > 0)
                        {
                            cmd.Parameters.AddWithValue("@ID", KHInfor.ID);
                        }

                        // Thực thi lệnh SQL
                        cmd.ExecuteNonQuery();
                    }
                }

                // Hiển thị thông báo thành công
                MessageBox.Show(KHInfor != null && KHInfor.ID > 0
                    ? "Thông tin khách hàng đã được cập nhật thành công!"
                    : "Khách hàng đã được thêm thành công!");

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
    }
}

