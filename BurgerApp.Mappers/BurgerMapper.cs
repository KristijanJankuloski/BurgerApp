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
    }
}
