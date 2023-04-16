using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MichalNajwerLab3.Models
{
    public class OrderPizza
    {
        [Key]
        public int OrderPizzaId { get; set; }

        [Required]
        public Guid OrderId { get; set; }
        [ForeignKey("OrderId")]
        public Order Order { get; set; }

        [Required]
        public int PizzaId { get; set; }
        [ForeignKey("PizzaId")]
        public Pizza Pizza { get; set; }

        [Required]
        public int Count { get; set; }
    }
}
