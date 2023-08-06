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
    }
}
