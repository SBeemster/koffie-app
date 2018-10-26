using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoffeeAPI.Migrations
{
    public partial class AddedWaterAndImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("b8790b5f-ab66-4c0b-95b9-677f723b0cdf"), true, "Koffie", "/assets/Images/Koffie.jpg" },
                    { new Guid("1f0d337b-dd59-4c4c-b98e-3894bbf974c6"), true, "Cappuccino", "/assets/Images/Cappuccino.jpg" },
                    { new Guid("4f53719c-7d97-4912-ab07-b96ab7298dbf"), true, "Latte Macchiato", "/assets/Images/Latte Macchiato.jpg" },
                    { new Guid("03e23eb6-b751-4ea2-8f9e-611df63a926d"), true, "Espresso", "/assets/Images/Espresso.png" },
                    { new Guid("35f25f9a-9420-4434-899c-bfa9a02a4816"), true, "Thee", "/assets/Images/Thee.jpg" },
                    { new Guid("f9157a7d-3109-4e41-9009-b3a4ac86d080"), true, "Water", "/assets/Images/Water.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "RoleName" },
                values: new object[,]
                {
                    { new Guid("b35dba57-e42b-4167-8f01-5a12c5b4883e"), "User" },
                    { new Guid("910b3ddf-974a-44bd-a536-a304179040e9"), "Manager" },
                    { new Guid("93e46bf9-ab05-4a8d-afd6-d7f54ec6c2d6"), "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "FirstName", "LastName", "PrefrenceDrinkId" },
                values: new object[] { new Guid("ae1b3523-205a-4071-a7a0-f48c89e8bb04"), "Jaap", "Schaap", null });

            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "LoginId", "PasswordHash", "PasswordSalt", "UserId", "UserName" },
                values: new object[] { new Guid("93696cab-00d4-4c81-82b9-a692d1ce1c9b"), new byte[] { 81, 64, 155, 62, 45, 39, 59, 143, 73, 138, 44, 114, 90, 91, 78, 11, 209, 21, 247, 215, 24, 89, 205, 212, 145, 248, 167, 193, 40, 11, 140, 191 }, new byte[] { 30, 40, 172, 233, 60, 51, 83, 42, 237, 233, 189, 100, 68, 178, 204, 48, 160, 226, 24, 221, 241, 68, 172, 93, 36, 91, 74, 237, 243, 216, 198, 120 }, new Guid("ae1b3523-205a-4071-a7a0-f48c89e8bb04"), "jaap" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserRoleId", "RoleId", "UserId" },
                values: new object[] { new Guid("0545122b-f432-406d-9317-48b8a84552a5"), new Guid("b35dba57-e42b-4167-8f01-5a12c5b4883e"), new Guid("ae1b3523-205a-4071-a7a0-f48c89e8bb04") });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserRoleId", "RoleId", "UserId" },
                values: new object[] { new Guid("1434f94e-01aa-4550-b8a3-5b01f57e11a4"), new Guid("910b3ddf-974a-44bd-a536-a304179040e9"), new Guid("ae1b3523-205a-4071-a7a0-f48c89e8bb04") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("03e23eb6-b751-4ea2-8f9e-611df63a926d"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("1f0d337b-dd59-4c4c-b98e-3894bbf974c6"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("35f25f9a-9420-4434-899c-bfa9a02a4816"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("4f53719c-7d97-4912-ab07-b96ab7298dbf"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("b8790b5f-ab66-4c0b-95b9-677f723b0cdf"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("f9157a7d-3109-4e41-9009-b3a4ac86d080"));

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: new Guid("93696cab-00d4-4c81-82b9-a692d1ce1c9b"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("93e46bf9-ab05-4a8d-afd6-d7f54ec6c2d6"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "UserRoleId",
                keyValue: new Guid("0545122b-f432-406d-9317-48b8a84552a5"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "UserRoleId",
                keyValue: new Guid("1434f94e-01aa-4550-b8a3-5b01f57e11a4"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("910b3ddf-974a-44bd-a536-a304179040e9"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("b35dba57-e42b-4167-8f01-5a12c5b4883e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("ae1b3523-205a-4071-a7a0-f48c89e8bb04"));

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
    }
}
