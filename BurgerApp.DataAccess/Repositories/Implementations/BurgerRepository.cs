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

        public async Task InsertAsync(Burger entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteByIdAsync(int id)
        {
            Burger burger = await _context.Burgers.FirstOrDefaultAsync(b => b.Id == id);
            if (burger == null) {
                throw new Exception("Burger not found");
            }
            await _context.SaveChangesAsync();
        }

        public async Task<List<Burger>> GetAllAsync()
        {
            return await _context.Burgers.ToListAsync();
        }

        public async Task<Burger> GetByIdAsync(int id)
        {
            Burger burger = await _context.Burgers.FirstOrDefaultAsync(b => b.Id == id);
            return burger;
        }

        public async Task UpdateAsync(Burger entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
