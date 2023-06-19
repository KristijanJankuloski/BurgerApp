using BurgerApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.Domain.Models
{
    public class Order : BaseEntity
    {
        public DateTime OrderDate { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public bool IsDelivered { get; set; }
        public List<OrderBurger> OrderBurgers { get; set; } = new();
    }
}
