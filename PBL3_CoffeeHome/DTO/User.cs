using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3_CoffeeHome.DTO
{
    [Table("Users")]
    public class User
    {
        public User()
        {
            Orders = new HashSet<Order>();
            BaristaQueues = new HashSet<BaristaQueue>();
            InventoryTransactions = new HashSet<InventoryTransaction>();
        }

        [Key]
        [StringLength(20)]
        public string UserID { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        [Required]
        [StringLength(100)]
        public string FullName { get; set; }

        [Required]
        [StringLength(20)]
        public string Role { get; set; } // Admin, Cashier, Barista

        public bool IsActive { get; set; }

        public DateTime? LastLoginAt { get; set; }

        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(20)]
        public string PhoneNumber { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<BaristaQueue> BaristaQueues { get; set; }
        public virtual ICollection<InventoryTransaction> InventoryTransactions { get; set; }
    }
}