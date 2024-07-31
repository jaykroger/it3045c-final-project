using IT3045C_Final_Project.Data;
using IT3045C_Final_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT3045C_Final_Project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CourseEnrollmentsController : ControllerBase
    {
        private static readonly int id;

        private readonly ILogger<CourseEnrollmentsController> _logger;
        private readonly CourseEnrollmentsContextDAO _context;

        public CourseEnrollmentsController(ILogger<CourseEnrollmentsController> logger, CourseEnrollmentsContextDAO context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet(Name = "CourseEnrollments")]
        public IActionResult Get()
        {
            return Ok(_context.GetAllCourseEnrollments());
        }
    }
}
