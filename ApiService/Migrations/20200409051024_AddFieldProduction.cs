using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiService.Migrations
{
    public partial class AddFieldProduction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "ItemCategoryId",
                table: "Production",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Factory",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "ImageUrl", "LicenseNo", "Name", "RegNo", "RowStatus", "SubscriptionEnd", "SubscriptionStart", "UpdatedDateTime", "VatRegNo" },
                values: new object[] { "46f3b013-9a66-4abb-bac2-ab83f7e85e8a", new DateTime(2020, 4, 9, 11, 10, 23, 632, DateTimeKind.Local).AddTicks(3246), "1956ba54-23fd-4c94-91c0-10e1b606b2e5", "", "", "Fazlu Loom Factory", "", "ADDED", new DateTime(2023, 1, 4, 11, 10, 23, 632, DateTimeKind.Local).AddTicks(8501), new DateTime(2020, 4, 9, 11, 10, 23, 632, DateTimeKind.Local).AddTicks(7528), new DateTime(2020, 4, 9, 11, 10, 23, 632, DateTimeKind.Local).AddTicks(9416), "" });

            migrationBuilder.InsertData(
                table: "ItemStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "Name", "RowStatus", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "a31d75d5-b03c-4116-9315-33d6650d9b3b", new DateTime(2020, 4, 9, 5, 10, 23, 654, DateTimeKind.Utc).AddTicks(4086), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "GOOD", "ADDED", new DateTime(2020, 4, 9, 5, 10, 23, 654, DateTimeKind.Utc).AddTicks(5720) },
                    { "84dcf0e2-780a-4807-94ef-65cf0247e023", new DateTime(2020, 4, 9, 5, 10, 23, 654, DateTimeKind.Utc).AddTicks(5761), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "BAD", "ADDED", new DateTime(2020, 4, 9, 5, 10, 23, 654, DateTimeKind.Utc).AddTicks(5806) }
                });

            migrationBuilder.InsertData(
                table: "PaymentStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "RowStatus", "Status", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "b35a03fb-4e3d-489d-b5c5-91cdd21a6524", new DateTime(2020, 4, 9, 5, 10, 23, 659, DateTimeKind.Utc).AddTicks(3899), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVED", new DateTime(2020, 4, 9, 11, 10, 23, 659, DateTimeKind.Local).AddTicks(4839) },
                    { "8a35dd78-54dc-4a2b-ad10-6a92afba3619", new DateTime(2020, 4, 9, 5, 10, 23, 659, DateTimeKind.Utc).AddTicks(4884), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAYABLE", new DateTime(2020, 4, 9, 11, 10, 23, 659, DateTimeKind.Local).AddTicks(4934) },
                    { "f23016c1-b7b0-4ac8-aef1-abf0f561e80f", new DateTime(2020, 4, 9, 5, 10, 23, 659, DateTimeKind.Utc).AddTicks(4938), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVABLE", new DateTime(2020, 4, 9, 11, 10, 23, 659, DateTimeKind.Local).AddTicks(4946) },
                    { "0c9f0bec-83ef-4886-a4c4-04f326bb9a6e", new DateTime(2020, 4, 9, 5, 10, 23, 659, DateTimeKind.Utc).AddTicks(4946), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAID", new DateTime(2020, 4, 9, 11, 10, 23, 659, DateTimeKind.Local).AddTicks(4950) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Factory",
                keyColumn: "Id",
                keyValue: "46f3b013-9a66-4abb-bac2-ab83f7e85e8a");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "84dcf0e2-780a-4807-94ef-65cf0247e023");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "a31d75d5-b03c-4116-9315-33d6650d9b3b");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "0c9f0bec-83ef-4886-a4c4-04f326bb9a6e");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "8a35dd78-54dc-4a2b-ad10-6a92afba3619");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "b35a03fb-4e3d-489d-b5c5-91cdd21a6524");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "f23016c1-b7b0-4ac8-aef1-abf0f561e80f");

            migrationBuilder.DropColumn(
                name: "ItemCategoryId",
                table: "Production");

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
    }
}
