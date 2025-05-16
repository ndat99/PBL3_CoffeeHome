using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_CoffeeHome.DTO.ViewModel
{
    // hiển thị item trong kho
    public class InventoryDisplayDTO
    {
        public string ItemID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Quantity { get; set; }
        public decimal MinimumQuantity { get; set; }
        public string Unit { get; set; }
        public DateTime ExpirationDate { get; set; }
        public decimal CostPrice { get; set; }

        // Thuộc tính mở rộng
        public bool IsLowStock => Quantity <= MinimumQuantity;
        public int DaysUntilExpiration => (ExpirationDate - DateTime.Now).Days;
        public string Status
        {
            get
            {
                if (Quantity == 0)
                    return "Hết hàng";
                if (Quantity <= MinimumQuantity)
                    return "Sắp hết";
                if (DaysUntilExpiration >= 0 && DaysUntilExpiration <= 7)
                    return "Sắp hết hạn";
                if (DaysUntilExpiration < 0)
                    return "Đã hêt hạn";
                return "Còn hàng";
            }
        }
    }

    //nhập kho
    public class ImportInventoryDTO
    {
        public string ItemID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Quantity { get; set; }
        public string Unit { get; set; }
        public decimal Price { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string UserID { get; set; }
        public string Note { get; set; }
    }

    //giao dịch kho
    public class TransactionDisplayDTO
    {
        public string ItemID { get; set; }
        public string ItemName { get; set; }
        public string Category { get; set; }
        public decimal Quantity { get; set; }
        public string Unit { get; set; }
        public string Type { get; set; }
        public string UserName { get; set; }
        public DateTime TransactionDate { get; set; }
    }

    public class TransactionInformationDTO
    {
        public string TransactionID { get; set; }
        public string ItemName { get; set; }
        public string Category { get; set; }
        public decimal Quantity { get; set; }
        public string Unit { get; set; }
        public decimal TransactionPrice { get; set; }
        public string FullName { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Note { get; set; }
    }

    //ds Xuuat kho nhom theo ten
    public class TransactionStockOut
    {
        public string Name { get; set; }
        public decimal Quantity { get; set; }
        public string Unit { get; set; }
        public DateTime? TransactionDate { get; set; }
    }

    public class TransactionStockIn
    {
        public string Name { get; set; }
        public decimal Quantity { get; set; }
        public string Unit { get; set; }
        public DateTime? TransactionDate { get; set; }
        public decimal TransactionPrice { get; set; }
    }


    //kiểm kê kho
    public class InventoryCheckDTO
    {
        public string ItemID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal SystemQuantity { get; set; }
        public decimal ActualQuantity { get; set; }
        public string Unit { get; set; }
        public string UserID { get; set; }
        public string Note { get; set; }

        // Thuộc tính mở rộng
        public decimal Difference => ActualQuantity - SystemQuantity;
        public string Status
        {
            get
            {
                if (Difference > 0)
                    return "Thừa";
                if (Difference < 0)
                    return "Thiếu";
                return "Khớp";
            }
        }
    }
}
