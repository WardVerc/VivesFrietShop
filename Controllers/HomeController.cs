using Microsoft.AspNetCore.Mvc;


namespace Vives_FrietShop.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        
    }
}