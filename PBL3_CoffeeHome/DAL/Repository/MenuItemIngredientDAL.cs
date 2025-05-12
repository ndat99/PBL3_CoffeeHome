using PBL3_CoffeeHome.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_CoffeeHome.DAL.Repository
{
    class MenuItemIngredientDAL
    {
        private readonly CoffeeDbContext _db;
        public MenuItemIngredientDAL()
        {
            _db = new CoffeeDbContext();
        }
        public List<MenuItemIngredient> GetIngredientByMenuItemID(string menuItemId)
        {
            return _db.MenuItemIngredients.Include(i => i.Inventory)
                .Where(i => i.MenuItemID == menuItemId)
                .ToList();
        }
    }
}
