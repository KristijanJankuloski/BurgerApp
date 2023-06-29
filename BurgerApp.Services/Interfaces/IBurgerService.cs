using BurgerApp.ViewModels.BurgerViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.Services.Interfaces
{
    public interface IBurgerService
    {
        Task<List<BurgerListViewModel>> GetBurgersForCards();
        Task<BurgerDetailsViewModel> GetBurgerDetails(int id);
        Task<BurgerViewModel> GetBurgerViewModel(int id);
        Task CreateBurger(BurgerViewModel model);
        Task UpdateBurger(BurgerViewModel model);
        Task DeleteBurgerById(int id);
    }
}
