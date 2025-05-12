using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3_CoffeeHome.DTO
{
    [Table("RevenueDetails")]
    public class RevenueDetail
    {
        [Key]
        [StringLength(10)]
        public string DetailID { get; set; }

        [Required]
        [ForeignKey("Revenue")]
        [StringLength(20)]
        public string RevenueID { get; set; }

        [Required]
        [ForeignKey("Order")]
        [StringLength(20)]
        public string OrderID { get; set; }

        [Required]
        [StringLength(100)]
        public string ItemName { get; set; }

        [Required]
        [Range(1, 999)]
        public int Quantity { get; set; }

        [Required]
        public decimal RevenueAmount { get; set; }

        public virtual Revenue Revenue { get; set; }
        public virtual Order Order { get; set; }
    }
}