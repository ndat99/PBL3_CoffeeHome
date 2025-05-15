using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using PBL3_CoffeeHome.DTO;
using PBL3_CoffeeHome.DTO.ViewModel;

namespace PBL3_CoffeeHome.DAL
{
    public class InventoryTransactionDAL
    {
        private readonly CoffeeDbContext _db;
        public InventoryTransactionDAL()
        {
            _db = new CoffeeDbContext();
        }

        public List<InventoryTransaction> GetAllTransaction()
        {
            return  _db.InventoryTransactions.AsNoTracking()
                                             .Include(t => t.Inventory).Include(t => t.User)
                                             .ToList();
        }

        public List<TransactionDisplayDTO> GetAllTransactionDisplay()
        {
            return _db.InventoryTransactions.AsNoTracking()
                .Include(t => t.Inventory).Include(t => t.User)
                .GroupBy(t => new
                {
                    t.ItemID,
                    Date = DbFunctions.TruncateTime(t.TransactionDate)
                })
                .Select(g => new TransactionDisplayDTO
                {
                    ItemID = g.Key.ItemID,
                    TransactionDate = g.Key.Date.Value,
                    ItemName = g.FirstOrDefault().Inventory.Name,
                    Category = g.FirstOrDefault().Inventory.Category,
                    Quantity = g.Sum(t => t.Quantity),
                    Unit = g.FirstOrDefault().Inventory.Unit,
                    Type = g.FirstOrDefault().Type,
                    UserName = g.FirstOrDefault().User.FullName
                })
                .OrderByDescending(t => t.TransactionDate).ToList();
        }

        public List<InventoryTransaction> GetTransactionStockOut()
        {
            return _db.InventoryTransactions.AsNoTracking()
                                            .Include(t => t.Inventory).Include(t => t.User)
                                            .Where(t => t.Type == "Xuất").OrderByDescending(t => t.TransactionDate).ToList();
        }

        public List<InventoryTransaction> GetTransactionStockIn()
        {
            return _db.InventoryTransactions.AsNoTracking()
                                            .Include(t => t.Inventory).Include(t => t.User)
                                            .Where(t => t.Type.Contains("Nhập")).OrderByDescending(t => t.TransactionDate).ToList();
        }

        // Chuc nang
        public bool StockIn(string itemID, decimal quantity, string userID, decimal price, DateTime expirationDate, string note = "")
        {
            if (quantity <= 0 || price <= 0)
            {
                return false;
            }

            var inventory = _db.Inventory.FirstOrDefault(i => i.ItemID == itemID);
            if (inventory == null)
            {
                return false; 
            }

            var transaction = new InventoryTransaction
            {
                TransactionID = GenerateTransactionID(),
                ItemID = itemID,
                Quantity = quantity,
                UserID = userID,
                TransactionPrice = price,
                Note = note,
                TransactionDate = DateTime.Now,
                Type = "Nhập Kho"
            };

            _db.InventoryTransactions.Add(transaction);
            inventory.Quantity += quantity;
            inventory.CostPrice = price;
            inventory.ExpirationDate = expirationDate;

            return _db.SaveChanges() > 0;
        }

        public bool StockOut(string itemID, decimal quantity, string userID, string orderID, string note = "")
        {
            using (var dbContextTransaction = _db.Database.BeginTransaction())
            {
                try
                {
                    var inventory = _db.Inventory.Find(itemID);
                    if (inventory == null || inventory.Quantity < quantity)
                        return false;

                    var transaction = new InventoryTransaction
                    {
                        TransactionID = GenerateTransactionID(),
                        ItemID = itemID,
                        Quantity = quantity,
                        Type = "Xuất Kho",
                        TransactionDate = DateTime.Now,
                        UserID = userID,
                        OrderID = orderID,
                        Note = note,
                        TransactionPrice = inventory.CostPrice
                    };
                    _db.InventoryTransactions.Add(transaction);

                    inventory.Quantity -= quantity;

                    _db.SaveChanges();
                    dbContextTransaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    dbContextTransaction.Rollback();
                    Console.WriteLine($"Error: {ex.Message}");
                    return false;
                }
            }
        }

        public bool AuditInventory(string userId, string itemId, decimal quantityChange, string note = "")
        {
            using (var dbContextTransaction = _db.Database.BeginTransaction())
            {
                try
                {
                    var inventoryItem = _db.Inventory.Find(itemId);
                    if (inventoryItem == null)
                    {
                        return false;
                    }
                    decimal newQuantity = quantityChange + inventoryItem.Quantity;
                    var transaction = new InventoryTransaction
                    {
                        TransactionID = GenerateTransactionID(),
                        ItemID = itemId,
                        Quantity = quantityChange,
                        Type = "Điều Chỉnh",
                        TransactionDate = DateTime.Now,
                        UserID = userId,
                        Note = note,
                        TransactionPrice = inventoryItem.CostPrice
                    };
                    _db.InventoryTransactions.Add(transaction);

                    inventoryItem.Quantity = newQuantity;
                    _db.SaveChanges();
                    dbContextTransaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    dbContextTransaction.Rollback();
                    MessageBox.Show("Lỗi kiểm kê: " + ex.Message);
                    return false;
                }

            }
        }

        private string GenerateTransactionID()
        {
            string prefix = "TRX" + DateTime.Now.ToString("yyyyMMdd");
            string newId;
            int attempt = 0;
            do
            {
                attempt++;
                newId = prefix + attempt.ToString("D4");
            } while (_db.InventoryTransactions.AsNoTracking().Any(t => t.TransactionID == newId) && attempt < 9999);

            if (attempt >= 9999) throw new Exception("Không thể tạo mã giao dịch.");

            return newId;
        }
    }
}
