using IT3045C_Final_Project.Interfaces;
using IT3045C_Final_Project.Models;

namespace IT3045C_Final_Project.Data
{
    public class TVShowsContextDAO : ITVShowsContextDAO
    {
        private TVShowsContext _context;

        public TVShowsContextDAO(TVShowsContext context)
        {
            _context = context;
        }





        // Reads all records from the database
        public List<TVShow> GetAllTVShows()
        {
            return _context.TVShows.OrderBy(x => x.ID).ToList();
        }



        // Read records from the database based on a given ID
        public List<TVShow> GetTVShowByID(int? id)
        {
            if (id == null || id == 0)
            {
                return _context.TVShows.OrderBy(x => x.ID).Take(5).ToList();
            } else
            {
                return _context.TVShows.Where(x => x.ID == id).ToList();
            }
        }



        // Create a new record in the database
        public int? AddTVShow(TVShow tvShow)
        {
            var tvShows = _context.TVShows.Where(x => x.ID.Equals(tvShow.ID) && x.ShowName.Equals(tvShow.ShowName)).FirstOrDefault();

            if (tvShows != null)
            {
                return null;
            }

            try
            {
                _context.TVShows.Add(tvShow);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }



        // Update an existing record in the database
        public int? UpdateTVShow(TVShow tvShow)
        {
            var existingTVShow = _context.TVShows.Find(tvShow.ID);

            if (existingTVShow == null) 
            {
                return null; // If record not found in database, return null
            }

            // Update the record with new data
            existingTVShow.ShowName = tvShow.ShowName;
            existingTVShow.Genre = tvShow.Genre;
            existingTVShow.NumSeasons = tvShow.NumSeasons;
            existingTVShow.ReleaseDate = tvShow.ReleaseDate;

            try
            {
                _context.TVShows.Update(existingTVShow);
                _context.SaveChanges();
                return 1; // If successfully updated, return 1
            }
            catch (Exception) 
            {
                return 0; // If error in updating record, return 0
            }
        }



        // Remove a record from the database based on a given ID
        public int? RemoveTVShowByID(int id)
        {
            var tvShow = _context.TVShows.Find(id);
            if (tvShow == null)
            {
                return null; // If record not found in database, return null
            }
            try
            {
                _context.TVShows.Remove(tvShow);
                _context.SaveChanges();
                return 1; // If successfully removed, return 1
            }
            catch (Exception)
            {
                return 0; // If an error occurred during removal, return 0
            }
        }

    }
}
