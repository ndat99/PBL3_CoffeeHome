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

        public List<BaristaQueue> GetQueuesByBarista(string baristaId)
        {
            return _baristaQueueDAL.GetQueuesByBarista(baristaId);
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

        public bool UpdateQueueStatus(string queueId, string status)
        {
            using (var context = new CoffeeDbContext())
            {
                var queue = context.BaristaQueues.Find(queueId);
                if (queue == null) return false;

                queue.Status = status;
                if (status == "Completed")
                {
                    queue.CompletedAt = DateTime.Now;
                    // Cập nhật trạng thái đơn hàng
                    var order = context.Orders.Find(queue.OrderID);
                    if (order != null)
                    {
                        order.Status = "Completed";
                    }
                }

                return _baristaQueueDAL.UpdateQueue(queue);
            }
        }

        public bool CancelQueue(string queueId)
        {
            return _baristaQueueDAL.UpdateQueueStatus(queueId, "Cancelled");
        }

        public List<BaristaQueue> GetPendingQueues()
        {
            return _baristaQueueDAL.GetQueuesByStatus("Pending");
        }
    }
}
