﻿using BurgerApp.Services.Interfaces;
using BurgerApp.ViewModels.UserViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BurgerApp.App.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(UserViewModel? model)
        {
            if (model == null)
            {
                TempData["Error"] = "User data not providied";
                return View();
            }
            if(!ModelState.IsValid)
            {
                return View();
            }
            await _userService.CreateUser(model);
            TempData["Success"] = "User created";
            return RedirectToAction("Index", "Order");
        }

        public async Task<IActionResult> Details(int? id)
        {
            if(id == null || id == 0)
            {
                TempData["Error"] = "No user found";
                return RedirectToAction("Index", "Home");
            }
            UserDetailsViewModel model = await _userService.GetUserDetails((int)id);
            return View(model);
        }
    }
}
