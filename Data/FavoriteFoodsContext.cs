using IT3045C_Final_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace IT3045C_Final_Project.Data
{
    public class FavoriteFoodsContext : DbContext
    {
        public FavoriteFoodsContext(DbContextOptions<FavoriteFoodsContext> options) : base(options) { }

        //seed table with info
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<FavoriteFoods>().HasData(
                new FavoriteFoods { Id = 14969824, FavBreakfast = "Waffles", FavLunch = "PBJ", FavSnack = "Apple slices", FavDinner = "Pasta" },
                new FavoriteFoods { Id = 12345678, FavBreakfast = "Toast", FavLunch = "BLT", FavSnack = "Chips", FavDinner = "Hamburgers" });
        }

        public DbSet<FavoriteFoods> FavoriteFood { get; set; }
    }
}
