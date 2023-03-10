using BillsPaymentSystem.Data.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BillsPaymentSystem.Data.Configurations
{
    public class BankAccountConfiguration : IEntityTypeConfiguration<BankAccount>
    {
        public void Configure(EntityTypeBuilder<BankAccount> builder)
        {
            builder
                .Property(ba => ba.Balance)
                .HasColumnType("decimal(18, 5)");


            builder // One to one - BankAccount to PaymentMethod
                .HasOne(ba => ba.PaymentMethod)
                .WithOne(pm => pm.BankAccount)
                .HasForeignKey<PaymentMethod>(pm => pm.BankAccountId);
        }
    }
}
