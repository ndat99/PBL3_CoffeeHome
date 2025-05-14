using PBL3_CoffeeHome.DAL.Repository;
using PBL3_CoffeeHome.DTO;
using PBL3_CoffeeHome.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using System.Collections;

namespace PBL3_CoffeeHome.BLL
{
    public class MenuItemBLL
    {
        private readonly MenuItemDAL _menuItemDAL;
        private readonly OrderDAL _orderDAL;
        private readonly BaristaQueueBLL _baristaQueueBLL;
        private readonly InventoryTransactionDAL _inventoryTransactionBLL;
        private readonly MenuItemIngredientBLL _menuItemIngredientBLL;

        public MenuItemBLL()
        {
            _menuItemDAL = new MenuItemDAL();
            _orderDAL = new OrderDAL();
            _baristaQueueBLL = new BaristaQueueBLL();
            _menuItemIngredientBLL = new MenuItemIngredientBLL();
            _inventoryTransactionBLL = new InventoryTransactionDAL();
        }
        // Lấy danh sách đơn hàng có trạng thái "Incompleted"
        public List<Order> GetOrdersWithStatus(string status)
        {
            return _orderDAL.GetOrdersByBaristaQueueStatus(status);
        }
        // Lấy thông tin món theo tên
        public MenuItems GetMenuItemByName(string name)
        {
            return _menuItemDAL.GetMenuItemByName(name);
        }

        // Cập nhật trạng thái đơn hàng
        public void CompleteOrder(string orderId, string queueID,string userId)
        {
            var orderItems = _orderDAL.GetOrderItemsByOrderId(orderId);
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
            _baristaQueueBLL.UpdateQueueStatus(queueID, "Completed");
        }
    }
}
