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

        public async Task<List<BurgerListViewModel>> GetBurgersForCards()
        {
            List<Burger> burgers = await _burgerRepository.GetAllAsync();
            return burgers.Select(b => b.ToBurgerListViewModel()).ToList();
        }
    }
}
