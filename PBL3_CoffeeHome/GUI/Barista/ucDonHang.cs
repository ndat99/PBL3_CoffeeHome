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
using PBL3_CoffeeHome.DAL.Repository;

namespace PBL3_CoffeeHome.GUI
{
    public partial class ucDonHang : UserControl
    {
        private readonly MenuItemBLL _menuItemBLL;
        private readonly MenuItemIngredientBLL _menuItemIngredientBLL;
        private User _barista;
        public ucDonHang(User barista)
        {
            InitializeComponent();
            _menuItemBLL = new MenuItemBLL();
            _menuItemIngredientBLL = new MenuItemIngredientBLL();
            _barista = barista;
            LoadOrdersToday();
            LoadOrderHistory(datePicker.Value);
            timerRefresh.Start();
        }
        // Load danh sách đơn hàng hôm nay
        private void LoadOrdersToday()
        {
            listDonHang.Items.Clear();
            var orders = _menuItemBLL.GetOrdersAssignedToday("Incompleted").OrderByDescending(o => o.CreatedAt);

            foreach (var order in orders)
            {
                if (order == null) continue;
                var item = new ListViewItem(new string[]
                {
                    "",
                    order.OrderID,
                    order.CreatedAt.ToString("HH:mm")
                });
                item.Tag = order;
                item.ImageIndex = 0;

                listDonHang.Items.Add(item);
            }
        }
        // Load lịch sử đơn hàng theo ngày
        private void LoadOrderHistory(DateTime selectedDate)
        {
            listLichSuDon.Items.Clear();
            var orders = _menuItemBLL.GetOrdersCompletedOnDate("Completed", selectedDate)
                        .OrderByDescending(o => o.BaristaQueues.FirstOrDefault().CompletedAt);

            foreach (var order in orders)
            {
                var completedQueue = order.BaristaQueues.FirstOrDefault();
                var completedAt = completedQueue?.CompletedAt.HasValue == true
                ? completedQueue.CompletedAt.Value.ToString("HH:mm"): "N/A";
                var item = new ListViewItem(new string[]
                {
                    "",
                    order.OrderID,
                    completedAt
                });
                item.Tag = order;
                item.ImageIndex = 1;

                listLichSuDon.Items.Add(item);
            }
        }

        private void btnLichSuDon_Click(object sender, EventArgs e)
        {
            fLichSuDonHang f = new fLichSuDonHang();
            f.Show();
        }

        private void checkTrangThai_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (listDonHang.SelectedItems.Count > 0)
                {
                    var selectedOrder = (Order)listDonHang.SelectedItems[0].Tag;
                    _menuItemBLL.CompleteOrder(selectedOrder.OrderID, _barista.UserID);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một đơn hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                LoadOrdersToday();
                LoadOrderHistory(datePicker.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Hiển thị chi tiết đơn hàng
        private void listDonHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listDonHang.SelectedItems.Count > 0)
            {
                var selectedOrder = (Order)listDonHang.SelectedItems[0].Tag;
                var orderItems = _menuItemBLL.GetOrderDetails(selectedOrder.OrderID);

                dgvChiTietDon.Rows.Clear();
                foreach (var item in orderItems)
                {
                    dgvChiTietDon.Rows.Add(item.MenuItem.Name, item.Quantity, item.Subtotal);
                }
            }
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            LoadOrderHistory(datePicker.Value);
        }

        private void listLichSuDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listLichSuDon.SelectedItems.Count > 0)
            {
                var selectedOrder = (Order)listLichSuDon.SelectedItems[0].Tag;
                var orderItems = _menuItemBLL.GetOrderDetails(selectedOrder.OrderID);

                dgvChiTietDon.Rows.Clear();
                foreach (var item in orderItems)
                {
                    dgvChiTietDon.Rows.Add(item.MenuItem.Name, item.Quantity, item.Subtotal);
                }
            }
        }

        private void dgvChiTietDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvChiTietDon.SelectedRows.Count > 0)
            {
                var cellValue = dgvChiTietDon.SelectedRows[0].Cells[0].Value;
                if (cellValue == null) return;

                var tenMon = cellValue.ToString();
                var menuItem = _menuItemBLL.GetMenuItemByName(tenMon);
                var ingredients = _menuItemIngredientBLL.GetMenuItemIngredient(menuItem.MenuItemID);

                dgvCongThuc.Rows.Clear();

                foreach (var ingredient in ingredients)
                {
                    dgvCongThuc.Rows.Add(
                        ingredient.Inventory.Name,
                        ingredient.QuantityRequired,
                        ingredient.Inventory.Unit
                    );
                }
            }
        }
        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            LoadOrdersToday();
            LoadOrderHistory(DateTime.Now.Date);
        }
    }
}
