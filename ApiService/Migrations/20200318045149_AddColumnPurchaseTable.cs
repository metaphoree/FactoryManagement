using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiService.Migrations
{
    public partial class AddColumnPurchaseTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Factory",
                keyColumn: "Id",
                keyValue: "73fb3a73-f2a3-49a2-b13a-99ef1df28366");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "11f8392c-1e62-469f-ad90-c68edf735fef");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "eedb5ed6-f89e-48d9-8cfe-b2fd622a806d");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "0124aa97-355d-469d-a3b2-001cfacf0d84");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "1ea8e0dc-6127-40c0-8dc9-e1934800c7de");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "80aafad3-5337-4191-a475-f189d900fa2a");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "fe585e88-a9e7-4ba0-bcb0-2ff2dfcf2b93");

            migrationBuilder.AddColumn<decimal>(
                name: "Amount",
                table: "Purchase",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.InsertData(
                table: "Factory",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "ImageUrl", "LicenseNo", "Name", "RegNo", "RowStatus", "SubscriptionEnd", "SubscriptionStart", "UpdatedDateTime", "VatRegNo" },
                values: new object[] { "44d15467-42ad-483d-b2e6-9f1b0e7a5c6e", new DateTime(2020, 3, 18, 10, 51, 48, 353, DateTimeKind.Local).AddTicks(3030), "7b526292-3de4-48ae-b28b-e00c7b4345f5", "", "", "Fazlu Loom Factory", "", "ADDED", new DateTime(2022, 12, 13, 10, 51, 48, 354, DateTimeKind.Local).AddTicks(7699), new DateTime(2020, 3, 18, 10, 51, 48, 354, DateTimeKind.Local).AddTicks(4509), new DateTime(2020, 3, 18, 10, 51, 48, 355, DateTimeKind.Local).AddTicks(63), "" });

            migrationBuilder.InsertData(
                table: "ItemStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "Name", "RowStatus", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "8cb655f8-8ebb-446a-a336-b6d59dead736", new DateTime(2020, 3, 18, 4, 51, 48, 380, DateTimeKind.Utc).AddTicks(959), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "GOOD", "ADDED", new DateTime(2020, 3, 18, 4, 51, 48, 380, DateTimeKind.Utc).AddTicks(2790) },
                    { "7808f3c1-a97b-4fee-a5f9-9ce6bddd101c", new DateTime(2020, 3, 18, 4, 51, 48, 380, DateTimeKind.Utc).AddTicks(2831), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "BAD", "ADDED", new DateTime(2020, 3, 18, 4, 51, 48, 380, DateTimeKind.Utc).AddTicks(2860) }
                });

            migrationBuilder.InsertData(
                table: "PaymentStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "RowStatus", "Status", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "5bef3ccb-9071-4ca4-8129-269449807c4d", new DateTime(2020, 3, 18, 4, 51, 48, 387, DateTimeKind.Utc).AddTicks(3841), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVED", new DateTime(2020, 3, 18, 10, 51, 48, 387, DateTimeKind.Local).AddTicks(5216) },
                    { "597222b9-a00e-4c5c-ae5b-c4ec6e83b545", new DateTime(2020, 3, 18, 4, 51, 48, 387, DateTimeKind.Utc).AddTicks(5274), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAYABLE", new DateTime(2020, 3, 18, 10, 51, 48, 387, DateTimeKind.Local).AddTicks(5327) },
                    { "fd635343-ef7c-4ce7-8814-8a6f85c8de37", new DateTime(2020, 3, 18, 4, 51, 48, 387, DateTimeKind.Utc).AddTicks(5331), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVABLE", new DateTime(2020, 3, 18, 10, 51, 48, 387, DateTimeKind.Local).AddTicks(5344) },
                    { "3a5d3a6a-e3e3-4dc5-b9b0-de267c2370d2", new DateTime(2020, 3, 18, 4, 51, 48, 387, DateTimeKind.Utc).AddTicks(5344), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAID", new DateTime(2020, 3, 18, 10, 51, 48, 387, DateTimeKind.Local).AddTicks(5352) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Factory",
                keyColumn: "Id",
                keyValue: "44d15467-42ad-483d-b2e6-9f1b0e7a5c6e");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "7808f3c1-a97b-4fee-a5f9-9ce6bddd101c");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "8cb655f8-8ebb-446a-a336-b6d59dead736");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "3a5d3a6a-e3e3-4dc5-b9b0-de267c2370d2");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "597222b9-a00e-4c5c-ae5b-c4ec6e83b545");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "5bef3ccb-9071-4ca4-8129-269449807c4d");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "fd635343-ef7c-4ce7-8814-8a6f85c8de37");

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Purchase");

            migrationBuilder.InsertData(
                table: "Factory",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "ImageUrl", "LicenseNo", "Name", "RegNo", "RowStatus", "SubscriptionEnd", "SubscriptionStart", "UpdatedDateTime", "VatRegNo" },
                values: new object[] { "73fb3a73-f2a3-49a2-b13a-99ef1df28366", new DateTime(2020, 3, 18, 10, 6, 13, 840, DateTimeKind.Local).AddTicks(3923), "d6180274-1d86-4675-b1fd-f779bf02f0ed", "", "", "Fazlu Loom Factory", "", "ADDED", new DateTime(2022, 12, 13, 10, 6, 13, 840, DateTimeKind.Local).AddTicks(9826), new DateTime(2020, 3, 18, 10, 6, 13, 840, DateTimeKind.Local).AddTicks(8825), new DateTime(2020, 3, 18, 10, 6, 13, 841, DateTimeKind.Local).AddTicks(738), "" });

            migrationBuilder.InsertData(
                table: "ItemStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "Name", "RowStatus", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "11f8392c-1e62-469f-ad90-c68edf735fef", new DateTime(2020, 3, 18, 4, 6, 13, 860, DateTimeKind.Utc).AddTicks(1245), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "GOOD", "ADDED", new DateTime(2020, 3, 18, 4, 6, 13, 860, DateTimeKind.Utc).AddTicks(2940) },
                    { "eedb5ed6-f89e-48d9-8cfe-b2fd622a806d", new DateTime(2020, 3, 18, 4, 6, 13, 860, DateTimeKind.Utc).AddTicks(2973), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "BAD", "ADDED", new DateTime(2020, 3, 18, 4, 6, 13, 860, DateTimeKind.Utc).AddTicks(3002) }
                });

            migrationBuilder.InsertData(
                table: "PaymentStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "RowStatus", "Status", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "80aafad3-5337-4191-a475-f189d900fa2a", new DateTime(2020, 3, 18, 4, 6, 13, 865, DateTimeKind.Utc).AddTicks(3411), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVED", new DateTime(2020, 3, 18, 10, 6, 13, 865, DateTimeKind.Local).AddTicks(5853) },
                    { "1ea8e0dc-6127-40c0-8dc9-e1934800c7de", new DateTime(2020, 3, 18, 4, 6, 13, 865, DateTimeKind.Utc).AddTicks(5915), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAYABLE", new DateTime(2020, 3, 18, 10, 6, 13, 865, DateTimeKind.Local).AddTicks(6001) },
                    { "fe585e88-a9e7-4ba0-bcb0-2ff2dfcf2b93", new DateTime(2020, 3, 18, 4, 6, 13, 865, DateTimeKind.Utc).AddTicks(6005), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVABLE", new DateTime(2020, 3, 18, 10, 6, 13, 865, DateTimeKind.Local).AddTicks(6017) },
                    { "0124aa97-355d-469d-a3b2-001cfacf0d84", new DateTime(2020, 3, 18, 4, 6, 13, 865, DateTimeKind.Utc).AddTicks(6017), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAID", new DateTime(2020, 3, 18, 10, 6, 13, 865, DateTimeKind.Local).AddTicks(6026) }
                });
        }
    }
}
