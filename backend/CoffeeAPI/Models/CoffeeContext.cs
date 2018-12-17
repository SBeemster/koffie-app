using CoffeeAPI.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Text;
using CoffeeAPI.Models;

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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // ensure indexed and unique usernames
            modelBuilder.Entity<Login>().HasIndex(login => login.UserName).IsUnique();

            // define composite keys
            modelBuilder.Entity<UserRole>().HasKey(ur => new { ur.UserId, ur.RoleId });

            // seed admin and first user data
            var groupId = Guid.NewGuid();
            modelBuilder.Entity<Group>().HasData(
                new { GroupId = groupId, GroupName = "Awesome" });

            var adminId = Guid.NewGuid();
            var jaapId = Guid.NewGuid();
            var drieId = Guid.NewGuid();
            modelBuilder.Entity<User>().HasData(
                new { UserId = adminId, FirstName = "Super", LastName = "Admin", Active = true, GroupMemberGroupId = groupId, GroupOwnerGroupId = groupId },
                new { UserId = jaapId, FirstName = "Jaap", LastName = "Schaap", Active = true, GroupMemberGroupId = groupId },
                new { UserId = drieId, FirstName = "User", LastName = "Drie", Active = true });

            var adminSalt = AuthHelper.GetRandom();
            var adminPassword = Encoding.UTF8.GetBytes("admin");
            var adminHashed = AuthHelper.GenerateSaltedHash(adminPassword, adminSalt);
            var jaapSalt = AuthHelper.GetRandom();
            var jaapPassword = Encoding.UTF8.GetBytes("password");
            var jaapHashed = AuthHelper.GenerateSaltedHash(jaapPassword, jaapSalt);
            var drieSalt = AuthHelper.GetRandom();
            var driePassword = Encoding.UTF8.GetBytes("password");
            var drieHashed = AuthHelper.GenerateSaltedHash(driePassword, drieSalt);
            modelBuilder.Entity<Login>().HasData(
                new { LoginId = Guid.NewGuid(), UserName = "admin", PasswordSalt = adminSalt, PasswordHash = adminHashed, UserId = adminId },
                new { LoginId = Guid.NewGuid(), UserName = "jaap", PasswordSalt = jaapSalt, PasswordHash = jaapHashed, UserId = jaapId },
                new { LoginId = Guid.NewGuid(), UserName = "drie", PasswordSalt = drieSalt, PasswordHash = drieHashed, UserId = drieId });

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
                new { UserRoleId = Guid.NewGuid(), UserId = jaapId, RoleId = roleManagerId },
                new { UserRoleId = Guid.NewGuid(), UserId = drieId, RoleId = roleUserId },
                new { UserRoleId = Guid.NewGuid(), UserId = drieId, RoleId = roleManagerId });

            modelBuilder.Entity<DrinkPreference>().HasData(
                new { PreferenceId = Guid.NewGuid(), UserId = adminId },
                new { PreferenceId = Guid.NewGuid(), UserId = jaapId },
                new { PreferenceId = Guid.NewGuid(), UserId = drieId });

            //seed first drinks
            String[,] drinkArray = new string[6, 3] { { "Koffie", "/assets/Images/Koffie.jpg", "true" }, { "Cappuccino", "/assets/Images/Cappuccino.jpg", "true" }, { "Latte Macchiato", "/assets/Images/Latte Macchiato.jpg", "true" }, { "Espresso", "/assets/Images/Espresso.png", "true" }, { "Thee", "/assets/Images/Thee.jpg", "true" }, { "Water", "/assets/Images/Water.jpg", "false" } };
            for (int i = 0; i < drinkArray.GetLength(0); i++)
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

            modelBuilder.Entity<Group>().HasData(
                new { GroupId = Guid.NewGuid(), GroupName = "The addicts" },
                new { GroupId = Guid.NewGuid(), GroupName = "The most drinkers" },
                new { GroupId = Guid.NewGuid(), GroupName = "Frequently need coffee" },
                new { GroupId = Guid.NewGuid(), GroupName = "Thee pussy\'s" }
                );

        }
        public DbSet<CoffeeAPI.Models.DrinkPreference> DrinkPreference { get; set; }


    }
}
