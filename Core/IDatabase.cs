using System.Collections.Generic;
using Vives_FrietShop.Models;

namespace Vives_FrietShop.Core
{
    public interface IDatabase
    {
        IList<ShopItem> ShopItems { get; set; }
        IList<ShopItem> Winkelmandje { get; set; }

    }
}