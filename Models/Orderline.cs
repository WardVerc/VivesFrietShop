namespace Vives_FrietShop.Models
{
    public class Orderline
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ShopItemId { get; set; }
    }
}