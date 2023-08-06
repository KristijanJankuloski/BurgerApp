using BurgerApp.Domain.Models;
using BurgerApp.ViewModels.UserViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.Mappers
{
    public static class UserMapper
    {
        public static User ToUser(this UserViewModel model)
        {
            return new User
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                PhoneNumber = model.PhoneNumber,
                Address = model.Address,
            };
        }

        public static UserSelectListViewModel ToUserSelectList(this User user)
        {
            return new UserSelectListViewModel
            {
                Id = user.Id,
                Name = $"{user.FirstName} {user.LastName} - {user.Email}",
            };
        }
    }
}
