using CoffeeAPI.Helpers;
using CoffeeAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController, Authorize]
    public class UsersController : ControllerBase
    {
        private readonly CoffeeContext _context;

        public UsersController(CoffeeContext context)
        {
            _context = context;
        }

        // GET: api/Users
        [HttpGet]
        public IEnumerable<object> GetUsers()
        {
            return _context.Users.Select(u => new {
                firstName = u.FirstName,
                lastName = u.LastName,
                userId = u.UserId
            }).ToList();
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser([FromRoute] Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = await _context.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        // PUT: api/Users/5
        [HttpPut("{id}"), Authorize(Roles = "Admin")]
        public async Task<IActionResult> PutUser([FromRoute] Guid id, [FromBody] User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != user.UserId)
            {
                return BadRequest();
            }

            _context.Entry(user).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
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

        // POST: api/Users
        [HttpPost, Authorize(Roles = "Admin")]
        public async Task<IActionResult> PostUser([FromBody] NewUser newUser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = new User
            {
                UserId = Guid.NewGuid(),
                FirstName = newUser.FirstName,
                LastName = newUser.LastName,
                Active = true
            };

            var salt = AuthHelper.GetRandom();
            var passBytes = Encoding.UTF8.GetBytes(newUser.Password);
            var login = new Login
            {
                LoginId = Guid.NewGuid(),
                User = user,
                UserName = newUser.UserName,
                PasswordSalt = salt,
                PasswordHash = AuthHelper.GenerateSaltedHash(passBytes, salt)
            };
            var list = newUser.UserRoles.ToArray();
            for(int i=0; i < list.Length; i++)
            {
                var role = _context.Roles.Single(r => r.RoleName == list[i].Role.RoleName);
                var userRole = new UserRole
                {
                    User = user,
                    Role = role
                };
                _context.UserRoles.Add(userRole);
            }
            
           

            var preference = new DrinkPreference
            {
                PreferenceId = Guid.NewGuid(),
                User = user
            };

            _context.Users.Add(user);
            _context.Logins.Add(login);
            
            _context.DrinkPreference.Add(preference);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUser", new { id = user.UserId }, user);
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}"), Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteUser([FromRoute] Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return Ok(user);
        }

        private bool UserExists(Guid id)
        {
            return _context.Users.Any(e => e.UserId == id);
        }
    }
}