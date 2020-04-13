using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiService.Migrations
{
    public partial class Emp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Factory",
                keyColumn: "Id",
                keyValue: "34b42c41-09a8-471c-bd78-37cffa8ae531");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "3074f980-94ae-4d62-b44f-63585ba618f7");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "acd3ab5c-6c71-4716-92f5-8fcd72dfaa79");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "5140f8f0-42f1-4e5a-a741-6d24d6f81be5");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "722dc016-4093-448c-8610-0207a08b265b");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "79a3ff2a-ff6e-49e2-9926-1f89ff99f875");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "bf0385c0-ca07-4a3c-9c90-7127b381c259");

            migrationBuilder.InsertData(
                table: "Factory",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "ImageUrl", "LicenseNo", "Name", "RegNo", "RowStatus", "SubscriptionEnd", "SubscriptionStart", "UpdatedDateTime", "VatRegNo" },
                values: new object[] { "1a0d4a92-9d14-4c4a-88d9-6d75a324bfea", new DateTime(2020, 4, 9, 10, 40, 32, 815, DateTimeKind.Local).AddTicks(7585), "a964412f-b01c-48f3-9d88-e12f4fb55f09", "", "", "Fazlu Loom Factory", "", "ADDED", new DateTime(2023, 1, 4, 10, 40, 32, 816, DateTimeKind.Local).AddTicks(3057), new DateTime(2020, 4, 9, 10, 40, 32, 816, DateTimeKind.Local).AddTicks(2092), new DateTime(2020, 4, 9, 10, 40, 32, 816, DateTimeKind.Local).AddTicks(3976), "" });

            migrationBuilder.InsertData(
                table: "ItemStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "Name", "RowStatus", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "ec07312f-d85a-4fe8-8d97-edae3eb8ce01", new DateTime(2020, 4, 9, 4, 40, 32, 836, DateTimeKind.Utc).AddTicks(3137), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "GOOD", "ADDED", new DateTime(2020, 4, 9, 4, 40, 32, 836, DateTimeKind.Utc).AddTicks(5563) },
                    { "459897cf-b1af-45b5-aa04-74a82f587735", new DateTime(2020, 4, 9, 4, 40, 32, 836, DateTimeKind.Utc).AddTicks(5608), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "BAD", "ADDED", new DateTime(2020, 4, 9, 4, 40, 32, 836, DateTimeKind.Utc).AddTicks(5645) }
                });

            migrationBuilder.InsertData(
                table: "PaymentStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "RowStatus", "Status", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "12dc7f9f-699d-485b-bb89-5a58b4186dc9", new DateTime(2020, 4, 9, 4, 40, 32, 841, DateTimeKind.Utc).AddTicks(6329), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVED", new DateTime(2020, 4, 9, 10, 40, 32, 841, DateTimeKind.Local).AddTicks(7314) },
                    { "1305662a-d670-4382-be96-2502f79bf766", new DateTime(2020, 4, 9, 4, 40, 32, 841, DateTimeKind.Utc).AddTicks(7363), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAYABLE", new DateTime(2020, 4, 9, 10, 40, 32, 841, DateTimeKind.Local).AddTicks(7396) },
                    { "04f8d312-b1af-4710-a47e-01cee99023ae", new DateTime(2020, 4, 9, 4, 40, 32, 841, DateTimeKind.Utc).AddTicks(7400), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVABLE", new DateTime(2020, 4, 9, 10, 40, 32, 841, DateTimeKind.Local).AddTicks(7408) },
                    { "0eb75f45-6169-490a-9cd0-588514126810", new DateTime(2020, 4, 9, 4, 40, 32, 841, DateTimeKind.Utc).AddTicks(7408), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAID", new DateTime(2020, 4, 9, 10, 40, 32, 841, DateTimeKind.Local).AddTicks(7412) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Factory",
                keyColumn: "Id",
                keyValue: "1a0d4a92-9d14-4c4a-88d9-6d75a324bfea");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "459897cf-b1af-45b5-aa04-74a82f587735");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "ec07312f-d85a-4fe8-8d97-edae3eb8ce01");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "04f8d312-b1af-4710-a47e-01cee99023ae");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "0eb75f45-6169-490a-9cd0-588514126810");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "12dc7f9f-699d-485b-bb89-5a58b4186dc9");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "1305662a-d670-4382-be96-2502f79bf766");

            migrationBuilder.InsertData(
                table: "Factory",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "ImageUrl", "LicenseNo", "Name", "RegNo", "RowStatus", "SubscriptionEnd", "SubscriptionStart", "UpdatedDateTime", "VatRegNo" },
                values: new object[] { "34b42c41-09a8-471c-bd78-37cffa8ae531", new DateTime(2020, 4, 7, 19, 35, 23, 449, DateTimeKind.Local).AddTicks(8767), "102d2743-8f38-4345-8eff-8bb849d845f4", "", "", "Fazlu Loom Factory", "", "ADDED", new DateTime(2023, 1, 2, 19, 35, 23, 450, DateTimeKind.Local).AddTicks(4145), new DateTime(2020, 4, 7, 19, 35, 23, 450, DateTimeKind.Local).AddTicks(3193), new DateTime(2020, 4, 7, 19, 35, 23, 450, DateTimeKind.Local).AddTicks(5036), "" });

            migrationBuilder.InsertData(
                table: "ItemStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "Name", "RowStatus", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "acd3ab5c-6c71-4716-92f5-8fcd72dfaa79", new DateTime(2020, 4, 7, 13, 35, 23, 470, DateTimeKind.Utc).AddTicks(3247), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "GOOD", "ADDED", new DateTime(2020, 4, 7, 13, 35, 23, 470, DateTimeKind.Utc).AddTicks(4758) },
                    { "3074f980-94ae-4d62-b44f-63585ba618f7", new DateTime(2020, 4, 7, 13, 35, 23, 470, DateTimeKind.Utc).AddTicks(4795), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "BAD", "ADDED", new DateTime(2020, 4, 7, 13, 35, 23, 470, DateTimeKind.Utc).AddTicks(4824) }
                });

            migrationBuilder.InsertData(
                table: "PaymentStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "RowStatus", "Status", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "722dc016-4093-448c-8610-0207a08b265b", new DateTime(2020, 4, 7, 13, 35, 23, 474, DateTimeKind.Utc).AddTicks(9191), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVED", new DateTime(2020, 4, 7, 19, 35, 23, 474, DateTimeKind.Local).AddTicks(9987) },
                    { "bf0385c0-ca07-4a3c-9c90-7127b381c259", new DateTime(2020, 4, 7, 13, 35, 23, 475, DateTimeKind.Utc).AddTicks(24), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAYABLE", new DateTime(2020, 4, 7, 19, 35, 23, 475, DateTimeKind.Local).AddTicks(57) },
                    { "79a3ff2a-ff6e-49e2-9926-1f89ff99f875", new DateTime(2020, 4, 7, 13, 35, 23, 475, DateTimeKind.Utc).AddTicks(57), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVABLE", new DateTime(2020, 4, 7, 19, 35, 23, 475, DateTimeKind.Local).AddTicks(65) },
                    { "5140f8f0-42f1-4e5a-a741-6d24d6f81be5", new DateTime(2020, 4, 7, 13, 35, 23, 475, DateTimeKind.Utc).AddTicks(65), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAID", new DateTime(2020, 4, 7, 19, 35, 23, 475, DateTimeKind.Local).AddTicks(86) }
                });
        }
    }
}
