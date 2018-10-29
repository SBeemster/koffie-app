using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoffeeAPI.Migrations
{
    public partial class AddedEditing : Migration
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
                columns: new[] { "DrinkId", "Available", "DrinkName", "ImageUrl" },
                values: new object[,]
                {
                    { new Guid("3a99198c-90a6-4e0a-af64-9d71d45ba477"), true, "Koffie", "/assets/Images/Koffie.jpg" },
                    { new Guid("bb048f57-4657-4a99-9166-2ebf5b08585a"), true, "Cappuccino", "/assets/Images/Cappuccino.jpg" },
                    { new Guid("ea11b94c-fb5c-4f7f-9d62-c3dfa05de3b6"), true, "Latte Macchiato", "/assets/Images/Latte Macchiato.jpg" },
                    { new Guid("5de9e271-fd48-4d1d-8c4e-7d9e0ce72f47"), true, "Espresso", "/assets/Images/Espresso.png" },
                    { new Guid("9d2eee48-382b-4ec3-9a55-a762e593f6c1"), true, "Thee", "/assets/Images/Thee.jpg" },
                    { new Guid("12c10314-e7ff-4f01-9414-fea23c7482fc"), true, "Water", "/assets/Images/Water.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "RoleName" },
                values: new object[,]
                {
                    { new Guid("7541f69d-34e4-4309-9e1e-d860866063a0"), "User" },
                    { new Guid("ed50cebb-803e-476e-ae9d-247b44d4dd8f"), "Manager" },
                    { new Guid("fe465b49-5ab0-4c60-9258-9757bcf5f3b0"), "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Active", "FirstName", "LastName", "PrefrenceDrinkId" },
                values: new object[,]
                {
                    { new Guid("5bf25c8c-9df6-4677-a51e-8aeeef178031"), true, "Super", "Admin", null },
                    { new Guid("c8ff9187-86eb-4845-8d94-310a822f9099"), true, "Jaap", "Schaap", null }
                });

            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "LoginId", "PasswordHash", "PasswordSalt", "UserId", "UserName" },
                values: new object[,]
                {
                    { new Guid("2c1acd7d-5c60-4bdd-ab92-393e4c8f8d0d"), new byte[] { 35, 156, 6, 82, 69, 227, 33, 146, 216, 35, 211, 75, 59, 227, 164, 129, 253, 169, 91, 22, 180, 49, 134, 87, 121, 227, 31, 223, 189, 147, 193, 125 }, new byte[] { 20, 191, 206, 165, 123, 50, 211, 161, 158, 215, 226, 179, 100, 127, 114, 149, 181, 9, 207, 216, 33, 184, 253, 135, 143, 214, 171, 101, 129, 78, 202, 48 }, new Guid("5bf25c8c-9df6-4677-a51e-8aeeef178031"), "admin" },
                    { new Guid("2042c4cc-ebc7-44c1-9f52-ccd2d8137c2f"), new byte[] { 60, 118, 187, 1, 232, 20, 112, 244, 61, 78, 54, 229, 150, 117, 194, 79, 233, 207, 180, 151, 106, 187, 115, 192, 232, 226, 208, 135, 114, 132, 22, 29 }, new byte[] { 106, 102, 47, 93, 107, 18, 242, 108, 65, 46, 76, 222, 170, 169, 134, 88, 128, 153, 108, 166, 248, 2, 180, 225, 225, 145, 236, 17, 50, 204, 158, 75 }, new Guid("c8ff9187-86eb-4845-8d94-310a822f9099"), "jaap" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { new Guid("5bf25c8c-9df6-4677-a51e-8aeeef178031"), new Guid("7541f69d-34e4-4309-9e1e-d860866063a0") },
                    { new Guid("5bf25c8c-9df6-4677-a51e-8aeeef178031"), new Guid("fe465b49-5ab0-4c60-9258-9757bcf5f3b0") },
                    { new Guid("c8ff9187-86eb-4845-8d94-310a822f9099"), new Guid("7541f69d-34e4-4309-9e1e-d860866063a0") },
                    { new Guid("c8ff9187-86eb-4845-8d94-310a822f9099"), new Guid("ed50cebb-803e-476e-ae9d-247b44d4dd8f") }
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
