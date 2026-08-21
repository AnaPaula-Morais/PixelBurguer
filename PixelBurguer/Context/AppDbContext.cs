using Microsoft.EntityFrameworkCore;
using PixelBurguer.Models;

namespace PixelBurguer.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Snack> Snacks { get; set; }

        public DbSet<ShoppingCartItem> ShoppingCartIntems { get; set; }
    }
}
