using IT3045C_Final_Project.Models;

namespace IT3045C_Final_Project.Interfaces
{
    public interface ITVShowsContextDAO
    {
        // CRUD operations for FavoriteTVShows

        // Create
        int? AddTVShow(TVShow tvShow);

        // Read
        List<TVShow> GetTVShowByID(int? id);

        // Update
        int? UpdateTVShow(TVShow tvShow);

        // Delete
        int? RemoveTVShowByID(int id);
    }
}
