using CoffeeAPI.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CoffeeAPI.Models;
using System.Text;

namespace CoffeeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly CoffeeContext _context;

        public LoginController(CoffeeContext context)
        {
            _context = context;
        }

        // GET: api/Login
        [HttpGet]
        public IEnumerable<Login> GetLogins()
        {
            return _context.Logins;
        }

        // GET: api/Login/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetLogin([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var login = await _context.Logins.FindAsync(id);

            if (login == null)
            {
                return NotFound();
            }

            return Ok(login);
        }

        // PUT: api/Login/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLogin([FromRoute] int id, [FromBody] Login login)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != login.LoginId)
            {
                return BadRequest();
            }

            _context.Entry(login).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LoginExists(id))
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

        // POST: api/Login
        [HttpPost]
        public IActionResult PostLogin([FromBody] LoginAttempt loginAttempt)
        {
            Login credentials;
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // fetch username from logins table
            try
            {
                credentials = _context.Logins.Single(login => login.UserName == loginAttempt.UserName);
            }
            catch
            {
                // unknown username
                return Unauthorized();
            }

            // check supplied password with saved salt against saved password
            var attemptPassword = Encoding.UTF8.GetBytes(loginAttempt.Password);
            var savedPasswordSalt = credentials.PasswordSalt;
            var attemptPasswordHash = AuthenticationHelper.GenerateSaltedHash(attemptPassword, savedPasswordSalt);
            var savedPasswordHash = credentials.PasswordHash;
            if (!AuthenticationHelper.Authenticate(attemptPasswordHash, savedPasswordHash))
            {
                // wrong password
                return Unauthorized();
            }

            // fetch a new jwt
            var token = AuthenticationHelper.SecurityToken(credentials.User.UserId, credentials.UserName);
            var result = Ok(token);

            return result;
        }

        // DELETE: api/Login/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLogin([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var login = await _context.Logins.FindAsync(id);
            if (login == null)
            {
                return NotFound();
            }

            _context.Logins.Remove(login);
            await _context.SaveChangesAsync();

            return Ok(login);
        }

        private bool LoginExists(int id)
        {
            return _context.Logins.Any(e => e.LoginId == id);
        }
    }
}