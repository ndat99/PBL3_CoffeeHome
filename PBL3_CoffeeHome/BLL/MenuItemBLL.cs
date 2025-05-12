using PBL3_CoffeeHome.DAL.Repository;
using PBL3_CoffeeHome.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_CoffeeHome.BLL
{
    public class MenuItemBLL
    {
        private readonly MenuItemDAL _menuItemDAL;

        public MenuItemBLL()
        {
            _menuItemDAL = new MenuItemDAL();
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

        // Cập nhật trạng thái đơn hàng
        public void CompleteOrder(string orderId)
        {
            _menuItemDAL.UpdateOrderStatus(orderId, "Completed");
        }
        public void IncompletedOrder(string orderId)
        {
            _menuItemDAL.UpdateOrderStatus(orderId, "Incompleted");
        }
        public MenuItems GetMenuItemByName(string name)
        {
            using (var db = new CoffeeDbContext())
            {
                return db.MenuItems.FirstOrDefault(m => m.Name == name && m.IsAvailable);
            }
        }
    }
}
