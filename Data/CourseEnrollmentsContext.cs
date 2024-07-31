using Microsoft.EntityFrameworkCore;

namespace IT3045C_Final_Project.Data
{
   public class CourseEnrollmentsContext : DbContext
   {

        public CourseEnrollmentsContext(DbContextOptions<CourseEnrollmentsContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CourseEnrollment>().HasData(
                new CourseEnrollment {StudentID = 14981719, CourseNumber = "IT3045C", CourseName= "Contemporary Programming", Track= "Software Application Development", CreditHours = 3},
                new CourseEnrollment { StudentID = 14981720, CourseNumber = "IT3071C", CourseName = "Network Security", Track = "Cybersecurity", CreditHours = 3}
               );
        }

        public DbSet<CourseEnrollment> CourseEnrollments { get; set; }
    }
    
}
