using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiService.Migrations
{
    public partial class FildchangeInvoice_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Factory",
                keyColumn: "Id",
                keyValue: "dd2ed2e4-aad7-40f2-bf91-e9342c5b1f3f");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "af38e367-e42a-4e1c-b213-03e629098c8b");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "f2e5181b-92bc-4178-a262-96642957e865");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "1789b5bf-b8c9-48eb-bfbb-9be9f3e80fe2");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "1da25797-432a-4d8a-8e4f-43ab2bb2e03b");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "96231f97-5794-4af8-b24d-67ff5c111b05");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "e85d5efb-89ce-474f-8841-e73fa2db72fe");

            migrationBuilder.DropColumn(
                name: "AmountAfterDiscount",
                table: "Invoice");

            migrationBuilder.DropColumn(
                name: "AmountBeforeDiscount",
                table: "Invoice");

            migrationBuilder.DropColumn(
                name: "AmountPaid",
                table: "Invoice");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<long>(
                name: "AmountAfterDiscount",
                table: "Invoice",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "AmountBeforeDiscount",
                table: "Invoice",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "AmountPaid",
                table: "Invoice",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.InsertData(
                table: "Factory",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "ImageUrl", "LicenseNo", "Name", "RegNo", "RowStatus", "SubscriptionEnd", "SubscriptionStart", "UpdatedDateTime", "VatRegNo" },
                values: new object[] { "dd2ed2e4-aad7-40f2-bf91-e9342c5b1f3f", new DateTime(2020, 4, 11, 12, 16, 16, 22, DateTimeKind.Local).AddTicks(8801), "6c370807-1d9e-4441-9d64-05ae64e8d910", "", "", "Fazlu Loom Factory", "", "ADDED", new DateTime(2023, 1, 6, 12, 16, 16, 23, DateTimeKind.Local).AddTicks(4500), new DateTime(2020, 4, 11, 12, 16, 16, 23, DateTimeKind.Local).AddTicks(3502), new DateTime(2020, 4, 11, 12, 16, 16, 23, DateTimeKind.Local).AddTicks(5403), "" });

            migrationBuilder.InsertData(
                table: "ItemStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "Name", "RowStatus", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "f2e5181b-92bc-4178-a262-96642957e865", new DateTime(2020, 4, 11, 6, 16, 16, 54, DateTimeKind.Utc).AddTicks(3666), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "GOOD", "ADDED", new DateTime(2020, 4, 11, 6, 16, 16, 54, DateTimeKind.Utc).AddTicks(5993) },
                    { "af38e367-e42a-4e1c-b213-03e629098c8b", new DateTime(2020, 4, 11, 6, 16, 16, 54, DateTimeKind.Utc).AddTicks(6043), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "BAD", "ADDED", new DateTime(2020, 4, 11, 6, 16, 16, 54, DateTimeKind.Utc).AddTicks(6088) }
                });

            migrationBuilder.InsertData(
                table: "PaymentStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "RowStatus", "Status", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "96231f97-5794-4af8-b24d-67ff5c111b05", new DateTime(2020, 4, 11, 6, 16, 16, 61, DateTimeKind.Utc).AddTicks(3851), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVED", new DateTime(2020, 4, 11, 12, 16, 16, 61, DateTimeKind.Local).AddTicks(4770) },
                    { "e85d5efb-89ce-474f-8841-e73fa2db72fe", new DateTime(2020, 4, 11, 6, 16, 16, 61, DateTimeKind.Utc).AddTicks(4815), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAYABLE", new DateTime(2020, 4, 11, 12, 16, 16, 61, DateTimeKind.Local).AddTicks(4848) },
                    { "1da25797-432a-4d8a-8e4f-43ab2bb2e03b", new DateTime(2020, 4, 11, 6, 16, 16, 61, DateTimeKind.Utc).AddTicks(4852), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVABLE", new DateTime(2020, 4, 11, 12, 16, 16, 61, DateTimeKind.Local).AddTicks(4860) },
                    { "1789b5bf-b8c9-48eb-bfbb-9be9f3e80fe2", new DateTime(2020, 4, 11, 6, 16, 16, 61, DateTimeKind.Utc).AddTicks(4860), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAID", new DateTime(2020, 4, 11, 12, 16, 16, 61, DateTimeKind.Local).AddTicks(4881) }
                });
        }
    }
}
