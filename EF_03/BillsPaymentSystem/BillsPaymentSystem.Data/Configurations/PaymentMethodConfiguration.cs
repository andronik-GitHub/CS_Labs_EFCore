using BillsPaymentSystem.Data.Models.Entities;
using BillsPaymentSystem.Data.Models.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BillsPaymentSystem.Data.Configurations
{
    public class PaymentMethodConfiguration : IEntityTypeConfiguration<PaymentMethod>
    {
        public void Configure(EntityTypeBuilder<PaymentMethod> builder)
        {
            builder
                .Property(pm => pm.PaymentMethodId)
                .HasColumnName("Id");

            builder
                .ToTable(pm => pm.HasCheckConstraint(
                        "CK_PaymentMethods_BankAccountId_AND_CreditCardId",
                        "(([BankAccountId] IS NULL) AND ([CreditCardId] IS NOT NULL)) OR (([BankAccountId] IS NOT NULL) AND ([CreditCardId] IS NULL))"
                    ));
        }
    }
}
