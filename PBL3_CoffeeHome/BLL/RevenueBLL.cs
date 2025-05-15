using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3_CoffeeHome.DAL.Repository;
using PBL3_CoffeeHome.DTO;
using PBL3_CoffeeHome.BLL;

namespace PBL3_CoffeeHome.BLL
{
    public class RevenueBLL
    {
        private readonly RevenueDAL _revenueDAL;
        private readonly InventoryTransactionBLL _inventoryTransactionBLL;

        public RevenueBLL()
        {
            _revenueDAL = new RevenueDAL();
            _inventoryTransactionBLL = new InventoryTransactionBLL();

        }
        // Lấy dữ liệu doanh thu hàng ngày trong tháng
        public List<(int Day, decimal Total)> GetDailyRevenueInMonth(int year, int month)
        {
            return _revenueDAL.GetDailyRevenueInMonth(year, month);
        }
        // doanh thu 1 tháng
        public decimal GetTotalRevenueByMonth(int year, int month)
        {
            return _revenueDAL.GetTotalRevenueByMonth(year, month);
        }
        // Lấy dữ liệu doanh thu hàng tháng trong năm
        public List<(int Month, decimal Total)> GetMonthlyRevenueInYear(int year)
        {
            return _revenueDAL.GetMonthlyRevenueInYear(year);
        }
        // doanh thu 1 năm
        public decimal GetTotalRevenueByYear(int year)
        {
            return _revenueDAL.GetTotalRevenueByYear(year);
        }
        // Lấy danh sách sản phẩm bán chạy nhất
        public List<(string ItemName, int TotalQuantity)> GetTopSellingProducts()
        {
            return _revenueDAL.GetTopSellingProducts();
        }
        // Lấy danh sách sản phẩm bán chạy nhất theo năm
        public List<(string ItemName, int TotalQuantity)> GetTopSellingProductsByYear(int year)
        {
            return _revenueDAL.GetTopSellingProductsByYear(year);
        }
        // Tổng số lượng sản phẩm bán chạy nhất trong năm
        public int GetTotalProductsSoldByYear(int year)
        {
            return _revenueDAL.GetTotalProductsSoldByYear(year);
        }

        // Lấy danh sách sản phẩm bán chạy nhất theo tháng
        public List<(string ItemName, int TotalQuantity)> GetTopSellingProductsByMonth(int year, int month)
        {
            return _revenueDAL.GetTopSellingProductsByMonth(year, month);
        }
        // Tổng số lượng sản phẩm bán chạy nhất trong tháng
        public int GetTotalProductsSoldByMonth(int year, int month)
        {
            return _revenueDAL.GetTotalProductsSoldByMonth(year, month);
        }
        // Tính tổng doanh thu
        public decimal GetTotalRevenue()
        {
            var revenueDetails = _revenueDAL.GetAllRevenueDetails()
                .Where(rd => rd.Revenue != null);
            return revenueDetails.Sum(rd => rd.RevenueAmount);
        }

        // Tính tổng số lượng sản phẩm đã bán
        public int GetTotalProductsSold()
        {
            return _revenueDAL.GetTotalProductsSold();
        }
        //Tính tổng số lượng khách hàng
        public int GetTotalCustomers()
        {
            return _revenueDAL.GetTotalCustomers();
        }
        // Tính tổng lượng khách trong tháng
        public int GetTotalCustomersByMonth(int year, int month)
        {
            return _revenueDAL.GetTotalCustomersByMonth(year, month);
        }
        // Tính tổng lượng khách trong năm
        public int GetTotalCustomersByYear(int year)
        {
            return _revenueDAL.GetTotalCustomersByYear(year);
        }
        // Lấy dữ liệu lợi nhuận theo tháng trong năm
        public List<(string ThoiGian, decimal DoanhThu, decimal ChiPhi, decimal LoiNhuan)>
            GetProfitByMonths(int year)
        {
            var monthlyRevenue = GetMonthlyRevenueInYear(year);
            var result = new List<(string, decimal, decimal, decimal)>();


            foreach (var (month, doanhThu) in monthlyRevenue)
            {
                var chiPhi = _inventoryTransactionBLL.TotalTransactionPriceInMonth(year, month);

                result.Add((
                    $"Tháng {month}",
                    doanhThu,
                    chiPhi,
                    doanhThu - chiPhi
                ));
            }

            return result;
        }
        //Tìm năm có doanh thu
        public List<int> GetAllYearsWithData()
        {
            // Lấy tất cả năm có dữ liệu Revenue
            return _revenueDAL.GetAllRevenueDetails()
                .Where(rd => rd.Revenue != null)
                .Select(rd => rd.Revenue.StartDate.Year)
                .Distinct()
                .OrderBy(y => y)
                .ToList();
        }
    }
}