using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_CoffeeHome.DTO
{
    [Table("Schedules")]
    public class Schedule
    {
        public Schedule()
        {
            Salaries = new HashSet<Salary>();
        }
        [Key]
        [StringLength(20)]
        public string ScheduleID { get; set; }

        [Required]
        [ForeignKey("User")]
        [StringLength(20)]
        public string UserID { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime EndTime { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Salary> Salaries { get; set; }
    }
}
