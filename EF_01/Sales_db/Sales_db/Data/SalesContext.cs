using Bogus;
using Microsoft.EntityFrameworkCore;
using Sales_db.Data.Bogus;
using Sales_db.Data.Configuration;
using Sales_db.Data.Models;

namespace Sales_db.Data
{
    public class SalesContext : DbContext
    {
        public DbSet<Sales> Sales { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Stores> Stores { get; set; }
        public DbSet<Products> Products { get; set; }

        public SalesContext(DbContextOptions<SalesContext> options)
            : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new StoreConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());

            
            DataGenerator.InitBogusData();
            modelBuilder.Entity<Products>().HasData(DataGenerator.Products);
            modelBuilder.Entity<Customers>().HasData(DataGenerator.Customers);
            modelBuilder.Entity<Stores>().HasData(DataGenerator.Stores);
            modelBuilder.Entity<Sales>().HasData(DataGenerator.Sales);
        }
    }
}
