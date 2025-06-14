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
using PBL3_CoffeeHome.DTO;
using PBL3_CoffeeHome.DAL.Repository;

namespace PBL3_CoffeeHome.GUI
{
    public partial class ucDonHang : UserControl
    {
        private OrderBLL _orderBLL;
        private readonly MenuItemBLL _menuItemBLL;
        private readonly MenuItemIngredientBLL _menuItemIngredientBLL;
        private BaristaQueueBLL _baristaQueueBLL;
        private User _barista;
        public ucDonHang(User barista)
        {
            InitializeComponent();
            _orderBLL = new OrderBLL();
            _menuItemBLL = new MenuItemBLL();
            _menuItemIngredientBLL = new MenuItemIngredientBLL();
            _baristaQueueBLL = new BaristaQueueBLL();
            _barista = barista;
            LoadOrdersToday();
            LoadOrderHistory(datePicker.Value);
            timerRefresh.Start();
            datePicker.Value = DateTime.Now.Date;
        }
        // Load danh sách đơn hàng hôm nay
        private void LoadOrdersToday()
        {
            listDonHang.Items.Clear();
            var queues = _baristaQueueBLL.GetQueueAssignedToday("Incomplete").OrderBy(bq => bq.AssignedAt);

            foreach (var queue in queues)
            {
                if (queues == null) continue;
                var item = new ListViewItem(new string[]
                {
                    "",
                    queue.OrderID,
                    queue.AssignedAt.ToString("HH:mm")
                });
                item.Tag = queue;
                item.ImageIndex = 0;

                listDonHang.Items.Add(item);
            }
        }
        // Load lịch sử đơn hàng theo ngày
        private void LoadOrderHistory(DateTime selectedDate)
        {
            listLichSuDon.Items.Clear();
            var queues = _baristaQueueBLL.GetQueueCompletedOnDate("Complete", selectedDate)
                        .OrderByDescending(bq => bq.CompletedAt).ToList();

            foreach (var queue in queues)
            {
                var item = new ListViewItem(new string[]
                {
                    "",
                    queue.OrderID,
                    queue.CompletedAt.HasValue ? queue.CompletedAt.Value.ToString("HH:mm") : "N/A"
                });
                item.Tag = queue;
                item.ImageIndex = 1;

                listLichSuDon.Items.Add(item);
            }
        }
        // Ấn nút để hoàn thành đơn hàng
        private void btnChuyenTrangThai_Click(object sender, EventArgs e)
        {
            try
            {
                if (listDonHang.SelectedItems.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Bạn có chắn chắn muốn chuyển trạng thái?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (result == DialogResult.Yes)
                    {
                        var selectedQueue = (BaristaQueue)listDonHang.SelectedItems[0].Tag;
                        _orderBLL.CompleteOrder(selectedQueue.OrderID, selectedQueue.QueueID, _barista.UserID);
                    }
                    else return;
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
                var selectedQueue = (BaristaQueue)listDonHang.SelectedItems[0].Tag;
                var orderItems = _orderBLL.GetOrderItemsByOrderId(selectedQueue.OrderID);

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
                var selectedQueue = (BaristaQueue)listLichSuDon.SelectedItems[0].Tag;
                var orderItems = _orderBLL.GetOrderItemsByOrderId(selectedQueue.OrderID);

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
        private void ucDonHang_Load(object sender, EventArgs e)
        {
            MakeButtonRounded(btnChuyenTrangThai, 10, Color.FromArgb(180, 180, 180));
        }
    }
}