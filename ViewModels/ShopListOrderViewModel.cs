using System.Collections.Generic;
using Vives_FrietShop.Models;

namespace Vives_FrietShop.ViewModels
{
    public class ShopListOrderViewModel
    {
        public IEnumerable<ShopItem> ShopItems { get; set; }
        public IEnumerable<ShopItem> Winkelmandje { get; set; }
    }
}