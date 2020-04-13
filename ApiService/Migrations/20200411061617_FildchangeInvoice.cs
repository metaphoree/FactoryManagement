using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiService.Migrations
{
    public partial class FildchangeInvoice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Factory",
                keyColumn: "Id",
                keyValue: "04371813-10f9-4b33-80e4-b7343683b4e3");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "2df06350-c7a2-4771-994c-2419858228be");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "5c3a0b6d-7ea3-49a7-a4ca-3a39ea57072f");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "84ee140c-5403-4f41-92f6-c911a978927a");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "9f20a108-72ee-4cc6-bd31-3793532b67a7");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "bd055bc8-f8c3-4125-860f-9b422d86ce30");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "cb24f1bb-73db-4f0e-97d4-46c4c891edf6");

            migrationBuilder.AlterColumn<long>(
                name: "AmountPaid",
                table: "Invoice",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "AmountBeforeDiscount",
                table: "Invoice",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<long>(
                name: "AmountAfterDiscount",
                table: "Invoice",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "AmountPaid",
                table: "Invoice",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<string>(
                name: "AmountBeforeDiscount",
                table: "Invoice",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<string>(
                name: "AmountAfterDiscount",
                table: "Invoice",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.InsertData(
                table: "Factory",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "ImageUrl", "LicenseNo", "Name", "RegNo", "RowStatus", "SubscriptionEnd", "SubscriptionStart", "UpdatedDateTime", "VatRegNo" },
                values: new object[] { "04371813-10f9-4b33-80e4-b7343683b4e3", new DateTime(2020, 4, 11, 12, 1, 26, 720, DateTimeKind.Local).AddTicks(1459), "7030acf7-e970-482a-93d1-e7077a4a93d5", "", "", "Fazlu Loom Factory", "", "ADDED", new DateTime(2023, 1, 6, 12, 1, 26, 720, DateTimeKind.Local).AddTicks(6746), new DateTime(2020, 4, 11, 12, 1, 26, 720, DateTimeKind.Local).AddTicks(5585), new DateTime(2020, 4, 11, 12, 1, 26, 720, DateTimeKind.Local).AddTicks(7645), "" });

            migrationBuilder.InsertData(
                table: "ItemStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "Name", "RowStatus", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "5c3a0b6d-7ea3-49a7-a4ca-3a39ea57072f", new DateTime(2020, 4, 11, 6, 1, 26, 740, DateTimeKind.Utc).AddTicks(7643), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "GOOD", "ADDED", new DateTime(2020, 4, 11, 6, 1, 26, 740, DateTimeKind.Utc).AddTicks(9835) },
                    { "2df06350-c7a2-4771-994c-2419858228be", new DateTime(2020, 4, 11, 6, 1, 26, 740, DateTimeKind.Utc).AddTicks(9884), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "BAD", "ADDED", new DateTime(2020, 4, 11, 6, 1, 26, 740, DateTimeKind.Utc).AddTicks(9925) }
                });

            migrationBuilder.InsertData(
                table: "PaymentStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "RowStatus", "Status", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "84ee140c-5403-4f41-92f6-c911a978927a", new DateTime(2020, 4, 11, 6, 1, 26, 746, DateTimeKind.Utc).AddTicks(7408), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVED", new DateTime(2020, 4, 11, 12, 1, 26, 746, DateTimeKind.Local).AddTicks(8356) },
                    { "bd055bc8-f8c3-4125-860f-9b422d86ce30", new DateTime(2020, 4, 11, 6, 1, 26, 746, DateTimeKind.Utc).AddTicks(8402), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAYABLE", new DateTime(2020, 4, 11, 12, 1, 26, 746, DateTimeKind.Local).AddTicks(8455) },
                    { "9f20a108-72ee-4cc6-bd31-3793532b67a7", new DateTime(2020, 4, 11, 6, 1, 26, 746, DateTimeKind.Utc).AddTicks(8455), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVABLE", new DateTime(2020, 4, 11, 12, 1, 26, 746, DateTimeKind.Local).AddTicks(8463) },
                    { "cb24f1bb-73db-4f0e-97d4-46c4c891edf6", new DateTime(2020, 4, 11, 6, 1, 26, 746, DateTimeKind.Utc).AddTicks(8463), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAID", new DateTime(2020, 4, 11, 12, 1, 26, 746, DateTimeKind.Local).AddTicks(8467) }
                });
        }
    }
}
