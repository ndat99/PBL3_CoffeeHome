using PBL3_CoffeeHome.BLL;
using PBL3_CoffeeHome.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            LoadOrderHistory(datePicker.Value.Date);
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
                var order = _orderBLL.GetOrderDetails(selectedQueue.OrderID);
                string billMessage = "===== HÓA ĐƠN =====\n\n" +
                                     $"Mã đơn hàng: {order.OrderID}\n" +
                                     $"Ngày tạo: {order.CreatedAt:dd/MM/yyyy HH:mm}\n" +
                                     $"Số bàn: {order.CardNumber}\n" +
                                     $"Nhân viên: {_userBLL.GetUserById(order.UserID).FullName}\n\n" +
                                     "----- Danh sách món -----\n";
                foreach (var item in order.OrderItems)
                {
                    billMessage += $"{item.MenuItem.Name} x {item.Quantity}: {item.Price * item.Quantity:N0} VNĐ\n";
                }
                billMessage += $"\nTổng tiền: {order.TotalAmount:N0} VNĐ\n" +
                               $"Giảm giá: {(order.Discount != null ? order.Discount.Name : "Không")}\n" +
                               $"Tiền giảm: {order.DiscountAmount:N0} VNĐ\n" +
                               $"Tiền cuối cùng: {order.FinalAmount:N0} VNĐ\n\n" +
                               "Cảm ơn quý khách đã sử dụng dịch vụ!";
                MessageBox.Show(billMessage, "Hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một đơn hàng để in hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
