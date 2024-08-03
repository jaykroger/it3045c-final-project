using IT3045C_Final_Project.Data;
using IT3045C_Final_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT3045C_Final_Project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoursesController : ControllerBase
    {
        private static readonly int id;

        private readonly ILogger<CoursesController> _logger;
        private readonly CoursesContextDAO _context;

        public CoursesController(ILogger<CoursesController> logger, CoursesContextDAO context)
        {
            _logger = logger;
            _context = context;
        }





        [HttpGet]
        public IActionResult Get()
        {
            var courses = _context.GetAllCourses();
            return Ok(courses);
        }



        [HttpGet("id")]
        public IActionResult GetByID(int id)
        {
            var course = _context.GetCourseByID(id);
            if (course == null)
            {
                return NotFound(id);
            }

            return Ok(course);
        }



        [HttpPost]
        public IActionResult Post(Course course)
        {
            var result = _context.AddCourse(course);

            if (result == null)
            {
                return StatusCode(500, "Course already exists.");
            }
            if (result == 0)
            {
                return StatusCode(500, "A server error occurred.");
            }

            return Ok();
        }



        [HttpPut]
        public IActionResult Put(Course course)
        {
            var result = _context.UpdateCourse(course);
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



        [HttpDelete("id")]
        public IActionResult Delete(int id)
        {
            var result = _context.RemoveCourseByID(id);
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
