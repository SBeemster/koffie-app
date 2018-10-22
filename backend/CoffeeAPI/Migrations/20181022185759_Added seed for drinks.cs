using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoffeeAPI.Migrations
{
    public partial class Addedseedfordrinks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: new Guid("58dc3f30-e1c5-407b-a971-e0d4b0869069"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("63d6d67d-02a8-472d-ab55-0f890b0dc590"));

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "DrinkId", "Available", "DrinkName", "ImageUrl" },
                values: new object[,]
                {
                    { new Guid("ada4a5b0-a7b0-4b85-991d-79ccf32f6bf6"), true, "Koffie", null },
                    { new Guid("0e4d6221-fbbe-4cf9-bac0-61f971fcd982"), true, "Cappuccino", null },
                    { new Guid("86d62434-b026-4f71-a1ec-44c0463d2cab"), true, "Latte Macchiato", null },
                    { new Guid("1882ae32-74b0-486c-b5e4-c92e886ca622"), true, "Espresso", null },
                    { new Guid("06d1171d-a007-4629-8209-5e4f7779da7e"), true, "Thee", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "FirstName", "LastName", "PrefrenceDrinkId" },
                values: new object[] { new Guid("5d25ed34-916a-45cf-a919-dea2873a9b47"), "Jaap", "Schaap", null });

            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "LoginId", "PasswordHash", "PasswordSalt", "UserId", "UserName" },
                values: new object[] { new Guid("3889953b-13af-4345-a112-4a5692240177"), new byte[] { 189, 30, 12, 207, 199, 24, 38, 173, 39, 243, 220, 123, 103, 118, 200, 175, 133, 207, 50, 58, 90, 23, 50, 34, 213, 63, 101, 197, 142, 28, 156, 141 }, new byte[] { 23, 69, 242, 248, 67, 140, 153, 151, 198, 225, 166, 223, 149, 253, 18, 109, 29, 177, 171, 55, 247, 45, 187, 202, 35, 116, 194, 146, 20, 174, 210, 33 }, new Guid("5d25ed34-916a-45cf-a919-dea2873a9b47"), "jaap" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("06d1171d-a007-4629-8209-5e4f7779da7e"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("0e4d6221-fbbe-4cf9-bac0-61f971fcd982"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("1882ae32-74b0-486c-b5e4-c92e886ca622"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("86d62434-b026-4f71-a1ec-44c0463d2cab"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("ada4a5b0-a7b0-4b85-991d-79ccf32f6bf6"));

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: new Guid("3889953b-13af-4345-a112-4a5692240177"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("5d25ed34-916a-45cf-a919-dea2873a9b47"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "FirstName", "LastName", "PrefrenceDrinkId" },
                values: new object[] { new Guid("63d6d67d-02a8-472d-ab55-0f890b0dc590"), "Jaap", "Schaap", null });

            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "LoginId", "PasswordHash", "PasswordSalt", "UserId", "UserName" },
                values: new object[] { new Guid("58dc3f30-e1c5-407b-a971-e0d4b0869069"), new byte[] { 206, 58, 32, 174, 83, 9, 251, 100, 83, 229, 219, 122, 39, 12, 45, 88, 187, 176, 245, 143, 39, 210, 209, 73, 200, 78, 44, 25, 39, 41, 87, 160 }, new byte[] { 115, 243, 62, 108, 238, 214, 54, 172, 34, 164, 118, 102, 70, 227, 16, 232, 59, 41, 252, 190, 4, 222, 88, 26, 108, 57, 49, 74, 162, 135, 175, 86 }, new Guid("63d6d67d-02a8-472d-ab55-0f890b0dc590"), "jaap" });
        }
    }
}
