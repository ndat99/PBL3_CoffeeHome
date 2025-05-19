using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3_CoffeeHome.DAL.Repository;
using PBL3_CoffeeHome.DTO;

namespace PBL3_CoffeeHome.BLL
{
    public class DiscountBLL
    {
        private readonly DiscountDAL _discountDAL;
        public DiscountBLL()
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

    }
}
