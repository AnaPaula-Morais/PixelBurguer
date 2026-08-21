using PixelBurguer.Context;
using PixelBurguer.Models;
using PixelBurguer.Repositories.Interfaces;

namespace PixelBurguer.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        //injection of the database context
        private readonly AppDbContext _context;

        public CategoryRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Category> Categories => _context.Categories;
    }
}
