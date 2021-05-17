using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GameShop.Models;

namespace GameShop.Data
{
    public class GameShopContext : DbContext
    {
        public GameShopContext (DbContextOptions<GameShopContext> options)
            : base(options)
        {
        }

        public DbSet<GameShop.Models.Product> Product { get; set; }

        public DbSet<GameShop.Models.ShoppingCart> ShoppingCart { get; set; }

        public DbSet<GameShop.Models.User> User { get; set; }

        public DbSet<GameShop.Models.ConsolePage> ConsolePage { get; set; }
    }
}
