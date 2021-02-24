using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Vives_FrietShop.Core;

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
        public IActionResult Toevoegen(int id)
        {
            var databaseItem = _database.ShopItems.SingleOrDefault(a => a.Id == id);
            
            _database.Winkelmandje.Add(databaseItem);
            
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Verwijderen(int id)
        {
            var mandjeItem = _database.Winkelmandje.SingleOrDefault(a => a.Id == id);
            
            _database.Winkelmandje.Remove(mandjeItem);
            
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