﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoffeeAPI.Models
{
    public class User
    {
        public int UserId { get; set; }

        [Required]
        public string UserName { get; set; }
        [Required]
        public string Salt { get; set; }
        [Required]
        public string Password { get; set; }

        public Drink Prefrence { get; set; }
        public ICollection<UserGroup> UserGroups { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }

        [InverseProperty("Customer")]
        public ICollection<OrderLine> OrderLinesOrdered { get; set; }
        [InverseProperty("Server")]
        public ICollection<OrderLine> OrderLinesServed { get; set; }
    }
}
