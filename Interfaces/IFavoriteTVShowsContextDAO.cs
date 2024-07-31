using IT3045C_Final_Project.Models;

namespace IT3045C_Final_Project.Interfaces
{
    public interface IFavoriteTVSHowsContextDAO
    {
        // CRUD operations for FavoriteTVShows
        List<FavoriteTVShow> GetAllFavoriteTVShows();
    }
}
