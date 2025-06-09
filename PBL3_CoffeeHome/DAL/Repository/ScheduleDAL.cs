using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3_CoffeeHome.DTO;
using PBL3_CoffeeHome.DTO.ViewModel;

namespace PBL3_CoffeeHome.DAL.Repository
{
    public class ScheduleDAL
    {
        private readonly CoffeeDbContext _db;
        private readonly SalaryDAL _salaryDAL;
        public ScheduleDAL()
        {
            _db = new CoffeeDbContext();
            _salaryDAL = new SalaryDAL();
        }

        public List<ScheduleDTO> GetAllShedule()
        {
            return _db.Schedules
                .AsNoTracking()
                .Include(s => s.User)
                .Select(s => new ScheduleDTO
                {
                    ScheduleID = s.ScheduleID,
                    FullName = s.User.FullName,
                    TypeSchedule = s.TypeSchedule,
                    Date = s.Date
                })
                .ToList();
        }

        public List<ScheduleDTO> GetSheduleByRole(string role)
        {
            var query = _db.Schedules.AsNoTracking().Include(s => s.User).AsQueryable();
            if (!string.IsNullOrEmpty(role) && role != "Tất cả")
            {
                query = query.Where(s => s.User.Role == role);
            }
            return query.Select(s => new ScheduleDTO
            {
                ScheduleID = s.ScheduleID,
                FullName = s.User.FullName,
                TypeSchedule = s.TypeSchedule,
                Date = s.Date
            }).ToList();
        }

        public List<ScheduleDTO> SearchSchedule(string txtSearch, string typeTypeSchedule)
        {
            var query = _db.Schedules.AsNoTracking().Include(s => s.User).AsQueryable();
            if (!string.IsNullOrEmpty(typeTypeSchedule) && typeTypeSchedule != "Tất cả")
            {
                query = query.Where(s => s.TypeSchedule == typeTypeSchedule);
            }
            if (!string.IsNullOrEmpty(txtSearch))
            {
                txtSearch = txtSearch.ToLower().Trim();
                query = query.Where(s => s.User.FullName.ToLower().Contains(txtSearch) || s.ScheduleID.ToLower().Contains(txtSearch));
            }
            return query.Select(s => new ScheduleDTO
            {
                ScheduleID = s.ScheduleID,
                FullName = s.User.FullName,
                TypeSchedule = s.TypeSchedule,
                Date = s.Date
            }).ToList();
        }

        public void AddSchedule(string userID, string typeSchedule, DateTime date, decimal hourlyRate)
        {
            string scheduleId = GenerateScheduleId();
            var schedule = new Schedule
            {
                ScheduleID = scheduleId,
                UserID = userID,
                TypeSchedule = typeSchedule,
                Date = date
            };

            _db.Schedules.Add(schedule);
            _db.SaveChanges();

            _salaryDAL.AddSalary(scheduleId, userID, 6, hourlyRate);
        }

        public void DeleteShedule(string scheduleId)
        {
            var schedule = _db.Schedules.Find(scheduleId);
            var salaries = _db.Salaries.Where(s => s.ScheduleID == scheduleId);

            if (schedule != null)
            {
                _db.Schedules.Remove(schedule);
                _db.SaveChanges();

                if (salaries != null)
                {
                    _salaryDAL.DeleteSalary(scheduleId);
                }
            }
            else
            {
                throw new Exception("Lịch làm việc không tồn tại");
            }
        }

        public string GenerateScheduleId()
        {
            string prefix = "SCH" + DateTime.Now.ToString("yyyyMMdd");
            string newId;
            int attempt = 0;
            do
            {
                attempt++;
                newId = prefix + attempt.ToString("D3");
            } while (_db.Schedules.AsNoTracking().Any(t => t.ScheduleID == newId) && attempt < 999);
            if (attempt >= 999) throw new Exception("Không thể tạo mã lịch làm việc");
            return newId;
        }

    }
}
