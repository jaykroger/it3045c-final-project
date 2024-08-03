using IT3045C_Final_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace IT3045C_Final_Project.Data
{
    public class CoursesContext : DbContext
    {

        public CoursesContext(DbContextOptions<CoursesContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().HasData(
                new Course { ID = 1, CourseNumber = "IT3045C", CourseName = "Contemporary Programming", Track = "Software Application Development", CreditHours = 3 },
                new Course { ID = 2, CourseNumber = "IT3071C", CourseName = "Network Security", Track = "Cybersecurity", CreditHours = 3 }
                );
        }

        public DbSet<Course> Courses { get; set; }
    }
}
