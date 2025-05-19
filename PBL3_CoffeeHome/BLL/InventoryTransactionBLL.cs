using System;
using System.Collections.Generic;
using System.Linq;
using PBL3_CoffeeHome.DAL;
using PBL3_CoffeeHome.DTO;
using PBL3_CoffeeHome.DTO.ViewModel;

namespace PBL3_CoffeeHome.BLL
{
    public class InventoryTransactionBLL
    {
        private readonly InventoryTransactionDAL _transactionDAL;

        public InventoryTransactionBLL()
        {
            _transactionDAL = new InventoryTransactionDAL();
        }

        public List<TransactionDisplayDTO> GetAllTransaction()
        {
            return _transactionDAL.GetAllTransaction();
        }

        public List<string> GetTypeTransaction()
        {
            return _transactionDAL.GetTypeTransaction();
        }

        public List<TransactionDisplayDTO> GetTransactionsByType(string type)
        {
            return _transactionDAL.GetTransactionByType(type);
        }

        public List<InventoryTransaction> GetDetailTransaction(string ItemID, DateTime transactionDate, string Type)
        {
            return _transactionDAL.GetDetailTransaction(ItemID, transactionDate, Type);
        }


        public List<TransactionDisplayDTO> SeaechTransaction(string txtSearch, DateTime startDate, DateTime endDate)
        {
            return _transactionDAL.SeaechTransaction(txtSearch, startDate, endDate);
        }

        public List<TransactionStockOut> GetTransactionStockOut()
        {
            return _transactionDAL.GetTransactionStockOut()
                                  .GroupBy(i => new { i.Inventory.Name, i.Inventory.Unit, i.TransactionDate.Date })
                                  .Select(g => new TransactionStockOut
                                  {
                                      Name = g.Key.Name,
                                      Quantity = g.Sum(i => i.Quantity),
                                      Unit = g.Key.Unit,
                                      TransactionDate = g.Key.Date,
                                  }).OrderBy(d => d.TransactionDate).ToList();
        }


        public bool StockIn(string itemID, decimal quantity, string userID, decimal price, DateTime expirationDate, string note = "")
        {
            return _transactionDAL.StockIn(itemID, quantity, userID, price, expirationDate, note);
        }

        public bool StockOut(string itemID, decimal quantity, string userID, string orderID = null, string note = "")
        {
            return _transactionDAL.StockOut(itemID, quantity, userID, orderID, note);
        }

        public bool AuditInventory(string userID, string itemId, decimal quantityChange, string note)
        {
            return _transactionDAL.AuditInventory(userID, itemId, quantityChange, note);
        }

    }
}
