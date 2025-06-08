using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3_CoffeeHome.BLL;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections;

namespace PBL3_CoffeeHome.GUI.Admin
{
    public partial class ucTongQuan: UserControl
    {
        private readonly RevenueBLL _revenueBLL;
        private readonly BaristaQueueBLL _baristaQueueBLL;
        private readonly OrderBLL _orderBLL;
        private DateTime fromDate;
        private DateTime toDate;
        public ucTongQuan()
        {
            InitializeComponent();
            _revenueBLL = new RevenueBLL();
            _baristaQueueBLL = new BaristaQueueBLL();
            _orderBLL = new OrderBLL();
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            fromDate = DateTime.Today;
            toDate = DateTime.Today.AddDays(1).AddTicks(-1);
            LoadCashierList(fromDate, toDate);
            LoadBaristaList(fromDate, toDate);
            CalculateRevenueStatistics(fromDate, toDate);
        }

        private void btn7Days_Click(object sender, EventArgs e)
        {
            toDate = DateTime.Today;
            fromDate = toDate.AddDays(-6);
            LoadCashierList(fromDate, toDate);
            LoadBaristaList(fromDate, toDate);
            CalculateRevenueStatistics(fromDate, toDate);
        }

        private void btn30Days_Click(object sender, EventArgs e)
        {
            toDate = DateTime.Today;
            fromDate = toDate.AddDays(-29);
            LoadCashierList(fromDate, toDate);
            LoadBaristaList(fromDate, toDate);
            CalculateRevenueStatistics(fromDate, toDate);
        }
        public void LoadCashierList(DateTime fromDate, DateTime toDate)
        {
            listThuNgan.Items.Clear();
            var cashierCounts = _orderBLL.GetCashierOrderCounts(fromDate, toDate).OrderByDescending(c => c.OrderCount).ToList();

            foreach (var cashier in cashierCounts)
            {
                if (cashierCounts == null) continue;
                var item = new ListViewItem(new string[]
                {
                    cashier.FullName,
                    cashier.OrderCount.ToString()
                });
                listThuNgan.Items.Add(item);
            }
        }
        public void LoadBaristaList(DateTime fromDate, DateTime toDate)
        {
            listPhaChe.Items.Clear();
            var baristaCounts = _baristaQueueBLL.GetBaristaCompletedCounts(fromDate, toDate).OrderByDescending(c => c.CompletedCount).ToList();

            foreach (var barista in baristaCounts)
            {
                if (baristaCounts == null) continue;
                var item = new ListViewItem(new string[]
                {
                    barista.FullName,
                    barista.CompletedCount.ToString()
                });
                listPhaChe.Items.Add(item);
            }
        }
        public void CalculateRevenueStatistics(DateTime fromDate, DateTime toDate)
        {
            try
            {
                txtTongDT.Text = "0";
                txtTongSP.Text = "0";
                txtTongKH.Text = "0";

                chartDoanhThu.Series["Doanh thu"].Points.Clear();
                chartSanPham.Series.Clear();
                chartSanPham.Legends.Clear();

                decimal totalRevenue = _revenueBLL.GetTotalRevenueByDateRange(fromDate, toDate);
                int totalProductsSold = _revenueBLL.GetTotalProductsSoldByDateRange(fromDate, toDate);
                int totalCustomers = _revenueBLL.GetTotalCustomersByDateRange(fromDate, toDate);
                var topProducts = _revenueBLL.GetTopSellingProductsByDateRange(fromDate, toDate);

                txtTongDT.Text = $"{totalRevenue:N0}đ";
                txtTongSP.Text = totalProductsSold.ToString();
                txtTongKH.Text = totalCustomers.ToString();

                // Vẽ chartDoanhThu
                var days = (toDate - fromDate).Days + 1;
                for (int i = 0; i < days; i++)
                {
                    var day = fromDate.AddDays(i);
                    decimal dayRevenue = _revenueBLL.GetTotalRevenueByDateRange(day, day);
                    chartDoanhThu.Series["Doanh thu"].Points.AddXY(day.ToString("dd/MM"), dayRevenue);
                }

                Legend legend = new Legend
                {
                    Name = "ProductLegend",
                    Docking = Docking.Bottom,
                    Alignment = StringAlignment.Center,
                    LegendStyle = LegendStyle.Table,
                    Font = new Font("Segoe UI", 10, FontStyle.Regular),
                    Title = "TOP SẢN PHẨM BÁN CHẠY",
                    TitleFont = new Font("Segoe UI", 11, FontStyle.Bold),
                    BorderColor = Color.LightGray,
                    IsTextAutoFit = false,
                    MaximumAutoSize = 40
                };
                chartSanPham.Legends.Add(legend);

                //Vẽ chartSanPham
                Series pieSeries = new Series
                {
                    Name = "TopProducts",
                    ChartType = SeriesChartType.Doughnut,
                    IsValueShownAsLabel = true,
                    Label = "#PERCENT{P0}",
                    Font = new Font("Segoe UI", 9, FontStyle.Bold),
                    LabelForeColor = Color.White,
                    BorderWidth = 1,
                    Legend = "ProductLegend"
                };

                Color[] colors = {
                    Color.FromArgb(74, 144, 226),
                    Color.FromArgb(126, 211, 33),
                    Color.FromArgb(245, 166, 35),
                    Color.FromArgb(144, 19, 254),
                    Color.FromArgb(255, 107, 107),
                    Color.FromArgb(80, 227, 194),
                    Color.FromArgb(255, 217, 61)
                };

                int colorIndex = 0;
                foreach (var product in topProducts)
                {
                    DataPoint point = new DataPoint();
                    point.SetValueXY(product.ItemName, product.TotalQuantity);
                    point.Color = colors[colorIndex++ % colors.Length];
                    point.LegendText = $"{product.ItemName} ({product.TotalQuantity})";
                    point.ToolTip = product.ItemName;

                    if (product.ItemName == "Khác")
                    {
                        point.Color = Color.DarkGray;
                        point.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                    }

                    pieSeries.Points.Add(point);
                }
                chartSanPham.Series.Add(pieSeries);

                pieSeries["PieLabelStyle"] = "Inside";
                chartSanPham.ChartAreas[0].Area3DStyle.Enable3D = false;
                chartSanPham.ChartAreas[0].Position = new ElementPosition(5, 5, 90, 50);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnLichSuDon_Click(object sender, EventArgs e)
        {
            new fLichSuDonHang().ShowDialog();
        }

        private void ucTongQuan_Load(object sender, EventArgs e)
        {
            fromDate = DateTime.Today;
            toDate = DateTime.Today.AddDays(1).AddTicks(-1);
            LoadCashierList(fromDate, toDate);
            LoadBaristaList(fromDate, toDate);
            CalculateRevenueStatistics(fromDate, toDate);
            MakeButtonRounded(btnToday, 15, Color.Gray);
            MakeButtonRounded(btn7Days, 15, Color.Gray);
            MakeButtonRounded(btn30Days, 15, Color.Gray);
            MakeButtonRounded(btnLichSuDon, 10, Color.Gray);
        }

    }
}
