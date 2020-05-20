namespace MyFitness.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HasilRekomendasi : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.JenisPrograms", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.JenisPrograms", new[] { "User_Id" });
            CreateTable(
                "dbo.HasilRekomendasis",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Hari = c.Int(nullable: false),
                        Set = c.Int(nullable: false),
                        Repetisi = c.Int(nullable: false),
                        ProgramId = c.Int(nullable: false),
                        UserId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.JenisPrograms", t => t.ProgramId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.ProgramId)
                .Index(t => t.UserId);
            
            DropColumn("dbo.JenisPrograms", "User_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.JenisPrograms", "User_Id", c => c.String(maxLength: 128));
            DropForeignKey("dbo.HasilRekomendasis", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.HasilRekomendasis", "ProgramId", "dbo.JenisPrograms");
            DropIndex("dbo.HasilRekomendasis", new[] { "UserId" });
            DropIndex("dbo.HasilRekomendasis", new[] { "ProgramId" });
            DropTable("dbo.HasilRekomendasis");
            CreateIndex("dbo.JenisPrograms", "User_Id");
            AddForeignKey("dbo.JenisPrograms", "User_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
