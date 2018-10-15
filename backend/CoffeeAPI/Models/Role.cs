using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoffeeAPI.Models
{
    public class Role
    {
        public int RoleId { get; set; }
        [Required]
        public string RoleName { get; set; }

        public ICollection<UserRole> UserRoles { get; set; }
    }
}
