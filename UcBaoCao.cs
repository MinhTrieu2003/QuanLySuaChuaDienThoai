using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using LiveCharts;
using LiveCharts.Wpf;

namespace QLDVSC
{
    public partial class UcBaoCao : UserControl
    {
        private readonly string connectionString = "server=localhost;database=QuanLySuaChua1;uid=root;pwd=123456789;";

        public UcBaoCao()
        {
            InitializeComponent();
        }

        private void UcBaoCao_Load(object sender, EventArgs e)
        {
            LoadPieChart();      // Tải dữ liệu cho biểu đồ Pie Chart
            LoadRevenueChart();  // Tải dữ liệu doanh thu theo tháng
        }

        // Biểu đồ Pie Chart
        private void LoadPieChart()
        {
            string query = @"
                SELECT 
                    d.Ten_dich_vu AS ServiceName, 
                    COUNT(ct.ID_dich_vu) AS UsageCount
                FROM chitietsuachua ct
                JOIN dichvu d ON ct.ID_dich_vu = d.ID_dich_vu
                GROUP BY d.Ten_dich_vu
                ORDER BY UsageCount DESC
                LIMIT 10;
            ";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    MySqlCommand cmdUtf8 = new MySqlCommand("SET NAMES utf8mb4;", conn);
                    cmdUtf8.ExecuteNonQuery();

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    DataTable dataTable = new DataTable();
                    new MySqlDataAdapter(cmd).Fill(dataTable);

                    var pieSeriesCollection = new SeriesCollection();

                    foreach (DataRow row in dataTable.Rows)
                    {
                        pieSeriesCollection.Add(new PieSeries
                        {
                            Title = row["ServiceName"].ToString(),
                            Values = new ChartValues<int> { Convert.ToInt32(row["UsageCount"]) },
                            DataLabels = false // Không hiển thị nhãn trên biểu đồ
                        });
                    }

                    // Cập nhật Pie Chart
                    pieChart1.Series = pieSeriesCollection;
                    pieChart1.LegendLocation = LegendLocation.Right;

                    pieChart1.DataTooltip = new DefaultTooltip
                    {
                        SelectionMode = TooltipSelectionMode.OnlySender // Hiển thị tooltip khi hover
                    };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu biểu đồ Pie Chart: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Bộ lọc biểu đồ doanh thu
        private void comboBoxRevenueFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFilter = comboBoxRevenueFilter.SelectedItem.ToString();

            if (selectedFilter == "By Quarter")
            {
                LoadRevenueByQuarterChart();
            }
            else if (selectedFilter == "By Month")
            {
                LoadRevenueChart();
            }
            else
            {
                MessageBox.Show("Lựa chọn bộ lọc không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Biểu đồ doanh thu theo quý
        private void LoadRevenueByQuarterChart()
        {
            string query = @"
                SELECT 
                    CONCAT('Quarter ', QUARTER(Ngay_lap), ' ', YEAR(Ngay_lap)) AS QuarterYear,
                    SUM(Tong_tien) AS TotalRevenue
                FROM hoadon
                GROUP BY YEAR(Ngay_lap), QUARTER(Ngay_lap), CONCAT('Quarter ', QUARTER(Ngay_lap), ' ', YEAR(Ngay_lap))
                ORDER BY YEAR(Ngay_lap), QUARTER(Ngay_lap);
            ";

            LoadCartesianChart(query, "Quý", "Doanh Thu (VNĐ)");
        }

        // Biểu đồ doanh thu theo tháng
        private void LoadRevenueChart()
        {
            string query = @"
                SELECT 
                    DATE_FORMAT(Ngay_lap, '%Y-%m') AS MonthYear, 
                    SUM(Tong_tien) AS TotalRevenue
                FROM hoadon
                GROUP BY DATE_FORMAT(Ngay_lap, '%Y-%m')
                ORDER BY DATE_FORMAT(Ngay_lap, '%Y-%m');
            ";

            LoadCartesianChart(query, "Tháng", "Doanh Thu (VNĐ)");
        }

        // Hàm chung để tải dữ liệu cho CartesianChart
        private void LoadCartesianChart(string query, string xAxisTitle, string yAxisTitle)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    var labels = new List<string>();
                    var values = new List<double>();

                    while (reader.Read())
                    {
                        labels.Add(reader[0].ToString());
                        values.Add(Convert.ToDouble(reader[1]));
                    }

                    // Cập nhật Cartesian Chart
                    cartesianChart1.Series = new SeriesCollection
                    {
                        new ColumnSeries
                        {
                            Title = "Doanh Thu",
                            Values = new ChartValues<double>(values)
                        }
                    };

                    cartesianChart1.AxisX.Clear();
                    cartesianChart1.AxisX.Add(new Axis
                    {
                        Title = xAxisTitle,
                        Labels = labels
                    });

                    cartesianChart1.AxisY.Clear();
                    cartesianChart1.AxisY.Add(new Axis
                    {
                        Title = yAxisTitle,
                        LabelFormatter = value => value.ToString("C0") // Định dạng tiền tệ
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu biểu đồ Cartesian Chart: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
