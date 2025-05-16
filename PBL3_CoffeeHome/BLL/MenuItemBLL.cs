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

        public List<String> GetAllMenuCategory()
        {
            var menuCategories = _menuItemDAL.GetAllMenuCategory();
            return menuCategories;
        }
        public List<MenuItems> SearchMenuItems(string searchTerm)
        {
            return _menuItemDAL.SearchMenuItems(searchTerm);
        }
        public List<MenuItems> SearchMenuItems(string searchTerm, string category)
        {
            return _menuItemDAL.SearchMenuItems(searchTerm, category);
        }
        public void AddMenuItem(MenuItems menuItem)
        {
            try
            {
                _menuItemDAL.AddMenuItem(menuItem);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm món ăn: " + ex.Message, ex);
            }
        }
        public void DeleteMenuItem(string id)
        {
            try
            {
                _menuItemDAL.DeleteMenuItem(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa món ăn: " + ex.Message, ex);
            }
        }
        public string GenerateNewMenuItemsId()
        {
            try
            {
                var menuItems = GetAllMenuItems();

                if (!menuItems.Any())
                {
                    return "MENU001";
                }

                // Lọc ra những ID hợp lệ bắt đầu bằng "MENU" và có hậu tố số
                var validIds = menuItems
                    .Where(u => !string.IsNullOrEmpty(u.MenuItemID) &&
                                u.MenuItemID.StartsWith("MENU") &&
                                u.MenuItemID.Length == 7 &&
                                int.TryParse(u.MenuItemID.Substring(4), out _))
                    .Select(u => int.Parse(u.MenuItemID.Substring(4)));

                int maxId = validIds.Any() ? validIds.Max() : 0;

                return $"MENU{(maxId + 1):D3}";
            }
            catch (Exception)
            {
                throw new Exception("Không thể tạo mã món mới!");
            }
        }

    }
}
