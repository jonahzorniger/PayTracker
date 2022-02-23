namespace PayTracker.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedcreatemethods : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Job", "JobName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Job", "JobName");
        }
    }
}
