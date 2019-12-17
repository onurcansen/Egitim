namespace DOB.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class gunceldb : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Products", "OrderId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "OrderId", c => c.Guid(nullable: false));
        }
    }
}
