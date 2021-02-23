using System.Collections;
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
        
        public void Initialize()
        {
            ShopItems = new List<ShopItem>
            {
                new ShopItem
                {
                    Naam = "Kleine Friet",
                    Prijs = 1.2
                },

                new ShopItem
                {
                    Naam = "Medium Friet",
                    Prijs = 1.5
                },

                new ShopItem
                {
                    Naam = "Chix fingers",
                    Prijs = 1.3
                },

                new ShopItem
                {
                    Naam = "Frikandel",
                    Prijs = 1.0
                },

                new ShopItem
                {
                    Naam = "Frikandel speciaal",
                    Prijs = 1.2
                },

                new ShopItem
                {
                    Naam = "Bicky burger",
                    Prijs = 3.0
                },

                new ShopItem
                {
                    Naam = "Bicky cheese",
                    Prijs = 3.2
                },
                
                new ShopItem
                {
                    Naam = "Stoofvleessaus",
                    Prijs = 0.5
                },
                
                new ShopItem
                {
                    Naam = "Satékruiden",
                    Prijs = 0.2
                },
                
                new ShopItem
                {
                    Naam = "Pintje 25cl",
                    Prijs = 1.0
                }
            };

            Winkelmandje = new List<ShopItem>();

        }
    }
}