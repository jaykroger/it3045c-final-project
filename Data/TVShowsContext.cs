using IT3045C_Final_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace IT3045C_Final_Project.Data
{
    public class TVShowsContext : DbContext
    {

        public TVShowsContext(DbContextOptions<TVShowsContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TVShow>().HasData(
                new TVShow { ID = 1, ShowName = "Succession", Genre = "Drama", NumSeasons = 4, ReleaseDate = new DateOnly(2018, 6, 3) },
                new TVShow { ID = 2, ShowName = "Mr. Robot", Genre = "Crime", NumSeasons = 4, ReleaseDate = new DateOnly(2015, 6, 24) }
                );
        }

        public DbSet<TVShow> TVShows { get; set; }
    }
}
    