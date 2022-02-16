namespace JobTracker.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class detailsAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Job", "JobType", c => c.String());
            DropColumn("dbo.Job", "JobName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Job", "JobName", c => c.String());
            DropColumn("dbo.Job", "JobType");
        }
    }
}
