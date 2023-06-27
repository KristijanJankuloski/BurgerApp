using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.ViewModels.BurgerViewModels
{
    public class BurgerDetailsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public bool IsVegan { get; set; }
        public bool IsVegeterian { get; set; }
        public bool HasFries { get; set; }
    }
}
