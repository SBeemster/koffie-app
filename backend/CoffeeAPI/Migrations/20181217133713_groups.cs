using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoffeeAPI.Migrations
{
    public partial class groups : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserGroups");

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

            migrationBuilder.AddColumn<Guid>(
                name: "GroupMemberGroupId",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "GroupOwnerGroupId",
                table: "Users",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "DrinkId", "Additions", "Available", "ImageUrl", "drinkName" },
                values: new object[,]
                {
                    { new Guid("402b4dce-ceb4-4946-b2ef-bd95754f145d"), true, true, "/assets/Images/Koffie.jpg", "Koffie" },
                    { new Guid("4dcbb469-6728-43a7-8f38-89703e7d7f86"), true, true, "/assets/Images/Cappuccino.jpg", "Cappuccino" },
                    { new Guid("4c8f4ae1-7d2c-43f7-9012-70396c1abe4a"), true, true, "/assets/Images/Latte Macchiato.jpg", "Latte Macchiato" },
                    { new Guid("4a54b9fa-9416-4ccf-ada3-2fa3d4efff09"), true, true, "/assets/Images/Espresso.png", "Espresso" },
                    { new Guid("1ade50f6-ead9-4faa-9b02-a3e1aac67868"), true, true, "/assets/Images/Thee.jpg", "Thee" },
                    { new Guid("2dfde6e9-a0d5-4786-9866-7a25ffb0d7a7"), false, true, "/assets/Images/Water.jpg", "Water" }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "GroupId", "GroupName" },
                values: new object[,]
                {
                    { new Guid("234221d9-9f19-48e8-943e-9078b854e7f2"), "Thee pussy's" },
                    { new Guid("ffb936c7-9e60-4bfc-9567-379b7cf8a518"), "Frequently need coffee" },
                    { new Guid("cd756d30-22fb-4b08-8bdf-a587777c5b55"), "The most drinkers" },
                    { new Guid("f3d29542-83cf-40f5-9fc6-16b38cb02c79"), "The addicts" },
                    { new Guid("fa7f1175-5c09-470b-8013-1e8d2d953581"), "Awesome" }
                });

            migrationBuilder.InsertData(
                table: "OrderStatuses",
                columns: new[] { "OrderStatusId", "StatusName" },
                values: new object[,]
                {
                    { new Guid("83311af4-b363-4f40-95c3-3d558c767ceb"), "Ordered" },
                    { new Guid("7f8257ad-83da-4acb-8153-6c4d6aab4b91"), "Finished" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "RoleName" },
                values: new object[,]
                {
                    { new Guid("803efa28-17b5-4cf5-9171-3e8e17880769"), "User" },
                    { new Guid("37af3ed8-1067-4221-aea0-0be30be34313"), "Manager" },
                    { new Guid("3b1e0fe0-bd3c-4510-b748-7739bc7ac19b"), "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Active", "FirstName", "GroupMemberGroupId", "GroupOwnerGroupId", "LastName", "PrefrenceDrinkId" },
                values: new object[] { new Guid("238d4e80-bd0d-46b8-b873-e3b16a08f787"), true, "User", null, null, "Drie", null });

            migrationBuilder.InsertData(
                table: "DrinkPreference",
                columns: new[] { "PreferenceId", "DrinkId", "Milk", "Sugar", "UserId" },
                values: new object[] { new Guid("e5a3b1c1-d873-4ac2-8cf7-4fc099c794cc"), null, null, null, new Guid("238d4e80-bd0d-46b8-b873-e3b16a08f787") });

            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "LoginId", "PasswordHash", "PasswordSalt", "UserId", "UserName" },
                values: new object[] { new Guid("e5242a9e-3724-4558-bcc0-6e2346286e7a"), new byte[] { 148, 181, 123, 75, 200, 76, 126, 163, 165, 2, 110, 107, 94, 223, 251, 42, 61, 157, 68, 119, 152, 212, 9, 23, 98, 60, 219, 27, 172, 163, 174, 8 }, new byte[] { 186, 22, 153, 112, 10, 85, 151, 92, 53, 90, 7, 17, 80, 59, 149, 22, 228, 82, 48, 238, 231, 67, 148, 70, 30, 134, 141, 210, 198, 33, 28, 186 }, new Guid("238d4e80-bd0d-46b8-b873-e3b16a08f787"), "drie" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { new Guid("238d4e80-bd0d-46b8-b873-e3b16a08f787"), new Guid("803efa28-17b5-4cf5-9171-3e8e17880769") },
                    { new Guid("238d4e80-bd0d-46b8-b873-e3b16a08f787"), new Guid("37af3ed8-1067-4221-aea0-0be30be34313") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Active", "FirstName", "GroupMemberGroupId", "GroupOwnerGroupId", "LastName", "PrefrenceDrinkId" },
                values: new object[,]
                {
                    { new Guid("b8bf48b9-d3ae-4bf6-b911-a469b860b0b8"), true, "Super", new Guid("fa7f1175-5c09-470b-8013-1e8d2d953581"), new Guid("fa7f1175-5c09-470b-8013-1e8d2d953581"), "Admin", null },
                    { new Guid("694834ee-2367-48c6-85b0-cbb12d73640f"), true, "Jaap", new Guid("fa7f1175-5c09-470b-8013-1e8d2d953581"), null, "Schaap", null }
                });

            migrationBuilder.InsertData(
                table: "DrinkPreference",
                columns: new[] { "PreferenceId", "DrinkId", "Milk", "Sugar", "UserId" },
                values: new object[,]
                {
                    { new Guid("6cc8c0cd-cedc-4804-8d08-2d4b636e5098"), null, null, null, new Guid("b8bf48b9-d3ae-4bf6-b911-a469b860b0b8") },
                    { new Guid("7acac077-0944-44d8-b019-17ef13431e92"), null, null, null, new Guid("694834ee-2367-48c6-85b0-cbb12d73640f") }
                });

            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "LoginId", "PasswordHash", "PasswordSalt", "UserId", "UserName" },
                values: new object[,]
                {
                    { new Guid("e63b6e0a-36f8-447d-9c17-755a5a440e9a"), new byte[] { 149, 143, 18, 169, 175, 131, 128, 35, 189, 71, 36, 25, 254, 47, 131, 179, 12, 77, 188, 57, 80, 55, 131, 121, 249, 11, 43, 254, 195, 102, 86, 204 }, new byte[] { 135, 119, 12, 96, 50, 202, 60, 123, 86, 169, 239, 30, 37, 156, 40, 34, 85, 194, 251, 168, 233, 188, 70, 42, 53, 238, 163, 52, 230, 67, 135, 161 }, new Guid("b8bf48b9-d3ae-4bf6-b911-a469b860b0b8"), "admin" },
                    { new Guid("69443dae-2dfa-4cb5-8027-73b06f60ee9e"), new byte[] { 230, 119, 237, 226, 228, 3, 26, 130, 119, 245, 104, 86, 76, 110, 193, 107, 37, 118, 0, 235, 127, 182, 45, 34, 84, 222, 35, 63, 58, 80, 95, 210 }, new byte[] { 149, 95, 22, 200, 67, 62, 77, 75, 234, 107, 37, 76, 140, 240, 134, 33, 142, 139, 165, 167, 171, 28, 179, 127, 42, 165, 49, 16, 163, 59, 31, 231 }, new Guid("694834ee-2367-48c6-85b0-cbb12d73640f"), "jaap" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { new Guid("b8bf48b9-d3ae-4bf6-b911-a469b860b0b8"), new Guid("803efa28-17b5-4cf5-9171-3e8e17880769") },
                    { new Guid("b8bf48b9-d3ae-4bf6-b911-a469b860b0b8"), new Guid("3b1e0fe0-bd3c-4510-b748-7739bc7ac19b") },
                    { new Guid("694834ee-2367-48c6-85b0-cbb12d73640f"), new Guid("803efa28-17b5-4cf5-9171-3e8e17880769") },
                    { new Guid("694834ee-2367-48c6-85b0-cbb12d73640f"), new Guid("37af3ed8-1067-4221-aea0-0be30be34313") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_GroupMemberGroupId",
                table: "Users",
                column: "GroupMemberGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_GroupOwnerGroupId",
                table: "Users",
                column: "GroupOwnerGroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Groups_GroupMemberGroupId",
                table: "Users",
                column: "GroupMemberGroupId",
                principalTable: "Groups",
                principalColumn: "GroupId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Groups_GroupOwnerGroupId",
                table: "Users",
                column: "GroupOwnerGroupId",
                principalTable: "Groups",
                principalColumn: "GroupId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Groups_GroupMemberGroupId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Groups_GroupOwnerGroupId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_GroupMemberGroupId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_GroupOwnerGroupId",
                table: "Users");

            migrationBuilder.DeleteData(
                table: "DrinkPreference",
                keyColumn: "PreferenceId",
                keyValue: new Guid("6cc8c0cd-cedc-4804-8d08-2d4b636e5098"));

            migrationBuilder.DeleteData(
                table: "DrinkPreference",
                keyColumn: "PreferenceId",
                keyValue: new Guid("7acac077-0944-44d8-b019-17ef13431e92"));

            migrationBuilder.DeleteData(
                table: "DrinkPreference",
                keyColumn: "PreferenceId",
                keyValue: new Guid("e5a3b1c1-d873-4ac2-8cf7-4fc099c794cc"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("1ade50f6-ead9-4faa-9b02-a3e1aac67868"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("2dfde6e9-a0d5-4786-9866-7a25ffb0d7a7"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("402b4dce-ceb4-4946-b2ef-bd95754f145d"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("4a54b9fa-9416-4ccf-ada3-2fa3d4efff09"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("4c8f4ae1-7d2c-43f7-9012-70396c1abe4a"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("4dcbb469-6728-43a7-8f38-89703e7d7f86"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: new Guid("234221d9-9f19-48e8-943e-9078b854e7f2"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: new Guid("cd756d30-22fb-4b08-8bdf-a587777c5b55"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: new Guid("f3d29542-83cf-40f5-9fc6-16b38cb02c79"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: new Guid("ffb936c7-9e60-4bfc-9567-379b7cf8a518"));

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: new Guid("69443dae-2dfa-4cb5-8027-73b06f60ee9e"));

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: new Guid("e5242a9e-3724-4558-bcc0-6e2346286e7a"));

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: new Guid("e63b6e0a-36f8-447d-9c17-755a5a440e9a"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "OrderStatusId",
                keyValue: new Guid("7f8257ad-83da-4acb-8153-6c4d6aab4b91"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "OrderStatusId",
                keyValue: new Guid("83311af4-b363-4f40-95c3-3d558c767ceb"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("238d4e80-bd0d-46b8-b873-e3b16a08f787"), new Guid("37af3ed8-1067-4221-aea0-0be30be34313") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("238d4e80-bd0d-46b8-b873-e3b16a08f787"), new Guid("803efa28-17b5-4cf5-9171-3e8e17880769") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("694834ee-2367-48c6-85b0-cbb12d73640f"), new Guid("37af3ed8-1067-4221-aea0-0be30be34313") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("694834ee-2367-48c6-85b0-cbb12d73640f"), new Guid("803efa28-17b5-4cf5-9171-3e8e17880769") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("b8bf48b9-d3ae-4bf6-b911-a469b860b0b8"), new Guid("3b1e0fe0-bd3c-4510-b748-7739bc7ac19b") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("b8bf48b9-d3ae-4bf6-b911-a469b860b0b8"), new Guid("803efa28-17b5-4cf5-9171-3e8e17880769") });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("37af3ed8-1067-4221-aea0-0be30be34313"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("3b1e0fe0-bd3c-4510-b748-7739bc7ac19b"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("803efa28-17b5-4cf5-9171-3e8e17880769"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("238d4e80-bd0d-46b8-b873-e3b16a08f787"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("694834ee-2367-48c6-85b0-cbb12d73640f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("b8bf48b9-d3ae-4bf6-b911-a469b860b0b8"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: new Guid("fa7f1175-5c09-470b-8013-1e8d2d953581"));

            migrationBuilder.DropColumn(
                name: "GroupMemberGroupId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "GroupOwnerGroupId",
                table: "Users");

            migrationBuilder.CreateTable(
                name: "UserGroups",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    GroupId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserGroups", x => new { x.UserId, x.GroupId });
                    table.ForeignKey(
                        name: "FK_UserGroups_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "GroupId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserGroups_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_UserGroups_GroupId",
                table: "UserGroups",
                column: "GroupId");
        }
    }
}
