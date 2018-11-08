using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoffeeAPI.Migrations
{
    public partial class AddCountToOrderLine : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("4e77f47f-5596-4d23-9d53-8177b9dec1cd"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("8b6cc636-d490-483e-95d6-87c64f934499"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("c9b2fede-fe38-4779-93e1-dc62095322e8"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("d4f160fc-e011-4610-8b8b-815e8f2fa85d"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("de38b331-a8e3-404b-88bd-8ba23f66e1b3"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("f28dfbf2-476c-48a5-9b89-929f7fdeb77c"));

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: new Guid("5a150693-44bc-4e38-be25-1ed3d3ae1c54"));

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: new Guid("a3e45372-9eeb-4a88-a38c-45d875909680"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "OrderStatusId",
                keyValue: new Guid("689b865d-711e-4693-a139-6ca772e40d03"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("39b19c70-5009-4481-b7b6-93e2a95463cc"), new Guid("42d3cd7d-c4e7-4907-b06c-d6849de8124b") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("39b19c70-5009-4481-b7b6-93e2a95463cc"), new Guid("e5e9d881-5aec-4bd7-ad64-ae811960a7f5") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("82586399-a721-4f7c-8d3f-83ccab9409a9"), new Guid("e5e9d881-5aec-4bd7-ad64-ae811960a7f5") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("82586399-a721-4f7c-8d3f-83ccab9409a9"), new Guid("f797c3ff-ef4f-4efc-a574-d069551fcc39") });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("42d3cd7d-c4e7-4907-b06c-d6849de8124b"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("e5e9d881-5aec-4bd7-ad64-ae811960a7f5"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("f797c3ff-ef4f-4efc-a574-d069551fcc39"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("39b19c70-5009-4481-b7b6-93e2a95463cc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("82586399-a721-4f7c-8d3f-83ccab9409a9"));

            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "OrderLines",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Count",
                table: "OrderLines");

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "DrinkId", "Additions", "Available", "drinkName", "ImageUrl" },
                values: new object[,]
                {
                    { new Guid("f28dfbf2-476c-48a5-9b89-929f7fdeb77c"), true, true, "Koffie", "/assets/Images/Koffie.jpg" },
                    { new Guid("4e77f47f-5596-4d23-9d53-8177b9dec1cd"), true, true, "Cappuccino", "/assets/Images/Cappuccino.jpg" },
                    { new Guid("8b6cc636-d490-483e-95d6-87c64f934499"), true, true, "Latte Macchiato", "/assets/Images/Latte Macchiato.jpg" },
                    { new Guid("c9b2fede-fe38-4779-93e1-dc62095322e8"), true, true, "Espresso", "/assets/Images/Espresso.png" },
                    { new Guid("d4f160fc-e011-4610-8b8b-815e8f2fa85d"), true, true, "Thee", "/assets/Images/Thee.jpg" },
                    { new Guid("de38b331-a8e3-404b-88bd-8ba23f66e1b3"), false, true, "Water", "/assets/Images/Water.jpg" }
                });

            migrationBuilder.InsertData(
                table: "OrderStatuses",
                columns: new[] { "OrderStatusId", "StatusName" },
                values: new object[] { new Guid("689b865d-711e-4693-a139-6ca772e40d03"), "Ordered" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "RoleName" },
                values: new object[,]
                {
                    { new Guid("e5e9d881-5aec-4bd7-ad64-ae811960a7f5"), "User" },
                    { new Guid("42d3cd7d-c4e7-4907-b06c-d6849de8124b"), "Manager" },
                    { new Guid("f797c3ff-ef4f-4efc-a574-d069551fcc39"), "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Active", "FirstName", "LastName", "PrefrenceDrinkId" },
                values: new object[,]
                {
                    { new Guid("82586399-a721-4f7c-8d3f-83ccab9409a9"), true, "Super", "Admin", null },
                    { new Guid("39b19c70-5009-4481-b7b6-93e2a95463cc"), true, "Jaap", "Schaap", null }
                });

            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "LoginId", "PasswordHash", "PasswordSalt", "UserId", "UserName" },
                values: new object[,]
                {
                    { new Guid("5a150693-44bc-4e38-be25-1ed3d3ae1c54"), new byte[] { 127, 64, 13, 198, 197, 166, 78, 149, 67, 66, 167, 156, 149, 106, 97, 175, 177, 171, 16, 76, 76, 90, 44, 243, 228, 206, 208, 117, 5, 254, 62, 251 }, new byte[] { 200, 160, 176, 211, 241, 44, 100, 69, 137, 77, 91, 147, 228, 150, 82, 17, 140, 51, 70, 89, 188, 99, 240, 96, 243, 247, 81, 22, 192, 99, 200, 114 }, new Guid("82586399-a721-4f7c-8d3f-83ccab9409a9"), "admin" },
                    { new Guid("a3e45372-9eeb-4a88-a38c-45d875909680"), new byte[] { 227, 234, 135, 135, 10, 245, 94, 99, 44, 136, 51, 19, 230, 176, 52, 146, 177, 99, 126, 22, 231, 72, 102, 210, 35, 212, 185, 133, 139, 160, 46, 48 }, new byte[] { 106, 23, 233, 131, 12, 21, 195, 73, 61, 40, 143, 94, 197, 140, 200, 115, 123, 5, 110, 130, 130, 57, 244, 103, 241, 182, 70, 129, 115, 110, 1, 226 }, new Guid("39b19c70-5009-4481-b7b6-93e2a95463cc"), "jaap" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { new Guid("82586399-a721-4f7c-8d3f-83ccab9409a9"), new Guid("e5e9d881-5aec-4bd7-ad64-ae811960a7f5") },
                    { new Guid("82586399-a721-4f7c-8d3f-83ccab9409a9"), new Guid("f797c3ff-ef4f-4efc-a574-d069551fcc39") },
                    { new Guid("39b19c70-5009-4481-b7b6-93e2a95463cc"), new Guid("e5e9d881-5aec-4bd7-ad64-ae811960a7f5") },
                    { new Guid("39b19c70-5009-4481-b7b6-93e2a95463cc"), new Guid("42d3cd7d-c4e7-4907-b06c-d6849de8124b") }
                });
        }
    }
}
