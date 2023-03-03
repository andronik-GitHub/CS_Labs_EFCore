using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sales_db.Data.Models;

namespace Sales_db.Data.Configuration
{
    public class StoreConfiguration : IEntityTypeConfiguration<Stores>
    {
        public void Configure(EntityTypeBuilder<Stores> builder)
        {
            builder.HasMany(s => s.Sales) // сутність Stores може бути зв'язана з багатьма сутностями Sales
                .WithOne(s => s.Store) // Sales знаходиться в відношеннях тільки з одною сутністю Stores
                .HasForeignKey(s => s.StoreId); // зовнішній ключ в сутності Sales
        }
    }
}
