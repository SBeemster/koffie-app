﻿// <auto-generated />
using System;
using CoffeeAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CoffeeAPI.Migrations
{
    [DbContext(typeof(CoffeeContext))]
    partial class CoffeeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CoffeeAPI.Models.Drink", b =>
                {
                    b.Property<Guid>("DrinkId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Available");

                    b.Property<string>("DrinkName")
                        .IsRequired();

                    b.Property<string>("ImageUrl");

                    b.HasKey("DrinkId");

                    b.ToTable("Drinks");

                    b.HasData(
                        new { DrinkId = new Guid("ada4a5b0-a7b0-4b85-991d-79ccf32f6bf6"), Available = true, DrinkName = "Koffie" },
                        new { DrinkId = new Guid("0e4d6221-fbbe-4cf9-bac0-61f971fcd982"), Available = true, DrinkName = "Cappuccino" },
                        new { DrinkId = new Guid("86d62434-b026-4f71-a1ec-44c0463d2cab"), Available = true, DrinkName = "Latte Macchiato" },
                        new { DrinkId = new Guid("1882ae32-74b0-486c-b5e4-c92e886ca622"), Available = true, DrinkName = "Espresso" },
                        new { DrinkId = new Guid("06d1171d-a007-4629-8209-5e4f7779da7e"), Available = true, DrinkName = "Thee" }
                    );
                });

            modelBuilder.Entity("CoffeeAPI.Models.Group", b =>
                {
                    b.Property<Guid>("GroupId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("GroupName")
                        .IsRequired();

                    b.HasKey("GroupId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("CoffeeAPI.Models.Login", b =>
                {
                    b.Property<Guid>("LoginId")
                        .ValueGeneratedOnAdd();

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired();

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired();

                    b.Property<Guid?>("UserId");

                    b.Property<string>("UserName")
                        .IsRequired();

                    b.HasKey("LoginId");

                    b.HasIndex("UserId");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("Logins");

                    b.HasData(
                        new { LoginId = new Guid("3889953b-13af-4345-a112-4a5692240177"), PasswordHash = new byte[] { 189, 30, 12, 207, 199, 24, 38, 173, 39, 243, 220, 123, 103, 118, 200, 175, 133, 207, 50, 58, 90, 23, 50, 34, 213, 63, 101, 197, 142, 28, 156, 141 }, PasswordSalt = new byte[] { 23, 69, 242, 248, 67, 140, 153, 151, 198, 225, 166, 223, 149, 253, 18, 109, 29, 177, 171, 55, 247, 45, 187, 202, 35, 116, 194, 146, 20, 174, 210, 33 }, UserId = new Guid("5d25ed34-916a-45cf-a919-dea2873a9b47"), UserName = "jaap" }
                    );
                });

            modelBuilder.Entity("CoffeeAPI.Models.OrderLine", b =>
                {
                    b.Property<Guid>("OrderLineId")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CustomerUserId");

                    b.Property<Guid>("DrinkId");

                    b.Property<int>("Milk");

                    b.Property<Guid?>("OrderStatusId");

                    b.Property<Guid?>("ServerUserId");

                    b.Property<int>("Sugar");

                    b.HasKey("OrderLineId");

                    b.HasIndex("CustomerUserId");

                    b.HasIndex("DrinkId");

                    b.HasIndex("OrderStatusId");

                    b.HasIndex("ServerUserId");

                    b.ToTable("OrderLines");
                });

            modelBuilder.Entity("CoffeeAPI.Models.OrderStatus", b =>
                {
                    b.Property<Guid>("OrderStatusId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("StatusName")
                        .IsRequired();

                    b.HasKey("OrderStatusId");

                    b.ToTable("OrderStatuses");
                });

            modelBuilder.Entity("CoffeeAPI.Models.Role", b =>
                {
                    b.Property<Guid>("RoleId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("RoleName")
                        .IsRequired();

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("CoffeeAPI.Models.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<Guid?>("PrefrenceDrinkId");

                    b.HasKey("UserId");

                    b.HasIndex("PrefrenceDrinkId");

                    b.ToTable("Users");

                    b.HasData(
                        new { UserId = new Guid("5d25ed34-916a-45cf-a919-dea2873a9b47"), FirstName = "Jaap", LastName = "Schaap" }
                    );
                });

            modelBuilder.Entity("CoffeeAPI.Models.UserGroup", b =>
                {
                    b.Property<Guid>("UserGroupId")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("GroupId");

                    b.Property<Guid?>("UserId");

                    b.HasKey("UserGroupId");

                    b.HasIndex("GroupId");

                    b.HasIndex("UserId");

                    b.ToTable("UserGroups");
                });

            modelBuilder.Entity("CoffeeAPI.Models.UserRole", b =>
                {
                    b.Property<Guid>("UserRoleId")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("RoleId");

                    b.Property<Guid?>("UserId");

                    b.HasKey("UserRoleId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("CoffeeAPI.Models.Login", b =>
                {
                    b.HasOne("CoffeeAPI.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("CoffeeAPI.Models.OrderLine", b =>
                {
                    b.HasOne("CoffeeAPI.Models.User", "Customer")
                        .WithMany("OrderLinesOrdered")
                        .HasForeignKey("CustomerUserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CoffeeAPI.Models.Drink", "Drink")
                        .WithMany("OrderLines")
                        .HasForeignKey("DrinkId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CoffeeAPI.Models.OrderStatus", "OrderStatus")
                        .WithMany("OrderLines")
                        .HasForeignKey("OrderStatusId");

                    b.HasOne("CoffeeAPI.Models.User", "Server")
                        .WithMany("OrderLinesServed")
                        .HasForeignKey("ServerUserId");
                });

            modelBuilder.Entity("CoffeeAPI.Models.User", b =>
                {
                    b.HasOne("CoffeeAPI.Models.Drink", "Prefrence")
                        .WithMany()
                        .HasForeignKey("PrefrenceDrinkId");
                });

            modelBuilder.Entity("CoffeeAPI.Models.UserGroup", b =>
                {
                    b.HasOne("CoffeeAPI.Models.Group", "Group")
                        .WithMany("UserGroups")
                        .HasForeignKey("GroupId");

                    b.HasOne("CoffeeAPI.Models.User", "User")
                        .WithMany("UserGroups")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("CoffeeAPI.Models.UserRole", b =>
                {
                    b.HasOne("CoffeeAPI.Models.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId");

                    b.HasOne("CoffeeAPI.Models.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
