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
        private readonly InventoryTransactionDAL _transactionDAL;

        public InventoryBLL()
        {
            _inventoryDAL = new InventoryDAL();
            _transactionDAL = new InventoryTransactionDAL();
        }

        public List<InventoryDisplayDTO> GetAllInventory()
        {
            var inventoryList = _inventoryDAL.GetAllInventory();
            return inventoryList.Select(InventoryDisplay).ToList();
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

        public List<InventoryDisplayDTO> GetInventoryByCategory(string category)
        {
            var inventoryList = _inventoryDAL.GetInventoryByCategory(category);
            return inventoryList.Select(InventoryDisplay).ToList();
        }

        public List<InventoryDisplayDTO> GetLowStock()
        {
            var expiringItem = _inventoryDAL.GetLowStock();
            return expiringItem.Select(InventoryDisplay).ToList();
        }

        public List<InventoryDisplayDTO> GetExpiring(int days)
        {
            var expiringItem = _inventoryDAL.GetExpiring(days);
            return expiringItem.Select(InventoryDisplay).ToList();
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
        public List<InventoryDisplayDTO> SearchInventory(string cboCategory, string txtSearch)
        {
            var inventoryList = _inventoryDAL.SearchInventory(cboCategory, txtSearch);
            return inventoryList.Select(InventoryDisplay).ToList();
        }
        public bool AddInventory(Inventory newInventory)
        {   
            if (newInventory == null)  return false;
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

        // Kiểm tra xem số lượng hàng tồn có đủ cho yêu cầu không
        public bool CheckStockAvailability(string itemID, decimal requiredQuantity)
        {
            if (string.IsNullOrEmpty(itemID) || requiredQuantity < 0) return false;
            return _inventoryDAL.CheckStockAvailability(itemID, requiredQuantity);
        }

        // Kiem ke
        public List<InventoryCheckDTO> GetInventoryAuditing()
        {
            List<Inventory> inventoryList = _inventoryDAL.GetAllInventory();

            return inventoryList.Select(item => new InventoryCheckDTO
            {
                ItemID = item.ItemID,
                Name = item.Name,
                Category = item.Category,
                SystemQuantity = item.Quantity,
                ActualQuantity = item.Quantity,
                Unit = item.Unit
            }).ToList();

        }

        public string GenerateNewItemID()
        {
            return _inventoryDAL.GenerateNewItemID();
        }

        private InventoryDisplayDTO InventoryDisplay(Inventory inventory)
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
