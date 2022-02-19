namespace JobTracker.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatemethodWorkType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WorkType", "OwnerId", c => c.Guid(nullable: false));
            AddColumn("dbo.WorkType", "CreatedUtc", c => c.DateTimeOffset(nullable: false, precision: 7));
            DropColumn("dbo.WorkType", "CreateUtc");
        }
        
        public override void Down()
        {
            AddColumn("dbo.WorkType", "CreateUtc", c => c.DateTimeOffset(nullable: false, precision: 7));
            DropColumn("dbo.WorkType", "CreatedUtc");
            DropColumn("dbo.WorkType", "OwnerId");
        }
    }
}
