using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiService.Migrations
{
    public partial class Transaction2TblTransaction_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Transaction",
                table: "Transaction");

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

            migrationBuilder.RenameTable(
                name: "Transaction",
                newName: "TblTransaction");

            migrationBuilder.AlterColumn<string>(
                name: "TransactionType",
                table: "TblTransaction",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TransactionId",
                table: "TblTransaction",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RowStatus",
                table: "TblTransaction",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Purpose",
                table: "TblTransaction",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PaymentStatus",
                table: "TblTransaction",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Month",
                table: "TblTransaction",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "InvoiceId",
                table: "TblTransaction",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FactoryId",
                table: "TblTransaction",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ExecutorId",
                table: "TblTransaction",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "TblTransaction",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClientId",
                table: "TblTransaction",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "TblTransaction",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TblTransaction",
                table: "TblTransaction",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Factory",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "ImageUrl", "LicenseNo", "Name", "RegNo", "RowStatus", "SubscriptionEnd", "SubscriptionStart", "UpdatedDateTime", "VatRegNo" },
                values: new object[] { "8541aae7-e6f7-4133-a36a-8f7ac1e0394d", new DateTime(2020, 3, 31, 20, 17, 52, 497, DateTimeKind.Local).AddTicks(9657), "fde7b646-b1c4-466d-8144-c055bfd9b01e", "", "", "Fazlu Loom Factory", "", "ADDED", new DateTime(2022, 12, 26, 20, 17, 52, 498, DateTimeKind.Local).AddTicks(4813), new DateTime(2020, 3, 31, 20, 17, 52, 498, DateTimeKind.Local).AddTicks(3828), new DateTime(2020, 3, 31, 20, 17, 52, 498, DateTimeKind.Local).AddTicks(5741), "" });

            migrationBuilder.InsertData(
                table: "ItemStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "Name", "RowStatus", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "1e5e87bb-6a0f-478f-8980-864ef5d6f7a1", new DateTime(2020, 3, 31, 14, 17, 52, 530, DateTimeKind.Utc).AddTicks(9994), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "GOOD", "ADDED", new DateTime(2020, 3, 31, 14, 17, 52, 531, DateTimeKind.Utc).AddTicks(1780) },
                    { "d3f4a236-1931-4d94-b68d-42924f1e4217", new DateTime(2020, 3, 31, 14, 17, 52, 531, DateTimeKind.Utc).AddTicks(1821), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "BAD", "ADDED", new DateTime(2020, 3, 31, 14, 17, 52, 531, DateTimeKind.Utc).AddTicks(1862) }
                });

            migrationBuilder.InsertData(
                table: "PaymentStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "RowStatus", "Status", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "38b688c0-1da5-4082-9a5f-d7471986e538", new DateTime(2020, 3, 31, 14, 17, 52, 538, DateTimeKind.Utc).AddTicks(3664), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVED", new DateTime(2020, 3, 31, 20, 17, 52, 538, DateTimeKind.Local).AddTicks(4584) },
                    { "13fdf70c-cb01-4268-a50e-57320724b274", new DateTime(2020, 3, 31, 14, 17, 52, 538, DateTimeKind.Utc).AddTicks(4625), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAYABLE", new DateTime(2020, 3, 31, 20, 17, 52, 538, DateTimeKind.Local).AddTicks(4662) },
                    { "b23272e2-e51f-47bd-a473-8fbfe305d97d", new DateTime(2020, 3, 31, 14, 17, 52, 538, DateTimeKind.Utc).AddTicks(4666), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVABLE", new DateTime(2020, 3, 31, 20, 17, 52, 538, DateTimeKind.Local).AddTicks(4674) },
                    { "afedbfd6-eb21-4ffe-8b82-f1c81ef0fb77", new DateTime(2020, 3, 31, 14, 17, 52, 538, DateTimeKind.Utc).AddTicks(4674), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAID", new DateTime(2020, 3, 31, 20, 17, 52, 538, DateTimeKind.Local).AddTicks(4678) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TblTransaction",
                table: "TblTransaction");

            migrationBuilder.DeleteData(
                table: "Factory",
                keyColumn: "Id",
                keyValue: "8541aae7-e6f7-4133-a36a-8f7ac1e0394d");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "1e5e87bb-6a0f-478f-8980-864ef5d6f7a1");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "d3f4a236-1931-4d94-b68d-42924f1e4217");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "13fdf70c-cb01-4268-a50e-57320724b274");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "38b688c0-1da5-4082-9a5f-d7471986e538");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "afedbfd6-eb21-4ffe-8b82-f1c81ef0fb77");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "b23272e2-e51f-47bd-a473-8fbfe305d97d");

            migrationBuilder.RenameTable(
                name: "TblTransaction",
                newName: "Transaction");

            migrationBuilder.AlterColumn<string>(
                name: "TransactionType",
                table: "Transaction",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "TransactionId",
                table: "Transaction",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "RowStatus",
                table: "Transaction",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Purpose",
                table: "Transaction",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PaymentStatus",
                table: "Transaction",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Month",
                table: "Transaction",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "InvoiceId",
                table: "Transaction",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FactoryId",
                table: "Transaction",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "ExecutorId",
                table: "Transaction",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Transaction",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClientId",
                table: "Transaction",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Transaction",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transaction",
                table: "Transaction",
                column: "Id");

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
    }
}
