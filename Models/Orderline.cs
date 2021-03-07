namespace Vives_FrietShop.Models
{
    public class Orderline
    {
        //dit model legt verband tussen shopItem en order
        
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ShopItemId { get; set; }
    }
}