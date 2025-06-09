using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3_CoffeeHome.DTO;

namespace PBL3_CoffeeHome.DAL.Repository
{
    public class SalaryDAL
    {
        private readonly CoffeeDbContext _db;
        public SalaryDAL()
        {
            _db = new CoffeeDbContext();
        }

        public List<Salary> GetAllSalary()
        {
            return _db.Salaries.AsNoTracking().ToList();
        }

        public List<string> GetYearBySalary()
        {
            return _db.Salaries.AsNoTracking().Select(s => s.PaymentDate.Year.ToString())
                               .Distinct().OrderByDescending(y => y).ToList();
        }

        public List<Salary> SearchSalary(String thang, String nam, string txtsearch)
        {
            var query = _db.Salaries.AsNoTracking().AsQueryable();
            if (!string.IsNullOrEmpty(thang) && thang != "Tất cả")
            {
                int month = int.Parse(thang);
                query = query.Where(s => s.PaymentDate.Month == month);
            }
            if (!string.IsNullOrEmpty(nam))
            {
                int year = int.Parse(nam);
                query = query.Where(s => s.PaymentDate.Year == year);
            }
            if (!string.IsNullOrEmpty(txtsearch))
            {
                txtsearch = txtsearch.ToLower().Trim();
                query = query.Where(s => s.UserID.ToLower().Contains(txtsearch));
            }
            return query.ToList();
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
