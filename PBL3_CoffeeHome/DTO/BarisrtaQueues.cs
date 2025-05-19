using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3_CoffeeHome.DTO
{
    [Table("BaristaQueues")]
    public class BaristaQueue
    {
        [Key]
        [StringLength(20)]
        public string QueueID { get; set; }

        [Required]
        [ForeignKey("Order")]
        [StringLength(20)]
        public string OrderID { get; set; }

        [ForeignKey("User")]
        [StringLength(20)]
        public string BaristaID { get; set; }

        [Required]
        [StringLength(50)]
        public string Status { get; set; } // "Incomplete", "Complete"

        [Required]
        public DateTime AssignedAt { get; set; }

        public DateTime? CompletedAt { get; set; }

        public virtual Order Order { get; set; }
        public virtual User User { get; set; }
    }
}