using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiService.Migrations
{
    public partial class ColumnChangeEquipment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Factory",
                keyColumn: "Id",
                keyValue: "76cf1f32-7c51-4b07-8916-b10c2814dd31");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "d0b28800-8e2d-4c6f-8c55-67854217cbf5");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "ec9f0924-e0f9-443f-a816-4c0bdefedb13");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "0104fcf0-eca2-4e56-97cb-682f7da37aca");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "02c3e5b7-cf78-4876-8d02-fc0d42e3fde0");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "3ddff730-bc9d-4088-ba8b-d01c0aea0b1b");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "df514bf0-abc9-4d0b-9ffa-ec6c455598f2");

            migrationBuilder.DropColumn(
                name: "Number",
                table: "Equipment");

            migrationBuilder.AddColumn<int>(
                name: "MachineNumber",
                table: "Equipment",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Factory",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "ImageUrl", "LicenseNo", "Name", "RegNo", "RowStatus", "SubscriptionEnd", "SubscriptionStart", "UpdatedDateTime", "VatRegNo" },
                values: new object[] { "8f1713d4-e26c-488d-b32c-4c36dcfb4b9e", new DateTime(2020, 3, 19, 23, 39, 57, 211, DateTimeKind.Local).AddTicks(6023), "cd72cb44-a064-4a6f-ab83-a4ceb52e283b", "", "", "Fazlu Loom Factory", "", "ADDED", new DateTime(2022, 12, 14, 23, 39, 57, 212, DateTimeKind.Local).AddTicks(1425), new DateTime(2020, 3, 19, 23, 39, 57, 212, DateTimeKind.Local).AddTicks(427), new DateTime(2020, 3, 19, 23, 39, 57, 212, DateTimeKind.Local).AddTicks(2332), "" });

            migrationBuilder.InsertData(
                table: "ItemStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "Name", "RowStatus", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "99488d9b-9175-4037-989e-20a55f2106e9", new DateTime(2020, 3, 19, 17, 39, 57, 237, DateTimeKind.Utc).AddTicks(7776), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "GOOD", "ADDED", new DateTime(2020, 3, 19, 17, 39, 57, 237, DateTimeKind.Utc).AddTicks(9727) },
                    { "c555e61c-ba95-4888-aac7-b594364472e0", new DateTime(2020, 3, 19, 17, 39, 57, 237, DateTimeKind.Utc).AddTicks(9768), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "BAD", "ADDED", new DateTime(2020, 3, 19, 17, 39, 57, 237, DateTimeKind.Utc).AddTicks(9796) }
                });

            migrationBuilder.InsertData(
                table: "PaymentStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "RowStatus", "Status", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "4e6b21fd-8b82-41ef-b665-506c7a7b0d5a", new DateTime(2020, 3, 19, 17, 39, 57, 243, DateTimeKind.Utc).AddTicks(6310), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVED", new DateTime(2020, 3, 19, 23, 39, 57, 243, DateTimeKind.Local).AddTicks(7455) },
                    { "53da6d00-9033-443b-a87d-dd605c9c7861", new DateTime(2020, 3, 19, 17, 39, 57, 243, DateTimeKind.Utc).AddTicks(7504), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAYABLE", new DateTime(2020, 3, 19, 23, 39, 57, 243, DateTimeKind.Local).AddTicks(7558) },
                    { "a7eab0d3-d05f-4a54-a493-f6b97c71960d", new DateTime(2020, 3, 19, 17, 39, 57, 243, DateTimeKind.Utc).AddTicks(7558), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVABLE", new DateTime(2020, 3, 19, 23, 39, 57, 243, DateTimeKind.Local).AddTicks(7570) },
                    { "40aaa664-9eca-41e1-a59b-cfcdd8d8dcd7", new DateTime(2020, 3, 19, 17, 39, 57, 243, DateTimeKind.Utc).AddTicks(7570), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAID", new DateTime(2020, 3, 19, 23, 39, 57, 243, DateTimeKind.Local).AddTicks(7578) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Factory",
                keyColumn: "Id",
                keyValue: "8f1713d4-e26c-488d-b32c-4c36dcfb4b9e");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "99488d9b-9175-4037-989e-20a55f2106e9");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "c555e61c-ba95-4888-aac7-b594364472e0");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "40aaa664-9eca-41e1-a59b-cfcdd8d8dcd7");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "4e6b21fd-8b82-41ef-b665-506c7a7b0d5a");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "53da6d00-9033-443b-a87d-dd605c9c7861");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "a7eab0d3-d05f-4a54-a493-f6b97c71960d");

            migrationBuilder.DropColumn(
                name: "MachineNumber",
                table: "Equipment");

            migrationBuilder.AddColumn<int>(
                name: "Number",
                table: "Equipment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Factory",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "ImageUrl", "LicenseNo", "Name", "RegNo", "RowStatus", "SubscriptionEnd", "SubscriptionStart", "UpdatedDateTime", "VatRegNo" },
                values: new object[] { "76cf1f32-7c51-4b07-8916-b10c2814dd31", new DateTime(2020, 3, 19, 17, 3, 47, 739, DateTimeKind.Local).AddTicks(5311), "9b6234c3-46da-4574-85a7-8ce144cb1cb6", "", "", "Fazlu Loom Factory", "", "ADDED", new DateTime(2022, 12, 14, 17, 3, 47, 740, DateTimeKind.Local).AddTicks(2118), new DateTime(2020, 3, 19, 17, 3, 47, 740, DateTimeKind.Local).AddTicks(1194), new DateTime(2020, 3, 19, 17, 3, 47, 740, DateTimeKind.Local).AddTicks(2980), "" });

            migrationBuilder.InsertData(
                table: "ItemStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "Name", "RowStatus", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "d0b28800-8e2d-4c6f-8c55-67854217cbf5", new DateTime(2020, 3, 19, 11, 3, 47, 761, DateTimeKind.Utc).AddTicks(6082), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "GOOD", "ADDED", new DateTime(2020, 3, 19, 11, 3, 47, 761, DateTimeKind.Utc).AddTicks(7696) },
                    { "ec9f0924-e0f9-443f-a816-4c0bdefedb13", new DateTime(2020, 3, 19, 11, 3, 47, 761, DateTimeKind.Utc).AddTicks(7757), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "BAD", "ADDED", new DateTime(2020, 3, 19, 11, 3, 47, 761, DateTimeKind.Utc).AddTicks(7790) }
                });

            migrationBuilder.InsertData(
                table: "PaymentStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "RowStatus", "Status", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "df514bf0-abc9-4d0b-9ffa-ec6c455598f2", new DateTime(2020, 3, 19, 11, 3, 47, 766, DateTimeKind.Utc).AddTicks(1437), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVED", new DateTime(2020, 3, 19, 17, 3, 47, 766, DateTimeKind.Local).AddTicks(2246) },
                    { "3ddff730-bc9d-4088-ba8b-d01c0aea0b1b", new DateTime(2020, 3, 19, 11, 3, 47, 766, DateTimeKind.Utc).AddTicks(2283), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAYABLE", new DateTime(2020, 3, 19, 17, 3, 47, 766, DateTimeKind.Local).AddTicks(2312) },
                    { "02c3e5b7-cf78-4876-8d02-fc0d42e3fde0", new DateTime(2020, 3, 19, 11, 3, 47, 766, DateTimeKind.Utc).AddTicks(2316), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVABLE", new DateTime(2020, 3, 19, 17, 3, 47, 766, DateTimeKind.Local).AddTicks(2320) },
                    { "0104fcf0-eca2-4e56-97cb-682f7da37aca", new DateTime(2020, 3, 19, 11, 3, 47, 766, DateTimeKind.Utc).AddTicks(2320), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAID", new DateTime(2020, 3, 19, 17, 3, 47, 766, DateTimeKind.Local).AddTicks(2341) }
                });
        }
    }
}
