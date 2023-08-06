using BurgerApp.DataAccess.Repositories.Interfaces;
using BurgerApp.Domain.Models;
using BurgerApp.Mappers;
using BurgerApp.Services.Interfaces;
using BurgerApp.ViewModels.LocationViewModels;

namespace BurgerApp.Services.Implementations
{
    public class LocationService : ILocationService
    {
        private readonly ILocationRepository _locationRepository;
        public LocationService(ILocationRepository locationRepository)
        {
            _locationRepository = locationRepository;
        }
        public async Task<List<LocationListViewModel>> GetAllListViewModel()
        {
            List<Location> locations = await _locationRepository.GetAllAsync();
            return locations.Select(l => l.ToListViewModel()).ToList();
        }
    }
}
