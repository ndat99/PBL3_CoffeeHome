using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3_CoffeeHome.DTO
{
    [Table("InventoryTransactions")]
    public class InventoryTransaction
    {
        [Key]
        [StringLength(20)]
        public string TransactionID { get; set; }

        [Required]
        [ForeignKey("Inventory")]
        [StringLength(20)]
        public string ItemID { get; set; }

        [Required]
        public decimal Quantity { get; set; }
        [Required]
        public DateTime TransactionDate { get; set; }

        [Required]
        [StringLength(50)]
        public string Type { get; set; } // "Nhập kho", "Xuất kho", "Điều chỉnh"

        public DateTime? ExpirationDate { get; set; }
        [Required]
        public decimal TransactionPrice { get; set; }

        [Required]
        [ForeignKey("User")]
        [StringLength(20)]
        public string UserID { get; set; }

        [StringLength(20)]
        public string OrderID { get; set; } 

        [StringLength(500)]
        public string Note { get; set; }

        public virtual Inventory Inventory { get; set; }
        public virtual User User { get; set; }
    }
}