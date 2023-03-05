namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Abouts", "AboutCreatedID");
            DropColumn("dbo.Abouts", "AboutCreatedDate");
            DropColumn("dbo.Abouts", "AboutisActive");
            DropColumn("dbo.Abouts", "AboutUpdatedID");
            DropColumn("dbo.Abouts", "AboutUpdatedDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Abouts", "AboutUpdatedDate", c => c.DateTime());
            AddColumn("dbo.Abouts", "AboutUpdatedID", c => c.Int());
            AddColumn("dbo.Abouts", "AboutisActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Abouts", "AboutCreatedDate", c => c.DateTime());
            AddColumn("dbo.Abouts", "AboutCreatedID", c => c.Int(nullable: false));
        }
    }
}
