using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3_CoffeeHome.DTO;
using PBL3_CoffeeHome.DTO.ViewModel;
namespace PBL3_CoffeeHome.DAL.Repository
{
    public class SalaryDAL
    {
        private readonly CoffeeDbContext _db;
        public SalaryDAL()
        {
            _db = new CoffeeDbContext();
        }

        public List<SalaryDTO> GetAllSalary()
        {
            return _db.Salaries.AsNoTracking().Include(s => s.User)
                .Select(s => new SalaryDTO
                {
                    SalaryID = s.SalaryID,
                    FullName = s.User.FullName,
                    HoursWorked = s.HoursWorked,
                    HourlyRate = s.HourlyRate,
                    TotalSalary = s.TotalSalary,
                    PaymentDate = s.PaymentDate,
                    Status = s.Status
                }).ToList();
        }

        public List<string> GetYearBySalary()
        {
            return _db.Salaries.AsNoTracking().Select(s => s.PaymentDate.Year.ToString())
                               .Distinct().OrderByDescending(y => y).ToList();
        }

        public List<SalaryDTO> SearchSalary(string thang, string nam, string txtsearch)
        {
            var query = _db.Salaries.AsNoTracking().Include(s => s.User).AsQueryable();

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
                query = query.Where(s => s.User.FullName.ToLower().Contains(txtsearch) || s.User.FullName.ToLower().Contains(txtsearch));
            }

            return query.Select(s => new SalaryDTO
            {
                SalaryID = s.SalaryID,
                FullName = s.User.FullName,
                HoursWorked = s.HoursWorked,
                HourlyRate = s.HourlyRate,
                TotalSalary = s.TotalSalary,
                PaymentDate = s.PaymentDate,
                Status = s.Status
            }).ToList();
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
                Status = "Pending"
            };
            _db.Salaries.Add(salary);
            _db.SaveChanges();
        }

        public void UpdateStatusSalary(string salaryId)
        {
            
            var salary = _db.Salaries.Find(salaryId);
            

            if (salary != null)
            {
                salary.Status = "Paid";
                salary.PaymentDate = DateTime.Now; 

                _db.SaveChanges();
            }
        }

        public void DeleteSalary(string ScheduleId)
        {
            Salary salary = _db.Salaries.FirstOrDefault(t => t.ScheduleID == ScheduleId);
            if (salary != null)
            {
                _db.Salaries.Remove(salary);
                _db.SaveChanges();
            }
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
