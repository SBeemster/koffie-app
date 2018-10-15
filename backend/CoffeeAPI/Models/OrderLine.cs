using System.ComponentModel.DataAnnotations;

namespace CoffeeAPI.Models
{
    public class OrderLine
    {
        public int OrderLineId { get; set; }

        [Required]
        public User Customer { get; set; }
        public User Server { get; set; }
        [Required]
        public Drink Drink { get; set; }
        public int Sugar { get; set; }
        public int Milk { get; set; }
        public OrderStatus OrderStatus { get; set; }
    }
}
