using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace pizzaClient.Models
{
    public class Pizza
    {
        [Key]
        public int PizzaId { get; set; }
        [Required]
        public string PizzaName { get; set; }
        [Required]
        public string Speciality { get; set; }
        [Required]
        [DisplayName("Vegetarian")]
        public bool IsVeg { get; set; }
        [Required]
        public double Price { get; set; }
        [DisplayName("Description")]
        [Required]
        public string PizzaDescription { get; set; }
        [Required]
        public string ImageFileName { get; set; }
    }
}
