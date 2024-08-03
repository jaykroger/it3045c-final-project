using IT3045C_Final_Project.Data;
using IT3045C_Final_Project.Interfaces;
using IT3045C_Final_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT3045C_Final_Project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FavortieFoodsController : ControllerBase
    {
        private readonly ILogger<FavortieFoodsController> _logger;

        private readonly IFoodsContextDAO _context;

        public FavortieFoodsController(ILogger<FavortieFoodsController> logger, IFoodsContextDAO context)
        {
            _logger = logger;
            _context = context;

        }

        [HttpGet]
        public IActionResult Get() 
        {
            return Ok(_context.GetAllFoods());
        }

        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            var food = _context.GetFoodsById(id);

            if (food == null)
            {
                return NotFound(id);
            }
                
            return Ok(_context.GetFoodsById(id));
        }

        [HttpDelete("id")]
        public IActionResult Delete(int id)
        {
           
            var food = _context.RemoveFoodById(id);
            if (food == null)
            {
                return NotFound(id);
            }

            return Ok();

            

        }
    }

}
