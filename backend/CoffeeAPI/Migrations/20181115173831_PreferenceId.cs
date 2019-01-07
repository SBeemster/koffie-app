using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoffeeAPI.Migrations
{
    public partial class PreferenceId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.RenameColumn(
                name: "Preferenceid",
                table: "DrinkPreference",
                newName: "PreferenceId");

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "DrinkId", "Additions", "Available", "ImageUrl", "drinkName" },
                values: new object[,]
                {
                    { new Guid("8d41470c-f1d9-40d6-b8d2-7ba75010a756"), true, true, "/assets/Images/Koffie.jpg", "Koffie" },
                    { new Guid("40002e86-7aba-4f7d-b5c7-8e89091535d3"), true, true, "/assets/Images/Cappuccino.jpg", "Cappuccino" },
                    { new Guid("cade8e76-7caa-4285-b2bb-a94b16aa6dac"), true, true, "/assets/Images/Latte Macchiato.jpg", "Latte Macchiato" },
                    { new Guid("35720804-1514-4f2d-946f-9ace707a2a80"), true, true, "/assets/Images/Espresso.png", "Espresso" },
                    { new Guid("92686ab2-9293-4eea-9e38-74386da0f57a"), true, true, "/assets/Images/Thee.jpg", "Thee" },
                    { new Guid("c01f63ca-eb8f-486d-adcd-9566969cf4c2"), false, true, "/assets/Images/Water.jpg", "Water" }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "GroupId", "GroupName" },
                values: new object[,]
                {
                    { new Guid("db78a2e9-e0ef-4c53-997f-e4dfc4c956d4"), "Thee pussy's" },
                    { new Guid("9ad8cf1d-a2db-4694-a58d-d78258dc6956"), "Frequently need coffee" },
                    { new Guid("089c46c4-2cda-4b87-8102-23cef8d10398"), "The addicts" },
                    { new Guid("3bbcde49-53c1-4dc8-b9e5-043a7c5b7816"), "The most drinkers" }
                });

            migrationBuilder.InsertData(
                table: "OrderStatuses",
                columns: new[] { "OrderStatusId", "StatusName" },
                values: new object[,]
                {
                    { new Guid("1f55855f-4b25-4e0f-9013-aa96da3fc744"), "Ordered" },
                    { new Guid("1279dd57-fc24-4141-a567-5ee77c137612"), "Finished" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "RoleName" },
                values: new object[,]
                {
                    { new Guid("6528e3e6-86f8-4149-af9a-d9496059fc2e"), "User" },
                    { new Guid("04194dbb-3267-4ab3-bc51-33b09ed5ba76"), "Manager" },
                    { new Guid("81e7dd63-cdb7-4fb2-82ae-98675ed5ed6c"), "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Active", "FirstName", "LastName", "PrefrenceDrinkId" },
                values: new object[,]
                {
                    { new Guid("c185bda6-20b1-4a5a-b1f3-0d2aa90bb7a6"), true, "Super", "Admin", null },
                    { new Guid("adbb0506-b882-4670-8966-4ebf573fa439"), true, "Jaap", "Schaap", null }
                });

            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "LoginId", "PasswordHash", "PasswordSalt", "UserId", "UserName" },
                values: new object[,]
                {
                    { new Guid("3a7c6d7d-a296-4807-a04f-e7fb3772f98b"), new byte[] { 137, 52, 25, 107, 255, 151, 43, 217, 149, 62, 114, 169, 157, 188, 144, 255, 230, 32, 108, 220, 108, 229, 111, 61, 248, 95, 208, 116, 237, 234, 185, 229 }, new byte[] { 155, 243, 11, 91, 102, 107, 111, 138, 196, 111, 182, 215, 216, 167, 29, 243, 255, 185, 246, 176, 80, 251, 61, 96, 72, 187, 28, 224, 19, 179, 164, 23 }, new Guid("c185bda6-20b1-4a5a-b1f3-0d2aa90bb7a6"), "admin" },
                    { new Guid("22ac6681-af69-4126-93c7-0422acfd70af"), new byte[] { 33, 141, 7, 120, 246, 234, 229, 138, 131, 166, 199, 107, 252, 209, 13, 230, 77, 16, 119, 156, 32, 119, 156, 69, 0, 195, 90, 76, 153, 221, 236, 105 }, new byte[] { 214, 199, 170, 30, 220, 111, 137, 219, 122, 78, 35, 233, 29, 68, 104, 255, 11, 116, 88, 202, 60, 187, 9, 209, 80, 70, 117, 76, 93, 107, 255, 65 }, new Guid("adbb0506-b882-4670-8966-4ebf573fa439"), "jaap" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { new Guid("c185bda6-20b1-4a5a-b1f3-0d2aa90bb7a6"), new Guid("6528e3e6-86f8-4149-af9a-d9496059fc2e") },
                    { new Guid("c185bda6-20b1-4a5a-b1f3-0d2aa90bb7a6"), new Guid("81e7dd63-cdb7-4fb2-82ae-98675ed5ed6c") },
                    { new Guid("adbb0506-b882-4670-8966-4ebf573fa439"), new Guid("6528e3e6-86f8-4149-af9a-d9496059fc2e") },
                    { new Guid("adbb0506-b882-4670-8966-4ebf573fa439"), new Guid("04194dbb-3267-4ab3-bc51-33b09ed5ba76") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("35720804-1514-4f2d-946f-9ace707a2a80"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("40002e86-7aba-4f7d-b5c7-8e89091535d3"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("8d41470c-f1d9-40d6-b8d2-7ba75010a756"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("92686ab2-9293-4eea-9e38-74386da0f57a"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("c01f63ca-eb8f-486d-adcd-9566969cf4c2"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("cade8e76-7caa-4285-b2bb-a94b16aa6dac"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: new Guid("089c46c4-2cda-4b87-8102-23cef8d10398"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: new Guid("3bbcde49-53c1-4dc8-b9e5-043a7c5b7816"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: new Guid("9ad8cf1d-a2db-4694-a58d-d78258dc6956"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: new Guid("db78a2e9-e0ef-4c53-997f-e4dfc4c956d4"));

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: new Guid("22ac6681-af69-4126-93c7-0422acfd70af"));

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: new Guid("3a7c6d7d-a296-4807-a04f-e7fb3772f98b"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "OrderStatusId",
                keyValue: new Guid("1279dd57-fc24-4141-a567-5ee77c137612"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "OrderStatusId",
                keyValue: new Guid("1f55855f-4b25-4e0f-9013-aa96da3fc744"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("adbb0506-b882-4670-8966-4ebf573fa439"), new Guid("04194dbb-3267-4ab3-bc51-33b09ed5ba76") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("adbb0506-b882-4670-8966-4ebf573fa439"), new Guid("6528e3e6-86f8-4149-af9a-d9496059fc2e") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("c185bda6-20b1-4a5a-b1f3-0d2aa90bb7a6"), new Guid("6528e3e6-86f8-4149-af9a-d9496059fc2e") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("c185bda6-20b1-4a5a-b1f3-0d2aa90bb7a6"), new Guid("81e7dd63-cdb7-4fb2-82ae-98675ed5ed6c") });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("04194dbb-3267-4ab3-bc51-33b09ed5ba76"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("6528e3e6-86f8-4149-af9a-d9496059fc2e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("81e7dd63-cdb7-4fb2-82ae-98675ed5ed6c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("adbb0506-b882-4670-8966-4ebf573fa439"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("c185bda6-20b1-4a5a-b1f3-0d2aa90bb7a6"));

            migrationBuilder.RenameColumn(
                name: "PreferenceId",
                table: "DrinkPreference",
                newName: "Preferenceid");

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
        }
    }
}
