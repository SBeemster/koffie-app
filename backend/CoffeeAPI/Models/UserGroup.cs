using System;
using System.ComponentModel.DataAnnotations;

namespace CoffeeAPI.Models
{
    public class UserGroup
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        public Guid GroupId { get; set; }
        public Group Group { get; set; }
    }
}
