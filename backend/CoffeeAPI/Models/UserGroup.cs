using System.ComponentModel.DataAnnotations;

namespace CoffeeAPI.Models
{
    public class UserGroup
    {
        public int UserGroupId { get; set; }
        public User User { get; set; }
        public Group Group { get; set; }
    }
}
