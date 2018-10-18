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
    [Migration("20181018075717_ReplacedStockForAvailableinDrinks")]
    partial class ReplacedStockForAvailableinDrinks
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
                    b.Property<int>("DrinkId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Available");

                    b.Property<string>("DrinkName")
                        .IsRequired();

                    b.Property<string>("ImageUrl");

                    b.HasKey("DrinkId");

                    b.ToTable("Drinks");
                });

            modelBuilder.Entity("CoffeeAPI.Models.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GroupName")
                        .IsRequired();

                    b.HasKey("GroupId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("CoffeeAPI.Models.OrderLine", b =>
                {
                    b.Property<int>("OrderLineId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerUserId");

                    b.Property<int>("DrinkId");

                    b.Property<int>("Milk");

                    b.Property<int?>("OrderStatusId");

                    b.Property<int?>("ServerUserId");

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
                    b.Property<int>("OrderStatusId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("StatusName")
                        .IsRequired();

                    b.HasKey("OrderStatusId");

                    b.ToTable("OrderStatuses");
                });

            modelBuilder.Entity("CoffeeAPI.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RoleName")
                        .IsRequired();

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("CoffeeAPI.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<int?>("PrefrenceDrinkId");

                    b.Property<string>("Salt")
                        .IsRequired();

                    b.Property<string>("UserName")
                        .IsRequired();

                    b.HasKey("UserId");

                    b.HasIndex("PrefrenceDrinkId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CoffeeAPI.Models.UserGroup", b =>
                {
                    b.Property<int>("UserGroupId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("GroupId");

                    b.Property<int?>("UserId");

                    b.HasKey("UserGroupId");

                    b.HasIndex("GroupId");

                    b.HasIndex("UserId");

                    b.ToTable("UserGroups");
                });

            modelBuilder.Entity("CoffeeAPI.Models.UserRole", b =>
                {
                    b.Property<int>("UserRoleId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("RoleId");

                    b.Property<int?>("UserId");

                    b.HasKey("UserRoleId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoles");
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
