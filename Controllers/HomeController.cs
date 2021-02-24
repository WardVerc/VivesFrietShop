using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Vives_FrietShop.Core;
using Vives_FrietShop.Models;



namespace Vives_FrietShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDatabase _database;

        public HomeController(IDatabase database)
        {
            _database = database;
        }
        
        public IActionResult Index()
        {
            return View(_database);
        }

        [HttpPost]
        public IActionResult Toevoegen(String naam)
        {
            var databaseItem = _database.ShopItems.SingleOrDefault(a => a.Naam == naam);
            
            _database.Winkelmandje.Add(databaseItem);
            
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Verwijderen(String naam)
        {
            var databaseItem = _database.ShopItems.SingleOrDefault(a => a.Naam == naam);
            
            _database.Winkelmandje.Remove(databaseItem);
            
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Betalen()
        {
            return View(_database.Winkelmandje);
        }

        [HttpPost]
        public IActionResult Einde()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LeegWinkelmandje()
        {
            _database.Winkelmandje.Clear();
            return RedirectToAction("Index");
        }
        
    }
}