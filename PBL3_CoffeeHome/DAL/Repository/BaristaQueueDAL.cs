using System;
using System.Collections.Generic;
using System.Linq;
using PBL3_CoffeeHome.DTO;

namespace PBL3_CoffeeHome.DAL.Repository
{
    public class BaristaQueueDAL
    {
        private readonly CoffeeDbContext _context;

        public BaristaQueueDAL()
        {
            _context = new CoffeeDbContext();
        }

        public List<BaristaQueue> GetQueuesByBarista(string baristaId)
        {
            return _context.BaristaQueues
                .Where(q => q.BaristaID == baristaId && q.Status != "Completed")
                .OrderBy(q => q.AssignedAt)
                .ToList();
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

        public bool UpdateQueue(BaristaQueue queue)
        {
            try
            {
                var existingQueue = _context.BaristaQueues.Find(queue.QueueID);
                if (existingQueue == null) return false;

                _context.Entry(existingQueue).CurrentValues.SetValues(queue);
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
            try
            {
                var queue = _context.BaristaQueues.Find(queueId);
                if (queue == null) return false;

                queue.Status = status;
                if (status == "Completed")
                    queue.CompletedAt = DateTime.Now;

                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
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
