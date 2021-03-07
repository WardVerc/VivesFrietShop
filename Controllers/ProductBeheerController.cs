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
        //deze controller maakt enkel gebruik van de in-memory db
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
        [ValidateAntiForgeryToken]
        public IActionResult Index(ShopListShopItemViewModel item)
        {
            //check validatie regels van ShopItem-model, indien niet ok
            //wordt errormessage (van model) getoond
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            
            //maken van een nieuw shopitem:
            //indien de naam van het nieuwe shopItem al bestaat wordt de pagina
            //gerefreshed
            var databaseItem = _database.ShopItems.SingleOrDefault(a => a.Naam == item.ShopItem.Naam);
            
            if (databaseItem != null)
            {
                Console.Write("Product " + item.ShopItem.Naam + " bestaat al!");
                return RedirectToAction("Index");
            }
            
            //indien de naam niet bestaat, wordt een nieuw shopItem gemaakt
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
                //indien het gekozen shopItem niet meer gevonden wordt in 
                //de in-memory db, refresh de pagina
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
                //indien het gekozen shopItem niet meer gevonden wordt in 
                //de in-memory db, refresh de pagina
                Console.Write("Product bestaat niet meer!");
                return RedirectToAction("Index");
            }
            else
            {
                return View(databaseItem);
            }
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ShopItem item)
        {
            //check validatie regels van ShopItem-model, indien niet ok
            //wordt errormessage (van model) getoond
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Edit");
            }
            
            var databaseItem = _database.ShopItems.SingleOrDefault(a => a.Id == item.Id);

            if (databaseItem == null)
            {
                //indien het gekozen shopItem niet meer gevonden wordt in 
                //de in-memory db, refresh de pagina
                Console.Write("Product bestaat niet meer!");
                return RedirectToAction("Index");
            }
            else
            {
                //wijzig het shopItem met de nieuwe naam en/of prijs
                //in de in-memory db
                databaseItem.Naam = item.Naam;
                databaseItem.Prijs = item.Prijs;
                
                _database.SaveChanges();
                
                return RedirectToAction("Index");
            }
        }
    }
}