﻿// <auto-generated />
using System;
using CoffeeAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CoffeeAPI.Migrations
{
    [DbContext(typeof(CoffeeContext))]
    [Migration("20181029180823_MergedUserManagement")]
    partial class MergedUserManagement
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<bool>("Additions");

                    b.Property<bool>("Available");

                    b.Property<string>("drinkName")
                        .IsRequired();

                    b.Property<string>("ImageUrl");

                    b.HasKey("DrinkId");

                    b.ToTable("Drinks");

                    b.HasData(
                        new { DrinkId = new Guid("ae084356-a070-4878-a8fd-a460bd48c111"), Additions = true, Available = true, drinkName = "Koffie", ImageUrl = "/assets/Images/Koffie.jpg" },
                        new { DrinkId = new Guid("42fe4253-e740-47a2-a8d8-e1e8c98662b2"), Additions = true, Available = true, drinkName = "Cappuccino", ImageUrl = "/assets/Images/Cappuccino.jpg" },
                        new { DrinkId = new Guid("d29225bc-866c-410f-aca2-46a153696901"), Additions = true, Available = true, drinkName = "Latte Macchiato", ImageUrl = "/assets/Images/Latte Macchiato.jpg" },
                        new { DrinkId = new Guid("21b7590e-57ac-4998-b6ce-b30e16cc5fe0"), Additions = true, Available = true, drinkName = "Espresso", ImageUrl = "/assets/Images/Espresso.png" },
                        new { DrinkId = new Guid("b9f1d17c-bf57-4914-909f-ca2930046068"), Additions = true, Available = true, drinkName = "Thee", ImageUrl = "/assets/Images/Thee.jpg" },
                        new { DrinkId = new Guid("40ce9245-f89b-464c-bc77-c60f53c9aac0"), Additions = false, Available = true, drinkName = "Water", ImageUrl = "/assets/Images/Water.jpg" }
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
                        new { LoginId = new Guid("230c5365-725e-4a5c-904c-61f9c755b90b"), PasswordHash = new byte[] { 244, 136, 40, 72, 163, 228, 235, 230, 64, 57, 179, 16, 80, 1, 113, 121, 119, 91, 221, 206, 185, 198, 1, 33, 90, 130, 225, 244, 145, 30, 217, 194 }, PasswordSalt = new byte[] { 41, 163, 31, 152, 251, 26, 117, 51, 20, 55, 46, 89, 87, 149, 203, 154, 69, 211, 182, 245, 3, 42, 15, 4, 83, 227, 209, 136, 78, 173, 130, 106 }, UserId = new Guid("8e40d6a9-7f58-4982-a25c-54aa89ac987e"), UserName = "admin" },
                        new { LoginId = new Guid("816d9ca4-ecb2-436e-bc60-6251ccdf88d9"), PasswordHash = new byte[] { 209, 29, 50, 116, 92, 196, 0, 52, 89, 150, 186, 235, 202, 114, 128, 85, 181, 207, 85, 191, 86, 103, 173, 199, 190, 178, 52, 159, 252, 42, 174, 89 }, PasswordSalt = new byte[] { 134, 117, 114, 164, 25, 99, 136, 83, 228, 232, 22, 76, 28, 121, 165, 84, 238, 209, 240, 255, 189, 19, 183, 111, 40, 199, 175, 190, 126, 23, 234, 77 }, UserId = new Guid("20d39328-0703-441c-be7d-236990da8961"), UserName = "jaap" }
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
                        new { RoleId = new Guid("6d4f78dd-0275-4e5a-b21d-5968176e7e29"), RoleName = "User" },
                        new { RoleId = new Guid("160b2bdd-0402-4a7d-974b-07ab26b182f8"), RoleName = "Manager" },
                        new { RoleId = new Guid("1b126cee-0250-4b64-b30b-0bf26898636c"), RoleName = "Admin" }
                    );
                });

            modelBuilder.Entity("CoffeeAPI.Models.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<Guid?>("PrefrenceDrinkId");

                    b.HasKey("UserId");

                    b.HasIndex("PrefrenceDrinkId");

                    b.ToTable("Users");

                    b.HasData(
                        new { UserId = new Guid("8e40d6a9-7f58-4982-a25c-54aa89ac987e"), Active = true, FirstName = "Super", LastName = "Admin" },
                        new { UserId = new Guid("20d39328-0703-441c-be7d-236990da8961"), Active = true, FirstName = "Jaap", LastName = "Schaap" }
                    );
                });

            modelBuilder.Entity("CoffeeAPI.Models.UserGroup", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<Guid>("GroupId");

                    b.HasKey("UserId", "GroupId");

                    b.HasIndex("GroupId");

                    b.ToTable("UserGroups");
                });

            modelBuilder.Entity("CoffeeAPI.Models.UserRole", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<Guid>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new { UserId = new Guid("8e40d6a9-7f58-4982-a25c-54aa89ac987e"), RoleId = new Guid("6d4f78dd-0275-4e5a-b21d-5968176e7e29") },
                        new { UserId = new Guid("8e40d6a9-7f58-4982-a25c-54aa89ac987e"), RoleId = new Guid("1b126cee-0250-4b64-b30b-0bf26898636c") },
                        new { UserId = new Guid("20d39328-0703-441c-be7d-236990da8961"), RoleId = new Guid("6d4f78dd-0275-4e5a-b21d-5968176e7e29") },
                        new { UserId = new Guid("20d39328-0703-441c-be7d-236990da8961"), RoleId = new Guid("160b2bdd-0402-4a7d-974b-07ab26b182f8") }
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
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CoffeeAPI.Models.User", "User")
                        .WithMany("UserGroups")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CoffeeAPI.Models.UserRole", b =>
                {
                    b.HasOne("CoffeeAPI.Models.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CoffeeAPI.Models.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
