using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3_CoffeeHome.DTO
{
    [Table("Inventory")]
    public class Inventory
    {
        public Inventory()
        {
            MenuItemIngredients = new HashSet<MenuItemIngredient>();
            InventoryTransactions = new HashSet<InventoryTransaction>();
        }

        [Key]
        [StringLength(20)]
        public string ItemID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        public decimal Quantity { get; set; }

        [Required]
        public decimal MinimumQuantity { get; set; }

        [Required]
        [StringLength(50)]
        public string Unit { get; set; }

        [Required]
        public DateTime ExpirationDate { get; set; }

        [Required]
        public decimal CostPrice { get; set; }

        [Required]
        [StringLength(50)]
        public string Category { get; set; }

        public virtual ICollection<MenuItemIngredient> MenuItemIngredients { get; set; }
        public virtual ICollection<InventoryTransaction> InventoryTransactions { get; set; }
    }
}