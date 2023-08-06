using BurgerApp.DataAccess.Repositories.Interfaces;
using BurgerApp.Domain.Models;
using BurgerApp.Mappers;
using BurgerApp.Services.Interfaces;
using BurgerApp.ViewModels.OrderViewModel;

namespace BurgerApp.Services.Implementations
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task CreateOrder(OrderCreateViewModel model)
        {
            Order order = await _orderRepository.InserAndReturnAsync(model.ToOrder());
            foreach(int id in model.BurgerIds)
            {
                order.OrderBurgers.Add(new OrderBurger() { OrderId = order.Id, BurgerId = id });
            }
            await _orderRepository.UpdateAsync(order);
        }
    }
}
