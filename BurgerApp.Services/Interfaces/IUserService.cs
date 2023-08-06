using BurgerApp.ViewModels.UserViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.Services.Interfaces
{
    public interface IUserService
    {
        Task CreateUser(UserViewModel user);
        Task<List<UserSelectListViewModel>> GetUserSelectList();
    }
}
