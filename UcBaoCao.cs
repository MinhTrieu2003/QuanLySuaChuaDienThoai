using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using LiveCharts;
using LiveCharts.Wpf;

namespace QLDVSC
{
    public partial class UcBaoCao : UserControl
    {
        string connectionString = "server=localhost;database=QuanLySuaChua;uid=root;pwd=123456789;";

        public UcBaoCao()
        {
            InitializeComponent();
        }

        private void UcBaoCao_Load(object sender, EventArgs e)
        {
            LoadPieChart();      // Load data for Báo cáo dịch vụ
            LoadRevenueChart();  // Load data for Báo cáo doanh thu
        }

        private void LoadPieChart()
        {
            string query = @"
                SELECT 
                    d.Ten_dich_vu, 
                    COUNT(ct.ID_dich_vu) AS SoLanSuDung
                FROM chitietsuachua ct
                JOIN dichvu d ON ct.ID_dich_vu = d.ID_dich_vu
                GROUP BY d.Ten_dich_vu
                ORDER BY SoLanSuDung DESC;
            ";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    DataTable dataTable = new DataTable();
                    new MySqlDataAdapter(cmd).Fill(dataTable);

                    var pieSeriesCollection = new SeriesCollection();

                    foreach (DataRow row in dataTable.Rows)
                    {
                        pieSeriesCollection.Add(new PieSeries
                        {
                            Title = row["Ten_dich_vu"].ToString(),
                            Values = new ChartValues<int> { Convert.ToInt32(row["SoLanSuDung"]) },
                            DataLabels = true
                        });
                    }

                    pieChart1.Series = pieSeriesCollection;
                    pieChart1.LegendLocation = LegendLocation.Bottom;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu biểu đồ Pie Chart: " + ex.Message);
            }
        }

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

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    var months = new List<string>();
                    var revenues = new List<double>();

                    while (reader.Read())
                    {
                        months.Add(reader["MonthYear"].ToString());
                        revenues.Add(Convert.ToDouble(reader["TotalRevenue"]));
                    }

                    cartesianChart1.Series = new SeriesCollection
                    {
                        new ColumnSeries
                        {
                            Title = "Doanh Thu",
                            Values = new ChartValues<double>(revenues)
                        }
                    };

                    cartesianChart1.AxisX.Clear();
                    cartesianChart1.AxisX.Add(new Axis
                    {
                        Title = "Tháng",
                        Labels = months
                    });

                    cartesianChart1.AxisY.Clear();
                    cartesianChart1.AxisY.Add(new Axis
                    {
                        Title = "Doanh Thu (VNĐ)"
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu biểu đồ Cartesian Chart: " + ex.Message);
            }
        }
    }
}
