using IT3045C_Final_Project.Data;
using IT3045C_Final_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT3045C_Final_Project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FavortieFoodsController : ControllerBase
    {
        private readonly ILogger<FavortieFoodsController> _logger;

        private readonly FavoriteFoodsContext _context;

        public FavortieFoodsController(ILogger<FavortieFoodsController> logger, FavoriteFoodsContext context)
        {
            _logger = logger;
            _context = context;

        }

        [HttpGet]
        public IActionResult Get() 
        {
            return Ok(_context.FavoriteFoods.ToList());
        }

        [HttpGet("id")]
        public IActionResult GetById(int? id)
        {
            return Ok(_context.FavoriteFoods.FirstOrDefault(x => x.Id == id));
        }
    }

}
