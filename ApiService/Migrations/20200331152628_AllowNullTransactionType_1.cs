using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiService.Migrations
{
    public partial class AllowNullTransactionType_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Factory",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "ImageUrl", "LicenseNo", "Name", "RegNo", "RowStatus", "SubscriptionEnd", "SubscriptionStart", "UpdatedDateTime", "VatRegNo" },
                values: new object[] { "ecd834c4-d468-4f59-aaf5-7c57c21e0856", new DateTime(2020, 3, 31, 21, 26, 27, 722, DateTimeKind.Local).AddTicks(8452), "fe7baa79-f26e-4c29-96b4-1120f2672710", "", "", "Fazlu Loom Factory", "", "ADDED", new DateTime(2022, 12, 26, 21, 26, 27, 723, DateTimeKind.Local).AddTicks(6314), new DateTime(2020, 3, 31, 21, 26, 27, 723, DateTimeKind.Local).AddTicks(4913), new DateTime(2020, 3, 31, 21, 26, 27, 723, DateTimeKind.Local).AddTicks(7607), "" });

            migrationBuilder.InsertData(
                table: "ItemStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "Name", "RowStatus", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "0f0fd2f1-2527-4f68-9814-be250e1e95d9", new DateTime(2020, 3, 31, 15, 26, 27, 763, DateTimeKind.Utc).AddTicks(5727), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "GOOD", "ADDED", new DateTime(2020, 3, 31, 15, 26, 27, 763, DateTimeKind.Utc).AddTicks(8120) },
                    { "a9f1f637-d9f1-4226-8b5d-b9c4fbcc7af4", new DateTime(2020, 3, 31, 15, 26, 27, 763, DateTimeKind.Utc).AddTicks(8169), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "BAD", "ADDED", new DateTime(2020, 3, 31, 15, 26, 27, 763, DateTimeKind.Utc).AddTicks(8214) }
                });

            migrationBuilder.InsertData(
                table: "PaymentStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "RowStatus", "Status", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "f97b64a2-bb06-42c8-a522-235f20c318ff", new DateTime(2020, 3, 31, 15, 26, 27, 772, DateTimeKind.Utc).AddTicks(3501), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVED", new DateTime(2020, 3, 31, 21, 26, 27, 772, DateTimeKind.Local).AddTicks(4881) },
                    { "42f8062e-e0ef-4338-9392-e282e5d0446d", new DateTime(2020, 3, 31, 15, 26, 27, 772, DateTimeKind.Utc).AddTicks(4947), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAYABLE", new DateTime(2020, 3, 31, 21, 26, 27, 772, DateTimeKind.Local).AddTicks(5004) },
                    { "e18cda76-5590-44bb-bce2-db9d2b4256d2", new DateTime(2020, 3, 31, 15, 26, 27, 772, DateTimeKind.Utc).AddTicks(5009), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVABLE", new DateTime(2020, 3, 31, 21, 26, 27, 772, DateTimeKind.Local).AddTicks(5037) },
                    { "08be1bd0-cf41-4a77-a227-019d4e6a4054", new DateTime(2020, 3, 31, 15, 26, 27, 772, DateTimeKind.Utc).AddTicks(5041), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAID", new DateTime(2020, 3, 31, 21, 26, 27, 772, DateTimeKind.Local).AddTicks(5050) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Factory",
                keyColumn: "Id",
                keyValue: "ecd834c4-d468-4f59-aaf5-7c57c21e0856");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "0f0fd2f1-2527-4f68-9814-be250e1e95d9");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "a9f1f637-d9f1-4226-8b5d-b9c4fbcc7af4");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "08be1bd0-cf41-4a77-a227-019d4e6a4054");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "42f8062e-e0ef-4338-9392-e282e5d0446d");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "e18cda76-5590-44bb-bce2-db9d2b4256d2");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "f97b64a2-bb06-42c8-a522-235f20c318ff");

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
    }
}
