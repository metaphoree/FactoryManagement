using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiService.Migrations
{
    public partial class SalesTableColumnModify : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Factory",
                keyColumn: "Id",
                keyValue: "44d15467-42ad-483d-b2e6-9f1b0e7a5c6e");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "7808f3c1-a97b-4fee-a5f9-9ce6bddd101c");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "8cb655f8-8ebb-446a-a336-b6d59dead736");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "3a5d3a6a-e3e3-4dc5-b9b0-de267c2370d2");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "597222b9-a00e-4c5c-ae5b-c4ec6e83b545");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "5bef3ccb-9071-4ca4-8129-269449807c4d");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "fd635343-ef7c-4ce7-8814-8a6f85c8de37");

            migrationBuilder.DropColumn(
                name: "AmountAfterDiscount",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "AmountBeforeDiscount",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "AmountDue",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "AmountPaid",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "Discount",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "IsDiscountInPercentage",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "IsPaid",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "SaleId",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "SalesDate",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "SellerId",
                table: "Sales");

            migrationBuilder.AddColumn<decimal>(
                name: "Amount",
                table: "Sales",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.InsertData(
                table: "Factory",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "ImageUrl", "LicenseNo", "Name", "RegNo", "RowStatus", "SubscriptionEnd", "SubscriptionStart", "UpdatedDateTime", "VatRegNo" },
                values: new object[] { "31291fc6-5fb2-4fe6-a40e-a815bb8f45ff", new DateTime(2020, 3, 18, 11, 2, 5, 465, DateTimeKind.Local).AddTicks(5421), "5172f57e-8857-4ab8-8f92-f22075de4a97", "", "", "Fazlu Loom Factory", "", "ADDED", new DateTime(2022, 12, 13, 11, 2, 5, 466, DateTimeKind.Local).AddTicks(1533), new DateTime(2020, 3, 18, 11, 2, 5, 466, DateTimeKind.Local).AddTicks(421), new DateTime(2020, 3, 18, 11, 2, 5, 466, DateTimeKind.Local).AddTicks(2523), "" });

            migrationBuilder.InsertData(
                table: "ItemStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "Name", "RowStatus", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "c75530f5-5f72-45b8-a961-2fdaecabe559", new DateTime(2020, 3, 18, 5, 2, 5, 485, DateTimeKind.Utc).AddTicks(2479), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "GOOD", "ADDED", new DateTime(2020, 3, 18, 5, 2, 5, 485, DateTimeKind.Utc).AddTicks(4528) },
                    { "bb7e0974-a013-4031-bf09-951d92c65f63", new DateTime(2020, 3, 18, 5, 2, 5, 485, DateTimeKind.Utc).AddTicks(4569), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "BAD", "ADDED", new DateTime(2020, 3, 18, 5, 2, 5, 485, DateTimeKind.Utc).AddTicks(4598) }
                });

            migrationBuilder.InsertData(
                table: "PaymentStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "RowStatus", "Status", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "d368dd69-8f01-4f06-97da-bbba2fd694d6", new DateTime(2020, 3, 18, 5, 2, 5, 490, DateTimeKind.Utc).AddTicks(5298), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVED", new DateTime(2020, 3, 18, 11, 2, 5, 490, DateTimeKind.Local).AddTicks(6308) },
                    { "054bce7c-1243-4d3b-bd62-90d2df0e041c", new DateTime(2020, 3, 18, 5, 2, 5, 490, DateTimeKind.Utc).AddTicks(6353), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAYABLE", new DateTime(2020, 3, 18, 11, 2, 5, 490, DateTimeKind.Local).AddTicks(6394) },
                    { "c45ffa58-55e0-4998-9542-2f03958f32f8", new DateTime(2020, 3, 18, 5, 2, 5, 490, DateTimeKind.Utc).AddTicks(6394), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVABLE", new DateTime(2020, 3, 18, 11, 2, 5, 490, DateTimeKind.Local).AddTicks(6403) },
                    { "8aae8245-7ebc-4735-b3c5-e853a1b65315", new DateTime(2020, 3, 18, 5, 2, 5, 490, DateTimeKind.Utc).AddTicks(6403), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAID", new DateTime(2020, 3, 18, 11, 2, 5, 490, DateTimeKind.Local).AddTicks(6407) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Factory",
                keyColumn: "Id",
                keyValue: "31291fc6-5fb2-4fe6-a40e-a815bb8f45ff");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "bb7e0974-a013-4031-bf09-951d92c65f63");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "c75530f5-5f72-45b8-a961-2fdaecabe559");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "054bce7c-1243-4d3b-bd62-90d2df0e041c");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "8aae8245-7ebc-4735-b3c5-e853a1b65315");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "c45ffa58-55e0-4998-9542-2f03958f32f8");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "d368dd69-8f01-4f06-97da-bbba2fd694d6");

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Sales");

            migrationBuilder.AddColumn<decimal>(
                name: "AmountAfterDiscount",
                table: "Sales",
                type: "decimal(18, 0)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "AmountBeforeDiscount",
                table: "Sales",
                type: "decimal(18, 0)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "AmountDue",
                table: "Sales",
                type: "decimal(18, 0)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "AmountPaid",
                table: "Sales",
                type: "decimal(18, 0)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Sales",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Discount",
                table: "Sales",
                type: "decimal(18, 0)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDiscountInPercentage",
                table: "Sales",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsPaid",
                table: "Sales",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SaleId",
                table: "Sales",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "SalesDate",
                table: "Sales",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "SellerId",
                table: "Sales",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.InsertData(
                table: "Factory",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "ImageUrl", "LicenseNo", "Name", "RegNo", "RowStatus", "SubscriptionEnd", "SubscriptionStart", "UpdatedDateTime", "VatRegNo" },
                values: new object[] { "44d15467-42ad-483d-b2e6-9f1b0e7a5c6e", new DateTime(2020, 3, 18, 10, 51, 48, 353, DateTimeKind.Local).AddTicks(3030), "7b526292-3de4-48ae-b28b-e00c7b4345f5", "", "", "Fazlu Loom Factory", "", "ADDED", new DateTime(2022, 12, 13, 10, 51, 48, 354, DateTimeKind.Local).AddTicks(7699), new DateTime(2020, 3, 18, 10, 51, 48, 354, DateTimeKind.Local).AddTicks(4509), new DateTime(2020, 3, 18, 10, 51, 48, 355, DateTimeKind.Local).AddTicks(63), "" });

            migrationBuilder.InsertData(
                table: "ItemStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "Name", "RowStatus", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "8cb655f8-8ebb-446a-a336-b6d59dead736", new DateTime(2020, 3, 18, 4, 51, 48, 380, DateTimeKind.Utc).AddTicks(959), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "GOOD", "ADDED", new DateTime(2020, 3, 18, 4, 51, 48, 380, DateTimeKind.Utc).AddTicks(2790) },
                    { "7808f3c1-a97b-4fee-a5f9-9ce6bddd101c", new DateTime(2020, 3, 18, 4, 51, 48, 380, DateTimeKind.Utc).AddTicks(2831), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "BAD", "ADDED", new DateTime(2020, 3, 18, 4, 51, 48, 380, DateTimeKind.Utc).AddTicks(2860) }
                });

            migrationBuilder.InsertData(
                table: "PaymentStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "RowStatus", "Status", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "5bef3ccb-9071-4ca4-8129-269449807c4d", new DateTime(2020, 3, 18, 4, 51, 48, 387, DateTimeKind.Utc).AddTicks(3841), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVED", new DateTime(2020, 3, 18, 10, 51, 48, 387, DateTimeKind.Local).AddTicks(5216) },
                    { "597222b9-a00e-4c5c-ae5b-c4ec6e83b545", new DateTime(2020, 3, 18, 4, 51, 48, 387, DateTimeKind.Utc).AddTicks(5274), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAYABLE", new DateTime(2020, 3, 18, 10, 51, 48, 387, DateTimeKind.Local).AddTicks(5327) },
                    { "fd635343-ef7c-4ce7-8814-8a6f85c8de37", new DateTime(2020, 3, 18, 4, 51, 48, 387, DateTimeKind.Utc).AddTicks(5331), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVABLE", new DateTime(2020, 3, 18, 10, 51, 48, 387, DateTimeKind.Local).AddTicks(5344) },
                    { "3a5d3a6a-e3e3-4dc5-b9b0-de267c2370d2", new DateTime(2020, 3, 18, 4, 51, 48, 387, DateTimeKind.Utc).AddTicks(5344), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAID", new DateTime(2020, 3, 18, 10, 51, 48, 387, DateTimeKind.Local).AddTicks(5352) }
                });
        }
    }
}
