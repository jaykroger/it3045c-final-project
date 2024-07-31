using IT3045C_Final_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace IT3045C_Final_Project.Data
{
    public class FavoriteTVShowsContext : DbContext
    {

        public FavoriteTVShowsContext(DbContextOptions<FavoriteTVShowsContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FavoriteTVShow>().HasData(
                new FavoriteTVShow { StudentID = 14981719, ShowName = "Succession", Genre = "Drama", NumSeasons = 4, ReleaseDate = new DateOnly(2018, 6, 3) },
                new FavoriteTVShow { StudentID = 14981720, ShowName = "Mr. Robot", Genre = "Crime", NumSeasons = 4, ReleaseDate = new DateOnly(2015, 6, 24) }
                );
        }

        public DbSet<FavoriteTVShow> FavoriteTVShows { get; set; }
    }
}
    