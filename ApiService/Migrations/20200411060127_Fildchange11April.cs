using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiService.Migrations
{
    public partial class Fildchange11April : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
