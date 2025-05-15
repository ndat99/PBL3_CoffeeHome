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

        public MenuItemBLL()
        {
            _menuItemDAL = new MenuItemDAL();
            _orderDAL = new OrderDAL();
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
        public MenuItems GetMenuItemByID(string id)
        {
            return _menuItemDAL.GetMenuItemByID(id);
        }
        public List<MenuItems> GetAllMenuItems()
        {
            var menuItems = _menuItemDAL.GetAllMenuItems();
            return menuItems;

        }
    }
}
