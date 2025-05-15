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
        private OrderBLL _orderBLL;
        private readonly MenuItemBLL _menuItemBLL;
        private readonly MenuItemIngredientBLL _menuItemIngredientBLL;
        public ucTaoDon()
        {
            InitializeComponent();
            _orderBLL = new OrderBLL();
            _menuItemBLL = new MenuItemBLL();
            _menuItemIngredientBLL = new MenuItemIngredientBLL();
            LoadComboBoxData();
            LoadOrdersToday();
            LoadOrderHistory(DateTime.Now.Date);
            timerRefresh.Start();
        }
        private string GenerateOrderID(DateTime date)
        {
            string datePart = date.ToString("yyyyMMdd");
            DateTime startDate = date.Date;
            DateTime endDate = startDate.AddDays(1);

            using (var context = new CoffeeDbContext())
            {
                // Đếm số đơn hàng trong ngày
                int orderCount = context.Orders
                    .Count(o => o.CreatedAt >= startDate && o.CreatedAt < endDate);

                // Tạo ID mới
                return "ORD" + datePart + (orderCount + 1).ToString("D3");
            }
        }
        // Thêm phương thức GenerateQueueID
        private string GenerateQueueID()
        {
            using (var context = new CoffeeDbContext())
            {
                int maxIdNumber = 0;
                try
                {
                    var lastQueue = context.BaristaQueues
                        .OrderByDescending(q => q.QueueID)
                        .FirstOrDefault();

                    if (lastQueue != null && lastQueue.QueueID.StartsWith("BQ"))
                    {
                        string lastId = lastQueue.QueueID.Substring(2); // Lấy phần số (ví dụ: "044" từ "BQ044")
                        if (int.TryParse(lastId, out int number))
                        {
                            maxIdNumber = number;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Lỗi khi tạo QueueID: {ex.Message}");
                    maxIdNumber = 0;
                }

                int newIdNumber = maxIdNumber + 1;
                return "BQ" + newIdNumber.ToString("D3"); // Ví dụ: BQ045
            }
        }

        // cập nhật danh sách món ăn theo danh mục
        private void UpdateMonComboBox(string selectedCategory)
        {
            var filteredItems = _allMenuItems
                .Where(item => item.Category == selectedCategory)
                .Select(item => item.Name)
                .ToArray();

            cBMon.Items.Clear();
            cBMon.Items.AddRange(filteredItems);
        }

        private void LoadComboBoxData()
        {

        }

        // Load danh sách đơn hàng hôm nay
        private void LoadOrdersToday()
        {
            listDonHienCo.Items.Clear();
            var orders = _orderBLL.GetOrdersAssignedToday("Incompleted").OrderByDescending(o => o.CreatedAt);

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
            var orders = _orderBLL.GetOrdersCompletedOnDate("Completed", selectedDate)
                        .OrderByDescending(o => o.BaristaQueues.FirstOrDefault().CompletedAt);

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

        private bool CheckKhoDu(string menuItemId, int soLuong)
        {
            var ingredients = _menuItemIngredientBLL.GetMenuItemIngredient(menuItemId);
            if (ingredients == null) return false;

            foreach (var ingredient in ingredients)
            {
                var inventory = _inventoryBLL.GetInventoryByID(ingredient.ItemID);
                if (inventory == null || inventory.Quantity < (ingredient.QuantityRequired * soLuong))
                    return false;
            }
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (cBMon.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn món!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string selectedItemName = cBMon.SelectedItem.ToString();
                var selectedItem = _menuItemBLL.GetMenuItemByName(selectedItemName);
                if (selectedItem == null)
                {
                    MessageBox.Show("Không tìm thấy thông tin món!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int soLuongThem = (int)numSoLuong.Value;
                if (soLuongThem <= 0)
                {
                    MessageBox.Show("Số lượng phải lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!CheckKhoDu(selectedItem.MenuItemID, soLuongThem))
                {
                    MessageBox.Show("Không đủ nguyên liệu cho món này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var existingItem = _currentOrderItems.FirstOrDefault(x => x.MenuItemID == selectedItem.MenuItemID);
                if (existingItem != null)
                {
                    int soLuongMoi = existingItem.Quantity + soLuongThem;
                    if (!CheckKhoDu(selectedItem.MenuItemID, soLuongMoi))
                    {
                        MessageBox.Show("Không đủ nguyên liệu cho tổng số lượng món này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    existingItem.Quantity = soLuongMoi;
                    existingItem.Subtotal = existingItem.Quantity * selectedItem.Price;

                    var existingDisplay = _listDataTable.FirstOrDefault(x => x.Name == selectedItem.Name);
                    if (existingDisplay != null)
                    {
                        existingDisplay.Quantity = soLuongMoi;
                        existingDisplay.TotalPrice = existingDisplay.Quantity * selectedItem.Price;
                    }
                }
                else
                {
                    var newOrderItem = new OrderItem
                    {
                        MenuItemID = selectedItem.MenuItemID,
                        Quantity = soLuongThem,
                        Price = selectedItem.Price,
                        Subtotal = selectedItem.Price * soLuongThem
                    };
                    _currentOrderItems.Add(newOrderItem);

                    _listDataTable.Add(new OrderDisplayDTO
                    {
                        Name = selectedItem.Name,
                        Quantity = soLuongThem,
                        CostPrice = selectedItem.Price,
                        TotalPrice = selectedItem.Price * soLuongThem
                    });
                }
                dgvChiTietDon.Refresh();

                txtThanhTien.Text = TinhTongTien().ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private decimal TinhTongTien()
        {
            decimal tong = _listDataTable.Sum(x => x.TotalPrice);
            int giamGia = 0;
            int.TryParse(txtGiamGia.Text, out giamGia);
            tong = tong * (100 - giamGia) / 100;
            return tong;
        }
=======
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

        private void listDonHienCo_SelectedIndexChanged(object sender, EventArgs e)
        {
                    decimal finalAmount = total - discountAmount;

                    var newOrder = new Order
                    {
                        OrderID = orderID,
                        CreatedAt = DateTime.Now,
                        //Status = "Incompleted",
                        CardNumber = cardNumber,
                        TotalAmount = total,
                        DiscountAmount = discountAmount,
                        FinalAmount = finalAmount,
                        UserID = userId,
                        DiscountID = discountId
                    };
                    context.Orders.Add(newOrder);
                    if (orderItemList.Count == 0)
                    {
                        MessageBox.Show("Không có món nào để lưu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Kiểm tra các giá trị required
                    if (string.IsNullOrEmpty(orderID) || string.IsNullOrEmpty(userId))
                    {
                        MessageBox.Show("Thiếu thông tin bắt buộc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    context.OrderItems.AddRange(orderItemList);
                    //Tạo bản ghi mới trong BaristaQueues
                    string queueID = GenerateQueueID();
                    var newBaristaQueue = new BaristaQueue
                    {
                        QueueID = queueID,
                        OrderID = orderID,
                        BaristaID = "USR004",
                        Status = "Incompleted",
                        AssignedAt = DateTime.Today,
                        CompletedAt = null
                    };
                    context.BaristaQueues.Add(newBaristaQueue);
                    context.SaveChanges();

                    var item = new ListViewItem(new[] {newOrder.OrderID, newOrder.CreatedAt.ToString("HH:mm") })
                    {
                        Tag = newOrder,
                        ImageIndex = 0
                    };
                    listDonHienCo.Items.Add(item);
                }
                ReloadData();
                LoadOrdersToday();
                
                LoadOrderHistory(DateTime.Today);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tạo đơn hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Lỗi khi tạo đơn hàng: {ex}");
            }
        }

        private void listDonHienCo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listDonHienCo.SelectedItems.Count > 0)
                {
                    // Lấy đơn hàng được chọn
                    var selectedOrder = (Order)listDonHienCo.SelectedItems[0].Tag;

                    var orderItems = _orderBLL.GetOrderMenuItem(selectedOrder.OrderID);
                    if (orderItems == null || !orderItems.Any())
                    {
                        MessageBox.Show("Đơn hàng này không có món nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _listDataTable.Clear(); // Xóa dữ liệu hiện tại trong dgvChiTietDon
                        txtThanhTien.Text = "0";
                        txtGiamGia.Text = "0";
                        txtSoBan.Text = "0";
                        return;
                    }

                    // Xóa dữ liệu cũ trong _listDataTable
                    _listDataTable.Clear();

                    // Thêm các món vào _listDataTable để hiển thị trên dgvChiTietDon
                    foreach (var item in orderItems)
                    {                      
                        _listDataTable.Add(new OrderDisplayDTO
                        {
                            Name = item.MenuItem.Name,
                            Quantity = item.Quantity,
                            CostPrice = item.Price,
                            TotalPrice = item.Subtotal
                        });
                    }

                    // Lấy thông tin giảm giá từ cơ sở dữ liệu
                    int discountPercentage = 0;
                    if (!string.IsNullOrEmpty(selectedOrder.DiscountID))
                    {
                        using (var context = new CoffeeDbContext())
                        {
                            var discount = context.Discounts.Find(selectedOrder.DiscountID);
                            if (discount != null)
                            {
                                discountPercentage = (int)discount.Percentage;
                            }
                        }
                    }

                    // Cập nhật giao diện
                    txtThanhTien.Text = selectedOrder.FinalAmount.ToString("N0");
                    txtGiamGia.Text = discountPercentage.ToString();
                    txtSoBan.Text = selectedOrder.CardNumber.ToString();
                }
                else
                {
                    // Nếu không có đơn hàng nào được chọn, xóa dữ liệu trong dgvChiTietDon
                    _listDataTable.Clear();
                    txtThanhTien.Text = "0";
                    txtGiamGia.Text = "0";
                    txtSoBan.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi hiển thị chi tiết đơn hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Lỗi khi hiển thị chi tiết đơn hàng: {ex}");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void listDaHoanThanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listDaHoanThanh.SelectedItems.Count > 0)
                {
                    // Lấy đơn hàng đã hoàn thành được chọn
                    var selectedOrder = (Order)listDaHoanThanh.SelectedItems[0].Tag;
                    if (selectedOrder == null)
                    {
                        MessageBox.Show("Đơn hàng không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Lấy danh sách món trong đơn hàng
                    var orderItems = _orderBLL.GetOrderMenuItem(selectedOrder.OrderID);
                    if (orderItems == null || !orderItems.Any())
                    {
                        MessageBox.Show("Đơn hàng này không có món nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _listDataTable.Clear(); // Xóa dữ liệu hiện tại trong dgvChiTietDon
                        txtThanhTien.Text = "0";
                        txtGiamGia.Text = "0";
                        txtSoBan.Text = "0";
                        return;
                    }

                    // Xóa dữ liệu cũ trong _listDataTable
                    _listDataTable.Clear();

                    // Thêm các món vào _listDataTable để hiển thị trên dgvChiTietDon
                    foreach (var item in orderItems)
                    {
                        if (item.MenuItem == null)
                        {
                            Console.WriteLine($"Món có MenuItemID {item.MenuItemID} không tồn tại trong cơ sở dữ liệu.");
                            continue;
                        }

                        _listDataTable.Add(new OrderDisplayDTO
                        {
                            Name = item.MenuItem.Name,
                            Quantity = item.Quantity,
                            CostPrice = item.Price,
                            TotalPrice = item.Subtotal
                        });
                    }

                    // Lấy thông tin giảm giá từ cơ sở dữ liệu
                    int discountPercentage = 0;
                    if (!string.IsNullOrEmpty(selectedOrder.DiscountID))
                    {
                        using (var context = new CoffeeDbContext())
                        {
                            var discount = context.Discounts.Find(selectedOrder.DiscountID);
                            if (discount != null)
                            {
                                discountPercentage = (int)discount.Percentage;
                            }
                        }
                    }

                    // Cập nhật giao diện
                    txtThanhTien.Text = selectedOrder.FinalAmount.ToString("N0");
                    txtGiamGia.Text = discountPercentage.ToString();
                    txtSoBan.Text = selectedOrder.CardNumber.ToString();
                }
                else
                {
                    // Nếu không có đơn hàng nào được chọn, xóa dữ liệu trong dgvChiTietDon
                    _listDataTable.Clear();
                    txtThanhTien.Text = "0";
                    txtGiamGia.Text = "0";
                    txtSoBan.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi hiển thị chi tiết đơn hàng đã hoàn thành: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Lỗi khi hiển thị chi tiết đơn hàng đã hoàn thành: {ex}");
            }
        }
    }

}
