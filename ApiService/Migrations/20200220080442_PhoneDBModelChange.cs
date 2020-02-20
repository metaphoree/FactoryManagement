using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiService.Migrations
{
    public partial class PhoneDBModelChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Factory",
                keyColumn: "Id",
                keyValue: "c0ecdd4d-1114-49a7-b749-ed47a71344e6");

            migrationBuilder.AddColumn<string>(
                name: "AlternateNumber_1",
                table: "Phone",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AlternateNumber_2",
                table: "Phone",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AlternateNumber_3",
                table: "Phone",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LandPhone",
                table: "Phone",
                maxLength: 50,
                nullable: true);

            migrationBuilder.InsertData(
                table: "Factory",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "ImageUrl", "LicenseNo", "Name", "RegNo", "RowStatus", "SubscriptionEnd", "SubscriptionStart", "UniqueId", "UpdatedDateTime", "VatRegNo" },
                values: new object[] { "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", new DateTime(2020, 2, 20, 14, 4, 41, 98, DateTimeKind.Local).AddTicks(5723), "89631c62-7ca9-43d5-8335-64c48030d651", "", "", "Fazlu Loom Factory", "", "ADDED", new DateTime(2022, 11, 16, 14, 4, 41, 99, DateTimeKind.Local).AddTicks(5161), new DateTime(2020, 2, 20, 14, 4, 41, 99, DateTimeKind.Local).AddTicks(3564), "FL00001", new DateTime(2020, 2, 20, 14, 4, 41, 99, DateTimeKind.Local).AddTicks(7793), "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Factory",
                keyColumn: "Id",
                keyValue: "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30");

            migrationBuilder.DropColumn(
                name: "AlternateNumber_1",
                table: "Phone");

            migrationBuilder.DropColumn(
                name: "AlternateNumber_2",
                table: "Phone");

            migrationBuilder.DropColumn(
                name: "AlternateNumber_3",
                table: "Phone");

            migrationBuilder.DropColumn(
                name: "LandPhone",
                table: "Phone");

            migrationBuilder.InsertData(
                table: "Factory",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "ImageUrl", "LicenseNo", "Name", "RegNo", "RowStatus", "SubscriptionEnd", "SubscriptionStart", "UniqueId", "UpdatedDateTime", "VatRegNo" },
                values: new object[] { "c0ecdd4d-1114-49a7-b749-ed47a71344e6", new DateTime(2020, 2, 18, 1, 26, 14, 762, DateTimeKind.Local).AddTicks(5315), "d2702c34-d617-449f-b71f-39f04a7bae09", "", "", "Fazlu Loom Factory", "", "ADDED", new DateTime(2022, 11, 14, 1, 26, 14, 763, DateTimeKind.Local).AddTicks(944), new DateTime(2020, 2, 18, 1, 26, 14, 762, DateTimeKind.Local).AddTicks(9724), "FL00001", new DateTime(2020, 2, 18, 1, 26, 14, 763, DateTimeKind.Local).AddTicks(2516), "" });
        }
    }
}
