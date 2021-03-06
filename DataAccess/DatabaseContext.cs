using Microsoft.EntityFrameworkCore;
using Vives_FrietShop.Models;

namespace Vives_FrietShop.DataAccess
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options) { }
        public DbSet<ShopItem> ShopItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Orderline> Orderlines { get; set; }

        public void Initialize()
        {
            ShopItem een = new ShopItem()
            {
                Naam = "Kleine Friet",
                Prijs = 1.2
            };
            ShopItem twee = new ShopItem()
            {
                Naam = "Medium Friet",
                Prijs = 1.5
            };
            ShopItem drie = new ShopItem()
            {
                Naam = "Chix fingers",
                Prijs = 1.3
            };
            ShopItem vier = new ShopItem()
            {
                Naam = "Frikandel",
                Prijs = 1.0
            };
            ShopItem vijf = new ShopItem()
            {
                Naam = "Frikandel speciaal",
                Prijs = 1.2
            };
            ShopItem zes = new ShopItem()
            {
                Naam = "Bicky burger",
                Prijs = 3.0
            };
            ShopItem zeven = new ShopItem()
            {
                Naam = "Bicky cheese",
                Prijs = 3.2
            };
            ShopItem acht = new ShopItem()
            {
                Naam = "Stoofvleessaus",
                Prijs = 0.5
            };
            ShopItem negen = new ShopItem()
            {
                Naam = "Satékruiden",
                Prijs = 0.2
            };
            ShopItem tien = new ShopItem()
            {
                Naam = "Pintje 25cl",
                Prijs = 1.0
            };

            ShopItems.Add(een);
            ShopItems.Add(twee);
            ShopItems.Add(drie);
            ShopItems.Add(vier);
            ShopItems.Add(vijf);
            ShopItems.Add(zes);
            ShopItems.Add(zeven);
            ShopItems.Add(acht);
            ShopItems.Add(negen);
            ShopItems.Add(tien);
        }
    }
}