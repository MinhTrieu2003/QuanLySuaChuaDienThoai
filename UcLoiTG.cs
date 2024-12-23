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
    }
}
