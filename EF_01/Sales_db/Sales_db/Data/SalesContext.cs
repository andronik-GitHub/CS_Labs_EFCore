using Microsoft.EntityFrameworkCore;
using Sales_db.Data.Models;

namespace Sales_db.Data
{
    public class SalesContext : DbContext
    {
        public DbSet<Sales> Sales { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Stores> Stores { get; set; }
        public DbSet<Products> Products { get; set; }

        public SalesContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
