using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiService.Migrations
{
    public partial class Phone_Table_Type_Null_Accept : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Factory",
                keyColumn: "Id",
                keyValue: "3cd4dbc2-d0f7-443d-89b0-c8b4e8b3fd42");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Phone",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.InsertData(
                table: "Factory",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "ImageUrl", "LicenseNo", "Name", "RegNo", "RowStatus", "SubscriptionEnd", "SubscriptionStart", "UniqueId", "UpdatedDateTime", "VatRegNo" },
                values: new object[] { "c0ecdd4d-1114-49a7-b749-ed47a71344e6", new DateTime(2020, 2, 18, 1, 26, 14, 762, DateTimeKind.Local).AddTicks(5315), "d2702c34-d617-449f-b71f-39f04a7bae09", "", "", "Fazlu Loom Factory", "", "ADDED", new DateTime(2022, 11, 14, 1, 26, 14, 763, DateTimeKind.Local).AddTicks(944), new DateTime(2020, 2, 18, 1, 26, 14, 762, DateTimeKind.Local).AddTicks(9724), "FL00001", new DateTime(2020, 2, 18, 1, 26, 14, 763, DateTimeKind.Local).AddTicks(2516), "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Factory",
                keyColumn: "Id",
                keyValue: "c0ecdd4d-1114-49a7-b749-ed47a71344e6");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Phone",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Factory",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "ImageUrl", "LicenseNo", "Name", "RegNo", "RowStatus", "SubscriptionEnd", "SubscriptionStart", "UniqueId", "UpdatedDateTime", "VatRegNo" },
                values: new object[] { "3cd4dbc2-d0f7-443d-89b0-c8b4e8b3fd42", new DateTime(2020, 2, 15, 18, 6, 6, 62, DateTimeKind.Local).AddTicks(2241), "44ebd3d4-b045-45cd-a966-b3ef95a0f951", "", "", "Fazlu Loom Factory", "", "ADDED", new DateTime(2022, 11, 11, 18, 6, 6, 62, DateTimeKind.Local).AddTicks(7176), new DateTime(2020, 2, 15, 18, 6, 6, 62, DateTimeKind.Local).AddTicks(6276), "FL00001", new DateTime(2020, 2, 15, 18, 6, 6, 62, DateTimeKind.Local).AddTicks(8641), "" });
        }
    }
}
