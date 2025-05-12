using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3_CoffeeHome.DAL.Repository;
using PBL3_CoffeeHome.DTO;

namespace PBL3_CoffeeHome.BLL
{
    public class DiscoutBLL
    {
        private readonly DiscountDAL _discountDAL;
        public DiscoutBLL()
        {
            _discountDAL = new DiscountDAL();
        }

        public List<decimal> GetPrecentageDiscount()
        {
            return _discountDAL.GetPrecentageDiscount();
        }

        public Discount GetDiscountByEffectiveDate(DateTime effectiveDate)
        {
            return _discountDAL.GetDiscountByEffectiveDate(effectiveDate);
        }

        public bool AddDiscount(Discount discount)
        {
            return _discountDAL.AddDiscount(discount);
        }

        public bool UpdateDiscount(Discount discount)
        {
            return _discountDAL.UpdateDiscount(discount);
        }

        public bool DeleteDiscount(string discountID)
        {
            return _discountDAL.DeleteDiscount(discountID);
        }
    }
}
