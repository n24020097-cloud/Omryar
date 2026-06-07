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
                        ReportId = c.Int(nullable: false, identity: true),
                        PersonId = c.Int(nullable: false),
                        ReportDate = c.DateTime(nullable: false),
                        Notes = c.String(),
                        WaterCups = c.Int(nullable: false),
                        Mood = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ReportId);
            
            CreateTable(
                "dbo.ReportTasks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ReportId = c.Int(nullable: false),
                        TaskTitle = c.String(),
                        IsCompleted = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Reports", t => t.ReportId, cascadeDelete: true)
                .Index(t => t.ReportId);
            
            CreateTable(
                "dbo.Drugs",
                c => new
                    {
                        DrugId = c.Int(nullable: false, identity: true),
                        PersonId = c.Int(nullable: false),
                        DrugName = c.String(),
                        Dosage = c.Int(nullable: false),
                        ReminderRepeatType = c.Int(nullable: false),
                        ReminderRepeatValue = c.Int(nullable: false),
                        ReminderStartTime = c.DateTime(nullable: false),
                        LastReminderTime = c.DateTime(),
                        ReminderDosage = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.DrugId);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Mobile = c.String(),
                        NationalCode = c.String(),
                        UserName = c.String(),
                        PasswordHash = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.PersonId);
            
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
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ReportTasks", "ReportId", "dbo.Reports");
            DropIndex("dbo.ReportTasks", new[] { "ReportId" });
            DropTable("dbo.VisitReminders");
            DropTable("dbo.People");
            DropTable("dbo.Drugs");
            DropTable("dbo.ReportTasks");
            DropTable("dbo.Reports");
        }
    }
}
