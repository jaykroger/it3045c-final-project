using IT3045C_Final_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace IT3045C_Final_Project.Data
{
    public class TeamMembersContext : DbContext
    {
        public TeamMembersContext(DbContextOptions<TeamMembersContext> options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<TeamMember>().HasData(
                new TeamMember {Id = 1, FullName = "Bella Orr", Birthdate = new DateTime(2003, 10, 11), CollegeProgram = "Computer Science", YearInProgram = "Sophomore" },
                new TeamMember { Id = 2, FullName = "Marko Nisiama", Birthdate = new DateTime(2001, 6, 24), CollegeProgram = "Information Technology", YearInProgram = "Junior" }, 
                new TeamMember { Id = 3, FullName = "Jay Kroger", Birthdate = new DateTime(2004, 12, 6), CollegeProgram = "Information Technology (Software Development) / Cybersecurity", YearInProgram = "Pre-junior" }
                );
        }

        public DbSet<TeamMember> TeamMembers { get; set; }
    }
}
