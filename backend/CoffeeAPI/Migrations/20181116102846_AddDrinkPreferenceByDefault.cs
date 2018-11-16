using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoffeeAPI.Migrations
{
    public partial class AddDrinkPreferenceByDefault : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DrinkPreference_Drinks_DrinkId",
                table: "DrinkPreference");

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

            migrationBuilder.AlterColumn<int>(
                name: "Sugar",
                table: "DrinkPreference",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "Milk",
                table: "DrinkPreference",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<Guid>(
                name: "DrinkId",
                table: "DrinkPreference",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "DrinkId", "Additions", "Available", "ImageUrl", "drinkName" },
                values: new object[,]
                {
                    { new Guid("7addc228-3dee-4ec4-a096-1fd8a04daab0"), true, true, "/assets/Images/Koffie.jpg", "Koffie" },
                    { new Guid("00520956-7a40-4d59-bbbd-e9dddead4f5c"), true, true, "/assets/Images/Cappuccino.jpg", "Cappuccino" },
                    { new Guid("d7410286-1576-444c-96c9-0c9ef75cf671"), true, true, "/assets/Images/Latte Macchiato.jpg", "Latte Macchiato" },
                    { new Guid("9e777953-33ea-459b-8f5c-145feb3067eb"), true, true, "/assets/Images/Espresso.png", "Espresso" },
                    { new Guid("cc6d6cba-1c32-410b-9688-74b4a2f0bd9b"), true, true, "/assets/Images/Thee.jpg", "Thee" },
                    { new Guid("1d534c5d-9a9c-4b5b-aa23-c5245f265b2f"), false, true, "/assets/Images/Water.jpg", "Water" }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "GroupId", "GroupName" },
                values: new object[,]
                {
                    { new Guid("31dbeaf0-c882-415d-b7b8-a2cd4797cef9"), "Thee pussy's" },
                    { new Guid("46d5dc88-3088-4dc5-8595-3566c26a1953"), "Frequently need coffee" },
                    { new Guid("4c184eea-bfac-44fd-9002-72833e8e7d52"), "The addicts" },
                    { new Guid("e364a8fa-268d-4151-ac82-5e06c22803fe"), "The most drinkers" }
                });

            migrationBuilder.InsertData(
                table: "OrderStatuses",
                columns: new[] { "OrderStatusId", "StatusName" },
                values: new object[,]
                {
                    { new Guid("d50513e4-952a-475b-bba1-f2ba0bc16a0e"), "Ordered" },
                    { new Guid("6c6f2e99-8bca-4ca7-93a5-cd61e0208578"), "Finished" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "RoleName" },
                values: new object[,]
                {
                    { new Guid("04b8db6c-40fb-4297-8392-1f4cfd890b66"), "User" },
                    { new Guid("ed3f0e85-7d09-4940-b059-992098f69603"), "Manager" },
                    { new Guid("5992848d-a6b9-42a1-962a-229598c03d81"), "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Active", "FirstName", "LastName", "PrefrenceDrinkId" },
                values: new object[,]
                {
                    { new Guid("f4f8d750-4841-4844-9ef6-bb620b6b4d1d"), true, "Super", "Admin", null },
                    { new Guid("4a13b7ef-d77b-478a-bcbe-26182b979e9d"), true, "Jaap", "Schaap", null }
                });

            migrationBuilder.InsertData(
                table: "DrinkPreference",
                columns: new[] { "PreferenceId", "DrinkId", "Milk", "Sugar", "UserId" },
                values: new object[,]
                {
                    { new Guid("1bc31ffb-fecb-41ee-a260-6300825fd98d"), null, null, null, new Guid("f4f8d750-4841-4844-9ef6-bb620b6b4d1d") },
                    { new Guid("2f7ee6b9-4a20-4655-9d57-63bc3ba47110"), null, null, null, new Guid("4a13b7ef-d77b-478a-bcbe-26182b979e9d") }
                });

            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "LoginId", "PasswordHash", "PasswordSalt", "UserId", "UserName" },
                values: new object[,]
                {
                    { new Guid("04c1e01f-d8be-471e-9ddb-83a9c1cb70e1"), new byte[] { 103, 197, 247, 239, 37, 239, 209, 225, 149, 180, 13, 107, 149, 169, 96, 249, 9, 221, 196, 147, 28, 176, 127, 22, 134, 45, 168, 246, 103, 105, 229, 249 }, new byte[] { 63, 22, 76, 201, 116, 48, 234, 233, 32, 193, 89, 59, 10, 133, 248, 215, 227, 247, 14, 102, 214, 33, 221, 39, 173, 132, 88, 69, 86, 193, 178, 170 }, new Guid("f4f8d750-4841-4844-9ef6-bb620b6b4d1d"), "admin" },
                    { new Guid("8d721acc-6716-40b3-bf4d-bfe32c95f8d5"), new byte[] { 245, 1, 19, 213, 190, 253, 45, 202, 27, 229, 111, 203, 253, 1, 174, 182, 6, 99, 140, 235, 76, 49, 97, 37, 216, 1, 146, 47, 53, 221, 163, 198 }, new byte[] { 87, 77, 233, 41, 243, 81, 13, 202, 187, 15, 163, 246, 66, 123, 247, 142, 107, 188, 6, 11, 115, 148, 171, 4, 114, 180, 173, 74, 67, 148, 220, 46 }, new Guid("4a13b7ef-d77b-478a-bcbe-26182b979e9d"), "jaap" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { new Guid("f4f8d750-4841-4844-9ef6-bb620b6b4d1d"), new Guid("04b8db6c-40fb-4297-8392-1f4cfd890b66") },
                    { new Guid("f4f8d750-4841-4844-9ef6-bb620b6b4d1d"), new Guid("5992848d-a6b9-42a1-962a-229598c03d81") },
                    { new Guid("4a13b7ef-d77b-478a-bcbe-26182b979e9d"), new Guid("04b8db6c-40fb-4297-8392-1f4cfd890b66") },
                    { new Guid("4a13b7ef-d77b-478a-bcbe-26182b979e9d"), new Guid("ed3f0e85-7d09-4940-b059-992098f69603") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_DrinkPreference_Drinks_DrinkId",
                table: "DrinkPreference",
                column: "DrinkId",
                principalTable: "Drinks",
                principalColumn: "DrinkId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DrinkPreference_Drinks_DrinkId",
                table: "DrinkPreference");

            migrationBuilder.DeleteData(
                table: "DrinkPreference",
                keyColumn: "PreferenceId",
                keyValue: new Guid("1bc31ffb-fecb-41ee-a260-6300825fd98d"));

            migrationBuilder.DeleteData(
                table: "DrinkPreference",
                keyColumn: "PreferenceId",
                keyValue: new Guid("2f7ee6b9-4a20-4655-9d57-63bc3ba47110"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("00520956-7a40-4d59-bbbd-e9dddead4f5c"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("1d534c5d-9a9c-4b5b-aa23-c5245f265b2f"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("7addc228-3dee-4ec4-a096-1fd8a04daab0"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("9e777953-33ea-459b-8f5c-145feb3067eb"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("cc6d6cba-1c32-410b-9688-74b4a2f0bd9b"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("d7410286-1576-444c-96c9-0c9ef75cf671"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: new Guid("31dbeaf0-c882-415d-b7b8-a2cd4797cef9"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: new Guid("46d5dc88-3088-4dc5-8595-3566c26a1953"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: new Guid("4c184eea-bfac-44fd-9002-72833e8e7d52"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: new Guid("e364a8fa-268d-4151-ac82-5e06c22803fe"));

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: new Guid("04c1e01f-d8be-471e-9ddb-83a9c1cb70e1"));

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: new Guid("8d721acc-6716-40b3-bf4d-bfe32c95f8d5"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "OrderStatusId",
                keyValue: new Guid("6c6f2e99-8bca-4ca7-93a5-cd61e0208578"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "OrderStatusId",
                keyValue: new Guid("d50513e4-952a-475b-bba1-f2ba0bc16a0e"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("4a13b7ef-d77b-478a-bcbe-26182b979e9d"), new Guid("04b8db6c-40fb-4297-8392-1f4cfd890b66") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("4a13b7ef-d77b-478a-bcbe-26182b979e9d"), new Guid("ed3f0e85-7d09-4940-b059-992098f69603") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("f4f8d750-4841-4844-9ef6-bb620b6b4d1d"), new Guid("04b8db6c-40fb-4297-8392-1f4cfd890b66") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("f4f8d750-4841-4844-9ef6-bb620b6b4d1d"), new Guid("5992848d-a6b9-42a1-962a-229598c03d81") });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("04b8db6c-40fb-4297-8392-1f4cfd890b66"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("5992848d-a6b9-42a1-962a-229598c03d81"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("ed3f0e85-7d09-4940-b059-992098f69603"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("4a13b7ef-d77b-478a-bcbe-26182b979e9d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("f4f8d750-4841-4844-9ef6-bb620b6b4d1d"));

            migrationBuilder.AlterColumn<int>(
                name: "Sugar",
                table: "DrinkPreference",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Milk",
                table: "DrinkPreference",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "DrinkId",
                table: "DrinkPreference",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_DrinkPreference_Drinks_DrinkId",
                table: "DrinkPreference",
                column: "DrinkId",
                principalTable: "Drinks",
                principalColumn: "DrinkId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
