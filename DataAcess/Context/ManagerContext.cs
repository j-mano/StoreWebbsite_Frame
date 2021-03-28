using DataAcess.Modell;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DataAcess.Context
{
    public class ManagerContext : DbContext
    {
        public ManagerContext() : base("DefaultConnection")
        {
        }

        public DbSet<ManagerInfoModell> ManagerInfo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ManagerInfoModell>().ToTable("ManagerInfo");
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
