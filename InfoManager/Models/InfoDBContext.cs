namespace InfoManager.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class InfoDBContext : DbContext
    {
        public InfoDBContext()
            : base("name=InfoDBContext")
        {
        }

        public DbSet<Info> Infos { get; set; }
        public DbSet<CategoryOfInfo> CategoryOfInfos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
