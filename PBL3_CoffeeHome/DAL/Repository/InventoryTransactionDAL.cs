using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using PBL3_CoffeeHome.DTO;

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
            return _db.InventoryTransactions.AsNoTracking()
                                            .Include(t => t.Inventory).Include(t => t.User)
                                            .OrderByDescending(t => t.TransactionDate).ToList();
        }

        public List<InventoryTransaction> GetTransactionByDateRange(DateTime startDate, DateTime endDate)
        {
            endDate = endDate.Date.AddDays(1).AddTicks(-1);
            return _db.InventoryTransactions.AsNoTracking()
                                            .Include(t => t.Inventory).Include(t => t.User)
                                            .Where(t => t.TransactionDate >= startDate && t.TransactionDate <= endDate).OrderByDescending(t => t.TransactionDate).ToList();
        }

        public List<InventoryTransaction> GetTranSactionByName(string name)
        {
            return _db.InventoryTransactions.AsNoTracking()
                                 .Include(t => t.Inventory)
                                 .Where(t => t.Inventory.Name == name).OrderByDescending(t => t.TransactionDate).ToList();
        }
        public List<InventoryTransaction> GetTransactionByType(string type)
        {
            if (string.IsNullOrEmpty(type) || type == "Tất cả")
            {
                return GetAllTransaction();
            }
            return _db.InventoryTransactions.AsNoTracking()
                                            .Include(t => t.Inventory).Include(t => t.User)
                                            .Where(t => t.Type == type).OrderByDescending(t => t.TransactionDate).ToList();
        }

        public List<InventoryTransaction> GetTransactionStockOut()
        {
            return _db.InventoryTransactions.AsNoTracking()
                                            .Include(t => t.Inventory).Include(t => t.User)
                                            .Where(t => t.Type == "Xuất").OrderByDescending(t => t.TransactionDate).ToList();
        }

        // Chuc nang
        public bool StockIn(string itemID, decimal quantity, string userID, decimal price, DateTime expirationDate, string note = "")
        {
            if (quantity <= 0 || price <= 0)
            {
                return false; // Số lượng hoặc giá không hợp lệ
            }

            // Thêm logic kiểm tra tồn tại của itemID trong cơ sở dữ liệu
            var inventory = _db.Inventory.FirstOrDefault(i => i.ItemID == itemID);
            if (inventory == null)
            {
                return false; // Không tìm thấy nguyên liệu
            }

            // Thực hiện nhập kho
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
                        Type = "Xuất",
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
