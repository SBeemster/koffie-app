using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoffeeAPI.Migrations
{
    public partial class sp_GetTopServer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"CREATE PROCEDURE getTopServers
                        (
                            @begintijd datetime = NULL,
	                        @eindtijd datetime = NULL
                        )
                        AS
                        BEGIN
                            SET NOCOUNT ON

                            SELECT TOP 10
		                        COUNT(OrderLineId) As Aantal,
		                        (S.Firstname + ' ' + S.LastName) As Server
	                        FROM OrderLines O
	                        INNER JOIN Users S ON
	                        S.UserId = O.ServerUserId
	                        WHERE 
		                        (O.OrderTime > @begintijd OR @begintijd IS NULL)
		                        AND
		                        (O.OrderTime < @eindtijd OR @eindtijd IS NULL)
	                        GROUP BY S.FirstName, S.LastName
                        END";

            migrationBuilder.Sql(sp);

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

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "DrinkId", "Additions", "Available", "ImageUrl", "drinkName" },
                values: new object[,]
                {
                    { new Guid("2a370079-b47c-4b42-9281-a6cbea366ed4"), true, true, "/assets/Images/Koffie.jpg", "Koffie" },
                    { new Guid("514397a4-3bdf-40b5-a1c9-5a2951bd5556"), true, true, "/assets/Images/Cappuccino.jpg", "Cappuccino" },
                    { new Guid("02be2d9e-55b9-4e69-962a-07611989dfdc"), true, true, "/assets/Images/Latte Macchiato.jpg", "Latte Macchiato" },
                    { new Guid("c321094d-bffd-49f7-bdff-23b1892972f9"), true, true, "/assets/Images/Espresso.png", "Espresso" },
                    { new Guid("fcce54d6-69ab-4e67-94e6-84fcdfee6556"), true, true, "/assets/Images/Thee.jpg", "Thee" },
                    { new Guid("8a6163b9-06ca-456d-bbaf-b05d6a48ef72"), false, true, "/assets/Images/Water.jpg", "Water" }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "GroupId", "GroupName" },
                values: new object[,]
                {
                    { new Guid("2fbd6a81-2e30-4b95-a0ca-38bd594c0cc1"), "Thee pussy's" },
                    { new Guid("dc93a374-1458-4137-bf7e-f52a0f61b389"), "Frequently need coffee" },
                    { new Guid("f084a20d-dc4f-4920-9b62-ec8f0376ab0f"), "The addicts" },
                    { new Guid("335caa1c-d99f-4883-ba4e-502a3b2d0386"), "The most drinkers" }
                });

            migrationBuilder.InsertData(
                table: "OrderStatuses",
                columns: new[] { "OrderStatusId", "StatusName" },
                values: new object[,]
                {
                    { new Guid("b9da2176-1d7a-4312-9ae5-fb5ba3b44a26"), "Ordered" },
                    { new Guid("9f8175c2-b69f-40c3-9de3-cdb4349cd5fb"), "Finished" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "RoleName" },
                values: new object[,]
                {
                    { new Guid("5db7d90e-4fb7-4290-9993-e1536c3e7552"), "User" },
                    { new Guid("d855d269-f1fd-425a-a25c-7e56e3342399"), "Manager" },
                    { new Guid("58b1aeb3-38d4-485d-b5f9-48fdb3b560f7"), "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Active", "FirstName", "LastName", "PrefrenceDrinkId" },
                values: new object[,]
                {
                    { new Guid("fc5c5a41-4681-4118-a9e8-8b18143acf49"), true, "Super", "Admin", null },
                    { new Guid("eac6b8ce-23f7-4096-a798-3815eabe9b6a"), true, "Jaap", "Schaap", null }
                });

            migrationBuilder.InsertData(
                table: "DrinkPreference",
                columns: new[] { "PreferenceId", "DrinkId", "Milk", "Sugar", "UserId" },
                values: new object[,]
                {
                    { new Guid("0ad7ca62-073c-4d39-aa55-6eaa896cfbca"), null, null, null, new Guid("fc5c5a41-4681-4118-a9e8-8b18143acf49") },
                    { new Guid("d10414ef-92a9-469e-9807-51695ce79d6d"), null, null, null, new Guid("eac6b8ce-23f7-4096-a798-3815eabe9b6a") }
                });

            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "LoginId", "PasswordHash", "PasswordSalt", "UserId", "UserName" },
                values: new object[,]
                {
                    { new Guid("f8cf56d1-7524-4ae6-bf83-9b04be495a3b"), new byte[] { 250, 142, 53, 183, 167, 108, 209, 206, 58, 34, 19, 179, 246, 124, 23, 100, 77, 149, 240, 49, 120, 214, 115, 148, 220, 47, 8, 233, 200, 169, 179, 251 }, new byte[] { 159, 161, 140, 62, 176, 63, 102, 12, 182, 169, 166, 152, 72, 136, 67, 175, 33, 41, 255, 198, 24, 166, 126, 104, 164, 133, 233, 86, 7, 119, 163, 25 }, new Guid("fc5c5a41-4681-4118-a9e8-8b18143acf49"), "admin" },
                    { new Guid("7b245232-5d92-4c47-854a-6c978024bf08"), new byte[] { 75, 74, 128, 142, 6, 154, 221, 163, 157, 90, 151, 48, 167, 39, 229, 51, 221, 122, 147, 125, 62, 194, 126, 210, 254, 94, 138, 23, 186, 200, 61, 32 }, new byte[] { 78, 4, 88, 57, 182, 30, 121, 220, 100, 161, 207, 65, 174, 82, 22, 171, 78, 157, 99, 71, 125, 237, 62, 45, 83, 147, 76, 172, 142, 169, 3, 206 }, new Guid("eac6b8ce-23f7-4096-a798-3815eabe9b6a"), "jaap" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { new Guid("fc5c5a41-4681-4118-a9e8-8b18143acf49"), new Guid("5db7d90e-4fb7-4290-9993-e1536c3e7552") },
                    { new Guid("fc5c5a41-4681-4118-a9e8-8b18143acf49"), new Guid("58b1aeb3-38d4-485d-b5f9-48fdb3b560f7") },
                    { new Guid("eac6b8ce-23f7-4096-a798-3815eabe9b6a"), new Guid("5db7d90e-4fb7-4290-9993-e1536c3e7552") },
                    { new Guid("eac6b8ce-23f7-4096-a798-3815eabe9b6a"), new Guid("d855d269-f1fd-425a-a25c-7e56e3342399") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DrinkPreference",
                keyColumn: "PreferenceId",
                keyValue: new Guid("0ad7ca62-073c-4d39-aa55-6eaa896cfbca"));

            migrationBuilder.DeleteData(
                table: "DrinkPreference",
                keyColumn: "PreferenceId",
                keyValue: new Guid("d10414ef-92a9-469e-9807-51695ce79d6d"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("02be2d9e-55b9-4e69-962a-07611989dfdc"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("2a370079-b47c-4b42-9281-a6cbea366ed4"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("514397a4-3bdf-40b5-a1c9-5a2951bd5556"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("8a6163b9-06ca-456d-bbaf-b05d6a48ef72"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("c321094d-bffd-49f7-bdff-23b1892972f9"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: new Guid("fcce54d6-69ab-4e67-94e6-84fcdfee6556"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: new Guid("2fbd6a81-2e30-4b95-a0ca-38bd594c0cc1"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: new Guid("335caa1c-d99f-4883-ba4e-502a3b2d0386"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: new Guid("dc93a374-1458-4137-bf7e-f52a0f61b389"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: new Guid("f084a20d-dc4f-4920-9b62-ec8f0376ab0f"));

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: new Guid("7b245232-5d92-4c47-854a-6c978024bf08"));

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: new Guid("f8cf56d1-7524-4ae6-bf83-9b04be495a3b"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "OrderStatusId",
                keyValue: new Guid("9f8175c2-b69f-40c3-9de3-cdb4349cd5fb"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "OrderStatusId",
                keyValue: new Guid("b9da2176-1d7a-4312-9ae5-fb5ba3b44a26"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("eac6b8ce-23f7-4096-a798-3815eabe9b6a"), new Guid("5db7d90e-4fb7-4290-9993-e1536c3e7552") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("eac6b8ce-23f7-4096-a798-3815eabe9b6a"), new Guid("d855d269-f1fd-425a-a25c-7e56e3342399") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("fc5c5a41-4681-4118-a9e8-8b18143acf49"), new Guid("58b1aeb3-38d4-485d-b5f9-48fdb3b560f7") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("fc5c5a41-4681-4118-a9e8-8b18143acf49"), new Guid("5db7d90e-4fb7-4290-9993-e1536c3e7552") });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("58b1aeb3-38d4-485d-b5f9-48fdb3b560f7"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("5db7d90e-4fb7-4290-9993-e1536c3e7552"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("d855d269-f1fd-425a-a25c-7e56e3342399"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("eac6b8ce-23f7-4096-a798-3815eabe9b6a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("fc5c5a41-4681-4118-a9e8-8b18143acf49"));

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
        }
    }
}
