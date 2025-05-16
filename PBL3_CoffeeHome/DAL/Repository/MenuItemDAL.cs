using PBL3_CoffeeHome.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
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
        public MenuItems GetMenuItemByID(string id)
        {
            using (var db = new CoffeeDbContext())
            {
                return db.MenuItems.FirstOrDefault(m => m.MenuItemID == id && m.IsAvailable);
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
            return _context.MenuItems
                .Where(u => u.Name.Contains(searchTerm) ||
                           u.Category.Contains(searchTerm))
                .ToList();
        }

        public List<MenuItems> SearchMenuItems(string searchTerm, string category)
        {
            return _context.MenuItems
                .Where(u =>
                    (string.IsNullOrEmpty(searchTerm) ||
                     u.Name.Contains(searchTerm) ||
                     u.Category.Contains(searchTerm)) &&
                    (u.Category == category)
                )
                .ToList();
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
    }
}
