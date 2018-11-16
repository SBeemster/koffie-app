using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace CoffeeAPI.Models
{
    public class DrinkPreference
    {   [Key]
        public Guid PreferenceId { get; set; }
        [Required]
        public User User { get; set; }
        public Drink Drink { get; set; }
        public int? Milk { get; set; }
        public int? Sugar { get; set; }

    }
}
