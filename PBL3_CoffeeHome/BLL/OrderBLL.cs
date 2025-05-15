using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3_CoffeeHome.DAL.Repository;
using PBL3_CoffeeHome.DAL;
using PBL3_CoffeeHome.DTO;

namespace PBL3_CoffeeHome.BLL
{
    public class OrderBLL
    {
        private readonly OrderDAL _orderDAL;
        private readonly RevenueDAL _revenueDAL;
        //private readonly BaristaQueueBLL _baristaQueueBLL;

        public OrderBLL()
        {
            _orderDAL = new OrderDAL();
            _revenueDAL = new RevenueDAL();
           // _baristaQueueBLL = new BaristaQueueBLL();
        }

        // ProcessOrder
        public void ProcessOrder(string userId, int cardNumber, List<(string menuItemId, int quantity)> items, string discountId = null)
        {
            using (var context = new CoffeeDbContext())
            {
                try
                {
                    decimal total = 0;
                    List<OrderItem> orderItems = new List<OrderItem>();
                    string orderId = Guid.NewGuid().ToString();

                    foreach (var (menuItemId, quantity) in items)
                    {
                        var item = context.MenuItems.Find(menuItemId);
                        if (item == null || !item.IsAvailable) continue;

                        decimal subtotal = item.Price * quantity;
                        total += subtotal;

                        orderItems.Add(new OrderItem
                        {
                            OrderItemID = Guid.NewGuid().ToString(),
                            OrderID = orderId,
                            MenuItemID = menuItemId,
                            Quantity = quantity,
                            Price = item.Price,
                            Subtotal = subtotal
                        });

                        // Trừ tồn kho theo nguyên liệu
                        var ingredients = context.MenuItemIngredients.Where(i => i.MenuItemID == menuItemId).ToList();
                        foreach (var ing in ingredients)
                        {
                            var inventoryItem = context.Inventory.Find(ing.ItemID);
                            if (inventoryItem == null) continue;

                            inventoryItem.Quantity -= ing.QuantityRequired * quantity;

                            // Kiểm tra tồn kho âm
                            if (inventoryItem.Quantity < 0)
                            {
                                throw new InvalidOperationException($"Nguyên liệu {inventoryItem.Name} không đủ tồn kho.");
                            }
                        }
                    }

                    // Tính giảm giá
                    decimal discountAmount = 0;
                    if (!string.IsNullOrEmpty(discountId))
                    {
                        var discount = context.Discounts.Find(discountId);
                        if (discount != null && total >= discount.MinOrderAmount)
                            discountAmount = total * discount.Percentage;
                    }

                    decimal finalAmount = total - discountAmount;

                    // Tạo order
                    Order order = new Order
                    {
                        OrderID = orderId,
                        CreatedAt = DateTime.Now,
                        CardNumber = cardNumber,
                        TotalAmount = total,
                        DiscountAmount = discountAmount,
                        FinalAmount = finalAmount,
                        UserID = userId,
                        DiscountID = discountId
                    };

                    _orderDAL.AddOrder(order);
                    _orderDAL.AddOrderItems(orderItems);

                    // Ghi doanh thu chi tiết
                    Revenue revenue = _revenueDAL.GetCurrentRevenuePeriod();
                    if (revenue != null)
                    {
                        foreach (var oi in orderItems)
                        {
                            _revenueDAL.AddRevenueDetail(new RevenueDetail
                            {
                                DetailID = Guid.NewGuid().ToString(),
                                RevenueID = revenue.RevenueID,
                                OrderID = order.OrderID,
                                ItemName = context.MenuItems.Find(oi.MenuItemID)?.Name,
                                Quantity = oi.Quantity,
                                RevenueAmount = oi.Subtotal
                            });
                        }

                        _revenueDAL.UpdateTotalRevenue(revenue.RevenueID, finalAmount);
                    }
                }
                catch (Exception ex)
                {
                    // Log lỗi hoặc xử lý ngoại lệ
                    throw new Exception("Đã xảy ra lỗi khi xử lý đơn hàng.", ex);
                }
            }
        }

        // Lấy lịch sử đơn hàng để hiển thị
        public List<OrderHistory> GetOrderHistory()
        {
            try
            {
                var orders = _orderDAL.GetAllOrders();
                return orders.Select(o => new OrderHistory
                {
                    OrderId = o.OrderID,
                    OrderDate = o.CreatedAt,
                    TotalAmount = o.FinalAmount
                }).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy lịch sử đơn hàng: " + ex.Message, ex);
            }
        }
        // Lấy danh sách đơn hàng của ngày hôm nay
        public List<Order> GetOrdersAssignedToday(string status)
        {
            return _orderDAL.GetOrdersAssignedToday(status);
        }

        // Lấy danh sách đơn hàng đã hoàn thành trong ngày được chọn
        public List<Order> GetOrdersCompletedOnDate(string status, DateTime selectedDate)
        {
            return _orderDAL.GetOrdersCompletedOnDate(status, selectedDate);
        }

        // Lấy chi tiết đơn hàng để in hóa đơn
        public Order GetOrderDetails(string orderId)
        {
            try
            {
                return _orderDAL.GetOrderById(orderId);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy chi tiết đơn hàng {orderId}: " + ex.Message, ex);
            }
        }
        // Lấy chi tiết các món trong đơn hàng
        public List<OrderItem> GetOrderMenuItem(string orderId)
        {
            return _orderDAL.GetOrderItemsByOrderId(orderId);
        }
        // In hóa đơn (giả lập, có thể mở rộng để in thực tế)
        public void PrintOrder(string orderId)
        {
            try
            {
                var order = GetOrderDetails(orderId);
                if (order == null)
                    throw new Exception($"Không tìm thấy đơn hàng {orderId}");

                // Logic in hóa đơn (giả lập)
                Console.WriteLine($"In hóa đơn cho đơn hàng {orderId}:");
                Console.WriteLine($"Thời gian: {order.CreatedAt}");
                Console.WriteLine($"Tổng tiền: {order.FinalAmount}");
                Console.WriteLine("Chi tiết:");
                foreach (var item in order.OrderItems)
                {
                    Console.WriteLine($"- {item.MenuItem.Name}: {item.Quantity} x {item.Price} = {item.Subtotal}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi in hóa đơn: " + ex.Message, ex);
            }
        }
    }


    // Lớp mô hình hiển thị lịch sử đơn hàng
    public class OrderHistory
    {
        public string OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
    }
}

