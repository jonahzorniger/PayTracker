namespace PayTracker.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatingforeignkeys : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Job", "WorkType_WorkTypeId", "dbo.WorkType");
            DropIndex("dbo.Job", new[] { "WorkType_WorkTypeId" });
            RenameColumn(table: "dbo.Job", name: "WorkType_WorkTypeId", newName: "WorkTypeId");
            AlterColumn("dbo.Job", "WorkTypeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Job", "WorkTypeId");
            AddForeignKey("dbo.Job", "WorkTypeId", "dbo.WorkType", "WorkTypeId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Job", "WorkTypeId", "dbo.WorkType");
            DropIndex("dbo.Job", new[] { "WorkTypeId" });
            AlterColumn("dbo.Job", "WorkTypeId", c => c.Int());
            RenameColumn(table: "dbo.Job", name: "WorkTypeId", newName: "WorkType_WorkTypeId");
            CreateIndex("dbo.Job", "WorkType_WorkTypeId");
            AddForeignKey("dbo.Job", "WorkType_WorkTypeId", "dbo.WorkType", "WorkTypeId");
        }
    }
}
