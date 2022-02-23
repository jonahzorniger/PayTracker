namespace JobTracker.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedworktypeidforeignkey : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Job", "WorkType_WorkTypeId", c => c.Int());
            CreateIndex("dbo.Job", "WorkType_WorkTypeId");
            AddForeignKey("dbo.Job", "WorkType_WorkTypeId", "dbo.WorkType", "WorkTypeId");
            DropColumn("dbo.Job", "CustomerId");
            DropColumn("dbo.Job", "WorkType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Job", "WorkType", c => c.String());
            AddColumn("dbo.Job", "CustomerId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Job", "WorkType_WorkTypeId", "dbo.WorkType");
            DropIndex("dbo.Job", new[] { "WorkType_WorkTypeId" });
            DropColumn("dbo.Job", "WorkType_WorkTypeId");
        }
    }
}
