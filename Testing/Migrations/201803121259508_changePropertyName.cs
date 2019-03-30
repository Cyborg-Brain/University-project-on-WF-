namespace Testing.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changePropertyName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "Birthday", c => c.String());
            DropColumn("dbo.People", "BirthdayStr");
        }
        
        public override void Down()
        {
            AddColumn("dbo.People", "BirthdayStr", c => c.String());
            DropColumn("dbo.People", "Birthday");
        }
    }
}
