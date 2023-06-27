using BurgerApp.DataAccess.DataContext;
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
        }

        public static void InjectServices(this IServiceCollection services)
        {
            services.AddTransient<IBurgerService, BurgerService>();
        }
    }
}
