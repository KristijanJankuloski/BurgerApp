using BurgerApp.Domain.Models;
using BurgerApp.ViewModels.BurgerViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.Mappers
{
    public static class BurgerMapper
    {
        public static BurgerListViewModel ToBurgerListViewModel(this Burger burger)
        {
            return new BurgerListViewModel
            {
                Id = burger.Id,
                Name = burger.Name,
                Price = burger.Price,
            };
        }

        public static BurgerDetailsViewModel ToBurgerDetailsViewModel(this Burger burger)
        {
            return new BurgerDetailsViewModel
            {
                Id = burger.Id,
                Name = burger.Name,
                Price = burger.Price,
                Description = burger.Description,
                IsVegan = burger.IsVegan,
                IsVegeterian = burger.IsVegeterian,
                HasFries = burger.HasFries,
            };
        }

        public static BurgerViewModel ToBurgerViewModel(this Burger burger)
        {
            return new BurgerViewModel
            {
                Id = burger.Id,
                Name = burger.Name,
                Price = burger.Price,
                Description = burger.Description,
                IsVegan = burger.IsVegan,
                IsVegeterian = burger.IsVegeterian,
                HasFires = burger.HasFries,
                ImageUrl = burger.ImageUrl,
            };
        }

        public static Burger ToBurger(this BurgerViewModel burgerVM)
        {
            return new Burger
            {
                Id = burgerVM.Id,
                Name = burgerVM.Name,
                Price = burgerVM.Price,
                Description = burgerVM.Description,
                IsVegan = burgerVM.IsVegan,
                IsVegeterian = burgerVM.IsVegeterian,
                HasFries = burgerVM.HasFires,
                ImageUrl = burgerVM.ImageUrl,
            };
        }
        public static BurgerOrderSelectListViewModel ToBurgerOrderSelectList(this Burger burger)
        {
            return new BurgerOrderSelectListViewModel
            {
                Id = burger.Id,
                Name = burger.Name,
            };
        }
    }
}
