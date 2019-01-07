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
    [Migration("20181108123034_AddTimeStampsToOrderline")]
    partial class AddTimeStampsToOrderline
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
                        new { DrinkId = new Guid("63797877-4310-48d4-8307-de09fd4f8fcd"), Additions = true, Available = true, drinkName = "Koffie", ImageUrl = "/assets/Images/Koffie.jpg" },
                        new { DrinkId = new Guid("6d08ef49-fc75-4987-b9b1-34a5078f30e1"), Additions = true, Available = true, drinkName = "Cappuccino", ImageUrl = "/assets/Images/Cappuccino.jpg" },
                        new { DrinkId = new Guid("61ddbe0f-7fb5-4a8c-9f0b-8f68438b66ad"), Additions = true, Available = true, drinkName = "Latte Macchiato", ImageUrl = "/assets/Images/Latte Macchiato.jpg" },
                        new { DrinkId = new Guid("56d8141e-748e-41c5-8850-95040c5ff7ad"), Additions = true, Available = true, drinkName = "Espresso", ImageUrl = "/assets/Images/Espresso.png" },
                        new { DrinkId = new Guid("2981af22-d936-41a8-9537-e05cea5b7fd9"), Additions = true, Available = true, drinkName = "Thee", ImageUrl = "/assets/Images/Thee.jpg" },
                        new { DrinkId = new Guid("39110afe-0ff4-4e0e-8579-4ee86efd3014"), Additions = false, Available = true, drinkName = "Water", ImageUrl = "/assets/Images/Water.jpg" }
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
                        new { LoginId = new Guid("8aee194e-7f50-4e77-b122-a5a41578f56a"), PasswordHash = new byte[] { 14, 171, 216, 209, 202, 42, 135, 91, 246, 94, 28, 95, 20, 192, 63, 22, 154, 32, 67, 254, 126, 18, 187, 247, 174, 112, 64, 9, 68, 97, 229, 23 }, PasswordSalt = new byte[] { 17, 34, 127, 12, 36, 135, 132, 202, 34, 62, 182, 99, 102, 143, 36, 147, 228, 173, 151, 93, 91, 149, 193, 98, 82, 54, 184, 84, 90, 10, 138, 218 }, UserId = new Guid("9347c329-916b-4040-afb9-5ac21de2af6a"), UserName = "admin" },
                        new { LoginId = new Guid("5928ef93-d305-4c95-a46f-b092672a849b"), PasswordHash = new byte[] { 78, 127, 25, 75, 96, 17, 2, 215, 99, 42, 149, 114, 138, 153, 126, 171, 205, 183, 3, 228, 141, 118, 31, 110, 162, 75, 121, 167, 161, 138, 153, 150 }, PasswordSalt = new byte[] { 117, 229, 60, 123, 7, 238, 240, 34, 221, 78, 6, 100, 16, 42, 55, 167, 86, 30, 223, 107, 212, 127, 122, 72, 155, 59, 44, 101, 19, 129, 37, 216 }, UserId = new Guid("f38ee494-2d8e-4c0c-81e4-276aa1787d98"), UserName = "jaap" }
                    );
                });

            modelBuilder.Entity("CoffeeAPI.Models.OrderLine", b =>
                {
                    b.Property<Guid>("OrderLineId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Count");

                    b.Property<Guid>("CustomerUserId");

                    b.Property<Guid>("DrinkId");

                    b.Property<DateTime>("GetTime");

                    b.Property<int>("Milk");

                    b.Property<Guid?>("OrderStatusId");

                    b.Property<DateTime>("OrderTime");

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

                    b.HasData(
                        new { OrderStatusId = new Guid("8ceafbbe-d117-4538-9615-2df2fd730ed1"), StatusName = "Ordered" },
                        new { OrderStatusId = new Guid("893ec008-139b-4fd8-a66f-543927d8584b"), StatusName = "Finished" }
                    );
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
                        new { RoleId = new Guid("4850e812-c529-4b74-b055-ca745334aa28"), RoleName = "User" },
                        new { RoleId = new Guid("165a341b-a2ee-4a85-85c1-57c48108782f"), RoleName = "Manager" },
                        new { RoleId = new Guid("961282b7-55ed-433f-b58e-b608917376e3"), RoleName = "Admin" }
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
                        new { UserId = new Guid("9347c329-916b-4040-afb9-5ac21de2af6a"), Active = true, FirstName = "Super", LastName = "Admin" },
                        new { UserId = new Guid("f38ee494-2d8e-4c0c-81e4-276aa1787d98"), Active = true, FirstName = "Jaap", LastName = "Schaap" }
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
                        new { UserId = new Guid("9347c329-916b-4040-afb9-5ac21de2af6a"), RoleId = new Guid("4850e812-c529-4b74-b055-ca745334aa28") },
                        new { UserId = new Guid("9347c329-916b-4040-afb9-5ac21de2af6a"), RoleId = new Guid("961282b7-55ed-433f-b58e-b608917376e3") },
                        new { UserId = new Guid("f38ee494-2d8e-4c0c-81e4-276aa1787d98"), RoleId = new Guid("4850e812-c529-4b74-b055-ca745334aa28") },
                        new { UserId = new Guid("f38ee494-2d8e-4c0c-81e4-276aa1787d98"), RoleId = new Guid("165a341b-a2ee-4a85-85c1-57c48108782f") }
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
