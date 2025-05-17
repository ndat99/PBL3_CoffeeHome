using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3_CoffeeHome.DTO
{
    [Table("MenuItems")]
    public class MenuItems
    {
        public MenuItems()
        {
            MenuItemIngredients = new HashSet<MenuItemIngredient>();
            OrderItems = new HashSet<OrderItem>();
        }

        [Key]
        [StringLength(20)]
        public string MenuItemID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Category { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public bool IsAvailable { get; set; }

        public virtual ICollection<MenuItemIngredient> MenuItemIngredients { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}