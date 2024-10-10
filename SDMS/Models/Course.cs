using System.ComponentModel.DataAnnotations;

namespace SDMS.Models
{
    public class Course
    {
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public int Credits { get; set; }
        [Required]
        public Teacher? Teacher { get; set; }

        public ICollection<Student>? Students { get; set; }
        public ICollection<Assignment>? Assignments { get; set; }
        public ICollection<Attendance>? Attendances { get; set; }
    }
}
