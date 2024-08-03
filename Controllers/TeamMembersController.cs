using IT3045C_Final_Project.Data;
using IT3045C_Final_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace IT3045C_Final_Project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeamMembersController : ControllerBase
    {

        private readonly ILogger<TeamMembersController> _logger;
        ITeamMembersContextDAO _context;

        public TeamMembersController(ILogger<TeamMembersController> logger, ITeamMembersContextDAO context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult GetInfo()
        {
            return Ok(_context.GetAllInfo());
        }

        [HttpGet]
        [Route("id")]
        public IActionResult GetInfo(int ID)
        {
            var result = _context.GetInfoById(ID);

            if (result == null)
            {
                return Ok(_context.GetAllInfo().Take(5));
            }
            return Ok(_context.GetInfoById(ID));
        }

        [HttpPost]

        public IActionResult PostFood(TeamMember i)
        {
            var result = _context.AddInfo(i);
            if (result == null)
            {
                return StatusCode(500, "An item with this ID already exists");
            }
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            return Ok();
        }

        [HttpPut]
        [Route("api/UpdateInfo")]
        public IActionResult PutFood(TeamMember i)
        {
            var result = _context.UpdateInfo(i);
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            return Ok();
        }

        [HttpDelete]

        public IActionResult DeleteInfo(int ID)
        {
            var data = _context.GetInfoById(ID);
            if (data == null)
            {
                return NotFound(ID);
            }
            var result = _context.RemoveInfoById(ID);
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            return Ok();
        }

    }
}