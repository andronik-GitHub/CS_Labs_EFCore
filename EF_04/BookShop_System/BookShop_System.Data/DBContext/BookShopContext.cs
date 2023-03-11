using BookShop_System.Data.Configurations;
using Microsoft.EntityFrameworkCore;

namespace BookShop_System.Data.DBContext
{
    public class BookShopContext : DbContext
    {
        public BookShopContext(DbContextOptions<BookShopContext> options)
            : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new AuthorConfiguration());
            modelBuilder.ApplyConfiguration(new BookConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new BookCategoryConfiguration());
        }
    }
}
