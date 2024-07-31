using IT3045C_Final_Project.Data;
using IT3045C_Final_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IT3045C_Final_Project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FavoriteTVShowsController : ControllerBase
    {
        private static readonly int id;

        private readonly ILogger<FavoriteTVShowsController> _logger;
        private readonly FavoriteTVShowsContextDAO _context;

        public FavoriteTVShowsController(ILogger<FavoriteTVShowsController> logger, FavoriteTVShowsContextDAO context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet(Name = "FavoriteTVShows")]
        public IActionResult GetAllFavoriteTVShows()
        {
            return Ok(_context.GetAllFavoriteTVShows());
        }
    }
}
