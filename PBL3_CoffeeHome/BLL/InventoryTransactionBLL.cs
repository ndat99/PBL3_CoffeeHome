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

        public List<TransactionDisplayDTO> GetAllTransactionDisplay()
        {
            return _transactionDAL.GetAllTransactionDisplay();
        }

        public List<string> GetTypeTransaction()
        {
            return _transactionDAL.GetAllTransactionDisplay()
                      .Select(t => t.Type).Distinct().ToList();
        }

        public List<TransactionDisplayDTO> GetTransactionsByType(string type)
        {
            if (string.IsNullOrEmpty(type) || type == "Tất cả")
            {
                return GetAllTransactionDisplay();
            }
            return _transactionDAL.GetAllTransactionDisplay()
                                  .Where(t => t.Type == type)
                                  .OrderByDescending(t => t.TransactionDate).ToList();
        }

        public List<InventoryTransaction> GetInformationTransaction(string ItemID, DateTime transactionDate)
        {
            return _transactionDAL.GetAllTransaction()
                                  .Where(t => t.ItemID == ItemID && t.TransactionDate.Date == transactionDate.Date)
                                  .OrderByDescending(t => t.TransactionDate).ToList();
        }


        public List<TransactionDisplayDTO> SeaechTransaction(string txtSearch, DateTime startDate, DateTime endDate)
        {
            var query = _transactionDAL.GetAllTransactionDisplay().Where(t => t.TransactionDate >= startDate && t.TransactionDate <= endDate);

            txtSearch = txtSearch.Trim().ToLower();
            if (!string.IsNullOrWhiteSpace(txtSearch))
            {
                txtSearch = txtSearch.Trim().ToLower();
                query = query.Where(t => t.ItemName.ToLower().Contains(txtSearch) ||
                                        t.ItemID.ToLower().Contains(txtSearch));
            }

            return query.OrderByDescending(t => t.TransactionDate).ToList();
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

        public List<TransactionStockIn> GetTransactionStockIn()
        {
            return _transactionDAL.GetTransactionStockIn ()
                                  .GroupBy(i => new { i.TransactionDate.Date,i.Inventory.Name,i.TransactionPrice })
                                  .Select(g => new TransactionStockIn
                                  {
                                      Name = g.Key.Name,
                                      Quantity = g.Sum(i => i.Quantity),
                                      TransactionDate = g.Key.Date,
                                      TransactionPrice = g.Key.TransactionPrice,
                                  }).OrderBy(d => d.TransactionDate).ToList();
        }

        public decimal TotalTransactionPriceInDate(DateTime date)
        {
            return GetTransactionStockIn()
                .Where(t => t.TransactionDate == date)
                .Sum(t => t.Quantity * t.TransactionPrice);
        }

        public decimal TotalTransactionPriceInMonth(int year, int month)
        {
            var startDate = new DateTime(year, month, 1);
            var endDate = startDate.AddMonths(1);

            return GetTransactionStockIn()
                .Where(t => t.TransactionDate >= startDate && t.TransactionDate < endDate)
                .Sum(t => t.Quantity * t.TransactionPrice); 
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
