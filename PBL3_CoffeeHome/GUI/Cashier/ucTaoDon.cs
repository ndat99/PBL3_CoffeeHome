using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using PBL3_CoffeeHome.BLL;
using PBL3_CoffeeHome.DTO;
using PBL3_CoffeeHome.DTO.ViewModel;

namespace PBL3_CoffeeHome.GUI
{
    public partial class ucTaoDon : UserControl
    {

        private MenuItemBLL _menuItemBLL = new MenuItemBLL();
        private MenuItemIngredientBLL _menuItemIngredientBLL = new MenuItemIngredientBLL();
        private InventoryBLL _inventoryBLL = new InventoryBLL();
        private OrderBLL _orderBLL = new OrderBLL();

        private List<MenuItems> _allMenuItems;
        private List<OrderItem> _currentOrderItems = new List<OrderItem>();
        private BindingList<OrderDisplayDTO> _listChiTietDon;
        private User cashier;

        public ucTaoDon(User user)
        {
            InitializeComponent();
            _listChiTietDon = new BindingList<OrderDisplayDTO>();
            dgvChiTietDon.DataSource = _listChiTietDon;
            _allMenuItems = _menuItemBLL.GetAllMenuItems();
            cashier = user;
            LoadComboBoxData();
            LoadOrdersToday();
            LoadOrderHistory(DateTime.Today);
            timerRefresh.Start();

            dgvChiTietDon.Columns["Name"].HeaderText = "Tên món";
            dgvChiTietDon.Columns["Quantity"].HeaderText = "Số lượng";
            dgvChiTietDon.Columns["CostPrice"].HeaderText = "Đơn giá";
            dgvChiTietDon.Columns["TotalPrice"].HeaderText = "Thành tiền";
            dgvChiTietDon.Columns["CostPrice"].DefaultCellStyle.Format = "N0";
            dgvChiTietDon.Columns["TotalPrice"].DefaultCellStyle.Format = "N0";

            listDonHienCo.View = View.Details;
            listDonHienCo.Columns.Clear();
            listDonHienCo.Columns.Add("clTrangThai", "Trạng thái", 100);
            listDonHienCo.Columns.Add("clMaDon", "Mã đơn", 160);
            listDonHienCo.Columns.Add("clGioTao", "Giờ tạo", 80);
        }

        private List<string> GenerateOrderItemIDs(int count)
        {
            List<string> ids = new List<string>();
            int maxIdNumber = 0;
            using (var context = new CoffeeDbContext())
            {
                var lastOrderItem = context.OrderItems
                    .OrderByDescending(oi => oi.OrderItemID)
                    .FirstOrDefault();
                if (lastOrderItem != null && lastOrderItem.OrderItemID.StartsWith("OI"))
                {
                    string lastId = lastOrderItem.OrderItemID.Substring(2);
                    int.TryParse(lastId, out maxIdNumber);
                }
            }
            for (int i = 1; i <= count; i++)
            {
                ids.Add("OI" + (maxIdNumber + i).ToString("D3"));
            }
            return ids;
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
            var categories = _allMenuItems.Select(i => i.Category).Distinct().ToList();
            cBDanhMuc.Items.Clear();
            cBDanhMuc.Items.AddRange(categories.ToArray());

            if (categories.Count > 0)
            {
                cBDanhMuc.SelectedIndex = 0;
                UpdateMonComboBox(categories[0]);
            }
        }
        // làm mới 
        private void ReloadData()
        {
            _listChiTietDon.Clear();
            _currentOrderItems.Clear();
            txtThanhTien.Text = "0";
            txtGiamGia.Text = "0";
            txtSoBan.Text = "0";
            numSoLuong.Value = 1;
            _allMenuItems = _menuItemBLL.GetAllMenuItems();

            LoadComboBoxData();
            LoadOrdersToday();
            LoadOrderHistory(DateTime.Today);
        }

        // Load danh sách đơn hàng hôm nay
        private void LoadOrdersToday()
        {
            listDonHienCo.Items.Clear();
            var orders = _orderBLL.GetOrdersAssignedToday("Incompleted").OrderByDescending(o => o.CreatedAt);

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
                var completedAt = completedQueue?.CompletedAt.HasValue == true
                ? completedQueue.CompletedAt.Value.ToString("HH:mm") : "N/A";
                var item = new ListViewItem(new string[]
                {
                    "",
                    order.OrderID,
                    completedAt
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

                    var existingDisplay = _listChiTietDon.FirstOrDefault(x => x.Name == selectedItem.Name);
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

                    _listChiTietDon.Add(new OrderDisplayDTO
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
            decimal tong = _listChiTietDon.Sum(x => x.TotalPrice);
            int giamGia = 0;
            int.TryParse(txtGiamGia.Text, out giamGia);
            tong = tong * (100 - giamGia) / 100;
            return tong;
        }
        private void btnLichSuDon_Click(object sender, EventArgs e)
        {
            new fLichSuDonHang().Show();
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            LoadOrdersToday();
            LoadOrderHistory(DateTime.Today);
        }

        private void cBDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = cBDanhMuc.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedCategory))
            {
                UpdateMonComboBox(selectedCategory);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvChiTietDon.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn món để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var itemsToRemove = new List<OrderDisplayDTO>();
                var orderItemsToRemove = new List<OrderItem>();

                foreach (DataGridViewRow row in dgvChiTietDon.SelectedRows)
                {
                    string tenMon = row.Cells["Name"].Value?.ToString()?.Trim();
                    if (string.IsNullOrEmpty(tenMon))
                    {
                        Console.WriteLine($"Tên món rỗng hoặc null tại hàng {row.Index}");
                        continue;
                    }
                    var displayItem = _listChiTietDon.FirstOrDefault(x => x.Name?.Trim() == tenMon);
                    if (displayItem != null)
                    {
                        itemsToRemove.Add(displayItem);
                        Console.WriteLine($"Tìm thấy món trong _listChiTietDon: {tenMon}");
                    }
                    else
                    {
                        Console.WriteLine($"Không tìm thấy món trong _listChiTietDon: {tenMon}");
                    }

                    var orderItem = _currentOrderItems.FirstOrDefault(x =>
                        _allMenuItems.FirstOrDefault(m => m.MenuItemID == x.MenuItemID)?.Name?.Trim() == tenMon);
                    if (orderItem != null)
                    {
                        orderItemsToRemove.Add(orderItem);
                        Console.WriteLine($"Tìm thấy món trong _currentOrderItems: {tenMon}");
                    }
                    else
                    {
                        Console.WriteLine($"Không tìm thấy món trong _currentOrderItems: {tenMon}");
                    }
                }

                foreach (var item in itemsToRemove)
                {
                    _listChiTietDon.Remove(item);
                }

                foreach (var orderItem in orderItemsToRemove)
                {
                    _currentOrderItems.Remove(orderItem);
                }

                txtThanhTien.Text = TinhTongTien().ToString("N0");

                dgvChiTietDon.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra khi xóa món: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Lỗi khi xóa món: {ex}");
            }
        }

        private void btnThanhToan_Click_1(object sender, EventArgs e)
        {
            if (_listChiTietDon.Count == 0)
            {
                MessageBox.Show("Chưa có món nào trong đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int cardNumber = 0;
            string soBanInput = txtSoBan.Text?.Trim();
            if (string.IsNullOrEmpty(soBanInput))
            {
                MessageBox.Show("Vui lòng nhập số bàn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(soBanInput, out cardNumber) || cardNumber <= 0)
            {
                MessageBox.Show("Số bàn phải là một số nguyên dương hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string userId = cashier.UserID;
                string orderID = GenerateOrderID(DateTime.Now);

                var orderItems = _currentOrderItems.Select(i => (i.MenuItemID, i.Quantity)).ToList();

                using (var context = new CoffeeDbContext())
                {
                    decimal total = 0;
                    List<OrderItem> orderItemList = new List<OrderItem>();
                    var orderItemIDs = GenerateOrderItemIDs(orderItems.Count);
                    int idx = 0;
                    foreach (var (menuItemId, quantity) in orderItems)
                    {
                        // ...
                        orderItemList.Add(new OrderItem
                        {
                            OrderItemID = orderItemIDs[idx++],
                            OrderID = orderID,
                            MenuItemID = menuItemId,
                            Quantity = quantity,
                            Price = _menuItemBLL.GetMenuItemByID(menuItemId).Price,
                            Subtotal = _menuItemBLL.GetMenuItemByID(menuItemId).Price * quantity
                        });
                    }

                    decimal discountAmount = 0;
                    string discountId = null;
                    if (!string.IsNullOrEmpty(discountId))
                    {
                        var discount = context.Discounts.Find(discountId);
                        if (discount != null && total >= discount.MinOrderAmount)
                            discountAmount = total * discount.Percentage;
                    }

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

                    var item = new ListViewItem(new[] { newOrder.OrderID, newOrder.CreatedAt.ToString("HH:mm") })
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
                        _listChiTietDon.Clear(); // Xóa dữ liệu hiện tại trong dgvChiTietDon
                        txtThanhTien.Text = "0";
                        txtGiamGia.Text = "0";
                        txtSoBan.Text = "0";
                        return;
                    }

                    // Xóa dữ liệu cũ trong _listChiTietDon
                    _listChiTietDon.Clear();

                    // Thêm các món vào _listChiTietDon để hiển thị trên dgvChiTietDon
                    foreach (var item in orderItems)
                    {
                        _listChiTietDon.Add(new OrderDisplayDTO
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
                    _listChiTietDon.Clear();
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
                        _listChiTietDon.Clear(); // Xóa dữ liệu hiện tại trong dgvChiTietDon
                        txtThanhTien.Text = "0";
                        txtGiamGia.Text = "0";
                        txtSoBan.Text = "0";
                        return;
                    }

                    // Xóa dữ liệu cũ trong _listChiTietDon
                    _listChiTietDon.Clear();

                    // Thêm các món vào _listChiTietDon để hiển thị trên dgvChiTietDon
                    foreach (var item in orderItems)
                    {
                        if (item.MenuItem == null)
                        {
                            Console.WriteLine($"Món có MenuItemID {item.MenuItemID} không tồn tại trong cơ sở dữ liệu.");
                            continue;
                        }

                        _listChiTietDon.Add(new OrderDisplayDTO
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
                    _listChiTietDon.Clear();
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
        // xóa giao diện
        //private void btnHuyDon_Click(object sender, EventArgs e)
        //{
        //    if (listDonHienCo.SelectedItems.Count == 0)
        //    {
        //        MessageBox.Show("Vui lòng chọn đơn hàng để hủy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    try
        //    {
        //        var itemsToRemove = new List<ListViewItem>();
        //        foreach (ListViewItem item in listDonHienCo.SelectedItems)
        //        {
        //            if (item.Tag is Order order && order.Status == "Incompleted")
        //            {
        //                itemsToRemove.Add(item);
        //                Console.WriteLine($"Đã thêm đơn {order.OrderID} vào danh sách xóa.");
        //            }
        //            else
        //            {
        //                Console.WriteLine($"Không thể hủy đơn {item.SubItems[1].Text} vì trạng thái không phải 'Incompleted'.");
        //            }
        //        }

        //        foreach (var item in itemsToRemove)
        //        {
        //            listDonHienCo.Items.Remove(item);
        //            Console.WriteLine($"Đã xóa đơn {item.SubItems[1].Text} khỏi listDonHienCo.");
        //        }

        //        if (itemsToRemove.Count == 0)
        //        {
        //            MessageBox.Show("Không có đơn nào được hủy vì không phải trạng thái 'Incompleted'.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //        else
        //        {
        //            MessageBox.Show($"Đã hủy thành công {itemsToRemove.Count} đơn hàng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Có lỗi xảy ra khi hủy đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Console.WriteLine($"Lỗi khi hủy đơn: {ex}");
        //    }
        //}
        //private void btnHuyDon_Click(object sender, EventArgs e)
        //{
        //    if (listDonHienCo.SelectedItems.Count == 0)
        //    {
        //        MessageBox.Show("Vui lòng chọn đơn hàng để hủy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    try
        //    {
        //        var itemsToRemove = new List<ListViewItem>();
        //        using (var context = new CoffeeDbContext())
        //        {
        //            foreach (ListViewItem item in listDonHienCo.SelectedItems)
        //            {
        //                if (item.Tag is Order order )
        //                {
        //                    // Lấy OrderID của đơn hàng
        //                    string orderId = order.OrderID;

        //                    // Xóa các bản ghi liên quan trong bảng OrderItems
        //                    var orderItems = context.OrderItems.Where(oi => oi.OrderID == orderId).ToList();
        //                    context.OrderItems.RemoveRange(orderItems);

        //                    // Xóa các bản ghi liên quan trong bảng BaristaQueues (nếu có)
        //                    var baristaQueues = context.BaristaQueues.Where(bq => bq.OrderID == orderId).ToList();
        //                    context.BaristaQueues.RemoveRange(baristaQueues);

        //                    // Xóa đơn hàng trong bảng Orders
        //                    var orderToRemove = context.Orders.Find(orderId);
        //                    if (orderToRemove != null)
        //                    {
        //                        context.Orders.Remove(orderToRemove);
        //                    }

        //                    itemsToRemove.Add(item);
        //                }
        //                else
        //                {
        //                    Console.WriteLine($"Không thể hủy đơn {item.SubItems[1].Text} vì trạng thái không phải 'Incompleted'.");
        //                }
        //            }

        //            // Lưu thay đổi vào cơ sở dữ liệu
        //            context.SaveChanges();
        //        }

        //        // Xóa các mục khỏi listDonHienCo
        //        foreach (var item in itemsToRemove)
        //        {
        //            listDonHienCo.Items.Remove(item);
        //            Console.WriteLine($"Đã xóa đơn {item.SubItems[1].Text} khỏi listDonHienCo.");
        //        }

        //        if (itemsToRemove.Count == 0)
        //        {
        //            MessageBox.Show("Không có đơn nào được hủy vì không phải trạng thái 'Incompleted'.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //        else
        //        {
        //            MessageBox.Show($"Đã hủy thành công {itemsToRemove.Count} đơn hàng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Có lỗi xảy ra khi hủy đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Console.WriteLine($"Lỗi khi hủy đơn: {ex}");
        //    }
        //}
    }

}