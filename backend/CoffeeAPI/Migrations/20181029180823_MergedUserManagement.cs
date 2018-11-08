using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoffeeAPI.Migrations
{
    public partial class MergedUserManagement : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drinks",
                columns: table => new
                {
                    DrinkId = table.Column<Guid>(nullable: false),
                    drinkName = table.Column<string>(nullable: false),
                    Available = table.Column<bool>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    Additions = table.Column<bool>(nullable: false)
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
                    PrefrenceDrinkId = table.Column<Guid>(nullable: true),
                    Active = table.Column<bool>(nullable: false)
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
                    UserId = table.Column<Guid>(nullable: false),
                    GroupId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserGroups", x => new { x.UserId, x.GroupId });
                    table.ForeignKey(
                        name: "FK_UserGroups_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "GroupId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserGroups_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    RoleId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "DrinkId", "Additions", "Available", "drinkName", "ImageUrl" },
                values: new object[,]
                {
                    { new Guid("ae084356-a070-4878-a8fd-a460bd48c111"), true, true, "Koffie", "/assets/Images/Koffie.jpg" },
                    { new Guid("42fe4253-e740-47a2-a8d8-e1e8c98662b2"), true, true, "Cappuccino", "/assets/Images/Cappuccino.jpg" },
                    { new Guid("d29225bc-866c-410f-aca2-46a153696901"), true, true, "Latte Macchiato", "/assets/Images/Latte Macchiato.jpg" },
                    { new Guid("21b7590e-57ac-4998-b6ce-b30e16cc5fe0"), true, true, "Espresso", "/assets/Images/Espresso.png" },
                    { new Guid("b9f1d17c-bf57-4914-909f-ca2930046068"), true, true, "Thee", "/assets/Images/Thee.jpg" },
                    { new Guid("40ce9245-f89b-464c-bc77-c60f53c9aac0"), false, true, "Water", "/assets/Images/Water.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "RoleName" },
                values: new object[,]
                {
                    { new Guid("6d4f78dd-0275-4e5a-b21d-5968176e7e29"), "User" },
                    { new Guid("160b2bdd-0402-4a7d-974b-07ab26b182f8"), "Manager" },
                    { new Guid("1b126cee-0250-4b64-b30b-0bf26898636c"), "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Active", "FirstName", "LastName", "PrefrenceDrinkId" },
                values: new object[,]
                {
                    { new Guid("8e40d6a9-7f58-4982-a25c-54aa89ac987e"), true, "Super", "Admin", null },
                    { new Guid("20d39328-0703-441c-be7d-236990da8961"), true, "Jaap", "Schaap", null }
                });

            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "LoginId", "PasswordHash", "PasswordSalt", "UserId", "UserName" },
                values: new object[,]
                {
                    { new Guid("230c5365-725e-4a5c-904c-61f9c755b90b"), new byte[] { 244, 136, 40, 72, 163, 228, 235, 230, 64, 57, 179, 16, 80, 1, 113, 121, 119, 91, 221, 206, 185, 198, 1, 33, 90, 130, 225, 244, 145, 30, 217, 194 }, new byte[] { 41, 163, 31, 152, 251, 26, 117, 51, 20, 55, 46, 89, 87, 149, 203, 154, 69, 211, 182, 245, 3, 42, 15, 4, 83, 227, 209, 136, 78, 173, 130, 106 }, new Guid("8e40d6a9-7f58-4982-a25c-54aa89ac987e"), "admin" },
                    { new Guid("816d9ca4-ecb2-436e-bc60-6251ccdf88d9"), new byte[] { 209, 29, 50, 116, 92, 196, 0, 52, 89, 150, 186, 235, 202, 114, 128, 85, 181, 207, 85, 191, 86, 103, 173, 199, 190, 178, 52, 159, 252, 42, 174, 89 }, new byte[] { 134, 117, 114, 164, 25, 99, 136, 83, 228, 232, 22, 76, 28, 121, 165, 84, 238, 209, 240, 255, 189, 19, 183, 111, 40, 199, 175, 190, 126, 23, 234, 77 }, new Guid("20d39328-0703-441c-be7d-236990da8961"), "jaap" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { new Guid("8e40d6a9-7f58-4982-a25c-54aa89ac987e"), new Guid("6d4f78dd-0275-4e5a-b21d-5968176e7e29") },
                    { new Guid("8e40d6a9-7f58-4982-a25c-54aa89ac987e"), new Guid("1b126cee-0250-4b64-b30b-0bf26898636c") },
                    { new Guid("20d39328-0703-441c-be7d-236990da8961"), new Guid("6d4f78dd-0275-4e5a-b21d-5968176e7e29") },
                    { new Guid("20d39328-0703-441c-be7d-236990da8961"), new Guid("160b2bdd-0402-4a7d-974b-07ab26b182f8") }
                });

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
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

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
