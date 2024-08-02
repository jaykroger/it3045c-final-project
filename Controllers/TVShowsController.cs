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
        private readonly TVShowsContextDAO _context;

        public FavoriteTVShowsController(ILogger<FavoriteTVShowsController> logger, TVShowsContextDAO context)
        {
            _logger = logger;
            _context = context;
        }





        [HttpGet]
        public IActionResult Get()
        {
            var tvShows = _context.GetAllTVShows();

            return Ok(tvShows);
        }



        [HttpGet("id")]
        public IActionResult GetByID(int id)
        {
            var tvShow = _context.GetTVShowByID(id);
            if (tvShow == null)
            {
                return NotFound(id);
            }

            return Ok(tvShow);
        }



        [HttpPost]
        public IActionResult Post(TVShow tvShow)
        {
            var result = _context.AddTVShow(tvShow);

            if (result == null)
            {
                return StatusCode(500, "TV Show already exists.");
            }
            if (result == 0)
            {
                return StatusCode(500, "A server error occurred.");
            }

            return Ok();
        }



        [HttpPut]
        public IActionResult Put(TVShow tvShow)
        {
            var result = _context.UpdateTVShow(tvShow);
            if (result == null)
            {
                return NotFound(tvShow.ID);
            }

            if (result == 0)
            {
                return StatusCode(500, "A server error occurred.");
            }

            return Ok();
        }



        [HttpDelete("id")]
        public IActionResult Delete(int id) 
        {
            var result = _context.RemoveTVShowByID(id);

            if (result == null)
            {
                return NotFound(id);
            }

            if (result == 0)
            {
                return StatusCode(500, "A server error occurred.");
            }

            return Ok();
        }
    }
}
