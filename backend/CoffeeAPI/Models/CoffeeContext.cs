using CoffeeAPI.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Text;

namespace CoffeeAPI.Models
{
    public class CoffeeContext : DbContext
    {
        public CoffeeContext(DbContextOptions<CoffeeContext> options) : base(options)
        { }

        // main tables
        public DbSet<Group> Groups { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }
        public DbSet<Drink> Drinks { get; set; }

        // intermediary tables
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<UserGroup> UserGroups { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // ensure indexed and unique usernames
            modelBuilder.Entity<Login>().HasIndex(login => login.UserName).IsUnique();

            // define composite keys
            modelBuilder.Entity<UserRole>().HasKey(ur => new { ur.UserId, ur.RoleId });
            modelBuilder.Entity<UserGroup>().HasKey(ug => new { ug.UserId, ug.GroupId });

            // seed admin and first user data
            var adminId = Guid.NewGuid();
            var jaapId = Guid.NewGuid();
            modelBuilder.Entity<User>().HasData(
                new { UserId = adminId, FirstName = "Super", LastName = "Admin", Active = true },
                new { UserId = jaapId, FirstName = "Jaap", LastName = "Schaap", Active = true });

            var adminSalt = AuthHelper.GetRandom();
            var adminPassword = Encoding.UTF8.GetBytes("admin");
            var adminHashed = AuthHelper.GenerateSaltedHash(adminPassword, adminSalt);
            var jaapSalt = AuthHelper.GetRandom();
            var jaapPassword = Encoding.UTF8.GetBytes("password");
            var jaapHashed = AuthHelper.GenerateSaltedHash(jaapPassword, jaapSalt);
            modelBuilder.Entity<Login>().HasData(
                new { LoginId = Guid.NewGuid(), UserName = "admin", PasswordSalt = adminSalt, PasswordHash = adminHashed, UserId = adminId },
                new { LoginId = Guid.NewGuid(), UserName = "jaap", PasswordSalt = jaapSalt, PasswordHash = jaapHashed, UserId = jaapId });

            var roleUserId = Guid.NewGuid();
            var roleManagerId = Guid.NewGuid();
            var roleAdminId = Guid.NewGuid();
            modelBuilder.Entity<Role>().HasData(
                new { RoleId = roleUserId, RoleName = "User" },
                new { RoleId = roleManagerId, RoleName = "Manager" },
                new { RoleId = roleAdminId, RoleName = "Admin" });

            modelBuilder.Entity<UserRole>().HasData(
                new { UserRoleId = Guid.NewGuid(), UserId = adminId, RoleId = roleUserId },
                new { UserRoleId = Guid.NewGuid(), UserId = adminId, RoleId = roleAdminId },
                new { UserRoleId = Guid.NewGuid(), UserId = jaapId, RoleId = roleUserId },
                new { UserRoleId = Guid.NewGuid(), UserId = jaapId, RoleId = roleManagerId });

            //seed first drinks
            String[,] drinkArray = new string[6, 3] { { "Koffie", "/assets/Images/Koffie.jpg", "true" }, { "Cappuccino", "/assets/Images/Cappuccino.jpg", "true" }, { "Latte Macchiato", "/assets/Images/Latte Macchiato.jpg", "true" }, { "Espresso", "/assets/Images/Espresso.png", "true" }, { "Thee", "/assets/Images/Thee.jpg", "true" }, { "Water", "/assets/Images/Water.jpg", "false" } };
            for (int i =0; i < drinkArray.GetLength(0); i++)
            {
                var Additions= false;
                var drankId = Guid.NewGuid();
                if (drinkArray[i, 2].Equals("true")) {
                   Additions  = true;
                }
                
                modelBuilder.Entity<Drink>().HasData(
                    new { DrinkId = drankId, drinkName = drinkArray[i,0], Available = true, ImageUrl = drinkArray[i,1], Additions = Additions });
            }

            modelBuilder.Entity<OrderStatus>().HasData(
                new { OrderStatusId = Guid.NewGuid(), StatusName = "Ordered" },
                new { OrderStatusId = Guid.NewGuid(), StatusName = "Finished" }
                );

        }
    }
}
