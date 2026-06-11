namespace Omryar.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateDrugs : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Drugs", "NextTokenTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Drugs", "NextTokenTime");
        }
    }
}
