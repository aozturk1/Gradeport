using System.ComponentModel.DataAnnotations;

namespace SDMS.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        public string? Email { get; set; }

        public ICollection<Course>? Courses { get; set; }
    }
}
