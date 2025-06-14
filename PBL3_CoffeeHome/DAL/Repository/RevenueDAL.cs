﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3_CoffeeHome.DTO;

namespace PBL3_CoffeeHome.DAL.Repository
{
    public class RevenueDAL
    {
        private readonly CoffeeDbContext _context;

        public RevenueDAL()
        {
            _context = new CoffeeDbContext();
        }
        public void AddRevenue(string revenueID, decimal totalRevenue, decimal totalExpense)
        {
            DateTime today = DateTime.Now.Date;
            var revenue = _context.Revenues.FirstOrDefault(r => r.RevenueID == revenueID);
            if (revenue == null)
            {
                revenue = new Revenue
                {
                    RevenueID = revenueID,
                    TotalRevenue = totalRevenue,
                    TotalExpense = totalExpense,
                    RevenueDate = today
                };
                _context.Revenues.Add(revenue);
            }
            else
            {
                revenue.TotalRevenue += totalRevenue;
                revenue.TotalExpense += totalExpense;
            }
            _context.SaveChanges();
        }
       

        public List<RevenueDetail> GetAllRevenueDetails()
        {
            return _context.RevenueDetails.ToList();
        }
        public decimal GetExpenseByMonth(int year, int month)
        {
            try
            {
                var totalExpense = _context.Revenues
                .Where(r => r.RevenueDate.Year == year && r.RevenueDate.Month == month)
                .Sum(r => r.TotalExpense);

                return totalExpense;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetExpenseByMonth: {ex.Message}");
                return 0;
            }
        }


        public List<(int Day, decimal Total)> GetDailyRevenueInMonth(int year, int month)
        {
            var revenueDetails = GetAllRevenueDetails()
                .Where(rd => rd.Revenue != null &&
                             rd.Revenue.RevenueDate.Year == year &&
                             rd.Revenue.RevenueDate.Month == month);

            var dailyRevenue = revenueDetails
                .GroupBy(rd => rd.Revenue.RevenueDate.Day)
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

        public List<(int Month, decimal Total)> GetMonthlyRevenueInYear(int year)
        {
            var revenueDetails = GetAllRevenueDetails()
                .Where(rd => rd.Revenue != null && rd.Revenue.RevenueDate.Year == year);

            var monthlyRevenue = revenueDetails
                .GroupBy(rd => rd.Revenue.RevenueDate.Month)
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


        public decimal GetTotalRevenueByYear(int year)
        {
            var revenueDetails = GetAllRevenueDetails()
                .Where(rd => rd.Revenue != null && rd.Revenue.RevenueDate.Year == year);
            return revenueDetails.Sum(rd => rd.RevenueAmount);
        }

        public decimal GetTotalRevenueByMonth(int year, int month)
        {
            var revenueDetails = GetAllRevenueDetails()
                .Where(rd => rd.Revenue != null &&
                             rd.Revenue.RevenueDate.Year == year &&
                             rd.Revenue.RevenueDate.Month == month);
            return revenueDetails.Sum(rd => rd.RevenueAmount);
        }

        public decimal GetRevenueByDate(DateTime date)
        {
            DateTime start = date.Date;
            DateTime end = start.AddDays(1);

            return GetAllRevenueDetails()
                .Where(rd => rd.Revenue != null &&
                             rd.Revenue.RevenueDate >= start &&
                             rd.Revenue.RevenueDate < end)
                .Sum(r => (decimal?)r.RevenueAmount) ?? 0m;
        }

        public decimal GetExpenseByDate(DateTime date)
        {
            DateTime start = date.Date;
            DateTime end = start.AddDays(1);

            return _context.Revenues
                .Where(r => r.RevenueDate >= start && r.RevenueDate < end)
                .Sum(r => (decimal?)r.TotalExpense) ?? 0m;
        }

        public int GetTotalProductsSold()
        {
            return GetAllRevenueDetails().Sum(rd => rd.Quantity);
        }

        public int GetTotalProductsSoldByYear(int year)
        {
            return GetAllRevenueDetails()
                .Where(rd => rd.Revenue != null && rd.Revenue.RevenueDate.Year == year)
                .Sum(rd => rd.Quantity);
        }

        public int GetTotalProductsSoldByMonth(int year, int month)
        {
            return GetAllRevenueDetails()
                .Where(rd => rd.Revenue != null &&
                             rd.Revenue.RevenueDate.Year == year &&
                             rd.Revenue.RevenueDate.Month == month)
                .Sum(rd => rd.Quantity);
        }


        public int GetTotalCustomersByYear(int year)
        {
            return GetAllRevenueDetails()
                .Where(rd => !string.IsNullOrEmpty(rd.OrderID) &&
                             rd.Revenue != null &&
                             rd.Revenue.RevenueDate.Year == year)
                .Select(rd => rd.OrderID)
                .Distinct()
                .Count();
        }

        public int GetTotalCustomersByMonth(int year, int month)
        {
            return GetAllRevenueDetails()
                .Where(rd => !string.IsNullOrEmpty(rd.OrderID) &&
                             rd.Revenue != null &&
                             rd.Revenue.RevenueDate.Year == year &&
                             rd.Revenue.RevenueDate.Month == month)
                .Select(rd => rd.OrderID)
                .Distinct()
                .Count();
        }

        public List<(string ItemName, int TotalQuantity)> GetTopSellingProductsByYear(int year)
        {
            var result = _context.RevenueDetails
                .Where(rd => rd.RevenueDetailDate.Year == year)
                .SelectMany(rd => rd.Order.OrderItems)
                .GroupBy(oi => new { oi.MenuItemID, oi.MenuItem.Name })
                .Select(g => new
                {
                    ItemName = g.Key.Name,
                    TotalQuantity = g.Sum(oi => oi.Quantity)
                })
                .OrderByDescending(x => x.TotalQuantity)
                .ToList()
                .Select(x => (x.ItemName, x.TotalQuantity))
                .ToList();

            return result;
        }

        public List<(string ItemName, int TotalQuantity)> GetTopSellingProductsByMonth(int year, int month)
        {
            var result = _context.RevenueDetails
                .Where(rd => rd.RevenueDetailDate.Year == year && rd.RevenueDetailDate.Month == month)
                .SelectMany(rd => rd.Order.OrderItems)
                .GroupBy(oi => new { oi.MenuItemID, oi.MenuItem.Name })
                .Select(g => new
                {
                    ItemName = g.Key.Name,
                    TotalQuantity = g.Sum(oi => oi.Quantity)
                })
                .OrderByDescending(x => x.TotalQuantity)
                .ToList()
                .Select(x => (x.ItemName, x.TotalQuantity))
                .ToList();

            return result;
        }
      
        //TongQuan
        public decimal GetTotalRevenueByDateRange(DateTime fromDate, DateTime toDate)
        {
            return GetAllRevenueDetails()
                .Where(rd => rd.Revenue != null &&
                             rd.Revenue.RevenueDate >= fromDate.Date &&
                             rd.Revenue.RevenueDate <= toDate.Date)
                .Sum(rd => rd.RevenueAmount);
        }

        public int GetTotalProductsSoldByDateRange(DateTime fromDate, DateTime toDate)
        {
            return GetAllRevenueDetails()
                .Where(rd => rd.Revenue != null &&
                             rd.Revenue.RevenueDate >= fromDate.Date &&
                             rd.Revenue.RevenueDate <= toDate.Date)
                .Sum(rd => rd.Quantity);
        }

        public int GetTotalCustomersByDateRange(DateTime fromDate, DateTime toDate)
        {
            return GetAllRevenueDetails()
                .Where(rd => !string.IsNullOrEmpty(rd.OrderID) &&
                             rd.Revenue != null &&
                             rd.Revenue.RevenueDate >= fromDate.Date &&
                             rd.Revenue.RevenueDate <= toDate.Date)
                .Select(rd => rd.OrderID)
                .Distinct()
                .Count();
        }
        public List<(string ItemName, int TotalQuantity)> GetTopSellingProductsByDateRange(DateTime fromDate, DateTime toDate)
        {
            var grouped = GetAllRevenueDetails()
                .Where(rd => rd.Revenue != null &&
                             rd.Revenue.RevenueDate >= fromDate.Date &&
                             rd.Revenue.RevenueDate <= toDate.Date)
                .GroupBy(rd => rd.Order.OrderItems.FirstOrDefault().MenuItem.Name)
                .Select(g => new
                {
                    ItemName = g.Key,
                    TotalQuantity = g.Sum(rd => rd.Quantity)
                })
                .OrderByDescending(x => x.TotalQuantity)
                .ToList();

            var top7 = grouped.Take(7).ToList();

            // Nếu còn sản phẩm khác, gộp lại thành "Khác"
            if (grouped.Count > 7)
            {
                int otherTotal = grouped.Skip(7).Sum(x => x.TotalQuantity);
                top7.Add(new { ItemName = "Khác", TotalQuantity = otherTotal });
            }

            // Chuyển về List<(string, int)>
            return top7.Select(x => (x.ItemName, x.TotalQuantity)).ToList();
        }

        public List<(DateTime Date, decimal Total)> GetDailyRevenueInDateRange(DateTime startDate, DateTime endDate)
        {
            return GetAllRevenueDetails()
                .Where(rd => rd.RevenueDetailDate >= startDate.Date && rd.RevenueDetailDate <= endDate.Date)
                .GroupBy(rd => rd.RevenueDetailDate.Date)
                .Select(g => (Date: g.Key, Total: g.Sum(rd => rd.RevenueAmount)))
                .OrderBy(g => g.Date)
                .ToList();
        }
    }
}