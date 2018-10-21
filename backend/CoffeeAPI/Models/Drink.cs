﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoffeeAPI.Models
{
    public class Drink
    {
        public Guid DrinkId { get; set; }
        [Required]
        public string DrinkName { get; set; }
        public int Stock { get; set; }
        public string ImageUrl { get; set; }

        public ICollection<OrderLine> OrderLines { get; set; }
    }
}
