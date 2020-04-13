using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiService.Migrations
{
    public partial class Transaction2TblTransaction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Factory",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "ImageUrl", "LicenseNo", "Name", "RegNo", "RowStatus", "SubscriptionEnd", "SubscriptionStart", "UpdatedDateTime", "VatRegNo" },
                values: new object[] { "cdb577fd-e9f5-46b0-b803-48d41f6f2fb9", new DateTime(2020, 3, 31, 19, 25, 41, 259, DateTimeKind.Local).AddTicks(326), "a66c12ce-2472-4c6f-8bed-33ded93d2382", "", "", "Fazlu Loom Factory", "", "ADDED", new DateTime(2022, 12, 26, 19, 25, 41, 259, DateTimeKind.Local).AddTicks(5564), new DateTime(2020, 3, 31, 19, 25, 41, 259, DateTimeKind.Local).AddTicks(4571), new DateTime(2020, 3, 31, 19, 25, 41, 259, DateTimeKind.Local).AddTicks(6472), "" });

            migrationBuilder.InsertData(
                table: "ItemStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "Name", "RowStatus", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "a94cf19d-55ab-4d29-b145-1a8668452de7", new DateTime(2020, 3, 31, 13, 25, 41, 287, DateTimeKind.Utc).AddTicks(7557), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "GOOD", "ADDED", new DateTime(2020, 3, 31, 13, 25, 41, 287, DateTimeKind.Utc).AddTicks(9512) },
                    { "9e607359-457c-48d2-a8c8-21bd9d858d1a", new DateTime(2020, 3, 31, 13, 25, 41, 287, DateTimeKind.Utc).AddTicks(9553), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "BAD", "ADDED", new DateTime(2020, 3, 31, 13, 25, 41, 287, DateTimeKind.Utc).AddTicks(9594) }
                });

            migrationBuilder.InsertData(
                table: "PaymentStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "RowStatus", "Status", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "3ffe1a40-a283-4986-be4d-6e899aa6c6c9", new DateTime(2020, 3, 31, 13, 25, 41, 293, DateTimeKind.Utc).AddTicks(5085), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVED", new DateTime(2020, 3, 31, 19, 25, 41, 293, DateTimeKind.Local).AddTicks(6009) },
                    { "4d91315d-3ed4-49ce-a736-d8b45d2a91df", new DateTime(2020, 3, 31, 13, 25, 41, 293, DateTimeKind.Utc).AddTicks(6054), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAYABLE", new DateTime(2020, 3, 31, 19, 25, 41, 293, DateTimeKind.Local).AddTicks(6108) },
                    { "a00040c9-3230-4000-8c17-505bd293e267", new DateTime(2020, 3, 31, 13, 25, 41, 293, DateTimeKind.Utc).AddTicks(6112), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVABLE", new DateTime(2020, 3, 31, 19, 25, 41, 293, DateTimeKind.Local).AddTicks(6116) },
                    { "4300ada6-aa86-4980-b3a7-1f8c6b18db19", new DateTime(2020, 3, 31, 13, 25, 41, 293, DateTimeKind.Utc).AddTicks(6116), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAID", new DateTime(2020, 3, 31, 19, 25, 41, 293, DateTimeKind.Local).AddTicks(6124) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Factory",
                keyColumn: "Id",
                keyValue: "cdb577fd-e9f5-46b0-b803-48d41f6f2fb9");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "9e607359-457c-48d2-a8c8-21bd9d858d1a");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "a94cf19d-55ab-4d29-b145-1a8668452de7");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "3ffe1a40-a283-4986-be4d-6e899aa6c6c9");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "4300ada6-aa86-4980-b3a7-1f8c6b18db19");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "4d91315d-3ed4-49ce-a736-d8b45d2a91df");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "a00040c9-3230-4000-8c17-505bd293e267");

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
    }
}
