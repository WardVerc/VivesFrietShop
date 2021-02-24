using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Vives_FrietShop.Core;
using Vives_FrietShop.Models;

namespace Vives_FrietShop.Controllers
{
    public class ProductBeheerController : Controller
    {
        private readonly IDatabase _database;

        public ProductBeheerController(IDatabase database)
        {
            _database = database;
        }
        
        public IActionResult Index()
        {
            return View(_database.ShopItems);
        }

        [HttpPost]
        public IActionResult Index(String naam, double prijs)
        {
            
            var databaseItem = _database.ShopItems.SingleOrDefault(a => a.Naam == naam);

            if (databaseItem != null)
            {
                Console.Write("Product " + naam + " bestaat al!");
                return RedirectToAction("Index");
            }
            else
            {
                ShopItem newItem = new ShopItem()
                {
                    Naam = naam,
                    Prijs = prijs,
                    Id = GetNewId()
                };
                _database.ShopItems.Add(newItem);
                return RedirectToAction("Index");
            }
            
        }

        public int GetNewId()
        {
            if (_database.ShopItems.Any())
            {
                var getMaxId = _database.ShopItems.Max(i => i.Id);
                return getMaxId += 1;
            }
            else
            {
                return 1;
            }
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var databaseItem = _database.ShopItems.SingleOrDefault(a => a.Id == id);

            if (databaseItem == null)
            {
                Console.Write("Product bestaat niet meer!");
                return RedirectToAction("Index");
            }
            else
            {
                _database.ShopItems.Remove(databaseItem);
                return RedirectToAction("Index");
            }
            
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var databaseItem = _database.ShopItems.SingleOrDefault(a => a.Id == id);

            if (databaseItem == null)
            {
                Console.Write("Product bestaat niet meer!");
                return RedirectToAction("Index");
            }
            else
            {
                return View(databaseItem);
            }
        }
        
        [HttpPost]
        public IActionResult Edit(ShopItem item)
        {
            var databaseItem = _database.ShopItems.SingleOrDefault(a => a.Id == item.Id);

            if (databaseItem == null)
            {
                Console.Write("Product bestaat niet meer!");
                return RedirectToAction("Index");
            }
            else
            {
                //wijzig de originele databaseitem.Naam met item.Naam , zelfde voor prijs
                databaseItem.Naam = item.Naam;
                databaseItem.Prijs = item.Prijs;
                return RedirectToAction("Index");
            }
        }
    }
}