using BillsPaymentSystem.Data.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BillsPaymentSystem.Data.Models.Entities
{
    [Table("PaymentMethods")]
    public class PaymentMethod
    {
        [Key]
        public Guid PaymentMethodId { get; set; }
        [Required]
        public PaymentTypes Type { get; set; }


        public Guid UserId { get; set; }
        public User User { get; set; } = default!;
        public Guid? BankAccountId { get; set; }
        public BankAccount? BankAccount { get; set; } = default;
        public Guid? CreditCardId { get; set; }
        public CreditCard? CreditCard { get; set; } = default;
    }
}
