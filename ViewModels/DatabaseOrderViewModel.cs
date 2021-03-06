using Vives_FrietShop.DataAccess;
using Vives_FrietShop.Models;

namespace Vives_FrietShop.ViewModels
{
    public class DatabaseOrderViewModel
    {
        public DatabaseContext Database { get; set; }
        public Order Order { get; set; } 
    }
}