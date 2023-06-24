using BurgerApp.DataAccess.DataContext;
using BurgerApp.DataAccess.Repositories.Interfaces;
using BurgerApp.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BurgerApp.DataAccess.Repositories.Implementations
{
    public class BurgerRepository : IBurgerRepository
    {
        private BurgerAppDbContext _context;
        public BurgerRepository(BurgerAppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Burger entity)
        {
            await _context.Burgers.AddAsync(entity);
            _context.SaveChanges();
        }

        public async Task DeleteByIdAsync(int id)
        {
        }

        public async Task<IEnumerable<Burger>> GetAllAsync()
        {
            List<Burger> burgers = null;
            await Task.Run(() =>
            {
                burgers = _context.Burgers.ToList();
            });
            if (burgers == null)
                throw new Exception("DB not found");
            return burgers;
        }

        public async Task<Burger> GetByIdAsync(int id)
        {
            Burger burger = null;
            await Task.Run(() =>
            {
                burger = _context.Burgers.FirstOrDefault(x => x.Id == id);
            });
            if (burger == null)
                throw new Exception("No burger found");
            return burger;
        }

        public async Task UpdateAsync(Burger entity)
        {
        }
    }
}
