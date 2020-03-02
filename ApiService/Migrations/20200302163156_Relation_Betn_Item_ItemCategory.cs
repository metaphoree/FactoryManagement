using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiService.Migrations
{
    public partial class Relation_Betn_Item_ItemCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Factory",
                keyColumn: "Id",
                keyValue: "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30");

            migrationBuilder.AddColumn<string>(
                name: "ItemCategoryId",
                table: "Item",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Factory",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "ImageUrl", "LicenseNo", "Name", "RegNo", "RowStatus", "SubscriptionEnd", "SubscriptionStart", "UniqueId", "UpdatedDateTime", "VatRegNo" },
                values: new object[] { "7d8fd90a-bc30-41c3-b6d9-4187a8305045", new DateTime(2020, 3, 2, 22, 31, 55, 428, DateTimeKind.Local).AddTicks(422), "5e001f76-0979-486d-bdb2-7d5e7d414174", "", "", "Fazlu Loom Factory", "", "ADDED", new DateTime(2022, 11, 27, 22, 31, 55, 428, DateTimeKind.Local).AddTicks(5619), new DateTime(2020, 3, 2, 22, 31, 55, 428, DateTimeKind.Local).AddTicks(4712), "FL00001", new DateTime(2020, 3, 2, 22, 31, 55, 428, DateTimeKind.Local).AddTicks(7101), "" });

            migrationBuilder.CreateIndex(
                name: "IX_Item_ItemCategoryId",
                table: "Item",
                column: "ItemCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_ItemCategory_ItemCategoryId",
                table: "Item",
                column: "ItemCategoryId",
                principalTable: "ItemCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_ItemCategory_ItemCategoryId",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_ItemCategoryId",
                table: "Item");

            migrationBuilder.DeleteData(
                table: "Factory",
                keyColumn: "Id",
                keyValue: "7d8fd90a-bc30-41c3-b6d9-4187a8305045");

            migrationBuilder.DropColumn(
                name: "ItemCategoryId",
                table: "Item");

            migrationBuilder.InsertData(
                table: "Factory",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "ImageUrl", "LicenseNo", "Name", "RegNo", "RowStatus", "SubscriptionEnd", "SubscriptionStart", "UniqueId", "UpdatedDateTime", "VatRegNo" },
                values: new object[] { "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", new DateTime(2020, 2, 20, 14, 4, 41, 98, DateTimeKind.Local).AddTicks(5723), "89631c62-7ca9-43d5-8335-64c48030d651", "", "", "Fazlu Loom Factory", "", "ADDED", new DateTime(2022, 11, 16, 14, 4, 41, 99, DateTimeKind.Local).AddTicks(5161), new DateTime(2020, 2, 20, 14, 4, 41, 99, DateTimeKind.Local).AddTicks(3564), "FL00001", new DateTime(2020, 2, 20, 14, 4, 41, 99, DateTimeKind.Local).AddTicks(7793), "" });
        }
    }
}
