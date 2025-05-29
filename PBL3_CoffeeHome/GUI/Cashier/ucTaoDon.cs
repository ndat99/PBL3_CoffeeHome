using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
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
        private DiscountBLL _discountBLL = new DiscountBLL();
        private readonly OrderBLL _orderBLL;
        private readonly OrderItemsBLL _orderItemsBLL;
        private readonly MenuItemBLL _menuItemBLL;
        
        private  List<MenuItems> _allMenuItems; 
        private readonly BaristaQueueBLL _baristaQueueBLL;
        private readonly MenuItemIngredientBLL _menuItemIngredientBLL;
        private readonly InventoryBLL _inventoryBLL;
        private BindingList<OrderDetailDTO> _listChiTietDon;
        private User _cashier;

        public ucTaoDon(User user)
        {
            InitializeComponent();
            _orderBLL = new OrderBLL();
            _orderItemsBLL = new OrderItemsBLL();
            _menuItemBLL = new MenuItemBLL();
            _baristaQueueBLL = new BaristaQueueBLL();
            _menuItemIngredientBLL = new MenuItemIngredientBLL();
            _inventoryBLL = new InventoryBLL();

            _allMenuItems = _menuItemBLL.GetAllMenuItems(); 
            _cashier = user;

            LoadOrdersToday();
            LoadOrderHistory(DateTime.Today);
            timerRefresh.Start();
            LoadCBBName();
        }
        private void ucTaoDon_Load(object sender, EventArgs e)
        {
            _listChiTietDon = new BindingList<OrderDetailDTO>();
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
       
        private void ReloadData()
        {
            _listChiTietDon.Clear();
            dgvChiTietDon.Rows.Clear();
            txtThanhTien.Text = "0";
            txtSoBan.Text = "0";
            numSoLuong.Value = 1;
            _allMenuItems = _menuItemBLL.GetAllMenuItems();

            LoadCBBName();
            LoadOrdersToday();
            LoadOrderHistory(DateTime.Today);

        }

        // Load danh sách đơn hàng hôm nay
        private void LoadOrdersToday()
        {
            listDonHienCo.Items.Clear();
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

                listDonHienCo.Items.Add(item);
            }
        }
        // Load lịch sử đơn hàng theo ngày
        private void LoadOrderHistory(DateTime selectedDate)
        {
            listDaHoanThanh.Items.Clear();
            var queues = _baristaQueueBLL.GetQueueCompletedOnDate("Complete", selectedDate)
                        .OrderBy(bq => bq.CompletedAt);

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
            int soLuong = (int)numSoLuong.Value;
            string tenMon = cBMon.SelectedItem.ToString().Trim();
            if (string.IsNullOrEmpty(tenMon))
            {
                MessageBox.Show("Vui lòng chọn món ăn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var selectedItem = _menuItemBLL.GetMenuItemByName(tenMon);
            bool khoDu = CheckKhoDu(selectedItem.MenuItemID, soLuong);
            if (!khoDu)
            {
                MessageBox.Show($"Không đủ nguyên liệu để thêm món {tenMon}!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var monDaCo = _listChiTietDon.FirstOrDefault(x => x.Name.Trim() == tenMon);
            if (monDaCo != null)
            {
                monDaCo.Quantity += soLuong;
            }
            else
            {
                var item = new OrderDetailDTO
                {
                    Name = tenMon,
                    Quantity = soLuong,
                    CostPrice = _menuItemBLL.GetMenuItemByName(tenMon).Price,
                };
                _listChiTietDon.Add(item);
            }

            UpdateChiTietDon();
            txtThanhTien.Text = _listChiTietDon.Sum(x => x.CostPrice * x.Quantity).ToString("N0");
        }
        private void UpdateChiTietDon()
        {
            dgvChiTietDon.Rows.Clear();
            foreach (var item in _listChiTietDon)
            {
                dgvChiTietDon.Rows.Add(
                    item.Name,
                    item.Quantity,
                    item.CostPrice.ToString("N0"),
                    (item.CostPrice * item.Quantity).ToString("N0")
                );
            }
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string tenMon = dgvChiTietDon.SelectedRows[0].Cells[0].Value?.ToString();// nếu null trả về null chứ không lỗi
            var monDaCo = _listChiTietDon.FirstOrDefault(x => x.Name == tenMon);

            if (monDaCo.Quantity > 1)
            {
                monDaCo.Quantity--;
            }
            else
            {
                _listChiTietDon.Remove(monDaCo);
            }
            UpdateChiTietDon();
            txtThanhTien.Text = _listChiTietDon.Sum(x => x.CostPrice * x.Quantity).ToString("N0");
           
        }

        private void btnThanhToan_Click_1(object sender, EventArgs e)
        {
            // Kiểm tra số bàn  
            if (string.IsNullOrWhiteSpace(txtSoBan.Text) || !int.TryParse(txtSoBan.Text, out int parsedCardNumber) || parsedCardNumber <= 0)
            {
                MessageBox.Show("Vui lòng nhập số bàn hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra danh sách món  
            if (_listChiTietDon.Count == 0)
            {
                MessageBox.Show("Vui lòng thêm ít nhất một món để thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string orderId = _orderBLL.GenerateOrderID();
            DateTime createdAt = DateTime.Now;
            int cardNumber = parsedCardNumber;

            decimal totalAmount = _listChiTietDon.Sum(x => x.CostPrice * x.Quantity);

            var discount = _discountBLL.GetDiscountByEffectiveDate(createdAt);
            string discountId = discount != null ? discount.DiscountID : null;
            decimal discountPercentage = discount != null ? discount.Percentage : 0;
            decimal discountAmount = 0;
            if (discount != null)
            {
                discountAmount = totalAmount * discountPercentage;
            }
            decimal finalAmount = totalAmount - discountAmount;

            string userId = _cashier.UserID;

            _orderBLL.AddOrder(orderId, createdAt, cardNumber, totalAmount, discountAmount, finalAmount, userId,discountId);

            foreach (var item in _listChiTietDon)
            {
                _orderItemsBLL.AddOrderItems(orderId, item.Name, item.Quantity, item.CostPrice);
            }

            InBill(orderId);
            MessageBox.Show("Tạo đơn thành công", "Hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ReloadData();
            LoadOrdersToday();
            LoadOrderHistory(DateTime.Today);

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
                    writer.WriteLine($"Nhân viên: {_cashier.FullName}");
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

        private void listDonHienCo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra nếu không có mục nào được chọn
            if (listDonHienCo.SelectedItems == null || listDonHienCo.SelectedItems.Count == 0) return;

            // Lấy ID đơn hàng 
            string selectedOrderID = listDonHienCo.SelectedItems[0].SubItems[1].Text;

            // Lấy thông tin chi tiết đơn hàng
            var order = _orderBLL.GetOrderDetails(selectedOrderID);
            if (order == null)
            {
                MessageBox.Show("Không tìm thấy đơn hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dgvChiTietDon.Rows.Clear();

            decimal tongTien = 0;

            foreach (var item in order.OrderItems)
            {
                dgvChiTietDon.Rows.Add(
                    item.MenuItem.Name,
                    item.Quantity,
                    item.Price.ToString("N0"),
                    item.Subtotal.ToString("N0")
                );

                tongTien += item.Subtotal;
            }


            txtThanhTien.Text = tongTien.ToString("N0");

            // Xóa dữ liệu trong _listChiTietDon để tránh xung đột
            _listChiTietDon.Clear();
        }

        private void listDaHoanThanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listDaHoanThanh.SelectedItems == null || listDaHoanThanh.SelectedItems.Count == 0) return;
            //lấy ID đơn hàng
            string selectedOrderID = listDaHoanThanh.SelectedItems[0].SubItems[1].Text;

            // Lấy thông tin chi tiết đơn hàng
            var order = _orderBLL.GetOrderDetails(selectedOrderID);
            if (order == null)
            {
                MessageBox.Show("Không tìm thấy đơn hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dgvChiTietDon.Rows.Clear();
            decimal tongTien = 0;

            foreach (var item in order.OrderItems)
            {
                dgvChiTietDon.Rows.Add(
                    item.MenuItem.Name,
                    item.Quantity,
                    item.Price.ToString("N0"),
                    item.Subtotal.ToString("N0")
                );

                tongTien += item.Subtotal;
            }

            // Cập nhật tổng tiền
            txtThanhTien.Text = tongTien.ToString("N0");

            // Xóa dữ liệu trong _listChiTietDon để tránh xung đột
            _listChiTietDon.Clear();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ReloadData();
        }
    }

}