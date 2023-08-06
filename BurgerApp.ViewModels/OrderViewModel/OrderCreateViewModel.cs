using BurgerApp.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace BurgerApp.ViewModels.OrderViewModel
{
    public class OrderCreateViewModel
    {
        [Required]
        [Display(Name = "Select from registered users")]
        public int UserId { get; set; }
        public int LocationId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public List<int> BurgerIds { get; set; }
    }
}
