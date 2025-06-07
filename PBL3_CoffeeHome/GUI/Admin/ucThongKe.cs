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
                cbThang.Items.Clear();
                cbThang.Enabled = false;

            }
            else if (mode == "Ngày")
            {
                cbThang.Items.Clear();
                cbThang.Enabled = true;
                for (int month = 1; month <= 12; month++)
                {
                    cbThang.Items.Add(month.ToString());
                }
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
                txtTongDT.Text = "$0";
                txtTongSP.Text = "0";
                txtTongKH.Text = "0";

                chartDoanhThu.Series["Series1"].Points.Clear();
                chartSanPham.Series.Clear();
                chartSanPham.Legends.Clear();

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

                }
                else if (mode == "Tháng")
                {
                    totalRevenue = _revenueBLL.GetTotalRevenueByYear(year);
                    totalProductsSold = _revenueBLL.GetTotalProductsSoldByYear(year);
                    totalCustomers = _revenueBLL.GetTotalCustomersByYear(year);
                    topProducts = _revenueBLL.GetTopSellingProductsByYear(year);

                }
                else
                {
                    throw new ArgumentException("Chế độ thống kê không hợp lệ.");
                }


                txtTongDT.Text = $"${totalRevenue:N0}";
                txtTongSP.Text = totalProductsSold.ToString();
                txtTongKH.Text = totalCustomers.ToString();


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
                //pieSeries["PieDrawingStyle"] = "Concave";
                chartSanPham.ChartAreas[0].Area3DStyle.Enable3D = false;
                //chartSanPham.ChartAreas[0].Area3DStyle.Inclination = 30;
                chartSanPham.ChartAreas[0].Position = new ElementPosition(5, 5, 90, 50);
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

        private void ucThongKe_Load(object sender, EventArgs e)
        {
            MakeButtonRounded(btnLoc, 10, Color.Black);
        }
    }
}