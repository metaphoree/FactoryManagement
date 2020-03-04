using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiService.Migrations
{
    public partial class FactoryTableDataAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Factory",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "ImageUrl", "LicenseNo", "Name", "RegNo", "RowStatus", "SubscriptionEnd", "SubscriptionStart", "UpdatedDateTime", "VatRegNo" },
                values: new object[] { "e2ec9087-3be7-4d69-922d-7ca70e84ee55", new DateTime(2020, 3, 3, 16, 40, 31, 942, DateTimeKind.Local).AddTicks(5440), "590c3be5-4890-49c1-89aa-c1d717922297", "", "", "Fazlu Loom Factory", "", "ADDED", new DateTime(2022, 11, 28, 16, 40, 31, 943, DateTimeKind.Local).AddTicks(3231), new DateTime(2020, 3, 3, 16, 40, 31, 943, DateTimeKind.Local).AddTicks(2168), new DateTime(2020, 3, 3, 16, 40, 31, 943, DateTimeKind.Local).AddTicks(4188), "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Factory",
                keyColumn: "Id",
                keyValue: "e2ec9087-3be7-4d69-922d-7ca70e84ee55");
        }
    }
}
