namespace MyFitness.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FoodInfo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FoodInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NamaMakanan = c.String(nullable: false, maxLength: 255),
                        TotalCalories = c.Int(nullable: false),
                        UserId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FoodInfoes", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.FoodInfoes", new[] { "UserId" });
            DropTable("dbo.FoodInfoes");
        }
    }
}
