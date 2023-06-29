using System.ComponentModel.DataAnnotations;

namespace BurgerApp.ViewModels.BurgerViewModels
{
    public class BurgerViewModel
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Burger name")]
        [MaxLength(35, ErrorMessage = "Name is too long")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Price")]
        [Range(0.0, 9999.99, ErrorMessage = "Price is out of range")]
        public double Price { get; set; }
        [Required]
        [Display(Name = "Description")]
        [MaxLength(200, ErrorMessage = "Description is too long")]
        public string Description { get; set; }
        [Display(Name = "Vegeterian")]
        public bool IsVegeterian { get; set; }
        [Display(Name = "Vegan")]
        public bool IsVegan { get; set; }
        [Display(Name = "Fries Included")]
        public bool HasFires { get; set; }
        [Display(Name = "Link to image")]
        public string? ImageUrl { get; set; }
    }
}
