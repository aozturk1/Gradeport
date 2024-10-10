using System.ComponentModel.DataAnnotations;

namespace SDMS.Models
{
    public class Grade
    {
        public int Id { get; set; }
        [Required]
        public int StudentId { get; set; }
        public Student? Student { get; set; }
        public int AssignmentId { get; set; }
        public Assignment? Assignment { get; set; }
        public int Score { get; set; }
        public GradeEnum GradeLetter { get; set; }
    }

    public enum GradeEnum
    {
        A, B, C, D, E, F
    }
}
