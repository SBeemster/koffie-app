using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoffeeAPI.Models
{
    public class Drink
    {
        public int DrinkId { get; set; }
        [Required]
        public string DrinkName { get; set; }
        public Boolean Available { get; set; }
        public string ImageUrl { get; set; }

        public ICollection<OrderLine> OrderLines { get; set; }
    }
}
