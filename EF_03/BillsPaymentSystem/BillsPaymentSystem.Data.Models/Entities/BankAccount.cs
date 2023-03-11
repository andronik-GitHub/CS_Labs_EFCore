using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BillsPaymentSystem.Data.Models.Entities
{
    [Table("BankAccounts")]
    public class BankAccount
    {
        [Key]
        public Guid BankAccountId { get; set; }
        [Required]
        public decimal Balance { get; private set; }
        [Required]
        [MaxLength(50)]
        [Unicode(true)]
        public string BankName { get; set; } = default!;
        [Required]
        [MaxLength(20)]
        [Unicode(false)]
        public string SWIFT_Code { get; set; } = default!;


        public PaymentMethod PaymentMethod { get; set; } = default!;



        public bool Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                return true;
            }
            else
                return false;
        }
        public bool Diposit(decimal amount)
        {
            Balance += amount;
            return true;
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
