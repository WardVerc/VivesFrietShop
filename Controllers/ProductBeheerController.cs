using Microsoft.AspNetCore.Mvc;
using Vives_FrietShop.Core;

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
        
        
    }
}