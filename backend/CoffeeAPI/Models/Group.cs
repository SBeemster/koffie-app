using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoffeeAPI.Models
{
    public class Group
    {
        public Guid GroupId { get; set; }
        [Required]
        public string GroupName { get; set; }

        [InverseProperty("GroupMember")]
        public ICollection<User> Members { get; set; }
    }
}
