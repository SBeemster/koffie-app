using CoffeeAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController, Authorize]
    public class DrinksController : ControllerBase
    {
        private readonly CoffeeContext _context;

        public DrinksController(CoffeeContext context)
        {
            _context = context;
        }

        // GET: api/Drinks
        [HttpGet]
        public IEnumerable<Drink> GetDrinks(bool? available)
        {
            switch (available)
            {
                case true:
                    return _context.Drinks.Where(d => d.Available == true);
                case false:
                    return _context.Drinks.Where(d => d.Available == false);
            }
            return _context.Drinks;
        }

        // GET: api/Drinks/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDrink([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var drink = await _context.Drinks.FindAsync(id);

            if (drink == null)
            {
                return NotFound();
            }

            return Ok(drink);
        }

        // PUT: api/Drinks/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDrink([FromRoute] int id, [FromBody] Drink drink)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (!drink.DrinkId.Equals(id))
            {
                return BadRequest();
            }

            _context.Entry(drink).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DrinkExists(id))
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

        // POST: api/Drinks
        [HttpPost]
        public async Task<IActionResult> PostDrink([FromBody] Drink drink)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Drinks.Add(drink);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDrink", new { id = drink.DrinkId }, drink);
        }

        // DELETE: api/Drinks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDrink([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var drink = await _context.Drinks.FindAsync(id);
            if (drink == null)
            {
                return NotFound();
            }

            _context.Drinks.Remove(drink);
            await _context.SaveChangesAsync();

            return Ok(drink);
        }

        private bool DrinkExists(int id)
        {
            return _context.Drinks.Any(e => e.DrinkId.Equals(id));
        }
    }
}