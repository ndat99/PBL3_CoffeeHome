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
    
        // Lấy doanh thu hàng ngày trong tháng
        public List<(int Day, decimal Total)> GetDailyRevenueInMonth(int year, int month)
        {
            var revenueDetails = GetAllRevenueDetails()
                .Where(rd => rd.Revenue != null && rd.Revenue.StartDate.Year == year && rd.Revenue.StartDate.Month == month);

            var dailyRevenue = revenueDetails
                .GroupBy(rd => rd.Revenue.StartDate.Day)
                .Select(g => new { Day = g.Key, Total = g.Sum(rd => rd.RevenueAmount) })
                .OrderBy(g => g.Day)
                .ToList();

            int daysInMonth = DateTime.DaysInMonth(year, month);
            var result = new List<(int Day, decimal Total)>();
            for (int i = 1; i <= daysInMonth; i++)
            {
                var dayData = dailyRevenue.FirstOrDefault(dr => dr.Day == i);
                result.Add((i, dayData?.Total ?? 0));
            }

            return result;
        }

        // Lấy doanh thu hàng tháng trong năm
        public List<(int Month, decimal Total)> GetMonthlyRevenueInYear(int year)
        {
            var revenueDetails = GetAllRevenueDetails()
                .Where(rd => rd.Revenue != null && rd.Revenue.StartDate.Year == year);

            var monthlyRevenue = revenueDetails
                .GroupBy(rd => rd.Revenue.StartDate.Month)
                .Select(g => new { Month = g.Key, Total = g.Sum(rd => rd.RevenueAmount) })
                .OrderBy(g => g.Month)
                .ToList();

            var result = new List<(int Month, decimal Total)>();
            for (int i = 1; i <= 12; i++)
            {
                var monthData = monthlyRevenue.FirstOrDefault(mr => mr.Month == i);
                result.Add((i, monthData?.Total ?? 0));
            }

            return result;
        }

        // Lấy danh sách sản phẩm bán chạy nhất 
        public List<(string ItemName, int TotalQuantity)> GetTopSellingProducts()
        {
            var revenueDetails = GetAllRevenueDetails()
                .Where(rd => !string.IsNullOrEmpty(rd.ItemName));

            var allProducts = revenueDetails
                .GroupBy(rd => rd.ItemName)
                .Select(g => new
                {
                    ItemName = g.Key,
                    TotalQuantity = g.Sum(rd => rd.Quantity)
                })
                .OrderByDescending(g => g.TotalQuantity)
                .ToList();

            // Lấy top 5 sản phẩm
            var topProducts = allProducts.Take(5).ToList();

            // Tính tổng số lượng của các sản phẩm còn lại
            int othersQuantity = allProducts.Skip(5).Sum(p => p.TotalQuantity);

            // Tạo danh sách kết quả bao gồm top 5 và "Khác"
            var result = topProducts.Select(p => (p.ItemName, p.TotalQuantity)).ToList();

            if (othersQuantity > 0)
            {
                result.Add(("Khác", othersQuantity));
            }

            return result;
        }
        // Lấy danh sách sản phẩm bán chạy nhất theo năm
        public List<(string ItemName, int TotalQuantity)> GetTopSellingProductsByYear(int year)
        {
            var revenueDetails = GetAllRevenueDetails()
                .Where(rd => !string.IsNullOrEmpty(rd.ItemName) && rd.Revenue != null && rd.Revenue.StartDate.Year == year);

            var allProducts = revenueDetails
                .GroupBy(rd => rd.ItemName)
                .Select(g => new
                {
                    ItemName = g.Key,
                    TotalQuantity = g.Sum(rd => rd.Quantity)
                })
                .OrderByDescending(g => g.TotalQuantity)
                .ToList();

            var topProducts = allProducts.Take(5).ToList();
            int othersQuantity = allProducts.Skip(5).Sum(p => p.TotalQuantity);

            var result = topProducts.Select(p => (p.ItemName, p.TotalQuantity)).ToList();
            if (othersQuantity > 0)
            {
                result.Add(("Khác", othersQuantity));
            }

            return result;
        }
        // Lấy danh sách sản phẩm bán chạy nhất theo tháng
        public List<(string ItemName, int TotalQuantity)> GetTopSellingProductsByMonth(int year, int month)
        {
            var revenueDetails = GetAllRevenueDetails()
                .Where(rd => !string.IsNullOrEmpty(rd.ItemName) && rd.Revenue != null &&
                             rd.Revenue.StartDate.Year == year && rd.Revenue.StartDate.Month == month);

            var allProducts = revenueDetails
                .GroupBy(rd => rd.ItemName)
                .Select(g => new
                {
                    ItemName = g.Key,
                    TotalQuantity = g.Sum(rd => rd.Quantity)
                })
                .OrderByDescending(g => g.TotalQuantity)
                .ToList();

            var topProducts = allProducts.Take(5).ToList();
            int othersQuantity = allProducts.Skip(5).Sum(p => p.TotalQuantity);

            var result = topProducts.Select(p => (p.ItemName, p.TotalQuantity)).ToList();
            if (othersQuantity > 0)
            {
                result.Add(("Khác", othersQuantity));
            }

            return result;
        }
        public decimal GetTotalRevenueByYear(int year)
        {
            var revenueDetails = GetAllRevenueDetails()
                .Where(rd => rd.Revenue != null && rd.Revenue.StartDate.Year == year);
            return revenueDetails.Sum(rd => rd.RevenueAmount);
        }

        // Tính tổng doanh thu theo tháng
        public decimal GetTotalRevenueByMonth(int year, int month)
        {
            var revenueDetails = GetAllRevenueDetails()
                .Where(rd => rd.Revenue != null && rd.Revenue.StartDate.Year == year && rd.Revenue.StartDate.Month == month);
            return revenueDetails.Sum(rd => rd.RevenueAmount);
        }
        // Tính tổng số lượng sản phẩm đã bán
        public int GetTotalProductsSold()
        {
            var revenueDetails = GetAllRevenueDetails();
            return revenueDetails.Sum(rd => rd.Quantity);
        }
        // Tính tổng số lượng sản phẩm đã bán theo năm
        public int GetTotalProductsSoldByYear(int year)
        {
            var revenueDetails = GetAllRevenueDetails()
                .Where(rd => rd.Revenue != null && rd.Revenue.StartDate.Year == year);
            return revenueDetails.Sum(rd => rd.Quantity);
        }

        // Tính tổng số lượng sản phẩm đã bán theo tháng
        public int GetTotalProductsSoldByMonth(int year, int month)
        {
            var revenueDetails = GetAllRevenueDetails()
                .Where(rd => rd.Revenue != null && rd.Revenue.StartDate.Year == year && rd.Revenue.StartDate.Month == month);
            return revenueDetails.Sum(rd => rd.Quantity);
        }

        // Tính tổng lượng khách (dựa trên OrderID duy nhất)
        public int GetTotalCustomers()
        {
            var revenueDetails = GetAllRevenueDetails()
                .Where(rd => !string.IsNullOrEmpty(rd.OrderID));
            return revenueDetails.Select(rd => rd.OrderID).Distinct().Count();
        }
        // Tính tổng lượng khách theo năm (dựa trên OrderID duy nhất)
        public int GetTotalCustomersByYear(int year)
        {
            var revenueDetails = GetAllRevenueDetails()
                .Where(rd => !string.IsNullOrEmpty(rd.OrderID) && rd.Revenue != null && rd.Revenue.StartDate.Year == year);
            return revenueDetails.Select(rd => rd.OrderID).Distinct().Count();
        }

        public int GetTotalCustomersByMonth(int year, int month)
        // Tính tổng lượng khách theo tháng (dựa trên OrderID duy nhất))
        {
            var revenueDetails = GetAllRevenueDetails()
                .Where(rd => !string.IsNullOrEmpty(rd.OrderID) && rd.Revenue != null &&
                             rd.Revenue.StartDate.Year == year && rd.Revenue.StartDate.Month == month);
            return revenueDetails.Select(rd => rd.OrderID).Distinct().Count();
        }
    }
}