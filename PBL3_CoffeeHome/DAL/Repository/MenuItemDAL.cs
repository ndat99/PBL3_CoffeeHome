using PBL3_CoffeeHome.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
