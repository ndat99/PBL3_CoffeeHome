using PBL3_CoffeeHome.BLL;
using PBL3_CoffeeHome.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_CoffeeHome.GUI
{
    public partial class fLichSuDonHang: Form
    {
        private readonly OrderBLL _orderBLL;
        private readonly BaristaQueueBLL _baristaQueueBLL;
        private readonly UserBLL _userBLL;
        public fLichSuDonHang()
        {
            InitializeComponent();
            _orderBLL = new OrderBLL();
            _baristaQueueBLL = new BaristaQueueBLL();
            _userBLL = new UserBLL();
            datePicker.Value = DateTime.Now.Date;
        }
        private void LoadOrderHistory(DateTime selectedDate)
        {
            listDonHang.Items.Clear();
            var queues = _baristaQueueBLL.GetQueueCompletedOnDate("Complete", selectedDate)
                        .OrderBy(bq => bq.CompletedAt);

            foreach (var queue in queues)
            {
                var item = new ListViewItem(new string[]
                {
                    queue.OrderID,
                    queue.CompletedAt.Value.ToString("HH:mm"),
                    queue.Order.TotalAmount.ToString("N0") + "VND",
                    _userBLL.GetUserById(queue.Order.UserID).FullName,
                    _userBLL.GetUserById(queue.BaristaID).FullName,
                });
                item.Tag = queue;
                item.ImageIndex = 1;

                listDonHang.Items.Add(item);
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            LoadOrderHistory(datePicker.Value.Date);
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            if (listDonHang.SelectedItems.Count > 0)
            {
                var selectedQueue = (BaristaQueue)listDonHang.SelectedItems[0].Tag;
                InBill(selectedQueue.OrderID);
                MessageBox.Show("In hóa đơn thành công", "Hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một đơn hàng để in hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void InBill(string orderId)
        {
            var order = _orderBLL.GetOrderDetails(orderId);
            if (order == null)
            {
                MessageBox.Show("Không tìm thấy đơn hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string projectPath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            string billFolderPath = Path.Combine(projectPath, "Bill");
            string fileName = "bill_" + order.OrderID + ".txt";
            string filePath = Path.Combine(billFolderPath, fileName);
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true, System.Text.Encoding.UTF8))
                {
                    writer.WriteLine(new string('=', 45));
                    writer.WriteLine("             HÓA ĐƠN THANH TOÁN           ");
                    writer.WriteLine(new string('=', 45));
                    writer.WriteLine($"Mã đơn hàng: {order.OrderID}");
                    writer.WriteLine($"Ngày tạo: {order.CreatedAt:dd/MM/yyyy HH:mm}");
                    writer.WriteLine($"Số bàn: {order.CardNumber}");
                    writer.WriteLine($"Nhân viên: {_userBLL.GetUserById(order.UserID).FullName}");
                    writer.WriteLine(new string('-', 45));
                    writer.WriteLine("Danh sách món:".PadRight(45));
                    writer.WriteLine(new string('-', 45));
                    writer.WriteLine($"{"Tên món".PadRight(20)}{"SL".PadRight(5)}{"Đơn giá".PadRight(10)}{"Thành tiền"}");

                    foreach (var item in order.OrderItems)
                    {
                        string tenMon = item.MenuItem.Name.Length > 18 ? item.MenuItem.Name.Substring(0, 15) + "..." : item.MenuItem.Name;
                        string soLuong = item.Quantity.ToString();
                        string donGia = item.Price.ToString("N0");
                        string thanhTien = (item.Price * item.Quantity).ToString("N0");
                        writer.WriteLine($"{tenMon.PadRight(20)}{soLuong.PadRight(5)}{donGia.PadRight(10)}{thanhTien}");
                    }

                    writer.WriteLine(new string('-', 45));
                    writer.WriteLine($"Tổng tiền:".PadRight(30) + $"{order.TotalAmount:N0} VNĐ");
                    writer.WriteLine($"Giảm giá:".PadRight(30) + $"{(order.Discount != null ? order.Discount.Name : "Không")}");
                    writer.WriteLine($"Tiền giảm:".PadRight(30) + $"{order.DiscountAmount:N0} VNĐ");
                    writer.WriteLine($"Tiền cuối cùng:".PadRight(30) + $"{order.FinalAmount:N0} VNĐ");
                    writer.WriteLine(new string('=', 45));
                    writer.WriteLine("    Cảm ơn quý khách đã sử dụng dịch vụ!");
                    writer.WriteLine(new string('=', 45));
                    writer.WriteLine();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu hóa đơn vào file: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fLichSuDonHang_Load(object sender, EventArgs e)
        {
            LoadOrderHistory(datePicker.Value.Date);
            MakeButtonRounded(btnInHoaDon, 10, Color.FromArgb(180, 180, 180));
            MakeButtonRounded(btnLoc, 10, Color.FromArgb(180, 180, 180));
        }
    }
}
