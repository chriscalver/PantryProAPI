using PantryProApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace PantryProApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PantryController : ControllerBase
    {
        private readonly PantryContext _dbContext;

        public PantryController(PantryContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]

        public async Task<ActionResult<IEnumerable<Pantry>>> GetPantries()
        {
            if (_dbContext.Pantries == null)
            {
                return NotFound();
            }
            return await _dbContext.Pantries.ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Pantry>> GetPantry(int id)
        {
            if (_dbContext.Pantries == null)
            {
                return NotFound();
            }
            var pantry = await _dbContext.Pantries.FindAsync(id);
            if (pantry == null)
            {
                return NotFound();
            }
            return pantry;
        }

        [HttpPost]
        public async Task<ActionResult<Pantry>> PostPantry(Pantry pantry)
        {
            _dbContext.Pantries.Add(pantry);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPantry), new { id = pantry.ID }, pantry);
        }

        [HttpPut]
        public async Task<IActionResult> PutPantry(int id, Pantry pantry)
        {
            if (id != pantry.ID)
            {
                return BadRequest();
            }
            _dbContext.Entry(pantry).State = EntityState.Modified;

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PantryAvailable(id))
                {
                    return NotFound();

                }
                else
                {
                    throw;
                }
            }
            return Ok();
        }
        private bool PantryAvailable(int id)
        {
            return (_dbContext.Pantries?.Any(x => x.ID == id)).GetValueOrDefault();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePantry(int id)
        {
            if (_dbContext.Pantries == null)
            {
                return NotFound();
            }
            var pantry = await _dbContext.Pantries.FindAsync(id);
            if (pantry == null)
            {
                return NotFound();
            }
            _dbContext.Pantries.Remove(pantry);
            await _dbContext.SaveChangesAsync();
            return Ok(pantry);
        }

    }
}
