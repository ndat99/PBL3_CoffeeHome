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

       // private readonly OrderBLL _orderBLL;

        public BaristaQueueBLL()
        {
            _baristaQueueDAL = new BaristaQueueDAL();

          //  _orderBLL = new OrderBLL();

        }

        public BaristaQueue GetQueuesByQueueID(string queueId)
        {
            return _baristaQueueDAL.GetQueueByQueueID(queueId);
        }

        public void UpdateQueueStatus(string queueId, string status)
        {
            _baristaQueueDAL.UpdateQueueStatus(queueId, status);
        }
    }
}
