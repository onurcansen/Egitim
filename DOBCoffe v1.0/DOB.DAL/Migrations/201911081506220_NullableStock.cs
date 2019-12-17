namespace DOB.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NullableStock : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "UnitOnStock", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "UnitOnStock", c => c.Int(nullable: false));
        }
    }
}
