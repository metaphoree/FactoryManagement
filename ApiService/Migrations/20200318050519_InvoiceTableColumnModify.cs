using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiService.Migrations
{
    public partial class InvoiceTableColumnModify : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Factory",
                keyColumn: "Id",
                keyValue: "31291fc6-5fb2-4fe6-a40e-a815bb8f45ff");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "bb7e0974-a013-4031-bf09-951d92c65f63");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "c75530f5-5f72-45b8-a961-2fdaecabe559");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "054bce7c-1243-4d3b-bd62-90d2df0e041c");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "8aae8245-7ebc-4735-b3c5-e853a1b65315");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "c45ffa58-55e0-4998-9542-2f03958f32f8");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "d368dd69-8f01-4f06-97da-bbba2fd694d6");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeId",
                table: "Invoice",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Factory",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "ImageUrl", "LicenseNo", "Name", "RegNo", "RowStatus", "SubscriptionEnd", "SubscriptionStart", "UpdatedDateTime", "VatRegNo" },
                values: new object[] { "b47a4f80-dfd4-4b5b-804e-02bb49ae0171", new DateTime(2020, 3, 18, 11, 5, 18, 128, DateTimeKind.Local).AddTicks(2492), "e10342cb-dfce-47b2-a22e-e5942470eec8", "", "", "Fazlu Loom Factory", "", "ADDED", new DateTime(2022, 12, 13, 11, 5, 18, 128, DateTimeKind.Local).AddTicks(8531), new DateTime(2020, 3, 18, 11, 5, 18, 128, DateTimeKind.Local).AddTicks(7439), new DateTime(2020, 3, 18, 11, 5, 18, 128, DateTimeKind.Local).AddTicks(9516), "" });

            migrationBuilder.InsertData(
                table: "ItemStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "Name", "RowStatus", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "33339b75-15e8-42b0-a7d1-11e7738064fb", new DateTime(2020, 3, 18, 5, 5, 18, 159, DateTimeKind.Utc).AddTicks(61), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "GOOD", "ADDED", new DateTime(2020, 3, 18, 5, 5, 18, 159, DateTimeKind.Utc).AddTicks(2651) },
                    { "d886041d-566d-4f57-9b94-0a327dea906b", new DateTime(2020, 3, 18, 5, 5, 18, 159, DateTimeKind.Utc).AddTicks(2708), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "BAD", "ADDED", new DateTime(2020, 3, 18, 5, 5, 18, 159, DateTimeKind.Utc).AddTicks(2753) }
                });

            migrationBuilder.InsertData(
                table: "PaymentStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "RowStatus", "Status", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "b94eb2e0-6f09-434e-8f10-0b95472eed46", new DateTime(2020, 3, 18, 5, 5, 18, 167, DateTimeKind.Utc).AddTicks(8772), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVED", new DateTime(2020, 3, 18, 11, 5, 18, 168, DateTimeKind.Local).AddTicks(176) },
                    { "979ef0c2-75d2-4eda-b66c-920583710772", new DateTime(2020, 3, 18, 5, 5, 18, 168, DateTimeKind.Utc).AddTicks(234), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAYABLE", new DateTime(2020, 3, 18, 11, 5, 18, 168, DateTimeKind.Local).AddTicks(283) },
                    { "daf9274a-1d38-47d3-9153-b1e45aac6dee", new DateTime(2020, 3, 18, 5, 5, 18, 168, DateTimeKind.Utc).AddTicks(287), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVABLE", new DateTime(2020, 3, 18, 11, 5, 18, 168, DateTimeKind.Local).AddTicks(299) },
                    { "797ae7ea-6588-46a3-835f-9167796ab2c5", new DateTime(2020, 3, 18, 5, 5, 18, 168, DateTimeKind.Utc).AddTicks(299), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAID", new DateTime(2020, 3, 18, 11, 5, 18, 168, DateTimeKind.Local).AddTicks(308) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Factory",
                keyColumn: "Id",
                keyValue: "b47a4f80-dfd4-4b5b-804e-02bb49ae0171");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "33339b75-15e8-42b0-a7d1-11e7738064fb");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "d886041d-566d-4f57-9b94-0a327dea906b");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "797ae7ea-6588-46a3-835f-9167796ab2c5");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "979ef0c2-75d2-4eda-b66c-920583710772");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "b94eb2e0-6f09-434e-8f10-0b95472eed46");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "daf9274a-1d38-47d3-9153-b1e45aac6dee");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Invoice");

            migrationBuilder.InsertData(
                table: "Factory",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "ImageUrl", "LicenseNo", "Name", "RegNo", "RowStatus", "SubscriptionEnd", "SubscriptionStart", "UpdatedDateTime", "VatRegNo" },
                values: new object[] { "31291fc6-5fb2-4fe6-a40e-a815bb8f45ff", new DateTime(2020, 3, 18, 11, 2, 5, 465, DateTimeKind.Local).AddTicks(5421), "5172f57e-8857-4ab8-8f92-f22075de4a97", "", "", "Fazlu Loom Factory", "", "ADDED", new DateTime(2022, 12, 13, 11, 2, 5, 466, DateTimeKind.Local).AddTicks(1533), new DateTime(2020, 3, 18, 11, 2, 5, 466, DateTimeKind.Local).AddTicks(421), new DateTime(2020, 3, 18, 11, 2, 5, 466, DateTimeKind.Local).AddTicks(2523), "" });

            migrationBuilder.InsertData(
                table: "ItemStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "Name", "RowStatus", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "c75530f5-5f72-45b8-a961-2fdaecabe559", new DateTime(2020, 3, 18, 5, 2, 5, 485, DateTimeKind.Utc).AddTicks(2479), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "GOOD", "ADDED", new DateTime(2020, 3, 18, 5, 2, 5, 485, DateTimeKind.Utc).AddTicks(4528) },
                    { "bb7e0974-a013-4031-bf09-951d92c65f63", new DateTime(2020, 3, 18, 5, 2, 5, 485, DateTimeKind.Utc).AddTicks(4569), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "BAD", "ADDED", new DateTime(2020, 3, 18, 5, 2, 5, 485, DateTimeKind.Utc).AddTicks(4598) }
                });

            migrationBuilder.InsertData(
                table: "PaymentStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "RowStatus", "Status", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "d368dd69-8f01-4f06-97da-bbba2fd694d6", new DateTime(2020, 3, 18, 5, 2, 5, 490, DateTimeKind.Utc).AddTicks(5298), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVED", new DateTime(2020, 3, 18, 11, 2, 5, 490, DateTimeKind.Local).AddTicks(6308) },
                    { "054bce7c-1243-4d3b-bd62-90d2df0e041c", new DateTime(2020, 3, 18, 5, 2, 5, 490, DateTimeKind.Utc).AddTicks(6353), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAYABLE", new DateTime(2020, 3, 18, 11, 2, 5, 490, DateTimeKind.Local).AddTicks(6394) },
                    { "c45ffa58-55e0-4998-9542-2f03958f32f8", new DateTime(2020, 3, 18, 5, 2, 5, 490, DateTimeKind.Utc).AddTicks(6394), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVABLE", new DateTime(2020, 3, 18, 11, 2, 5, 490, DateTimeKind.Local).AddTicks(6403) },
                    { "8aae8245-7ebc-4735-b3c5-e853a1b65315", new DateTime(2020, 3, 18, 5, 2, 5, 490, DateTimeKind.Utc).AddTicks(6403), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAID", new DateTime(2020, 3, 18, 11, 2, 5, 490, DateTimeKind.Local).AddTicks(6407) }
                });
        }
    }
}
