using System;
using System.Collections.Generic;
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
        public string GenerateNewDiscountID()
        {
            return _discountDAL.GenerateNewDiscountID();
        }
        // Xem tất cả discounts
        public List<Discount> GetAllDiscounts()
        {
            return _discountDAL.GetAllDiscounts();
        }

        // Thêm discount với xác thực
        public void AddDiscount(Discount discount)
        {
            if (string.IsNullOrEmpty(discount.DiscountID) || discount.Percentage < 0 || discount.Percentage > 1)
            {
                throw new ArgumentException("Thông tin giảm giá không hợp lệ.");
            }
            _discountDAL.AddDiscount(discount);
        }

        // Sửa discount với xác thực
        public void UpdateDiscount(Discount discount)
        {
            if (string.IsNullOrEmpty(discount.DiscountID))
            {
                throw new ArgumentException("Mã giảm giá không hợp lệ.");
            }
            _discountDAL.UpdateDiscount(discount);
        }

        // Xóa discount
        public void DeleteDiscount(string discountId)
        {
            if (string.IsNullOrEmpty(discountId))
            {
                throw new ArgumentException("Mã giảm giá không hợp lệ.");
            }
            _discountDAL.DeleteDiscount(discountId);
        }

        // Lấy discount theo EffectiveDate (giữ nguyên)
        public Discount GetDiscountByEffectiveDate(DateTime effectiveDate)
        {
            return _discountDAL.GetDiscountByEffectiveDate(effectiveDate);
        }
    }
}