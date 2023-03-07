namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Admins", "AdminCreatedID", c => c.Int(nullable: false));
            AddColumn("dbo.Admins", "AdminCreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Admins", "AdminUpdatedID", c => c.Int());
            AddColumn("dbo.Admins", "AdminUpdatedDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Admins", "AdminUpdatedDate");
            DropColumn("dbo.Admins", "AdminUpdatedID");
            DropColumn("dbo.Admins", "AdminCreatedDate");
            DropColumn("dbo.Admins", "AdminCreatedID");
        }
    }
}
