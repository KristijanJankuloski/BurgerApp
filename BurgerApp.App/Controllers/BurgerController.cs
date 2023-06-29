using BurgerApp.Services.Interfaces;
using BurgerApp.ViewModels.BurgerViewModels;
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
            if (id == null)
            {
                TempData["Error"] = $"Id is not valid";
                return RedirectToAction("Index");
            }
            var burger = await _burgerService.GetBurgerDetails((int)id);
            if (burger == null)
            {
                TempData["Error"] = $"Cannot find burger with id: {id}";
                return RedirectToAction("Index");
            }
            return View(burger);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(BurgerViewModel burger)
        {
            if(burger == null)
            {
                TempData["Error"] = "No burger provided";
                return RedirectToAction("Index");
            }
            await _burgerService.CreateBurger(burger);
            TempData["Success"] = "New burger created";
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if(id == null || id == 0)
            {
                TempData["Error"] = "Invalid id provided";
                return RedirectToAction("Index");
            }
            var burger = await _burgerService.GetBurgerViewModel((int)id);
            if(burger == null)
            {
                TempData["Error"] = $"No burger with id: {id} found";
                return RedirectToAction("Index");
            }
            return View(burger);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(BurgerViewModel burger)
        {
            if(burger == null)
            {
                TempData["Error"] = "No burger provided";
                return RedirectToAction("Index");
            }
            await _burgerService.UpdateBurger(burger);
            TempData["Success"] = "Burger has been updated";
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if(id == null || id == 0)
            {
                TempData["Error"] = "Invalid id provided";
                return RedirectToAction("Index");
            }
            return View(await _burgerService.GetBurgerViewModel((int)id));
        }

        [HttpPost]
        public async Task<IActionResult> Delete(BurgerViewModel burger)
        {
            if(burger == null)
            {
                TempData["Error"] = "No burger provided";
                return RedirectToAction("Index");
            }
            await _burgerService.DeleteBurgerById(burger.Id);
            TempData["Success"] = "Burger has beed deleted";
            return RedirectToAction("Index");
        }
    }
}
