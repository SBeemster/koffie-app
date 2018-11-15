using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace CoffeeAPI.Models
{
    public class DrinkPreference
    {   [Key]
        public Guid Preferenceid { get; set; }
        [Required]
        public User User { get; set; }
        [Required]
        public Drink Drink { get; set; }
        public int Milk { get; set; }
        public int Sugar { get; set; }

    }
}
