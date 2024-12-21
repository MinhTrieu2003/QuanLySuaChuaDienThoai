namespace QLDVSC
{
    public partial class UcCustomer : UserControl
    {
        // Danh sách giả lập để lưu thông tin khách hàng
        public List<Customer> customers;

        // Lớp dữ liệu khách hàng
        public class Customer
        {
            public int ID { get; set; }
            public string FullName { get; set; }
            public string PhoneNumber { get; set; }
            public string Email { get; set; }
            public string Address { get; set; }
        }
        public UcCustomer()
        {
            InitializeComponent();
            InitCustomerList();
            LoadCustomerData();
        }

        // Khởi tạo danh sách khách hàng mẫu
        private void InitCustomerList()
        {
            customers = new List<Customer>
            {
                new Customer { ID = 1, FullName = "Nguyễn Văn A", PhoneNumber = "0912345678", Email = "a@gmail.com", Address = "Hà Nội" },
                new Customer { ID = 2, FullName = "Trần Thị B", PhoneNumber = "0987654321", Email = "b@gmail.com", Address = "Hồ Chí Minh" }
            };
        }

        // Nạp danh sách khách hàng vào DataGridView
        private void LoadCustomerData()
        {
            dgvCustomers.DataSource = null;
            dgvCustomers.DataSource = customers;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addForm = new CustomerForm(); // Form thêm khách hàng
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                customers.Add(addForm.CustomerData);
                LoadCustomerData();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count > 0)
            {
                int selectedID = (int)dgvCustomers.SelectedRows[0].Cells["ID"].Value;
                var customer = customers.Find(c => c.ID == selectedID);

                var editForm = new CustomerForm(customer); // Form chỉnh sửa khách hàng
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadCustomerData();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng để sửa!", "Thông báo");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count > 0)
            {
                int selectedID = (int)dgvCustomers.SelectedRows[0].Cells["ID"].Value;
                var customer = customers.Find(c => c.ID == selectedID);

                var confirm = MessageBox.Show($"Bạn có chắc muốn xóa khách hàng '{customer.FullName}' không?", "Xác nhận", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    customers.Remove(customer);
                    LoadCustomerData();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng để xóa!", "Thông báo");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.ToLower();

            var searchResult = customers.FindAll(c =>
                c.FullName.ToLower().Contains(keyword) ||
                c.PhoneNumber.Contains(keyword));

            dgvCustomers.DataSource = null;
            dgvCustomers.DataSource = searchResult;
        }
    }
}
