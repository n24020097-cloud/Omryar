namespace Omryar.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createUserSettingTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserSettings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonId = c.Int(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Username = c.String(),
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
            DropTable("dbo.UserSettings");
        }
    }
}
