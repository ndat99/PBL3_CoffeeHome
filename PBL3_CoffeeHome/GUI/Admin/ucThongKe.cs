using System;
using System.Drawing;
using System.Windows.Forms;
using PBL3_CoffeeHome.BLL;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections.Generic;
using System.Linq;

namespace PBL3_CoffeeHome.GUI
{
    public partial class ucThongKe : UserControl
    {
        private readonly RevenueBLL _revenueBLL;

        public ucThongKe()
        {
            InitializeComponent();
            _revenueBLL = new RevenueBLL();

            cbThongKeTheo.Items.Clear();
            cbThongKeTheo.Items.AddRange(new string[] { "Ngày", "Tháng", "Khoảng thời gian" });
            cbThongKeTheo.SelectedIndex = -1;

            cbNam.Items.Clear();
            int currentYear = DateTime.Now.Year;
            for (int year = 2020; year <= currentYear; year++)
            {
                cbNam.Items.Add(year.ToString());
            }
            cbNam.SelectedIndex = -1;
            cbNam.Enabled = false;

            cbThang.Items.Clear();
            for (int month = 1; month <= 12; month++)
            {
                cbThang.Items.Add(month.ToString());
            }
            cbThang.SelectedIndex = -1;
            cbThang.Enabled = false;

            // Thiết lập DateTimePicker
            dtpBatDau.Format = DateTimePickerFormat.Custom;
            dtpBatDau.CustomFormat = "dd/MM/yyyy";
            dtpKetThuc.Format = DateTimePickerFormat.Custom;
            dtpKetThuc.CustomFormat = "dd/MM/yyyy";

            // Đặt ngày mặc định: đầu tháng đến hiện tại
            dtpBatDau.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpKetThuc.Value = DateTime.Now;
            dtpBatDau.Enabled = false;
            dtpKetThuc.Enabled = false;

            // Cấu hình biểu đồ
            chartDoanhThu.Series["DoanhThu"].ChartType = SeriesChartType.Column;
        }

        private void cbThongKeTheo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbThongKeTheo.SelectedItem == null) return;

            cbNam.SelectedIndex = -1;
            cbThang.SelectedIndex = -1;
            cbNam.Enabled = true;
            cbThang.Enabled = false;
            dtpBatDau.Enabled = false;
            dtpKetThuc.Enabled = false;

            string mode = cbThongKeTheo.SelectedItem.ToString();
            if (mode == "Tháng")
            {
                cbThang.Items.Clear();
                cbThang.Enabled = false;
            }
            else if (mode == "Ngày")
            {
                cbThang.Items.Clear();
                cbThang.Enabled = true;
                cbThang.Items.AddRange(Enumerable.Range(1, 12).Select(m => m.ToString()).ToArray());
            }
            else if (mode == "Khoảng thời gian")
            {
                cbThang.Items.Clear();
                cbNam.Enabled = false;
                cbThang.Enabled = false;
                dtpBatDau.Enabled = true;
                dtpKetThuc.Enabled = true;
            }
        }

        private void cbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbThongKeTheo.SelectedItem == null || cbThongKeTheo.SelectedItem.ToString() != "Ngày") return;
            cbThang.Enabled = cbNam.SelectedIndex != -1;
        }

        private int GetDayInterval(int totalDays)
        {
            if (totalDays <= 7) return 1;
            else if (totalDays <= 14) return 2;
            else if (totalDays <= 30) return 3;
            else if (totalDays <= 60) return 5;
            else if (totalDays <= 90) return 7;
            else if (totalDays <= 180) return 15;
            else if (totalDays <= 365) return 30;
            else if (totalDays <= 730) return 60;
            else if (totalDays <= 1460) return 90;
            else return 180;
        }

        public void CalculateRevenueStatistics(string mode, DateTime? startDate = null, DateTime? endDate = null, int year = 0, int? month = null)
        {
            try
            {
                txtTongDT.Text = "$0";
                txtTongSP.Text = "0";
                txtTongKH.Text = "0";

                chartDoanhThu.Series["DoanhThu"].Points.Clear();
                chartSanPham.Series.Clear();
                chartSanPham.Legends.Clear();

                // Reset trục X để tránh lỗi khi chuyển mode
                var axisX = chartDoanhThu.ChartAreas[0].AxisX;
                axisX.CustomLabels.Clear();
                axisX.Interval = 1;
                axisX.IntervalType = DateTimeIntervalType.Number;
                axisX.LabelStyle.Format = "";
                axisX.LabelStyle.Angle = 0;
                axisX.LabelStyle.IsStaggered = false;

                decimal totalRevenue;
                int totalProductsSold;
                int totalCustomers;
                List<(string ItemName, int TotalQuantity)> topProducts;
                if (mode == "Ngày" && month.HasValue)
                {
                    totalRevenue = _revenueBLL.GetTotalRevenueByMonth(year, month.Value);
                    totalProductsSold = _revenueBLL.GetTotalProductsSoldByMonth(year, month.Value);
                    totalCustomers = _revenueBLL.GetTotalCustomersByMonth(year, month.Value);
                    topProducts = _revenueBLL.GetTopSellingProductsByMonth(year, month.Value);
                    var dailyRevenue = _revenueBLL.GetDailyRevenueInMonth(year, month.Value);

                    // Vẽ cột cho tất cả các ngày có dữ liệu
                    foreach (var data in dailyRevenue.OrderBy(d => d.Day))
                    {
                        chartDoanhThu.Series["DoanhThu"].Points.AddXY(data.Day, data.Total);
                    }
                    chartDoanhThu.ChartAreas[0].AxisX.Interval = 2;

                }
                else if (mode == "Tháng")
                {
                    totalRevenue = _revenueBLL.GetTotalRevenueByYear(year);
                    totalProductsSold = _revenueBLL.GetTotalProductsSoldByYear(year);
                    totalCustomers = _revenueBLL.GetTotalCustomersByYear(year);
                    topProducts = _revenueBLL.GetTopSellingProductsByYear(year);
                    var monthlyRevenue = _revenueBLL.GetMonthlyRevenueInYear(year);


                    foreach (var data in monthlyRevenue)
                    {
                        chartDoanhThu.Series["DoanhThu"].Points.AddXY(data.Month, data.Total);
                    }
                    chartDoanhThu.ChartAreas[0].AxisX.Interval = 1; // Hiển thị tất cả số tháng
                }
                else if (mode == "Khoảng thời gian" && startDate.HasValue && endDate.HasValue)
                {
                    totalRevenue = _revenueBLL.GetTotalRevenueByDateRange(startDate.Value, endDate.Value);
                    totalProductsSold = _revenueBLL.GetTotalProductsSoldByDateRange(startDate.Value, endDate.Value);
                    totalCustomers = _revenueBLL.GetTotalCustomersByDateRange(startDate.Value, endDate.Value);
                    topProducts = _revenueBLL.GetTopSellingProductsByDateRange(startDate.Value, endDate.Value);
                    var dailyRevenue = _revenueBLL.GetDailyRevenueInDateRange(startDate.Value, endDate.Value);

                    // Tạo danh sách tất cả các ngày trong khoảng thời gian
                    var allDates = Enumerable.Range(0, (endDate.Value - startDate.Value).Days + 1)
                        .Select(d => startDate.Value.AddDays(d))
                        .ToList();
                    var revenueDict = dailyRevenue?.ToDictionary(x => x.Date.Date, x => x.Total) ?? new Dictionary<DateTime, decimal>();

                    // Vẽ cột cho tất cả các ngày, giá trị 0 nếu không có doanh thu
                    foreach (var date in allDates)
                    {
                        decimal revenue = revenueDict.ContainsKey(date.Date) ? revenueDict[date.Date] : 0m;
                        chartDoanhThu.Series["DoanhThu"].Points.AddXY(date.ToString("dd/MM/yyyy"), revenue);
                    }

                    int totalDays = (endDate.Value - startDate.Value).Days + 1;
                    int dayInterval = GetDayInterval(totalDays);
                    chartDoanhThu.ChartAreas[0].AxisX.Interval = dayInterval;
                    chartDoanhThu.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;
                    chartDoanhThu.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
                    if (totalDays > 30)
                    {
                        chartDoanhThu.ChartAreas[0].AxisX.IntervalOffset = dayInterval / 2;
                    }
                }
                else
                {
                    throw new ArgumentException("Chế độ thống kê không hợp lệ.");
                }

                txtTongDT.Text = $"${totalRevenue:N0}";
                txtTongSP.Text = totalProductsSold.ToString();
                txtTongKH.Text = totalCustomers.ToString();

                Legend legend = new Legend
                {
                    Name = "ProductLegend",
                    Docking = Docking.Bottom,
                    Alignment = StringAlignment.Center,
                    LegendStyle = LegendStyle.Table,
                    Font = new Font("Arial", 9, FontStyle.Regular),
                    Title = "TOP SẢN PHẨM BÁN CHẠY",
                    TitleFont = new Font("Arial", 10, FontStyle.Bold),
                    BorderColor = Color.LightGray,
                    IsTextAutoFit = false,
                    MaximumAutoSize = 60
                };
                chartSanPham.Legends.Add(legend);

                Series pieSeries = new Series
                {
                    Name = "TopProducts",
                    ChartType = SeriesChartType.Pie,
                    IsValueShownAsLabel = true,
                    Label = "#PERCENT{P0}",
                    Font = new Font("Arial", 9, FontStyle.Bold),
                    LabelForeColor = Color.White,
                    BorderWidth = 1,
                    Legend = "ProductLegend"
                };

                Color[] colors = {
            Color.FromArgb(65, 140, 240),
            Color.FromArgb(252, 180, 65),
            Color.FromArgb(70, 190, 100),
            Color.FromArgb(240, 80, 110),
            Color.FromArgb(170, 110, 210),
            Color.FromArgb(150, 150, 150)
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
                        point.Color = Color.LightGray;
                        point.Font = new Font("Arial", 8, FontStyle.Italic);
                    }

                    pieSeries.Points.Add(point);
                }

                chartSanPham.Series.Add(pieSeries);

                pieSeries["PieLabelStyle"] = "Inside";
                chartSanPham.ChartAreas[0].Area3DStyle.Enable3D = false;
                chartSanPham.ChartAreas[0].Position = new ElementPosition(5, 5, 90, 50);

                chartDoanhThu.ChartAreas[0].AxisY.Maximum = (double)(Math.Ceiling(totalRevenue * 1.2m / 50000m) * 50000m);
                chartDoanhThu.ChartAreas[0].AxisY.Interval = (double)(Math.Ceiling((totalRevenue * 1.2m) / 5 / 50000m) * 50000m) / 5;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (cbThongKeTheo.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn kiểu thống kê (Ngày, Tháng hoặc Khoảng thời gian).", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string mode = cbThongKeTheo.SelectedItem.ToString();

            if (mode == "Khoảng thời gian")
            {
                if (dtpBatDau.Value > dtpKetThuc.Value)
                {
                    MessageBox.Show("Ngày bắt đầu phải nhỏ hơn hoặc bằng ngày kết thúc.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                CalculateRevenueStatistics(mode, startDate: dtpBatDau.Value, endDate: dtpKetThuc.Value);
            }
            else
            {
                if (!int.TryParse(cbNam.SelectedItem?.ToString(), out int year))
                {
                    MessageBox.Show("Vui lòng chọn năm hợp lệ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int? month = null;
                if (mode == "Ngày")
                {
                    if (!int.TryParse(cbThang.SelectedItem?.ToString(), out int selectedMonth) || selectedMonth < 1 || selectedMonth > 12)
                    {
                        MessageBox.Show("Vui lòng chọn tháng hợp lệ (1-12).", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    month = selectedMonth;
                }

                CalculateRevenueStatistics(mode, year: year, month: month);
            }
        }

        private void ucThongKe_Load(object sender, EventArgs e)
        {
            MakeButtonRounded(btnLoc, 10, Color.Black);
        }
    }
}