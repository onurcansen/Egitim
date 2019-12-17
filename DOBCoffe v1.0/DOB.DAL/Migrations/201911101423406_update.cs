namespace DOB.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Orders", "OrderDetailId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "OrderDetailId", c => c.Guid(nullable: false));
        }
    }
}
