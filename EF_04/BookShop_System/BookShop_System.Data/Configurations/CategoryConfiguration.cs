using BookShop_System.Data.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookShop_System.Data.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder
                .HasMany(c => c.BookCategories)
                .WithOne(bc => bc.Category)
                .HasForeignKey(bc => bc.CategoryId);
        }
    }
}
