using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3_CoffeeHome.DTO
{
    [Table("Revenues")]
    public class Revenue
    {
        public Revenue()
        {
            RevenueDetails = new HashSet<RevenueDetail>();
        }

        [Key]
        [StringLength(20)]
        public string RevenueID { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public decimal TotalRevenue { get; set; }

        public virtual ICollection<RevenueDetail> RevenueDetails { get; set; }
    }
}