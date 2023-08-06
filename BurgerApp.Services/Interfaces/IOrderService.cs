using BurgerApp.ViewModels.OrderViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.Services.Interfaces
{
    public interface IOrderService
    {
        Task CreateOrder(OrderCreateViewModel model);
    }
}
