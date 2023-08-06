using BurgerApp.DataAccess.Repositories.Interfaces;
using BurgerApp.Domain.Models;
using BurgerApp.Mappers;
using BurgerApp.Services.Interfaces;
using BurgerApp.ViewModels.BurgerViewModels;

namespace BurgerApp.Services.Implementations
{
    public class BurgerService : IBurgerService
    {
        private readonly IBurgerRepository _burgerRepository;
        public BurgerService(IBurgerRepository burgerRepository)
        {
            _burgerRepository = burgerRepository;
        }

        public async Task CreateBurger(BurgerViewModel model)
        {
            await _burgerRepository.InsertAsync(model.ToBurger());
        }

        public async Task DeleteBurgerById(int id)
        {
            await _burgerRepository.DeleteByIdAsync(id);
        }

        public async Task<BurgerDetailsViewModel> GetBurgerDetails(int id)
        {
            Burger burger = await _burgerRepository.GetByIdAsync(id);
            if(burger == null)
            {
                return null;
            }
            return burger.ToBurgerDetailsViewModel();
        }

        public async Task<List<BurgerOrderSelectListViewModel>> GetBurgerSelectList()
        {
            List<Burger> burgers = await _burgerRepository.GetAllAsync();
            return burgers.Select(b => b.ToBurgerOrderSelectList()).ToList();
        }

        public async Task<List<BurgerListViewModel>> GetBurgersForCards()
        {
            List<Burger> burgers = await _burgerRepository.GetAllAsync();
            return burgers.Select(b => b.ToBurgerListViewModel()).ToList();
        }

        public async Task<BurgerViewModel> GetBurgerViewModel(int id)
        {
            var burger = await _burgerRepository.GetByIdAsync(id);
            return burger.ToBurgerViewModel();
        }

        public async Task UpdateBurger(BurgerViewModel model)
        {
            await _burgerRepository.UpdateAsync(model.ToBurger());
        }
    }
}
