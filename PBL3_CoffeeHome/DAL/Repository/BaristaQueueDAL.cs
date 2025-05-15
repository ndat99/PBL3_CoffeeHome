using System;
using System.Collections;
using System.Collections.Generic;
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

        public bool AddQueue(BaristaQueue queue)
        {
            try
            {
                _context.BaristaQueues.Add(queue);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateQueueStatus(string queueId, string status)
        {
            var queue = _context.BaristaQueues.Find(queueId);
            if (queue == null) return false;

            queue.Status = status;
            if (status == "Completed")
                queue.CompletedAt = DateTime.Now;

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
    }
}
