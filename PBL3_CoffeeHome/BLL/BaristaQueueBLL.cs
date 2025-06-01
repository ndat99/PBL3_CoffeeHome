using System;
using System.Collections.Generic;
using System.Linq;
using PBL3_CoffeeHome.DAL.Repository;
using PBL3_CoffeeHome.DTO;

namespace PBL3_CoffeeHome.BLL
{
    public class BaristaQueueBLL
    {
        private readonly BaristaQueueDAL _baristaQueueDAL;
        public BaristaQueueBLL()
        {
            _baristaQueueDAL = new BaristaQueueDAL();
        }
        public List<BaristaQueue> GetQueueAssignedToday(string status)
        {
            return _baristaQueueDAL.GetQueueAssignedToday(status);
        }
        public List<BaristaQueue> GetQueueCompletedOnDate(string status, DateTime selectedDate)
        {
            return _baristaQueueDAL.GetQueueCompletedOnDate(status, selectedDate);
        }

        public void UpdateQueueStatus(string queueId, string baristaId, string status)
        {
            _baristaQueueDAL.UpdateQueueStatus(queueId, baristaId, status);
        }
    }
}
