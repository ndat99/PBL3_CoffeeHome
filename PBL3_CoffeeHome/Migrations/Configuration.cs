namespace PBL3_CoffeHome.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using PBL3_CoffeeHome.DTO;
    using PBL3_CoffeeHome;

    internal sealed class Configuration : DbMigrationsConfiguration<CoffeeDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CoffeeDbContext context)
        {
            try
            {
                // Lấy mật khẩu từ biến môi trường
                string adminPassword = Environment.GetEnvironmentVariable("ADMIN_PASSWORD");
                string cashierPassword = Environment.GetEnvironmentVariable("CASHIER_PASSWORD");
                string baristaPassword = Environment.GetEnvironmentVariable("BARISTA_PASSWORD");

                // Nếu không có trong biến môi trường, sử dụng mật khẩu mặc định cho development
                if (string.IsNullOrEmpty(adminPassword)) adminPassword = "123456";
                if (string.IsNullOrEmpty(cashierPassword)) cashierPassword = "123456";
                if (string.IsNullOrEmpty(baristaPassword)) baristaPassword = "123456";

                // Seed Users
                context.Users.AddOrUpdate(
                    u => u.UserID,
                    new User
                    {
                        UserID = "USR001",
                        UserName = "admin",
                        FullName = "Nguyễn Văn Admin",
                        Role = "Admin",
                        IsActive = true,
                        Email = "admin@coffeeshop.com",
                        PhoneNumber = "0901234567",
                        PasswordHash = BCrypt.Net.BCrypt.HashPassword(adminPassword)
                    },
                    new User
                    {
                        UserID = "USR002",
                        UserName = "cashier01",
                        FullName = "Trần Thị Thu Ngân",
                        Role = "Cashier",
                        IsActive = true,
                        Email = "cashier01@coffeeshop.com",
                        PhoneNumber = "0912345678",
                        PasswordHash = BCrypt.Net.BCrypt.HashPassword(cashierPassword)
                    },
                    new User
                    {
                        UserID = "USR003",
                        UserName = "cashier02",
                        FullName = "Lê Thị Mai Hương",
                        Role = "Cashier",
                        IsActive = true,
                        Email = "cashier02@coffeeshop.com",
                        PhoneNumber = "0923456789",
                        PasswordHash = BCrypt.Net.BCrypt.HashPassword(cashierPassword)
                    },
                    new User
                    {
                        UserID = "USR004",
                        UserName = "barista01",
                        FullName = "Phạm Văn Long",
                        Role = "Barista",
                        IsActive = true,
                        Email = "barista01@coffeeshop.com",
                        PhoneNumber = "0934567890",
                        PasswordHash = BCrypt.Net.BCrypt.HashPassword(baristaPassword)
                    },
                    new User
                    {
                        UserID = "USR005",
                        UserName = "barista02",
                        FullName = "Hoàng Thị Lan",
                        Role = "Barista",
                        IsActive = true,
                        Email = "barista02@coffeeshop.com",
                        PhoneNumber = "0945678901",
                        PasswordHash = BCrypt.Net.BCrypt.HashPassword(baristaPassword)
                    }
                );

                // Seed Discounts - Chương trình giảm giá theo ngày lễ
                context.Discounts.AddOrUpdate(
                    d => d.DiscountID,
                    new Discount
                    {
                        DiscountID = "DISC001",
                        Name = "Giảm giá Tết Nguyên Đán",
                        Percentage = 0.20m,  // Giảm 20%
                        MinOrderAmount = 0m
                    },
                    new Discount
                    {
                        DiscountID = "DISC002",
                        Name = "Giảm giá Giáng Sinh",
                        Percentage = 0.25m,  // Giảm 25%
                        MinOrderAmount = 0m
                    },
                    new Discount
                    {
                        DiscountID = "DISC003",
                        Name = "Giảm giá Quốc Khánh 2/9",
                        Percentage = 0.15m,  // Giảm 15%
                        MinOrderAmount = 0m
                    },
                    new Discount
                    {
                        DiscountID = "DISC004",
                        Name = "Giảm giá 30/4-1/5",
                        Percentage = 0.10m,  // Giảm 10%
                        MinOrderAmount = 0m
                    },
                    new Discount
                    {
                        DiscountID = "DISC005",
                        Name = "Giảm giá Phụ nữ Việt Nam 20/10",
                        Percentage = 0.10m,  // Giảm 10%
                        MinOrderAmount = 0m
                    },
                    new Discount
                    {
                        DiscountID = "DISC006",
                        Name = "Giảm giá Quốc tế Phụ nữ 8/3",
                        Percentage = 0.15m,  // Giảm 15%
                        MinOrderAmount = 0m
                    }
                );

                // Seed Inventory - Nguyên liệu và vật tư
                context.Inventory.AddOrUpdate(
                    i => i.ItemID,
                    // Cà phê
                    new Inventory { ItemID = "INV001", Name = "Cà phê Robusta", Quantity = 50.0m, MinimumQuantity = 10.0m, Unit = "kg", ExpirationDate = DateTime.Now.AddMonths(6), CostPrice = 180000m, Category = "Cà phê" },
                    new Inventory { ItemID = "INV002", Name = "Cà phê Arabica", Quantity = 30.0m, MinimumQuantity = 5.0m, Unit = "kg", ExpirationDate = DateTime.Now.AddMonths(6), CostPrice = 250000m, Category = "Cà phê" },

                    // Sữa
                    new Inventory { ItemID = "INV003", Name = "Sữa đặc", Quantity = 100.0m, MinimumQuantity = 20.0m, Unit = "hộp", ExpirationDate = DateTime.Now.AddMonths(12), CostPrice = 22000m, Category = "Sữa" },
                    new Inventory { ItemID = "INV004", Name = "Sữa tươi", Quantity = 50.0m, MinimumQuantity = 10.0m, Unit = "lít", ExpirationDate = DateTime.Now.AddDays(7), CostPrice = 35000m, Category = "Sữa" },

                    // Đường
                    new Inventory { ItemID = "INV005", Name = "Đường trắng", Quantity = 50.0m, MinimumQuantity = 10.0m, Unit = "kg", ExpirationDate = DateTime.Now.AddYears(2), CostPrice = 20000m, Category = "Đường" },

                    // Đá
                    new Inventory { ItemID = "INV006", Name = "Đá viên", Quantity = 200.0m, MinimumQuantity = 50.0m, Unit = "kg", ExpirationDate = DateTime.Now.AddDays(1), CostPrice = 3000m, Category = "Đá" },

                    // Vật tư
                    new Inventory { ItemID = "INV007", Name = "Ly nhựa", Quantity = 1000.0m, MinimumQuantity = 200.0m, Unit = "cái", ExpirationDate = DateTime.Now.AddYears(2), CostPrice = 800m, Category = "Vật tư" },
                    new Inventory { ItemID = "INV008", Name = "Ống hút", Quantity = 2000.0m, MinimumQuantity = 500.0m, Unit = "cái", ExpirationDate = DateTime.Now.AddYears(2), CostPrice = 50m, Category = "Vật tư" },
                    new Inventory { ItemID = "INV009", Name = "Túi nilon", Quantity = 1000.0m, MinimumQuantity = 200.0m, Unit = "cái", ExpirationDate = DateTime.Now.AddYears(2), CostPrice = 200m, Category = "Vật tư" }
                );

                // Seed MenuItems - Thực đơn
                context.MenuItems.AddOrUpdate(
                    m => m.MenuItemID,
                    // Cà phê
                    new MenuItems { MenuItemID = "MENU001", Name = "Cà phê đen", Category = "Cà phê", Price = 25000m, IsAvailable = true },
                    new MenuItems { MenuItemID = "MENU002", Name = "Cà phê sữa", Category = "Cà phê", Price = 30000m, IsAvailable = true },
                    new MenuItems { MenuItemID = "MENU003", Name = "Bạc xỉu", Category = "Cà phê", Price = 35000m, IsAvailable = true },

                    // Cà phê đá
                    new MenuItems { MenuItemID = "MENU004", Name = "Cà phê đen đá", Category = "Cà phê đá", Price = 28000m, IsAvailable = true },
                    new MenuItems { MenuItemID = "MENU005", Name = "Cà phê sữa đá", Category = "Cà phê đá", Price = 32000m, IsAvailable = true },
                    new MenuItems { MenuItemID = "MENU006", Name = "Bạc xỉu đá", Category = "Cà phê đá", Price = 38000m, IsAvailable = true }
                );

                // Seed MenuItemIngredients - Công thức
                context.MenuItemIngredients.AddOrUpdate(
                    mi => mi.Id,
                    // Cà phê đen
                    new MenuItemIngredient { Id = "MI001", MenuItemID = "MENU001", ItemID = "INV001", QuantityRequired = 0.018m, Unit = "kg" },
                    new MenuItemIngredient { Id = "MI002", MenuItemID = "MENU001", ItemID = "INV005", QuantityRequired = 0.010m, Unit = "kg" },

                    // Cà phê sữa
                    new MenuItemIngredient { Id = "MI003", MenuItemID = "MENU002", ItemID = "INV001", QuantityRequired = 0.018m, Unit = "kg" },
                    new MenuItemIngredient { Id = "MI004", MenuItemID = "MENU002", ItemID = "INV003", QuantityRequired = 0.030m, Unit = "hộp" },
                    new MenuItemIngredient { Id = "MI005", MenuItemID = "MENU002", ItemID = "INV005", QuantityRequired = 0.005m, Unit = "kg" },

                    // Bạc xỉu
                    new MenuItemIngredient { Id = "MI006", MenuItemID = "MENU003", ItemID = "INV001", QuantityRequired = 0.015m, Unit = "kg" },
                    new MenuItemIngredient { Id = "MI007", MenuItemID = "MENU003", ItemID = "INV003", QuantityRequired = 0.040m, Unit = "hộp" },
                    new MenuItemIngredient { Id = "MI008", MenuItemID = "MENU003", ItemID = "INV004", QuantityRequired = 0.050m, Unit = "lít" },

                    // Cà phê đen đá
                    new MenuItemIngredient { Id = "MI009", MenuItemID = "MENU004", ItemID = "INV001", QuantityRequired = 0.018m, Unit = "kg" },
                    new MenuItemIngredient { Id = "MI010", MenuItemID = "MENU004", ItemID = "INV005", QuantityRequired = 0.010m, Unit = "kg" },
                    new MenuItemIngredient { Id = "MI011", MenuItemID = "MENU004", ItemID = "INV006", QuantityRequired = 0.150m, Unit = "kg" },

                    // Cà phê sữa đá
                    new MenuItemIngredient { Id = "MI012", MenuItemID = "MENU005", ItemID = "INV001", QuantityRequired = 0.018m, Unit = "kg" },
                    new MenuItemIngredient { Id = "MI013", MenuItemID = "MENU005", ItemID = "INV003", QuantityRequired = 0.030m, Unit = "hộp" },
                    new MenuItemIngredient { Id = "MI014", MenuItemID = "MENU005", ItemID = "INV005", QuantityRequired = 0.005m, Unit = "kg" },
                    new MenuItemIngredient { Id = "MI015", MenuItemID = "MENU005", ItemID = "INV006", QuantityRequired = 0.150m, Unit = "kg" },

                    // Bạc xỉu đá
                    new MenuItemIngredient { Id = "MI016", MenuItemID = "MENU006", ItemID = "INV001", QuantityRequired = 0.015m, Unit = "kg" },
                    new MenuItemIngredient { Id = "MI017", MenuItemID = "MENU006", ItemID = "INV003", QuantityRequired = 0.040m, Unit = "hộp" },
                    new MenuItemIngredient { Id = "MI018", MenuItemID = "MENU006", ItemID = "INV004", QuantityRequired = 0.050m, Unit = "lít" },
                    new MenuItemIngredient { Id = "MI019", MenuItemID = "MENU006", ItemID = "INV006", QuantityRequired = 0.150m, Unit = "kg" }
                );

                // Seed sample data
                DateTime currentDate = DateTime.Now;

                // Sample Orders
                context.Orders.AddOrUpdate(
                    o => o.OrderID,
                    new Order
                    {
                        OrderID = "ORD20240401001",
                        CreatedAt = currentDate.AddDays(-7),
                        Status = "Completed",
                        CardNumber = 101,
                        TotalAmount = 62000m,
                        DiscountAmount = 0m,
                        FinalAmount = 62000m,
                        UserID = "USR002"
                    },
                    new Order
                    {
                        OrderID = "ORD20240401002",
                        CreatedAt = currentDate.AddDays(-6),
                        Status = "Completed",
                        CardNumber = 102,
                        TotalAmount = 95000m,
                        DiscountAmount = 14250m, // Giảm 15% (Ngày 2/9)
                        FinalAmount = 80750m,
                        UserID = "USR003",
                        DiscountID = "DISC003"
                    },
                    new Order
                    {
                        OrderID = "ORD20240401003",
                        CreatedAt = currentDate.AddDays(-5),
                        Status = "Completed",
                        CardNumber = 103,
                        TotalAmount = 138000m,
                        DiscountAmount = 0m,
                        FinalAmount = 138000m,
                        UserID = "USR002"
                    },
                    new Order
                    {
                        OrderID = "ORD20240401004",
                        CreatedAt = currentDate.AddHours(-2),
                        Status = "In Progress",
                        CardNumber = 104,
                        TotalAmount = 70000m,
                        DiscountAmount = 0m,
                        FinalAmount = 70000m,
                        UserID = "USR003"
                    }
                );

                // Sample OrderItems
                context.OrderItems.AddOrUpdate(
                    oi => oi.OrderItemID,
                    // Order 1
                    new OrderItem { OrderItemID = "OI001", OrderID = "ORD20240401001", MenuItemID = "MENU002", Quantity = 2, Price = 30000m, Subtotal = 60000m },

                    // Order 2
                    new OrderItem { OrderItemID = "OI002", OrderID = "ORD20240401002", MenuItemID = "MENU003", Quantity = 1, Price = 35000m, Subtotal = 35000m },
                    new OrderItem { OrderItemID = "OI003", OrderID = "ORD20240401002", MenuItemID = "MENU005", Quantity = 2, Price = 32000m, Subtotal = 64000m },

                    // Order 3
                    new OrderItem { OrderItemID = "OI004", OrderID = "ORD20240401003", MenuItemID = "MENU006", Quantity = 3, Price = 38000m, Subtotal = 114000m },
                    new OrderItem { OrderItemID = "OI005", OrderID = "ORD20240401003", MenuItemID = "MENU004", Quantity = 1, Price = 28000m, Subtotal = 28000m },

                    // Order 4
                    new OrderItem { OrderItemID = "OI006", OrderID = "ORD20240401004", MenuItemID = "MENU001", Quantity = 1, Price = 25000m, Subtotal = 25000m },
                    new OrderItem { OrderItemID = "OI007", OrderID = "ORD20240401004", MenuItemID = "MENU003", Quantity = 1, Price = 35000m, Subtotal = 35000m }
                );

                // Sample BaristaQueues
                context.BaristaQueues.AddOrUpdate(
                    bq => bq.QueueID,
                    new BaristaQueue
                    {
                        QueueID = "BQ001",
                        OrderID = "ORD20240401001",
                        BaristaID = "USR004",
                        Status = "Completed",
                        AssignedAt = currentDate.AddDays(-7),
                        CompletedAt = currentDate.AddDays(-7).AddMinutes(5)
                    },
                    new BaristaQueue
                    {
                        QueueID = "BQ002",
                        OrderID = "ORD20240401002",
                        BaristaID = "USR005",
                        Status = "Completed",
                        AssignedAt = currentDate.AddDays(-6),
                        CompletedAt = currentDate.AddDays(-6).AddMinutes(8)
                    },
                    new BaristaQueue
                    {
                        QueueID = "BQ003",
                        OrderID = "ORD20240401003",
                        BaristaID = "USR004",
                        Status = "Completed",
                        AssignedAt = currentDate.AddDays(-5),
                        CompletedAt = currentDate.AddDays(-5).AddMinutes(10)
                    },
                    new BaristaQueue
                    {
                        QueueID = "BQ004",
                        OrderID = "ORD20240401004",
                        BaristaID = "USR005",
                        Status = "In Progress",
                        AssignedAt = currentDate.AddHours(-2)
                    }
                );

                // Sample InventoryTransactions
                context.InventoryTransactions.AddOrUpdate(
                    it => it.TransactionID,
                    // Nhập kho ban đầu
                    new InventoryTransaction
                    {
                        TransactionID = "TR20240401001",
                        ItemID = "INV001",
                        Quantity = 50.0m,
                        Type = "Nhập",
                        TransactionDate = currentDate.AddMonths(-1),
                        UserID = "USR001",
                        Note = "Nhập hàng đầu tháng"
                    },
                    new InventoryTransaction
                    {
                        TransactionID = "TR20240401002",
                        ItemID = "INV003",
                        Quantity = 100.0m,
                        Type = "Nhập",
                        TransactionDate = currentDate.AddMonths(-1),
                        UserID = "USR001",
                        Note = "Nhập hàng đầu tháng"
                    },

                    // Xuất kho tự động cho đơn hàng
                    new InventoryTransaction
                    {
                        TransactionID = "TR20240401003",
                        ItemID = "INV001",
                        Quantity = -0.036m,
                        Type = "Xuất",
                        TransactionDate = currentDate.AddDays(-7),
                        UserID = "USR004",
                        OrderID = "ORD20240401001",
                        Note = "Xuất tự động cho đơn hàng"
                    },
                    new InventoryTransaction
                    {
                        TransactionID = "TR20240401004",
                        ItemID = "INV003",
                        Quantity = -0.060m,
                        Type = "Xuất",
                        TransactionDate = currentDate.AddDays(-7),
                        UserID = "USR004",
                        OrderID = "ORD20240401001",
                        Note = "Xuất tự động cho đơn hàng"
                    },

                    // Điều chỉnh kho
                    new InventoryTransaction
                    {
                        TransactionID = "TR20240401005",
                        ItemID = "INV001",
                        Quantity = -0.002m,
                        Type = "Điều chỉnh",
                        TransactionDate = currentDate.AddDays(-7).AddHours(1),
                        UserID = "USR004",
                        OrderID = "ORD20240401001",
                        Note = "Điều chỉnh: Khách yêu cầu đậm"
                    }
                );

                // Sample Revenues
                context.Revenues.AddOrUpdate(
                    r => r.RevenueID,
                    new Revenue
                    {
                        RevenueID = "REV20240401",
                        StartDate = currentDate.AddDays(-7).Date,
                        EndDate = currentDate.AddDays(-7).Date.AddDays(1).AddSeconds(-1),
                        TotalRevenue = 62000m
                    },
                    new Revenue
                    {
                        RevenueID = "REV20240402",
                        StartDate = currentDate.AddDays(-6).Date,
                        EndDate = currentDate.AddDays(-6).Date.AddDays(1).AddSeconds(-1),
                        TotalRevenue = 80750m
                    },
                    new Revenue
                    {
                        RevenueID = "REV20240403",
                        StartDate = currentDate.AddDays(-5).Date,
                        EndDate = currentDate.AddDays(-5).Date.AddDays(1).AddSeconds(-1),
                        TotalRevenue = 138000m
                    }
                );

                // Sample RevenueDetails
                context.RevenueDetails.AddOrUpdate(
                    rd => rd.DetailID,
                    // Ngày 1
                    new RevenueDetail
                    {
                        DetailID = "RD001",
                        RevenueID = "REV20240401",
                        OrderID = "ORD20240401001",
                        ItemName = "Cà phê sữa",
                        Quantity = 2,
                        RevenueAmount = 60000m
                    },

                    // Ngày 2
                    new RevenueDetail
                    {
                        DetailID = "RD002",
                        RevenueID = "REV20240402",
                        OrderID = "ORD20240401002",
                        ItemName = "Bạc xỉu",
                        Quantity = 1,
                        RevenueAmount = 35000m
                    },
                    new RevenueDetail
                    {
                        DetailID = "RD003",
                        RevenueID = "REV20240402",
                        OrderID = "ORD20240401002",
                        ItemName = "Cà phê sữa đá",
                        Quantity = 2,
                        RevenueAmount = 64000m
                    },

                    // Ngày 3
                    new RevenueDetail
                    {
                        DetailID = "RD004",
                        RevenueID = "REV20240403",
                        OrderID = "ORD20240401003",
                        ItemName = "Bạc xỉu đá",
                        Quantity = 3,
                        RevenueAmount = 114000m
                    },
                    new RevenueDetail
                    {
                        DetailID = "RD005",
                        RevenueID = "REV20240403",
                        OrderID = "ORD20240401003",
                        ItemName = "Cà phê đen đá",
                        Quantity = 1,
                        RevenueAmount = 28000m
                    }
                );

                context.SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                var errorMessages = new List<string>();
                foreach (var eve in ex.EntityValidationErrors)
                {
                    foreach (var ve in eve.ValidationErrors)
                    {
                        errorMessages.Add($"Property: {ve.PropertyName}, Error: {ve.ErrorMessage}");
                    }
                }

                var fullErrorMessage = string.Join("\n", errorMessages);
                throw new Exception($"Entity Validation Failed:\n{fullErrorMessage}", ex);
            }
            catch (Exception ex)
            {
                throw new Exception($"Database Seed Error: {ex.Message}", ex);
            }
        }
    }
}
