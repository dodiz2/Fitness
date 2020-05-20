namespace MyFitness.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DetailProgram : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DetailProgramViewModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FotoGerakan = c.String(nullable: false, maxLength: 255),
                        Deskripsi = c.String(),
                        Langkah = c.String(),
                        ProgramId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.JenisPrograms", t => t.ProgramId, cascadeDelete: true)
                .Index(t => t.ProgramId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DetailProgramViewModels", "ProgramId", "dbo.JenisPrograms");
            DropIndex("dbo.DetailProgramViewModels", new[] { "ProgramId" });
            DropTable("dbo.DetailProgramViewModels");
        }
    }
}
