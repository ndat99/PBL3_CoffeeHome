using PBL3_CoffeeHome.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_CoffeeHome.DAL.Repository
{
    public class MenuItemDAL
    {
        private readonly CoffeeDbContext _context;

        public MenuItemDAL()
        {
            _context = new CoffeeDbContext();
        }
        public MenuItems GetMenuItemByName(string name)
        {
            using (var db = new CoffeeDbContext())
            {
                return db.MenuItems.FirstOrDefault(m => m.Name == name && m.IsAvailable);
            }
        }
        
        public List<MenuItems> GetAllMenuItems()
        {
            using (var db = new CoffeeDbContext())
            {
                return db.MenuItems
                    .Include(m => m.MenuItemIngredients.Select(mi => mi.Inventory))
                    .Where(m => m.IsAvailable)
                    .ToList();
            }
        }
        public List<MenuItems> GetMenuItemsByCategory(string category)
        {
            using (var db = new CoffeeDbContext())
            {
                return db.MenuItems
                    .Include(m => m.MenuItemIngredients.Select(mi => mi.Inventory))
                    .Where(m => m.IsAvailable && m.Category == category)
                    .ToList();
            }
        }
        public List<String> GetAllMenuCategory()
        {
            using (var db = new CoffeeDbContext())
            {
                return db.MenuItems
                         .Select(m => m.Category)
                         .Distinct()
                         .ToList();
            }
        }

        public List<MenuItems> SearchMenuItems(string searchTerm)
        {
            using (var db = new CoffeeDbContext())
            {
                if (string.IsNullOrEmpty(searchTerm))
                {
                    return db.MenuItems.ToList();
                }
                return db.MenuItems
                    .Where(u => u.Name.Contains(searchTerm) ||
                                u.Category.Contains(searchTerm))
                    .ToList();
            }
        }

        public List<MenuItems> SearchMenuItems(string searchTerm, string category)
        {
            using(var db = new CoffeeDbContext())
            {
                if (string.IsNullOrEmpty(searchTerm) && string.IsNullOrEmpty(category))
                {
                    return db.MenuItems.ToList();
                }
                return db.MenuItems
                    .Where(u =>
                        (string.IsNullOrEmpty(searchTerm) ||
                         u.Name.Contains(searchTerm) ||
                         u.Category.Contains(searchTerm)) &&
                        (string.IsNullOrEmpty(category) || u.Category == category))
                    .ToList();
            }
        }

        public void AddMenuItem(MenuItems item)
        {
            _context.MenuItems.Add(item);
            _context.SaveChanges();
        }
        public void DeleteMenuItem(string id)
        {
            var item = _context.MenuItems.Find(id);
            if (item != null)
            {
                _context.MenuItems.Remove(item);
                _context.SaveChanges();
            }
        }

        public void UpdateMenuItem(MenuItems updatedItem)
        {
            var existingItem = _context.MenuItems.Find(updatedItem.MenuItemID);
            if (existingItem != null)
            {
                // Cập nhật các trường thông tin
                existingItem.Name = updatedItem.Name;
                existingItem.Category = updatedItem.Category;
                existingItem.Price = updatedItem.Price;
                existingItem.IsAvailable = updatedItem.IsAvailable;
                existingItem.ImagePath = updatedItem.ImagePath;

                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Không tìm thấy món ăn để cập nhật.");
            }
        }

        public bool UpdateImage(string menuItemId, string imagePath)
        {
            using (var context = new CoffeeDbContext())
            {
                var menuItem = context.MenuItems.Find(menuItemId);
                if (menuItem != null)
                {
                    // Xóa ảnh cũ nếu có
                    if (!string.IsNullOrEmpty(menuItem.ImagePath))
                    {
                        string oldImagePath = Path.Combine(Application.StartupPath, menuItem.ImagePath);
                        if (File.Exists(oldImagePath))
                            File.Delete(oldImagePath);
                    }

                    menuItem.ImagePath = imagePath;
                    context.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        public String getImagePath(string menuItemId)
        {
            using (var context = new CoffeeDbContext())
            {
                var menuItem = context.MenuItems.Find(menuItemId);
                if (menuItem != null)
                {
                    return menuItem.ImagePath;
                }
                return null;
            }
        }
    }
}
