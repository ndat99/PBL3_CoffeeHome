using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_CoffeeHome.DAL.Repository
{
    public class OrderItemsDAL
    {
        private readonly CoffeeDbContext _context;
        public OrderItemsDAL()
        {
            _context = new CoffeeDbContext();
        }
        private string GenerateOrderItemsID()
        {
            string prefix = "OI";
            string newId;
            int attempt = 0;
            do
            {
                attempt++;
                newId = prefix + attempt.ToString("D3");
            } while (_context.OrderItems.AsNoTracking().Any(oi => oi.OrderItemID == newId) && attempt < 999);

            if (attempt >= 999) throw new Exception("Không thể tạo mã đơn.");

            return newId;
        }
    }
}