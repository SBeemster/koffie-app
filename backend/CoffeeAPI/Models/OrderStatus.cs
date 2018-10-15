using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoffeeAPI.Models
{
    public class OrderStatus
    {
        public int OrderStatusId { get; set; }
        [Required]
        public string StatusName { get; set; }

        public ICollection<OrderLine> OrderLines { get; set; }
    }
}
