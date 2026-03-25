using Microsoft.AspNetCore.Mvc;
using PantryProApi.Models;
using System.Linq;
using System.Threading.Tasks;

namespace PantryProApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LocationController : ControllerBase
    {
        private readonly PantryContext _context;

        public LocationController(PantryContext context)
        {
            _context = context;
        }

        // GET: api/Location
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_context.Locations.ToList());
        }
    }
}
