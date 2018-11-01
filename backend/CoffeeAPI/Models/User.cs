using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoffeeAPI.Models
{
    public class User
    {
        public Guid UserId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Drink Prefrence { get; set; }
        public bool Active { get; set; }
        public ICollection<UserGroup> UserGroups { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }

        [InverseProperty("Customer")]
        public ICollection<OrderLine> OrderLinesOrdered { get; set; }
        [InverseProperty("Server")]
        public ICollection<OrderLine> OrderLinesServed { get; set; }
    }
}
