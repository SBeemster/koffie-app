using CoffeeAPI.Helpers;
using CoffeeAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
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

        // POST: api/Login
        [HttpPost]
        public IActionResult PostLogin([FromBody] LoginAttempt loginAttempt)
        {
            Login login;
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // fetch username from logins table
            try
            {
                login = _context.Logins
                    .Include(l => l.User)
                    .Where(l => l.UserName == loginAttempt.UserName)
                    .Single();
            }
            catch
            {
                // unknown username
                return Unauthorized();
            }

            // check supplied password with saved salt against saved password
            var attemptPassword = Encoding.UTF8.GetBytes(loginAttempt.Password);
            var savedPasswordSalt = login.PasswordSalt;
            var attemptPasswordHash = AuthHelper.GenerateSaltedHash(attemptPassword, savedPasswordSalt);
            var savedPasswordHash = login.PasswordHash;
            if (!AuthHelper.Authenticate(attemptPasswordHash, savedPasswordHash) || !login.User.Active)
            {
                // wrong password or user archived
                return Unauthorized();
            }

            // gather refrences
            var roles = _context.UserRoles
                .Include(ur => ur.User)
                .Include(ur => ur.Role)
                .Where(ur => ur.User == login.User)
                .Select(ur => ur.Role)
                .ToList();

            // compile user claims
            var tokenClaims = new ClaimsIdentity();
            tokenClaims.AddClaim(new Claim(ClaimTypes.NameIdentifier, login.User.UserId.ToString()));
            tokenClaims.AddClaim(new Claim(ClaimTypes.Name, login.UserName));
            foreach (var roleName in roles.Select(r => r.RoleName))
            {
                tokenClaims.AddClaim(new Claim(ClaimTypes.Role, roleName));
            }

            // create a new jwt
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = new SymmetricSecurityKey(AuthHelper.SecurityKey);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Issuer = "https://jorisvdinther.nl",
                Expires = DateTime.UtcNow.AddDays(7),
                Subject = tokenClaims,
                SigningCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);

            return Ok(new { idToken = tokenHandler.WriteToken(token) });
        }
    }
}