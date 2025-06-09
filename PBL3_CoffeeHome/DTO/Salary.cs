using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_CoffeeHome.DTO
{
    [Table("Salaries")]
    public class Salary
    {
        [Key]
        [StringLength(20)]
        public string SalaryID { get; set; }

        [Required]
        [ForeignKey("Schedule")]
        [StringLength(20)]
        public string ScheduleID { get; set; }

        [Required]
        [ForeignKey("User")]
        [StringLength(20)]
        public string UserID { get; set; }

        [Required]
        public decimal HoursWorked { get; set; }

        [Required]
        public decimal HourlyRate { get; set; }

        [Required]
        public decimal TotalSalary { get; set; }

        [Required]
        public DateTime PaymentDate { get; set; }

        [Required]
        [StringLength(20)]
        public string Status { get; set; } // Pending, Paid

        public virtual Schedule Schedule { get; set; }
        public virtual User User { get; set; }
    }
}
