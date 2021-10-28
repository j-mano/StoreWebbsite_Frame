using DataAcess.Modell;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DataAcess.Context
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("DefaultConnection")
        {
        }

        public DbSet<ProductModell> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductModell>().ToTable("Product");
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
