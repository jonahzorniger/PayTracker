namespace PayTracker.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatingcustomerkey : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Job", "Customer_CustomerId", "dbo.Customer");
            DropIndex("dbo.Job", new[] { "Customer_CustomerId" });
            RenameColumn(table: "dbo.Job", name: "Customer_CustomerId", newName: "CustomerId");
            AlterColumn("dbo.Job", "CustomerId", c => c.Int(nullable: false));
            CreateIndex("dbo.Job", "CustomerId");
            AddForeignKey("dbo.Job", "CustomerId", "dbo.Customer", "CustomerId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Job", "CustomerId", "dbo.Customer");
            DropIndex("dbo.Job", new[] { "CustomerId" });
            AlterColumn("dbo.Job", "CustomerId", c => c.Int());
            RenameColumn(table: "dbo.Job", name: "CustomerId", newName: "Customer_CustomerId");
            CreateIndex("dbo.Job", "Customer_CustomerId");
            AddForeignKey("dbo.Job", "Customer_CustomerId", "dbo.Customer", "CustomerId");
        }
    }
}
