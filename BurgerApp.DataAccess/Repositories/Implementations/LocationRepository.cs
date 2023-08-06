using BurgerApp.DataAccess.DataContext;
using BurgerApp.DataAccess.Repositories.Interfaces;
using BurgerApp.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.DataAccess.Repositories.Implementations
{
    public class LocationRepository : ILocationRepository
    {
        private readonly BurgerAppDbContext _context;
        public LocationRepository(BurgerAppDbContext context)
        {
            _context = context;
        }
        public async Task DeleteByIdAsync(int id)
        {
            Location location = await _context.Locations.FirstOrDefaultAsync(x => x.Id == id);
            if (location == null)
            {
                throw new Exception("Location is not found");
            }
            _context.Locations.Remove(location);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Location>> GetAllAsync()
        {
            return await _context.Locations.ToListAsync();
        }

        public async Task<Location> GetByIdAsync(int id)
        {
            return await _context.Locations.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task InsertAsync(Location entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Location entity)
        {
            _context.Locations.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
