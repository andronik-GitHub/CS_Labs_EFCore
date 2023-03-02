using System.ComponentModel.DataAnnotations;

namespace Hospital_db.Data.Models
{
    public class Visitations
    {
        [Key]
        public int VisitationId { get; set; }
        public DateTime Date { get; set; }
        [MaxLength(250)]
        public string Comments { get; set; }

        
        public int PatiendId { get; set; } // Foreign key
        public Patients patient { get; set; }
    }
}
