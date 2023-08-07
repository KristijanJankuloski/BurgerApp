using BurgerApp.Domain.Enums;
using BurgerApp.Domain.Models;
using BurgerApp.ViewModels.OrderViewModel;

namespace BurgerApp.Mappers
{
    public static class OrderMapper
    {
        public static Order ToOrder(this OrderCreateViewModel model)
        {
            return new Order
            {
                IsDelivered = false,
                OrderDate = DateTime.Now,
                OrderStatus = OrderStatus.Pending,
                UserId = model.UserId,
                LocationId = model.LocationId,
                PaymentMethod = model.PaymentMethod,
            };
        }

        public static OrderListViewModel ToOrderList(this Order order)
        {
            return new OrderListViewModel
            {
                Id = order.Id,
                OrderDate = order.OrderDate,
                LocationName = order.Location.Name,
                PaymentMethod = order.PaymentMethod,
                Status = order.OrderStatus,
                NumberOfItems = order.OrderBurgers.Count,
            };
        }
    }
}
