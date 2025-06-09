using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3_CoffeeHome.DAL.Repository;
using PBL3_CoffeeHome.DTO;
using PBL3_CoffeeHome.BLL;

namespace PBL3_CoffeeHome.BLL
{
    public class RevenueBLL
    {
        private readonly RevenueDAL _revenueDAL;

        public RevenueBLL()
        {
            _revenueDAL = new RevenueDAL();
        }

        public void AddRevenue(string revenueID, decimal totalRevenue, decimal totalExpense)
        {
            _revenueDAL.AddRevenue(revenueID, totalRevenue, totalExpense);
        }
        public List<(int Day, decimal Total)> GetDailyRevenueInMonth(int year, int month)
        {
            return _revenueDAL.GetDailyRevenueInMonth(year, month);
        }
        public decimal GetTotalRevenueByMonth(int year, int month)
        {
            return _revenueDAL.GetTotalRevenueByMonth(year, month);
        }
        public List<(int Month, decimal Total)> GetMonthlyRevenueInYear(int year)
        {
            return _revenueDAL.GetMonthlyRevenueInYear(year);
        }
        public decimal GetTotalRevenueByYear(int year)
        {
            return _revenueDAL.GetTotalRevenueByYear(year);
        }

        public int GetTotalCustomersByMonth(int year, int month)
        {
            return _revenueDAL.GetTotalCustomersByMonth(year, month);
        }
        public int GetTotalCustomersByYear(int year)
        {
            return _revenueDAL.GetTotalCustomersByYear(year);
        }

        public List<(string ThoiGian, decimal DoanhThu, decimal ChiPhi, decimal LoiNhuan)>
            GetProfitByMonths(int year)
        {
            var monthlyRevenue = GetMonthlyRevenueInYear(year);
            var result = new List<(string, decimal, decimal, decimal)>();


            foreach (var (month, doanhThu) in monthlyRevenue)
            {
                var chiPhi = _revenueDAL.GetExpenseByMonth(year, month);

                result.Add((
                    $"Tháng {month}",
                    doanhThu,
                    chiPhi,
                    doanhThu - chiPhi
                ));
            }

            return result;
        }

        // Hàm lấy lợi nhuận theo ngày trong khoảng thời gian
        public List<(String Date, decimal DoanhThu, decimal ChiPhi, decimal LoiNhuan)>
        GetProfitByDateRange(DateTime startDate, DateTime endDate)
        {
            var result = new List<(String Date, decimal DoanhThu, decimal ChiPhi, decimal LoiNhuan)>();

            for (DateTime date = startDate.Date; date <= endDate.Date; date = date.AddDays(1))
            {
                decimal doanhThu = _revenueDAL.GetRevenueByDate(date);

                decimal chiPhi = _revenueDAL.GetExpenseByDate(date);

                decimal loiNhuan = doanhThu - chiPhi;

                string dateString = date.ToString("dd");

                result.Add((dateString, doanhThu, chiPhi, loiNhuan));
            }

            return result;
        }

        // Hàm tính tổng lợi nhuận trong khoảng thời gian
        public (decimal TongDoanhThu, decimal TongChiPhi, decimal TongLoiNhuan)
            GetTotalProfitByDateRange(DateTime startDate, DateTime endDate)
        {
            var dailyProfits = GetProfitByDateRange(startDate, endDate);

            decimal tongDoanhThu = dailyProfits.Sum(p => p.DoanhThu);
            decimal tongChiPhi = dailyProfits.Sum(p => p.ChiPhi);
            decimal tongLoiNhuan = tongDoanhThu - tongChiPhi;

            return (tongDoanhThu, tongChiPhi, tongLoiNhuan);
        }

        public List<int> GetAllYearsWithData()
        {
            return _revenueDAL.GetAllRevenueDetails()
        .Where(rd => rd.Revenue != null)
        .Select(rd => rd.Revenue.RevenueDate.Year)
        .Distinct()
        .OrderBy(y => y)
        .ToList();
        }

        public List<(string ItemName, int TotalQuantity)> GetTopSellingProductsByYear(int year)
        {
            return _revenueDAL.GetTopSellingProductsByYear(year);
        }

        public List<(string ItemName, int TotalQuantity)> GetTopSellingProductsByMonth(int year, int month)
        {
            return _revenueDAL.GetTopSellingProductsByMonth(year, month);
        }

        public int GetTotalProductsSoldByYear(int year)
        {
            return _revenueDAL.GetTotalProductsSoldByYear(year);
        }

        public int GetTotalProductsSoldByMonth(int year, int month)
        {
            return _revenueDAL.GetTotalProductsSoldByMonth(year, month);
        }
    }
}