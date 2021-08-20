using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pizzaClient.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        [Required]
        [RegularExpression(@"^[A-Za-z]{4}[a-zA-Z ]*$", ErrorMessage = "Not a valid Customer Name")]
        [StringLength(30, MinimumLength = 4, ErrorMessage = "Must be at least 4 characters long.")]
        [DisplayName("Name")]
        public string CustomerName { get; set; }
        [Required]
        [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "Not a valid mobile number")]
        [DisplayName("Mobile Number")]
        public string CustomerPhone { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 10, ErrorMessage = "Must be at least 10 characters long.")]
        [DisplayName("Address")]
        public string Address { get; set; }
        [Required]
        [DisplayName("Area/City")]
        [StringLength(30, MinimumLength = 6, ErrorMessage = "Must be at least 8 characters long.")]
        public string City { get; set; }
        [Required]
        [DisplayName("Pincode")]
        [RegularExpression(@"^[0-9]{6}$", ErrorMessage = "Enter a valid Pincode")]
        public string Pincode { get; set; }
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
