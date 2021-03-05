using System.Collections.Generic;

namespace Vives_FrietShop.Models
{
    public class Order
    {
        public int Id { get; set; }
        public List<ShopItem> Winkelmandje { get; set; }
    }
}