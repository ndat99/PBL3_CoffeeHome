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

        public List<TransactionDisplayDTO> GetAllTransactions()
        {
            var transactions = _transactionDAL.GetAllTransaction();
            return transactions.Select(ToTransactionDisplayDTO).ToList();
        }

        public List<InventoryTransaction> GetTranSactionByName(string Name)
        {
            return _transactionDAL.GetTranSactionByName(Name);
        }
        public List<TransactionDisplayDTO> GetTransactionsByDateRange(DateTime startDate, DateTime endDate)
        {
            var transactions = _transactionDAL.GetTransactionByDateRange(startDate, endDate);
            return transactions.Select(ToTransactionDisplayDTO).ToList();
        }

        public List<TransactionDisplayDTO> GetTransactionsByType(string type)
        {
            var transactions = _transactionDAL.GetTransactionByType(type);
            return transactions.Select(ToTransactionDisplayDTO).ToList();
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


        private TransactionDisplayDTO ToTransactionDisplayDTO(InventoryTransaction transaction)
        {
            if (transaction == null) return null;

            return new TransactionDisplayDTO
            {
                TransactionID = transaction.TransactionID,
                TransactionDate = transaction.TransactionDate,
                ItemID = transaction.ItemID,
                ItemName = transaction.Inventory?.Name,
                Category = transaction.Inventory?.Category,
                Quantity = transaction.Quantity,
                Unit = transaction.Inventory?.Unit,
                Type = transaction.Type,
                UserID = transaction.UserID,
                UserName = transaction.User.UserName,
                Note = transaction.Note
            };
        }
    }
}
