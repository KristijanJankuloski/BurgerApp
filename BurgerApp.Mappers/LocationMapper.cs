using BurgerApp.Domain.Models;
using BurgerApp.ViewModels.LocationViewModels;

namespace BurgerApp.Mappers
{
    public static class LocationMapper
    {
        public static LocationListViewModel ToListViewModel(this Location location)
        {
            return new LocationListViewModel
            {
                Id = location.Id,
                Name = location.Name,
                Address = location.Address,
                Closes = location.ClosesAt.ToString(),
                Opens = location.OpensAt.ToString(),
            };
        }
    }
}
