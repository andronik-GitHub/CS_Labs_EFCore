using Microsoft.EntityFrameworkCore;
using Student_System.Data.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace Student_System.Data.Models
{
    public class Homework
    {
        [Key]
        public Guid HomeworkId { get; set; }
        [Required]
        [Unicode(false)]
        public string Content { get; set; } = default!;
        [Required]
        public ContentTypes ContentType { get; set; }
        [Required]
        public DateTime SubmissionTime { get; set; }


        public Guid StudentId { get; set; } // FK
        public Students Student { get; set; } = new();
        public Guid CourseId { get; set; } // FK
        public Courses Course { get; set; } = new();
    }
}
