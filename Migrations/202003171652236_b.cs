namespace MyFitness.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class b : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserInfoes", "Tingkatan", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserInfoes", "Tingkatan");
        }
    }
}
