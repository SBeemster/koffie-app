using System;

namespace CoffeeAPI.Models
{
    public class UserRole
    {
        public Guid UserRoleId { get; set; }
        public User User { get; set; }
        public Role Role { get; set; }
    }
}
