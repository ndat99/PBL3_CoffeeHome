using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3_CoffeeHome.DAL.Repository;
using PBL3_CoffeeHome.DTO;

namespace PBL3_CoffeeHome.BLL
{
    public class ScheduleBLL
    {
        private readonly ScheduleDAL _scheduleDAL;
        public ScheduleBLL()
        {
            _scheduleDAL = new ScheduleDAL();
        }

        public List<Schedule> GetAllSchedule()
        {
            return _scheduleDAL.GetAllShedule();
        }

        public List<Schedule> GetScheduleByType(string type)
        {
            return _scheduleDAL.GetSheduleByType(type);
        }

        public List<Schedule> SearchShedule(string txtsearch,string cbbType)
        {
            return _scheduleDAL.SearchSchedule(txtsearch, cbbType);
        }

        public void AddSchedule(string userId, string typeSchedule, DateTime date, decimal hourlyRate)
        {
            _scheduleDAL.AddSchedule(userId, typeSchedule, date, hourlyRate);
        }

        public void DeleteSchedule(string scheduleId)
        {
            _scheduleDAL.DeleteShedule(scheduleId);
        }   
    }
}
