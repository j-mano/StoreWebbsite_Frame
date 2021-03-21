using DataAcess.Modell;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.Context
{
    public class StoreContext : DbContext
    {
        public StoreContext() : base("DefaultConnection")
        {
        }

        public DbSet<StoreModell> StoreInfo { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ManagerInfoModell>().ToTable("StoreInfo");
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
