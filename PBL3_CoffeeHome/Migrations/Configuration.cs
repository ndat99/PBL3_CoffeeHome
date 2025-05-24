namespace PBL3_CoffeeHome.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using PBL3_CoffeeHome.DTO;

    internal sealed class Configuration : DbMigrationsConfiguration<PBL3_CoffeeHome.CoffeeDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }


        protected override void Seed(PBL3_CoffeeHome.CoffeeDbContext context)
        {
            try
            {
                string adminPassword = Environment.GetEnvironmentVariable("ADMIN_PASSWORD") ?? "123";
                string cashierPassword = Environment.GetEnvironmentVariable("CASHIER_PASSWORD") ?? "123";
                string baristaPassword = Environment.GetEnvironmentVariable("BARISTA_PASSWORD") ?? "123";

                // === 1. Seed Users ===
                context.Users.AddOrUpdate(
                    u => u.UserID,
                    new User { UserID = "USR001", UserName = "admin01", FullName = "Tran Duy Thai", Role = "Admin", IsActive = true, Email = "admin01@coffeeshop.com", PhoneNumber = "0901112221", PasswordHash = BCrypt.Net.BCrypt.HashPassword(adminPassword) },
                    new User { UserID = "USR002", UserName = "cashier01", FullName = "Tran Thi Thu Ngân", Role = "Cashier", IsActive = true, Email = "cashier01@coffeeshop.com", PhoneNumber = "0901112222", PasswordHash = BCrypt.Net.BCrypt.HashPassword(cashierPassword) },
                    new User { UserID = "USR003", UserName = "barista01", FullName = "Phan Van Ha", Role = "Barista", IsActive = true, Email = "barista01@coffeeshop建.com", PhoneNumber = "0901112223", PasswordHash = BCrypt.Net.BCrypt.HashPassword(baristaPassword) }
                );
                context.SaveChanges();

                // === 2. Seed Discounts ===
                context.Discounts.AddOrUpdate(
                    d => d.DiscountID,
                    new Discount { DiscountID = "DIS0001", Name = "Giảm giá 30/4", Percentage = 0.15m, MinOrderAmount = 100000m, EffectiveDate = new DateTime(2025, 4, 30) },
                    new Discount { DiscountID = "DIS0002", Name = "Tri Ân Giữa Tháng 5", Percentage = 0.10m, MinOrderAmount = 50000m, EffectiveDate = new DateTime(2025, 5, 13) }
                );
                context.SaveChanges();

                // === 3. Seed Inventory ===
                var invCfRobusta = new Inventory { ItemID = "INV001", Name = "Cà phê Robusta hạt", Quantity = 20.0m, MinimumQuantity = 5.0m, Unit = "kg", ExpirationDate = new DateTime(2025, 11, 1), CostPrice = 180000m, Category = "Cà phê" };
                var invSuaDac = new Inventory { ItemID = "INV002", Name = "Sữa đặc Ông Thọ", Quantity = 50.0m, MinimumQuantity = 10.0m, Unit = "hộp", ExpirationDate = new DateTime(2026, 5, 1), CostPrice = 30000m, Category = "Sữa" };
                var invDuong = new Inventory { ItemID = "INV003", Name = "Đường cát trắng", Quantity = 30.0m, MinimumQuantity = 5.0m, Unit = "kg", ExpirationDate = new DateTime(2027, 5, 1), CostPrice = 22000m, Category = "Đường" };
                var invLyNhua = new Inventory { ItemID = "INV004", Name = "Ly nhựa size M", Quantity = 500.0m, MinimumQuantity = 100.0m, Unit = "cái", ExpirationDate = new DateTime(2027, 1, 1), CostPrice = 700m, Category = "Vật tư" };
                context.Inventory.AddOrUpdate(i => i.ItemID, invCfRobusta, invSuaDac, invDuong, invLyNhua);
                context.SaveChanges();

                // === 4. Seed MenuItems ===
                context.MenuItems.AddOrUpdate(m => m.MenuItemID,
                    new MenuItems { MenuItemID = "MENU001", Name = "Cà phê đen đá", Category = "Cà phê", Price = 25000m, IsAvailable = true },
                    new MenuItems { MenuItemID = "MENU002", Name = "Cà phê sữa đá", Category = "Cà phê", Price = 27000m, IsAvailable = true },
                    new MenuItems { MenuItemID = "MENU003", Name = "Bạc xỉu", Category = "Cà phê", Price = 27000m, IsAvailable = true }
                );
                context.SaveChanges();

                // === 5. Seed MenuItemIngredients ===
                context.MenuItemIngredients.AddOrUpdate(mi => mi.Id,
                    new MenuItemIngredient { Id = "MI0001", MenuItemID = "MENU001", ItemID = "INV001", QuantityRequired = 0.020m, Unit = "kg" },
                    new MenuItemIngredient { Id = "MI0002", MenuItemID = "MENU001", ItemID = "INV003", QuantityRequired = 0.010m, Unit = "kg" },
                    new MenuItemIngredient { Id = "MI0003", MenuItemID = "MENU002", ItemID = "INV001", QuantityRequired = 0.020m, Unit = "kg" },
                    new MenuItemIngredient { Id = "MI0004", MenuItemID = "MENU002", ItemID = "INV002", QuantityRequired = 0.08m, Unit = "hộp" },
                    new MenuItemIngredient { Id = "MI0005", MenuItemID = "MENU002", ItemID = "INV003", QuantityRequired = 0.005m, Unit = "kg" },
                    new MenuItemIngredient { Id = "MI0006", MenuItemID = "MENU003", ItemID = "INV001", QuantityRequired = 0.015m, Unit = "kg" },
                    new MenuItemIngredient { Id = "MI0007", MenuItemID = "MENU003", ItemID = "INV002", QuantityRequired = 0.10m, Unit = "hộp" }
                );
                context.SaveChanges();

                // === 6. Seed Orders & OrderItems ===
                context.Orders.AddOrUpdate(o => o.OrderID,
                    new Order { OrderID = "OR20250512093000", CreatedAt = new DateTime(2025, 5, 12, 9, 30, 0), CardNumber = 1, TotalAmount = 52000m, DiscountAmount = 0m, FinalAmount = 52000m, UserID = "USR002", DiscountID = null },
                    new Order { OrderID = "OR20250513141500", CreatedAt = new DateTime(2025, 5, 13, 14, 15, 0), CardNumber = 2, TotalAmount = 54000m, DiscountAmount = 5400m, FinalAmount = 48600m, UserID = "USR002", DiscountID = "DIS0002" },
                    new Order { OrderID = "OR20250514100500", CreatedAt = new DateTime(2025, 5, 14, 10, 5, 0), CardNumber = 3, TotalAmount = 27000m, DiscountAmount = 0m, FinalAmount = 27000m, UserID = "USR002", DiscountID = null }
                );

                context.OrderItems.AddOrUpdate(oi => oi.OrderItemID,
                    new OrderItem { OrderItemID = "OI20250512001", OrderID = "OR20250512093000", MenuItemID = "MENU001", Quantity = 1, Price = 25000m, Subtotal = 25000m },
                    new OrderItem { OrderItemID = "OI20250512002", OrderID = "OR20250512093000", MenuItemID = "MENU002", Quantity = 1, Price = 27000m, Subtotal = 27000m },
                    new OrderItem { OrderItemID = "OI20250513001", OrderID = "OR20250513141500", MenuItemID = "MENU003", Quantity = 2, Price = 27000m, Subtotal = 54000m },
                    new OrderItem { OrderItemID = "OI20250514001", OrderID = "OR20250514100500", MenuItemID = "MENU002", Quantity = 1, Price = 27000m, Subtotal = 27000m }
                );
                context.SaveChanges();

                // === 7. Seed BaristaQueues ===
                context.BaristaQueues.AddOrUpdate(bq => bq.QueueID,
                    new BaristaQueue { QueueID = "BQ20250512093000", OrderID = "OR20250512093000", BaristaID = "USR003", Status = "Complete", AssignedAt = new DateTime(2025, 5, 12, 9, 30, 0), CompletedAt = new DateTime(2025, 5, 12, 9, 35, 0) },
                    new BaristaQueue { QueueID = "BQ20250513141500", OrderID = "OR20250513141500", BaristaID = "USR003", Status = "Complete", AssignedAt = new DateTime(2025, 5, 13, 14, 15, 0), CompletedAt = new DateTime(2025, 5, 13, 14, 22, 0) },
                    new BaristaQueue { QueueID = "BQ20250514100500", OrderID = "OR20250514100500", BaristaID = "USR003", Status = "Incomplete", AssignedAt = new DateTime(2025, 5, 14, 10, 5, 0), CompletedAt = null }
                );
                context.SaveChanges();

                // === 8. Seed InventoryTransactions ===
                DateTime dateNhapKho = new DateTime(2025, 5, 1, 8, 0, 0);
                DateTime dateOrder1 = new DateTime(2025, 5, 12, 9, 30, 0);
                DateTime dateOrder2 = new DateTime(2025, 5, 13, 14, 15, 0);
                DateTime dateOrder3 = new DateTime(2025, 5, 14, 10, 5, 0);

                context.InventoryTransactions.AddOrUpdate(it => it.TransactionID,
                    // Nhập kho
                    new InventoryTransaction { TransactionID = "TR20250501080000001", ItemID = invCfRobusta.ItemID, Quantity = 20.0m, TransactionDate = dateNhapKho, Type = "Nhập kho", UserID = "USR001", Note = "Nhập kho đầu tháng", TransactionPrice = invCfRobusta.CostPrice, ExpirationDate = invCfRobusta.ExpirationDate },
                    new InventoryTransaction { TransactionID = "TR20250501080000002", ItemID = invSuaDac.ItemID, Quantity = 50.0m, TransactionDate = dateNhapKho, Type = "Nhập kho", UserID = "USR001", Note = "Nhập kho đầu tháng", TransactionPrice = invSuaDac.CostPrice, ExpirationDate = invSuaDac.ExpirationDate },
                    new InventoryTransaction { TransactionID = "TR20250501080000003", ItemID = invDuong.ItemID, Quantity = 30.0m, TransactionDate = dateNhapKho, Type = "Nhập kho", UserID = "USR001", Note = "Nhập kho đầu tháng", TransactionPrice = invDuong.CostPrice, ExpirationDate = invDuong.ExpirationDate },
                    new InventoryTransaction { TransactionID = "TR20250501080000004", ItemID = invLyNhua.ItemID, Quantity = 500.0m, TransactionDate = dateNhapKho, Type = "Nhập kho", UserID = "USR001", Note = "Nhập kho đầu tháng", TransactionPrice = invLyNhua.CostPrice, ExpirationDate = invLyNhua.ExpirationDate },
                    // Xuất kho cho Order 1 (OR20250512093000)
                    new InventoryTransaction { TransactionID = "TR20250512093000001", ItemID = invCfRobusta.ItemID, Quantity = 0.040m, TransactionDate = dateOrder1, Type = "Xuất kho", UserID = "USR003", OrderID = "OR20250512093000", Note = "Xuất cho Order OR20250512093000", TransactionPrice = invCfRobusta.CostPrice },
                    new InventoryTransaction { TransactionID = "TR20250512093000002", ItemID = invSuaDac.ItemID, Quantity = 0.08m, TransactionDate = dateOrder1, Type = "Xuất kho", UserID = "USR003", OrderID = "OR20250512093000", Note = "Xuất cho Order OR20250512093000", TransactionPrice = invSuaDac.CostPrice },
                    new InventoryTransaction { TransactionID = "TR20250512093000003", ItemID = invDuong.ItemID, Quantity = 0.015m, TransactionDate = dateOrder1, Type = "Xuất kho", UserID = "USR003", OrderID = "OR20250512093000", Note = "Xuất cho Order OR20250512093000", TransactionPrice = invDuong.CostPrice },
                    new InventoryTransaction { TransactionID = "TR20250512093000004", ItemID = invLyNhua.ItemID, Quantity = 2m, TransactionDate = dateOrder1, Type = "Xuất kho", UserID = "USR003", OrderID = "OR20250512093000", Note = "Xuất cho Order OR20250512093000", TransactionPrice = invLyNhua.CostPrice },
                    // Xuất kho cho Order 2 (OR20250513141500)
                    new InventoryTransaction { TransactionID = "TR20250513141500001", ItemID = invCfRobusta.ItemID, Quantity = 0.030m, TransactionDate = dateOrder2, Type = "Xuất kho", UserID = "USR003", OrderID = "OR20250513141500", Note = "Xuất cho Order OR20250513141500", TransactionPrice = invCfRobusta.CostPrice },
                    new InventoryTransaction { TransactionID = "TR20250513141500002", ItemID = invSuaDac.ItemID, Quantity = 0.20m, TransactionDate = dateOrder2, Type = "Xuất kho", UserID = "USR003", OrderID = "OR20250513141500", Note = "Xuất cho Order OR20250513141500", TransactionPrice = invSuaDac.CostPrice },
                    new InventoryTransaction { TransactionID = "TR20250513141500003", ItemID = invLyNhua.ItemID, Quantity = 2m, TransactionDate = dateOrder2, Type = "Xuất kho", UserID = "USR003", OrderID = "OR20250513141500", Note = "Xuất cho Order OR20250513141500", TransactionPrice = invLyNhua.CostPrice },
                    // Xuất kho cho Order 3 (OR20250514100500)
                    new InventoryTransaction { TransactionID = "TR20250514100500001", ItemID = invCfRobusta.ItemID, Quantity = 0.020m, TransactionDate = dateOrder3, Type = "Xuất kho", UserID = "USR003", OrderID = "OR20250514100500", Note = "Xuất cho Order OR20250514100500", TransactionPrice = invCfRobusta.CostPrice },
                    new InventoryTransaction { TransactionID = "TR20250514100500002", ItemID = invSuaDac.ItemID, Quantity = 0.08m, TransactionDate = dateOrder3, Type = "Xuất kho", UserID = "USR003", OrderID = "OR20250514100500", Note = "Xuất cho Order OR20250514100500", TransactionPrice = invSuaDac.CostPrice },
                    new InventoryTransaction { TransactionID = "TR20250514100500003", ItemID = invDuong.ItemID, Quantity = 0.005m, TransactionDate = dateOrder3, Type = "Xuất kho", UserID = "USR003", OrderID = "OR20250514100500", Note = "Xuất cho Order OR20250514100500", TransactionPrice = invDuong.CostPrice },
                    new InventoryTransaction { TransactionID = "TR20250514100500004", ItemID = invLyNhua.ItemID, Quantity = 1m, TransactionDate = dateOrder3, Type = "Xuất kho", UserID = "USR003", OrderID = "OR20250514100500", Note = "Xuất cho Order OR20250514100500", TransactionPrice = invLyNhua.CostPrice }
                );
                context.SaveChanges();

                // === 9. Seed Revenues & RevenueDetails ===
                context.Revenues.AddOrUpdate(r => r.RevenueID,
                    new Revenue { RevenueID = "RVE20250512", RevenueDate = new DateTime(2025, 5, 12), TotalRevenue = 52000m, TotalExpense = 11330m },
                    new Revenue { RevenueID = "RVE20250513", RevenueDate = new DateTime(2025, 5, 13), TotalRevenue = 48600m, TotalExpense = 12800m },
                    new Revenue { RevenueID = "RVE20250514", RevenueDate = new DateTime(2025, 5, 14), TotalRevenue = 27000m, TotalExpense = 6810m }
                );

                context.RevenueDetails.AddOrUpdate(rd => rd.DetailID,
                    new RevenueDetail { DetailID = "RD20250512001", RevenueID = "RVE20250512", OrderID = "OR20250512093000", MenuItemID = "MENU001", Quantity = 1, RevenueAmount = 25000m, RevenueDetailDate = new DateTime(2025, 5, 12, 9, 30, 0) },
                    new RevenueDetail { DetailID = "RD20250512002", RevenueID = "RVE20250512", OrderID = "OR20250512093000", MenuItemID = "MENU002", Quantity = 1, RevenueAmount = 27000m, RevenueDetailDate = new DateTime(2025, 5, 12, 9, 30, 0) },
                    new RevenueDetail { DetailID = "RD20250513001", RevenueID = "RVE20250513", OrderID = "OR20250513141500", MenuItemID = "MENU003", Quantity = 2, RevenueAmount = 54000m, RevenueDetailDate = new DateTime(2025, 5, 13, 14, 15, 0) },
                    new RevenueDetail { DetailID = "RD20250514001", RevenueID = "RVE20250514", OrderID = "OR20250514100500", MenuItemID = "MENU002", Quantity = 1, RevenueAmount = 27000m, RevenueDetailDate = new DateTime(2025, 5, 14, 10, 5, 0) }
                );
                context.SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                var errorMessages = ex.EntityValidationErrors.SelectMany(x => x.ValidationErrors).Select(x => $"Property: {x.PropertyName}, Error: {x.ErrorMessage}");
                var fullErrorMessage = string.Join("; ", errorMessages);
                var exceptionMessage = string.Concat("Entity Validation Failed: ", fullErrorMessage);
                System.Diagnostics.Debug.WriteLine(exceptionMessage);
                throw new System.Data.Entity.Core.EntityException(exceptionMessage, ex);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Database Seed Error: {ex.Message}\nInnerException: {ex.InnerException?.Message}");
                throw new Exception($"Database Seed Error: {ex.Message}\nInnerException: {ex.InnerException?.Message}", ex);
            }
        }
    }
}
