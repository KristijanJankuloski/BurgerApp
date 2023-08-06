using BurgerApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BurgerApp.App.Controllers
{
    public class OrderController : Controller
    {
        private readonly IUserService _userService;
        private readonly IBurgerService _burgerService;
        private readonly ILocationService _locationService;
        public OrderController(IUserService userService, 
                                IBurgerService burgerService, 
                                ILocationService locationService)
        {
            _userService = userService;
            _burgerService = burgerService;
            _locationService = locationService;

        }

        public async Task<IActionResult> Index()
        {
            ViewBag.AllUsers = await _userService.GetUserSelectList();
            ViewBag.AllLocations = await _locationService.GetAllListViewModel();
            ViewBag.AllBurgers = await _burgerService.GetBurgerSelectList();
            return View();
        }
    }
}
