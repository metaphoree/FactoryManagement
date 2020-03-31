using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiService.Migrations
{
    public partial class TransactionTypeFromTransactionTypeId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "TransactionTypeId",
                table: "Transaction");

            migrationBuilder.AddColumn<string>(
                name: "TransactionType",
                table: "Transaction",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Factory",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "ImageUrl", "LicenseNo", "Name", "RegNo", "RowStatus", "SubscriptionEnd", "SubscriptionStart", "UpdatedDateTime", "VatRegNo" },
                values: new object[] { "9e11896e-85cd-4a36-bf86-5758e0800910", new DateTime(2020, 3, 29, 15, 14, 14, 468, DateTimeKind.Local).AddTicks(5882), "f145e8b7-00dc-4ac9-b8a3-679599197a00", "", "", "Fazlu Loom Factory", "", "ADDED", new DateTime(2022, 12, 24, 15, 14, 14, 469, DateTimeKind.Local).AddTicks(1247), new DateTime(2020, 3, 29, 15, 14, 14, 469, DateTimeKind.Local).AddTicks(180), new DateTime(2020, 3, 29, 15, 14, 14, 469, DateTimeKind.Local).AddTicks(2147), "" });

            migrationBuilder.InsertData(
                table: "ItemStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "Name", "RowStatus", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "9f425be2-ee93-4abb-8060-643be87daaac", new DateTime(2020, 3, 29, 9, 14, 14, 496, DateTimeKind.Utc).AddTicks(2604), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "GOOD", "ADDED", new DateTime(2020, 3, 29, 9, 14, 14, 496, DateTimeKind.Utc).AddTicks(4230) },
                    { "fbed1002-824d-4dc8-8b14-a2235aed9e29", new DateTime(2020, 3, 29, 9, 14, 14, 496, DateTimeKind.Utc).AddTicks(4275), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "BAD", "ADDED", new DateTime(2020, 3, 29, 9, 14, 14, 496, DateTimeKind.Utc).AddTicks(4320) }
                });

            migrationBuilder.InsertData(
                table: "PaymentStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "RowStatus", "Status", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "ad2415d9-45c0-4852-b99b-9e002f666e16", new DateTime(2020, 3, 29, 9, 14, 14, 502, DateTimeKind.Utc).AddTicks(304), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVED", new DateTime(2020, 3, 29, 15, 14, 14, 502, DateTimeKind.Local).AddTicks(1252) },
                    { "6302a504-3c92-4c5e-9bb1-fd7bb99e946a", new DateTime(2020, 3, 29, 9, 14, 14, 502, DateTimeKind.Utc).AddTicks(1297), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAYABLE", new DateTime(2020, 3, 29, 15, 14, 14, 502, DateTimeKind.Local).AddTicks(1330) },
                    { "5c152fea-a1dc-48e9-b1ae-9023138918f1", new DateTime(2020, 3, 29, 9, 14, 14, 502, DateTimeKind.Utc).AddTicks(1334), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVABLE", new DateTime(2020, 3, 29, 15, 14, 14, 502, DateTimeKind.Local).AddTicks(1338) },
                    { "6dc09833-a7e5-4051-a897-bac49db19036", new DateTime(2020, 3, 29, 9, 14, 14, 502, DateTimeKind.Utc).AddTicks(1342), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAID", new DateTime(2020, 3, 29, 15, 14, 14, 502, DateTimeKind.Local).AddTicks(1358) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Factory",
                keyColumn: "Id",
                keyValue: "9e11896e-85cd-4a36-bf86-5758e0800910");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "9f425be2-ee93-4abb-8060-643be87daaac");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "fbed1002-824d-4dc8-8b14-a2235aed9e29");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "5c152fea-a1dc-48e9-b1ae-9023138918f1");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "6302a504-3c92-4c5e-9bb1-fd7bb99e946a");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "6dc09833-a7e5-4051-a897-bac49db19036");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "ad2415d9-45c0-4852-b99b-9e002f666e16");

            migrationBuilder.DropColumn(
                name: "TransactionType",
                table: "Transaction");

            migrationBuilder.AddColumn<string>(
                name: "TransactionTypeId",
                table: "Transaction",
                type: "nvarchar(50)",
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
    }
}
