using PBL3_CoffeeHome.BLL;
using System;
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
        public fLichSuDonHang()
        {
            InitializeComponent();
            _orderBLL = new OrderBLL();
            datePicker.Value = DateTime.Now.Date;
            LoadOrderHistory(datePicker.Value.Date);
        }
        private void LoadOrderHistory(DateTime selectedDate)
        {
            listDonHang.Items.Clear();
            var orders = _orderBLL.GetOrdersCompletedOnDate("Completed", selectedDate)
                        .OrderByDescending(o => o.BaristaQueues.FirstOrDefault().CompletedAt);

            foreach (var order in orders)
            {
                var completedQueue = order.BaristaQueues.FirstOrDefault();
                var completedAt = completedQueue?.CompletedAt.HasValue == true
                ? completedQueue.CompletedAt.Value.ToString("HH:mm") : "N/A";
                var item = new ListViewItem(new string[]
                {
                    order.OrderID,
                    completedAt,
                    order.TotalAmount.ToString("N0") + " VNĐ",
                });
                listDonHang.Items.Add(item);
            }
        }
    }
}
