using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_CoffeeHome.DTO.ViewModel
{
    public class ScheduleDTO
    {
        public string ScheduleID { get; set; }
        public string FullName { get; set; }
        public string TypeSchedule { get; set; }
        public DateTime Date { get; set; }
    }

    public class SalaryDTO
    {
        public string SalaryID { get; set; }
        public string FullName { get; set; }
        public decimal HoursWorked { get; set; }
        public decimal HourlyRate { get; set; }
        public decimal TotalSalary { get; set; }
        public DateTime PaymentDate { get; set; }
        public string Status { get; set; }
    }

}
