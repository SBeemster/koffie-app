using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoffeeAPI.Migrations
{
    public partial class AddedImageURL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("26e1250c-01bd-46bb-99ba-5c12da282fa7"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("3a61aee8-0868-493e-8876-cdf5dd2edee4"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("a15013d5-a30b-4983-9e2f-7b6fcd85b073"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("c15c5bb0-e523-4094-9fd7-76a9e63be318"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("cf404ddb-2246-4ffe-ac79-f66d8d96b47a"));

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: new Guid("69442c12-0951-4576-9937-52389c3dc9fb"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("9a040110-6ced-492e-a6f9-9134a55d21c0"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "UserRoleId",
                keyValue: new Guid("92764fce-faa4-491a-ba72-33cdafdffe71"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "UserRoleId",
                keyValue: new Guid("f3d2f341-7964-4caf-ad28-27ed0b1cba87"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("beea9893-9114-4536-98a1-88ea39e68455"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("e251b626-3498-4de8-8f9b-f184b024386d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("2cc1bb28-c12e-4f2c-a63a-138725f28b57"));

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "DrinkId", "Available", "DrinkName", "ImageUrl" },
                values: new object[,]
                {
                    { new Guid("f40a9e9d-ed92-4dc7-9b10-2c02e6bf63d4"), true, "Koffie", null },
                    { new Guid("c7792274-2e78-4245-932f-a16cd4793158"), true, "Cappuccino", "/assets/Images/Cappuccino.jpg" },
                    { new Guid("8838856a-d389-4959-b542-888b745a86db"), true, "Latte Macchiato", "/assets/Images/Latte Macchiato.jpg" },
                    { new Guid("d936a5ec-6438-4bc1-bd05-05548fe7e764"), true, "Espresso", null },
                    { new Guid("6bc9a6df-0f20-4952-a1c2-33fc5599205a"), true, "Thee", "/assets/Images/Thee.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "RoleName" },
                values: new object[,]
                {
                    { new Guid("ff96fbd6-03bc-4f5e-bbf8-c7edd8247fa4"), "User" },
                    { new Guid("3c4dbb2d-9129-4010-bdbd-5b1459dee052"), "Manager" },
                    { new Guid("08684c47-b6ef-4353-8110-826537ec5520"), "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "FirstName", "LastName", "PrefrenceDrinkId" },
                values: new object[] { new Guid("35aa280b-5bca-4e4b-a1ba-cb900aa000c7"), "Jaap", "Schaap", null });

            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "LoginId", "PasswordHash", "PasswordSalt", "UserId", "UserName" },
                values: new object[] { new Guid("9bb759c5-bee9-48ef-8855-8fd82607b7a2"), new byte[] { 65, 63, 160, 66, 233, 70, 47, 106, 12, 50, 199, 223, 101, 84, 114, 230, 224, 252, 138, 145, 93, 253, 161, 173, 219, 128, 120, 227, 185, 131, 22, 147 }, new byte[] { 77, 202, 148, 47, 152, 93, 206, 44, 88, 21, 136, 160, 106, 72, 201, 38, 20, 189, 90, 70, 67, 226, 152, 238, 15, 67, 189, 171, 128, 161, 229, 70 }, new Guid("35aa280b-5bca-4e4b-a1ba-cb900aa000c7"), "jaap" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserRoleId", "RoleId", "UserId" },
                values: new object[] { new Guid("e473e940-597b-4484-a1c2-45046c3e44e3"), new Guid("ff96fbd6-03bc-4f5e-bbf8-c7edd8247fa4"), new Guid("35aa280b-5bca-4e4b-a1ba-cb900aa000c7") });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserRoleId", "RoleId", "UserId" },
                values: new object[] { new Guid("83a1157c-7dd5-44b1-8af3-fb33f932953a"), new Guid("3c4dbb2d-9129-4010-bdbd-5b1459dee052"), new Guid("35aa280b-5bca-4e4b-a1ba-cb900aa000c7") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("6bc9a6df-0f20-4952-a1c2-33fc5599205a"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("8838856a-d389-4959-b542-888b745a86db"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("c7792274-2e78-4245-932f-a16cd4793158"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("d936a5ec-6438-4bc1-bd05-05548fe7e764"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("f40a9e9d-ed92-4dc7-9b10-2c02e6bf63d4"));

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: new Guid("9bb759c5-bee9-48ef-8855-8fd82607b7a2"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("08684c47-b6ef-4353-8110-826537ec5520"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "UserRoleId",
                keyValue: new Guid("83a1157c-7dd5-44b1-8af3-fb33f932953a"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "UserRoleId",
                keyValue: new Guid("e473e940-597b-4484-a1c2-45046c3e44e3"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("3c4dbb2d-9129-4010-bdbd-5b1459dee052"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("ff96fbd6-03bc-4f5e-bbf8-c7edd8247fa4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("35aa280b-5bca-4e4b-a1ba-cb900aa000c7"));

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
        }
    }
}
