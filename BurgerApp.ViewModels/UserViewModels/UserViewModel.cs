using System.ComponentModel.DataAnnotations;

namespace BurgerApp.ViewModels.UserViewModels
{
    public class UserViewModel
    {
        [Required]
        [Display(Name = "First name")]
        [MaxLength(25)]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        [Display(Name = "Last name")]
        [MaxLength(25)]
        public string LastName { get; set; } = string.Empty;
        [Required]
        [Phone]
        [Display(Name = "Phone number")]
        [MaxLength(20)]
        public string PhoneNumber { get; set; } = string.Empty;
        [Required]
        [EmailAddress]
        [Display(Name = "email")]
        [MaxLength(50)]
        public string Email { get; set; } = string.Empty;
        [Required]
        [Display(Name = "Delivery address")]
        [MaxLength(50)]
        public string Address { get; set; } = string.Empty;
    }
}
