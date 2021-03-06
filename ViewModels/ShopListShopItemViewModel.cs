using System.Collections.Generic;
using Vives_FrietShop.Models;

namespace Vives_FrietShop.ViewModels
{
    public class ShopListShopItemViewModel
    {
        public IEnumerable<ShopItem> ShopItems { get; set; }
        public ShopItem ShopItem { get; set; }
    }
}