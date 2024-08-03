using IT3045C_Final_Project.Data;
using IT3045C_Final_Project.Interfaces;
using IT3045C_Final_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT3045C_Final_Project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FavoriteFoodsController : ControllerBase
    {
        private static readonly int id;

        private readonly ILogger<FavoriteFoodsController> _logger;

        private readonly FoodsContextDAO _context;

        public FavoriteFoodsController(ILogger<FavoriteFoodsController> logger, FoodsContextDAO context)
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

            var food = _context.GetFoodById(id);
            if (food == null)
            {
                return NotFound(id);
            }


            return Ok(food);
        }

        //delete function
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var result = _context.RemoveFoodById(id);

            if (result == null)
            {
                return NotFound(id);
            }

            if (result == 0)
            {
                return StatusCode(500, "An error occured");
            }

            return Ok();

        }

        //update
        [HttpPut]

        public IActionResult Put(FavoriteFoods personsFood)
        {
            var result = _context.UpdateFood(personsFood);

            if (result == null)
            {
                return NotFound(personsFood.Id);
            }

            if (result == 0)
            {
                return StatusCode(500, "An error occured");
            }

            return Ok();
        }


        [HttpPost]
        public IActionResult Post(FavoriteFoods personsFood)
        {
            var results = _context.AddFood(personsFood);

            if (results == null)
            {
                return StatusCode(500, "Food already Exist.");

            }

            if (results == 0)
            {
                return StatusCode(500, "An error occured");
            }

            return Ok();
        }
        
    }

}
