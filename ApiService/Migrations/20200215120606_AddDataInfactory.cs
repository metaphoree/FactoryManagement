using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiService.Migrations
{
    public partial class AddDataInfactory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Factory",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "ImageUrl", "LicenseNo", "Name", "RegNo", "RowStatus", "SubscriptionEnd", "SubscriptionStart", "UniqueId", "UpdatedDateTime", "VatRegNo" },
                values: new object[] { "3cd4dbc2-d0f7-443d-89b0-c8b4e8b3fd42", new DateTime(2020, 2, 15, 18, 6, 6, 62, DateTimeKind.Local).AddTicks(2241), "44ebd3d4-b045-45cd-a966-b3ef95a0f951", "", "", "Fazlu Loom Factory", "", "ADDED", new DateTime(2022, 11, 11, 18, 6, 6, 62, DateTimeKind.Local).AddTicks(7176), new DateTime(2020, 2, 15, 18, 6, 6, 62, DateTimeKind.Local).AddTicks(6276), "FL00001", new DateTime(2020, 2, 15, 18, 6, 6, 62, DateTimeKind.Local).AddTicks(8641), "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Factory",
                keyColumn: "Id",
                keyValue: "3cd4dbc2-d0f7-443d-89b0-c8b4e8b3fd42");
        }
    }
}
