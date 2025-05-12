using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using PBL3_CoffeeHome.BLL;
using PBL3_CoffeeHome.DTO;

namespace PBL3_CoffeeHome.DAL
{
    public class InventoryDAL
    {
        private readonly CoffeeDbContext _db;
        public InventoryDAL()
        {
            _db = new CoffeeDbContext();
        }

        public List<Inventory> GetAllInventory()
        {
            return _db.Inventory.AsNoTracking().ToList();
        }

        public Inventory GetInventoryByID(string itemID)
        {
            return _db.Inventory.AsNoTracking().FirstOrDefault(i => i.ItemID == itemID);
        }

        public Inventory GetInventoryByName(string name)
        {
            return _db.Inventory.AsNoTracking().FirstOrDefault(i => i.Name == name);
        }

        public List<Inventory> GetInventoryByCategory(string category)
        {
            if (string.IsNullOrEmpty(category) || category == "Tất cả")
            {
                return GetAllInventory();
            }
            return _db.Inventory.AsNoTracking().Where(i => i.Category == category).ToList();
        }

        public List<Inventory> GetLowStock()
        {
            return _db.Inventory.AsNoTracking().Where(i => i.Quantity <= i.MinimumQuantity).ToList();
        }

        public List<Inventory> GetExpiring(int days)
        {
            var expiringDate = DateTime.Now.AddDays(7);
            var today = DateTime.Now.Date;
            return _db.Inventory.AsNoTracking().Where(i => i.ExpirationDate <= expiringDate && i.ExpirationDate >= today).OrderBy(c => c.ExpirationDate).ToList();
        }

        public List<string> GetCategory()
        {
            return _db.Inventory.AsNoTracking().Select(c => c.Category).Distinct().OrderBy(c => c).ToList();
        }

        // Chuc nang
        public List<Inventory> SearchInventory(string cboCategory, string txtSearch)
        {
            var querySearch = _db.Inventory.AsNoTracking().AsQueryable();
            if (!string.IsNullOrEmpty(cboCategory) && cboCategory != "Tất cả")
            {
                querySearch = querySearch.Where(i => i.Category == cboCategory);
            }
            if (!string.IsNullOrEmpty(txtSearch))
            {
                txtSearch = txtSearch.Trim().ToLower();
                querySearch = querySearch.Where(i => i.Name.ToLower().Contains(txtSearch) || i.ItemID.ToLower().Contains(txtSearch));
            }
            return querySearch.ToList();
        }

        public bool AddInventory(Inventory newInvnetory)
        {
            try
            {
                _db.Inventory.Add(newInvnetory);
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateInventory(Inventory updateInventory)
        {
            try
            {
                var item = _db.Inventory.Find(updateInventory.ItemID);
                if (item != null)
                {
                    item.Name = updateInventory.Name;
                    item.Category = updateInventory.Category;
                    item.MinimumQuantity = updateInventory.MinimumQuantity;
                    item.Unit = updateInventory.Unit;
                    item.ExpirationDate = updateInventory.ExpirationDate;
                    item.CostPrice = updateInventory.CostPrice;

                    _db.SaveChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteInventory(string itemIdDelete)
        {
            try
            {
                var item = _db.Inventory.Find(itemIdDelete);
                if (itemIdDelete != null)
                {
                    _db.Inventory.Remove(item);
                    _db.SaveChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public bool IsInventoryUsedMenu(string ItemID)
        {
            return _db.MenuItemIngredients.Any(m => m.ItemID == ItemID);
        }

        public bool CheckStockAvailability(string itemID, decimal requiredQuantity)
        {
            var item = GetInventoryByID(itemID);
            return item != null && item.Quantity >= requiredQuantity;
        }

    }
}