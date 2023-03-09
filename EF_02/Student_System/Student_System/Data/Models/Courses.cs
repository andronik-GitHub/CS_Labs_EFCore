using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Student_System.Data.Models
{
    public class Courses
    {
        [Key]
        public Guid CourseId { get; set; }
        [MaxLength(50)]
        [Required]
        public string Name { get; set; } = default!;
        [Unicode(true)]
        public string Description { get; set; } = default!;
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public decimal Price { get; set; }


        public ICollection<Resources> Resources { get; set; } = new List<Resources>();
        public ICollection<Homework> Homework { get; set; } = new List<Homework>();
        public ICollection<StudentsCourses> StudentsCourses { get; set; } = new List<StudentsCourses>();
    }
}
