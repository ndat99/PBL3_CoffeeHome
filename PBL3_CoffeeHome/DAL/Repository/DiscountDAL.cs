using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
        // Phương thức tạo mã mới cho Discount
        public string GenerateNewDiscountID()
        {
            string prefix = "DIS";
            string newId;
            int attempt = 0;
            int maxNumber = 9999;

            do
            {
                attempt++;
                newId = prefix + attempt.ToString("D4");
            }
            while (_db.Discounts.AsNoTracking().Any(d => d.DiscountID == newId) && attempt < maxNumber);

            if (attempt >= maxNumber)
            {
                throw new Exception("Không thể tạo mã giảm giá mới. Đã đạt giới hạn tối đa.");
            }

            return newId;
        }

        // Xem tất cả discounts
        public List<Discount> GetAllDiscounts()
        {
            return _db.Discounts.AsNoTracking().ToList();
        }

        // Thêm discount
        public void AddDiscount(Discount discount)
        {
            _db.Discounts.Add(discount);
            _db.SaveChanges();
        }

        // Sửa discount
        public void UpdateDiscount(Discount discount)
        {
            var existingDiscount = _db.Discounts.Find(discount.DiscountID);
            if (existingDiscount != null)
            {
                _db.Entry(existingDiscount).CurrentValues.SetValues(discount);
                _db.SaveChanges();
            }
        }

        // Xóa discount
        public void DeleteDiscount(string discountId)
        {
            var discount = _db.Discounts.Find(discountId);
            if (discount != null)
            {
                _db.Discounts.Remove(discount);
                _db.SaveChanges();
            }
        }

        // Lấy discount theo EffectiveDate (giữ nguyên phương thức cũ)
        public Discount GetDiscountByEffectiveDate(DateTime effectiveDate)
        {
            return _db.Discounts.AsNoTracking()
                .FirstOrDefault(d => d.EffectiveDate.HasValue &&
                    d.EffectiveDate.Value.Month == effectiveDate.Month &&
                    d.EffectiveDate.Value.Day == effectiveDate.Day);
        }
    }
}