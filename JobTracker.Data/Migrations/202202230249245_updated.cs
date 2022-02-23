namespace PayTracker.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Job", "Customer_CustomerId", c => c.Int());
            CreateIndex("dbo.Job", "Customer_CustomerId");
            AddForeignKey("dbo.Job", "Customer_CustomerId", "dbo.Customer", "CustomerId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Job", "Customer_CustomerId", "dbo.Customer");
            DropIndex("dbo.Job", new[] { "Customer_CustomerId" });
            DropColumn("dbo.Job", "Customer_CustomerId");
        }
    }
}
