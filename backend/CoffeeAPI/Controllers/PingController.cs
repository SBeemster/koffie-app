using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PingController : ControllerBase
    {
        // GET: api/ping/user
        [HttpGet("user")]
        [Authorize(Roles = "User")]
        public string PingUser()
        {
            return "Pong";
        }

        // GET: api/ping/manager
        [HttpGet("manager")]
        [Authorize(Roles = "Manager")]
        public string PingManager()
        {
            return "Pong";
        }

        // GET: api/ping/admin
        [HttpGet("admin")]
        [Authorize(Roles = "Admin")]
        public string PingAdmin()
        {
            return "Pong";
        }
    }
}