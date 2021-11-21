namespace Proekt_v2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.InRepairs", "ClientName", c => c.String(maxLength: 120));
            AlterColumn("dbo.Reviews", "Client", c => c.String(nullable: false, maxLength: 120));
            AlterColumn("dbo.Reviews", "Title", c => c.String(maxLength: 20));
            AlterColumn("dbo.Reviews", "Comment", c => c.String(maxLength: 800));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Reviews", "Comment", c => c.String());
            AlterColumn("dbo.Reviews", "Title", c => c.String());
            AlterColumn("dbo.Reviews", "Client", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.InRepairs", "ClientName", c => c.String());
        }
    }
}
