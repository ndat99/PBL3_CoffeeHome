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
using PBL3_CoffeeHome.DTO;

namespace PBL3_CoffeeHome.GUI
{
    public partial class ucTaoDon: UserControl
    {
        private readonly MenuItemBLL _menuItemBLL;
        private readonly MenuItemIngredientBLL _menuItemIngredientBLL;
        public ucTaoDon()
        {
            InitializeComponent();
            _menuItemBLL = new MenuItemBLL();
            _menuItemIngredientBLL = new MenuItemIngredientBLL();
            LoadComboBoxData();
            LoadOrdersToday();
            LoadOrderHistory(DateTime.Now.Date);
            timerRefresh.Start();
        }
        private void LoadComboBoxData()
        {

        }
        private void LoadOrdersToday()
        {
            listDonHienCo.Items.Clear();
            var orders = _menuItemBLL.GetOrdersAssignedToday("Incompleted");

            foreach (var order in orders)
            {
                var item = new ListViewItem(new string[]
                {
                    "",
                    order.OrderID,
                    order.CreatedAt.ToString("HH:mm")
                });
                item.Tag = order;
                item.ImageIndex = 0;

                listDonHienCo.Items.Add(item);
            }
        }
        // Load lịch sử đơn hàng theo ngày
        private void LoadOrderHistory(DateTime selectedDate)
        {
            listDaHoanThanh.Items.Clear();
            var orders = _orderBLL.GetOrdersCompletedOnDate("Completed", selectedDate);

            foreach (var order in orders)
            {
                var completedQueue = order.BaristaQueues.FirstOrDefault();
                var item = new ListViewItem(new string[]
                {
                    "",
                    order.OrderID,
                    completedQueue.CompletedAt.Value.ToString("HH:mm")
                });
                item.Tag = order;
                item.ImageIndex = 1;

                listDaHoanThanh.Items.Add(item);
            }
        }
        private void btnBan_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            MessageBox.Show("Đang chọn " + btn.Text);
        }

        private void btnLichSuDon_Click(object sender, EventArgs e)
        {
            fLichSuDonHang f = new fLichSuDonHang();
            f.Show();
        }
        private void btnThemMon_Click(object sender, EventArgs e)
        {

        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            LoadOrdersToday();
            LoadOrderHistory(DateTime.Now.Date);
        }
    }

}
