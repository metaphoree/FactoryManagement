using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiService.Migrations
{
    public partial class EquipmentToEquipmentCategoryRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Factory",
                keyColumn: "Id",
                keyValue: "3372fd09-aae9-44ae-a36c-fed0e2ba4af3");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "6659660d-3f39-460a-b885-1f29ca8f23e5");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "75bb1edb-9225-4d51-b267-875317dc4968");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "2209c74e-3abc-413b-b690-3997fcf2fbc2");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "7f3deb17-28f4-4225-84e1-edcda392eb54");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "87822fe1-078a-4066-b247-6772bfef3173");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "ce7ed5bd-2d05-4c01-ac9a-9ebe08973dc9");

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

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_EquipmentCategoryId",
                table: "Equipment",
                column: "EquipmentCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipment_EquipmentCategory_EquipmentCategoryId",
                table: "Equipment",
                column: "EquipmentCategoryId",
                principalTable: "EquipmentCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipment_EquipmentCategory_EquipmentCategoryId",
                table: "Equipment");

            migrationBuilder.DropIndex(
                name: "IX_Equipment_EquipmentCategoryId",
                table: "Equipment");

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

            migrationBuilder.InsertData(
                table: "Factory",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "ImageUrl", "LicenseNo", "Name", "RegNo", "RowStatus", "SubscriptionEnd", "SubscriptionStart", "UpdatedDateTime", "VatRegNo" },
                values: new object[] { "3372fd09-aae9-44ae-a36c-fed0e2ba4af3", new DateTime(2020, 3, 19, 12, 44, 54, 318, DateTimeKind.Local).AddTicks(3366), "ef98b21b-3b6e-4a18-b29c-d66fc0d6865f", "", "", "Fazlu Loom Factory", "", "ADDED", new DateTime(2022, 12, 14, 12, 44, 54, 318, DateTimeKind.Local).AddTicks(8735), new DateTime(2020, 3, 19, 12, 44, 54, 318, DateTimeKind.Local).AddTicks(7845), new DateTime(2020, 3, 19, 12, 44, 54, 318, DateTimeKind.Local).AddTicks(9585), "" });

            migrationBuilder.InsertData(
                table: "ItemStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "Name", "RowStatus", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "6659660d-3f39-460a-b885-1f29ca8f23e5", new DateTime(2020, 3, 19, 6, 44, 54, 340, DateTimeKind.Utc).AddTicks(2157), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "GOOD", "ADDED", new DateTime(2020, 3, 19, 6, 44, 54, 340, DateTimeKind.Utc).AddTicks(3804) },
                    { "75bb1edb-9225-4d51-b267-875317dc4968", new DateTime(2020, 3, 19, 6, 44, 54, 340, DateTimeKind.Utc).AddTicks(3837), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "BAD", "ADDED", new DateTime(2020, 3, 19, 6, 44, 54, 340, DateTimeKind.Utc).AddTicks(3869) }
                });

            migrationBuilder.InsertData(
                table: "PaymentStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "RowStatus", "Status", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "87822fe1-078a-4066-b247-6772bfef3173", new DateTime(2020, 3, 19, 6, 44, 54, 345, DateTimeKind.Utc).AddTicks(132), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVED", new DateTime(2020, 3, 19, 12, 44, 54, 345, DateTimeKind.Local).AddTicks(1126) },
                    { "2209c74e-3abc-413b-b690-3997fcf2fbc2", new DateTime(2020, 3, 19, 6, 44, 54, 345, DateTimeKind.Utc).AddTicks(1167), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAYABLE", new DateTime(2020, 3, 19, 12, 44, 54, 345, DateTimeKind.Local).AddTicks(1232) },
                    { "7f3deb17-28f4-4225-84e1-edcda392eb54", new DateTime(2020, 3, 19, 6, 44, 54, 345, DateTimeKind.Utc).AddTicks(1237), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVABLE", new DateTime(2020, 3, 19, 12, 44, 54, 345, DateTimeKind.Local).AddTicks(1245) },
                    { "ce7ed5bd-2d05-4c01-ac9a-9ebe08973dc9", new DateTime(2020, 3, 19, 6, 44, 54, 345, DateTimeKind.Utc).AddTicks(1245), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAID", new DateTime(2020, 3, 19, 12, 44, 54, 345, DateTimeKind.Local).AddTicks(1253) }
                });
        }
    }
}
