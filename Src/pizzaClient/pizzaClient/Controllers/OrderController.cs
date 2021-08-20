using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using pizzaClient.Models;
using pizzaClient.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace pizzaClient.Controllers
{
    public class OrderController : Controller
    {
        private ILogger<OrderController> _logger;
        private IOrder<Order> _repo;
        private IPizza<Pizza> _pizza;
        private PizzaContext _context;
        public OrderController(PizzaContext context, IPizza<Pizza> pizza, IOrder<Order> repo, ILogger<OrderController> logger)
        {
            _context = context;
            _logger = logger;
            _repo = repo;
            _pizza = pizza;
        }
        [HttpPost]
        public IActionResult InitiateOrder(string pizzaIds)
        {
            var Ids = pizzaIds.Split(",");
            ViewBag.Crust = populateCrust();
            ViewBag.Toppings = populatetoppings();
            Order order = new Order();
            order.DeliveryDate = date();
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
                    for (int i = 0;i< order.orderDetails.Count; i++)
                    {
                        ViewBag.toppings = populatetoppings();
                        ViewBag.crust = populateCrust();
                    }
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
        private List<Crust> populateCrust()
        {
            List<Crust> crusts = new List<Crust>();
            crusts = (from i in _context.Crust
                      select i).ToList();
            return crusts;
        }
        private List<Toppings> populatetoppings()
        {
            List<Toppings> toppings = new List<Toppings>();
            toppings = (from i in _context.Toppings
                        select i).ToList();
            return toppings;
        }
        private DateTime date()
        {
            DateTime date = DateTime.Now;
            date = date.AddMilliseconds(-date.Millisecond);
            date = date.AddSeconds(-date.Second);
            return date;
        }
    }
}
