using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using pizzaClient.Models;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using pizzaClient.Services;

namespace pizzaClient.Controllers
{
    public class OrderController : Controller
    {
        private ILogger<OrderController> _logger;
        private IOrder<Order> _repo;
        private IPizza<Pizza> _pizza;
        public OrderController(IPizza<Pizza>pizza, IOrder<Order> repo, ILogger<OrderController> logger)
        {
            _logger = logger;
            _repo = repo;
            _pizza = pizza;
        }
        [HttpPost]
        public IActionResult InitiateOrder(string pizzaIds)
        {
            var Ids = pizzaIds.Split(",");
            Order order = new Order();
            order.DeliveryDate = DateTime.Now;
            order.orderDetails = new List<OrderDetails>();
            foreach (var item in Ids)
            {
                Pizza p = _pizza.Get(Convert.ToInt32(item));
                OrderDetails orderDetails = new OrderDetails();
                orderDetails.pizzaId = p.PizzaId;
                orderDetails.PizzaName = p.PizzaName;
                orderDetails.Price = p.Price;
                orderDetails.Quantity = 1;
                order.orderDetails.Add(orderDetails);
            }            
            return View("Index", order);
        }
        public IActionResult SaveOrder(Order order) 
        {
            try
            {
                if(order.AlterOrder == true)
                {
                    return View("Index", order);
                }
                _repo.AddOrder(order);
                return View("Success", order); 
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
                return RedirectToAction("Error", "Home");
            }
            
        }
        public IActionResult Confirm(Order order)
        {

            return View(order);
        }
       
    }
}
