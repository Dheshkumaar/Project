using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using pizzaClient.Models;
using pizzaClient.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace pizzaClient.Controllers
{
    public class VegController : Controller
    {
        private ILogger<VegController> _logger;
        private IPizza<Pizza> _repo;
        public VegController(IPizza<Pizza> repo, ILogger<VegController> logger)
        {
            _logger = logger;
            _repo = repo;
        }
        public ActionResult VegPizza()
        {
            try
            {
                List<Pizza> pizzaDetails = _repo.GetAll().Where(i => i.IsVeg == true).ToList();
                return View(pizzaDetails);
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
                return RedirectToAction("Error", "Home");
            }
        }
        public ActionResult NonVegPizza()
        {
            try
            {
                List<Pizza> pizzaDetails = _repo.GetAll().Where(i => i.IsVeg == false).ToList();
                return View("NonVegPizza", pizzaDetails);
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
                return RedirectToAction("Error", "Home");
            }
        }
        [HttpGet]
        public IActionResult VegPizzaDetails(int id)
        {
            try
            {
                Pizza pizza = _repo.Get(id);
                return View(pizza);
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
                return RedirectToAction("Error", "Home");
            }
        }
        [HttpGet]
        public IActionResult NonVegPizzaDetails(int id)
        {
            try
            {
                Pizza pizza = _repo.Get(id);
                return View(pizza);
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
                return RedirectToAction("Error", "Home");
            }
        }
    }
}
