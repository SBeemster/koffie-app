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

            // seed first test user data
            var userId = Guid.NewGuid();
            modelBuilder.Entity<User>().HasData(
                new { UserId = userId, FirstName = "Jaap", LastName = "Schaap" });

            var salt = AuthHelper.GetRandom();
            var password = Encoding.UTF8.GetBytes("password");
            var hashedPassword = AuthHelper.GenerateSaltedHash(password, salt);
            modelBuilder.Entity<Login>().HasData(
                new { LoginId = Guid.NewGuid(), UserName = "jaap", PasswordSalt = salt, PasswordHash = hashedPassword, UserId = userId});

            var roleUserId = Guid.NewGuid();
            var roleManagerId = Guid.NewGuid();
            modelBuilder.Entity<Role>().HasData(
                new { RoleId = roleUserId, RoleName = "User" },
                new { RoleId = roleManagerId, RoleName = "Manager" },
                new { RoleId = Guid.NewGuid(), RoleName = "Admin" });

            modelBuilder.Entity<UserRole>().HasData(
                new { UserRoleId = Guid.NewGuid(), UserId = userId, RoleId = roleUserId },
                new { UserRoleId = Guid.NewGuid(), UserId = userId, RoleId = roleManagerId });
        }
    }
}
