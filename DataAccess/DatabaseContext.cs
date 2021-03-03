using Microsoft.EntityFrameworkCore;
using Vives_FrietShop.Models;

namespace Vives_FrietShop.DataAccess
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options) { }
        public DbSet<ShopItem> ShopItems { get; set; }
    }
}