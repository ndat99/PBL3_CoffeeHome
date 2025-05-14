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

        public List<Order> GetOrdersByStatus(string status)
        {
            var today = DateTime.Today;
            return _context.Orders
                .Where(o => o.Status == status && DbFunctions.TruncateTime(o.CreatedAt) == today)
                .Include(o => o.OrderItems)
                .ToList();
        }

        public bool UpdateOrderStatus(string orderId, string status)
        {
            try
            {
                var order = _context.Orders.Find(orderId);
                if (order == null) return false;

                order.Status = status;
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
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


    }
}
