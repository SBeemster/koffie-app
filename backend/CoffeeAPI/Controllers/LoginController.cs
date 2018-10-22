using CoffeeAPI.Helpers;
using CoffeeAPI.Models;
using Microsoft.AspNetCore.Mvc;
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
            var attemptPasswordHash = AuthHelper.GenerateSaltedHash(attemptPassword, savedPasswordSalt);
            var savedPasswordHash = credentials.PasswordHash;
            if (!AuthHelper.Authenticate(attemptPasswordHash, savedPasswordHash))
            {
                // wrong password
                return Unauthorized();
            }

            // create a new jwt
            var fingerPrint = Encoding.UTF8.GetString(AuthHelper.GetRandom());
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = new SymmetricSecurityKey(AuthHelper.SecurityKey);
            var user = _context.Entry(credentials).Reference(login => login.User);
            user.Load();
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Issuer = "https://jorisvdinther.nl",
                Expires = DateTime.UtcNow.AddDays(7),
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.NameIdentifier, user.CurrentValue.UserId.ToString())
                }),
                SigningCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);

            return Ok(new { idToken = tokenHandler.WriteToken(token) });
        }
    }
}