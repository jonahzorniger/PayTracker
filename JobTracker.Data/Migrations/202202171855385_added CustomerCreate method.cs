namespace PayTracker.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedCustomerCreatemethod : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        OwnerId = c.Guid(nullable: false),
                        FirstName = c.String(nullable: false, maxLength: 100),
                        LastName = c.String(nullable: false, maxLength: 100),
                        CreatedUtc = c.DateTimeOffset(nullable: false, precision: 7),
                        ModifiedUtc = c.DateTimeOffset(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.WorkType",
                c => new
                    {
                        WorkTypeId = c.Int(nullable: false, identity: true),
                        WorkTypeName = c.String(nullable: false, maxLength: 100),
                        Description = c.String(),
                        CreateUtc = c.DateTimeOffset(nullable: false, precision: 7),
                        ModifiedUtc = c.DateTimeOffset(precision: 7),
                    })
                .PrimaryKey(t => t.WorkTypeId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.WorkType");
            DropTable("dbo.Customer");
        }
    }
}
