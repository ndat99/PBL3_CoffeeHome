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

        public BaristaQueue GetQueuesByQueueID(string queueId)
        {
            return _baristaQueueDAL.GetQueueByQueueID(queueId);
        }

        public bool AssignOrderToBarista(string orderId, string baristaId)
        {
            var queue = new BaristaQueue
            {
                QueueID = Guid.NewGuid().ToString().Substring(0, 10),
                OrderID = orderId,
                BaristaID = baristaId,
                Status = "Pending",
                AssignedAt = DateTime.Now
            };

            return _baristaQueueDAL.AddQueue(queue);
        }

        public void UpdateQueueStatus(string queueId, string status)
        {
            _baristaQueueDAL.UpdateQueueStatus(queueId, status);
        }
        public List<BaristaQueue> GetPendingQueues()
        {
            return _baristaQueueDAL.GetQueuesByStatus("Pending");
        }
    }
}
