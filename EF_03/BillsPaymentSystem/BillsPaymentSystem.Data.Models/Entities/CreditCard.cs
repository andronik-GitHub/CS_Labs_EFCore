using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BillsPaymentSystem.Data.Models.Entities
{
    [Table("CreditCards")]
    public class CreditCard
    {
        [Key]
        public Guid CreditCardId { get; set; }
        [Required]
        public decimal Limit { get; set; }
        [Required]
        public decimal MoneyOwed { get; set; }
        [NotMapped]
        public decimal LimitLeft { get; set; }
        [Required]
        public DateTime ExpirationDate { get; set; }


        public PaymentMethod PaymentMethod { get; set; } = default!;
    }
}
