using Microsoft.AspNetCore.Mvc;
using PixelBurguer.Models;
using PixelBurguer.Repositories.Interfaces;

namespace PixelBurguer.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ISnackRepository _snackpository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(ISnackRepository snackpository, ShoppingCart shoppingCart)
        {
            _snackpository = snackpository;
            _shoppingCart = shoppingCart;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
