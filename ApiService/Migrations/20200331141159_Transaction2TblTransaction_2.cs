using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiService.Migrations
{
    public partial class Transaction2TblTransaction_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Factory",
                keyColumn: "Id",
                keyValue: "0abf5a59-8723-438e-98d0-84ca3485e773");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "75a3bf38-0472-4974-a5fb-4f8387062704");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "d8536182-c03b-4e97-8d7c-7321a9770cbd");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "1a76543a-b53c-49c8-8c60-b80d55ae10a7");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "4aed98ca-c8f2-4c24-a18d-77b6e89b58e2");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "53ffd49b-1065-416a-a189-862a388aae55");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "efea1105-5f8a-4108-9a9d-acf5b8da6730");

            migrationBuilder.AlterColumn<string>(
                name: "TransactionType",
                table: "Transaction",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "TransactionId",
                table: "Transaction",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "RowStatus",
                table: "Transaction",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Purpose",
                table: "Transaction",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PaymentStatus",
                table: "Transaction",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Month",
                table: "Transaction",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "InvoiceId",
                table: "Transaction",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FactoryId",
                table: "Transaction",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "ExecutorId",
                table: "Transaction",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Transaction",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClientId",
                table: "Transaction",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Transaction",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.InsertData(
                table: "Factory",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "ImageUrl", "LicenseNo", "Name", "RegNo", "RowStatus", "SubscriptionEnd", "SubscriptionStart", "UpdatedDateTime", "VatRegNo" },
                values: new object[] { "910c3451-fc70-4e1c-beb9-ac4ed6d6e879", new DateTime(2020, 3, 31, 20, 11, 58, 123, DateTimeKind.Local).AddTicks(1688), "0b2e46c5-ea83-49c3-9cf2-8a090db59cfe", "", "", "Fazlu Loom Factory", "", "ADDED", new DateTime(2022, 12, 26, 20, 11, 58, 124, DateTimeKind.Local).AddTicks(1914), new DateTime(2020, 3, 31, 20, 11, 58, 123, DateTimeKind.Local).AddTicks(9858), new DateTime(2020, 3, 31, 20, 11, 58, 124, DateTimeKind.Local).AddTicks(3253), "" });

            migrationBuilder.InsertData(
                table: "ItemStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "Name", "RowStatus", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "fb274032-7011-4c26-bf96-0b47854dd150", new DateTime(2020, 3, 31, 14, 11, 58, 157, DateTimeKind.Utc).AddTicks(4448), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "GOOD", "ADDED", new DateTime(2020, 3, 31, 14, 11, 58, 157, DateTimeKind.Utc).AddTicks(7190) },
                    { "1d57827f-b583-4aa6-9344-e3ec6b260eb9", new DateTime(2020, 3, 31, 14, 11, 58, 157, DateTimeKind.Utc).AddTicks(7244), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "BAD", "ADDED", new DateTime(2020, 3, 31, 14, 11, 58, 157, DateTimeKind.Utc).AddTicks(7285) }
                });

            migrationBuilder.InsertData(
                table: "PaymentStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "RowStatus", "Status", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "f22254f1-704f-4646-ac9a-dd3acd381e10", new DateTime(2020, 3, 31, 14, 11, 58, 163, DateTimeKind.Utc).AddTicks(6902), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVED", new DateTime(2020, 3, 31, 20, 11, 58, 163, DateTimeKind.Local).AddTicks(8166) },
                    { "44512485-f0d4-4068-8f4b-d7e2ce1236a2", new DateTime(2020, 3, 31, 14, 11, 58, 163, DateTimeKind.Utc).AddTicks(8224), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAYABLE", new DateTime(2020, 3, 31, 20, 11, 58, 163, DateTimeKind.Local).AddTicks(8277) },
                    { "d1a9f3e9-7cb4-4d96-ac5d-abd19c6a0860", new DateTime(2020, 3, 31, 14, 11, 58, 163, DateTimeKind.Utc).AddTicks(8281), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVABLE", new DateTime(2020, 3, 31, 20, 11, 58, 163, DateTimeKind.Local).AddTicks(8310) },
                    { "d268f4a4-9968-4cdd-a113-d04641a41c44", new DateTime(2020, 3, 31, 14, 11, 58, 163, DateTimeKind.Utc).AddTicks(8310), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAID", new DateTime(2020, 3, 31, 20, 11, 58, 163, DateTimeKind.Local).AddTicks(8318) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Factory",
                keyColumn: "Id",
                keyValue: "910c3451-fc70-4e1c-beb9-ac4ed6d6e879");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "1d57827f-b583-4aa6-9344-e3ec6b260eb9");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "fb274032-7011-4c26-bf96-0b47854dd150");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "44512485-f0d4-4068-8f4b-d7e2ce1236a2");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "d1a9f3e9-7cb4-4d96-ac5d-abd19c6a0860");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "d268f4a4-9968-4cdd-a113-d04641a41c44");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "f22254f1-704f-4646-ac9a-dd3acd381e10");

            migrationBuilder.AlterColumn<string>(
                name: "TransactionType",
                table: "Transaction",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TransactionId",
                table: "Transaction",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RowStatus",
                table: "Transaction",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Purpose",
                table: "Transaction",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PaymentStatus",
                table: "Transaction",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Month",
                table: "Transaction",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "InvoiceId",
                table: "Transaction",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FactoryId",
                table: "Transaction",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ExecutorId",
                table: "Transaction",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Transaction",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClientId",
                table: "Transaction",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Transaction",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.InsertData(
                table: "Factory",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "ImageUrl", "LicenseNo", "Name", "RegNo", "RowStatus", "SubscriptionEnd", "SubscriptionStart", "UpdatedDateTime", "VatRegNo" },
                values: new object[] { "0abf5a59-8723-438e-98d0-84ca3485e773", new DateTime(2020, 3, 31, 19, 32, 25, 515, DateTimeKind.Local).AddTicks(4289), "18557e75-60e8-4f79-ac1a-651c4028a77f", "", "", "Fazlu Loom Factory", "", "ADDED", new DateTime(2022, 12, 26, 19, 32, 25, 516, DateTimeKind.Local).AddTicks(2680), new DateTime(2020, 3, 31, 19, 32, 25, 516, DateTimeKind.Local).AddTicks(1276), new DateTime(2020, 3, 31, 19, 32, 25, 516, DateTimeKind.Local).AddTicks(3993), "" });

            migrationBuilder.InsertData(
                table: "ItemStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "Name", "RowStatus", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "d8536182-c03b-4e97-8d7c-7321a9770cbd", new DateTime(2020, 3, 31, 13, 32, 25, 547, DateTimeKind.Utc).AddTicks(1382), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "GOOD", "ADDED", new DateTime(2020, 3, 31, 13, 32, 25, 547, DateTimeKind.Utc).AddTicks(3808) },
                    { "75a3bf38-0472-4974-a5fb-4f8387062704", new DateTime(2020, 3, 31, 13, 32, 25, 547, DateTimeKind.Utc).AddTicks(3874), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "BAD", "ADDED", new DateTime(2020, 3, 31, 13, 32, 25, 547, DateTimeKind.Utc).AddTicks(3915) }
                });

            migrationBuilder.InsertData(
                table: "PaymentStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "RowStatus", "Status", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "1a76543a-b53c-49c8-8c60-b80d55ae10a7", new DateTime(2020, 3, 31, 13, 32, 25, 555, DateTimeKind.Utc).AddTicks(8854), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVED", new DateTime(2020, 3, 31, 19, 32, 25, 556, DateTimeKind.Local).AddTicks(131) },
                    { "efea1105-5f8a-4108-9a9d-acf5b8da6730", new DateTime(2020, 3, 31, 13, 32, 25, 556, DateTimeKind.Utc).AddTicks(192), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAYABLE", new DateTime(2020, 3, 31, 19, 32, 25, 556, DateTimeKind.Local).AddTicks(242) },
                    { "4aed98ca-c8f2-4c24-a18d-77b6e89b58e2", new DateTime(2020, 3, 31, 13, 32, 25, 556, DateTimeKind.Utc).AddTicks(242), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVABLE", new DateTime(2020, 3, 31, 19, 32, 25, 556, DateTimeKind.Local).AddTicks(270) },
                    { "53ffd49b-1065-416a-a189-862a388aae55", new DateTime(2020, 3, 31, 13, 32, 25, 556, DateTimeKind.Utc).AddTicks(274), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAID", new DateTime(2020, 3, 31, 19, 32, 25, 556, DateTimeKind.Local).AddTicks(283) }
                });
        }
    }
}
