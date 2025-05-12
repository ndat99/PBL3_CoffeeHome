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
        private readonly BaristaQueueBLL _baristaQueueBLL;

        public OrderBLL()
        {
            _orderDAL = new OrderDAL();
            _revenueDAL = new RevenueDAL();
            _baristaQueueBLL = new BaristaQueueBLL();
        }

        //ProcessOrder
        public void ProcessOrder(string userId, int cardNumber, List<(string menuItemId, int quantity)> items, string discountId = null)
        {
            var context = new CoffeeDbContext();
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
                    inventoryItem.Quantity -= ing.QuantityRequired * quantity;

                    //// Ghi nhật ký giao dịch tồn kho
                    //InventoryTransactionDAL.AddTransaction(new InventoryTransaction
                    //{
                    //    TransactionID = Guid.NewGuid().ToString(),
                    //    ItemID = ing.ItemID,
                    //    Quantity = ing.QuantityRequired * quantity,
                    //    Type = "Used",
                    //    TransactionDate = DateTime.Now,
                    //    UserID = userId
                    //});
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
                Status = "Đã thanh toán",
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
                        ItemName = context.MenuItems.Find(oi.MenuItemID).Name,
                        Quantity = oi.Quantity,
                        RevenueAmount = oi.Subtotal
                    });
                }

                _revenueDAL.UpdateTotalRevenue(revenue.RevenueID, finalAmount);
            }
        }

        // Các phương thức bổ sung
        public Order GetOrderById(string orderId)
        {
            return _orderDAL.GetOrderById(orderId);
        }

        public List<Order> GetOrdersByStatus(string status)
        {
            return _orderDAL.GetOrdersByStatus(status);
        }

        public bool UpdateOrderStatus(string orderId, string status)
        {
            return _orderDAL.UpdateOrderStatus(orderId, status);
        }

        public bool CancelOrder(string orderId)
        {
            var order = _orderDAL.GetOrderById(orderId);
            if (order == null || order.Status == "Completed")
                return false;

            // Hoàn trả tồn kho
            using (var context = new CoffeeDbContext())
            {
                foreach (var item in order.OrderItems)
                {
                    var ingredients = context.MenuItemIngredients
                        .Where(i => i.MenuItemID == item.MenuItemID)
                        .ToList();

                    foreach (var ing in ingredients)
                    {
                        var inventoryItem = context.Inventory.Find(ing.ItemID);
                        inventoryItem.Quantity += ing.QuantityRequired * item.Quantity;
                    }
                }

                order.Status = "Cancelled";
                return _orderDAL.UpdateOrder(order);
            }
        }

        public bool UpdateOrder(Order order)
        {
            return _orderDAL.UpdateOrder(order);
        }
    }
}
