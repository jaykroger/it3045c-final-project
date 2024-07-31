using System.ComponentModel.DataAnnotations;

namespace IT3045C_Final_Project.Models
{
    public class FavoriteTVShow
    {
        [Key]
        public int? StudentID { get; set; }

        public string? ShowName { get; set; }

        public string? Genre { get; set; }

        public int? NumSeasons { get; set; }

        public DateOnly ReleaseDate { get; set; }
    }
}
