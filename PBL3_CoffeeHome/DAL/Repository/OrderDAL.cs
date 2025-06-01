using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using PBL3_CoffeeHome.DTO;
using Microsoft.VisualBasic.ApplicationServices;

namespace PBL3_CoffeeHome.DAL.Repository
{
    public class OrderDAL
    {
        private readonly CoffeeDbContext _context;
        private readonly OrderItemsDAL _orderItemsDAL;
        private readonly BaristaQueueDAL _baristaQueueDAL;

        public OrderDAL()
        {
            _orderItemsDAL = new OrderItemsDAL();
            _baristaQueueDAL = new BaristaQueueDAL();
            _context = new CoffeeDbContext();
        }

        public void AddOrder(string OrderID, DateTime createdAt, int cardNumber, decimal totalAmount, decimal discountAmount, decimal finalAmount, string userId, string discountId)
        {
            List<OrderItem> orderItems = _orderItemsDAL.GetOrderItemsByOrderID(OrderID);
            foreach (OrderItem item in orderItems)
            {
                totalAmount += item.Subtotal;
            }

            var order = new Order
            {
                OrderID = OrderID,
                CreatedAt = createdAt,
                CardNumber = cardNumber,
                TotalAmount = totalAmount,
                DiscountAmount = discountAmount,
                FinalAmount = totalAmount - discountAmount,
                UserID = userId,
                DiscountID = discountId,
            };
            _context.Orders.Add(order);
            _context.SaveChanges();

            _baristaQueueDAL.AddBaristaQueue(OrderID, createdAt);
        }

        public string GenerateOrderID()
        {
            string newId = "OR" + DateTime.Now.ToString("yyyyMMddHHmmss");
            if (_context.OrderItems.AsNoTracking().Any(oi => oi.OrderItemID == newId))
            {
                newId = "OR" + DateTime.Now.ToString("yyyyMMddHHmmssfff");
            }
            return newId;
        }


        public Order GetOrderById(string orderId)
        {
            return _context.Orders
                .Include(o => o.OrderItems)
                .Include(o => o.User)
                .Include(o => o.Discount)
                .FirstOrDefault(o => o.OrderID == orderId);
        }
        
        // Lấy chi tiết các món trong đơn hàng
        public List<OrderItem> GetOrderItemsByOrderId(string orderId)
        {
            return _context.OrderItems
                .Where(oi => oi.OrderID == orderId)
                .ToList();
        }
        
    }
}
