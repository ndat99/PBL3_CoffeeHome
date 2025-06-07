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
        public List<OrderItem> GetOrderItemsByOrderId(string orderId)
        {
            return _orderDAL.GetOrderItemsByOrderId(orderId);
        }
        
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
            _baristaQueueBLL.UpdateQueueStatus(queueID, baristaId, "Complete");
        }
    }

}

