using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiService.Migrations
{
    public partial class FildchangeInvoice_6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Factory",
                keyColumn: "Id",
                keyValue: "7890fe3f-13f7-490e-83f9-5abfff2d29f0");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "06f917dd-06c6-4fc1-8fbe-7049dcbcbcad");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "71375479-28e9-4b81-acf5-e768594a0c12");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "1ab25ef9-1412-47b4-b91a-2a5af5a224d9");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "b3724297-a8b7-43da-b7a2-31706f80f023");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "c1577b67-e33d-4ba7-be0a-1d4e23d5b4be");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "e6a4e07e-fba3-448b-91e2-6546d1d0dc35");

            migrationBuilder.InsertData(
                table: "Factory",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "ImageUrl", "LicenseNo", "Name", "RegNo", "RowStatus", "SubscriptionEnd", "SubscriptionStart", "UpdatedDateTime", "VatRegNo" },
                values: new object[] { "ac329cdc-1e4d-4cf4-820a-580cacaee67d", new DateTime(2020, 4, 11, 12, 54, 49, 720, DateTimeKind.Local).AddTicks(5760), "3d21e625-d9c1-4eb7-8f6e-272157f5bdc8", "", "", "Fazlu Loom Factory", "", "ADDED", new DateTime(2023, 1, 6, 12, 54, 49, 721, DateTimeKind.Local).AddTicks(1266), new DateTime(2020, 4, 11, 12, 54, 49, 721, DateTimeKind.Local).AddTicks(260), new DateTime(2020, 4, 11, 12, 54, 49, 721, DateTimeKind.Local).AddTicks(2173), "" });

            migrationBuilder.InsertData(
                table: "ItemStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "Name", "RowStatus", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "e1a4ea20-5e3c-4aa2-8043-ef5767b2e8ed", new DateTime(2020, 4, 11, 6, 54, 49, 742, DateTimeKind.Utc).AddTicks(9520), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "GOOD", "ADDED", new DateTime(2020, 4, 11, 6, 54, 49, 743, DateTimeKind.Utc).AddTicks(1166) },
                    { "024d9b39-f494-4f27-a6fb-4aac9bb806bf", new DateTime(2020, 4, 11, 6, 54, 49, 743, DateTimeKind.Utc).AddTicks(1207), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "BAD", "ADDED", new DateTime(2020, 4, 11, 6, 54, 49, 743, DateTimeKind.Utc).AddTicks(1240) }
                });

            migrationBuilder.InsertData(
                table: "PaymentStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "RowStatus", "Status", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "6c3841e1-1cb3-456c-93ed-874f6f0a1e51", new DateTime(2020, 4, 11, 6, 54, 49, 748, DateTimeKind.Utc).AddTicks(2873), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVED", new DateTime(2020, 4, 11, 12, 54, 49, 748, DateTimeKind.Local).AddTicks(3792) },
                    { "78e01d16-1e30-4e6e-88c1-fc0b8c006e2a", new DateTime(2020, 4, 11, 6, 54, 49, 748, DateTimeKind.Utc).AddTicks(3841), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAYABLE", new DateTime(2020, 4, 11, 12, 54, 49, 748, DateTimeKind.Local).AddTicks(3870) },
                    { "083ff81d-4587-4ceb-824e-049be7549911", new DateTime(2020, 4, 11, 6, 54, 49, 748, DateTimeKind.Utc).AddTicks(3874), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVABLE", new DateTime(2020, 4, 11, 12, 54, 49, 748, DateTimeKind.Local).AddTicks(3899) },
                    { "1c8e1ce8-25bc-4fd3-b896-8050d336fac2", new DateTime(2020, 4, 11, 6, 54, 49, 748, DateTimeKind.Utc).AddTicks(3899), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAID", new DateTime(2020, 4, 11, 12, 54, 49, 748, DateTimeKind.Local).AddTicks(3903) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Factory",
                keyColumn: "Id",
                keyValue: "ac329cdc-1e4d-4cf4-820a-580cacaee67d");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "024d9b39-f494-4f27-a6fb-4aac9bb806bf");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "e1a4ea20-5e3c-4aa2-8043-ef5767b2e8ed");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "083ff81d-4587-4ceb-824e-049be7549911");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "1c8e1ce8-25bc-4fd3-b896-8050d336fac2");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "6c3841e1-1cb3-456c-93ed-874f6f0a1e51");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "78e01d16-1e30-4e6e-88c1-fc0b8c006e2a");

            migrationBuilder.InsertData(
                table: "Factory",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "ImageUrl", "LicenseNo", "Name", "RegNo", "RowStatus", "SubscriptionEnd", "SubscriptionStart", "UpdatedDateTime", "VatRegNo" },
                values: new object[] { "7890fe3f-13f7-490e-83f9-5abfff2d29f0", new DateTime(2020, 4, 11, 12, 25, 45, 364, DateTimeKind.Local).AddTicks(9129), "22231d76-b2e6-493a-8814-af0848302772", "", "", "Fazlu Loom Factory", "", "ADDED", new DateTime(2023, 1, 6, 12, 25, 45, 365, DateTimeKind.Local).AddTicks(8338), new DateTime(2020, 4, 11, 12, 25, 45, 365, DateTimeKind.Local).AddTicks(6555), new DateTime(2020, 4, 11, 12, 25, 45, 365, DateTimeKind.Local).AddTicks(9906), "" });

            migrationBuilder.InsertData(
                table: "ItemStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "Name", "RowStatus", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "71375479-28e9-4b81-acf5-e768594a0c12", new DateTime(2020, 4, 11, 6, 25, 45, 401, DateTimeKind.Utc).AddTicks(1697), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "GOOD", "ADDED", new DateTime(2020, 4, 11, 6, 25, 45, 401, DateTimeKind.Utc).AddTicks(3643) },
                    { "06f917dd-06c6-4fc1-8fbe-7049dcbcbcad", new DateTime(2020, 4, 11, 6, 25, 45, 401, DateTimeKind.Utc).AddTicks(3693), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "BAD", "ADDED", new DateTime(2020, 4, 11, 6, 25, 45, 401, DateTimeKind.Utc).AddTicks(3730) }
                });

            migrationBuilder.InsertData(
                table: "PaymentStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "RowStatus", "Status", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "b3724297-a8b7-43da-b7a2-31706f80f023", new DateTime(2020, 4, 11, 6, 25, 45, 410, DateTimeKind.Utc).AddTicks(4846), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVED", new DateTime(2020, 4, 11, 12, 25, 45, 410, DateTimeKind.Local).AddTicks(6271) },
                    { "1ab25ef9-1412-47b4-b91a-2a5af5a224d9", new DateTime(2020, 4, 11, 6, 25, 45, 410, DateTimeKind.Utc).AddTicks(6340), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAYABLE", new DateTime(2020, 4, 11, 12, 25, 45, 410, DateTimeKind.Local).AddTicks(6414) },
                    { "e6a4e07e-fba3-448b-91e2-6546d1d0dc35", new DateTime(2020, 4, 11, 6, 25, 45, 410, DateTimeKind.Utc).AddTicks(6418), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVABLE", new DateTime(2020, 4, 11, 12, 25, 45, 410, DateTimeKind.Local).AddTicks(6435) },
                    { "c1577b67-e33d-4ba7-be0a-1d4e23d5b4be", new DateTime(2020, 4, 11, 6, 25, 45, 410, DateTimeKind.Utc).AddTicks(6435), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAID", new DateTime(2020, 4, 11, 12, 25, 45, 410, DateTimeKind.Local).AddTicks(6463) }
                });
        }
    }
}
