using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.Domain.Models
{
    public class Location : BaseEntity
    {
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;
        [MaxLength(50)]
        public string Address { get; set; } = string.Empty;
        public List<Order> Orders { get; set; } = new();
        public TimeSpan OpensAt { get; set; }
        public TimeSpan ClosesAt { get; set; }
    }
}
