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

        //public List<(string ItemName, int TotalQuantity)> GetBestSellingProducts()
        //{
        //    var result = _context.RevenueDetails
        //        .Where(rd => rd.Quantity.HasValue)
        //        .GroupBy(rd => rd.ItemName)
        //        .Select(g => new
        //        {
        //            ItemName = g.Key,
        //            TotalQuantity = g.Sum(rd => rd.Quantity.Value)
        //        })
        //        .OrderByDescending(x => x.TotalQuantity)
        //        .ToList();

        //    return result.Select(r => (r.ItemName, r.TotalQuantity)).ToList();
        //}
    }

}
