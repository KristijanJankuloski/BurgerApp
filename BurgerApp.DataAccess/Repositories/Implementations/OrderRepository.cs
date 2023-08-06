using BurgerApp.DataAccess.DataContext;
using BurgerApp.DataAccess.Repositories.Interfaces;
using BurgerApp.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BurgerApp.DataAccess.Repositories.Implementations
{
    public class OrderRepository : IOrderRepository
    {
        private readonly BurgerAppDbContext _context;
        public OrderRepository(BurgerAppDbContext context)
        {
            _context = context;
        }
        public async Task DeleteByIdAsync(int id)
        {
            Order order = _context.Orders.FirstOrDefault(o => o.Id == id);
            if (order == null)
            {
                throw new Exception("No order found");
            }
            _context.Orders.Remove(order);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Order>> GetAllAsync()
        {
            return await _context.Orders.ToListAsync();
        }

        public async Task<Order> GetByIdAsync(int id)
        {
            return await _context.Orders
                .Include(x => x.User)
                .Include(x => x.OrderBurgers)
                .ThenInclude(x => x.Burger)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Order> InserAndReturnAsync(Order order)
        {
            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();
            return order;
        }

        public async Task InsertAsync(Order entity)
        {
            await _context.Orders.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Order entity)
        {
            _context.Orders.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
