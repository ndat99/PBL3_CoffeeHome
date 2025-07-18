﻿using System;
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
    public partial class ucLoiNhuan: UserControl
    {
        private readonly RevenueBLL _revenueBLL;
        public ucLoiNhuan()
        {
            InitializeComponent();
            _revenueBLL = new RevenueBLL();
            SetupComboBoxes();
            SetupChart();
        }

        private void SetupComboBoxes()
        {
            cbNam.Items.Clear();

            // Lấy danh sách năm có dữ liệu từ RevenueBLL
            var years = _revenueBLL.GetAllYearsWithData(); 

            foreach (var year in years.OrderBy(y => y))
            {
                cbNam.Items.Add(year);
            }
            cbNam.SelectedIndex = 0;
        }

        private void SetupChart()
        {
            chartLoiNhuan.Series.Clear();

            // Series Doanh Thu
            Series revenueSeries = new Series("Doanh Thu")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.DodgerBlue,
                IsValueShownAsLabel = true,
                LabelFormat = "#,##0",
                ["PointWidth"] = "0.3"  // Giảm độ rộng cột
            };

            // Series Chi Phí
            Series expenseSeries = new Series("Chi Phí")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.OrangeRed,
                IsValueShownAsLabel = true,
                LabelFormat = "#,##0",
                ["PointWidth"] = "0.3"  // Giảm độ rộng cột
            };

            // Series Lợi Nhuận
            Series profitSeries = new Series("Lợi Nhuận")
            {
                ChartType = SeriesChartType.Spline,  // Đổi thành đường cong
                Color = Color.FromArgb(114, 187, 83),
                BorderWidth = 2,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 7,
                IsValueShownAsLabel = true,
                ["LabelOffset"] = "50",  // Đẩy label ra xa điểm
                YAxisType = AxisType.Secondary
            };

            chartLoiNhuan.Series.Add(revenueSeries);
            chartLoiNhuan.Series.Add(expenseSeries);
            chartLoiNhuan.Series.Add(profitSeries);

            // Định dạng biểu đồ
            var area = chartLoiNhuan.ChartAreas[0];

            // Trục X
            area.AxisX.Interval = 2;  // Giãn khoảng hiển thị nhãn
            area.AxisX.LabelStyle.Angle = -45;
            area.AxisX.LabelStyle.Font = new Font("Segoe UI", 8, FontStyle.Regular);
            area.AxisX.MajorGrid.Enabled = false;

            // Trục Y chính (cho doanh thu và chi phí)
            area.AxisY.LabelStyle.Format = "#,##0";
            area.AxisY.LabelStyle.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            area.AxisY.MajorGrid.LineColor = Color.FromArgb(50, Color.Gray);
            area.AxisY.Minimum = 0;

            // Trục Y phụ (cho lợi nhuận)
            area.AxisY2.Enabled = AxisEnabled.True;
            area.AxisY2.LabelStyle.Format = "#,##0";
            area.AxisY2.LabelStyle.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            area.AxisY2.LineColor = Color.FromArgb(80, 200, 80);
            area.AxisY2.MajorGrid.Enabled = false;

            // Legend
            chartLoiNhuan.Legends[0].Enabled = true;
            chartLoiNhuan.Legends[0].Docking = Docking.Top;
            chartLoiNhuan.Legends[0].Font = new Font("Segoe UI", 9, FontStyle.Regular);
            chartLoiNhuan.Legends[0].Alignment = StringAlignment.Center;

            // Thêm padding cho chart
            chartLoiNhuan.ChartAreas[0].Position.Auto = false;
            chartLoiNhuan.ChartAreas[0].Position = new ElementPosition(5, 10, 90, 85);

            chartLoiNhuan.Series["Lợi Nhuận"].IsValueShownAsLabel = false;
            chartLoiNhuan.Series["Doanh Thu"].IsValueShownAsLabel = false;
            chartLoiNhuan.Series["Chi Phí"].IsValueShownAsLabel = false;
        }

        
        private void LoadChartData(int year)
        {
            try
            {
                foreach (var series in chartLoiNhuan.Series)
                {
                    series.Points.Clear();
                }

                var data = _revenueBLL.GetProfitByMonths(year);

                if (!data.Any())
                {
                    MessageBox.Show("Không có dữ liệu cho năm này!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int labelInterval = (int)Math.Ceiling(data.Count / 1.0);

                for (int i = 0; i < data.Count; i++)
                {
                    var item = data[i];

                    var revenuePoint = chartLoiNhuan.Series["Doanh Thu"].Points.Add((double)item.DoanhThu);
                    var expensePoint = chartLoiNhuan.Series["Chi Phí"].Points.Add((double)item.ChiPhi);
                    var profitPoint = chartLoiNhuan.Series["Lợi Nhuận"].Points.Add((double)item.LoiNhuan);

                    if (i % labelInterval == 0)
                    {
                        revenuePoint.AxisLabel = item.ThoiGian; 
                    }

                    string profitLabel = item.LoiNhuan >= 0
                        ? $"+{item.LoiNhuan:#,##0}"
                        : $"{item.LoiNhuan:#,##0}";

                    profitPoint.Label = profitLabel;
                    profitPoint.LabelForeColor = item.LoiNhuan >= 0 ? Color.Green : Color.Red;
                    profitPoint.MarkerColor = item.LoiNhuan >= 0 ? Color.Green : Color.Red;
                }

                var maxValue = Math.Max(
                    data.Max(x => x.DoanhThu),
                    data.Max(x => x.ChiPhi));
                chartLoiNhuan.ChartAreas[0].AxisY.Maximum = (double)maxValue * 1.1;

                var maxProfit = data.Max(x => Math.Abs(x.LoiNhuan));
                chartLoiNhuan.ChartAreas[0].AxisY2.Minimum = (double)-maxProfit * 1.1;
                chartLoiNhuan.ChartAreas[0].AxisY2.Maximum = (double)maxProfit * 1.1;

                chartLoiNhuan.Update();

                decimal tongDoanhThu = data.Sum(x => x.DoanhThu);
                decimal tongChiPhi = data.Sum(x => x.ChiPhi);
                decimal tongLoiNhuan = data.Sum(x => x.LoiNhuan);

                // Hiển thị vào các TextBox
                txtTongDT.Text = $"{tongDoanhThu:#,##0} Đ";
                txtTongChi.Text = $"{tongChiPhi:#,##0} Đ";
                txtTongLoiNhuan.Text = $"{(tongLoiNhuan >= 0 ? "+" : "")}{tongLoiNhuan:#,##0} Đ";

                // Đổi màu theo giá trị lợi nhuận
                txtTongLoiNhuan.ForeColor = tongLoiNhuan >= 0 ? Color.FromArgb(114, 187, 83) : Color.Red;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadChartData(DateTime startDate, DateTime endDate)
        {
            try
            {
                // Xóa dữ liệu cũ trong chart
                foreach (var series in chartLoiNhuan.Series)
                {
                    series.Points.Clear();
                }

                // Lấy dữ liệu từ RevenueBLL
                var data = _revenueBLL.GetProfitByDateRange(startDate, endDate);

                if (!data.Any())
                {
                    MessageBox.Show("Không có dữ liệu trong khoảng thời gian này!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Tính toán khoảng cách giữa các label trên trục X
                int labelInterval = (int)Math.Ceiling(data.Count / 12.0); // Hiển thị tối đa 12 label

                decimal maxValue = 0;
                decimal maxProfit = 0;

                for (int i = 0; i < data.Count; i++)
                {
                    var item = data[i];

                    // Thêm điểm dữ liệu vào từng series
                    var revenuePoint = chartLoiNhuan.Series["Doanh Thu"].Points.Add((double)item.DoanhThu);
                    var expensePoint = chartLoiNhuan.Series["Chi Phí"].Points.Add((double)item.ChiPhi);
                    var profitPoint = chartLoiNhuan.Series["Lợi Nhuận"].Points.Add((double)item.LoiNhuan);

                    // Thêm label cho trục X
                    if (i % labelInterval == 0)
                    {
                        revenuePoint.AxisLabel = item.Date;
                    }

                    // Định dạng label cho lợi nhuận
                    string profitLabel = item.LoiNhuan >= 0
                        ? $"+{item.LoiNhuan:#,##0}"
                        : $"{item.LoiNhuan:#,##0}";

                    profitPoint.Label = profitLabel;
                    profitPoint.LabelForeColor = item.LoiNhuan >= 0 ? Color.Green : Color.Red;
                    profitPoint.MarkerColor = item.LoiNhuan >= 0 ? Color.Green : Color.Red;

                    // Cập nhật giá trị lớn nhất
                    maxValue = Math.Max(maxValue, Math.Max(item.DoanhThu, item.ChiPhi));
                    maxProfit = Math.Max(maxProfit, Math.Abs(item.LoiNhuan));
                }

                // Điều chỉnh tỷ lệ trục Y
                chartLoiNhuan.ChartAreas[0].AxisY.Maximum = (double)maxValue * 1.1;
                chartLoiNhuan.ChartAreas[0].AxisY2.Minimum = (double)-maxProfit * 1.1;
                chartLoiNhuan.ChartAreas[0].AxisY2.Maximum = (double)maxProfit * 1.1;

                // Cập nhật biểu đồ
                chartLoiNhuan.Update();

                // Tính tổng các giá trị
                decimal tongDoanhThu = data.Sum(x => x.DoanhThu);
                decimal tongChiPhi = data.Sum(x => x.ChiPhi);
                decimal tongLoiNhuan = data.Sum(x => x.LoiNhuan);

                // Hiển thị tổng vào các TextBox
                txtTongDT.Text = $"{tongDoanhThu:#,##0} Đ";
                txtTongChi.Text = $"{tongChiPhi:#,##0} Đ";
                txtTongLoiNhuan.Text = $"{(tongLoiNhuan >= 0 ? "+" : "")}{tongLoiNhuan:#,##0} Đ";

                // Đổi màu theo giá trị lợi nhuận
                txtTongLoiNhuan.ForeColor = tongLoiNhuan >= 0 ? Color.FromArgb(114, 187, 83) : Color.Red;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnLoc_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbThongKeTheo.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn hình thức thống kê!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cbThongKeTheo.SelectedItem.ToString() == "Năm")
                {
                    if (cbNam.SelectedItem == null)
                    {
                        MessageBox.Show("Vui lòng chọn năm!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    int year = (int)cbNam.SelectedItem;
                    LoadChartData(year);
                }
                else // Theo khoảng thời gian
                {
                    DateTime startDate = dateTimePickerBatDau.Value.Date;
                    DateTime endDate = dateTimePickerKetThuc.Value.Date;

                    if (startDate > endDate)
                    {
                        MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if ((endDate - startDate).TotalDays > 31)
                    {
                        MessageBox.Show("Khoảng thời gian không được vượt quá 31 ngày", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    LoadChartData(startDate, endDate);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ucLoiNhuan_Load(object sender, EventArgs e)
        {
            MakeButtonRounded(btnLoc, 10, Color.Black);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbThongKeTheo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbThongKeTheo.SelectedItem != null && cbThongKeTheo.SelectedItem.ToString() == "Năm")
            {
                cbNam.Enabled = true;
                dateTimePickerBatDau.Enabled = false;
                dateTimePickerKetThuc.Enabled = false;
            }
            else
            {
                cbNam.Enabled = false;
                dateTimePickerBatDau.Enabled = true;
                dateTimePickerKetThuc.Enabled = true;
            }
        }

    }
}
