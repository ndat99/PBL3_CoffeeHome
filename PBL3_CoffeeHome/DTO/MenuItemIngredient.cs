using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3_CoffeeHome.DTO
{
    [Table("MenuItemIngredients")]
    public class MenuItemIngredient
    {
        [Key]
        [StringLength(20)]
        public string Id { get; set; }

        [Required]
        [ForeignKey("MenuItem")]
        [StringLength(20)]
        public string MenuItemID { get; set; }

        [Required]
        [ForeignKey("Inventory")]
        [StringLength(20)]
        public string ItemID { get; set; }

        [Required]
        public decimal QuantityRequired { get; set; }

        [Required]
        [StringLength(50)]
        public string Unit { get; set; }

        public virtual MenuItems MenuItem { get; set; }
        public virtual Inventory Inventory { get; set; }
    }
}