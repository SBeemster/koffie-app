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
                        new { DrinkId = new Guid("26e1250c-01bd-46bb-99ba-5c12da282fa7"), Available = true, DrinkName = "Koffie" },
                        new { DrinkId = new Guid("3a61aee8-0868-493e-8876-cdf5dd2edee4"), Available = true, DrinkName = "Cappuccino" },
                        new { DrinkId = new Guid("cf404ddb-2246-4ffe-ac79-f66d8d96b47a"), Available = true, DrinkName = "Latte Macchiato" },
                        new { DrinkId = new Guid("c15c5bb0-e523-4094-9fd7-76a9e63be318"), Available = true, DrinkName = "Espresso" },
                        new { DrinkId = new Guid("a15013d5-a30b-4983-9e2f-7b6fcd85b073"), Available = true, DrinkName = "Thee" }
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
                        new { LoginId = new Guid("69442c12-0951-4576-9937-52389c3dc9fb"), PasswordHash = new byte[] { 103, 185, 6, 217, 166, 141, 163, 87, 44, 54, 164, 35, 216, 248, 130, 2, 1, 242, 31, 250, 32, 11, 200, 167, 236, 191, 155, 5, 19, 63, 134, 44 }, PasswordSalt = new byte[] { 50, 95, 79, 228, 165, 228, 78, 142, 36, 222, 173, 149, 54, 5, 45, 39, 97, 162, 162, 6, 117, 38, 95, 76, 183, 155, 29, 208, 103, 56, 91, 141 }, UserId = new Guid("2cc1bb28-c12e-4f2c-a63a-138725f28b57"), UserName = "jaap" }
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

                    b.HasData(
                        new { RoleId = new Guid("beea9893-9114-4536-98a1-88ea39e68455"), RoleName = "User" },
                        new { RoleId = new Guid("e251b626-3498-4de8-8f9b-f184b024386d"), RoleName = "Manager" },
                        new { RoleId = new Guid("9a040110-6ced-492e-a6f9-9134a55d21c0"), RoleName = "Admin" }
                    );
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
                        new { UserId = new Guid("2cc1bb28-c12e-4f2c-a63a-138725f28b57"), FirstName = "Jaap", LastName = "Schaap" }
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

                    b.HasData(
                        new { UserRoleId = new Guid("92764fce-faa4-491a-ba72-33cdafdffe71"), RoleId = new Guid("beea9893-9114-4536-98a1-88ea39e68455"), UserId = new Guid("2cc1bb28-c12e-4f2c-a63a-138725f28b57") },
                        new { UserRoleId = new Guid("f3d2f341-7964-4caf-ad28-27ed0b1cba87"), RoleId = new Guid("e251b626-3498-4de8-8f9b-f184b024386d"), UserId = new Guid("2cc1bb28-c12e-4f2c-a63a-138725f28b57") }
                    );
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
