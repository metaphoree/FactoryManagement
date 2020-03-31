using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiService.Migrations
{
    public partial class PurchaseSalesFieldChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Sales");

            migrationBuilder.AddColumn<string>(
                name: "BuyerId",
                table: "StockOut",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ExecutorId",
                table: "StockIn",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ItemCategoryId",
                table: "Sales",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ItemId",
                table: "Sales",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Month",
                table: "Purchase",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Factory",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "ImageUrl", "LicenseNo", "Name", "RegNo", "RowStatus", "SubscriptionEnd", "SubscriptionStart", "UpdatedDateTime", "VatRegNo" },
                values: new object[] { "0c4f2c7d-d285-4e88-bd04-8c7d4b614563", new DateTime(2020, 3, 29, 19, 37, 38, 757, DateTimeKind.Local).AddTicks(953), "d29872df-ee8d-4a56-b584-ccd01a97862e", "", "", "Fazlu Loom Factory", "", "ADDED", new DateTime(2022, 12, 24, 19, 37, 38, 757, DateTimeKind.Local).AddTicks(7858), new DateTime(2020, 3, 29, 19, 37, 38, 757, DateTimeKind.Local).AddTicks(6852), new DateTime(2020, 3, 29, 19, 37, 38, 757, DateTimeKind.Local).AddTicks(8757), "" });

            migrationBuilder.InsertData(
                table: "ItemStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "Name", "RowStatus", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "8515c91f-975b-4fab-98e6-dfb203b2c2c4", new DateTime(2020, 3, 29, 13, 37, 38, 783, DateTimeKind.Utc).AddTicks(7571), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "GOOD", "ADDED", new DateTime(2020, 3, 29, 13, 37, 38, 783, DateTimeKind.Utc).AddTicks(9382) },
                    { "500c0279-043f-4348-b6fb-583e1f614e1d", new DateTime(2020, 3, 29, 13, 37, 38, 783, DateTimeKind.Utc).AddTicks(9427), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "BAD", "ADDED", new DateTime(2020, 3, 29, 13, 37, 38, 783, DateTimeKind.Utc).AddTicks(9456) }
                });

            migrationBuilder.InsertData(
                table: "PaymentStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "RowStatus", "Status", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "b91e6e8b-ab34-4109-bfab-a3b6d65e3795", new DateTime(2020, 3, 29, 13, 37, 38, 789, DateTimeKind.Utc).AddTicks(1138), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVED", new DateTime(2020, 3, 29, 19, 37, 38, 789, DateTimeKind.Local).AddTicks(2033) },
                    { "4182aeb4-a094-4502-86c3-ab3f9f90418d", new DateTime(2020, 3, 29, 13, 37, 38, 789, DateTimeKind.Utc).AddTicks(2078), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAYABLE", new DateTime(2020, 3, 29, 19, 37, 38, 789, DateTimeKind.Local).AddTicks(2124) },
                    { "c0db46a3-3c81-4fcf-a925-5b38edb218c9", new DateTime(2020, 3, 29, 13, 37, 38, 789, DateTimeKind.Utc).AddTicks(2128), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVABLE", new DateTime(2020, 3, 29, 19, 37, 38, 789, DateTimeKind.Local).AddTicks(2132) },
                    { "888e3297-4332-4bd9-94ec-2ffaa3a8fea6", new DateTime(2020, 3, 29, 13, 37, 38, 789, DateTimeKind.Utc).AddTicks(2136), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAID", new DateTime(2020, 3, 29, 19, 37, 38, 789, DateTimeKind.Local).AddTicks(2140) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Factory",
                keyColumn: "Id",
                keyValue: "0c4f2c7d-d285-4e88-bd04-8c7d4b614563");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "500c0279-043f-4348-b6fb-583e1f614e1d");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "8515c91f-975b-4fab-98e6-dfb203b2c2c4");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "4182aeb4-a094-4502-86c3-ab3f9f90418d");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "888e3297-4332-4bd9-94ec-2ffaa3a8fea6");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "b91e6e8b-ab34-4109-bfab-a3b6d65e3795");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "c0db46a3-3c81-4fcf-a925-5b38edb218c9");

            migrationBuilder.DropColumn(
                name: "BuyerId",
                table: "StockOut");

            migrationBuilder.DropColumn(
                name: "ExecutorId",
                table: "StockIn");

            migrationBuilder.DropColumn(
                name: "ItemCategoryId",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "Month",
                table: "Purchase");

            migrationBuilder.AddColumn<string>(
                name: "ProductId",
                table: "Sales",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

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
    }
}
