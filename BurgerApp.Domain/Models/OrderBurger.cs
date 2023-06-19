using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.Domain.Models
{
    public class OrderBurger : BaseEntity
    {
        public Burger Burger { get; set; }
        public int BurgerId { get; set; }
        public Order Order { get; set; }
        public int OrderId { get; set; }
        public bool IncludeFries { get; set; }
    }
}
