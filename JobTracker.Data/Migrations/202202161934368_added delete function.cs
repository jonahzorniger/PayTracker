namespace PayTracker.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addeddeletefunction : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Job", "ProductId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Job", "ProductId", c => c.Int(nullable: false));
        }
    }
}
