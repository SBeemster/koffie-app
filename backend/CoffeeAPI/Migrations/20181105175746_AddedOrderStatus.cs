using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoffeeAPI.Migrations
{
    public partial class AddedOrderStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("21b7590e-57ac-4998-b6ce-b30e16cc5fe0"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("40ce9245-f89b-464c-bc77-c60f53c9aac0"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("42fe4253-e740-47a2-a8d8-e1e8c98662b2"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("ae084356-a070-4878-a8fd-a460bd48c111"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("b9f1d17c-bf57-4914-909f-ca2930046068"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("d29225bc-866c-410f-aca2-46a153696901"));

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: new Guid("230c5365-725e-4a5c-904c-61f9c755b90b"));

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: new Guid("816d9ca4-ecb2-436e-bc60-6251ccdf88d9"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("20d39328-0703-441c-be7d-236990da8961"), new Guid("160b2bdd-0402-4a7d-974b-07ab26b182f8") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("20d39328-0703-441c-be7d-236990da8961"), new Guid("6d4f78dd-0275-4e5a-b21d-5968176e7e29") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("8e40d6a9-7f58-4982-a25c-54aa89ac987e"), new Guid("1b126cee-0250-4b64-b30b-0bf26898636c") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("8e40d6a9-7f58-4982-a25c-54aa89ac987e"), new Guid("6d4f78dd-0275-4e5a-b21d-5968176e7e29") });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("160b2bdd-0402-4a7d-974b-07ab26b182f8"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("1b126cee-0250-4b64-b30b-0bf26898636c"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("6d4f78dd-0275-4e5a-b21d-5968176e7e29"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("20d39328-0703-441c-be7d-236990da8961"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("8e40d6a9-7f58-4982-a25c-54aa89ac987e"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
