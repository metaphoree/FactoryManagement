using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiService.Migrations
{
    public partial class AllowNullTransactionType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<string>(
                name: "TransactionType",
                table: "TblTransaction",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.InsertData(
                table: "Factory",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "ImageUrl", "LicenseNo", "Name", "RegNo", "RowStatus", "SubscriptionEnd", "SubscriptionStart", "UpdatedDateTime", "VatRegNo" },
                values: new object[] { "cd2b5ed9-d122-430d-b2d0-624a8f96a80f", new DateTime(2020, 3, 31, 21, 21, 27, 950, DateTimeKind.Local).AddTicks(3508), "210c96a3-2b80-447c-9bb5-fcdb3c10d281", "", "", "Fazlu Loom Factory", "", "ADDED", new DateTime(2022, 12, 26, 21, 21, 27, 951, DateTimeKind.Local).AddTicks(1423), new DateTime(2020, 3, 31, 21, 21, 27, 950, DateTimeKind.Local).AddTicks(9998), new DateTime(2020, 3, 31, 21, 21, 27, 951, DateTimeKind.Local).AddTicks(2753), "" });

            migrationBuilder.InsertData(
                table: "ItemStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "Name", "RowStatus", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "adf39437-d234-42c4-92e1-51c58c47fcf6", new DateTime(2020, 3, 31, 15, 21, 27, 982, DateTimeKind.Utc).AddTicks(3150), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "GOOD", "ADDED", new DateTime(2020, 3, 31, 15, 21, 27, 982, DateTimeKind.Utc).AddTicks(5130) },
                    { "a2f1ed80-3701-4042-9eaa-381638b2b6a9", new DateTime(2020, 3, 31, 15, 21, 27, 982, DateTimeKind.Utc).AddTicks(5166), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "BAD", "ADDED", new DateTime(2020, 3, 31, 15, 21, 27, 982, DateTimeKind.Utc).AddTicks(5212) }
                });

            migrationBuilder.InsertData(
                table: "PaymentStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "RowStatus", "Status", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "f39f596b-8cef-4ea2-ac87-3f1e1fb178cf", new DateTime(2020, 3, 31, 15, 21, 27, 989, DateTimeKind.Utc).AddTicks(6656), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVED", new DateTime(2020, 3, 31, 21, 21, 27, 989, DateTimeKind.Local).AddTicks(7625) },
                    { "9000f874-9084-427b-a2b5-dfd9baea46f2", new DateTime(2020, 3, 31, 15, 21, 27, 989, DateTimeKind.Utc).AddTicks(7674), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAYABLE", new DateTime(2020, 3, 31, 21, 21, 27, 989, DateTimeKind.Local).AddTicks(7724) },
                    { "092c4baa-be95-43da-a7a4-1685d5921ef3", new DateTime(2020, 3, 31, 15, 21, 27, 989, DateTimeKind.Utc).AddTicks(7728), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVABLE", new DateTime(2020, 3, 31, 21, 21, 27, 989, DateTimeKind.Local).AddTicks(7732) },
                    { "b2fc39cd-46ff-4b2e-9c9c-ab3bfe58d8d1", new DateTime(2020, 3, 31, 15, 21, 27, 989, DateTimeKind.Utc).AddTicks(7736), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAID", new DateTime(2020, 3, 31, 21, 21, 27, 989, DateTimeKind.Local).AddTicks(7740) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Factory",
                keyColumn: "Id",
                keyValue: "cd2b5ed9-d122-430d-b2d0-624a8f96a80f");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "a2f1ed80-3701-4042-9eaa-381638b2b6a9");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "adf39437-d234-42c4-92e1-51c58c47fcf6");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "092c4baa-be95-43da-a7a4-1685d5921ef3");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "9000f874-9084-427b-a2b5-dfd9baea46f2");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "b2fc39cd-46ff-4b2e-9c9c-ab3bfe58d8d1");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "f39f596b-8cef-4ea2-ac87-3f1e1fb178cf");

            migrationBuilder.AlterColumn<string>(
                name: "TransactionType",
                table: "TblTransaction",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

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
    }
}
