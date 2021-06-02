using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace pizzaClient.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        [Required]
        [RegularExpression(@"^[A-Za-z]{4}[a-zA-Z ]*$", ErrorMessage = "Not a valid Customer Name")]
        [StringLength(30, MinimumLength = 4, ErrorMessage = "Must be at least 4 characters long.")]
        [DisplayName("Customer Name")]
        public string CustomerName { get; set; }
        [Required]
        [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "Not a valid phone number")]
        [DisplayName("Customer Phone")]
        public string CustomerPhone { get; set; }
        [Required]
        [StringLength(80,MinimumLength = 10, ErrorMessage = "Must be at least 10 characters long.")]
        [DisplayName("Customer Address")]
        public string Address { get; set; }
        [Required]
        public double Amount { get; set; }
        [Required]
        [DisplayName("Delivery Date")]
        public DateTime DeliveryDate { get; set; }
        [NotMapped]
        public bool AlterOrder { get; set; }
        [NotMapped]
        public List<OrderDetails> orderDetails { get; set; }
    }
}
