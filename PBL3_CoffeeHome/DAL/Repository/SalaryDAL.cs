using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_CoffeeHome.DAL.Repository
{
    public class SalaryDAL
    {
        private readonly CoffeeDbContext _db;
        public SalaryDAL()
        {
            _db = new CoffeeDbContext();
        }

        public void AddSalary(string scheduleId, string userId, decimal hoursWorked, decimal hourlyRate)
        {
            string salaryId = GenerateSalaryId();
            var salary = new DTO.Salary
            {
                SalaryID = salaryId,
                ScheduleID = scheduleId,
                UserID = userId,
                HoursWorked = hoursWorked,
                HourlyRate = hourlyRate,
                TotalSalary = hoursWorked * hourlyRate,
                PaymentDate = DateTime.Now,  
                //
                Status = "Pending"
            };
            _db.Salaries.Add(salary);
            _db.SaveChanges();
        }

        public string GenerateSalaryId()
        {
            string prefix = "SAL" + DateTime.Now.ToString("yyyyMMdd");
            string newId;
            int attempt = 0;
            do
            {
                attempt++;
                newId = prefix + attempt.ToString("D3");
            } while (_db.Salaries.AsNoTracking().Any(t => t.SalaryID == newId) && attempt < 999);
            if (attempt >= 999) throw new Exception("Không thể tạo mã lương");
            return newId;
        }
    }
}
