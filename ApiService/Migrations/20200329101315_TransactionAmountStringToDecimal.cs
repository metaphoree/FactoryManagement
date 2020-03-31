using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiService.Migrations
{
    public partial class TransactionAmountStringToDecimal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "Transaction",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.InsertData(
                table: "Factory",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "ImageUrl", "LicenseNo", "Name", "RegNo", "RowStatus", "SubscriptionEnd", "SubscriptionStart", "UpdatedDateTime", "VatRegNo" },
                values: new object[] { "b05b13c1-41af-4931-be25-106191e20be2", new DateTime(2020, 3, 29, 16, 13, 14, 341, DateTimeKind.Local).AddTicks(4589), "85135efc-bdb4-475d-9ffa-13a01b8a4b25", "", "", "Fazlu Loom Factory", "", "ADDED", new DateTime(2022, 12, 24, 16, 13, 14, 342, DateTimeKind.Local).AddTicks(1050), new DateTime(2020, 3, 29, 16, 13, 14, 342, DateTimeKind.Local).AddTicks(48), new DateTime(2020, 3, 29, 16, 13, 14, 342, DateTimeKind.Local).AddTicks(1953), "" });

            migrationBuilder.InsertData(
                table: "ItemStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "Name", "RowStatus", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "500c0c97-c693-4316-8b96-013833ffb56a", new DateTime(2020, 3, 29, 10, 13, 14, 375, DateTimeKind.Utc).AddTicks(6405), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "GOOD", "ADDED", new DateTime(2020, 3, 29, 10, 13, 14, 375, DateTimeKind.Utc).AddTicks(8835) },
                    { "e0299c9a-c9e4-476c-8d03-292a33e327db", new DateTime(2020, 3, 29, 10, 13, 14, 375, DateTimeKind.Utc).AddTicks(8892), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "BAD", "ADDED", new DateTime(2020, 3, 29, 10, 13, 14, 375, DateTimeKind.Utc).AddTicks(8934) }
                });

            migrationBuilder.InsertData(
                table: "PaymentStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "RowStatus", "Status", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "9a166407-048e-4a5e-8a91-2e8071427bc9", new DateTime(2020, 3, 29, 10, 13, 14, 384, DateTimeKind.Utc).AddTicks(1713), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVED", new DateTime(2020, 3, 29, 16, 13, 14, 384, DateTimeKind.Local).AddTicks(2944) },
                    { "4d22a1fc-2abd-44f2-a5e3-e051d03e36c5", new DateTime(2020, 3, 29, 10, 13, 14, 384, DateTimeKind.Utc).AddTicks(3002), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAYABLE", new DateTime(2020, 3, 29, 16, 13, 14, 384, DateTimeKind.Local).AddTicks(3047) },
                    { "cf444648-92b2-4997-b735-a33df65600ba", new DateTime(2020, 3, 29, 10, 13, 14, 384, DateTimeKind.Utc).AddTicks(3055), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVABLE", new DateTime(2020, 3, 29, 16, 13, 14, 384, DateTimeKind.Local).AddTicks(3063) },
                    { "cb96c472-931d-4794-8f40-4683e2ade9eb", new DateTime(2020, 3, 29, 10, 13, 14, 384, DateTimeKind.Utc).AddTicks(3068), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAID", new DateTime(2020, 3, 29, 16, 13, 14, 384, DateTimeKind.Local).AddTicks(3072) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Factory",
                keyColumn: "Id",
                keyValue: "b05b13c1-41af-4931-be25-106191e20be2");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "500c0c97-c693-4316-8b96-013833ffb56a");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "e0299c9a-c9e4-476c-8d03-292a33e327db");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "4d22a1fc-2abd-44f2-a5e3-e051d03e36c5");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "9a166407-048e-4a5e-8a91-2e8071427bc9");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "cb96c472-931d-4794-8f40-4683e2ade9eb");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "cf444648-92b2-4997-b735-a33df65600ba");

            migrationBuilder.AlterColumn<string>(
                name: "Amount",
                table: "Transaction",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(decimal),
                oldMaxLength: 50);

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
    }
}
