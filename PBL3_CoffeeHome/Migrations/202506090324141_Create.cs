namespace PBL3_CoffeeHome.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MenuItems", "ImagePath", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MenuItems", "ImagePath");
        }
    }
}
