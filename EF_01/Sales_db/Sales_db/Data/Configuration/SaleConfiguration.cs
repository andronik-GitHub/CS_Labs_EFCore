using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sales_db.Data.Models;

namespace Sales_db.Data.Configuration
{
    public class SaleConfiguration : IEntityTypeConfiguration<Sales>
    {
        public void Configure(EntityTypeBuilder<Sales> builder)
        {
            builder
                .Property(s => s.Date)
                .HasDefaultValueSql("getdate()");
        }
    }
}
