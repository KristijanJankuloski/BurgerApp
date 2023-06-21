using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.Domain.Enums
{
    public enum OrderStatus
    {
        Pending = 1,
        Accepted,
        Preparing,
        Delivering,
        Delivered,
        Canceled

    }
}
