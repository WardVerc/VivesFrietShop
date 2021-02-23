using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Vives_FrietShop.Models;


namespace Vives_FrietShop.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            var lijst = new List<ShopItem>(ShopItem.maakData());
            return View(lijst);
        }

        
    }
}