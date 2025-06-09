namespace PBL3_CoffeeHome.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Salary : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Salaries",
                c => new
                    {
                        SalaryID = c.String(nullable: false, maxLength: 20),
                        ScheduleID = c.String(nullable: false, maxLength: 20),
                        UserID = c.String(nullable: false, maxLength: 20),
                        HoursWorked = c.Decimal(nullable: false, precision: 18, scale: 2),
                        HourlyRate = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalSalary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PaymentDate = c.DateTime(nullable: false),
                        Status = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.SalaryID)
                .ForeignKey("dbo.Schedules", t => t.ScheduleID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.ScheduleID)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.Schedules",
                c => new
                    {
                        ScheduleID = c.String(nullable: false, maxLength: 20),
                        UserID = c.String(maxLength: 20),
                        TypeSchedule = c.String(),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ScheduleID)
                .ForeignKey("dbo.Users", t => t.UserID)
                .Index(t => t.UserID);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Salaries", "UserID", "dbo.Users");
            DropForeignKey("dbo.Salaries", "ScheduleID", "dbo.Schedules");
            DropForeignKey("dbo.Schedules", "UserID", "dbo.Users");
            DropIndex("dbo.Schedules", new[] { "UserID" });
            DropIndex("dbo.Salaries", new[] { "UserID" });
            DropIndex("dbo.Salaries", new[] { "ScheduleID" });
            DropTable("dbo.Schedules");
            DropTable("dbo.Salaries");
        }
    }
}
