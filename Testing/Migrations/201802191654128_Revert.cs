namespace Testing.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Revert : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.People", new[] { "ExamBook" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.People", "ExamBook", unique: false);
        }
    }
}
