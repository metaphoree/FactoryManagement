using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiService.Migrations
{
    public partial class RemoveFieldFromPurchase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropColumn(
                name: "AmountAfterDiscount",
                table: "Purchase");

            migrationBuilder.DropColumn(
                name: "AmountBeforeDiscount",
                table: "Purchase");

            migrationBuilder.DropColumn(
                name: "AmountDue",
                table: "Purchase");

            migrationBuilder.DropColumn(
                name: "AmountPaid",
                table: "Purchase");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Purchase");

            migrationBuilder.DropColumn(
                name: "Discount",
                table: "Purchase");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Purchase");

            migrationBuilder.DropColumn(
                name: "IsDiscountInPercentage",
                table: "Purchase");

            migrationBuilder.DropColumn(
                name: "IsPaid",
                table: "Purchase");

            migrationBuilder.DropColumn(
                name: "Month",
                table: "Purchase");

            migrationBuilder.DropColumn(
                name: "PurchaseId",
                table: "Purchase");

            migrationBuilder.DropColumn(
                name: "SalesDate",
                table: "Purchase");

            migrationBuilder.InsertData(
                table: "Factory",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "ImageUrl", "LicenseNo", "Name", "RegNo", "RowStatus", "SubscriptionEnd", "SubscriptionStart", "UpdatedDateTime", "VatRegNo" },
                values: new object[] { "73fb3a73-f2a3-49a2-b13a-99ef1df28366", new DateTime(2020, 3, 18, 10, 6, 13, 840, DateTimeKind.Local).AddTicks(3923), "d6180274-1d86-4675-b1fd-f779bf02f0ed", "", "", "Fazlu Loom Factory", "", "ADDED", new DateTime(2022, 12, 13, 10, 6, 13, 840, DateTimeKind.Local).AddTicks(9826), new DateTime(2020, 3, 18, 10, 6, 13, 840, DateTimeKind.Local).AddTicks(8825), new DateTime(2020, 3, 18, 10, 6, 13, 841, DateTimeKind.Local).AddTicks(738), "" });

            migrationBuilder.InsertData(
                table: "ItemStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "Name", "RowStatus", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "11f8392c-1e62-469f-ad90-c68edf735fef", new DateTime(2020, 3, 18, 4, 6, 13, 860, DateTimeKind.Utc).AddTicks(1245), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "GOOD", "ADDED", new DateTime(2020, 3, 18, 4, 6, 13, 860, DateTimeKind.Utc).AddTicks(2940) },
                    { "eedb5ed6-f89e-48d9-8cfe-b2fd622a806d", new DateTime(2020, 3, 18, 4, 6, 13, 860, DateTimeKind.Utc).AddTicks(2973), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "BAD", "ADDED", new DateTime(2020, 3, 18, 4, 6, 13, 860, DateTimeKind.Utc).AddTicks(3002) }
                });

            migrationBuilder.InsertData(
                table: "PaymentStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "RowStatus", "Status", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "80aafad3-5337-4191-a475-f189d900fa2a", new DateTime(2020, 3, 18, 4, 6, 13, 865, DateTimeKind.Utc).AddTicks(3411), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVED", new DateTime(2020, 3, 18, 10, 6, 13, 865, DateTimeKind.Local).AddTicks(5853) },
                    { "1ea8e0dc-6127-40c0-8dc9-e1934800c7de", new DateTime(2020, 3, 18, 4, 6, 13, 865, DateTimeKind.Utc).AddTicks(5915), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAYABLE", new DateTime(2020, 3, 18, 10, 6, 13, 865, DateTimeKind.Local).AddTicks(6001) },
                    { "fe585e88-a9e7-4ba0-bcb0-2ff2dfcf2b93", new DateTime(2020, 3, 18, 4, 6, 13, 865, DateTimeKind.Utc).AddTicks(6005), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVABLE", new DateTime(2020, 3, 18, 10, 6, 13, 865, DateTimeKind.Local).AddTicks(6017) },
                    { "0124aa97-355d-469d-a3b2-001cfacf0d84", new DateTime(2020, 3, 18, 4, 6, 13, 865, DateTimeKind.Utc).AddTicks(6017), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAID", new DateTime(2020, 3, 18, 10, 6, 13, 865, DateTimeKind.Local).AddTicks(6026) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Factory",
                keyColumn: "Id",
                keyValue: "73fb3a73-f2a3-49a2-b13a-99ef1df28366");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "11f8392c-1e62-469f-ad90-c68edf735fef");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "eedb5ed6-f89e-48d9-8cfe-b2fd622a806d");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "0124aa97-355d-469d-a3b2-001cfacf0d84");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "1ea8e0dc-6127-40c0-8dc9-e1934800c7de");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "80aafad3-5337-4191-a475-f189d900fa2a");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "fe585e88-a9e7-4ba0-bcb0-2ff2dfcf2b93");

            migrationBuilder.AddColumn<decimal>(
                name: "AmountAfterDiscount",
                table: "Purchase",
                type: "decimal(18, 0)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "AmountBeforeDiscount",
                table: "Purchase",
                type: "decimal(18, 0)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "AmountDue",
                table: "Purchase",
                type: "decimal(18, 0)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "AmountPaid",
                table: "Purchase",
                type: "decimal(18, 0)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Purchase",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Discount",
                table: "Purchase",
                type: "decimal(18, 0)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmployeeId",
                table: "Purchase",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDiscountInPercentage",
                table: "Purchase",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsPaid",
                table: "Purchase",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Month",
                table: "Purchase",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PurchaseId",
                table: "Purchase",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "SalesDate",
                table: "Purchase",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
        }
    }
}
