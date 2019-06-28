namespace InfoManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CategoryOfInfoes",
                c => new
                    {
                        CategoryOfInfoID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.CategoryOfInfoID);
            
            CreateTable(
                "dbo.Infoes",
                c => new
                    {
                        InfoId = c.Int(nullable: false, identity: true),
                        NameOfInfo = c.String(),
                        CategoryOfInfoID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.InfoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Infoes");
            DropTable("dbo.CategoryOfInfoes");
        }
    }
}
