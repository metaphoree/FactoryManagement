using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiService.Migrations
{
    public partial class RemoveItemCategoryRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_ItemCategory_ItemCategoryId",
                table: "Purchase");

            migrationBuilder.DropForeignKey(
                name: "FK_Sales_ItemCategory_ItemCategoryId",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Sales_ItemCategoryId",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Purchase_ItemCategoryId",
                table: "Purchase");

            migrationBuilder.DeleteData(
                table: "Factory",
                keyColumn: "Id",
                keyValue: "46f3b013-9a66-4abb-bac2-ab83f7e85e8a");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "84dcf0e2-780a-4807-94ef-65cf0247e023");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "a31d75d5-b03c-4116-9315-33d6650d9b3b");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "0c9f0bec-83ef-4886-a4c4-04f326bb9a6e");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "8a35dd78-54dc-4a2b-ad10-6a92afba3619");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "b35a03fb-4e3d-489d-b5c5-91cdd21a6524");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "f23016c1-b7b0-4ac8-aef1-abf0f561e80f");

            migrationBuilder.InsertData(
                table: "Factory",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "ImageUrl", "LicenseNo", "Name", "RegNo", "RowStatus", "SubscriptionEnd", "SubscriptionStart", "UpdatedDateTime", "VatRegNo" },
                values: new object[] { "74e71871-3c85-4daf-9dd5-9279d8eb2cd9", new DateTime(2020, 4, 9, 11, 21, 15, 614, DateTimeKind.Local).AddTicks(6), "0537f6b3-7d14-4761-b24a-8b11cded3ac4", "", "", "Fazlu Loom Factory", "", "ADDED", new DateTime(2023, 1, 4, 11, 21, 15, 614, DateTimeKind.Local).AddTicks(5999), new DateTime(2020, 4, 9, 11, 21, 15, 614, DateTimeKind.Local).AddTicks(4977), new DateTime(2020, 4, 9, 11, 21, 15, 614, DateTimeKind.Local).AddTicks(7231), "" });

            migrationBuilder.InsertData(
                table: "ItemStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "Name", "RowStatus", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "78a25ef7-77b1-45bf-8d29-b37a0be28a8b", new DateTime(2020, 4, 9, 5, 21, 15, 640, DateTimeKind.Utc).AddTicks(626), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "GOOD", "ADDED", new DateTime(2020, 4, 9, 5, 21, 15, 640, DateTimeKind.Utc).AddTicks(2318) },
                    { "b48cba78-77ca-48c6-90ed-e0004266359a", new DateTime(2020, 4, 9, 5, 21, 15, 640, DateTimeKind.Utc).AddTicks(2363), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "BAD", "ADDED", new DateTime(2020, 4, 9, 5, 21, 15, 640, DateTimeKind.Utc).AddTicks(2392) }
                });

            migrationBuilder.InsertData(
                table: "PaymentStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "RowStatus", "Status", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "73fedfce-3684-4d78-ab6f-2d4450ce66a3", new DateTime(2020, 4, 9, 5, 21, 15, 645, DateTimeKind.Utc).AddTicks(7891), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVED", new DateTime(2020, 4, 9, 11, 21, 15, 645, DateTimeKind.Local).AddTicks(9056) },
                    { "013f93a0-32c9-463f-9849-7f519cfffcdd", new DateTime(2020, 4, 9, 5, 21, 15, 645, DateTimeKind.Utc).AddTicks(9106), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAYABLE", new DateTime(2020, 4, 9, 11, 21, 15, 645, DateTimeKind.Local).AddTicks(9139) },
                    { "a3a148d8-6174-4a12-b55f-2e0a5e0ba3fa", new DateTime(2020, 4, 9, 5, 21, 15, 645, DateTimeKind.Utc).AddTicks(9143), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVABLE", new DateTime(2020, 4, 9, 11, 21, 15, 645, DateTimeKind.Local).AddTicks(9163) },
                    { "df2b6b06-3ae1-4cce-9c05-28d108652187", new DateTime(2020, 4, 9, 5, 21, 15, 645, DateTimeKind.Utc).AddTicks(9163), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAID", new DateTime(2020, 4, 9, 11, 21, 15, 645, DateTimeKind.Local).AddTicks(9171) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Factory",
                keyColumn: "Id",
                keyValue: "74e71871-3c85-4daf-9dd5-9279d8eb2cd9");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "78a25ef7-77b1-45bf-8d29-b37a0be28a8b");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "b48cba78-77ca-48c6-90ed-e0004266359a");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "013f93a0-32c9-463f-9849-7f519cfffcdd");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "73fedfce-3684-4d78-ab6f-2d4450ce66a3");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "a3a148d8-6174-4a12-b55f-2e0a5e0ba3fa");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "df2b6b06-3ae1-4cce-9c05-28d108652187");

            migrationBuilder.InsertData(
                table: "Factory",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "ImageUrl", "LicenseNo", "Name", "RegNo", "RowStatus", "SubscriptionEnd", "SubscriptionStart", "UpdatedDateTime", "VatRegNo" },
                values: new object[] { "46f3b013-9a66-4abb-bac2-ab83f7e85e8a", new DateTime(2020, 4, 9, 11, 10, 23, 632, DateTimeKind.Local).AddTicks(3246), "1956ba54-23fd-4c94-91c0-10e1b606b2e5", "", "", "Fazlu Loom Factory", "", "ADDED", new DateTime(2023, 1, 4, 11, 10, 23, 632, DateTimeKind.Local).AddTicks(8501), new DateTime(2020, 4, 9, 11, 10, 23, 632, DateTimeKind.Local).AddTicks(7528), new DateTime(2020, 4, 9, 11, 10, 23, 632, DateTimeKind.Local).AddTicks(9416), "" });

            migrationBuilder.InsertData(
                table: "ItemStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "Name", "RowStatus", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "a31d75d5-b03c-4116-9315-33d6650d9b3b", new DateTime(2020, 4, 9, 5, 10, 23, 654, DateTimeKind.Utc).AddTicks(4086), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "GOOD", "ADDED", new DateTime(2020, 4, 9, 5, 10, 23, 654, DateTimeKind.Utc).AddTicks(5720) },
                    { "84dcf0e2-780a-4807-94ef-65cf0247e023", new DateTime(2020, 4, 9, 5, 10, 23, 654, DateTimeKind.Utc).AddTicks(5761), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "BAD", "ADDED", new DateTime(2020, 4, 9, 5, 10, 23, 654, DateTimeKind.Utc).AddTicks(5806) }
                });

            migrationBuilder.InsertData(
                table: "PaymentStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "RowStatus", "Status", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "b35a03fb-4e3d-489d-b5c5-91cdd21a6524", new DateTime(2020, 4, 9, 5, 10, 23, 659, DateTimeKind.Utc).AddTicks(3899), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVED", new DateTime(2020, 4, 9, 11, 10, 23, 659, DateTimeKind.Local).AddTicks(4839) },
                    { "8a35dd78-54dc-4a2b-ad10-6a92afba3619", new DateTime(2020, 4, 9, 5, 10, 23, 659, DateTimeKind.Utc).AddTicks(4884), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAYABLE", new DateTime(2020, 4, 9, 11, 10, 23, 659, DateTimeKind.Local).AddTicks(4934) },
                    { "f23016c1-b7b0-4ac8-aef1-abf0f561e80f", new DateTime(2020, 4, 9, 5, 10, 23, 659, DateTimeKind.Utc).AddTicks(4938), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVABLE", new DateTime(2020, 4, 9, 11, 10, 23, 659, DateTimeKind.Local).AddTicks(4946) },
                    { "0c9f0bec-83ef-4886-a4c4-04f326bb9a6e", new DateTime(2020, 4, 9, 5, 10, 23, 659, DateTimeKind.Utc).AddTicks(4946), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAID", new DateTime(2020, 4, 9, 11, 10, 23, 659, DateTimeKind.Local).AddTicks(4950) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sales_ItemCategoryId",
                table: "Sales",
                column: "ItemCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_ItemCategoryId",
                table: "Purchase",
                column: "ItemCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_ItemCategory_ItemCategoryId",
                table: "Purchase",
                column: "ItemCategoryId",
                principalTable: "ItemCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_ItemCategory_ItemCategoryId",
                table: "Sales",
                column: "ItemCategoryId",
                principalTable: "ItemCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
