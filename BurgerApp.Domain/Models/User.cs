using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.Domain.Models
{
    public class User : BaseEntity
    {
        [MaxLength(25)]
        public string FirstName { get; set; } = string.Empty;
        [MaxLength(25)]
        public string LastName { get; set; } = string.Empty;
        [MaxLength(20)]
        public string PhoneNumber { get; set; } = string.Empty;
        [MaxLength(50)]
        public string Email { get; set; } = string.Empty;
        [MaxLength(50)]
        public string Address { get; set; } = string.Empty;
        public List<Order> Orders { get; set; } = new();
    }
}
