using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DrinksApp.Models;

namespace DrinksApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDrinkRepository _drinkRepository;

        public HomeController(IDrinkRepository drinkRepository)
        {
            _drinkRepository = drinkRepository;
        }

        public IActionResult Index()
        {
            var drinks = _drinkRepository.GetAllDrinks().OrderBy(p => p.Name);
            return View(drinks);
        }

        public IActionResult Map()
        {
            return View();
        }

        public IActionResult ViewDetails(int Id)
        {
            var drink = _drinkRepository.GetDrinkById(Id);
            return View(drink);
        }

        public IActionResult Cart(int Id)
        {
            var drink = _drinkRepository.GetDrinkById(Id);
            return View(drink);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
