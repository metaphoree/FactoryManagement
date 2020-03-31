using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiService.Migrations
{
    public partial class PaymentStatusFromPaymentStatusId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "PaymentStatusId",
                table: "Transaction");

            migrationBuilder.AddColumn<string>(
                name: "PaymentStatus",
                table: "Transaction",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Factory",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "ImageUrl", "LicenseNo", "Name", "RegNo", "RowStatus", "SubscriptionEnd", "SubscriptionStart", "UpdatedDateTime", "VatRegNo" },
                values: new object[] { "267851a3-c76e-47d1-9ea8-82c4ca7fe2fc", new DateTime(2020, 3, 29, 14, 20, 16, 159, DateTimeKind.Local).AddTicks(4124), "16dacbfd-b338-482e-8019-89aec392d0c2", "", "", "Fazlu Loom Factory", "", "ADDED", new DateTime(2022, 12, 24, 14, 20, 16, 159, DateTimeKind.Local).AddTicks(9346), new DateTime(2020, 3, 29, 14, 20, 16, 159, DateTimeKind.Local).AddTicks(8398), new DateTime(2020, 3, 29, 14, 20, 16, 160, DateTimeKind.Local).AddTicks(233), "" });

            migrationBuilder.InsertData(
                table: "ItemStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "Name", "RowStatus", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "f0e30a7d-1b58-4d61-91de-ef642a3da316", new DateTime(2020, 3, 29, 8, 20, 16, 190, DateTimeKind.Utc).AddTicks(7219), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "GOOD", "ADDED", new DateTime(2020, 3, 29, 8, 20, 16, 190, DateTimeKind.Utc).AddTicks(9784) },
                    { "91f3f731-7f6a-4b4a-8ac5-26dbd01c87fb", new DateTime(2020, 3, 29, 8, 20, 16, 190, DateTimeKind.Utc).AddTicks(9838), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "BAD", "ADDED", new DateTime(2020, 3, 29, 8, 20, 16, 190, DateTimeKind.Utc).AddTicks(9887) }
                });

            migrationBuilder.InsertData(
                table: "PaymentStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "RowStatus", "Status", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "e5308296-0029-4e65-89b1-cb5eb4996b6e", new DateTime(2020, 3, 29, 8, 20, 16, 199, DateTimeKind.Utc).AddTicks(3233), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVED", new DateTime(2020, 3, 29, 14, 20, 16, 199, DateTimeKind.Local).AddTicks(4178) },
                    { "b3ca328a-33f3-4205-bdca-d095fae3096c", new DateTime(2020, 3, 29, 8, 20, 16, 199, DateTimeKind.Utc).AddTicks(4223), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAYABLE", new DateTime(2020, 3, 29, 14, 20, 16, 199, DateTimeKind.Local).AddTicks(4256) },
                    { "f60f22be-6315-41d5-a13c-5904aa4be302", new DateTime(2020, 3, 29, 8, 20, 16, 199, DateTimeKind.Utc).AddTicks(4260), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVABLE", new DateTime(2020, 3, 29, 14, 20, 16, 199, DateTimeKind.Local).AddTicks(4268) },
                    { "4d0f065a-a98b-4bd7-bf27-ef92aec15dd0", new DateTime(2020, 3, 29, 8, 20, 16, 199, DateTimeKind.Utc).AddTicks(4268), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAID", new DateTime(2020, 3, 29, 14, 20, 16, 199, DateTimeKind.Local).AddTicks(4280) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Factory",
                keyColumn: "Id",
                keyValue: "267851a3-c76e-47d1-9ea8-82c4ca7fe2fc");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "91f3f731-7f6a-4b4a-8ac5-26dbd01c87fb");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "f0e30a7d-1b58-4d61-91de-ef642a3da316");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "4d0f065a-a98b-4bd7-bf27-ef92aec15dd0");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "b3ca328a-33f3-4205-bdca-d095fae3096c");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "e5308296-0029-4e65-89b1-cb5eb4996b6e");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "f60f22be-6315-41d5-a13c-5904aa4be302");

            migrationBuilder.DropColumn(
                name: "PaymentStatus",
                table: "Transaction");

            migrationBuilder.AddColumn<string>(
                name: "PaymentStatusId",
                table: "Transaction",
                type: "nvarchar(50)",
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
    }
}
