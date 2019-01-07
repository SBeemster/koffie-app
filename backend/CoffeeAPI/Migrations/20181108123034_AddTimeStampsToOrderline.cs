using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoffeeAPI.Migrations
{
    public partial class AddTimeStampsToOrderline : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("024c78e3-7b31-4515-b9d4-4ba37ad6a140"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("3d45c301-0ec8-41ca-8ca9-fa0f11281841"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("665aaffe-7846-4790-9a98-11ce1dcbe50f"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("8536b511-b4b7-4410-94bb-f6dacf410251"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("8aff668d-1f5a-4ed0-a691-38ad33bf9911"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("c70a369a-1792-49f8-a7b3-25cf50ee5d06"));

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: new Guid("83f9e364-b745-454a-ba78-8c714b99eee7"));

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: new Guid("a71104c2-605f-4ad0-a235-802d708c8fce"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "OrderStatusId",
                keyValue: new Guid("6706a0ee-2181-4769-8e30-f75c9fbd47c6"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "OrderStatusId",
                keyValue: new Guid("b945f4d5-07db-4b73-8867-61245cf5beb8"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("343a7f87-e2d1-4495-b1f2-19db3c6a874c"), new Guid("53e0bf21-2338-42c5-bc62-d4d7b57a4a63") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("343a7f87-e2d1-4495-b1f2-19db3c6a874c"), new Guid("f2d2eb0f-f1c3-43ed-afbd-3d40fc5c1a28") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("9c9769c1-40a7-4daa-85aa-84fa645b05b8"), new Guid("53e0bf21-2338-42c5-bc62-d4d7b57a4a63") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("9c9769c1-40a7-4daa-85aa-84fa645b05b8"), new Guid("edb3ed9f-7b60-4ead-8b05-980fd94d604b") });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("53e0bf21-2338-42c5-bc62-d4d7b57a4a63"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("edb3ed9f-7b60-4ead-8b05-980fd94d604b"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("f2d2eb0f-f1c3-43ed-afbd-3d40fc5c1a28"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("343a7f87-e2d1-4495-b1f2-19db3c6a874c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("9c9769c1-40a7-4daa-85aa-84fa645b05b8"));

            migrationBuilder.AddColumn<DateTime>(
                name: "GetTime",
                table: "OrderLines",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "OrderTime",
                table: "OrderLines",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "DrinkId", "Additions", "Available", "drinkName", "ImageUrl" },
                values: new object[,]
                {
                    { new Guid("63797877-4310-48d4-8307-de09fd4f8fcd"), true, true, "Koffie", "/assets/Images/Koffie.jpg" },
                    { new Guid("6d08ef49-fc75-4987-b9b1-34a5078f30e1"), true, true, "Cappuccino", "/assets/Images/Cappuccino.jpg" },
                    { new Guid("61ddbe0f-7fb5-4a8c-9f0b-8f68438b66ad"), true, true, "Latte Macchiato", "/assets/Images/Latte Macchiato.jpg" },
                    { new Guid("56d8141e-748e-41c5-8850-95040c5ff7ad"), true, true, "Espresso", "/assets/Images/Espresso.png" },
                    { new Guid("2981af22-d936-41a8-9537-e05cea5b7fd9"), true, true, "Thee", "/assets/Images/Thee.jpg" },
                    { new Guid("39110afe-0ff4-4e0e-8579-4ee86efd3014"), false, true, "Water", "/assets/Images/Water.jpg" }
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "GetTime",
                table: "OrderLines");

            migrationBuilder.DropColumn(
                name: "OrderTime",
                table: "OrderLines");

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "DrinkId", "Additions", "Available", "drinkName", "ImageUrl" },
                values: new object[,]
                {
                    { new Guid("8aff668d-1f5a-4ed0-a691-38ad33bf9911"), true, true, "Koffie", "/assets/Images/Koffie.jpg" },
                    { new Guid("3d45c301-0ec8-41ca-8ca9-fa0f11281841"), true, true, "Cappuccino", "/assets/Images/Cappuccino.jpg" },
                    { new Guid("8536b511-b4b7-4410-94bb-f6dacf410251"), true, true, "Latte Macchiato", "/assets/Images/Latte Macchiato.jpg" },
                    { new Guid("c70a369a-1792-49f8-a7b3-25cf50ee5d06"), true, true, "Espresso", "/assets/Images/Espresso.png" },
                    { new Guid("665aaffe-7846-4790-9a98-11ce1dcbe50f"), true, true, "Thee", "/assets/Images/Thee.jpg" },
                    { new Guid("024c78e3-7b31-4515-b9d4-4ba37ad6a140"), false, true, "Water", "/assets/Images/Water.jpg" }
                });

            migrationBuilder.InsertData(
                table: "OrderStatuses",
                columns: new[] { "OrderStatusId", "StatusName" },
                values: new object[,]
                {
                    { new Guid("6706a0ee-2181-4769-8e30-f75c9fbd47c6"), "Ordered" },
                    { new Guid("b945f4d5-07db-4b73-8867-61245cf5beb8"), "Finished" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "RoleName" },
                values: new object[,]
                {
                    { new Guid("53e0bf21-2338-42c5-bc62-d4d7b57a4a63"), "User" },
                    { new Guid("f2d2eb0f-f1c3-43ed-afbd-3d40fc5c1a28"), "Manager" },
                    { new Guid("edb3ed9f-7b60-4ead-8b05-980fd94d604b"), "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Active", "FirstName", "LastName", "PrefrenceDrinkId" },
                values: new object[,]
                {
                    { new Guid("9c9769c1-40a7-4daa-85aa-84fa645b05b8"), true, "Super", "Admin", null },
                    { new Guid("343a7f87-e2d1-4495-b1f2-19db3c6a874c"), true, "Jaap", "Schaap", null }
                });

            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "LoginId", "PasswordHash", "PasswordSalt", "UserId", "UserName" },
                values: new object[,]
                {
                    { new Guid("a71104c2-605f-4ad0-a235-802d708c8fce"), new byte[] { 201, 24, 255, 174, 22, 82, 122, 49, 191, 128, 187, 247, 74, 55, 34, 0, 115, 157, 68, 37, 60, 68, 170, 24, 211, 109, 73, 102, 231, 22, 43, 112 }, new byte[] { 215, 49, 121, 181, 184, 162, 165, 141, 120, 242, 83, 138, 92, 215, 31, 124, 64, 196, 171, 197, 172, 169, 227, 175, 108, 64, 169, 27, 53, 30, 187, 68 }, new Guid("9c9769c1-40a7-4daa-85aa-84fa645b05b8"), "admin" },
                    { new Guid("83f9e364-b745-454a-ba78-8c714b99eee7"), new byte[] { 49, 64, 71, 213, 216, 77, 100, 22, 80, 78, 232, 142, 157, 250, 208, 141, 211, 149, 161, 60, 199, 182, 139, 246, 0, 177, 89, 62, 194, 157, 109, 108 }, new byte[] { 8, 54, 101, 116, 235, 153, 8, 128, 148, 25, 31, 74, 52, 62, 36, 11, 221, 68, 169, 121, 195, 67, 145, 176, 50, 52, 222, 246, 71, 202, 33, 116 }, new Guid("343a7f87-e2d1-4495-b1f2-19db3c6a874c"), "jaap" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { new Guid("9c9769c1-40a7-4daa-85aa-84fa645b05b8"), new Guid("53e0bf21-2338-42c5-bc62-d4d7b57a4a63") },
                    { new Guid("9c9769c1-40a7-4daa-85aa-84fa645b05b8"), new Guid("edb3ed9f-7b60-4ead-8b05-980fd94d604b") },
                    { new Guid("343a7f87-e2d1-4495-b1f2-19db3c6a874c"), new Guid("53e0bf21-2338-42c5-bc62-d4d7b57a4a63") },
                    { new Guid("343a7f87-e2d1-4495-b1f2-19db3c6a874c"), new Guid("f2d2eb0f-f1c3-43ed-afbd-3d40fc5c1a28") }
                });
        }
    }
}
