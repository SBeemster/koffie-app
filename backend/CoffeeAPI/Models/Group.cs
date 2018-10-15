using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoffeeAPI.Models
{
    public class Group
    {
        public int GroupId { get; set; }
        [Required]
        public string GroupName { get; set; }

        public ICollection<UserGroup> UserGroups { get; set; }
    }
}
