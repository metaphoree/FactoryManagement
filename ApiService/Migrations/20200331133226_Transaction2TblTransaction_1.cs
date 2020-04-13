using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiService.Migrations
{
    public partial class Transaction2TblTransaction_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
