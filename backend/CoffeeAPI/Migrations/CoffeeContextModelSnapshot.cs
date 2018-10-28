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
                        new { DrinkId = new Guid("b7a04987-a4c5-4565-841e-4b56face2544"), Available = true, DrinkName = "Koffie", ImageUrl = "/assets/Images/Koffie.jpg" },
                        new { DrinkId = new Guid("68ed037d-4092-41bd-aff3-e8021f158822"), Available = true, DrinkName = "Cappuccino", ImageUrl = "/assets/Images/Cappuccino.jpg" },
                        new { DrinkId = new Guid("1e726bb6-3d0e-4cd7-aa04-fd95564a0576"), Available = true, DrinkName = "Latte Macchiato", ImageUrl = "/assets/Images/Latte Macchiato.jpg" },
                        new { DrinkId = new Guid("2d99e759-efae-4638-b5fd-a352ef1b9158"), Available = true, DrinkName = "Espresso", ImageUrl = "/assets/Images/Espresso.png" },
                        new { DrinkId = new Guid("af6d14ea-a772-4a91-afcf-cb8418521939"), Available = true, DrinkName = "Thee", ImageUrl = "/assets/Images/Thee.jpg" },
                        new { DrinkId = new Guid("5a268737-c318-4869-91ea-a408afb08f6c"), Available = true, DrinkName = "Water", ImageUrl = "/assets/Images/Water.jpg" }
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
                        new { LoginId = new Guid("826695ba-27dd-4a70-b164-da6c3c839d2f"), PasswordHash = new byte[] { 226, 207, 245, 189, 37, 91, 167, 172, 172, 129, 99, 29, 214, 127, 171, 213, 9, 54, 144, 189, 193, 26, 51, 211, 191, 220, 115, 105, 235, 51, 248, 147 }, PasswordSalt = new byte[] { 29, 91, 67, 240, 243, 219, 46, 236, 39, 126, 211, 40, 235, 209, 234, 165, 177, 51, 214, 201, 172, 62, 82, 122, 181, 105, 93, 250, 84, 166, 247, 102 }, UserId = new Guid("4f49ea3c-339a-4493-9a0f-b1af2b9dac6b"), UserName = "admin" },
                        new { LoginId = new Guid("a4c3a7b8-5878-4474-adcc-cd822e53747c"), PasswordHash = new byte[] { 92, 121, 59, 110, 8, 160, 15, 145, 174, 65, 136, 229, 64, 94, 95, 110, 67, 50, 126, 28, 79, 62, 26, 45, 169, 127, 16, 38, 13, 23, 35, 127 }, PasswordSalt = new byte[] { 134, 39, 51, 18, 47, 62, 86, 121, 229, 237, 36, 46, 129, 179, 225, 49, 23, 107, 217, 244, 61, 237, 187, 83, 197, 195, 190, 41, 180, 205, 66, 224 }, UserId = new Guid("cb9cc2de-0d6e-40e2-b9f2-ec17666bac8b"), UserName = "jaap" }
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
                        new { RoleId = new Guid("5dcbaf44-7299-4463-9264-2a38a45fd802"), RoleName = "User" },
                        new { RoleId = new Guid("960b2188-1b83-41b6-8693-39e98556a931"), RoleName = "Manager" },
                        new { RoleId = new Guid("b5bd42fd-341d-4e50-a705-1f5e41d50487"), RoleName = "Admin" }
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
                        new { UserId = new Guid("4f49ea3c-339a-4493-9a0f-b1af2b9dac6b"), FirstName = "Super", LastName = "Admin" },
                        new { UserId = new Guid("cb9cc2de-0d6e-40e2-b9f2-ec17666bac8b"), FirstName = "Jaap", LastName = "Schaap" }
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
                        new { UserId = new Guid("4f49ea3c-339a-4493-9a0f-b1af2b9dac6b"), RoleId = new Guid("5dcbaf44-7299-4463-9264-2a38a45fd802") },
                        new { UserId = new Guid("4f49ea3c-339a-4493-9a0f-b1af2b9dac6b"), RoleId = new Guid("b5bd42fd-341d-4e50-a705-1f5e41d50487") },
                        new { UserId = new Guid("cb9cc2de-0d6e-40e2-b9f2-ec17666bac8b"), RoleId = new Guid("5dcbaf44-7299-4463-9264-2a38a45fd802") },
                        new { UserId = new Guid("cb9cc2de-0d6e-40e2-b9f2-ec17666bac8b"), RoleId = new Guid("960b2188-1b83-41b6-8693-39e98556a931") }
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
