namespace Proekt_v2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.InRepairs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ServicesId = c.Int(),
                        ProductName = c.String(nullable: false, maxLength: 120),
                        ClientName = c.String(),
                        ProductNumber = c.Int(nullable: false),
                        TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Received = c.DateTime(nullable: false),
                        Returning = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Services", t => t.ServicesId)
                .Index(t => t.ServicesId);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        InRepairId = c.Int(nullable: false),
                        Client = c.String(nullable: false, maxLength: 100),
                        Title = c.String(),
                        Comment = c.String(),
                        Published = c.DateTime(nullable: false),
                        Rating = c.Int(nullable: false),
                        Reads = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.InRepairs", t => t.InRepairId, cascadeDelete: true)
                .Index(t => t.InRepairId);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 100),
                        Description = c.String(maxLength: 300),
                        IsAvailable = c.Boolean(nullable: false),
                        MaterialsPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        RepairPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ExpectedRepairDays = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.InRepairs", "ServicesId", "dbo.Services");
            DropForeignKey("dbo.Reviews", "InRepairId", "dbo.InRepairs");
            DropIndex("dbo.Reviews", new[] { "InRepairId" });
            DropIndex("dbo.InRepairs", new[] { "ServicesId" });
            DropTable("dbo.Services");
            DropTable("dbo.Reviews");
            DropTable("dbo.InRepairs");
        }
    }
}
