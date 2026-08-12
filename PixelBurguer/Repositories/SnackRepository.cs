using Microsoft.EntityFrameworkCore;
using PixelBurguer.Context;
using PixelBurguer.Models;
using PixelBurguer.Repositories.Interfaces;

namespace PixelBurguer.Repositories
{
    public class SnackRepository : ISnackRepository
    {
        private readonly AppDbContext _context;
        public SnackRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Snack> Snacks => _context.Snacks.Include(c => c.Category);

        public IEnumerable<Snack> FavoriteSnacks => _context.Snacks.Where(s => s.IsSnackFavorite).Include(c => c.Category);

        public Snack GetSnackById(int snackId)
        {
            return _context.Snacks.FirstOrDefault(s => s.SnackId == snackId);
        }
    }
}
