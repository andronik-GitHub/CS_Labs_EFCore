using Microsoft.EntityFrameworkCore;
using Student_System.Data.Models.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student_System.Data.Models
{
    public class Resources
    {
        [Key]
        public Guid ResourceId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = default!;
        [Required]
        [Unicode(false)]
        public string Url { get; set; } = default!;
        [Required]
        public ResourceTypes ResourceType { get; set; }


        public Guid CourseId { get; set; } // FK
        public Courses Course { get; set; } = new();
    }
}
