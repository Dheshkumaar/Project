using System.ComponentModel.DataAnnotations;

namespace pizzaClient.Models
{
    public class Toppings
    {
        [Key]
        public int id { get; set; }
        public string ToppingName { get; set; }
    }
}
