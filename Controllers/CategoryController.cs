using Microsoft.AspNetCore.Mvc;
using PantryProApi.Models;
using System.Linq;
using System.Threading.Tasks;

namespace PantryProApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly PantryContext _context;

        public CategoryController(PantryContext context)
        {
            _context = context;
        }

        // GET: api/Category
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_context.Categories.ToList());
        }
    }
}
