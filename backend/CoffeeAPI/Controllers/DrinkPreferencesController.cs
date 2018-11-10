using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CoffeeAPI.Models;

namespace CoffeeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DrinkPreferencesController : ControllerBase
    {
        private readonly CoffeeContext _context;

        public DrinkPreferencesController(CoffeeContext context)
        {
            _context = context;
        }

        // GET: api/DrinkPreferences
        [HttpGet]
        public IEnumerable<DrinkPreference> GetDrinkPreference()
        {
            return _context.DrinkPreference;
        }

        // GET: api/DrinkPreferences/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDrinkPreference([FromRoute] Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var drinkPreference = await _context.DrinkPreference.FindAsync(id);

            if (drinkPreference == null)
            {
                return NotFound();
            }

            return Ok(drinkPreference);
        }

        // PUT: api/DrinkPreferences/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDrinkPreference([FromRoute] Guid id, [FromBody] DrinkPreference drinkPreference)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != drinkPreference.Preferenceid)
            {
                return BadRequest();
            }

            _context.Entry(drinkPreference).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DrinkPreferenceExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/DrinkPreferences
        [HttpPost]
        public async Task<IActionResult> PostDrinkPreference([FromBody] DrinkPreference drinkPreference)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.DrinkPreference.Add(drinkPreference);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDrinkPreference", new { id = drinkPreference.Preferenceid }, drinkPreference);
        }

        // DELETE: api/DrinkPreferences/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDrinkPreference([FromRoute] Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var drinkPreference = await _context.DrinkPreference.FindAsync(id);
            if (drinkPreference == null)
            {
                return NotFound();
            }

            _context.DrinkPreference.Remove(drinkPreference);
            await _context.SaveChangesAsync();

            return Ok(drinkPreference);
        }

        private bool DrinkPreferenceExists(Guid id)
        {
            return _context.DrinkPreference.Any(e => e.Preferenceid == id);
        }
    }
}