using System.ComponentModel.DataAnnotations;

namespace IT3045C_Final_Project.Models
{
    public class TVShow
    {
        [Key]
        public int ID { get; set; }

        public string ShowName { get; set; }

        public string Genre { get; set; }

        public int NumSeasons { get; set; }

        public DateOnly ReleaseDate { get; set; }
    }
}
