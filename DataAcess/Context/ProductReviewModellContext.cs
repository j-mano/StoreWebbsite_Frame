using DataAcess.Modell;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DataAcess.Context
{
    public class ProductReviewModellContext : DbContext
    {
        public ProductReviewModellContext() : base("DefaultConnection")
        {
        }

        public DbSet<ProductReviewModell> Productreviews { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductReviewModell>().ToTable("ProductReview");
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
