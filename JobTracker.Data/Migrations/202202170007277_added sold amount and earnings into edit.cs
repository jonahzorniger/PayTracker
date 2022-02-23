namespace PayTracker.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedsoldamountandearningsintoedit : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Job", "SoldAmount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Job", "Earnings", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Job", "Earnings", c => c.Int(nullable: false));
            AlterColumn("dbo.Job", "SoldAmount", c => c.Int(nullable: false));
        }
    }
}
