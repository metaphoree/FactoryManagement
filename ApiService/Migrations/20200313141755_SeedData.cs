using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiService.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Factory",
                keyColumn: "Id",
                keyValue: "ae2e825f-997c-4384-a77d-5b0a579813ab");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "7730c5a0-2a7d-49af-97ac-1f299c987c44");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "a531b24c-1719-4d22-ad17-b99464cba94b");

            migrationBuilder.InsertData(
                table: "Factory",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "ImageUrl", "LicenseNo", "Name", "RegNo", "RowStatus", "SubscriptionEnd", "SubscriptionStart", "UpdatedDateTime", "VatRegNo" },
                values: new object[] { "1c533e87-5fb4-4608-b3a0-c9c7993d1078", new DateTime(2020, 3, 13, 20, 17, 53, 876, DateTimeKind.Local).AddTicks(4698), "fb82e823-ff41-4de7-9cd6-2cffc76d8e5d", "", "", "Fazlu Loom Factory", "", "ADDED", new DateTime(2022, 12, 8, 20, 17, 53, 877, DateTimeKind.Local).AddTicks(947), new DateTime(2020, 3, 13, 20, 17, 53, 876, DateTimeKind.Local).AddTicks(9908), new DateTime(2020, 3, 13, 20, 17, 53, 877, DateTimeKind.Local).AddTicks(1846), "" });

            migrationBuilder.InsertData(
                table: "ItemStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "Name", "RowStatus", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "6efb8f1e-e9d7-4ad9-946c-3ecf2bd4678c", new DateTime(2020, 3, 13, 14, 17, 53, 900, DateTimeKind.Utc).AddTicks(1702), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "GOOD", "ADDED", new DateTime(2020, 3, 13, 14, 17, 53, 900, DateTimeKind.Utc).AddTicks(3352) },
                    { "f8340190-2402-4047-842e-f621f3842a4a", new DateTime(2020, 3, 13, 14, 17, 53, 900, DateTimeKind.Utc).AddTicks(3393), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "BAD", "ADDED", new DateTime(2020, 3, 13, 14, 17, 53, 900, DateTimeKind.Utc).AddTicks(3426) }
                });

            migrationBuilder.InsertData(
                table: "PaymentStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "RowStatus", "Status", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "e3dc6104-2298-4797-a557-960b1a4520ae", new DateTime(2020, 3, 13, 14, 17, 53, 907, DateTimeKind.Utc).AddTicks(9711), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVED", new DateTime(2020, 3, 13, 20, 17, 53, 908, DateTimeKind.Local).AddTicks(893) },
                    { "bce5c7d1-4415-42d0-ae77-c79341f10904", new DateTime(2020, 3, 13, 14, 17, 53, 908, DateTimeKind.Utc).AddTicks(946), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAYABLE", new DateTime(2020, 3, 13, 20, 17, 53, 908, DateTimeKind.Local).AddTicks(1004) },
                    { "4fc689bc-00ca-454f-86f3-8844ccde9741", new DateTime(2020, 3, 13, 14, 17, 53, 908, DateTimeKind.Utc).AddTicks(1008), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVABLE", new DateTime(2020, 3, 13, 20, 17, 53, 908, DateTimeKind.Local).AddTicks(1020) },
                    { "4acf847e-754c-4c4e-b768-8427258690a5", new DateTime(2020, 3, 13, 14, 17, 53, 908, DateTimeKind.Utc).AddTicks(1024), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAID", new DateTime(2020, 3, 13, 20, 17, 53, 908, DateTimeKind.Local).AddTicks(1028) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Factory",
                keyColumn: "Id",
                keyValue: "1c533e87-5fb4-4608-b3a0-c9c7993d1078");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "6efb8f1e-e9d7-4ad9-946c-3ecf2bd4678c");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "f8340190-2402-4047-842e-f621f3842a4a");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "4acf847e-754c-4c4e-b768-8427258690a5");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "4fc689bc-00ca-454f-86f3-8844ccde9741");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "bce5c7d1-4415-42d0-ae77-c79341f10904");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "e3dc6104-2298-4797-a557-960b1a4520ae");

            migrationBuilder.InsertData(
                table: "Factory",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "ImageUrl", "LicenseNo", "Name", "RegNo", "RowStatus", "SubscriptionEnd", "SubscriptionStart", "UpdatedDateTime", "VatRegNo" },
                values: new object[] { "ae2e825f-997c-4384-a77d-5b0a579813ab", new DateTime(2020, 3, 13, 10, 42, 25, 949, DateTimeKind.Local).AddTicks(6777), "54569290-52f7-4544-827d-9e1132a96565", "", "", "Fazlu Loom Factory", "", "ADDED", new DateTime(2022, 12, 8, 10, 42, 25, 951, DateTimeKind.Local).AddTicks(1039), new DateTime(2020, 3, 13, 10, 42, 25, 950, DateTimeKind.Local).AddTicks(4023), new DateTime(2020, 3, 13, 10, 42, 25, 951, DateTimeKind.Local).AddTicks(2989), "" });

            migrationBuilder.InsertData(
                table: "ItemStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "Name", "RowStatus", "UpdatedDateTime" },
                values: new object[] { "7730c5a0-2a7d-49af-97ac-1f299c987c44", new DateTime(2020, 3, 13, 4, 42, 25, 988, DateTimeKind.Utc).AddTicks(4884), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "GOOD", "ADDED", new DateTime(2020, 3, 13, 4, 42, 25, 988, DateTimeKind.Utc).AddTicks(6584) });

            migrationBuilder.InsertData(
                table: "ItemStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "Name", "RowStatus", "UpdatedDateTime" },
                values: new object[] { "a531b24c-1719-4d22-ad17-b99464cba94b", new DateTime(2020, 3, 13, 4, 42, 25, 988, DateTimeKind.Utc).AddTicks(6625), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "BAD", "ADDED", new DateTime(2020, 3, 13, 4, 42, 25, 988, DateTimeKind.Utc).AddTicks(6662) });
        }
    }
}
