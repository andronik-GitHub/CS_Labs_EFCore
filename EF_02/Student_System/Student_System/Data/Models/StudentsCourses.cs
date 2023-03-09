using System.ComponentModel.DataAnnotations;

namespace Student_System.Data.Models
{
    public class StudentsCourses
    {
        [Key]
        public Guid StudentId { get; set; }
        public Students Student { get; set; } = new();


        [Key]
        public Guid CourseId { get; set; }
        public Courses Course { get; set; } = new();
    }
}
