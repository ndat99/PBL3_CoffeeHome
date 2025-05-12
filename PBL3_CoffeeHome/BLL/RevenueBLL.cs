using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3_CoffeeHome.DAL.Repository;
using PBL3_CoffeeHome.DTO;

namespace PBL3_CoffeeHome.BLL
{
    public class RevenueBLL
    {
        private readonly RevenueDAL _revenueDAL;

        public RevenueBLL()
        {
            _revenueDAL = new RevenueDAL();
        }

        // Lấy dữ liệu doanh thu hàng ngày trong tháng
        public List<(int Day, decimal Total)> GetDailyRevenueInMonth(int year, int month)
        {
            var revenueDetails = _revenueDAL.GetAllRevenueDetails()
                .Where(rd => rd.Revenue != null && rd.Revenue.StartDate.Year == year && rd.Revenue.StartDate.Month == month);
            int daysInMonth = DateTime.DaysInMonth(year, month);

            var dailyRevenue = revenueDetails
                .GroupBy(rd => rd.Revenue.StartDate.Day)
                .Select(g => new { Day = g.Key, Total = g.Sum(rd => rd.RevenueAmount) })
                .OrderBy(g => g.Day)
                .ToList();

            var result = new List<(int Day, decimal Total)>();
            for (int i = 1; i <= daysInMonth; i++)
            {
                var dayData = dailyRevenue.FirstOrDefault(dr => dr.Day == i);
                result.Add((i, dayData?.Total ?? 0));
            }

            return result;
        }

        // Lấy dữ liệu doanh thu hàng tháng trong năm
        public List<(int Month, decimal Total)> GetMonthlyRevenueInYear(int year)
        {
            var revenueDetails = _revenueDAL.GetAllRevenueDetails()
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
            var revenueDetails = _revenueDAL.GetAllRevenueDetails()
                .Where(rd => !string.IsNullOrEmpty(rd.ItemName));

            var allProducts = revenueDetails
                .GroupBy(rd => rd.ItemName)
                .Select(g => new
                {
                    ItemName = g.Key,
                    TotalQuantity = g.Sum(rd => rd.Quantity)  // can chinh sua 
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

        // Tính tổng doanh thu
        public decimal GetTotalRevenue()
        {
            var revenueDetails = _revenueDAL.GetAllRevenueDetails()
                .Where(rd => rd.Revenue != null);
            return revenueDetails.Sum(rd => rd.RevenueAmount);
        }

        // Tính tổng số lượng sản phẩm đã bán
        public int GetTotalProductsSold()
        {
            var revenueDetails = _revenueDAL.GetAllRevenueDetails();
            return revenueDetails.Select(rd => rd.Quantity).Count();    // Can chinh sua
        }

        // Tính tổng lượng khách (dựa trên OrderID duy nhất)
        public int GetTotalCustomers()
        {
            var revenueDetails = _revenueDAL.GetAllRevenueDetails()
                .Where(rd => !string.IsNullOrEmpty(rd.OrderID));
            return revenueDetails.Select(rd => rd.OrderID).Distinct().Count();
        }
    }
}