using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Vives_FrietShop.DataAccess;
using Vives_FrietShop.Models;
using Vives_FrietShop.ViewModels;

namespace Vives_FrietShop.Controllers
{
    public class ProductBeheerController : Controller
    {
        private readonly DatabaseContext _database;

        public ProductBeheerController(DatabaseContext database)
        {
            _database = database;
        }
        
        public IActionResult Index()
        {
            var shopItem = new ShopItem();

            ShopListShopItemViewModel model = new ShopListShopItemViewModel()
            {
                ShopItems = _database.ShopItems,
                ShopItem = shopItem
            };
            
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(ShopListShopItemViewModel item)
        {
            
            var databaseItem = _database.ShopItems.SingleOrDefault(a => a.Naam == item.ShopItem.Naam);

            if (databaseItem != null)
            {
                Console.Write("Product " + item.ShopItem.Naam + " bestaat al!");
                return RedirectToAction("Index");
            }
            else
            {
                ShopItem newItem = new ShopItem()
                {
                    Naam = item.ShopItem.Naam,
                    Prijs = item.ShopItem.Prijs
                };
                _database.ShopItems.Add(newItem);
                _database.SaveChanges();
                return RedirectToAction("Index");
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
                //verwijder eerst alle orderlines met dit ShopItem
                //anders DB-error
                foreach (var orderline in _database.Orderlines)
                {
                    if (orderline.ShopItemId == id)
                    {
                        _database.Orderlines.Remove(orderline);
                    }
                }
                
                _database.ShopItems.Remove(databaseItem);
                _database.SaveChanges();
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
                
                _database.SaveChanges();
                
                return RedirectToAction("Index");
            }
        }
    }
}