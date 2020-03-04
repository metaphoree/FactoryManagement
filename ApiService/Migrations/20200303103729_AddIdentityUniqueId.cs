using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiService.Migrations
{
    public partial class AddIdentityUniqueId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "UniqueId",
                table: "UserRole",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<long>(
                name: "UniqueId",
                table: "UserAuthInfo",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<long>(
                name: "UniqueId",
                table: "TransactionType",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<long>(
                name: "UniqueId",
                table: "Transaction",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<long>(
                name: "UniqueId",
                table: "Supplier",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<long>(
                name: "UniqueId",
                table: "StockOut",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<long>(
                name: "UniqueId",
                table: "StockIn",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<long>(
                name: "UniqueId",
                table: "Stock",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<long>(
                name: "UniqueId",
                table: "Staff",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<long>(
                name: "UniqueId",
                table: "Sales",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<long>(
                name: "UniqueId",
                table: "Role",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<long>(
                name: "UniqueId",
                table: "Recievable",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<long>(
                name: "UniqueId",
                table: "PurchaseType",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<long>(
                name: "UniqueId",
                table: "Purchase",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<long>(
                name: "UniqueId",
                table: "Production",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<long>(
                name: "UniqueId",
                table: "Phone",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<long>(
                name: "UniqueId",
                table: "PaymentStatus",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<long>(
                name: "UniqueId",
                table: "Payable",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<long>(
                name: "UniqueId",
                table: "ItemStatus",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<long>(
                name: "UniqueId",
                table: "ItemCategory",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<long>(
                name: "UniqueId",
                table: "Item",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<long>(
                name: "UniqueId",
                table: "InvoiceType",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<long>(
                name: "UniqueId",
                table: "Invoice",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<long>(
                name: "UniqueId",
                table: "IncomeType",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<long>(
                name: "UniqueId",
                table: "Factory",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<long>(
                name: "UniqueId",
                table: "ExpenseType",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<long>(
                name: "UniqueId",
                table: "Expense",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<long>(
                name: "UniqueId",
                table: "EquipmentCategory",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<long>(
                name: "UniqueId",
                table: "Equipment",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<long>(
                name: "UniqueId",
                table: "Department",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<long>(
                name: "UniqueId",
                table: "Customer",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<long>(
                name: "UniqueId",
                table: "Address",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
