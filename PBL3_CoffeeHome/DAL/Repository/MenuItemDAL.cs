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
    }
}
