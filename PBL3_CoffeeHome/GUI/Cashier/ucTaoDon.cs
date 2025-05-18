using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using PBL3_CoffeeHome.BLL;
using PBL3_CoffeeHome.DAL.Repository;
using PBL3_CoffeeHome.DTO;
using PBL3_CoffeeHome.DTO.ViewModel;

namespace PBL3_CoffeeHome.GUI
{
    public partial class ucTaoDon : UserControl
    {

        private readonly OrderBLL _orderBLL;
        private readonly OrderItemsBLL _orderItemsBLL;
        private readonly MenuItemBLL _menuItemBLL;
        private readonly BaristaQueueBLL _baristaQueueBLL;
        private BindingList<OrderDetailDTO> _listChiTietDon;
        private User _cashier;

        public ucTaoDon(User user)
        {
            InitializeComponent();
            _orderBLL = new OrderBLL();
            _orderItemsBLL = new OrderItemsBLL();
            _menuItemBLL = new MenuItemBLL();
            _baristaQueueBLL = new BaristaQueueBLL();
            _cashier = user;
            //LoadComboBoxData();
            LoadOrdersToday();
            LoadOrderHistory(DateTime.Today);
            timerRefresh.Start();
            LoadData();
        }
        private void ucTaoDon_Load(object sender, EventArgs e)
        {
            _listChiTietDon = new BindingList<OrderDetailDTO>();
        }
        public void LoadData()
        {
            //LoadMenuItems();
            //LoadOrderItems();
            LoadCBBName();
        }
        public void LoadCBBName()
        {
            cBDanhMuc.Items.Clear();
            cBDanhMuc.Items.AddRange(_menuItemBLL.GetAllMenuCategory().ToArray());
            cBDanhMuc.SelectedIndex = 0;
        }
        private void cBDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            cBMon.Items.Clear();
            cBMon.Items.AddRange(_menuItemBLL.GetAllMenuItems()
                                             .Where(m => m.Category == cBDanhMuc.SelectedItem.ToString())
                                             .Select(m => m.Name)
                                             .ToArray());
            cBMon.SelectedIndex = 0;
        }
        // cập nhật danh sách món ăn theo danh mục
        //private void UpdateMonComboBox(string selectedCategory)
        //{
        //    var filteredItems = _allMenuItems
        //        .Where(item => item.Category == selectedCategory)
        //        .Select(item => item.Name)
        //        .ToArray();

        //    cBMon.Items.Clear();
        //    cBMon.Items.AddRange(filteredItems);
        //}

        //private void LoadComboBoxData()
        //{
        //    var categories = _allMenuItems.Select(i => i.Category).Distinct().ToList();
        //    cBDanhMuc.Items.Clear();
        //    cBDanhMuc.Items.AddRange(categories.ToArray());

        //    if (categories.Count > 0)
        //    {
        //        cBDanhMuc.SelectedIndex = 0;
        //        UpdateMonComboBox(categories[0]);
        //    }
        //}
        // làm mới 
        //private void ReloadData()
        //{
        //    _listChiTietDon.Clear();
        //    _currentOrderItems.Clear();
        //    txtThanhTien.Text = "0";
        //    txtGiamGia.Text = "0";
        //    txtSoBan.Text = "0";
        //    numSoLuong.Value = 1;
        //    _allMenuItems = _menuItemBLL.GetAllMenuItems();

        //    LoadComboBoxData();
        //    LoadOrdersToday();
        //    LoadOrderHistory(DateTime.Today);
        //}

        // Load danh sách đơn hàng hôm nay
        private void LoadOrdersToday()
        {
            listDonHienCo.Items.Clear();
            var queues = _baristaQueueBLL.GetQueueAssignedToday("Incompleted").OrderByDescending(bq => bq.AssignedAt);

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

                listDonHienCo.Items.Add(item);
            }
        }
        // Load lịch sử đơn hàng theo ngày
        private void LoadOrderHistory(DateTime selectedDate)
        {
            listDaHoanThanh.Items.Clear();
            var queues = _baristaQueueBLL.GetQueueCompletedOnDate("Completed", selectedDate)
                        .OrderByDescending(bq => bq.CompletedAt);

            foreach (var queue in queues)
            {
                var item = new ListViewItem(new string[]
                {
                    "",
                    queue.OrderID,
                    queue.CompletedAt.Value.ToString("HH:mm")
                });
                item.Tag = queue;
                item.ImageIndex = 1;

                listDaHoanThanh.Items.Add(item);
            }
        }

        //private bool CheckKhoDu(string menuItemId, int soLuong)
        //{
        //    var ingredients = _menuItemIngredientBLL.GetMenuItemIngredient(menuItemId);
        //    if (ingredients == null) return false;

        //    foreach (var ingredient in ingredients)
        //    {
        //        var inventory = _inventoryBLL.GetInventoryByID(ingredient.ItemID);
        //        if (inventory == null || inventory.Quantity < (ingredient.QuantityRequired * soLuong))
        //            return false;
        //    }
        //    return true;
        //}

        //private void SetUpChiTietDon(OrderDetailDTO item)
        //{
        //    if ()
        //    dgvChiTietDon.Rows.Add(
        //        item.Name,
        //        item.Quantity,
        //        item.CostPrice.ToString("N0"),
        //        (item.CostPrice * item.Quantity).ToString("N0")
        //    );
        //}
        private void btnThem_Click(object sender, EventArgs e)
        {
            var item = new OrderDetailDTO
            {
                Name = cBMon.SelectedItem.ToString(),
                Quantity = (int)numSoLuong.Value,
                CostPrice = _menuItemBLL.GetMenuItemByName(cBMon.SelectedItem.ToString()).Price,
            };

            _listChiTietDon.Add(item);

            dgvChiTietDon.Rows.Add(
                item.Name,
                item.Quantity,
                item.CostPrice.ToString("N0"),
                (item.CostPrice * item.Quantity).ToString("N0")
            );
        }

        //private decimal TinhTongTien()
        //{
        //    decimal tong = _listChiTietDon.Sum(x => x.TotalPrice);
        //    int giamGia = 0;
        //    int.TryParse(txtGiamGia.Text, out giamGia);
        //    tong = tong * (100 - giamGia) / 100;
        //    return tong;
        //}
        private void btnLichSuDon_Click(object sender, EventArgs e)
        {
            new fLichSuDonHang().Show();
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            LoadOrdersToday();
            LoadOrderHistory(DateTime.Today);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //if (dgvChiTietDon.SelectedRows.Count == 0)
            //{
            //    MessageBox.Show("Vui lòng chọn món để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //try
            //{
            //    var itemsToRemove = new List<OrderDisplayDTO>();
            //    var orderItemsToRemove = new List<OrderItem>();

            //    foreach (DataGridViewRow row in dgvChiTietDon.SelectedRows)
            //    {
            //        string tenMon = row.Cells["Name"].Value?.ToString()?.Trim();
            //        if (string.IsNullOrEmpty(tenMon))
            //        {
            //            Console.WriteLine($"Tên món rỗng hoặc null tại hàng {row.Index}");
            //            continue;
            //        }
            //        var displayItem = _listChiTietDon.FirstOrDefault(x => x.Name?.Trim() == tenMon);
            //        if (displayItem != null)
            //        {
            //            itemsToRemove.Add(displayItem);
            //            Console.WriteLine($"Tìm thấy món trong _listChiTietDon: {tenMon}");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"Không tìm thấy món trong _listChiTietDon: {tenMon}");
            //        }

            //        var orderItem = _currentOrderItems.FirstOrDefault(x =>
            //            _allMenuItems.FirstOrDefault(m => m.MenuItemID == x.MenuItemID)?.Name?.Trim() == tenMon);
            //        if (orderItem != null)
            //        {
            //            orderItemsToRemove.Add(orderItem);
            //            Console.WriteLine($"Tìm thấy món trong _currentOrderItems: {tenMon}");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"Không tìm thấy món trong _currentOrderItems: {tenMon}");
            //        }
            //    }

            //    foreach (var item in itemsToRemove)
            //    {
            //        _listChiTietDon.Remove(item);
            //    }

            //    foreach (var orderItem in orderItemsToRemove)
            //    {
            //        _currentOrderItems.Remove(orderItem);
            //    }

            //    txtThanhTien.Text = TinhTongTien().ToString("N0");

            //    dgvChiTietDon.Refresh();

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Có lỗi xảy ra khi xóa món: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    Console.WriteLine($"Lỗi khi xóa món: {ex}");
            //}
        }

        private void btnThanhToan_Click_1(object sender, EventArgs e)
        {
            string orderId = _orderBLL.GenerateOrderID();
            DateTime createdAt = DateTime.Now;
            int cardNumber = 1; // hoặc lấy từ giao diện
            decimal totalAmount = _listChiTietDon.Sum(x => x.CostPrice * x.Quantity);
            decimal discountAmount = 0; // hoặc tính theo logic của bạn
            decimal finalAmount = totalAmount - discountAmount;
            string userId = "USR002"; // hoặc lấy từ user đăng nhập

            _orderBLL.AddOrder(orderId, createdAt, cardNumber, totalAmount, discountAmount, finalAmount, userId);

            foreach (var item in _listChiTietDon)
            {
                _orderItemsBLL.AddOrderItems(orderId, item.Name, item.Quantity, item.CostPrice);
            }

            _listChiTietDon.Clear();
            LoadOrdersToday();
            LoadOrderHistory(DateTime.Today);

            MessageBox.Show("Tạo đơn hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //private void listDonHienCo_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (listDonHienCo.SelectedItems.Count > 0)
        //        {
        //            // Lấy đơn hàng được chọn
        //            var selectedOrder = (Order)listDonHienCo.SelectedItems[0].Tag;

        //            var orderItems = _orderBLL.GetOrderMenuItem(selectedOrder.OrderID);
        //            if (orderItems == null || !orderItems.Any())
        //            {
        //                MessageBox.Show("Đơn hàng này không có món nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                _listChiTietDon.Clear(); // Xóa dữ liệu hiện tại trong dgvChiTietDon
        //                txtThanhTien.Text = "0";
        //                txtGiamGia.Text = "0";
        //                txtSoBan.Text = "0";
        //                return;
        //            }

        //            // Xóa dữ liệu cũ trong _listChiTietDon
        //            _listChiTietDon.Clear();

        //            // Thêm các món vào _listChiTietDon để hiển thị trên dgvChiTietDon
        //            //foreach (var item in orderItems)
        //            //{
        //            //    _listChiTietDon.Add(new OrderDisplayDTO
        //            //    {
        //            //        Name = item.MenuItem.Name,
        //            //        Quantity = item.Quantity,
        //            //        CostPrice = item.Price,
        //            //        TotalPrice = item.Subtotal
        //            //    });
        //            //}

        //            // Lấy thông tin giảm giá từ cơ sở dữ liệu
        //            int discountPercentage = 0;
        //            if (!string.IsNullOrEmpty(selectedOrder.DiscountID))
        //            {
        //                using (var context = new CoffeeDbContext())
        //                {
        //                    var discount = context.Discounts.Find(selectedOrder.DiscountID);
        //                    if (discount != null)
        //                    {
        //                        discountPercentage = (int)discount.Percentage;
        //                    }
        //                }
        //            }

        //            // Cập nhật giao diện
        //            txtThanhTien.Text = selectedOrder.FinalAmount.ToString("N0");
        //            txtGiamGia.Text = discountPercentage.ToString();
        //            txtSoBan.Text = selectedOrder.CardNumber.ToString();
        //        }
        //        else
        //        {
        //            // Nếu không có đơn hàng nào được chọn, xóa dữ liệu trong dgvChiTietDon
        //            _listChiTietDon.Clear();
        //            txtThanhTien.Text = "0";
        //            txtGiamGia.Text = "0";
        //            txtSoBan.Text = "0";
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Lỗi khi hiển thị chi tiết đơn hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Console.WriteLine($"Lỗi khi hiển thị chi tiết đơn hàng: {ex}");
        //    }
        //}

        //private void btnClear_Click(object sender, EventArgs e)
        //{
        //    ReloadData();
        //}

        //private void listDaHoanThanh_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (listDaHoanThanh.SelectedItems.Count > 0)
        //        {
        //            // Lấy đơn hàng đã hoàn thành được chọn
        //            var selectedOrder = (Order)listDaHoanThanh.SelectedItems[0].Tag;
        //            if (selectedOrder == null)
        //            {
        //                MessageBox.Show("Đơn hàng không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                return;
        //            }

        //            // Lấy danh sách món trong đơn hàng
        //            var orderItems = _orderBLL.GetOrderMenuItem(selectedOrder.OrderID);
        //            if (orderItems == null || !orderItems.Any())
        //            {
        //                MessageBox.Show("Đơn hàng này không có món nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                _listChiTietDon.Clear(); // Xóa dữ liệu hiện tại trong dgvChiTietDon
        //                txtThanhTien.Text = "0";
        //                txtGiamGia.Text = "0";
        //                txtSoBan.Text = "0";
        //                return;
        //            }

        //            // Xóa dữ liệu cũ trong _listChiTietDon
        //            _listChiTietDon.Clear();

        //            // Thêm các món vào _listChiTietDon để hiển thị trên dgvChiTietDon
        //            foreach (var item in orderItems)
        //            {
        //                if (item.MenuItem == null)
        //                {
        //                    Console.WriteLine($"Món có MenuItemID {item.MenuItemID} không tồn tại trong cơ sở dữ liệu.");
        //                    continue;
        //                }

        //                //_listChiTietDon.Add(new OrderDisplayDTO
        //                //{
        //                //    Name = item.MenuItem.Name,
        //                //    Quantity = item.Quantity,
        //                //    CostPrice = item.Price,
        //                //    TotalPrice = item.Subtotal
        //                //});
        //            }

        //            // Lấy thông tin giảm giá từ cơ sở dữ liệu
        //            int discountPercentage = 0;
        //            if (!string.IsNullOrEmpty(selectedOrder.DiscountID))
        //            {
        //                using (var context = new CoffeeDbContext())
        //                {
        //                    var discount = context.Discounts.Find(selectedOrder.DiscountID);
        //                    if (discount != null)
        //                    {
        //                        discountPercentage = (int)discount.Percentage;
        //                    }
        //                }
        //            }

        //            // Cập nhật giao diện
        //            txtThanhTien.Text = selectedOrder.FinalAmount.ToString("N0");
        //            txtGiamGia.Text = discountPercentage.ToString();
        //            txtSoBan.Text = selectedOrder.CardNumber.ToString();
        //        }
        //        else
        //        {
        //            // Nếu không có đơn hàng nào được chọn, xóa dữ liệu trong dgvChiTietDon
        //            _listChiTietDon.Clear();
        //            txtThanhTien.Text = "0";
        //            txtGiamGia.Text = "0";
        //            txtSoBan.Text = "0";
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Lỗi khi hiển thị chi tiết đơn hàng đã hoàn thành: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Console.WriteLine($"Lỗi khi hiển thị chi tiết đơn hàng đã hoàn thành: {ex}");
        //    }
        //}


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