using BurgerApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BurgerApp.App.Controllers
{
    public class BurgerController : Controller
    {
        private readonly IBurgerService _burgerService;
        public BurgerController(IBurgerService burgerService)
        {
            _burgerService = burgerService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _burgerService.GetBurgersForCards());
        }
    }
}
