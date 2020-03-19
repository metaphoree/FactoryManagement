using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiService.Migrations
{
    public partial class IncomeTableAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Factory",
                keyColumn: "Id",
                keyValue: "b47a4f80-dfd4-4b5b-804e-02bb49ae0171");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "33339b75-15e8-42b0-a7d1-11e7738064fb");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "d886041d-566d-4f57-9b94-0a327dea906b");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "797ae7ea-6588-46a3-835f-9167796ab2c5");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "979ef0c2-75d2-4eda-b66c-920583710772");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "b94eb2e0-6f09-434e-8f10-0b95472eed46");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "daf9274a-1d38-47d3-9153-b1e45aac6dee");

            migrationBuilder.CreateTable(
                name: "Income",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(nullable: false),
                    FactoryId = table.Column<string>(maxLength: 50, nullable: false),
                    RowStatus = table.Column<string>(maxLength: 50, nullable: false),
                    UniqueId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IncomeTypeId = table.Column<string>(nullable: true),
                    ClientId = table.Column<string>(nullable: true),
                    InvoiceId = table.Column<string>(nullable: true),
                    Month = table.Column<string>(nullable: true),
                    Amount = table.Column<decimal>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    OccurranceDate = table.Column<DateTime>(nullable: true),
                    EmployeeId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Income", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Factory",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "ImageUrl", "LicenseNo", "Name", "RegNo", "RowStatus", "SubscriptionEnd", "SubscriptionStart", "UpdatedDateTime", "VatRegNo" },
                values: new object[] { "ec3f99ed-f37c-4a46-abfc-543faacac4f2", new DateTime(2020, 3, 18, 12, 33, 31, 468, DateTimeKind.Local).AddTicks(2396), "afb85b05-0f2a-44f0-979c-20352c83b742", "", "", "Fazlu Loom Factory", "", "ADDED", new DateTime(2022, 12, 13, 12, 33, 31, 468, DateTimeKind.Local).AddTicks(8037), new DateTime(2020, 3, 18, 12, 33, 31, 468, DateTimeKind.Local).AddTicks(7056), new DateTime(2020, 3, 18, 12, 33, 31, 468, DateTimeKind.Local).AddTicks(8965), "" });

            migrationBuilder.InsertData(
                table: "ItemStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "Name", "RowStatus", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "4d45a488-eb22-454f-9580-1c9ba4629b81", new DateTime(2020, 3, 18, 6, 33, 31, 491, DateTimeKind.Utc).AddTicks(2269), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "GOOD", "ADDED", new DateTime(2020, 3, 18, 6, 33, 31, 491, DateTimeKind.Utc).AddTicks(4207) },
                    { "04fd358f-11c1-4089-b31e-77f1b9662bc9", new DateTime(2020, 3, 18, 6, 33, 31, 491, DateTimeKind.Utc).AddTicks(4248), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "BAD", "ADDED", new DateTime(2020, 3, 18, 6, 33, 31, 491, DateTimeKind.Utc).AddTicks(4277) }
                });

            migrationBuilder.InsertData(
                table: "PaymentStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "RowStatus", "Status", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "4353f91e-6ade-4d74-868b-6a062a6a7d6b", new DateTime(2020, 3, 18, 6, 33, 31, 496, DateTimeKind.Utc).AddTicks(5720), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVED", new DateTime(2020, 3, 18, 12, 33, 31, 496, DateTimeKind.Local).AddTicks(6647) },
                    { "1df2c52d-be35-4576-8524-4046318bcfd7", new DateTime(2020, 3, 18, 6, 33, 31, 496, DateTimeKind.Utc).AddTicks(6689), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAYABLE", new DateTime(2020, 3, 18, 12, 33, 31, 496, DateTimeKind.Local).AddTicks(6721) },
                    { "54f36b91-9aa8-4804-a47f-de3e52887472", new DateTime(2020, 3, 18, 6, 33, 31, 496, DateTimeKind.Utc).AddTicks(6721), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVABLE", new DateTime(2020, 3, 18, 12, 33, 31, 496, DateTimeKind.Local).AddTicks(6730) },
                    { "dc27dbcd-a9a7-467b-8a70-eacd007b08da", new DateTime(2020, 3, 18, 6, 33, 31, 496, DateTimeKind.Utc).AddTicks(6730), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAID", new DateTime(2020, 3, 18, 12, 33, 31, 496, DateTimeKind.Local).AddTicks(6750) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Income");

            migrationBuilder.DeleteData(
                table: "Factory",
                keyColumn: "Id",
                keyValue: "ec3f99ed-f37c-4a46-abfc-543faacac4f2");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "04fd358f-11c1-4089-b31e-77f1b9662bc9");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "4d45a488-eb22-454f-9580-1c9ba4629b81");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "1df2c52d-be35-4576-8524-4046318bcfd7");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "4353f91e-6ade-4d74-868b-6a062a6a7d6b");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "54f36b91-9aa8-4804-a47f-de3e52887472");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "dc27dbcd-a9a7-467b-8a70-eacd007b08da");

            migrationBuilder.InsertData(
                table: "Factory",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "ImageUrl", "LicenseNo", "Name", "RegNo", "RowStatus", "SubscriptionEnd", "SubscriptionStart", "UpdatedDateTime", "VatRegNo" },
                values: new object[] { "b47a4f80-dfd4-4b5b-804e-02bb49ae0171", new DateTime(2020, 3, 18, 11, 5, 18, 128, DateTimeKind.Local).AddTicks(2492), "e10342cb-dfce-47b2-a22e-e5942470eec8", "", "", "Fazlu Loom Factory", "", "ADDED", new DateTime(2022, 12, 13, 11, 5, 18, 128, DateTimeKind.Local).AddTicks(8531), new DateTime(2020, 3, 18, 11, 5, 18, 128, DateTimeKind.Local).AddTicks(7439), new DateTime(2020, 3, 18, 11, 5, 18, 128, DateTimeKind.Local).AddTicks(9516), "" });

            migrationBuilder.InsertData(
                table: "ItemStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "Name", "RowStatus", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "33339b75-15e8-42b0-a7d1-11e7738064fb", new DateTime(2020, 3, 18, 5, 5, 18, 159, DateTimeKind.Utc).AddTicks(61), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "GOOD", "ADDED", new DateTime(2020, 3, 18, 5, 5, 18, 159, DateTimeKind.Utc).AddTicks(2651) },
                    { "d886041d-566d-4f57-9b94-0a327dea906b", new DateTime(2020, 3, 18, 5, 5, 18, 159, DateTimeKind.Utc).AddTicks(2708), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "BAD", "ADDED", new DateTime(2020, 3, 18, 5, 5, 18, 159, DateTimeKind.Utc).AddTicks(2753) }
                });

            migrationBuilder.InsertData(
                table: "PaymentStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "RowStatus", "Status", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "b94eb2e0-6f09-434e-8f10-0b95472eed46", new DateTime(2020, 3, 18, 5, 5, 18, 167, DateTimeKind.Utc).AddTicks(8772), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVED", new DateTime(2020, 3, 18, 11, 5, 18, 168, DateTimeKind.Local).AddTicks(176) },
                    { "979ef0c2-75d2-4eda-b66c-920583710772", new DateTime(2020, 3, 18, 5, 5, 18, 168, DateTimeKind.Utc).AddTicks(234), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAYABLE", new DateTime(2020, 3, 18, 11, 5, 18, 168, DateTimeKind.Local).AddTicks(283) },
                    { "daf9274a-1d38-47d3-9153-b1e45aac6dee", new DateTime(2020, 3, 18, 5, 5, 18, 168, DateTimeKind.Utc).AddTicks(287), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVABLE", new DateTime(2020, 3, 18, 11, 5, 18, 168, DateTimeKind.Local).AddTicks(299) },
                    { "797ae7ea-6588-46a3-835f-9167796ab2c5", new DateTime(2020, 3, 18, 5, 5, 18, 168, DateTimeKind.Utc).AddTicks(299), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAID", new DateTime(2020, 3, 18, 11, 5, 18, 168, DateTimeKind.Local).AddTicks(308) }
                });
        }
    }
}
