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

        public List<decimal> GetPrecentageDiscount()
        {
            return _db.Discounts.AsNoTracking().Select(d => d.Percentage).OrderBy(t => t).ToList();
        }

        public Discount GetDiscountByEffectiveDate(DateTime effectiveDate)
        {
            return _db.Discounts.AsNoTracking().FirstOrDefault(d => d.EffectiveDate == effectiveDate);
        }

        public bool AddDiscount(Discount discount)
        {
            try
            {
                _db.Discounts.Add(discount);
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateDiscount(Discount discount)
        {
            try
            {
                var existingDiscount = _db.Discounts.Find(discount.DiscountID);
                if (existingDiscount == null) return false;

                _db.Entry(existingDiscount).CurrentValues.SetValues(discount);
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteDiscount(string discountID)
        {
            try
            {
                var existingDiscount = _db.Discounts.Find(discountID);
                if (existingDiscount != null)
                {
                    _db.Discounts.Remove(existingDiscount);
                    _db.SaveChanges();
                    return true;
                }

                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
