namespace Testing.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddScheduleProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Schedules", "DayInt", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Schedules", "DayInt");
        }
    }
}
