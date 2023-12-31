﻿using BurgerApp.DataAccess.DataContext;
using BurgerApp.DataAccess.Repositories.Implementations;
using BurgerApp.DataAccess.Repositories.Interfaces;
using BurgerApp.Services.Implementations;
using BurgerApp.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BurgerApp.Helpers
{
    public static class DependencyInjectionHelper
    {
        public static void InjectDbContext(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<BurgerAppDbContext>(options =>
                options.UseSqlServer(connectionString));
        }

        public static void InjectRepositories(this IServiceCollection services)
        {
            services.AddTransient<IBurgerRepository, BurgerRepository>();
            services.AddTransient<ILocationRepository, LocationRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IOrderRepository, OrderRepository>();
        }

        public static void InjectServices(this IServiceCollection services)
        {
            services.AddTransient<IBurgerService, BurgerService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<ILocationService, LocationService>();
            services.AddTransient<IOrderService, OrderService>();
        }
    }
}
