using PBL3_CoffeeHome.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
        public void DeleteByMenuItemId(string Id)
        {
            if (string.IsNullOrEmpty(Id))
                return;

            var entity = _db.MenuItemIngredients.FirstOrDefault(mii => mii.Id == Id);
            if (entity != null)
            {
                _db.MenuItemIngredients.Remove(entity);
                _db.SaveChanges();
            }
        }
        public List<MenuItemIngredient> GetAllMenuItemIngredients()
        {
            return _db.MenuItemIngredients
                              .Include(i => i.Inventory)   
                              .Include(i => i.MenuItem) 
                              .ToList();
        }
        public void AddMenuItemIngredient(MenuItemIngredient ingredient)
        {
            _db.MenuItemIngredients.Add(ingredient);
            _db.SaveChanges();
        }

        public void Update(MenuItemIngredient ingredient)
        {
            var existing = _db.MenuItemIngredients.SingleOrDefault(x => x.Id == ingredient.Id);
            if(existing == null)
            {
                throw new Exception("Nguyên liệu không tồn tại.");
            }
            existing.MenuItemID = ingredient.MenuItemID;
            existing.ItemID = ingredient.ItemID;
            existing.QuantityRequired = ingredient.QuantityRequired;
            existing.Unit = ingredient.Unit;

            _db.SaveChanges();
        }
    }
}
