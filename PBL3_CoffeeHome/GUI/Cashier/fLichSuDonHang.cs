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
        private readonly BaristaQueueBLL _baristaQueueBLL;
        public fLichSuDonHang()
        {
            InitializeComponent();
            _baristaQueueBLL = new BaristaQueueBLL();
            datePicker.Value = DateTime.Now.Date;
            LoadOrderHistory(datePicker.Value.Date);
        }
        private void LoadOrderHistory(DateTime selectedDate)
        {
            listDonHang.Items.Clear();
            var queues = _baristaQueueBLL.GetQueueCompletedOnDate("Complete", selectedDate)
                        .OrderByDescending(bq => bq.CompletedAt);

            foreach (var queue in queues)
            {
                var item = new ListViewItem(new string[]
                {
                    queue.OrderID,
                    queue.CompletedAt.Value.ToString("HH:mm"),
                    queue.Order.TotalAmount.ToString("N0") + "VND"
                });
                item.Tag = queue;
                item.ImageIndex = 1;

                listDonHang.Items.Add(item);
            }
        }
    }
}
