using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3_CoffeeHome.DTO;

namespace PBL3_CoffeeHome.DAL.Repository
{   // cập nhật doanh thu
    public class RevenueDAL
    {
        private readonly CoffeeDbContext _context;

        public RevenueDAL()
        {
            _context = new CoffeeDbContext();
        }

        public void AddRevenueDetail(RevenueDetail detail)
        {
            _context.RevenueDetails.Add(detail);
            _context.SaveChanges();
        }

        public Revenue GetCurrentRevenuePeriod()
        {
            DateTime now = DateTime.Now.Date;
            return _context.Revenues.FirstOrDefault(r => r.StartDate <= now && r.EndDate >= now);
        }

        public void UpdateTotalRevenue(string revenueID, decimal amount)
        {
            var revenue = _context.Revenues.Find(revenueID);
            if (revenue != null)
            {
                revenue.TotalRevenue += amount;
                _context.SaveChanges();
            }
        }
        public List<RevenueDetail> GetAllRevenueDetails()
        {
            return _context.RevenueDetails.ToList();
        }

        // Lấy chi phí theo ngày
        public decimal GetExpenseByDate(DateTime date)
        {
            try
            {
                var startDate = date.Date;
                var endDate = date.Date.AddDays(1).AddSeconds(-1);

                var expense = _context.InventoryTransactions
                    .Where(t => t.TransactionDate >= startDate &&
                               t.TransactionDate < endDate &&
                               t.Type == "Nhập")
                    .Join(_context.Inventory,
                          trans => trans.ItemID,
                          inv => inv.ItemID,
                          (trans, inv) => trans.Quantity * inv.CostPrice)  // Sử dụng CostPrice từ Inventory
                    .DefaultIfEmpty(0)
                    .Sum();

                return expense;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetExpenseByDate: {ex.Message}");
                return 0;
            }
        }

        public decimal GetExpenseByMonth(int year, int month)
        {
            try
            {
                var startDate = new DateTime(year, month, 1);
                var endDate = startDate.AddMonths(1);

                var expense = _context.InventoryTransactions
                    .Where(t => t.TransactionDate >= startDate &&
                               t.TransactionDate < endDate &&
                               t.Type == ("Nhập"))
                    .Join(_context.Inventory,
                          trans => trans.ItemID,
                          inv => inv.ItemID,
                          (trans, inv) => trans.Quantity * inv.CostPrice)  // Sử dụng CostPrice từ Inventory
                    .DefaultIfEmpty(0)
                    .Sum();

                return expense;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetExpenseByMonth: {ex.Message}");
                return 0;
            }
        }
    }

}