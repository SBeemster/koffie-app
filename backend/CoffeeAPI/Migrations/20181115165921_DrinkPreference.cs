using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoffeeAPI.Migrations
{
    public partial class DrinkPreference : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("34af5d1d-3e22-470e-9f9f-a5ae6d252c7a"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("41dca43b-4d37-42bb-ae34-baed178df09a"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("4fbc52ac-f258-45f7-a7ba-29143342b713"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("758b278d-7483-41bb-8c15-969f71fba28f"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("893f7066-76ea-4c6d-b03e-abc1154dde3d"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("e22b15fb-9a69-4037-b31f-91a381cb9972"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: new Guid("9e7f76c2-2fdf-4f17-a245-f4a78eb37a10"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: new Guid("ae94aa2a-9453-40de-8409-10f47ec9c9d6"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: new Guid("c6e16df5-e901-444b-8abb-82c3f221e40f"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: new Guid("f1d2605f-2b4d-4808-ae16-d99d767a409c"));

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: new Guid("23510a3d-357e-4d3c-81e8-715af567eaa7"));

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: new Guid("b1b8e57c-457a-42f5-be39-445056bcfc57"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "OrderStatusId",
                keyValue: new Guid("170e0c58-f878-4979-baca-b5273b344a35"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "OrderStatusId",
                keyValue: new Guid("c19b3826-ecc7-41fa-92ab-27c674afc3f2"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("4406796c-fe8d-41f0-b521-edbeeecf1bab"), new Guid("6f45a612-8fd5-4b4a-b6c5-4e4c41cc108a") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("4406796c-fe8d-41f0-b521-edbeeecf1bab"), new Guid("84ba19c0-49a0-457e-a84f-695751826f08") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("678052a2-ded1-4809-8452-655c493f35d2"), new Guid("47479cd3-4d33-4bf9-93c5-1bc523cf8862") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("678052a2-ded1-4809-8452-655c493f35d2"), new Guid("6f45a612-8fd5-4b4a-b6c5-4e4c41cc108a") });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("47479cd3-4d33-4bf9-93c5-1bc523cf8862"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("6f45a612-8fd5-4b4a-b6c5-4e4c41cc108a"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("84ba19c0-49a0-457e-a84f-695751826f08"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("4406796c-fe8d-41f0-b521-edbeeecf1bab"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("678052a2-ded1-4809-8452-655c493f35d2"));

            migrationBuilder.CreateTable(
                name: "DrinkPreference",
                columns: table => new
                {
                    Preferenceid = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    DrinkId = table.Column<Guid>(nullable: false),
                    Milk = table.Column<int>(nullable: false),
                    Sugar = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrinkPreference", x => x.Preferenceid);
                    table.ForeignKey(
                        name: "FK_DrinkPreference_Drinks_DrinkId",
                        column: x => x.DrinkId,
                        principalTable: "Drinks",
                        principalColumn: "DrinkId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DrinkPreference_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "DrinkId", "Additions", "Available", "ImageUrl", "drinkName" },
                values: new object[,]
                {
                    { new Guid("7174dab5-2d9f-4471-aeb2-7da26d232e22"), true, true, "/assets/Images/Koffie.jpg", "Koffie" },
                    { new Guid("506ea877-250c-4a45-a38b-91294a3281eb"), true, true, "/assets/Images/Cappuccino.jpg", "Cappuccino" },
                    { new Guid("bccedb02-9039-46f5-8673-d75e0335e513"), true, true, "/assets/Images/Latte Macchiato.jpg", "Latte Macchiato" },
                    { new Guid("de0d9cbd-c8c9-4185-8e70-d5b7d3a482fa"), true, true, "/assets/Images/Espresso.png", "Espresso" },
                    { new Guid("fb67d366-82db-488f-8a51-8737f3e731bf"), true, true, "/assets/Images/Thee.jpg", "Thee" },
                    { new Guid("d301fd10-4303-4e47-b9e1-fd319e322fe6"), false, true, "/assets/Images/Water.jpg", "Water" }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "GroupId", "GroupName" },
                values: new object[,]
                {
                    { new Guid("28d6197e-1c64-4e68-94ac-5febb9cdee9d"), "Thee pussy's" },
                    { new Guid("f974747e-41dc-45c1-96ed-1a8b253c33f4"), "Frequently need coffee" },
                    { new Guid("89fa258f-8154-452b-ba03-9ff3ccbaa3f9"), "The addicts" },
                    { new Guid("bcc3dc47-c860-4db4-80b6-baba99a2a495"), "The most drinkers" }
                });

            migrationBuilder.InsertData(
                table: "OrderStatuses",
                columns: new[] { "OrderStatusId", "StatusName" },
                values: new object[,]
                {
                    { new Guid("dd154c53-e21f-4985-8c32-8d49e770c3e0"), "Ordered" },
                    { new Guid("cf491f0a-e431-4f01-a901-089c7c626998"), "Finished" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "RoleName" },
                values: new object[,]
                {
                    { new Guid("42532ca9-3bbc-4117-9da8-aad8a4f0fefc"), "User" },
                    { new Guid("6f35b77d-6f3a-4d95-9715-ee8021b1f8b3"), "Manager" },
                    { new Guid("07c754fa-5b86-4aa5-a5bb-6a32586da063"), "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Active", "FirstName", "LastName", "PrefrenceDrinkId" },
                values: new object[,]
                {
                    { new Guid("a69a80fa-1542-4c75-93a9-2d3e30708e1e"), true, "Super", "Admin", null },
                    { new Guid("bcd4194d-fce0-438c-8e05-99dc127049ae"), true, "Jaap", "Schaap", null }
                });

            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "LoginId", "PasswordHash", "PasswordSalt", "UserId", "UserName" },
                values: new object[,]
                {
                    { new Guid("f880e915-a424-4a78-b3dd-0725eaf04641"), new byte[] { 82, 112, 224, 48, 144, 146, 12, 82, 242, 42, 64, 100, 6, 55, 38, 122, 25, 76, 39, 42, 202, 108, 237, 49, 218, 116, 19, 55, 137, 112, 197, 145 }, new byte[] { 31, 178, 104, 236, 7, 49, 233, 89, 38, 96, 138, 154, 114, 165, 104, 91, 3, 37, 195, 123, 171, 226, 181, 83, 161, 70, 58, 243, 244, 245, 81, 36 }, new Guid("a69a80fa-1542-4c75-93a9-2d3e30708e1e"), "admin" },
                    { new Guid("bfa3dfe1-433e-4880-92fe-470ed565a122"), new byte[] { 140, 181, 5, 42, 89, 235, 80, 125, 246, 146, 20, 185, 43, 57, 128, 179, 132, 214, 228, 91, 137, 0, 43, 94, 227, 40, 211, 154, 62, 150, 223, 192 }, new byte[] { 116, 6, 18, 178, 244, 198, 137, 218, 71, 190, 12, 241, 45, 174, 6, 152, 20, 164, 132, 89, 211, 255, 10, 153, 56, 134, 162, 32, 4, 170, 18, 215 }, new Guid("bcd4194d-fce0-438c-8e05-99dc127049ae"), "jaap" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { new Guid("a69a80fa-1542-4c75-93a9-2d3e30708e1e"), new Guid("42532ca9-3bbc-4117-9da8-aad8a4f0fefc") },
                    { new Guid("a69a80fa-1542-4c75-93a9-2d3e30708e1e"), new Guid("07c754fa-5b86-4aa5-a5bb-6a32586da063") },
                    { new Guid("bcd4194d-fce0-438c-8e05-99dc127049ae"), new Guid("42532ca9-3bbc-4117-9da8-aad8a4f0fefc") },
                    { new Guid("bcd4194d-fce0-438c-8e05-99dc127049ae"), new Guid("6f35b77d-6f3a-4d95-9715-ee8021b1f8b3") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DrinkPreference_DrinkId",
                table: "DrinkPreference",
                column: "DrinkId");

            migrationBuilder.CreateIndex(
                name: "IX_DrinkPreference_UserId",
                table: "DrinkPreference",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DrinkPreference");

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("506ea877-250c-4a45-a38b-91294a3281eb"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("7174dab5-2d9f-4471-aeb2-7da26d232e22"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("bccedb02-9039-46f5-8673-d75e0335e513"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("d301fd10-4303-4e47-b9e1-fd319e322fe6"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("de0d9cbd-c8c9-4185-8e70-d5b7d3a482fa"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("fb67d366-82db-488f-8a51-8737f3e731bf"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: new Guid("28d6197e-1c64-4e68-94ac-5febb9cdee9d"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: new Guid("89fa258f-8154-452b-ba03-9ff3ccbaa3f9"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: new Guid("bcc3dc47-c860-4db4-80b6-baba99a2a495"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: new Guid("f974747e-41dc-45c1-96ed-1a8b253c33f4"));

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: new Guid("bfa3dfe1-433e-4880-92fe-470ed565a122"));

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: new Guid("f880e915-a424-4a78-b3dd-0725eaf04641"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "OrderStatusId",
                keyValue: new Guid("cf491f0a-e431-4f01-a901-089c7c626998"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "OrderStatusId",
                keyValue: new Guid("dd154c53-e21f-4985-8c32-8d49e770c3e0"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("a69a80fa-1542-4c75-93a9-2d3e30708e1e"), new Guid("07c754fa-5b86-4aa5-a5bb-6a32586da063") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("a69a80fa-1542-4c75-93a9-2d3e30708e1e"), new Guid("42532ca9-3bbc-4117-9da8-aad8a4f0fefc") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("bcd4194d-fce0-438c-8e05-99dc127049ae"), new Guid("42532ca9-3bbc-4117-9da8-aad8a4f0fefc") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("bcd4194d-fce0-438c-8e05-99dc127049ae"), new Guid("6f35b77d-6f3a-4d95-9715-ee8021b1f8b3") });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("07c754fa-5b86-4aa5-a5bb-6a32586da063"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("42532ca9-3bbc-4117-9da8-aad8a4f0fefc"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("6f35b77d-6f3a-4d95-9715-ee8021b1f8b3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("a69a80fa-1542-4c75-93a9-2d3e30708e1e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("bcd4194d-fce0-438c-8e05-99dc127049ae"));

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "DrinkId", "Additions", "Available", "ImageUrl", "drinkName" },
                values: new object[,]
                {
                    { new Guid("4fbc52ac-f258-45f7-a7ba-29143342b713"), true, true, "/assets/Images/Koffie.jpg", "Koffie" },
                    { new Guid("893f7066-76ea-4c6d-b03e-abc1154dde3d"), true, true, "/assets/Images/Cappuccino.jpg", "Cappuccino" },
                    { new Guid("758b278d-7483-41bb-8c15-969f71fba28f"), true, true, "/assets/Images/Latte Macchiato.jpg", "Latte Macchiato" },
                    { new Guid("e22b15fb-9a69-4037-b31f-91a381cb9972"), true, true, "/assets/Images/Espresso.png", "Espresso" },
                    { new Guid("41dca43b-4d37-42bb-ae34-baed178df09a"), true, true, "/assets/Images/Thee.jpg", "Thee" },
                    { new Guid("34af5d1d-3e22-470e-9f9f-a5ae6d252c7a"), false, true, "/assets/Images/Water.jpg", "Water" }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "GroupId", "GroupName" },
                values: new object[,]
                {
                    { new Guid("ae94aa2a-9453-40de-8409-10f47ec9c9d6"), "Thee pussy's" },
                    { new Guid("f1d2605f-2b4d-4808-ae16-d99d767a409c"), "Frequently need coffee" },
                    { new Guid("9e7f76c2-2fdf-4f17-a245-f4a78eb37a10"), "The addicts" },
                    { new Guid("c6e16df5-e901-444b-8abb-82c3f221e40f"), "The most drinkers" }
                });

            migrationBuilder.InsertData(
                table: "OrderStatuses",
                columns: new[] { "OrderStatusId", "StatusName" },
                values: new object[,]
                {
                    { new Guid("c19b3826-ecc7-41fa-92ab-27c674afc3f2"), "Ordered" },
                    { new Guid("170e0c58-f878-4979-baca-b5273b344a35"), "Finished" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "RoleName" },
                values: new object[,]
                {
                    { new Guid("6f45a612-8fd5-4b4a-b6c5-4e4c41cc108a"), "User" },
                    { new Guid("47479cd3-4d33-4bf9-93c5-1bc523cf8862"), "Manager" },
                    { new Guid("84ba19c0-49a0-457e-a84f-695751826f08"), "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Active", "FirstName", "LastName", "PrefrenceDrinkId" },
                values: new object[,]
                {
                    { new Guid("4406796c-fe8d-41f0-b521-edbeeecf1bab"), true, "Super", "Admin", null },
                    { new Guid("678052a2-ded1-4809-8452-655c493f35d2"), true, "Jaap", "Schaap", null }
                });

            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "LoginId", "PasswordHash", "PasswordSalt", "UserId", "UserName" },
                values: new object[,]
                {
                    { new Guid("b1b8e57c-457a-42f5-be39-445056bcfc57"), new byte[] { 1, 129, 45, 215, 45, 188, 176, 54, 52, 159, 104, 196, 66, 140, 121, 202, 159, 65, 254, 61, 86, 47, 82, 117, 41, 100, 117, 183, 163, 102, 83, 119 }, new byte[] { 210, 178, 36, 38, 31, 3, 64, 112, 199, 198, 10, 1, 143, 111, 34, 55, 23, 55, 216, 74, 66, 224, 221, 169, 123, 81, 95, 244, 150, 73, 20, 145 }, new Guid("4406796c-fe8d-41f0-b521-edbeeecf1bab"), "admin" },
                    { new Guid("23510a3d-357e-4d3c-81e8-715af567eaa7"), new byte[] { 50, 219, 250, 253, 186, 66, 3, 12, 74, 111, 173, 36, 175, 69, 127, 188, 189, 12, 76, 21, 15, 74, 144, 57, 153, 229, 193, 254, 52, 102, 126, 16 }, new byte[] { 117, 166, 62, 215, 212, 108, 201, 142, 221, 32, 125, 211, 6, 249, 8, 2, 36, 165, 79, 126, 220, 51, 244, 204, 205, 109, 60, 106, 97, 63, 175, 120 }, new Guid("678052a2-ded1-4809-8452-655c493f35d2"), "jaap" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { new Guid("4406796c-fe8d-41f0-b521-edbeeecf1bab"), new Guid("6f45a612-8fd5-4b4a-b6c5-4e4c41cc108a") },
                    { new Guid("4406796c-fe8d-41f0-b521-edbeeecf1bab"), new Guid("84ba19c0-49a0-457e-a84f-695751826f08") },
                    { new Guid("678052a2-ded1-4809-8452-655c493f35d2"), new Guid("6f45a612-8fd5-4b4a-b6c5-4e4c41cc108a") },
                    { new Guid("678052a2-ded1-4809-8452-655c493f35d2"), new Guid("47479cd3-4d33-4bf9-93c5-1bc523cf8862") }
                });
        }
    }
}
