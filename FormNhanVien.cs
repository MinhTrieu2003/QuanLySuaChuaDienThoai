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
    public partial class FormNhanVien : Form
    {
        private string connectionString = "server=localhost;database=QuanLySuaChua1;uid=root;pwd=123456789;";
        public FormNhanVien()
        {
            InitializeComponent();
        }

        public class NhanVien
        {
            public int ID { get; set; }
            public string TenNhanVien { get; set; }
            public string VaiTro { get; set; }
            public string TenDangNhap { get; set; }
            public string MatKhau { get; set; }
        }
        private NhanVien nvInfor;

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            if (NVInfor != null)
            {
                // Điền thông tin khách hàng lên form (chỉ khi chỉnh sửa)
                txtHoTen.Text = nvInfor.TenNhanVien;
                cbVaiTro.Text = nvInfor.VaiTro;
                txtTenDangNhap.Text = nvInfor.TenDangNhap;
                txtPass.Text = nvInfor.MatKhau;
            }
        }

        private void btnSave7_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query;

                    // Nếu đang sửa thông tin khách hàng
                    if (NVInfor != null && NVInfor.ID > 0)
                    {
                        query = @"UPDATE NhanVien 
                          SET Ho_ten = @Name, Vai_tro = @Role, Ten_dang_nhap = @Username, Mat_khau = @Pass 
                          WHERE ID_nhan_vien = @ID";
                    }
                    else
                    {
                        // Nếu đang thêm mới khách hàng
                        query = "INSERT INTO NhanVien (Ho_ten, Vai_tro, Ten_dang_nhap, Mat_khau) VALUES (@Name, @Role, @Username, @Pass)";
                    }

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        // Truyền giá trị từ các TextBox vào tham số
                        cmd.Parameters.AddWithValue("@Name", txtHoTen.Text);
                        cmd.Parameters.AddWithValue("@Role", cbVaiTro.Text);
                        cmd.Parameters.AddWithValue("@Username", txtTenDangNhap.Text);
                        cmd.Parameters.AddWithValue("@Pass", txtPass.Text);

                        if (NVInfor != null && NVInfor.ID > 0)
                        {
                            cmd.Parameters.AddWithValue("@ID", NVInfor.ID);
                        }

                        // Thực thi lệnh SQL
                        cmd.ExecuteNonQuery();
                    }
                }

                // Hiển thị thông báo thành công
                MessageBox.Show(NVInfor != null && NVInfor.ID > 0
                    ? "Thông tin nhân viên đã được cập nhật thành công!"
                    : "Nhân viên đã được thêm thành công!");

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

        public NhanVien NVInfor
        {

            get => nvInfor;
            set
            {
                nvInfor = value;
                // Hiển thị thông tin khách hàng lên form khi được gán giá trị
                if (nvInfor != null)
                {
                    txtHoTen.Text = nvInfor.TenNhanVien;
                    cbVaiTro.Text = nvInfor.VaiTro;
                    txtTenDangNhap.Text = nvInfor.TenDangNhap;
                    txtPass.Text = nvInfor.MatKhau;
                }
            }

        }


    }
}
