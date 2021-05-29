﻿using System;
using System.Collections.Generic;
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
        [NotMapped]
        public int PizzaId { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Required]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string CustomerPhone { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public double Amount { get; set; }
        [Required]
        public DateTime DeliveryDate { get; set; }
        [NotMapped]
        public int Quantity { get; set; }
        [NotMapped]
        public string Toppings { get; set; }
        [NotMapped]
        public string CrustType { get; set; }
    }
}
