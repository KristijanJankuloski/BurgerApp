using BurgerApp.Domain.Enums;
using BurgerApp.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BurgerApp.DataAccess.DataContext
{
    public class BurgerAppDbContext : DbContext
    {
        public DbSet<Burger> Burgers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Location> Locations { get; set; }

        public BurgerAppDbContext(DbContextOptions dbContextOptions) : 
            base(dbContextOptions){}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Order>()
                .HasMany(x => x.OrderBurgers)
                .WithOne(x => x.Order)
                .HasForeignKey(x => x.OrderId);

            modelBuilder.Entity<Burger>()
                .HasMany(x => x.OrderBurgers)
                .WithOne(x => x.Burger)
                .HasForeignKey(x => x.BurgerId);

            modelBuilder.Entity<User>()
                .HasMany(x => x.Orders)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId);

            modelBuilder.Entity<Location>()
                .HasMany(x => x.Orders)
                .WithOne(x => x.Location)
                .HasForeignKey(x => x.LocationId);

            modelBuilder.Entity<Burger>()
                .HasData(
                new Burger
                {
                    Id = 1,
                    Name = "Hamburger",
                    Description = "Beef patty, Buns, Ketchup, Mayo, Lettuce",
                    Price = 180,
                    IsVegan = false,
                    IsVegeterian = false,
                    HasFries = true,
                },
                new Burger
                {
                    Id = 2,
                    Name = "Cheeseburger",
                    Description = "Beef patty, Cheddar, Buns, Ketchup, Mayo, Lettuce",
                    Price = 200,
                    IsVegan = false,
                    IsVegeterian = false,
                    HasFries = true,
                },
                new Burger
                {
                    Id = 3,
                    Name = "Chikenburger",
                    Description = "Chiken steak, Buns, Ketchup, Mayo, Lettuce",
                    Price = 200,
                    IsVegan = false,
                    IsVegeterian = false,
                    HasFries = true,
                },
                new Burger
                {
                    Id = 4,
                    Name = "Chiken Cheese",
                    Description = "Chiken steak, Cheddar, Buns, Ketchup, Mayo, Lettuce",
                    Price = 220,
                    IsVegan = false,
                    IsVegeterian = false,
                    HasFries = true,
                }
            );
            modelBuilder.Entity<User>()
                .HasData(
                    new User
                    {
                        Id = 1,
                        FirstName = "John",
                        LastName = "Doe",
                        PhoneNumber = "1234567890",
                        Address = "112b Baker's street",
                        Email = "doe@john.com",

                    }
                );
            modelBuilder.Entity<Location>()
                .HasData(
                new Location
                {
                    Id = 1,
                    Name = "Centar",
                    Address = "Ulica Makedonija 11",
                    OpensAt = new TimeSpan(9, 0, 0),
                    ClosesAt = new TimeSpan(23, 0, 0)
                }
            );
        }
    }
}
