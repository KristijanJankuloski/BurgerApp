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
        public TimeOnly OpensAt { get; set; }
        public TimeOnly ClosesAt { get; set; }
    }
}
