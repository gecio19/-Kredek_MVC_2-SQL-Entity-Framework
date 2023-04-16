using System.ComponentModel.DataAnnotations;

namespace MichalNajwerLab3.Models
{
    public class Pizza
    {
        public Pizza(int id, string name, decimal price, string description, string image)
        {
            Id = id;
            Name = name;
            Price = price;
            Description = description;
            Image = image;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Image { get; set; }
    }
}
