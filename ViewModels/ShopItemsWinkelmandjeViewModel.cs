using System.Collections.Generic;
using Vives_FrietShop.Models;

namespace Vives_FrietShop.ViewModels
{
    public class ShopItemsWinkelmandjeViewModel
    {
        public IEnumerable<ShopItem> ShopItems { get; set; }
        public IEnumerable<ShopItem> Winkelmandje { get; set; }
    }
}