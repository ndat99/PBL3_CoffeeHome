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

namespace PBL3_CoffeeHome.GUI
{
    public partial class ucThongKe : UserControl
    {
        private readonly RevenueBLL _revenueBLL;

        public ucThongKe()
        {
            InitializeComponent();
            _revenueBLL = new RevenueBLL();

            // Khởi tạo dữ liệu cho các combobox
            cbThongKeTheo.Items.Clear();
            cbThongKeTheo.Items.AddRange(new string[] { "Ngày", "Tháng" });
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

            // Gắn sự kiện
            cbThongKeTheo.SelectedIndexChanged += cbThongKeTheo_SelectedIndexChanged;
            cbNam.SelectedIndexChanged += cbNam_SelectedIndexChanged;
            btnLoc.Click += btnLoc_Click;
        }

        private void cbThongKeTheo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbThongKeTheo.SelectedItem == null) return;

            cbNam.SelectedIndex = -1;
            cbThang.SelectedIndex = -1;
            cbNam.Enabled = true;
            cbThang.Enabled = false;

            string mode = cbThongKeTheo.SelectedItem.ToString();
            if (mode == "Tháng")
            {
                cbThang.Enabled = false;
                cbThang.Items.Clear();
            }
            else if (mode == "Ngày")
            {
                cbThang.Enabled = true;
            }
        }

        private void cbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbThongKeTheo.SelectedItem == null) return;

            if (cbThongKeTheo.SelectedItem.ToString() == "Ngày" && cbNam.SelectedItem != null)
            {
                cbThang.Enabled = true;
            }
        }

        public void CalculateRevenueStatistics(string mode, int year, int? month = null)
        {
            try
            {
                // Xóa dữ liệu cũ trong biểu đồ
                chartDoanhThu.Series["Series1"].Points.Clear();
                // chartSanPham.Series["CaPheDen"].Points.Clear();

                // Cập nhật tổng Series1, sản phẩm đã bán, và lượng khách
                decimal totalRevenue = _revenueBLL.GetTotalRevenue();
                int totalProductsSold = _revenueBLL.GetTotalProductsSold();
                int totalCustomers = _revenueBLL.GetTotalCustomers();

                // Hiển thị trên giao diện trong các panel
                txtTongDT.Text = $"${totalRevenue:N0}";
                txtTongSP.Text = totalProductsSold.ToString();
                txtTongKH.Text = totalCustomers.ToString();

                // Xử lý Series1 theo ngày hoặc tháng
                if (mode == "Ngày" && month.HasValue)
                {
                    var dailyRevenue = _revenueBLL.GetDailyRevenueInMonth(year, month.Value);
                    foreach (var data in dailyRevenue)
                    {
                        chartDoanhThu.Series["Series1"].Points.AddXY(data.Day, data.Total);
                    }
                }
                else if (mode == "Tháng")
                {
                    var monthlyRevenue = _revenueBLL.GetMonthlyRevenueInYear(year);
                    foreach (var data in monthlyRevenue)
                    {
                        chartDoanhThu.Series["Series1"].Points.AddXY(data.Month, data.Total);
                    }
                }

                // Xử lý sản phẩm bán chạy nhất - Biểu đồ tròn
                // Xóa dữ liệu cũ
                chartSanPham.Series.Clear();
                chartSanPham.Legends.Clear();

                // Tạo legend (chú thích) ở phía dưới
                Legend legend = new Legend
                {
                    Name = "ProductLegend",
                    Docking = Docking.Bottom,
                    Alignment = StringAlignment.Center,
                    LegendStyle = LegendStyle.Table, // Sử dụng Table để hiển thị linh hoạt hơn
                    Font = new Font("Arial", 9, FontStyle.Regular),
                    Title = "TOP SẢN PHẨM BÁN CHẠY",
                    TitleFont = new Font("Arial", 10, FontStyle.Bold),
                    BorderColor = Color.LightGray,
                    IsTextAutoFit = false, // Tắt tự động điều chỉnh kích thước chữ
                    MaximumAutoSize = 60 // Tăng không gian dành cho legend
                };
                chartSanPham.Legends.Add(legend);

                // Tạo series biểu đồ tròn
                Series pieSeries = new Series
                {
                    Name = "TopProducts",
                    ChartType = SeriesChartType.Pie,
                    IsValueShownAsLabel = true,
                    Label = "#PERCENT{P0}", // Hiển thị phần trăm
                    Font = new Font("Arial", 9, FontStyle.Bold),
                    LabelForeColor = Color.White,
                    BorderWidth = 1,
                    Legend = "ProductLegend"
                };

                // Lấy dữ liệu top sản phẩm từ BLL
                var topProducts = new RevenueBLL().GetTopSellingProducts();

                // Kiểm tra dữ liệu
                if (!topProducts.Any())
                {
                    chartSanPham.Titles.Add(new Title("Không có dữ liệu sản phẩm", Docking.Top, new Font("Arial", 12, FontStyle.Bold), Color.Red));
                    return;
                }

                // Màu sắc cho các phần
                Color[] colors = {
        Color.FromArgb(65, 140, 240),  // Xanh dương
        Color.FromArgb(252, 180, 65),  // Cam
        Color.FromArgb(70, 190, 100),  // Xanh lá
        Color.FromArgb(240, 80, 110),  // Đỏ
        Color.FromArgb(170, 110, 210), // Tím
        Color.FromArgb(150, 150, 150)  // Xám (cho phần Khác)
    };

                int colorIndex = 0;
                foreach (var product in topProducts)
                {
                    DataPoint point = new DataPoint();
                    point.SetValueXY(product.ItemName, product.TotalQuantity);
                    point.Color = colors[colorIndex++ % colors.Length];
                    point.LegendText = $"{product.ItemName} ({product.TotalQuantity})";
                    point.ToolTip = product.ItemName; // Hiển thị tên đầy đủ khi hover

                    // Định dạng đặc biệt cho phần "Khác"
                    if (product.ItemName == "Khác")
                    {
                        point.Color = Color.LightGray;
                        point.Font = new Font("Arial", 8, FontStyle.Italic);
                    }

                    pieSeries.Points.Add(point);
                }

                chartSanPham.Series.Add(pieSeries);

                // Tùy chỉnh hiển thị
                pieSeries["PieLabelStyle"] = "Inside"; // Nhãn nằm bên trong
                pieSeries["PieDrawingStyle"] = "Concave";
                chartSanPham.ChartAreas[0].Area3DStyle.Enable3D = true;
                chartSanPham.ChartAreas[0].Area3DStyle.Inclination = 30;

                // Điều chỉnh kích thước để dành chỗ cho legend
                chartSanPham.ChartAreas[0].Position = new ElementPosition(5, 5, 90, 50); // Giảm chiều cao để dành chỗ cho legend
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
                MessageBox.Show("Vui lòng chọn kiểu thống kê (Ngày hoặc Tháng).", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string mode = cbThongKeTheo.SelectedItem.ToString();

            if (!int.TryParse(cbNam.SelectedItem?.ToString(), out int year))
            {
                MessageBox.Show("Vui lòng chọn năm hợp lệ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int? month = null;
            if (mode == "Ngày")
            {
                if (!int.TryParse(cbThang.SelectedItem?.ToString(), out int selectedMonth))
                {
                    MessageBox.Show("Vui lòng chọn tháng hợp lệ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                month = selectedMonth;
            }

            CalculateRevenueStatistics(mode, year, month);
        }

       
    }
}