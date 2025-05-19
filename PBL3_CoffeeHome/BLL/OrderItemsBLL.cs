using PBL3_CoffeeHome.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_CoffeeHome.BLL
{
    class OrderItemsBLL
    {
        private readonly OrderItemsDAL _orderItemsDAL;
        public OrderItemsBLL()
        {
            _orderItemsDAL = new OrderItemsDAL();
        }
        public void AddOrderItems(string orderId, string name, int quantity, decimal price)
        {
            _orderItemsDAL.AddOrderItems(orderId, name, quantity, price);
        }
    }
}
