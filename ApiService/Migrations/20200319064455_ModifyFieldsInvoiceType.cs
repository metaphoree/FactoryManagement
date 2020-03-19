using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiService.Migrations
{
    public partial class ModifyFieldsInvoiceType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropColumn(
                name: "TypeName",
                table: "InvoiceType");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "InvoiceType",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Factory",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "ImageUrl", "LicenseNo", "Name", "RegNo", "RowStatus", "SubscriptionEnd", "SubscriptionStart", "UpdatedDateTime", "VatRegNo" },
                values: new object[] { "3372fd09-aae9-44ae-a36c-fed0e2ba4af3", new DateTime(2020, 3, 19, 12, 44, 54, 318, DateTimeKind.Local).AddTicks(3366), "ef98b21b-3b6e-4a18-b29c-d66fc0d6865f", "", "", "Fazlu Loom Factory", "", "ADDED", new DateTime(2022, 12, 14, 12, 44, 54, 318, DateTimeKind.Local).AddTicks(8735), new DateTime(2020, 3, 19, 12, 44, 54, 318, DateTimeKind.Local).AddTicks(7845), new DateTime(2020, 3, 19, 12, 44, 54, 318, DateTimeKind.Local).AddTicks(9585), "" });

            migrationBuilder.InsertData(
                table: "ItemStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "Name", "RowStatus", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "6659660d-3f39-460a-b885-1f29ca8f23e5", new DateTime(2020, 3, 19, 6, 44, 54, 340, DateTimeKind.Utc).AddTicks(2157), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "GOOD", "ADDED", new DateTime(2020, 3, 19, 6, 44, 54, 340, DateTimeKind.Utc).AddTicks(3804) },
                    { "75bb1edb-9225-4d51-b267-875317dc4968", new DateTime(2020, 3, 19, 6, 44, 54, 340, DateTimeKind.Utc).AddTicks(3837), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "BAD", "ADDED", new DateTime(2020, 3, 19, 6, 44, 54, 340, DateTimeKind.Utc).AddTicks(3869) }
                });

            migrationBuilder.InsertData(
                table: "PaymentStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "RowStatus", "Status", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "87822fe1-078a-4066-b247-6772bfef3173", new DateTime(2020, 3, 19, 6, 44, 54, 345, DateTimeKind.Utc).AddTicks(132), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVED", new DateTime(2020, 3, 19, 12, 44, 54, 345, DateTimeKind.Local).AddTicks(1126) },
                    { "2209c74e-3abc-413b-b690-3997fcf2fbc2", new DateTime(2020, 3, 19, 6, 44, 54, 345, DateTimeKind.Utc).AddTicks(1167), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAYABLE", new DateTime(2020, 3, 19, 12, 44, 54, 345, DateTimeKind.Local).AddTicks(1232) },
                    { "7f3deb17-28f4-4225-84e1-edcda392eb54", new DateTime(2020, 3, 19, 6, 44, 54, 345, DateTimeKind.Utc).AddTicks(1237), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVABLE", new DateTime(2020, 3, 19, 12, 44, 54, 345, DateTimeKind.Local).AddTicks(1245) },
                    { "ce7ed5bd-2d05-4c01-ac9a-9ebe08973dc9", new DateTime(2020, 3, 19, 6, 44, 54, 345, DateTimeKind.Utc).AddTicks(1245), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAID", new DateTime(2020, 3, 19, 12, 44, 54, 345, DateTimeKind.Local).AddTicks(1253) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Factory",
                keyColumn: "Id",
                keyValue: "3372fd09-aae9-44ae-a36c-fed0e2ba4af3");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "6659660d-3f39-460a-b885-1f29ca8f23e5");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "75bb1edb-9225-4d51-b267-875317dc4968");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "2209c74e-3abc-413b-b690-3997fcf2fbc2");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "7f3deb17-28f4-4225-84e1-edcda392eb54");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "87822fe1-078a-4066-b247-6772bfef3173");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "ce7ed5bd-2d05-4c01-ac9a-9ebe08973dc9");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "InvoiceType");

            migrationBuilder.AddColumn<string>(
                name: "TypeName",
                table: "InvoiceType",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

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
    }
}
