using System;
using System.ComponentModel.DataAnnotations;

namespace CoffeeAPI.Models
{
    public class Login
    {
        public Guid LoginId { get; set; }

        [Required]
        public string UserName { get; set; }
        [Required]
        public byte[] PasswordSalt { get; set; }
        [Required]
        public byte[] PasswordHash { get; set; }

        public User User { get; set; }
    }
}
