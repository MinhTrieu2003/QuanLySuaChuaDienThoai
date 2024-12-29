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
using static QLDVSC.FormDangNhap;

namespace QLDVSC
{
    public partial class UcTiepNhanTB : UserControl
    {
        private string connectionString = "server=localhost;database=QuanLySuaChua1;uid=root;pwd=123456789;";
        public UcTiepNhanTB()
        {
            InitializeComponent();
        }

        private void UcTiepNhanTB_Load(object sender, EventArgs e)
        {

        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ giao diện
            string customerName = txtCustomerName.Text.Trim();
            string phoneNumber = txtPhoneNumber.Text.Trim();
            string email = txtEmail.Text.Trim();
            string address = txtAddress.Text.Trim();

            string deviceName = txtDeviceName.Text.Trim();
            string deviceModel = txtDeviceModel.Text.Trim();
            string deviceTechnicalInfo = txtTechnicalInfo.Text.Trim();
            string deviceProblem = txtProblem.Text.Trim();
            string receivedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            

            string username = LoggedInUser.TenTaiKhoan;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    // Lấy ID_nhan_vien từ tên đăng nhập
                    string queryGetStaffId = "SELECT ID_nhan_vien FROM NhanVien WHERE Ten_dang_nhap = @username";
                    int staffId;

                    using (MySqlCommand cmd = new MySqlCommand(queryGetStaffId, connection))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        staffId = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // Bắt đầu transaction để đảm bảo tính toàn vẹn dữ liệu
                    using (var transaction = connection.BeginTransaction())
                    {
                        // 1. Thêm khách hàng mới vào bảng `KhachHang` nếu chưa tồn tại
                        string customerIdQuery = @"
                            SELECT ID_khach_hang 
                            FROM KhachHang 
                            WHERE So_dien_thoai = @PhoneNumber LIMIT 1";

                        int customerId = 0;

                        using (MySqlCommand cmd = new MySqlCommand(customerIdQuery, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                            var result = cmd.ExecuteScalar();
                            if (result != null)
                            {
                                customerId = Convert.ToInt32(result);
                            }
                            else
                            {
                                string insertCustomerQuery = @"
                                    INSERT INTO KhachHang (Ho_ten, So_dien_thoai, Email, Dia_chi) 
                                    VALUES (@CustomerName, @PhoneNumber, @Email, @Address)";
                                using (MySqlCommand insertCmd = new MySqlCommand(insertCustomerQuery, connection, transaction))
                                {
                                    insertCmd.Parameters.AddWithValue("@CustomerName", customerName);
                                    insertCmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                                    insertCmd.Parameters.AddWithValue("@Email", email);
                                    insertCmd.Parameters.AddWithValue("@Address", address);
                                    insertCmd.ExecuteNonQuery();
                                    customerId = (int)insertCmd.LastInsertedId;
                                }
                            }
                        }

                        // 2. Thêm thiết bị vào bảng `ThietBi`
                        int deviceId;
                        string insertDeviceQuery = @"
                            INSERT INTO ThietBi (Hang, Model, Thong_tin_ky_thuat) 
                            VALUES (@DeviceName, @DeviceModel, @DeviceTechnicalInfo)";
                        using (MySqlCommand deviceCmd = new MySqlCommand(insertDeviceQuery, connection, transaction))
                        {
                            deviceCmd.Parameters.AddWithValue("@DeviceName", deviceName);
                            deviceCmd.Parameters.AddWithValue("@DeviceModel", deviceModel);
                            deviceCmd.Parameters.AddWithValue("@DeviceTechnicalInfo", deviceTechnicalInfo);
                            deviceCmd.ExecuteNonQuery();
                            deviceId = (int)deviceCmd.LastInsertedId;
                        }

                        // 3. Tạo phiếu tiếp nhận thiết bị trong bảng `PhieuTiepNhanThietBi`
                        int receiptId;
                        string insertReceiptQuery = @"
                            INSERT INTO PhieuTiepNhanThietBi (Ngay_tiep_nhan, ID_khach_hang, ID_thiet_bi, ID_nhan_vien) 
                            VALUES (@ReceivedDate, @CustomerId, @DeviceId, @StaffId)";
                        using (MySqlCommand receiptCmd = new MySqlCommand(insertReceiptQuery, connection, transaction))
                        {
                            receiptCmd.Parameters.AddWithValue("@ReceivedDate", receivedDate);
                            receiptCmd.Parameters.AddWithValue("@CustomerId", customerId);
                            receiptCmd.Parameters.AddWithValue("@DeviceId", deviceId);
                            receiptCmd.Parameters.AddWithValue("@StaffId", staffId);
                            receiptCmd.ExecuteNonQuery();
                            receiptId = (int)receiptCmd.LastInsertedId;
                        }

                        // 4. Tạo phiếu sửa chữa trong bảng `PhieuSuaChua`
                        string repairStatus = "Đang xử lý"; // Trạng thái mặc định
                        string insertRepairOrderQuery = @"
                            INSERT INTO PhieuSuaChua (ID_phieu_tiep_nhan, Mo_ta_loi, Tinh_trang, Ngay_tiep_nhan) 
                            VALUES (@ReceiptId, @DeviceProblem, @RepairStatus, @ReceivedDate)";
                        using (MySqlCommand repairCmd = new MySqlCommand(insertRepairOrderQuery, connection, transaction))
                        {
                            repairCmd.Parameters.AddWithValue("@ReceiptId", receiptId);
                            repairCmd.Parameters.AddWithValue("@DeviceProblem", deviceProblem);
                            repairCmd.Parameters.AddWithValue("@RepairStatus", repairStatus);
                            repairCmd.Parameters.AddWithValue("@ReceivedDate", receivedDate);
                            repairCmd.ExecuteNonQuery();
                        }

                        // Commit transaction nếu tất cả các bước thành công
                        transaction.Commit();
                        MessageBox.Show("Tạo phiếu tiếp nhận thiết bị thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tạo phiếu tiếp nhận thiết bị: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

