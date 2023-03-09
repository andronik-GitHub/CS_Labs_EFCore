using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sales_db.Data.Models;

namespace Sales_db.Data.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Products>
    {
        public void Configure(EntityTypeBuilder<Products> builder)
        {
            builder.HasMany(p => p.Sales) // сутність Products може бути зв'язана з багатьма сутностями Sales
                .WithOne(s => s.Product) // Sales знаходиться в відношеннях тільки з одною сутністю Products
                .HasForeignKey(s => s.ProductId); // зовнішній ключ в сутності Sales

            builder
                .ToTable(t => t.HasCheckConstraint(
                        "CK_Products_Quantity_RealNumber",
                        "[Quantity] >= 0"
                    ));

            builder
                .Property(p => p.Description)
                .HasDefaultValue("No description");
        }
    }
}
