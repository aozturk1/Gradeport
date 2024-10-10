using System.ComponentModel.DataAnnotations;

namespace SDMS.Models
{
    public class Assignment
    {
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public DateTime DueDate { get; set; }
        [Required]
        public int TotalPoints { get; set; }

        public int ClassId { get; set; }
        public Course? Class { get; set; }
        public ICollection<Grade>? Grades { get; set; }
    }
}
