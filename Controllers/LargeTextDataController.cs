using Microsoft.AspNetCore.Mvc;
using PantryProApi.Models;
using System.Linq;
using System.Threading.Tasks;

namespace PantryProApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LargeTextDataController : ControllerBase
    {
        private readonly PantryContext _context;

        public LargeTextDataController(PantryContext context)
        {
            _context = context;
        }

        // GET: api/LargeTextData
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_context.LargeTextData.ToList());
        }

        // GET: api/LargeTextData/{id}
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var item = _context.LargeTextData.Find(id);
            if (item == null) return NotFound();
            return Ok(item);
        }

        // POST: api/LargeTextData
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] LargeTextData data)
        {
            if (data == null || string.IsNullOrEmpty(data.Data))
                return BadRequest();
            _context.LargeTextData.Add(data);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = data.Id }, data);
        }

        // DELETE: api/LargeTextData/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var item = await _context.LargeTextData.FindAsync(id);
            if (item == null) return NotFound();
            _context.LargeTextData.Remove(item);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        // PUT: api/LargeTextData/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] LargeTextData data)
        {
            if (data == null || string.IsNullOrEmpty(data.Data) || id != data.Id)
                return BadRequest();
            var existing = await _context.LargeTextData.FindAsync(id);
            if (existing == null) return NotFound();
            existing.Data = data.Data;
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }

}
