using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3_CoffeeHome.DTO
{
    [Table("Discounts")]
    public class Discount
    {
        public Discount()
        {
            Orders = new HashSet<Order>();
        }

        [Key]
        [StringLength(20)]
        public string DiscountID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [Range(0, 1)]
        public decimal Percentage { get; set; }

        [Required]
        public decimal MinOrderAmount { get; set; }

        public DateTime? EffectiveDate { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}