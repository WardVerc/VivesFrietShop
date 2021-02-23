using System.Collections.Generic;

namespace Vives_FrietShop.Models
{
    public class ShopItem
    {
        public string Naam { get; set; }
        public double Prijs { get; set; }
        
        //om prijs om te zetten en afronden naar kommagetal:
        //culture = CultureInfo.CreateSpecificCulture("nl-BE");
        //prijs.ToString("C", culture);

        public static IEnumerable<ShopItem> maakData()
        {
            var shopItem1 = new ShopItem()
            {
                Naam = "Kleine Friet",
                Prijs = 1.2
            };
            
            var shopItem2 = new ShopItem()
            {
                Naam = "Medium Friet",
                Prijs = 1.5
            };
            
            var shopItem3 = new ShopItem()
            {
                Naam = "Chix fingers",
                Prijs = 1.3
            };
            
            var shopItem4 = new ShopItem()
            {
                Naam = "Frikandel",
                Prijs = 1.0
            };
            
            var shopItem5 = new ShopItem()
            {
                Naam = "Frikandel speciaal",
                Prijs = 1.2
            };
            
            var shopItem6 = new ShopItem()
            {
                Naam = "Bicky burger",
                Prijs = 3.0
            };
            
            var shopItem7 = new ShopItem()
            {
                Naam = "Bicky cheese",
                Prijs = 3.2
            };

            var shopLijst = new List<ShopItem>();
            shopLijst.Add(shopItem1);
            shopLijst.Add(shopItem2);
            shopLijst.Add(shopItem3);
            shopLijst.Add(shopItem4);
            shopLijst.Add(shopItem5);
            shopLijst.Add(shopItem6);
            shopLijst.Add(shopItem7);

            return shopLijst;

        }
    }
}