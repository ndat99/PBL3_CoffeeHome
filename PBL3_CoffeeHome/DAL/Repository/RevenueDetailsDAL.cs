using PBL3_CoffeeHome.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_CoffeeHome.DAL.Repository
{
    class RevenueDetailsDAL
    {
        private readonly CoffeeDbContext _db;
        private readonly RevenueDAL _revenueDAL;
        public RevenueDetailsDAL()
        {
            _revenueDAL = new RevenueDAL();
            _db = new CoffeeDbContext();
        }
        public string GenerateRevenueDetailId()
        {
            string prefix = "RD" + DateTime.Now.ToString("yyyyMMdd");
            string newId;
            int attempt = 0;
            do
            {
                attempt++;
                newId = prefix + attempt.ToString("D3");
            } while (_db.RevenueDetails.AsNoTracking().Any(t => t.DetailID == newId) && attempt < 999);

            if (attempt >= 999) throw new Exception("Không thể tạo mã doanh thu chi tiết");

            return newId;
        }
        public void AddRevenueDetails(OrderItem orderItem, string revenueId, string itemId, decimal totalRevenue)
        {
            using (var context = new CoffeeDbContext())
            {
                var revenueDetail = new RevenueDetail
                {
                    DetailID = GenerateRevenueDetailId(),
                    RevenueID = revenueId,
                    OrderID = orderItem.OrderID,
                    MenuItemID = orderItem.MenuItemID,
                    Quantity = orderItem.Quantity,
                    RevenueAmount = orderItem.Subtotal,
                    RevenueDetailDate = DateTime.Now
                };

                context.RevenueDetails.Add(revenueDetail);

                context.SaveChanges();
            }
        }
    }
}
