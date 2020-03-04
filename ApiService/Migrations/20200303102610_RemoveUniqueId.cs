using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiService.Migrations
{
    public partial class RemoveUniqueId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Factory",
                keyColumn: "Id",
                keyValue: "7d8fd90a-bc30-41c3-b6d9-4187a8305045");

            migrationBuilder.DropColumn(
                name: "UniqueId",
                table: "UserRole");

            migrationBuilder.DropColumn(
                name: "UniqueId",
                table: "UserAuthInfo");

            migrationBuilder.DropColumn(
                name: "UniqueId",
                table: "TransactionType");

            migrationBuilder.DropColumn(
                name: "UniqueId",
                table: "Transaction");

            migrationBuilder.DropColumn(
                name: "UniqueId",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "UniqueId",
                table: "StockOut");

            migrationBuilder.DropColumn(
                name: "UniqueId",
                table: "StockIn");

            migrationBuilder.DropColumn(
                name: "UniqueId",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "UniqueId",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "UniqueId",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "UniqueId",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "UniqueId",
                table: "Recievable");

            migrationBuilder.DropColumn(
                name: "UniqueId",
                table: "PurchaseType");

            migrationBuilder.DropColumn(
                name: "UniqueId",
                table: "Purchase");

            migrationBuilder.DropColumn(
                name: "UniqueId",
                table: "Production");

            migrationBuilder.DropColumn(
                name: "UniqueId",
                table: "Phone");

            migrationBuilder.DropColumn(
                name: "UniqueId",
                table: "PaymentStatus");

            migrationBuilder.DropColumn(
                name: "UniqueId",
                table: "Payable");

            migrationBuilder.DropColumn(
                name: "UniqueId",
                table: "ItemStatus");

            migrationBuilder.DropColumn(
                name: "UniqueId",
                table: "ItemCategory");

            migrationBuilder.DropColumn(
                name: "UniqueId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "UniqueId",
                table: "InvoiceType");

            migrationBuilder.DropColumn(
                name: "UniqueId",
                table: "Invoice");

            migrationBuilder.DropColumn(
                name: "UniqueId",
                table: "IncomeType");

            migrationBuilder.DropColumn(
                name: "UniqueId",
                table: "Factory");

            migrationBuilder.DropColumn(
                name: "UniqueId",
                table: "ExpenseType");

            migrationBuilder.DropColumn(
                name: "UniqueId",
                table: "Expense");

            migrationBuilder.DropColumn(
                name: "UniqueId",
                table: "EquipmentCategory");

            migrationBuilder.DropColumn(
                name: "UniqueId",
                table: "Equipment");

            migrationBuilder.DropColumn(
                name: "UniqueId",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "UniqueId",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "UniqueId",
                table: "Address");

            migrationBuilder.AlterColumn<string>(
                name: "RowStatus",
                table: "Supplier",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "RowStatus",
                table: "Staff",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UniqueId",
                table: "UserRole",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UniqueId",
                table: "UserAuthInfo",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UniqueId",
                table: "TransactionType",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UniqueId",
                table: "Transaction",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "RowStatus",
                table: "Supplier",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "UniqueId",
                table: "Supplier",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UniqueId",
                table: "StockOut",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UniqueId",
                table: "StockIn",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UniqueId",
                table: "Stock",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "RowStatus",
                table: "Staff",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "UniqueId",
                table: "Staff",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UniqueId",
                table: "Sales",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UniqueId",
                table: "Role",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UniqueId",
                table: "Recievable",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UniqueId",
                table: "PurchaseType",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UniqueId",
                table: "Purchase",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UniqueId",
                table: "Production",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UniqueId",
                table: "Phone",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UniqueId",
                table: "PaymentStatus",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UniqueId",
                table: "Payable",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UniqueId",
                table: "ItemStatus",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UniqueId",
                table: "ItemCategory",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UniqueId",
                table: "Item",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UniqueId",
                table: "InvoiceType",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UniqueId",
                table: "Invoice",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UniqueId",
                table: "IncomeType",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UniqueId",
                table: "Factory",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UniqueId",
                table: "ExpenseType",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UniqueId",
                table: "Expense",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UniqueId",
                table: "EquipmentCategory",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UniqueId",
                table: "Equipment",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UniqueId",
                table: "Department",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UniqueId",
                table: "Customer",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UniqueId",
                table: "Address",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Factory",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "ImageUrl", "LicenseNo", "Name", "RegNo", "RowStatus", "SubscriptionEnd", "SubscriptionStart", "UniqueId", "UpdatedDateTime", "VatRegNo" },
                values: new object[] { "7d8fd90a-bc30-41c3-b6d9-4187a8305045", new DateTime(2020, 3, 2, 22, 31, 55, 428, DateTimeKind.Local).AddTicks(422), "5e001f76-0979-486d-bdb2-7d5e7d414174", "", "", "Fazlu Loom Factory", "", "ADDED", new DateTime(2022, 11, 27, 22, 31, 55, 428, DateTimeKind.Local).AddTicks(5619), new DateTime(2020, 3, 2, 22, 31, 55, 428, DateTimeKind.Local).AddTicks(4712), "FL00001", new DateTime(2020, 3, 2, 22, 31, 55, 428, DateTimeKind.Local).AddTicks(7101), "" });
        }
    }
}
