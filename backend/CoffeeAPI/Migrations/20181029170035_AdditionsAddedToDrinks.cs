using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoffeeAPI.Migrations
{
    public partial class AdditionsAddedToDrinks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<bool>(
                name: "Additions",
                table: "Drinks",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "DrinkId", "Additions", "Available", "DrinkName", "ImageUrl" },
                values: new object[,]
                {
                    { new Guid("e4eab252-fdb4-4dbe-ac45-1d4e23e4099b"), true, true, "Koffie", "/assets/Images/Koffie.jpg" },
                    { new Guid("85a8c454-5f8a-4b5e-a846-7a804ad6b7ab"), true, true, "Cappuccino", "/assets/Images/Cappuccino.jpg" },
                    { new Guid("ec978005-7ad8-4458-be6f-540b2f294e9a"), true, true, "Latte Macchiato", "/assets/Images/Latte Macchiato.jpg" },
                    { new Guid("08cfb4bb-3ce0-4aa4-87f5-659231720c35"), true, true, "Espresso", "/assets/Images/Espresso.png" },
                    { new Guid("28a276ca-4c29-4f7f-87a9-44805fa04d02"), true, true, "Thee", "/assets/Images/Thee.jpg" },
                    { new Guid("787039ba-d5f1-4f22-9f06-0641ba1b5866"), false, true, "Water", "/assets/Images/Water.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "RoleName" },
                values: new object[,]
                {
                    { new Guid("fd264769-780a-47eb-b630-d71d19294eb5"), "User" },
                    { new Guid("b19cd87b-a35e-420e-8b03-49e00d7feedf"), "Manager" },
                    { new Guid("311b45a0-c25a-41b3-9ddf-2533f5699651"), "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "FirstName", "LastName", "PrefrenceDrinkId" },
                values: new object[] { new Guid("a46be6d7-727a-4457-81dd-96a75c197fd1"), "Jaap", "Schaap", null });

            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "LoginId", "PasswordHash", "PasswordSalt", "UserId", "UserName" },
                values: new object[] { new Guid("e1f08ede-9ee8-4ab6-8d0f-e0d9cea00b31"), new byte[] { 140, 136, 176, 186, 219, 168, 133, 129, 250, 69, 249, 206, 159, 166, 139, 91, 205, 230, 133, 90, 218, 191, 22, 48, 105, 166, 31, 235, 204, 116, 245, 159 }, new byte[] { 189, 148, 164, 133, 18, 39, 78, 156, 111, 164, 53, 168, 224, 222, 17, 255, 7, 236, 156, 214, 197, 219, 146, 249, 222, 220, 48, 173, 244, 217, 218, 253 }, new Guid("a46be6d7-727a-4457-81dd-96a75c197fd1"), "jaap" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserRoleId", "RoleId", "UserId" },
                values: new object[] { new Guid("c97eb98f-fe48-40de-a63b-fd8dfc380adc"), new Guid("fd264769-780a-47eb-b630-d71d19294eb5"), new Guid("a46be6d7-727a-4457-81dd-96a75c197fd1") });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserRoleId", "RoleId", "UserId" },
                values: new object[] { new Guid("8a0609f4-2c6a-4e7a-89d8-919e5bd39d23"), new Guid("b19cd87b-a35e-420e-8b03-49e00d7feedf"), new Guid("a46be6d7-727a-4457-81dd-96a75c197fd1") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("08cfb4bb-3ce0-4aa4-87f5-659231720c35"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("28a276ca-4c29-4f7f-87a9-44805fa04d02"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("787039ba-d5f1-4f22-9f06-0641ba1b5866"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("85a8c454-5f8a-4b5e-a846-7a804ad6b7ab"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("e4eab252-fdb4-4dbe-ac45-1d4e23e4099b"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("ec978005-7ad8-4458-be6f-540b2f294e9a"));

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: new Guid("e1f08ede-9ee8-4ab6-8d0f-e0d9cea00b31"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("311b45a0-c25a-41b3-9ddf-2533f5699651"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "UserRoleId",
                keyValue: new Guid("8a0609f4-2c6a-4e7a-89d8-919e5bd39d23"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "UserRoleId",
                keyValue: new Guid("c97eb98f-fe48-40de-a63b-fd8dfc380adc"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("b19cd87b-a35e-420e-8b03-49e00d7feedf"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("fd264769-780a-47eb-b630-d71d19294eb5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("a46be6d7-727a-4457-81dd-96a75c197fd1"));

            migrationBuilder.DropColumn(
                name: "Additions",
                table: "Drinks");

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
    }
}
