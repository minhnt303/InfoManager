namespace InfoManager.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<InfoManager.Models.InfoDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "InfoManager.Models.InfoDBContext";
        }

        protected override void Seed(InfoManager.Models.InfoDBContext context)
        {
            //  This method will be called after migrating to the latest version.
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.CategoryOfInfos.AddOrUpdate(c => c.CategoryOfInfoID,
                new Models.CategoryOfInfo { CategoryOfInfoID = 1, Description = @"Đồ điện tử" },
                new Models.CategoryOfInfo { CategoryOfInfoID = 2, Description = @"Đồ nhà bếp" }
                );
            context.Infos.AddOrUpdate(p => p.InfoId,
                new Models.Info { InfoId = 1, NameOfInfo = @"Quạt điện", CategoryOfInfoID = 1 },
                new Models.Info { InfoId = 2, NameOfInfo = @"Chảo", CategoryOfInfoID = 2 }
                );
        }
    }
}
