using System;
using System.Collections.Generic;
using System.Linq;
using PBL3_CoffeeHome.DAL;
using PBL3_CoffeeHome.DAL.Repository;
using PBL3_CoffeeHome.DTO;

namespace PBL3_CoffeeHome.BLL
{
    public class RevenueDetailsBLL
    {
        private readonly RevenueDetailsDAL _revenueDetailsDAL;
        public RevenueDetailsBLL()
        {
            _revenueDetailsDAL = new RevenueDetailsDAL();
        }

        public void AddRevenueDetails(OrderItem orderItem, string revenueID, string itemId, decimal totalRevenue)
        {
            _revenueDetailsDAL.AddRevenueDetails(orderItem, revenueID, itemId, totalRevenue);
        }
    }
}
