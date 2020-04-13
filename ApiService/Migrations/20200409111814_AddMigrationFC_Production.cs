using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiService.Migrations
{
    public partial class AddMigrationFC_Production : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "fb85e822-c277-4958-91bc-c8583915ce38", new DateTime(2020, 4, 9, 17, 18, 12, 777, DateTimeKind.Local).AddTicks(698), "0abc3588-b30c-446f-b20f-0984b4b3d7f1", "", "", "Fazlu Loom Factory", "", "ADDED", new DateTime(2023, 1, 4, 17, 18, 12, 777, DateTimeKind.Local).AddTicks(5949), new DateTime(2020, 4, 9, 17, 18, 12, 777, DateTimeKind.Local).AddTicks(5066), new DateTime(2020, 4, 9, 17, 18, 12, 777, DateTimeKind.Local).AddTicks(6790), "" });

            migrationBuilder.InsertData(
                table: "ItemStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "Name", "RowStatus", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "7a532f74-e7e1-4e8c-bf0e-cd34922b7946", new DateTime(2020, 4, 9, 11, 18, 12, 815, DateTimeKind.Utc).AddTicks(9740), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "GOOD", "ADDED", new DateTime(2020, 4, 9, 11, 18, 12, 816, DateTimeKind.Utc).AddTicks(1362) },
                    { "14f6ff62-9693-4035-b2fe-d937dcbfcd47", new DateTime(2020, 4, 9, 11, 18, 12, 816, DateTimeKind.Utc).AddTicks(1407), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "BAD", "ADDED", new DateTime(2020, 4, 9, 11, 18, 12, 816, DateTimeKind.Utc).AddTicks(1436) }
                });

            migrationBuilder.InsertData(
                table: "PaymentStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "RowStatus", "Status", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "7b37dbdf-f411-4175-bc26-561ca3a63ded", new DateTime(2020, 4, 9, 11, 18, 12, 821, DateTimeKind.Utc).AddTicks(526), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVED", new DateTime(2020, 4, 9, 17, 18, 12, 821, DateTimeKind.Local).AddTicks(1446) },
                    { "bf2a181e-df18-4887-b699-7b2b1a5207a8", new DateTime(2020, 4, 9, 11, 18, 12, 821, DateTimeKind.Utc).AddTicks(1495), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAYABLE", new DateTime(2020, 4, 9, 17, 18, 12, 821, DateTimeKind.Local).AddTicks(1606) },
                    { "ee0cc9fe-46e9-4be2-9cce-b19f9758caa8", new DateTime(2020, 4, 9, 11, 18, 12, 821, DateTimeKind.Utc).AddTicks(1610), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVABLE", new DateTime(2020, 4, 9, 17, 18, 12, 821, DateTimeKind.Local).AddTicks(1631) },
                    { "5cddf83d-f8bc-42c1-ad37-76c3889edd1e", new DateTime(2020, 4, 9, 11, 18, 12, 821, DateTimeKind.Utc).AddTicks(1635), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAID", new DateTime(2020, 4, 9, 17, 18, 12, 821, DateTimeKind.Local).AddTicks(1639) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Production_ItemId",
                table: "Production",
                column: "ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Production_Item_ItemId",
                table: "Production",
                column: "ItemId",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Production_Item_ItemId",
                table: "Production");

            migrationBuilder.DropIndex(
                name: "IX_Production_ItemId",
                table: "Production");

            migrationBuilder.DeleteData(
                table: "Factory",
                keyColumn: "Id",
                keyValue: "fb85e822-c277-4958-91bc-c8583915ce38");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "14f6ff62-9693-4035-b2fe-d937dcbfcd47");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "7a532f74-e7e1-4e8c-bf0e-cd34922b7946");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "5cddf83d-f8bc-42c1-ad37-76c3889edd1e");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "7b37dbdf-f411-4175-bc26-561ca3a63ded");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "bf2a181e-df18-4887-b699-7b2b1a5207a8");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "ee0cc9fe-46e9-4be2-9cce-b19f9758caa8");

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
    }
}
