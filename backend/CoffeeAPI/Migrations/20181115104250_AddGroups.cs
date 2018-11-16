using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoffeeAPI.Migrations
{
    public partial class AddGroups : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("2981af22-d936-41a8-9537-e05cea5b7fd9"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("39110afe-0ff4-4e0e-8579-4ee86efd3014"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("56d8141e-748e-41c5-8850-95040c5ff7ad"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("61ddbe0f-7fb5-4a8c-9f0b-8f68438b66ad"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("63797877-4310-48d4-8307-de09fd4f8fcd"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("6d08ef49-fc75-4987-b9b1-34a5078f30e1"));

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: new Guid("5928ef93-d305-4c95-a46f-b092672a849b"));

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: new Guid("8aee194e-7f50-4e77-b122-a5a41578f56a"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "OrderStatusId",
                keyValue: new Guid("893ec008-139b-4fd8-a66f-543927d8584b"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "OrderStatusId",
                keyValue: new Guid("8ceafbbe-d117-4538-9615-2df2fd730ed1"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("9347c329-916b-4040-afb9-5ac21de2af6a"), new Guid("4850e812-c529-4b74-b055-ca745334aa28") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("9347c329-916b-4040-afb9-5ac21de2af6a"), new Guid("961282b7-55ed-433f-b58e-b608917376e3") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("f38ee494-2d8e-4c0c-81e4-276aa1787d98"), new Guid("165a341b-a2ee-4a85-85c1-57c48108782f") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("f38ee494-2d8e-4c0c-81e4-276aa1787d98"), new Guid("4850e812-c529-4b74-b055-ca745334aa28") });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("165a341b-a2ee-4a85-85c1-57c48108782f"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("4850e812-c529-4b74-b055-ca745334aa28"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("961282b7-55ed-433f-b58e-b608917376e3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("9347c329-916b-4040-afb9-5ac21de2af6a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("f38ee494-2d8e-4c0c-81e4-276aa1787d98"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "DrinkId", "Additions", "Available", "ImageUrl", "drinkName" },
                values: new object[,]
                {
                    { new Guid("63797877-4310-48d4-8307-de09fd4f8fcd"), true, true, "/assets/Images/Koffie.jpg", "Koffie" },
                    { new Guid("6d08ef49-fc75-4987-b9b1-34a5078f30e1"), true, true, "/assets/Images/Cappuccino.jpg", "Cappuccino" },
                    { new Guid("61ddbe0f-7fb5-4a8c-9f0b-8f68438b66ad"), true, true, "/assets/Images/Latte Macchiato.jpg", "Latte Macchiato" },
                    { new Guid("56d8141e-748e-41c5-8850-95040c5ff7ad"), true, true, "/assets/Images/Espresso.png", "Espresso" },
                    { new Guid("2981af22-d936-41a8-9537-e05cea5b7fd9"), true, true, "/assets/Images/Thee.jpg", "Thee" },
                    { new Guid("39110afe-0ff4-4e0e-8579-4ee86efd3014"), false, true, "/assets/Images/Water.jpg", "Water" }
                });

            migrationBuilder.InsertData(
                table: "OrderStatuses",
                columns: new[] { "OrderStatusId", "StatusName" },
                values: new object[,]
                {
                    { new Guid("8ceafbbe-d117-4538-9615-2df2fd730ed1"), "Ordered" },
                    { new Guid("893ec008-139b-4fd8-a66f-543927d8584b"), "Finished" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "RoleName" },
                values: new object[,]
                {
                    { new Guid("4850e812-c529-4b74-b055-ca745334aa28"), "User" },
                    { new Guid("165a341b-a2ee-4a85-85c1-57c48108782f"), "Manager" },
                    { new Guid("961282b7-55ed-433f-b58e-b608917376e3"), "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Active", "FirstName", "LastName", "PrefrenceDrinkId" },
                values: new object[,]
                {
                    { new Guid("9347c329-916b-4040-afb9-5ac21de2af6a"), true, "Super", "Admin", null },
                    { new Guid("f38ee494-2d8e-4c0c-81e4-276aa1787d98"), true, "Jaap", "Schaap", null }
                });

            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "LoginId", "PasswordHash", "PasswordSalt", "UserId", "UserName" },
                values: new object[,]
                {
                    { new Guid("8aee194e-7f50-4e77-b122-a5a41578f56a"), new byte[] { 14, 171, 216, 209, 202, 42, 135, 91, 246, 94, 28, 95, 20, 192, 63, 22, 154, 32, 67, 254, 126, 18, 187, 247, 174, 112, 64, 9, 68, 97, 229, 23 }, new byte[] { 17, 34, 127, 12, 36, 135, 132, 202, 34, 62, 182, 99, 102, 143, 36, 147, 228, 173, 151, 93, 91, 149, 193, 98, 82, 54, 184, 84, 90, 10, 138, 218 }, new Guid("9347c329-916b-4040-afb9-5ac21de2af6a"), "admin" },
                    { new Guid("5928ef93-d305-4c95-a46f-b092672a849b"), new byte[] { 78, 127, 25, 75, 96, 17, 2, 215, 99, 42, 149, 114, 138, 153, 126, 171, 205, 183, 3, 228, 141, 118, 31, 110, 162, 75, 121, 167, 161, 138, 153, 150 }, new byte[] { 117, 229, 60, 123, 7, 238, 240, 34, 221, 78, 6, 100, 16, 42, 55, 167, 86, 30, 223, 107, 212, 127, 122, 72, 155, 59, 44, 101, 19, 129, 37, 216 }, new Guid("f38ee494-2d8e-4c0c-81e4-276aa1787d98"), "jaap" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { new Guid("9347c329-916b-4040-afb9-5ac21de2af6a"), new Guid("4850e812-c529-4b74-b055-ca745334aa28") },
                    { new Guid("9347c329-916b-4040-afb9-5ac21de2af6a"), new Guid("961282b7-55ed-433f-b58e-b608917376e3") },
                    { new Guid("f38ee494-2d8e-4c0c-81e4-276aa1787d98"), new Guid("4850e812-c529-4b74-b055-ca745334aa28") },
                    { new Guid("f38ee494-2d8e-4c0c-81e4-276aa1787d98"), new Guid("165a341b-a2ee-4a85-85c1-57c48108782f") }
                });
        }
    }
}
