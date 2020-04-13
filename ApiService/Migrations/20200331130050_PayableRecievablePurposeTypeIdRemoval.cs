using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiService.Migrations
{
    public partial class PayableRecievablePurposeTypeIdRemoval : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "PurposeTypeId",
                table: "Recievable");

            migrationBuilder.DropColumn(
                name: "PurposeTypeId",
                table: "Payable");

            migrationBuilder.AddColumn<string>(
                name: "Purpose",
                table: "Recievable",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Purpose",
                table: "Payable",
                maxLength: 50,
                nullable: true);

            migrationBuilder.InsertData(
                table: "Factory",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "ImageUrl", "LicenseNo", "Name", "RegNo", "RowStatus", "SubscriptionEnd", "SubscriptionStart", "UpdatedDateTime", "VatRegNo" },
                values: new object[] { "09f2d5bb-939b-4822-b11c-34d392266202", new DateTime(2020, 3, 31, 19, 0, 46, 904, DateTimeKind.Local).AddTicks(295), "c93e5992-a100-4c2f-a48d-66f20979c854", "", "", "Fazlu Loom Factory", "", "ADDED", new DateTime(2022, 12, 26, 19, 0, 46, 904, DateTimeKind.Local).AddTicks(9494), new DateTime(2020, 3, 31, 19, 0, 46, 904, DateTimeKind.Local).AddTicks(8181), new DateTime(2020, 3, 31, 19, 0, 46, 905, DateTimeKind.Local).AddTicks(775), "" });

            migrationBuilder.InsertData(
                table: "ItemStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "Name", "RowStatus", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "6b594010-48e3-4f31-8581-b228bbb46e33", new DateTime(2020, 3, 31, 13, 0, 46, 944, DateTimeKind.Utc).AddTicks(1558), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "GOOD", "ADDED", new DateTime(2020, 3, 31, 13, 0, 46, 944, DateTimeKind.Utc).AddTicks(4178) },
                    { "74a717c6-dffd-4b57-917d-6b806700f3ae", new DateTime(2020, 3, 31, 13, 0, 46, 944, DateTimeKind.Utc).AddTicks(4235), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "BAD", "ADDED", new DateTime(2020, 3, 31, 13, 0, 46, 944, DateTimeKind.Utc).AddTicks(4276) }
                });

            migrationBuilder.InsertData(
                table: "PaymentStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "RowStatus", "Status", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "2184a17b-9d9a-4702-be4e-ac62e66c73a1", new DateTime(2020, 3, 31, 13, 0, 46, 951, DateTimeKind.Utc).AddTicks(9210), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVED", new DateTime(2020, 3, 31, 19, 0, 46, 952, DateTimeKind.Local).AddTicks(491) },
                    { "6f76aeb9-15ca-4f48-9bc9-733fd17f50e2", new DateTime(2020, 3, 31, 13, 0, 46, 952, DateTimeKind.Utc).AddTicks(549), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAYABLE", new DateTime(2020, 3, 31, 19, 0, 46, 952, DateTimeKind.Local).AddTicks(606) },
                    { "0ff505ba-17b0-460f-ab1e-337e5d376ade", new DateTime(2020, 3, 31, 13, 0, 46, 952, DateTimeKind.Utc).AddTicks(610), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVABLE", new DateTime(2020, 3, 31, 19, 0, 46, 952, DateTimeKind.Local).AddTicks(623) },
                    { "298e595a-d738-41a6-adda-cd98839d5be1", new DateTime(2020, 3, 31, 13, 0, 46, 952, DateTimeKind.Utc).AddTicks(623), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAID", new DateTime(2020, 3, 31, 19, 0, 46, 952, DateTimeKind.Local).AddTicks(631) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Factory",
                keyColumn: "Id",
                keyValue: "09f2d5bb-939b-4822-b11c-34d392266202");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "6b594010-48e3-4f31-8581-b228bbb46e33");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "74a717c6-dffd-4b57-917d-6b806700f3ae");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "0ff505ba-17b0-460f-ab1e-337e5d376ade");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "2184a17b-9d9a-4702-be4e-ac62e66c73a1");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "298e595a-d738-41a6-adda-cd98839d5be1");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "6f76aeb9-15ca-4f48-9bc9-733fd17f50e2");

            migrationBuilder.DropColumn(
                name: "Purpose",
                table: "Recievable");

            migrationBuilder.DropColumn(
                name: "Purpose",
                table: "Payable");

            migrationBuilder.AddColumn<string>(
                name: "PurposeTypeId",
                table: "Recievable",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PurposeTypeId",
                table: "Payable",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

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
    }
}
