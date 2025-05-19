using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3_CoffeeHome.DTO;

namespace PBL3_CoffeeHome.DAL.Repository
{
    public class DiscountDAL
    {
        private readonly CoffeeDbContext _db;
        public DiscountDAL()
        {
            _db = new CoffeeDbContext();
        }

        public Discount GetDiscountByEffectiveDate(DateTime effectiveDate)
        {// lấy ngày, tháng
            return _db.Discounts.AsNoTracking()
     .FirstOrDefault(d => d.EffectiveDate.HasValue &&
         d.EffectiveDate.Value.Month == effectiveDate.Month &&
         d.EffectiveDate.Value.Day == effectiveDate.Day);
        }
    }
}
