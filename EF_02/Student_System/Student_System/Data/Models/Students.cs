using System.ComponentModel.DataAnnotations;

namespace Student_System.Data.Models
{
    public class Students
    {
        [Key]
        public Guid StudentId { get; set; }
        [MaxLength(100)]
        [Required]
        public string Name { get; set; } = default!;
        [Required]
        public string PhoneNumber { get; set; } = default!;
        [Required]
        public bool RegisteredOn { get; set; }
        public DateTime Birthday { get; set; }


        public ICollection<Homework> Homework { get; set; } = new List<Homework>();
        public ICollection<StudentsCourses> StudentsCourses { get; set; } = new List<StudentsCourses>();
    }
}
