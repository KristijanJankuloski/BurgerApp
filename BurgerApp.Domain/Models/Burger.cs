namespace BurgerApp.Domain.Models
{
    public class Burger : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public double Price { get; set; }
    }
}
