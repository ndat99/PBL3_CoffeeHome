using System;
using System.Collections.Generic;
using System.Linq;
using PBL3_CoffeeHome.DAL;
using PBL3_CoffeeHome.DTO;
using PBL3_CoffeeHome.DTO.ViewModel;

namespace PBL3_CoffeeHome.BLL
{
    public class InventoryBLL
    {
        private readonly InventoryDAL _inventoryDAL;

        public InventoryBLL()
        {
            _inventoryDAL = new InventoryDAL();
        }

        public List<Inventory> GetAllInventory()
        {
            return _inventoryDAL.GetAllInventory();
        }

        public Inventory GetInventoryByID(string itemID)
        {
            if (itemID == null) return null;
            return _inventoryDAL.GetInventoryByID(itemID);
        }

        public Inventory GetInventoryByName(string name)
        {
            if (name == null) return null;
            return _inventoryDAL.GetInventoryByName(name);
        }

        public List<Inventory> GetInventoryByCategory(string category)
        {
            return _inventoryDAL.GetInventoryByCategory(category);
        }

        public List<Inventory> GetLowStock()
        {
            return _inventoryDAL.GetLowStock();
        }

        public List<Inventory> GetExpiring(int days)
        {
            return _inventoryDAL.GetExpiring(days);
        }

        public List<string> GetCategory()
        {
            return _inventoryDAL.GetCategory();
        }

        public List<string> GetUnit()
        {
            return _inventoryDAL.GetUnit();
        }

        //Chuc nang
        public List<Inventory> SearchInventory(string cboCategory, string txtSearch)
        {
            return _inventoryDAL.SearchInventory(cboCategory, txtSearch);
        }
        public bool AddInventory(Inventory newInventory)
        {
            if (newInventory == null) return false;
            if (string.IsNullOrEmpty(newInventory.ItemID))
            {
                newInventory.ItemID = _inventoryDAL.GenerateNewItemID();
            }
            var existingInventory = _inventoryDAL.GetInventoryByID(newInventory.ItemID);
            if (existingInventory != null)
            {
                return false;
            }
            return _inventoryDAL.AddInventory(newInventory);
        }

        public bool UpdateInventory(Inventory inventoryDTO)
        {
            if (inventoryDTO == null || string.IsNullOrEmpty(inventoryDTO.ItemID))
            {
                return false;
            }

            var inventoryUpdate = new Inventory
            {
                ItemID = inventoryDTO.ItemID,
                Name = inventoryDTO.Name,
                Category = inventoryDTO.Category,
                MinimumQuantity = inventoryDTO.MinimumQuantity,
                Unit = inventoryDTO.Unit,
                ExpirationDate = inventoryDTO.ExpirationDate,
                CostPrice = inventoryDTO.CostPrice
            };
            return _inventoryDAL.UpdateInventory(inventoryUpdate);
        }

        public bool DeleteInventory(string itemID)
        {
            if (string.IsNullOrEmpty(itemID))
            {
                return false;
            }
            if (_inventoryDAL.IsInventoryUsedMenu(itemID))
            {
                // throw new InvalidOperationException("Mặt hàng đang được sử dụng trong thực đơn, không thể xóa.");
                return false;
            }
            return _inventoryDAL.DeleteInventory(itemID);
        }

        public string GenerateNewItemID()
        {
            return _inventoryDAL.GenerateNewItemID();
        }

        public InventoryDisplayDTO InventoryDisplay(Inventory inventory)
        {
            if (inventory == null) return null;

            return new InventoryDisplayDTO
            {
                ItemID = inventory.ItemID,
                Name = inventory.Name,
                Category = inventory.Category,
                Quantity = inventory.Quantity,
                MinimumQuantity = inventory.MinimumQuantity,
                Unit = inventory.Unit,
                ExpirationDate = inventory.ExpirationDate,
                CostPrice = inventory.CostPrice
            };
        }
    }
}
