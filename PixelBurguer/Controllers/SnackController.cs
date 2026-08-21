using Microsoft.AspNetCore.Mvc;
using PixelBurguer.Repositories.Interfaces;
using PixelBurguer.ViewModels;

namespace PixelBurguer.Controllers
{
    public class SnackController : Controller
    {
        private readonly ISnackRepository _snackRepository;

        public SnackController(ISnackRepository snackRepository)
        {
            _snackRepository = snackRepository;
        }

        public IActionResult List()
        {

            //var snacks = _snackRepository.Snacks;
            //return View(snacks);
            var snackListViewModel = new SnackListViewModel();
            snackListViewModel.Snacks = _snackRepository.Snacks;
            snackListViewModel.CurrentCategory = "Categoria atual";

            return View(snackListViewModel);
        }
    }
}
