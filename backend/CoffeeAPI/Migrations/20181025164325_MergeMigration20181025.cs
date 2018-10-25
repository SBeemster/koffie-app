using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoffeeAPI.Migrations
{
    public partial class MergeMigration20181025 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drinks",
                columns: table => new
                {
                    DrinkId = table.Column<Guid>(nullable: false),
                    DrinkName = table.Column<string>(nullable: false),
                    Available = table.Column<bool>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drinks", x => x.DrinkId);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    GroupId = table.Column<Guid>(nullable: false),
                    GroupName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.GroupId);
                });

            migrationBuilder.CreateTable(
                name: "OrderStatuses",
                columns: table => new
                {
                    OrderStatusId = table.Column<Guid>(nullable: false),
                    StatusName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderStatuses", x => x.OrderStatusId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<Guid>(nullable: false),
                    RoleName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    PrefrenceDrinkId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_Drinks_PrefrenceDrinkId",
                        column: x => x.PrefrenceDrinkId,
                        principalTable: "Drinks",
                        principalColumn: "DrinkId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Logins",
                columns: table => new
                {
                    LoginId = table.Column<Guid>(nullable: false),
                    UserName = table.Column<string>(nullable: false),
                    PasswordSalt = table.Column<byte[]>(nullable: false),
                    PasswordHash = table.Column<byte[]>(nullable: false),
                    UserId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logins", x => x.LoginId);
                    table.ForeignKey(
                        name: "FK_Logins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderLines",
                columns: table => new
                {
                    OrderLineId = table.Column<Guid>(nullable: false),
                    CustomerUserId = table.Column<Guid>(nullable: false),
                    ServerUserId = table.Column<Guid>(nullable: true),
                    DrinkId = table.Column<Guid>(nullable: false),
                    Sugar = table.Column<int>(nullable: false),
                    Milk = table.Column<int>(nullable: false),
                    OrderStatusId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderLines", x => x.OrderLineId);
                    table.ForeignKey(
                        name: "FK_OrderLines_Users_CustomerUserId",
                        column: x => x.CustomerUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderLines_Drinks_DrinkId",
                        column: x => x.DrinkId,
                        principalTable: "Drinks",
                        principalColumn: "DrinkId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderLines_OrderStatuses_OrderStatusId",
                        column: x => x.OrderStatusId,
                        principalTable: "OrderStatuses",
                        principalColumn: "OrderStatusId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderLines_Users_ServerUserId",
                        column: x => x.ServerUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserGroups",
                columns: table => new
                {
                    UserGroupId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: true),
                    GroupId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserGroups", x => x.UserGroupId);
                    table.ForeignKey(
                        name: "FK_UserGroups_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "GroupId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserGroups_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserRoleId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: true),
                    RoleId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.UserRoleId);
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "DrinkId", "Available", "DrinkName", "ImageUrl" },
                values: new object[,]
                {
                    { new Guid("26e1250c-01bd-46bb-99ba-5c12da282fa7"), true, "Koffie", null },
                    { new Guid("3a61aee8-0868-493e-8876-cdf5dd2edee4"), true, "Cappuccino", null },
                    { new Guid("cf404ddb-2246-4ffe-ac79-f66d8d96b47a"), true, "Latte Macchiato", null },
                    { new Guid("c15c5bb0-e523-4094-9fd7-76a9e63be318"), true, "Espresso", null },
                    { new Guid("a15013d5-a30b-4983-9e2f-7b6fcd85b073"), true, "Thee", null }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "RoleName" },
                values: new object[,]
                {
                    { new Guid("beea9893-9114-4536-98a1-88ea39e68455"), "User" },
                    { new Guid("e251b626-3498-4de8-8f9b-f184b024386d"), "Manager" },
                    { new Guid("9a040110-6ced-492e-a6f9-9134a55d21c0"), "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "FirstName", "LastName", "PrefrenceDrinkId" },
                values: new object[] { new Guid("2cc1bb28-c12e-4f2c-a63a-138725f28b57"), "Jaap", "Schaap", null });

            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "LoginId", "PasswordHash", "PasswordSalt", "UserId", "UserName" },
                values: new object[] { new Guid("69442c12-0951-4576-9937-52389c3dc9fb"), new byte[] { 103, 185, 6, 217, 166, 141, 163, 87, 44, 54, 164, 35, 216, 248, 130, 2, 1, 242, 31, 250, 32, 11, 200, 167, 236, 191, 155, 5, 19, 63, 134, 44 }, new byte[] { 50, 95, 79, 228, 165, 228, 78, 142, 36, 222, 173, 149, 54, 5, 45, 39, 97, 162, 162, 6, 117, 38, 95, 76, 183, 155, 29, 208, 103, 56, 91, 141 }, new Guid("2cc1bb28-c12e-4f2c-a63a-138725f28b57"), "jaap" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserRoleId", "RoleId", "UserId" },
                values: new object[] { new Guid("92764fce-faa4-491a-ba72-33cdafdffe71"), new Guid("beea9893-9114-4536-98a1-88ea39e68455"), new Guid("2cc1bb28-c12e-4f2c-a63a-138725f28b57") });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserRoleId", "RoleId", "UserId" },
                values: new object[] { new Guid("f3d2f341-7964-4caf-ad28-27ed0b1cba87"), new Guid("e251b626-3498-4de8-8f9b-f184b024386d"), new Guid("2cc1bb28-c12e-4f2c-a63a-138725f28b57") });

            migrationBuilder.CreateIndex(
                name: "IX_Logins_UserId",
                table: "Logins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Logins_UserName",
                table: "Logins",
                column: "UserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderLines_CustomerUserId",
                table: "OrderLines",
                column: "CustomerUserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderLines_DrinkId",
                table: "OrderLines",
                column: "DrinkId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderLines_OrderStatusId",
                table: "OrderLines",
                column: "OrderStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderLines_ServerUserId",
                table: "OrderLines",
                column: "ServerUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserGroups_GroupId",
                table: "UserGroups",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_UserGroups_UserId",
                table: "UserGroups",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserId",
                table: "UserRoles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_PrefrenceDrinkId",
                table: "Users",
                column: "PrefrenceDrinkId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Logins");

            migrationBuilder.DropTable(
                name: "OrderLines");

            migrationBuilder.DropTable(
                name: "UserGroups");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "OrderStatuses");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Drinks");
        }
    }
}
