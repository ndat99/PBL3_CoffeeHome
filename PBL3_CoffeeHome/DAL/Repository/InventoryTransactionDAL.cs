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

        public List<TransactionDisplayDTO> GetAllTransaction()
        {
            return _db.InventoryTransactions.AsNoTracking()
                .Include(t => t.Inventory).Include(t => t.User)
                .GroupBy(t => new { t.Type, t.ItemID, Date = DbFunctions.TruncateTime(t.TransactionDate) })
                .Select(g => new TransactionDisplayDTO
                {
                    ItemID = g.Key.ItemID,
                    ItemName = g.FirstOrDefault().Inventory.Name,
                    Quantity = g.Sum(t => t.Quantity),
                    Unit = g.FirstOrDefault().Inventory.Unit,
                    Price = g.FirstOrDefault().TransactionPrice,
                    Type = g.Key.Type,
                    UserName = g.FirstOrDefault().User.UserName,
                    TransactionDate = g.Key.Date.Value,
                })
                .OrderByDescending(t => t.TransactionDate).ToList();
        }

        public List<string> GetTypeTransaction()
        {
            return _db.InventoryTransactions.AsNoTracking()
                                            .Select(t => t.Type).Distinct().ToList();
        }

        public List<TransactionDisplayDTO> GetTransactionByType(string type)
        {
            if (string.IsNullOrEmpty(type) || type == "Tất cả")
            {
                return GetAllTransaction();
            }
            return GetAllTransaction().Where(t => t.Type == type)
                                      .OrderByDescending(t => t.TransactionDate).ToList();
        }

        public List<InventoryTransaction> GetDetailTransaction(string itemID, DateTime transactionDate, string Type)
        {
            return _db.InventoryTransactions.AsNoTracking().Include(t => t.Inventory).Include(t => t.User)
                                            .Where(t => t.ItemID == itemID && t.Type == Type && DbFunctions.TruncateTime(t.TransactionDate) == transactionDate.Date)
                                            .OrderByDescending(t => t.TransactionDate).ToList();
        }

        public List<InventoryTransaction> GetTransactionStockOut()
        {
            return _db.InventoryTransactions.AsNoTracking()
                                            .Include(t => t.Inventory).Include(t => t.User)
                                            .Where(t => t.Type == "Xuất kho").OrderByDescending(t => t.TransactionDate).ToList();
        }

        public List<InventoryTransaction> GetTransactionStockIn()
        {
            return _db.InventoryTransactions.AsNoTracking()
                                            .Include(t => t.Inventory).Include(t => t.User)
                                            .Where(t => t.Type == "Nhập kho").OrderByDescending(t => t.TransactionDate).ToList();
        }

        // Chuc nang

        public List<TransactionDisplayDTO> SeaechTransaction(string txtSearch, DateTime startDate, DateTime endDate)
        {
            var query = GetAllTransaction().Where(t => t.TransactionDate >= startDate && t.TransactionDate <= endDate);

            txtSearch = txtSearch.Trim().ToLower();
            if (!string.IsNullOrWhiteSpace(txtSearch))
            {
                txtSearch = txtSearch.Trim().ToLower();
                query = query.Where(t => t.ItemName.ToLower().Contains(txtSearch) ||
                                        t.ItemID.ToLower().Contains(txtSearch));
            }

            return query.OrderByDescending(t => t.TransactionDate).ToList();
        }

        public bool StockIn(string itemID, decimal quantity, string userID, decimal price, DateTime expirationDate, string note = "")
        {
            try
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
                    Type = "Nhập kho"
                };

                _db.InventoryTransactions.Add(transaction);
                inventory.Quantity += quantity;
                inventory.CostPrice = price;
                inventory.ExpirationDate = expirationDate;

                return _db.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi nhập kho: {ex.Message}");
                return false;
            }
        }

        public bool StockOut(string itemID, decimal quantity, string userID, string orderID, string note = "")
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
                    Type = "Xuất kho",
                    TransactionDate = DateTime.Now,
                    UserID = userID,
                    OrderID = orderID,
                    Note = note,
                    TransactionPrice = inventory.CostPrice
                };
                _db.InventoryTransactions.Add(transaction);

                inventory.Quantity -= quantity;

                _db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi xuất kho: {ex.Message}");
                return false;
            }
        }

        public bool AuditInventory(string userId, string itemId, decimal quantityChange, string note = "")
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
                    Type = "Điều chỉnh",
                    TransactionDate = DateTime.Now,
                    UserID = userId,
                    Note = note,
                    TransactionPrice = inventoryItem.CostPrice
                };
                _db.InventoryTransactions.Add(transaction);

                inventoryItem.Quantity = newQuantity;
                _db.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kiểm kê: " + ex.Message);
                return false;
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
