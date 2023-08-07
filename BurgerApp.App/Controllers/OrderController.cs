using BurgerApp.Services.Interfaces;
using BurgerApp.ViewModels.OrderViewModel;
using Microsoft.AspNetCore.Mvc;

namespace BurgerApp.App.Controllers
{
    public class OrderController : Controller
    {
        private readonly IUserService _userService;
        private readonly IBurgerService _burgerService;
        private readonly ILocationService _locationService;
        private readonly IOrderService _orderService;
        public OrderController(IUserService userService, 
                                IBurgerService burgerService, 
                                ILocationService locationService,
                                IOrderService orderService)
        {
            _userService = userService;
            _burgerService = burgerService;
            _locationService = locationService;
            _orderService = orderService;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.AllUsers = await _userService.GetUserSelectList();
            ViewBag.AllLocations = await _locationService.GetAllListViewModel();
            ViewBag.AllBurgers = await _burgerService.GetBurgerSelectList();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(OrderCreateViewModel? model)
        {
            if(model == null)
            {
                TempData["Error"] = "No order provided";
                return RedirectToAction("Index");
            }
            await _orderService.CreateOrder(model);
            TempData["Success"] = "Order Created";
            return Redirect($"/User/Details/{model.UserId}");
        }
    }
}
