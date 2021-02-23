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
        public IActionResult Index(String naam)
        {
            var databaseItem = _database.ShopItems.SingleOrDefault(a => a.Naam == naam);
            
            _database.Winkelmandje.Add(databaseItem);
            
            return RedirectToAction("Index");
        }

        
    }
}