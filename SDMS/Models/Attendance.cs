namespace SDMS.Models
{
    public class Attendance
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student? Student { get; set; }

        public int ClassId { get; set; }
        public Course? Course { get; set; }

        public DateTime Date { get; set; }
        public string? Status { get; set; }
    }

    public enum AttendanceEnum
    {
        Present,
        Absent,
        Late
    }
}
