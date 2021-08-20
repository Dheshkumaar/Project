using System.ComponentModel.DataAnnotations;

namespace pizzaClient.Models
{
    public class Crust
    {
        [Key]
        public int id { get; set; }
        public string CrustName { get; set; }
    }
}
