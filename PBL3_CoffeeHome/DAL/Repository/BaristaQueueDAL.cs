using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using PBL3_CoffeeHome.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PBL3_CoffeeHome.DAL.Repository
{
    public class BaristaQueueDAL
    {
        private readonly CoffeeDbContext _context;

        public BaristaQueueDAL()
        {
            _context = new CoffeeDbContext();
        }

        public BaristaQueue GetQueueByQueueID(string queueId)
        {
            return _context.BaristaQueues.FirstOrDefault(q => q.QueueID == queueId);
        }
        public List<BaristaQueue> GetQueueAssignedToday(string status)
        {
            var today = DateTime.Today;
            return _context.BaristaQueues
                .Where(bq => bq.Status == status && DbFunctions.TruncateTime(bq.AssignedAt) == today.Date)
                .ToList();
        }
        public List<BaristaQueue> GetQueueCompletedOnDate(string status, DateTime selectedDate)
        {
            return _context.BaristaQueues
                .Where(bq => bq.Status == status && DbFunctions.TruncateTime(bq.CompletedAt) == selectedDate.Date)
                .ToList();
        }
        public void AddBaristaQueue(string orderId, DateTime createdAt)
        {
            var queue = new BaristaQueue
            {
                QueueID = GenerateQueueID(),
                OrderID = orderId,
                Status = "Incomplete",
                AssignedAt = createdAt
            };

            _context.BaristaQueues.Add(queue);
            _context.SaveChanges();
        }
        public bool UpdateQueueStatus(string queueId, string baristaId, string status)
        {
            var queue = _context.BaristaQueues.Find(queueId);
            if (queue == null) return false;

            queue.Status = status;
            if (status == "Complete")
            {
                queue.CompletedAt = DateTime.Now;
                queue.BaristaID = baristaId;
            }

            _context.SaveChanges();
            return true;
        }

        public List<BaristaQueue> GetQueuesByStatus(string status)
        {
            return _context.BaristaQueues
                .Where(q => q.Status == status)
                .OrderBy(q => q.AssignedAt)
                .ToList();
        }
        private string GenerateQueueID()
        {
            string newId = "BQ" + DateTime.Now.ToString("yyyyMMddHHmmss");
            if (_context.OrderItems.AsNoTracking().Any(oi => oi.OrderItemID == newId))
            {
                newId = "BQ" + DateTime.Now.ToString("yyyyMMddHHmmssfff");
            }
            return newId;
        }
    }
}
