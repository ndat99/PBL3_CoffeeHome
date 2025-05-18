using PBL3_CoffeeHome.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_CoffeeHome.DAL.Repository
{
    public class OrderItemsDAL
    {
        private readonly CoffeeDbContext _context;
        private readonly MenuItemDAL _menuItemDAL;
        public OrderItemsDAL()
        {
            _context = new CoffeeDbContext();
            _menuItemDAL = new MenuItemDAL();
        }

        public List<OrderItem> GetOrderItemsByOrderID(string orderId)
        {
            return _context.OrderItems.Include(oi => oi.MenuItem).Include(oi => oi.Order)
                                                .Where(oi => oi.OrderID == orderId)
                                                .ToList();
        }

        public void AddOrderItems(string OrderID, string name, int quantity, decimal price)
        {
            var itemMenu = _menuItemDAL.GetMenuItemByName(name);
            var orderItem = _context.OrderItems.FirstOrDefault(oi => oi.OrderID == OrderID && oi.MenuItemID == itemMenu.MenuItemID);
            if (orderItem == null)
            {
                orderItem = new OrderItem
                {
                    OrderItemID = GenerateOrderItemsID(),
                    OrderID = OrderID,
                    MenuItemID = itemMenu.MenuItemID,
                    Quantity = quantity,
                    Price = price,
                    Subtotal = price * quantity
                };
                _context.OrderItems.Add(orderItem);
            }
            else
            {
                orderItem.Quantity += quantity;
                orderItem.Subtotal += orderItem.Price;
            }
            _context.SaveChanges();
        }

        private string GenerateOrderItemsID()
        {
            string prefix = "OI";
            string newId;
            int attempt = 0;
            do
            {
                attempt++;
                newId = prefix + attempt.ToString("D3");
            } while (_context.OrderItems.AsNoTracking().Any(oi => oi.OrderItemID == newId) && attempt < 999);

            if (attempt >= 999) throw new Exception("Không thể tạo mã đơn.");

            return newId;
        }
    }
}