using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BillsPaymentSystem.Data.Models.Entities
{
    [Table("BankAccounts")]
    public class BankAccount
    {
        [Key]
        public Guid BankAccountId { get; set; }
        [Required]
        public decimal Balance { get; set; }
        [Required]
        [MaxLength(50)]
        [Unicode(true)]
        public string BankName { get; set; } = default!;
        [Required]
        [MaxLength(20)]
        [Unicode(false)]
        public string SWIFT_Code { get; set; } = default!;


        public PaymentMethod PaymentMethod { get; set; } = default!;
    }
}
