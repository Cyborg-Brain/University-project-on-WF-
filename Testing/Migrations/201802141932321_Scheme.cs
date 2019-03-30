namespace Testing.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Scheme : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IdLecturer = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        Name = c.String(),
                        Surname = c.String(),
                        BirthdayStr = c.String(),
                        SexInt = c.Int(nullable: false),
                        Password = c.String(),
                        StatusInt = c.Int(nullable: false),
                        ExamBook = c.Int(nullable: false),
                        Course = c.Int(nullable: false),
                        AverageMark = c.Int(nullable: false),
                        IdGroup = c.Int(nullable: false),
                        Experience = c.Int(nullable: false),
                        Subjects = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Schedules",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdLecturer = c.Int(nullable: false),
                        IdGroup = c.Int(nullable: false),
                        IdSubject = c.Int(nullable: false),
                        NumSubject = c.Int(nullable: false),
                        DaysEnum = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Subjects");
            DropTable("dbo.Schedules");
            DropTable("dbo.People");
            DropTable("dbo.Groups");
        }
    }
}
