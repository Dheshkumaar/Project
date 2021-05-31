using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using pizzaClient.Models;
using pizzaClient.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pizzaClient.Controllers
{
    public class PizzaController : Controller
    {
        private ILogger<PizzaController> _logger;
        private IPizza<Pizza> _repo;
        public PizzaController(IPizza<Pizza> repo, ILogger<PizzaController> logger)
        {
            _logger = logger;
            _repo = repo;
        }
        // GET: PizzaController
        public ActionResult Index()
        {
            try
            {
                List<Pizza> pizzaDetails = _repo.GetAll().ToList();
                return View(pizzaDetails);
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
                return RedirectToAction("Error", "Home");
            }
        }

        public ActionResult Home()
        {
            return View();
        }

        

        // GET: PizzaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PizzaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Pizza pizza)
        {
            try
            {
                _repo.Add(pizza);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
                return RedirectToAction("Error", "Home");
            }
            
        }
        [HttpGet]
        public IActionResult Detail(int id)
        {
            try
            {
                Pizza P = _repo.Get(id);
                return View(P);
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
                return RedirectToAction("Error", "Home");
            }
            
        }
    }
}
