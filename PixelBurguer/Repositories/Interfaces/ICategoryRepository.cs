using PixelBurguer.Models;

namespace PixelBurguer.Repositories.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }
    }
}
