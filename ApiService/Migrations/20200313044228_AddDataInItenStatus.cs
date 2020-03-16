using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiService.Migrations
{
    public partial class AddDataInItenStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Factory",
                keyColumn: "Id",
                keyValue: "b1e1eea3-3106-4879-af5c-a68a4224d0c9");

            migrationBuilder.InsertData(
                table: "Factory",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "ImageUrl", "LicenseNo", "Name", "RegNo", "RowStatus", "SubscriptionEnd", "SubscriptionStart", "UpdatedDateTime", "VatRegNo" },
                values: new object[] { "ae2e825f-997c-4384-a77d-5b0a579813ab", new DateTime(2020, 3, 13, 10, 42, 25, 949, DateTimeKind.Local).AddTicks(6777), "54569290-52f7-4544-827d-9e1132a96565", "", "", "Fazlu Loom Factory", "", "ADDED", new DateTime(2022, 12, 8, 10, 42, 25, 951, DateTimeKind.Local).AddTicks(1039), new DateTime(2020, 3, 13, 10, 42, 25, 950, DateTimeKind.Local).AddTicks(4023), new DateTime(2020, 3, 13, 10, 42, 25, 951, DateTimeKind.Local).AddTicks(2989), "" });

            migrationBuilder.InsertData(
                table: "ItemStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "Name", "RowStatus", "UpdatedDateTime" },
                values: new object[] { "7730c5a0-2a7d-49af-97ac-1f299c987c44", new DateTime(2020, 3, 13, 4, 42, 25, 988, DateTimeKind.Utc).AddTicks(4884), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "GOOD", "ADDED", new DateTime(2020, 3, 13, 4, 42, 25, 988, DateTimeKind.Utc).AddTicks(6584) });

            migrationBuilder.InsertData(
                table: "ItemStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "Name", "RowStatus", "UpdatedDateTime" },
                values: new object[] { "a531b24c-1719-4d22-ad17-b99464cba94b", new DateTime(2020, 3, 13, 4, 42, 25, 988, DateTimeKind.Utc).AddTicks(6625), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "BAD", "ADDED", new DateTime(2020, 3, 13, 4, 42, 25, 988, DateTimeKind.Utc).AddTicks(6662) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Factory",
                keyColumn: "Id",
                keyValue: "ae2e825f-997c-4384-a77d-5b0a579813ab");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "7730c5a0-2a7d-49af-97ac-1f299c987c44");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "a531b24c-1719-4d22-ad17-b99464cba94b");

            migrationBuilder.InsertData(
                table: "Factory",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "ImageUrl", "LicenseNo", "Name", "RegNo", "RowStatus", "SubscriptionEnd", "SubscriptionStart", "UpdatedDateTime", "VatRegNo" },
                values: new object[] { "b1e1eea3-3106-4879-af5c-a68a4224d0c9", new DateTime(2020, 3, 10, 19, 52, 8, 805, DateTimeKind.Local).AddTicks(8559), "7c0401e4-1efa-42f8-8fbc-72dcd784cb4d", "", "", "Fazlu Loom Factory", "", "ADDED", new DateTime(2022, 12, 5, 19, 52, 8, 806, DateTimeKind.Local).AddTicks(3937), new DateTime(2020, 3, 10, 19, 52, 8, 806, DateTimeKind.Local).AddTicks(2960), new DateTime(2020, 3, 10, 19, 52, 8, 806, DateTimeKind.Local).AddTicks(4894), "" });
        }
    }
}
