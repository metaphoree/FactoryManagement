using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiService.Migrations
{
    public partial class RelationChangeAndAddressPhoneFieldAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: "e2ec9087-3be7-4d69-922d-7ca70e84ee55");

            migrationBuilder.DropColumn(
                name: "ItemCategoryId",
                table: "Item");

            migrationBuilder.AddColumn<string>(
                name: "AlternateNumber_1",
                table: "Supplier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AlternateNumber_2",
                table: "Supplier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Number",
                table: "Supplier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PermanentAddress",
                table: "Supplier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PresentAddress",
                table: "Supplier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AlternateNumber_1",
                table: "Staff",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AlternateNumber_2",
                table: "Staff",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Number",
                table: "Staff",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PermanentAddress",
                table: "Staff",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PresentAddress",
                table: "Staff",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CategoryId",
                table: "Item",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AddColumn<string>(
                name: "AlternateNumber_1",
                table: "Customer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AlternateNumber_2",
                table: "Customer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Number",
                table: "Customer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PermanentAddress",
                table: "Customer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PresentAddress",
                table: "Customer",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Factory",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "ImageUrl", "LicenseNo", "Name", "RegNo", "RowStatus", "SubscriptionEnd", "SubscriptionStart", "UpdatedDateTime", "VatRegNo" },
                values: new object[] { "b1e1eea3-3106-4879-af5c-a68a4224d0c9", new DateTime(2020, 3, 10, 19, 52, 8, 805, DateTimeKind.Local).AddTicks(8559), "7c0401e4-1efa-42f8-8fbc-72dcd784cb4d", "", "", "Fazlu Loom Factory", "", "ADDED", new DateTime(2022, 12, 5, 19, 52, 8, 806, DateTimeKind.Local).AddTicks(3937), new DateTime(2020, 3, 10, 19, 52, 8, 806, DateTimeKind.Local).AddTicks(2960), new DateTime(2020, 3, 10, 19, 52, 8, 806, DateTimeKind.Local).AddTicks(4894), "" });

            migrationBuilder.CreateIndex(
                name: "IX_Item_CategoryId",
                table: "Item",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_ItemCategory_CategoryId",
                table: "Item",
                column: "CategoryId",
                principalTable: "ItemCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_ItemCategory_CategoryId",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_CategoryId",
                table: "Item");

            migrationBuilder.DeleteData(
                table: "Factory",
                keyColumn: "Id",
                keyValue: "b1e1eea3-3106-4879-af5c-a68a4224d0c9");

            migrationBuilder.DropColumn(
                name: "AlternateNumber_1",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "AlternateNumber_2",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "Number",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "PermanentAddress",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "PresentAddress",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "AlternateNumber_1",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "AlternateNumber_2",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "Number",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "PermanentAddress",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "PresentAddress",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "AlternateNumber_1",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "AlternateNumber_2",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Number",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "PermanentAddress",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "PresentAddress",
                table: "Customer");

            migrationBuilder.AlterColumn<string>(
                name: "CategoryId",
                table: "Item",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AddColumn<string>(
                name: "ItemCategoryId",
                table: "Item",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Factory",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "ImageUrl", "LicenseNo", "Name", "RegNo", "RowStatus", "SubscriptionEnd", "SubscriptionStart", "UpdatedDateTime", "VatRegNo" },
                values: new object[] { "e2ec9087-3be7-4d69-922d-7ca70e84ee55", new DateTime(2020, 3, 3, 16, 40, 31, 942, DateTimeKind.Local).AddTicks(5440), "590c3be5-4890-49c1-89aa-c1d717922297", "", "", "Fazlu Loom Factory", "", "ADDED", new DateTime(2022, 11, 28, 16, 40, 31, 943, DateTimeKind.Local).AddTicks(3231), new DateTime(2020, 3, 3, 16, 40, 31, 943, DateTimeKind.Local).AddTicks(2168), new DateTime(2020, 3, 3, 16, 40, 31, 943, DateTimeKind.Local).AddTicks(4188), "" });

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
    }
}
