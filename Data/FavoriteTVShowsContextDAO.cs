using IT3045C_Final_Project.Interfaces;
using IT3045C_Final_Project.Models;

namespace IT3045C_Final_Project.Data
{
    public class FavoriteTVShowsContextDAO : IFavoriteTVSHowsContextDAO
    {
        private FavoriteTVShowsContext _context;

        public FavoriteTVShowsContextDAO(FavoriteTVShowsContext context)
        {
            _context = context;
        }

        public List<FavoriteTVShow> GetAllFavoriteTVShows()
        {
            return _context.FavoriteTVShows.ToList();
        }
    }
}
