using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3_CoffeeHome.DAL.Repository;
using PBL3_CoffeeHome.DAL;
using PBL3_CoffeeHome.DTO;
using Microsoft.VisualBasic.ApplicationServices;

namespace PBL3_CoffeeHome.BLL
{
    public class OrderBLL
    {
        private readonly OrderDAL _orderDAL;
        private readonly RevenueBLL _revenueBLL;
        private readonly RevenueDetailsBLL _revenueDetailsBLL;
        private readonly MenuItemIngredientBLL _menuItemIngredientBLL;
        private readonly BaristaQueueBLL _baristaQueueBLL;
        private readonly InventoryTransactionBLL _inventoryTransactionBLL;

        public OrderBLL()
        {
            _orderDAL = new OrderDAL();
            _revenueBLL = new RevenueBLL();
            _revenueDetailsBLL = new RevenueDetailsBLL();
            _menuItemIngredientBLL = new MenuItemIngredientBLL();
            _baristaQueueBLL = new BaristaQueueBLL();
            _inventoryTransactionBLL = new InventoryTransactionBLL();
        }
        public void AddOrder(string orderId, DateTime createdAt, int cardNumber, decimal totalAmount, decimal discountAmount, decimal finalAmount, string userId, string discountId)
        {
            _orderDAL.AddOrder(orderId, createdAt, cardNumber, totalAmount, discountAmount, finalAmount, userId,discountId);
        }

        public string GenerateOrderID()
        {
            return _orderDAL.GenerateOrderID();
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
        public List<OrderItem> GetOrderItemsByOrderId(string orderId)
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
        // Cập nhật trạng thái đơn hàng
        public void CompleteOrder(string orderId, string queueID, string baristaId)
        {
            var orderItems = _orderDAL.GetOrderItemsByOrderId(orderId);
            foreach (var orderItem in orderItems)
            {
                decimal totalExpense = 0;
                var ingredients = _menuItemIngredientBLL.GetMenuItemIngredient(orderItem.MenuItemID);
                foreach (var ingredient in ingredients)
                {
                    decimal totalQty = ingredient.QuantityRequired * orderItem.Quantity;
                    _inventoryTransactionBLL.StockOut(ingredient.ItemID, totalQty, baristaId, orderId,
                        $"Xuất tự động cho đơn hàng");
                    decimal totalCost = ingredient.Inventory.CostPrice * totalQty;
                    totalExpense += totalCost;
                }

                string revenueId = "RVE" + DateTime.Now.ToString("yyyyMMdd");
                _revenueBLL.AddRevenue(revenueId, orderItem.Subtotal, totalExpense);
                _revenueDetailsBLL.AddRevenueDetails(orderItem, revenueId, orderItem.MenuItemID, orderItem.Subtotal);
            }
            _baristaQueueBLL.UpdateQueueStatus(queueID, baristaId, "Completed");
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

