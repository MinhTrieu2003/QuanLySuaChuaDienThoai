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
    public partial class FormLinhKien : Form
    {
        private string connectionString = "server=localhost;database=QuanLySuaChua1;uid=root;pwd=123456789;";
        public FormLinhKien()
        {
            InitializeComponent();
        }

        public class LinhKien
        {
            public int ID { get; set; }
            public string TenLinhKien { get; set; }
            public string LoaiLK { get; set; }
            public string GiaNhap { get; set; }
            public string GiaBan { get; set; }
            public string Sltk { get; set; }

        }
        private LinhKien lkInfor;

        private void FormLinhKien_Load(object sender, EventArgs e)
        {
            if (LKInfor != null)
            {

                txtTenLinhKien.Text = lkInfor.TenLinhKien;
                txtLoaiLK.Text = lkInfor.LoaiLK;
                txtGiaNhap.Text = lkInfor.GiaNhap;
                txtGiaBan.Text = lkInfor.GiaBan;
                txtSltk.Text = lkInfor.Sltk;
            }
        }

        private void ttnSave4_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query;

                    // Nếu đang sửa thông tin 
                    if (LKInfor != null && LKInfor.ID > 0)
                    {
                        query = @"UPDATE LinhKien 
                          SET Ten_linh_kien = @Ten, Loai_linh_kien = @Loai, Gia_nhap = @Nhap, Gia_ban = @Ban, So_luong_ton_kho = @Sltk 
                          WHERE ID_linh_kien = @ID";
                    }
                    else
                    {
                        // Nếu đang thêm mới 
                        query = "INSERT INTO LinhKien (Ten_linh_kien, Loai_linh_kien, Gia_nhap, Gia_ban, So_luong_ton_kho ) VALUES (@Ten, @PLoai, @Nhap, @Ban, @Sltk )";
                    }

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        // Truyền giá trị từ các TextBox vào tham số
                        cmd.Parameters.AddWithValue("@Ten", txtTenLinhKien.Text);
                        cmd.Parameters.AddWithValue("@Loai", txtLoaiLK.Text);
                        cmd.Parameters.AddWithValue("@Nhap", txtGiaNhap.Text);
                        cmd.Parameters.AddWithValue("@Ban", txtGiaBan.Text);
                        cmd.Parameters.AddWithValue("@Sltk", txtSltk.Text);


                        if (LKInfor != null && LKInfor.ID > 0)
                        {
                            cmd.Parameters.AddWithValue("@ID", LKInfor.ID);
                        }

                        // Thực thi lệnh SQL
                        cmd.ExecuteNonQuery();
                    }
                }

                // Hiển thị thông báo thành công
                MessageBox.Show(LKInfor != null && LKInfor.ID > 0
                    ? "Thông tin linh kiện đã được cập nhật thành công!"
                    : "Linh kiện đã được thêm thành công!");

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

        public LinhKien LKInfor
        {

            get => lkInfor;
            set
            {
                lkInfor = value;

                if (lkInfor != null)
                {
                    txtTenLinhKien.Text = lkInfor.TenLinhKien;
                    txtLoaiLK.Text = lkInfor.LoaiLK;
                    txtGiaNhap.Text = lkInfor.GiaNhap;
                    txtGiaBan.Text = lkInfor.GiaBan;
                    txtSltk.Text = lkInfor.Sltk;
                }
            }

        }


    }
}
