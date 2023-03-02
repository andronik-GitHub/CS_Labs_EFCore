using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Hospital_db.Data.Models
{
    public class Diagnoses
    {
        [Key]
        public int DiagnoseId { get; set; }
        [MaxLength(50)]
        public string Name { get; set; } = null!;
        [MaxLength(250)]
        public string Comments { get; set; } = null!;


        public int PatiendId { get; set; } // Foreign key
        public Patients patient { get; set; } = null!;
    }
}
