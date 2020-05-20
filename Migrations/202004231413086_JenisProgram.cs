namespace MyFitness.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JenisProgram : DbMigration
    {
        public override void Up()
        {
            CreateTable(
               "dbo.JenisPrograms",
               c => new
               {
                   Id = c.Int(nullable: false, identity: true),
                   NamaProgram = c.String(),
                   JenisAlat = c.String(nullable: false),
                   JenisProgram = c.String(nullable: false),
                   Dada = c.Boolean(nullable: false),
                   Bahu = c.Boolean(nullable: false),
                   Punggung = c.Boolean(nullable: false),
                   Kaki = c.Boolean(nullable: false),
                   Bokong = c.Boolean(nullable: false),
                   Perut = c.Boolean(nullable: false),
                   LenganBicep = c.Boolean(nullable: false),
                   LenganTricep = c.Boolean(nullable: false),
                   FotoGerakan = c.String(nullable: false),
                   Deskripsi = c.String(nullable: false),
               })
               .PrimaryKey(t => t.Id);
              
        }
        
        public override void Down()
        {
            DropTable("dbo.JenisProgram");
        }
    }
}
