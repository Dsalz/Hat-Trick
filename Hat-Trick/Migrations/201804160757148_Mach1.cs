namespace Hat_Trick.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mach1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clubs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Image = c.Binary(),
                        LeagueId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Leagues", t => t.LeagueId, cascadeDelete: true)
                .Index(t => t.LeagueId);
            
            CreateTable(
                "dbo.Leagues",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Image = c.Binary(),
                        CountryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: true)
                .Index(t => t.CountryId);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Myimage = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Image = c.Binary(),
                        Name = c.String(),
                        Age = c.Int(nullable: false),
                        Position = c.String(),
                        ClubId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clubs", t => t.ClubId, cascadeDelete: true)
                .Index(t => t.ClubId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Players", "ClubId", "dbo.Clubs");
            DropForeignKey("dbo.Leagues", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.Clubs", "LeagueId", "dbo.Leagues");
            DropIndex("dbo.Players", new[] { "ClubId" });
            DropIndex("dbo.Leagues", new[] { "CountryId" });
            DropIndex("dbo.Clubs", new[] { "LeagueId" });
            DropTable("dbo.Players");
            DropTable("dbo.Countries");
            DropTable("dbo.Leagues");
            DropTable("dbo.Clubs");
        }
    }
}
