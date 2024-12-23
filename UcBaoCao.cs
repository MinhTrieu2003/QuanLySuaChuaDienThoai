using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using LiveCharts;
using LiveCharts.Wpf;

namespace QLDVSC
{
    public partial class UcBaoCao : UserControl
    {
        string connectionString = "server=localhost;database=QuanLySuaChua;uid=root;pwd=admin;";

        public UcBaoCao()
        {
            InitializeComponent();
        }

        private void UcBaoCao_Load(object sender, EventArgs e)
        {
            LoadRevenueChart();
        }

        private void LoadRevenueChart()
        {
            string query = @"
                SELECT 
                    DATE_FORMAT(Ngay_lap, '%Y-%m') AS MonthYear, 
                    SUM(Tong_tien) AS TotalRevenue
                FROM 
                    hoadon
                GROUP BY 
                    DATE_FORMAT(Ngay_lap, '%Y-%m')
                ORDER BY 
                    DATE_FORMAT(Ngay_lap, '%Y-%m') ASC";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    var months = new List<string>();
                    var revenues = new List<double>();

                    while (reader.Read())
                    {
                        months.Add(reader["MonthYear"].ToString());
                        revenues.Add(Convert.ToDouble(reader["TotalRevenue"]));
                    }

                    // Cập nhật dữ liệu cho biểu đồ
                    cartesianChart1.Series = new SeriesCollection
                    {
                        new ColumnSeries
                        {
                            Title = "Doanh Thu",
                            Values = new LiveCharts.ChartValues<double>(revenues)
                        }
                    };

                    cartesianChart1.AxisX.Clear();
                    cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
                    {
                        Title = "Tháng",
                        Labels = months
                    });

                    cartesianChart1.AxisY.Clear();
                    cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
                    {
                        Title = "Doanh Thu (VNĐ)"
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu biểu đồ: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
