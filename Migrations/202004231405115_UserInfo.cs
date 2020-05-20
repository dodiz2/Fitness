namespace MyFitness.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class UserInfo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserInfoes",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    NamaLengkap = c.String(),
                    BeratBadan = c.Int(nullable: false),
                    TinggiBadan = c.Int(nullable: false),
                    Dada = c.Boolean(nullable: false),
                    Bahu = c.Boolean(nullable: false),
                    Punggung = c.Boolean(nullable: false),
                    Kaki = c.Boolean(nullable: false),
                    Bokong = c.Boolean(nullable: false),
                    Perut = c.Boolean(nullable: false),
                    LenganBicep = c.Boolean(nullable: false),
                    LenganTricep = c.Boolean(nullable: false),
                    tanggal_update = c.DateTime(nullable: false),
                    tanggal_lahir = c.DateTime(nullable: false),
                    Tingkatan = c.Int(nullable:false),
                    UserId = c.String(maxLength: 128),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.UserId);

        }

        public override void Down()
        {
            DropForeignKey("dbo.UserInfoes", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.UserInfoes", new[] { "UserId" });
            DropTable("dbo.UserInfoes");
        }
    }
}