namespace PayTracker.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixedheaders : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Job", "WorkType", c => c.String());
            DropColumn("dbo.Job", "JobType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Job", "JobType", c => c.String());
            DropColumn("dbo.Job", "WorkType");
        }
    }
}
