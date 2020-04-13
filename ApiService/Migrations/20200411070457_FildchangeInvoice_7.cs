using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiService.Migrations
{
    public partial class FildchangeInvoice_7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_Item_ItemId",
                table: "Purchase");

            migrationBuilder.DropIndex(
                name: "IX_Purchase_ItemId",
                table: "Purchase");

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
                values: new object[] { "85344622-7e53-4d48-bc6b-fd6e4e04a34f", new DateTime(2020, 4, 11, 13, 4, 55, 914, DateTimeKind.Local).AddTicks(865), "ac3ee4b2-e3df-4a14-80ee-b3966d0bed3d", "", "", "Fazlu Loom Factory", "", "ADDED", new DateTime(2023, 1, 6, 13, 4, 55, 914, DateTimeKind.Local).AddTicks(8250), new DateTime(2020, 4, 11, 13, 4, 55, 914, DateTimeKind.Local).AddTicks(6669), new DateTime(2020, 4, 11, 13, 4, 55, 914, DateTimeKind.Local).AddTicks(9551), "" });

            migrationBuilder.InsertData(
                table: "ItemStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "Name", "RowStatus", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "36323012-8010-4eac-9796-34a2d85b13ec", new DateTime(2020, 4, 11, 7, 4, 55, 940, DateTimeKind.Utc).AddTicks(3000), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "GOOD", "ADDED", new DateTime(2020, 4, 11, 7, 4, 55, 940, DateTimeKind.Utc).AddTicks(4696) },
                    { "8485d71e-6b29-44d3-92a0-eec5bdb9c958", new DateTime(2020, 4, 11, 7, 4, 55, 940, DateTimeKind.Utc).AddTicks(4737), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "BAD", "ADDED", new DateTime(2020, 4, 11, 7, 4, 55, 940, DateTimeKind.Utc).AddTicks(4765) }
                });

            migrationBuilder.InsertData(
                table: "PaymentStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "RowStatus", "Status", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "e7155feb-4e3b-4f16-bdf0-44b86524d85e", new DateTime(2020, 4, 11, 7, 4, 55, 946, DateTimeKind.Utc).AddTicks(9555), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVED", new DateTime(2020, 4, 11, 13, 4, 55, 947, DateTimeKind.Local).AddTicks(901) },
                    { "c65036c0-6411-4dc7-b3bc-902823b2ae1a", new DateTime(2020, 4, 11, 7, 4, 55, 947, DateTimeKind.Utc).AddTicks(967), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAYABLE", new DateTime(2020, 4, 11, 13, 4, 55, 947, DateTimeKind.Local).AddTicks(1021) },
                    { "2e5d6777-3879-47e5-b1fa-579a6bd2b5b6", new DateTime(2020, 4, 11, 7, 4, 55, 947, DateTimeKind.Utc).AddTicks(1021), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVABLE", new DateTime(2020, 4, 11, 13, 4, 55, 947, DateTimeKind.Local).AddTicks(1123) },
                    { "67345721-7e6e-4393-8eec-fce69c7de747", new DateTime(2020, 4, 11, 7, 4, 55, 947, DateTimeKind.Utc).AddTicks(1123), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAID", new DateTime(2020, 4, 11, 13, 4, 55, 947, DateTimeKind.Local).AddTicks(1131) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Factory",
                keyColumn: "Id",
                keyValue: "85344622-7e53-4d48-bc6b-fd6e4e04a34f");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "36323012-8010-4eac-9796-34a2d85b13ec");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "8485d71e-6b29-44d3-92a0-eec5bdb9c958");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "2e5d6777-3879-47e5-b1fa-579a6bd2b5b6");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "67345721-7e6e-4393-8eec-fce69c7de747");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "c65036c0-6411-4dc7-b3bc-902823b2ae1a");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "e7155feb-4e3b-4f16-bdf0-44b86524d85e");

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

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_ItemId",
                table: "Purchase",
                column: "ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_Item_ItemId",
                table: "Purchase",
                column: "ItemId",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
