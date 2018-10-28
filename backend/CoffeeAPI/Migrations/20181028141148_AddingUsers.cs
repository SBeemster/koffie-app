using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoffeeAPI.Migrations
{
    public partial class AddingUsers : Migration
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
                    { new Guid("b7a04987-a4c5-4565-841e-4b56face2544"), true, "Koffie", "/assets/Images/Koffie.jpg" },
                    { new Guid("68ed037d-4092-41bd-aff3-e8021f158822"), true, "Cappuccino", "/assets/Images/Cappuccino.jpg" },
                    { new Guid("1e726bb6-3d0e-4cd7-aa04-fd95564a0576"), true, "Latte Macchiato", "/assets/Images/Latte Macchiato.jpg" },
                    { new Guid("2d99e759-efae-4638-b5fd-a352ef1b9158"), true, "Espresso", "/assets/Images/Espresso.png" },
                    { new Guid("af6d14ea-a772-4a91-afcf-cb8418521939"), true, "Thee", "/assets/Images/Thee.jpg" },
                    { new Guid("5a268737-c318-4869-91ea-a408afb08f6c"), true, "Water", "/assets/Images/Water.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "RoleName" },
                values: new object[,]
                {
                    { new Guid("5dcbaf44-7299-4463-9264-2a38a45fd802"), "User" },
                    { new Guid("960b2188-1b83-41b6-8693-39e98556a931"), "Manager" },
                    { new Guid("b5bd42fd-341d-4e50-a705-1f5e41d50487"), "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "FirstName", "LastName", "PrefrenceDrinkId" },
                values: new object[,]
                {
                    { new Guid("4f49ea3c-339a-4493-9a0f-b1af2b9dac6b"), "Super", "Admin", null },
                    { new Guid("cb9cc2de-0d6e-40e2-b9f2-ec17666bac8b"), "Jaap", "Schaap", null }
                });

            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "LoginId", "PasswordHash", "PasswordSalt", "UserId", "UserName" },
                values: new object[,]
                {
                    { new Guid("826695ba-27dd-4a70-b164-da6c3c839d2f"), new byte[] { 226, 207, 245, 189, 37, 91, 167, 172, 172, 129, 99, 29, 214, 127, 171, 213, 9, 54, 144, 189, 193, 26, 51, 211, 191, 220, 115, 105, 235, 51, 248, 147 }, new byte[] { 29, 91, 67, 240, 243, 219, 46, 236, 39, 126, 211, 40, 235, 209, 234, 165, 177, 51, 214, 201, 172, 62, 82, 122, 181, 105, 93, 250, 84, 166, 247, 102 }, new Guid("4f49ea3c-339a-4493-9a0f-b1af2b9dac6b"), "admin" },
                    { new Guid("a4c3a7b8-5878-4474-adcc-cd822e53747c"), new byte[] { 92, 121, 59, 110, 8, 160, 15, 145, 174, 65, 136, 229, 64, 94, 95, 110, 67, 50, 126, 28, 79, 62, 26, 45, 169, 127, 16, 38, 13, 23, 35, 127 }, new byte[] { 134, 39, 51, 18, 47, 62, 86, 121, 229, 237, 36, 46, 129, 179, 225, 49, 23, 107, 217, 244, 61, 237, 187, 83, 197, 195, 190, 41, 180, 205, 66, 224 }, new Guid("cb9cc2de-0d6e-40e2-b9f2-ec17666bac8b"), "jaap" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { new Guid("4f49ea3c-339a-4493-9a0f-b1af2b9dac6b"), new Guid("5dcbaf44-7299-4463-9264-2a38a45fd802") },
                    { new Guid("4f49ea3c-339a-4493-9a0f-b1af2b9dac6b"), new Guid("b5bd42fd-341d-4e50-a705-1f5e41d50487") },
                    { new Guid("cb9cc2de-0d6e-40e2-b9f2-ec17666bac8b"), new Guid("5dcbaf44-7299-4463-9264-2a38a45fd802") },
                    { new Guid("cb9cc2de-0d6e-40e2-b9f2-ec17666bac8b"), new Guid("960b2188-1b83-41b6-8693-39e98556a931") }
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
