using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3_CoffeeHome.DTO
{
    [Table("OrderItems")]
    public class OrderItem
    {
        [Key]
        [StringLength(20)]
        public string OrderItemID { get; set; }

        [Required]
        [ForeignKey("Order")]
        [StringLength(20)]
        public string OrderID { get; set; }

        [Required]
        [ForeignKey("MenuItem")]
        [StringLength(20)]
        public string MenuItemID { get; set; }

        [Required]
        [Range(1, 999)]
        public int Quantity { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public decimal Subtotal { get; set; }

        public virtual Order Order { get; set; }
        public virtual MenuItems MenuItem { get; set; }
    }
}