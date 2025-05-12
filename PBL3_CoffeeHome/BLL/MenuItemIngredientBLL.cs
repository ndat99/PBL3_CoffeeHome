using PBL3_CoffeeHome.DAL.Repository;
using PBL3_CoffeeHome.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_CoffeeHome.BLL
{
    public class MenuItemIngredientBLL
    {
        private readonly MenuItemIngredientDAL _menuItemIngredientDAL;
        public MenuItemIngredientBLL()
        {
            _menuItemIngredientDAL = new MenuItemIngredientDAL();
        }
        public List<MenuItemIngredient> GetMenuItemIngredient(string menuItemId)
        {
            return _menuItemIngredientDAL.GetIngredientByMenuItemID(menuItemId);
        }
    }
}
