namespace Hat_Trick.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mach2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Players", "ClubId", "dbo.Clubs");
            DropIndex("dbo.Players", new[] { "ClubId" });
            AddColumn("dbo.Players", "CountryId", c => c.Int());
            AlterColumn("dbo.Players", "ClubId", c => c.Int());
            CreateIndex("dbo.Players", "ClubId");
            CreateIndex("dbo.Players", "CountryId");
            AddForeignKey("dbo.Players", "CountryId", "dbo.Countries", "Id");
            AddForeignKey("dbo.Players", "ClubId", "dbo.Clubs", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Players", "ClubId", "dbo.Clubs");
            DropForeignKey("dbo.Players", "CountryId", "dbo.Countries");
            DropIndex("dbo.Players", new[] { "CountryId" });
            DropIndex("dbo.Players", new[] { "ClubId" });
            AlterColumn("dbo.Players", "ClubId", c => c.Int(nullable: false));
            DropColumn("dbo.Players", "CountryId");
            CreateIndex("dbo.Players", "ClubId");
            AddForeignKey("dbo.Players", "ClubId", "dbo.Clubs", "Id", cascadeDelete: true);
        }
    }
}
