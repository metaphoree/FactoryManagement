using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiService.Migrations
{
    public partial class PurchaseTableFieldChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Factory",
                keyColumn: "Id",
                keyValue: "8f1713d4-e26c-488d-b32c-4c36dcfb4b9e");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "99488d9b-9175-4037-989e-20a55f2106e9");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "c555e61c-ba95-4888-aac7-b594364472e0");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "40aaa664-9eca-41e1-a59b-cfcdd8d8dcd7");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "4e6b21fd-8b82-41ef-b665-506c7a7b0d5a");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "53da6d00-9033-443b-a87d-dd605c9c7861");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "a7eab0d3-d05f-4a54-a493-f6b97c71960d");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Purchase");

            migrationBuilder.AddColumn<string>(
                name: "ItemCategoryId",
                table: "Purchase",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ItemId",
                table: "Purchase",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Factory",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "ImageUrl", "LicenseNo", "Name", "RegNo", "RowStatus", "SubscriptionEnd", "SubscriptionStart", "UpdatedDateTime", "VatRegNo" },
                values: new object[] { "f40f8a31-adee-4bfe-9f4b-49356dc81726", new DateTime(2020, 3, 27, 21, 20, 36, 794, DateTimeKind.Local).AddTicks(3370), "533a36b8-ade1-41d9-8ff3-63dec1a2090d", "", "", "Fazlu Loom Factory", "", "ADDED", new DateTime(2022, 12, 22, 21, 20, 36, 794, DateTimeKind.Local).AddTicks(8486), new DateTime(2020, 3, 27, 21, 20, 36, 794, DateTimeKind.Local).AddTicks(7600), new DateTime(2020, 3, 27, 21, 20, 36, 794, DateTimeKind.Local).AddTicks(9311), "" });

            migrationBuilder.InsertData(
                table: "ItemStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "Name", "RowStatus", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "7d5b6cad-f46c-475c-bcac-737b967e16fd", new DateTime(2020, 3, 27, 15, 20, 36, 816, DateTimeKind.Utc).AddTicks(1362), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "GOOD", "ADDED", new DateTime(2020, 3, 27, 15, 20, 36, 816, DateTimeKind.Utc).AddTicks(2840) },
                    { "e473c859-f7bf-453b-afb5-a17145c4f4eb", new DateTime(2020, 3, 27, 15, 20, 36, 816, DateTimeKind.Utc).AddTicks(2877), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "BAD", "ADDED", new DateTime(2020, 3, 27, 15, 20, 36, 816, DateTimeKind.Utc).AddTicks(2906) }
                });

            migrationBuilder.InsertData(
                table: "PaymentStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "RowStatus", "Status", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "98e55c67-ec8f-430b-9f74-647977faa974", new DateTime(2020, 3, 27, 15, 20, 36, 820, DateTimeKind.Utc).AddTicks(9772), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVED", new DateTime(2020, 3, 27, 21, 20, 36, 821, DateTimeKind.Local).AddTicks(610) },
                    { "ad153d2c-be6a-45cc-ae7d-4d7266305d79", new DateTime(2020, 3, 27, 15, 20, 36, 821, DateTimeKind.Utc).AddTicks(651), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAYABLE", new DateTime(2020, 3, 27, 21, 20, 36, 821, DateTimeKind.Local).AddTicks(684) },
                    { "0af172ca-1266-456e-a30e-02e5d443fd27", new DateTime(2020, 3, 27, 15, 20, 36, 821, DateTimeKind.Utc).AddTicks(688), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVABLE", new DateTime(2020, 3, 27, 21, 20, 36, 821, DateTimeKind.Local).AddTicks(692) },
                    { "d9eaec63-902a-45b3-9c4f-161af0ae0c24", new DateTime(2020, 3, 27, 15, 20, 36, 821, DateTimeKind.Utc).AddTicks(696), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAID", new DateTime(2020, 3, 27, 21, 20, 36, 821, DateTimeKind.Local).AddTicks(716) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Factory",
                keyColumn: "Id",
                keyValue: "f40f8a31-adee-4bfe-9f4b-49356dc81726");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "7d5b6cad-f46c-475c-bcac-737b967e16fd");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "e473c859-f7bf-453b-afb5-a17145c4f4eb");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "0af172ca-1266-456e-a30e-02e5d443fd27");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "98e55c67-ec8f-430b-9f74-647977faa974");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "ad153d2c-be6a-45cc-ae7d-4d7266305d79");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "d9eaec63-902a-45b3-9c4f-161af0ae0c24");

            migrationBuilder.DropColumn(
                name: "ItemCategoryId",
                table: "Purchase");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "Purchase");

            migrationBuilder.AddColumn<string>(
                name: "ProductId",
                table: "Purchase",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Factory",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "ImageUrl", "LicenseNo", "Name", "RegNo", "RowStatus", "SubscriptionEnd", "SubscriptionStart", "UpdatedDateTime", "VatRegNo" },
                values: new object[] { "8f1713d4-e26c-488d-b32c-4c36dcfb4b9e", new DateTime(2020, 3, 19, 23, 39, 57, 211, DateTimeKind.Local).AddTicks(6023), "cd72cb44-a064-4a6f-ab83-a4ceb52e283b", "", "", "Fazlu Loom Factory", "", "ADDED", new DateTime(2022, 12, 14, 23, 39, 57, 212, DateTimeKind.Local).AddTicks(1425), new DateTime(2020, 3, 19, 23, 39, 57, 212, DateTimeKind.Local).AddTicks(427), new DateTime(2020, 3, 19, 23, 39, 57, 212, DateTimeKind.Local).AddTicks(2332), "" });

            migrationBuilder.InsertData(
                table: "ItemStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "Name", "RowStatus", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "99488d9b-9175-4037-989e-20a55f2106e9", new DateTime(2020, 3, 19, 17, 39, 57, 237, DateTimeKind.Utc).AddTicks(7776), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "GOOD", "ADDED", new DateTime(2020, 3, 19, 17, 39, 57, 237, DateTimeKind.Utc).AddTicks(9727) },
                    { "c555e61c-ba95-4888-aac7-b594364472e0", new DateTime(2020, 3, 19, 17, 39, 57, 237, DateTimeKind.Utc).AddTicks(9768), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "BAD", "ADDED", new DateTime(2020, 3, 19, 17, 39, 57, 237, DateTimeKind.Utc).AddTicks(9796) }
                });

            migrationBuilder.InsertData(
                table: "PaymentStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "RowStatus", "Status", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "4e6b21fd-8b82-41ef-b665-506c7a7b0d5a", new DateTime(2020, 3, 19, 17, 39, 57, 243, DateTimeKind.Utc).AddTicks(6310), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVED", new DateTime(2020, 3, 19, 23, 39, 57, 243, DateTimeKind.Local).AddTicks(7455) },
                    { "53da6d00-9033-443b-a87d-dd605c9c7861", new DateTime(2020, 3, 19, 17, 39, 57, 243, DateTimeKind.Utc).AddTicks(7504), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAYABLE", new DateTime(2020, 3, 19, 23, 39, 57, 243, DateTimeKind.Local).AddTicks(7558) },
                    { "a7eab0d3-d05f-4a54-a493-f6b97c71960d", new DateTime(2020, 3, 19, 17, 39, 57, 243, DateTimeKind.Utc).AddTicks(7558), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVABLE", new DateTime(2020, 3, 19, 23, 39, 57, 243, DateTimeKind.Local).AddTicks(7570) },
                    { "40aaa664-9eca-41e1-a59b-cfcdd8d8dcd7", new DateTime(2020, 3, 19, 17, 39, 57, 243, DateTimeKind.Utc).AddTicks(7570), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAID", new DateTime(2020, 3, 19, 23, 39, 57, 243, DateTimeKind.Local).AddTicks(7578) }
                });
        }
    }
}
