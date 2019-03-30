namespace Testing.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ScheduleChangeProperty : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Schedules", "DaysEnum");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Schedules", "DaysEnum", c => c.Int(nullable: false));
        }
    }
}
