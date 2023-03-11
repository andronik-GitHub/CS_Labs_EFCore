using BookShop_System.Data.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookShop_System.Data.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder
                .Property(b => b.Price)
                .HasColumnType("decimal(18, 2)");


            builder
                .HasOne(b => b.Author)
                .WithMany(a => a.Books)
                .HasForeignKey(b => b.AuthorId);

            builder
                .HasMany(b => b.BookCategories)
                .WithOne(bc => bc.Book)
                .HasForeignKey(bc => bc.BookId);
        }
    }
}
