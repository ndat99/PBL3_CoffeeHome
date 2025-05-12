using System;
using System.Data.Entity;
using System.Linq;
using PBL3_CoffeeHome.DTO;

namespace PBL3_CoffeeHome
{
    public class CoffeeDbContext : DbContext
    {
        public CoffeeDbContext() : base("name=CoffeeDbContext")
        {

        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Discount> Discounts { get; set; }
        public virtual DbSet<Inventory> Inventory { get; set; }
        public virtual DbSet<InventoryTransaction> InventoryTransactions { get; set; }
        public virtual DbSet<MenuItems> MenuItems { get; set; }
        public virtual DbSet<MenuItemIngredient> MenuItemIngredients { get; set; }
        public virtual DbSet<OrderItem> OrderItems { get; set; }
        public virtual DbSet<Revenue> Revenues { get; set; }
        public virtual DbSet<RevenueDetail> RevenueDetails { get; set; }
        public virtual DbSet<BaristaQueue> BaristaQueues { get; set; }

        public override int SaveChanges()
        {
            try
            {
                return base.SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                var errorMessages = ex.EntityValidationErrors
                    .SelectMany(x => x.ValidationErrors)
                    .Select(x => $"{x.PropertyName}: {x.ErrorMessage}");

                var fullErrorMessage = string.Join("; ", errorMessages);
                var exceptionMessage = string.Concat(ex.Message, " The validation errors are: ", fullErrorMessage);

                throw new System.Data.Entity.Validation.DbEntityValidationException(exceptionMessage, ex.EntityValidationErrors);
            }
        }
    }
}