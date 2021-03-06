using DataAcess.Modell;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DataAcess.Context
{
    public class StoreContext : DbContext
    {
        public StoreContext() : base("DefaultConnection")
        {
        }

        public DbSet<StoreInfoModell> StoreInfo { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StoreInfoModell>().ToTable("StoreInfo");
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
