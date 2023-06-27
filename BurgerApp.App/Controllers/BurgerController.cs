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

        public async Task<IActionResult> Details(int? id)
        {
            if(id == null)
            {
                TempData["Error"] = "Cannot find id";
                return RedirectToAction("Index");
            }
            return View(await _burgerService.GetBurgerDetails((int)id));
        }
    }
}
