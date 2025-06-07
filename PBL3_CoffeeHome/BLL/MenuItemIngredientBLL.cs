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

        public void SaveMenuItemIngredients(string menuItemId, List<MenuItemIngredient> ingredients)
        {
            if(ingredients == null)
            {
                throw new ArgumentNullException(nameof(ingredients), "Nguyên liệu không được null");
            }
            foreach (var item in ingredients)
            {
               _menuItemIngredientDAL.Update(item);
            }
        }
        public void AddMenuItemIngredient(MenuItemIngredient ingredient)
        {
            if (ingredient == null)
            {
                throw new ArgumentNullException(nameof(ingredient), "Nguyên liệu không được null");
            }
            _menuItemIngredientDAL.AddMenuItemIngredient(ingredient);
        }

        public void DeleteMenuItemIngredientById(string Id)
        {
            if(Id == null)
            {
                throw new ArgumentNullException(nameof(Id), "Mã món không được null");
            }
            _menuItemIngredientDAL.DeleteByMenuItemId(Id);
        }
        public string GenerateNewIngredientId()
        {
            var all = _menuItemIngredientDAL.GetAllMenuItemIngredients();

            int maxId = all
                .Where(i => i.Id.StartsWith("MI") && i.Id.Length == 5 && int.TryParse(i.Id.Substring(2), out _))
                .Select(i => int.Parse(i.Id.Substring(2)))
                .DefaultIfEmpty(0)
                .Max();

            return $"MI{(maxId + 1):D3}";
        }
    }
}
