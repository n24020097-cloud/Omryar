namespace Omryar.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonId = c.Int(nullable: false),
                        ReportDate = c.DateTime(nullable: false),
                        Notes = c.String(),
                        WaterCups = c.Int(nullable: false),
                        Mood = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.PersonId, cascadeDelete: true)
                .Index(t => t.PersonId);
            
            CreateTable(
                "dbo.ReportTasks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ReportId = c.Int(nullable: false),
                        TaskTitle = c.String(),
                        IsCompleted = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Reports", t => t.ReportId, cascadeDelete: true)
                .Index(t => t.ReportId);
            
            CreateTable(
                "dbo.Drugs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonId = c.Int(nullable: false),
                        DrugName = c.String(),
                        RepeatType = c.Int(nullable: false),
                        RepeatValue = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        Note = c.String(),
                        LastTakenTime = c.DateTime(),
                        DrugQty = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.PersonId, cascadeDelete: true)
                .Index(t => t.PersonId);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Mobile = c.String(),
                        NationalCode = c.String(),
                        UserName = c.String(),
                        PasswordHash = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.VisitReminders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonId = c.Int(nullable: false),
                        DoctorName = c.String(),
                        Specialty = c.String(),
                        VisitDateTime = c.DateTime(nullable: false),
                        Notes = c.String(),
                        IsDone = c.Boolean(nullable: false),
                        IsNotified = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.PersonId, cascadeDelete: true)
                .Index(t => t.PersonId);
            
            CreateTable(
                "dbo.UserSettings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonId = c.Int(nullable: false),
                        Bio = c.String(),
                        ProfileImagePath = c.String(),
                        IsProfilePublic = c.Boolean(nullable: false),
                        EnableVisitReminder = c.Boolean(nullable: false),
                        EnableMedicineReminder = c.Boolean(nullable: false),
                        Theme = c.String(),
                        FontSize = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.VisitReminders", "PersonId", "dbo.People");
            DropForeignKey("dbo.Reports", "PersonId", "dbo.People");
            DropForeignKey("dbo.Drugs", "PersonId", "dbo.People");
            DropForeignKey("dbo.ReportTasks", "ReportId", "dbo.Reports");
            DropIndex("dbo.VisitReminders", new[] { "PersonId" });
            DropIndex("dbo.Drugs", new[] { "PersonId" });
            DropIndex("dbo.ReportTasks", new[] { "ReportId" });
            DropIndex("dbo.Reports", new[] { "PersonId" });
            DropTable("dbo.UserSettings");
            DropTable("dbo.VisitReminders");
            DropTable("dbo.People");
            DropTable("dbo.Drugs");
            DropTable("dbo.ReportTasks");
            DropTable("dbo.Reports");
        }
    }
}
