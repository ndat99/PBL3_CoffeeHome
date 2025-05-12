namespace PBL3_CoffeHome.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BaristaQueues",
                c => new
                    {
                        QueueID = c.String(nullable: false, maxLength: 10),
                        OrderID = c.String(nullable: false, maxLength: 20),
                        BaristaID = c.String(nullable: false, maxLength: 10),
                        Status = c.String(nullable: false, maxLength: 50),
                        AssignedAt = c.DateTime(nullable: false),
                        CompletedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.QueueID)
                .ForeignKey("dbo.Orders", t => t.OrderID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.BaristaID, cascadeDelete: true)
                .Index(t => t.OrderID)
                .Index(t => t.BaristaID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderID = c.String(nullable: false, maxLength: 20),
                        CreatedAt = c.DateTime(nullable: false),
                        Status = c.String(nullable: false, maxLength: 50),
                        CardNumber = c.Int(nullable: false),
                        TotalAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DiscountAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FinalAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        UserID = c.String(maxLength: 10),
                        DiscountID = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.OrderID)
                .ForeignKey("dbo.Discounts", t => t.DiscountID)
                .ForeignKey("dbo.Users", t => t.UserID)
                .Index(t => t.UserID)
                .Index(t => t.DiscountID);
            
            CreateTable(
                "dbo.Discounts",
                c => new
                    {
                        DiscountID = c.String(nullable: false, maxLength: 10),
                        Name = c.String(nullable: false, maxLength: 100),
                        Percentage = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MinOrderAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        EffectiveDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.DiscountID);
            
            CreateTable(
                "dbo.OrderItems",
                c => new
                    {
                        OrderItemID = c.String(nullable: false, maxLength: 10),
                        OrderID = c.String(nullable: false, maxLength: 20),
                        MenuItemID = c.String(nullable: false, maxLength: 10),
                        Quantity = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Subtotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.OrderItemID)
                .ForeignKey("dbo.MenuItems", t => t.MenuItemID, cascadeDelete: true)
                .ForeignKey("dbo.Orders", t => t.OrderID, cascadeDelete: true)
                .Index(t => t.OrderID)
                .Index(t => t.MenuItemID);
            
            CreateTable(
                "dbo.MenuItems",
                c => new
                    {
                        MenuItemID = c.String(nullable: false, maxLength: 10),
                        Name = c.String(nullable: false, maxLength: 100),
                        Category = c.String(nullable: false, maxLength: 50),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IsAvailable = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MenuItemID);
            
            CreateTable(
                "dbo.MenuItemIngredients",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 10),
                        MenuItemID = c.String(nullable: false, maxLength: 10),
                        ItemID = c.String(nullable: false, maxLength: 10),
                        QuantityRequired = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Unit = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Inventory", t => t.ItemID, cascadeDelete: true)
                .ForeignKey("dbo.MenuItems", t => t.MenuItemID, cascadeDelete: true)
                .Index(t => t.MenuItemID)
                .Index(t => t.ItemID);
            
            CreateTable(
                "dbo.Inventory",
                c => new
                    {
                        ItemID = c.String(nullable: false, maxLength: 10),
                        Name = c.String(nullable: false, maxLength: 100),
                        Quantity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MinimumQuantity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Unit = c.String(nullable: false, maxLength: 50),
                        ExpirationDate = c.DateTime(nullable: false),
                        CostPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Category = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ItemID);
            
            CreateTable(
                "dbo.InventoryTransactions",
                c => new
                    {
                        TransactionID = c.String(nullable: false, maxLength: 20),
                        ItemID = c.String(nullable: false, maxLength: 10),
                        Quantity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TransactionDate = c.DateTime(nullable: false),
                        Type = c.String(nullable: false, maxLength: 50),
                        ExpirationDate = c.DateTime(),
                        TransactionPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        UserID = c.String(nullable: false, maxLength: 10),
                        OrderID = c.String(maxLength: 20),
                        Note = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.TransactionID)
                .ForeignKey("dbo.Inventory", t => t.ItemID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.ItemID)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.String(nullable: false, maxLength: 10),
                        UserName = c.String(nullable: false, maxLength: 50),
                        PasswordHash = c.String(nullable: false),
                        FullName = c.String(nullable: false, maxLength: 100),
                        Role = c.String(nullable: false, maxLength: 20),
                        IsActive = c.Boolean(nullable: false),
                        LastLoginAt = c.DateTime(),
                        Email = c.String(maxLength: 100),
                        PhoneNumber = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.UserID);
            
            CreateTable(
                "dbo.RevenueDetails",
                c => new
                    {
                        DetailID = c.String(nullable: false, maxLength: 10),
                        RevenueID = c.String(nullable: false, maxLength: 20),
                        OrderID = c.String(nullable: false, maxLength: 20),
                        ItemName = c.String(nullable: false, maxLength: 100),
                        Quantity = c.Int(nullable: false),
                        RevenueAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.DetailID)
                .ForeignKey("dbo.Orders", t => t.OrderID, cascadeDelete: true)
                .ForeignKey("dbo.Revenues", t => t.RevenueID, cascadeDelete: true)
                .Index(t => t.RevenueID)
                .Index(t => t.OrderID);
            
            CreateTable(
                "dbo.Revenues",
                c => new
                    {
                        RevenueID = c.String(nullable: false, maxLength: 20),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        TotalRevenue = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.RevenueID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RevenueDetails", "RevenueID", "dbo.Revenues");
            DropForeignKey("dbo.RevenueDetails", "OrderID", "dbo.Orders");
            DropForeignKey("dbo.BaristaQueues", "BaristaID", "dbo.Users");
            DropForeignKey("dbo.BaristaQueues", "OrderID", "dbo.Orders");
            DropForeignKey("dbo.Orders", "UserID", "dbo.Users");
            DropForeignKey("dbo.OrderItems", "OrderID", "dbo.Orders");
            DropForeignKey("dbo.OrderItems", "MenuItemID", "dbo.MenuItems");
            DropForeignKey("dbo.MenuItemIngredients", "MenuItemID", "dbo.MenuItems");
            DropForeignKey("dbo.MenuItemIngredients", "ItemID", "dbo.Inventory");
            DropForeignKey("dbo.InventoryTransactions", "UserID", "dbo.Users");
            DropForeignKey("dbo.InventoryTransactions", "ItemID", "dbo.Inventory");
            DropForeignKey("dbo.Orders", "DiscountID", "dbo.Discounts");
            DropIndex("dbo.RevenueDetails", new[] { "OrderID" });
            DropIndex("dbo.RevenueDetails", new[] { "RevenueID" });
            DropIndex("dbo.InventoryTransactions", new[] { "UserID" });
            DropIndex("dbo.InventoryTransactions", new[] { "ItemID" });
            DropIndex("dbo.MenuItemIngredients", new[] { "ItemID" });
            DropIndex("dbo.MenuItemIngredients", new[] { "MenuItemID" });
            DropIndex("dbo.OrderItems", new[] { "MenuItemID" });
            DropIndex("dbo.OrderItems", new[] { "OrderID" });
            DropIndex("dbo.Orders", new[] { "DiscountID" });
            DropIndex("dbo.Orders", new[] { "UserID" });
            DropIndex("dbo.BaristaQueues", new[] { "BaristaID" });
            DropIndex("dbo.BaristaQueues", new[] { "OrderID" });
            DropTable("dbo.Revenues");
            DropTable("dbo.RevenueDetails");
            DropTable("dbo.Users");
            DropTable("dbo.InventoryTransactions");
            DropTable("dbo.Inventory");
            DropTable("dbo.MenuItemIngredients");
            DropTable("dbo.MenuItems");
            DropTable("dbo.OrderItems");
            DropTable("dbo.Discounts");
            DropTable("dbo.Orders");
            DropTable("dbo.BaristaQueues");
        }
    }
}
