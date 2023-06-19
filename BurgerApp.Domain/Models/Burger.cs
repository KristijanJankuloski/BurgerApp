using BurgerApp.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace BurgerApp.Domain.Models
{
    public class Burger : BaseEntity
    {
        [MaxLength(35)]
        public string Name { get; set; } = string.Empty;
        [Range(0, 999)]
        public double Price { get; set; }
        public Category Category { get; set; }
        [MaxLength(200)]
        public string Description { get; set; } = string.Empty;
        public List<OrderBurger> OrderBurgers { get; set; } = new();
    }
}
