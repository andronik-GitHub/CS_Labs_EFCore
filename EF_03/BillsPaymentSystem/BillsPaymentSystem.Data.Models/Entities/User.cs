using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BillsPaymentSystem.Data.Models.Entities
{
    [Table("Users")]
    public class User
    {
        [Key]
        public Guid UserId { get; set; }
        [Required]
        [MaxLength(50)]
        [Unicode(true)]
        public string FirtsName { get; set; } = default!;
        [Required]
        [MaxLength(50)]
        [Unicode(true)]
        public string LastName { get; set; } = default!;
        [Required]
        [MaxLength(80)]
        [Unicode(false)]
        public string Email { get; set; } = default!;
        [Required]
        [MaxLength(25)]
        [Unicode(false)]
        public string Password { get; set; } = default!;


        public ICollection<PaymentMethod> PaymentMethods { get; set; } = default!;
    }
}
