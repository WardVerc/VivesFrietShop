using System.Collections.Generic;
using Vives_FrietShop.Models;

namespace Vives_FrietShop.Core
{
    public class Database : IDatabase
    {
        public IList<ShopItem> ShopItems { get; set; }
        public IList<ShopItem> Winkelmandje { get; set; }

        public Database()
        {
            ShopItems = new List<ShopItem>();
            Winkelmandje = new List<ShopItem>();
        }
    }
}