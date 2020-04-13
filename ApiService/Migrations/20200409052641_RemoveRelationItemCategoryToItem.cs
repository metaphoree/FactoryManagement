using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiService.Migrations
{
    public partial class RemoveRelationItemCategoryToItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Factory",
                keyColumn: "Id",
                keyValue: "74e71871-3c85-4daf-9dd5-9279d8eb2cd9");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "78a25ef7-77b1-45bf-8d29-b37a0be28a8b");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "b48cba78-77ca-48c6-90ed-e0004266359a");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "013f93a0-32c9-463f-9849-7f519cfffcdd");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "73fedfce-3684-4d78-ab6f-2d4450ce66a3");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "a3a148d8-6174-4a12-b55f-2e0a5e0ba3fa");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "df2b6b06-3ae1-4cce-9c05-28d108652187");

            migrationBuilder.InsertData(
                table: "Factory",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "ImageUrl", "LicenseNo", "Name", "RegNo", "RowStatus", "SubscriptionEnd", "SubscriptionStart", "UpdatedDateTime", "VatRegNo" },
                values: new object[] { "d68b25c3-855a-44ac-b6ef-7657677b9297", new DateTime(2020, 4, 9, 11, 26, 40, 774, DateTimeKind.Local).AddTicks(1358), "07923359-0e06-4842-84e1-d6108f14863d", "", "", "Fazlu Loom Factory", "", "ADDED", new DateTime(2023, 1, 4, 11, 26, 40, 774, DateTimeKind.Local).AddTicks(6682), new DateTime(2020, 4, 9, 11, 26, 40, 774, DateTimeKind.Local).AddTicks(5709), new DateTime(2020, 4, 9, 11, 26, 40, 774, DateTimeKind.Local).AddTicks(7581), "" });

            migrationBuilder.InsertData(
                table: "ItemStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "Name", "RowStatus", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "7714b292-23a0-4f5a-bd49-635867be9891", new DateTime(2020, 4, 9, 5, 26, 40, 796, DateTimeKind.Utc).AddTicks(9784), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "GOOD", "ADDED", new DateTime(2020, 4, 9, 5, 26, 40, 797, DateTimeKind.Utc).AddTicks(1463) },
                    { "2b64619f-43f0-4232-bf79-ccd5c1512473", new DateTime(2020, 4, 9, 5, 26, 40, 797, DateTimeKind.Utc).AddTicks(1508), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "BAD", "ADDED", new DateTime(2020, 4, 9, 5, 26, 40, 797, DateTimeKind.Utc).AddTicks(1541) }
                });

            migrationBuilder.InsertData(
                table: "PaymentStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "RowStatus", "Status", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "9f775bba-df16-4707-befc-1831e2dbe728", new DateTime(2020, 4, 9, 5, 26, 40, 802, DateTimeKind.Utc).AddTicks(5337), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVED", new DateTime(2020, 4, 9, 11, 26, 40, 802, DateTimeKind.Local).AddTicks(6252) },
                    { "2e89aae1-a58e-465e-8703-0e111a5720e3", new DateTime(2020, 4, 9, 5, 26, 40, 802, DateTimeKind.Utc).AddTicks(6298), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAYABLE", new DateTime(2020, 4, 9, 11, 26, 40, 802, DateTimeKind.Local).AddTicks(6330) },
                    { "9a4a1e05-8956-4963-8ee8-06dffa65bb09", new DateTime(2020, 4, 9, 5, 26, 40, 802, DateTimeKind.Utc).AddTicks(6330), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVABLE", new DateTime(2020, 4, 9, 11, 26, 40, 802, DateTimeKind.Local).AddTicks(6339) },
                    { "901ccd90-910e-4712-a05b-df53a4f0ade8", new DateTime(2020, 4, 9, 5, 26, 40, 802, DateTimeKind.Utc).AddTicks(6343), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAID", new DateTime(2020, 4, 9, 11, 26, 40, 802, DateTimeKind.Local).AddTicks(6347) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Factory",
                keyColumn: "Id",
                keyValue: "d68b25c3-855a-44ac-b6ef-7657677b9297");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "2b64619f-43f0-4232-bf79-ccd5c1512473");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "7714b292-23a0-4f5a-bd49-635867be9891");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "2e89aae1-a58e-465e-8703-0e111a5720e3");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "901ccd90-910e-4712-a05b-df53a4f0ade8");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "9a4a1e05-8956-4963-8ee8-06dffa65bb09");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "9f775bba-df16-4707-befc-1831e2dbe728");

            migrationBuilder.InsertData(
                table: "Factory",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "ImageUrl", "LicenseNo", "Name", "RegNo", "RowStatus", "SubscriptionEnd", "SubscriptionStart", "UpdatedDateTime", "VatRegNo" },
                values: new object[] { "74e71871-3c85-4daf-9dd5-9279d8eb2cd9", new DateTime(2020, 4, 9, 11, 21, 15, 614, DateTimeKind.Local).AddTicks(6), "0537f6b3-7d14-4761-b24a-8b11cded3ac4", "", "", "Fazlu Loom Factory", "", "ADDED", new DateTime(2023, 1, 4, 11, 21, 15, 614, DateTimeKind.Local).AddTicks(5999), new DateTime(2020, 4, 9, 11, 21, 15, 614, DateTimeKind.Local).AddTicks(4977), new DateTime(2020, 4, 9, 11, 21, 15, 614, DateTimeKind.Local).AddTicks(7231), "" });

            migrationBuilder.InsertData(
                table: "ItemStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "Name", "RowStatus", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "78a25ef7-77b1-45bf-8d29-b37a0be28a8b", new DateTime(2020, 4, 9, 5, 21, 15, 640, DateTimeKind.Utc).AddTicks(626), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "GOOD", "ADDED", new DateTime(2020, 4, 9, 5, 21, 15, 640, DateTimeKind.Utc).AddTicks(2318) },
                    { "b48cba78-77ca-48c6-90ed-e0004266359a", new DateTime(2020, 4, 9, 5, 21, 15, 640, DateTimeKind.Utc).AddTicks(2363), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "BAD", "ADDED", new DateTime(2020, 4, 9, 5, 21, 15, 640, DateTimeKind.Utc).AddTicks(2392) }
                });

            migrationBuilder.InsertData(
                table: "PaymentStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "RowStatus", "Status", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "73fedfce-3684-4d78-ab6f-2d4450ce66a3", new DateTime(2020, 4, 9, 5, 21, 15, 645, DateTimeKind.Utc).AddTicks(7891), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVED", new DateTime(2020, 4, 9, 11, 21, 15, 645, DateTimeKind.Local).AddTicks(9056) },
                    { "013f93a0-32c9-463f-9849-7f519cfffcdd", new DateTime(2020, 4, 9, 5, 21, 15, 645, DateTimeKind.Utc).AddTicks(9106), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAYABLE", new DateTime(2020, 4, 9, 11, 21, 15, 645, DateTimeKind.Local).AddTicks(9139) },
                    { "a3a148d8-6174-4a12-b55f-2e0a5e0ba3fa", new DateTime(2020, 4, 9, 5, 21, 15, 645, DateTimeKind.Utc).AddTicks(9143), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVABLE", new DateTime(2020, 4, 9, 11, 21, 15, 645, DateTimeKind.Local).AddTicks(9163) },
                    { "df2b6b06-3ae1-4cce-9c05-28d108652187", new DateTime(2020, 4, 9, 5, 21, 15, 645, DateTimeKind.Utc).AddTicks(9163), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAID", new DateTime(2020, 4, 9, 11, 21, 15, 645, DateTimeKind.Local).AddTicks(9171) }
                });
        }
    }
}
