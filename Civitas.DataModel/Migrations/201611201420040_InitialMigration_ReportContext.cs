namespace Civitas.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration_ReportContext : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reports",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Title = c.String(),
                        Description = c.String(),
                        Creation = c.DateTime(nullable: false),
                        Location_Id = c.Guid(nullable: false),
                        Reporter_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Locations", t => t.Location_Id, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.Reporter_Id, cascadeDelete: true)
                .Index(t => t.Location_Id)
                .Index(t => t.Reporter_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Username = c.String(),
                        Firstname = c.String(),
                        Lastname = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Votes",
                c => new
                    {
                        id = c.Guid(nullable: false),
                        Statement = c.String(),
                        NumericVote = c.Int(nullable: false),
                        Creation = c.DateTime(nullable: false),
                        Voter_Id = c.Guid(),
                        Report_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Users", t => t.Voter_Id)
                .ForeignKey("dbo.Reports", t => t.Report_Id)
                .Index(t => t.Voter_Id)
                .Index(t => t.Report_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Votes", "Report_Id", "dbo.Reports");
            DropForeignKey("dbo.Votes", "Voter_Id", "dbo.Users");
            DropForeignKey("dbo.Reports", "Reporter_Id", "dbo.Users");
            DropForeignKey("dbo.Reports", "Location_Id", "dbo.Locations");
            DropIndex("dbo.Votes", new[] { "Report_Id" });
            DropIndex("dbo.Votes", new[] { "Voter_Id" });
            DropIndex("dbo.Reports", new[] { "Reporter_Id" });
            DropIndex("dbo.Reports", new[] { "Location_Id" });
            DropTable("dbo.Votes");
            DropTable("dbo.Users");
            DropTable("dbo.Reports");
            DropTable("dbo.Locations");
        }
    }
}
