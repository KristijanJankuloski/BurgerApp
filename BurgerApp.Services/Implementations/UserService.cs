﻿using BurgerApp.DataAccess.Repositories.Interfaces;
using BurgerApp.Domain.Models;
using BurgerApp.Mappers;
using BurgerApp.Services.Interfaces;
using BurgerApp.ViewModels.UserViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task CreateUser(UserViewModel user)
        {
            await _userRepository.InsertAsync(user.ToUser());
        }

        public async Task<UserDetailsViewModel> GetUserDetails(int id)
        {
            User user = await _userRepository.GetByIdAsync(id);
            UserDetailsViewModel model = user.ToUserDetails();
            model.Orders = new();
            foreach(var item in user.Orders)
            {
                model.Orders.Add(item.ToOrderList());
            }
            return model;
        }

        public async Task<List<UserSelectListViewModel>> GetUserSelectList()
        {
            List<User> userList = await _userRepository.GetAllAsync();
            return userList.Select(u => u.ToUserSelectList()).ToList();
        }
    }
}
