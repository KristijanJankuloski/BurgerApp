using BurgerApp.ViewModels.LocationViewModels;

namespace BurgerApp.Services.Interfaces
{
    public interface ILocationService
    {
        Task<List<LocationListViewModel>> GetAllListViewModel();
    }
}
