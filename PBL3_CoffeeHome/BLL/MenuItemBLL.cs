using PBL3_CoffeeHome.DAL.Repository;
using PBL3_CoffeeHome.DTO;
using PBL3_CoffeeHome.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;

namespace PBL3_CoffeeHome.BLL
{
    public class MenuItemBLL
    {
        private readonly MenuItemDAL _menuItemDAL;
        private readonly InventoryTransactionDAL _inventoryTransactionBLL;
        private readonly MenuItemIngredientBLL _menuItemIngredientBLL;

        public MenuItemBLL()
        {
            _menuItemDAL = new MenuItemDAL();
            _menuItemIngredientBLL = new MenuItemIngredientBLL();
            _inventoryTransactionBLL = new InventoryTransactionDAL();
        }
        // Lấy danh sách tất cả đơn hàng
        public List<Order> GetOrders()
        {
            return _menuItemDAL.GetAllOrders();

        }

        // Lấy danh sách đơn hàng của ngày hôm nay
        public List<Order> GetOrdersAssignedToday(string status)
        {
            return _menuItemDAL.GetOrdersAssignedToday(status);
        }

        // Lấy danh sách đơn hàng đã hoàn thành trong ngày được chọn
        public List<Order> GetOrdersCompletedOnDate(string status, DateTime selectedDate)
        {
            return _menuItemDAL.GetOrdersCompletedOnDate(status, selectedDate);
        }

        // Lấy danh sách đơn hàng có trạng thái "Incompleted"
        public List<Order> GetOrdersWithStatus(string status)
        {
            return _menuItemDAL.GetOrdersWithStatus(status);
        }

        // Lấy chi tiết các món trong đơn hàng
        public List<OrderItem> GetOrderDetails(string orderId)
        {
            return _menuItemDAL.GetOrderItemsByOrderId(orderId);
        }
        // Lấy thông tin món theo tên
        public MenuItems GetMenuItemByName(string name)
        {
            return _menuItemDAL.GetMenuItemByName(name);
        }

        // Cập nhật trạng thái đơn hàng
        public void CompleteOrder(string orderId, string userId)
        {
            var order = _menuItemDAL.GetOrderById(orderId);

            var orderItems = _menuItemDAL.GetOrderItemsByOrderId(orderId);
            foreach (var orderItem in orderItems)
            {
                var ingredients = _menuItemIngredientBLL.GetMenuItemIngredient(orderItem.MenuItemID);
                foreach (var ingredient in ingredients)
                {
                    decimal totalQty = ingredient.QuantityRequired * orderItem.Quantity;
                    _inventoryTransactionBLL.StockOut(ingredient.ItemID, totalQty, userId, orderId,
                        $"Xuất tự động cho đơn hàng");
                }
            }
            _menuItemDAL.UpdateOrderStatus(orderId, "Completed");
        }
    }
}
