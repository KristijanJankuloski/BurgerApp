using BurgerApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.ViewModels.OrderViewModel
{
    public class OrderListViewModel
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string LocationName { get; set; }
        public int NumberOfItems { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public OrderStatus Status { get; set; }
    }
}
