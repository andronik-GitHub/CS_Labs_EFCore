using BookShop_System.Data.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookShop_System.Data.Configurations
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder
                .HasMany(a => a.Books)
                .WithOne(b => b.Author)
                .HasForeignKey(b => b.AuthorId);
        }
    }
}
