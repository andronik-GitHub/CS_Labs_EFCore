using BookShop_System.Data.Bogus;
using BookShop_System.Data.Configurations;
using BookShop_System.Data.Models.Entities;
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

            DataGenerator.InitBogusData();
            modelBuilder.Entity<Author>().HasData(DataGenerator.Authors);
            modelBuilder.Entity<Book>().HasData(DataGenerator.Books);
            modelBuilder.Entity<Category>().HasData(DataGenerator.Categories);
            modelBuilder.Entity<BookCategory>().HasData(DataGenerator.BookCategories);
        }
    }
}
