using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using PBL3_CoffeeHome.DTO;

namespace PBL3_CoffeeHome.DAL.Repository
{
    public class OrderDAL
    {
        private readonly CoffeeDbContext _context;

        public OrderDAL()
        {
            _context = new CoffeeDbContext();
        }

        // Giữ nguyên các phương thức hiện có
        public void AddOrder(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        public void AddOrderItems(List<OrderItem> items)
        {
            _context.OrderItems.AddRange(items);
            _context.SaveChanges();
        }

        // Các phương thức bổ sung
        public Order GetOrderById(string orderId)
        {
            return _context.Orders
                .Include(o => o.OrderItems)
                .Include(o => o.User)
                .Include(o => o.Discount)
                .FirstOrDefault(o => o.OrderID == orderId);
        }
        public List<Order> GetOrdersByBaristaQueueStatus(string status)
        {
            return _context.Orders
                .Where(o => o.BaristaQueues.Any(bq => bq.Status == status))
                .Include(o => o.OrderItems)
                .ToList();
        }
        public List<Order>  GetOrdersAssignedToday(string status)
        {
            var today = DateTime.Today;
            return _context.Orders
                .Where(o => o.BaristaQueues.Any(bq => bq.Status == status) &&
                    DbFunctions.TruncateTime(o.CreatedAt) == today)
                .ToList();
        }
        public List<Order> GetOrdersCompletedOnDate(string status, DateTime selectedDate)
        {
            return _context.Orders
                .Where(o => o.BaristaQueues.Any(bq => bq.Status == status && DbFunctions.TruncateTime(bq.CompletedAt) == DbFunctions.TruncateTime(selectedDate)))
                .ToList();
        }
        public bool UpdateOrder(Order order)
        {
            try
            {
                var existingOrder = _context.Orders.Find(order.OrderID);
                if (existingOrder == null) return false;

                _context.Entry(existingOrder).CurrentValues.SetValues(order);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Order> GetOrdersByDateRange(DateTime startDate, DateTime endDate)
        {
            return _context.Orders
                .Where(o => o.CreatedAt >= startDate && o.CreatedAt <= endDate)
                .Include(o => o.OrderItems)
                .ToList();
        }
        // Lấy tất cả đơn hàng
        public List<Order> GetAllOrders()
        {
            try
            {
                return _context.Orders
                    .Include("OrderItems")
                    .Include("OrderItems.MenuItem")
                    .Include("User")
                    .Include("Discount")
                    .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách đơn hàng: " + ex.Message, ex);
            }
        }

        // Lấy chi tiết các món trong đơn hàng
        public List<OrderItem> GetOrderItemsByOrderId(string orderId)
        {
            return _context.OrderItems
                .Where(oi => oi.OrderID == orderId)
                .ToList();
        }
        private string GenerateOrderID()
        {
            string prefix = "ORD" + DateTime.Now.ToString("yyyyMMdd");
            string newId;
            int attempt = 0;
            do
            {
                attempt++;
                newId = prefix + attempt.ToString("D3");
            } while (_context.Orders.AsNoTracking().Any(o => o.OrderID == newId) && attempt < 999);

            if (attempt >= 999) throw new Exception("Không thể tạo mã đơn.");

            return newId;
        }
    }
}
