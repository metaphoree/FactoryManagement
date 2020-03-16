using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiService.Migrations
{
    public partial class RELATION_STOCK_TO_ITEM_STATUS_AND_ITEM : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "29f8d57f-743b-45a3-b3a4-197bc9099026", new DateTime(2020, 3, 13, 20, 23, 53, 885, DateTimeKind.Local).AddTicks(4822), "11cfdf58-b660-4ff5-b3e3-2cbd6e2f1557", "", "", "Fazlu Loom Factory", "", "ADDED", new DateTime(2022, 12, 8, 20, 23, 53, 886, DateTimeKind.Local).AddTicks(4186), new DateTime(2020, 3, 13, 20, 23, 53, 886, DateTimeKind.Local).AddTicks(2450), new DateTime(2020, 3, 13, 20, 23, 53, 886, DateTimeKind.Local).AddTicks(5832), "" });

            migrationBuilder.InsertData(
                table: "ItemStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "Name", "RowStatus", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "aa0362cd-6aa2-4321-8b6d-a5288b06f7df", new DateTime(2020, 3, 13, 14, 23, 53, 921, DateTimeKind.Utc).AddTicks(8676), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "GOOD", "ADDED", new DateTime(2020, 3, 13, 14, 23, 53, 922, DateTimeKind.Utc).AddTicks(1274) },
                    { "1b5cd05d-654e-4db9-994b-df51befe163f", new DateTime(2020, 3, 13, 14, 23, 53, 922, DateTimeKind.Utc).AddTicks(1332), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "BAD", "ADDED", new DateTime(2020, 3, 13, 14, 23, 53, 922, DateTimeKind.Utc).AddTicks(1385) }
                });

            migrationBuilder.InsertData(
                table: "PaymentStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "RowStatus", "Status", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "50b34297-6166-48ef-a33e-c2bb1fd24abd", new DateTime(2020, 3, 13, 14, 23, 53, 930, DateTimeKind.Utc).AddTicks(7091), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVED", new DateTime(2020, 3, 13, 20, 23, 53, 930, DateTimeKind.Local).AddTicks(8384) },
                    { "1e4f30f3-18af-4918-9c2a-577455190343", new DateTime(2020, 3, 13, 14, 23, 53, 930, DateTimeKind.Utc).AddTicks(8446), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAYABLE", new DateTime(2020, 3, 13, 20, 23, 53, 930, DateTimeKind.Local).AddTicks(8507) },
                    { "c5435783-833d-410d-a86d-aa3872d08f9c", new DateTime(2020, 3, 13, 14, 23, 53, 930, DateTimeKind.Utc).AddTicks(8512), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVABLE", new DateTime(2020, 3, 13, 20, 23, 53, 930, DateTimeKind.Local).AddTicks(8524) },
                    { "c277c643-4fcb-4c04-8b8c-419feddf6024", new DateTime(2020, 3, 13, 14, 23, 53, 930, DateTimeKind.Utc).AddTicks(8524), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAID", new DateTime(2020, 3, 13, 20, 23, 53, 930, DateTimeKind.Local).AddTicks(8532) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stock_ItemId",
                table: "Stock",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Stock_ItemStatusId",
                table: "Stock",
                column: "ItemStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Stock_Item_ItemId",
                table: "Stock",
                column: "ItemId",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stock_ItemStatus_ItemStatusId",
                table: "Stock",
                column: "ItemStatusId",
                principalTable: "ItemStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stock_Item_ItemId",
                table: "Stock");

            migrationBuilder.DropForeignKey(
                name: "FK_Stock_ItemStatus_ItemStatusId",
                table: "Stock");

            migrationBuilder.DropIndex(
                name: "IX_Stock_ItemId",
                table: "Stock");

            migrationBuilder.DropIndex(
                name: "IX_Stock_ItemStatusId",
                table: "Stock");

            migrationBuilder.DeleteData(
                table: "Factory",
                keyColumn: "Id",
                keyValue: "29f8d57f-743b-45a3-b3a4-197bc9099026");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "1b5cd05d-654e-4db9-994b-df51befe163f");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "aa0362cd-6aa2-4321-8b6d-a5288b06f7df");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "1e4f30f3-18af-4918-9c2a-577455190343");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "50b34297-6166-48ef-a33e-c2bb1fd24abd");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "c277c643-4fcb-4c04-8b8c-419feddf6024");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "c5435783-833d-410d-a86d-aa3872d08f9c");

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
    }
}
