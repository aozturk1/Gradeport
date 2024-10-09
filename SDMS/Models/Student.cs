using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;

namespace SDMS.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }

        //public string? StudentPicturePath { get; set; }

        public DateTime EnrollmentDate { get; set; }
        public ICollection<Enrollment>? Enrollments { get; set; }

    }
}
