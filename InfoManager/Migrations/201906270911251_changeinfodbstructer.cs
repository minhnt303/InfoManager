namespace InfoManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeinfodbstructer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Infoes", "CategoryOfInfosdsdsID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Infoes", "CategoryOfInfosdsdsID");
        }
    }
}
