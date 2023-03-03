using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sales_db.Data.Models;

namespace Sales_db.Data.Configuration
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customers>
    {
        public void Configure(EntityTypeBuilder<Customers> builder)
        {
            builder.HasMany(c => c.Sales) // сутність Customers може бути зв'язана з багатьма сутностями Sales
                .WithOne(s => s.Customer) // Sales знаходиться в відношеннях тільки з одною сутністю Customers
                .HasForeignKey(c => c.CustomerId); // зовнішній ключ в сутності Sales
        }
    }
}
