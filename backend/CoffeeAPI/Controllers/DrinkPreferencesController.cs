using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CoffeeAPI.Models;
using Microsoft.AspNetCore.Authorization;

namespace CoffeeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController, Authorize]
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

        // GET: api/DrinkPreferences/ByUserID/5

        [HttpGet]
        [Route("byuserid/{userId}")]
        public IActionResult GetUserPreference([FromRoute] Guid userId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            User user = _context.Users
              .Where(l => l.UserId == userId)
              .Single();
            var drinkPreference = _context.DrinkPreference
              .Where(l => l.User.UserId == userId)
              .Include(d => d.Drink)
              .Single();
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

            if (id != drinkPreference.PreferenceId)
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
            User user = _context.Users
               .Where(l => l.UserId == drinkPreference.User.UserId)
               .Single();

            Drink drink = _context.Drinks
               .Where(l => l.DrinkId == drinkPreference.Drink.DrinkId)
               .Single();

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var newDrinkPreference = new DrinkPreference
            {
                PreferenceId = Guid.NewGuid(),
                User = user,
                Drink = drink,
                Milk = drinkPreference.Milk,
                Sugar = drinkPreference.Sugar
            };

            _context.DrinkPreference.Add(newDrinkPreference);
            await _context.SaveChangesAsync();

            return Ok(newDrinkPreference);
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
            return _context.DrinkPreference.Any(e => e.PreferenceId == id);
        }
    }
}