using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3_CoffeeHome.DTO;

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

        public List<Schedule> GetAllShedule()
        {
            return _db.Schedules.AsNoTracking().ToList();
        }

        public List<Schedule> GetSheduleByType(string type)
        {
            return _db.Schedules.AsNoTracking().Where(s => s.TypeSchedule == type).ToList();
        }
        public List<Schedule> SearchSchedule(string txtSearch, string typeTypeSchedule)
        {
            var query = _db.Schedules.AsNoTracking().AsQueryable();
            if (!string.IsNullOrEmpty(typeTypeSchedule) && typeTypeSchedule != "Tất cả")
            {
                query = query.Where(s => s.TypeSchedule == typeTypeSchedule);
            }


            if (!string.IsNullOrEmpty(txtSearch))
            {
                txtSearch = txtSearch.ToLower().Trim();
                query = query.Where(s => s.UserID.ToLower().Contains(txtSearch) || s.ScheduleID.ToLower().Contains(txtSearch));
            }

            return query.ToList();
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
