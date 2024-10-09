using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using SDMS.Models;

namespace SDMS.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Student>()
                .Property(x => x.Id) // Configure the Id property
                .ValueGeneratedOnAdd();

            builder.Entity<Student>()
                .Property(x => x.EnrollmentDate)
                .HasDefaultValueSql("GETDATE()"); // Set default value for EnrollmentDate
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public object Studnets { get; internal set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
