using BillsPaymentSystem.Data.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BillsPaymentSystem.Data.Configurations
{
    public class CreditCardConfiguration : IEntityTypeConfiguration<CreditCard>
    {
        public void Configure(EntityTypeBuilder<CreditCard> builder)
        {
            builder
                .Property(cc => cc.Limit)
                .HasColumnType("decimal(18, 5)");

            builder
                .Property(cc => cc.MoneyOwed)
                .HasColumnType("decimal(18, 5)");


            builder // One to one - CreditCard to PaymentMethod
                .HasOne(cc => cc.PaymentMethod)
                .WithOne(pm => pm.CreditCard)
                .HasForeignKey<PaymentMethod>(pm => pm.CreditCardId);
        }
    }
}
