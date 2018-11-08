using System;
using System.ComponentModel.DataAnnotations;

namespace CoffeeAPI.Models
{
    public class OrderLine
    {
        public Guid OrderLineId { get; set; }

        [Required]
        public User Customer { get; set; }
        public User Server { get; set; }
        [Required]
        public Drink Drink { get; set; }
        public int Count { get; set; }
        public int Sugar { get; set; }
        public int Milk { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public DateTime OrderTime { get; set; }
        public DateTime GetTime { get; set; }
    }
}
