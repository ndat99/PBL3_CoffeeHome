using PBL3_CoffeeHome.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_CoffeeHome.DAL.Repository
{
    public class MenuItemDAL
    {
        private readonly CoffeeDbContext _context;

        public MenuItemDAL()
        {
            _context = new CoffeeDbContext();
        }
        public List<Order> GetAllOrders()
        {
            return _context.Orders.ToList();
        }
        // Lấy danh sách đơn hàng có trạng thái "Incompleted"
        public List<Order> GetOrdersWithStatus(string status)
        {
            return _context.Orders
                .Where(o => o.BaristaQueues.Any(bq => bq.Status == status))
                .ToList();
        }
        public List<Order> GetOrdersAssignedToday(string status)
        {
            var today = DateTime.Today;
            return _context.Orders
                .Where(o => o.BaristaQueues.Any(bq => bq.Status == status && DbFunctions.TruncateTime(bq.AssignedAt) == today))
                .ToList();
        }
        public List<MenuItems> GetAllMenuItems()
        {
            using (var context = new CoffeeDbContext())
            {

                    var menuItems = context.MenuItems
                        .ToList();
                    Console.WriteLine($"[DAL] Đã lấy thành công {menuItems.Count} món từ cơ sở dữ liệu.");
                    return menuItems;

            }
        }
        public List<Order> GetOrdersCompletedOnDate(string status, DateTime selectedDate)
        {
            return _context.Orders
                .Where(o => o.BaristaQueues.Any(bq => bq.Status == status && DbFunctions.TruncateTime(bq.CompletedAt) == DbFunctions.TruncateTime(selectedDate)))
                .ToList();
        }

        // Lấy chi tiết các món trong đơn hàng
        public List<OrderItem> GetOrderItemsByOrderId(string orderId)
        {
            return _context.OrderItems
                .Where(oi => oi.OrderID == orderId)
                .ToList();
        }
        public Order GetOrderById(string orderId)
        {
            using (var db = new CoffeeDbContext())
            {
                return db.Orders
                    .Include(o => o.BaristaQueues)
                    .FirstOrDefault(o => o.OrderID == orderId);
            }
        }
        public MenuItems GetMenuItemByName(string name)
        {
            using (var db = new CoffeeDbContext())
            {
                return db.MenuItems.FirstOrDefault(m => m.Name == name && m.IsAvailable);
            }
        }

        // Cập nhật trạng thái của đơn hàng trong BaristaQueue
        public void UpdateOrderStatus(string orderId, string newStatus)
        {
            var baristaQueues = _context.BaristaQueues
                .Where(bq => bq.OrderID == orderId)
                .ToList();

            foreach (var queue in baristaQueues)
            {
                queue.Status = newStatus;
                if (newStatus == "Completed")
                {
                    queue.CompletedAt = DateTime.Now;
                }
                else if (newStatus == "Incompleted")
                {
                    queue.CompletedAt = null;
                }
            }
            _context.SaveChanges();
        }
    }
}
