using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace BillsPaymentSystem.Data.Models.Entities
{
    [Table("CreditCards")]
    public class CreditCard
    {
        [Key]
        public Guid CreditCardId { get; set; }
        [Required]
        public decimal Limit { get; private set; }
        [Required]
        public decimal MoneyOwed { get; private set; }
        [NotMapped]
        public decimal LimitLeft { get => Limit - MoneyOwed; }
        [Required]
        public DateTime ExpirationDate { get; set; }


        public PaymentMethod PaymentMethod { get; set; } = default!;



        public bool Withdraw(decimal amount)
        {
            if (LimitLeft <= amount)
            {
                MoneyOwed += amount;
                return true;
            }
            else
                return false;
        }
        public bool Diposit(decimal amount)
        {
            if (LimitLeft < amount)
                return false;
            else
            {
                MoneyOwed -= amount;
                return true;
            }
        }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this, new JsonSerializerOptions
            {
                WriteIndented = true,
                ReferenceHandler = ReferenceHandler.Preserve
            });
        }
    }
}
