using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiService.Migrations
{
    public partial class FieldChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Factory",
                keyColumn: "Id",
                keyValue: "ecd834c4-d468-4f59-aaf5-7c57c21e0856");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "0f0fd2f1-2527-4f68-9814-be250e1e95d9");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "a9f1f637-d9f1-4226-8b5d-b9c4fbcc7af4");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "08be1bd0-cf41-4a77-a227-019d4e6a4054");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "42f8062e-e0ef-4338-9392-e282e5d0446d");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "e18cda76-5590-44bb-bce2-db9d2b4256d2");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "f97b64a2-bb06-42c8-a522-235f20c318ff");

            migrationBuilder.DropColumn(
                name: "MachineId",
                table: "Production");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Production");

            migrationBuilder.RenameColumn(
                name: "RatePerProduct",
                table: "Production",
                newName: "UnitPrice");

            migrationBuilder.AddColumn<DateTime>(
                name: "OccurranceDate",
                table: "Sales",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "OccurranceDate",
                table: "Purchase",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "EquipmentId",
                table: "Production",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ItemId",
                table: "Production",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AmountPaid",
                table: "Invoice",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IncomeTypeId",
                table: "Income",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Factory",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "ImageUrl", "LicenseNo", "Name", "RegNo", "RowStatus", "SubscriptionEnd", "SubscriptionStart", "UpdatedDateTime", "VatRegNo" },
                values: new object[] { "34b42c41-09a8-471c-bd78-37cffa8ae531", new DateTime(2020, 4, 7, 19, 35, 23, 449, DateTimeKind.Local).AddTicks(8767), "102d2743-8f38-4345-8eff-8bb849d845f4", "", "", "Fazlu Loom Factory", "", "ADDED", new DateTime(2023, 1, 2, 19, 35, 23, 450, DateTimeKind.Local).AddTicks(4145), new DateTime(2020, 4, 7, 19, 35, 23, 450, DateTimeKind.Local).AddTicks(3193), new DateTime(2020, 4, 7, 19, 35, 23, 450, DateTimeKind.Local).AddTicks(5036), "" });

            migrationBuilder.InsertData(
                table: "ItemStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "Name", "RowStatus", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "acd3ab5c-6c71-4716-92f5-8fcd72dfaa79", new DateTime(2020, 4, 7, 13, 35, 23, 470, DateTimeKind.Utc).AddTicks(3247), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "GOOD", "ADDED", new DateTime(2020, 4, 7, 13, 35, 23, 470, DateTimeKind.Utc).AddTicks(4758) },
                    { "3074f980-94ae-4d62-b44f-63585ba618f7", new DateTime(2020, 4, 7, 13, 35, 23, 470, DateTimeKind.Utc).AddTicks(4795), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "BAD", "ADDED", new DateTime(2020, 4, 7, 13, 35, 23, 470, DateTimeKind.Utc).AddTicks(4824) }
                });

            migrationBuilder.InsertData(
                table: "PaymentStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "RowStatus", "Status", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "722dc016-4093-448c-8610-0207a08b265b", new DateTime(2020, 4, 7, 13, 35, 23, 474, DateTimeKind.Utc).AddTicks(9191), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVED", new DateTime(2020, 4, 7, 19, 35, 23, 474, DateTimeKind.Local).AddTicks(9987) },
                    { "bf0385c0-ca07-4a3c-9c90-7127b381c259", new DateTime(2020, 4, 7, 13, 35, 23, 475, DateTimeKind.Utc).AddTicks(24), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAYABLE", new DateTime(2020, 4, 7, 19, 35, 23, 475, DateTimeKind.Local).AddTicks(57) },
                    { "79a3ff2a-ff6e-49e2-9926-1f89ff99f875", new DateTime(2020, 4, 7, 13, 35, 23, 475, DateTimeKind.Utc).AddTicks(57), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVABLE", new DateTime(2020, 4, 7, 19, 35, 23, 475, DateTimeKind.Local).AddTicks(65) },
                    { "5140f8f0-42f1-4e5a-a741-6d24d6f81be5", new DateTime(2020, 4, 7, 13, 35, 23, 475, DateTimeKind.Utc).AddTicks(65), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAID", new DateTime(2020, 4, 7, 19, 35, 23, 475, DateTimeKind.Local).AddTicks(86) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sales_ItemCategoryId",
                table: "Sales",
                column: "ItemCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_ItemId",
                table: "Sales",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_ItemCategoryId",
                table: "Purchase",
                column: "ItemCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_ItemId",
                table: "Purchase",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_InvoiceTypeId",
                table: "Invoice",
                column: "InvoiceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Income_IncomeTypeId",
                table: "Income",
                column: "IncomeTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Expense_ExpenseTypeId",
                table: "Expense",
                column: "ExpenseTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Expense_ExpenseType_ExpenseTypeId",
                table: "Expense",
                column: "ExpenseTypeId",
                principalTable: "ExpenseType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Income_IncomeType_IncomeTypeId",
                table: "Income",
                column: "IncomeTypeId",
                principalTable: "IncomeType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoice_InvoiceType_InvoiceTypeId",
                table: "Invoice",
                column: "InvoiceTypeId",
                principalTable: "InvoiceType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_ItemCategory_ItemCategoryId",
                table: "Purchase",
                column: "ItemCategoryId",
                principalTable: "ItemCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_Item_ItemId",
                table: "Purchase",
                column: "ItemId",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_ItemCategory_ItemCategoryId",
                table: "Sales",
                column: "ItemCategoryId",
                principalTable: "ItemCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Item_ItemId",
                table: "Sales",
                column: "ItemId",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expense_ExpenseType_ExpenseTypeId",
                table: "Expense");

            migrationBuilder.DropForeignKey(
                name: "FK_Income_IncomeType_IncomeTypeId",
                table: "Income");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoice_InvoiceType_InvoiceTypeId",
                table: "Invoice");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_ItemCategory_ItemCategoryId",
                table: "Purchase");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_Item_ItemId",
                table: "Purchase");

            migrationBuilder.DropForeignKey(
                name: "FK_Sales_ItemCategory_ItemCategoryId",
                table: "Sales");

            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Item_ItemId",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Sales_ItemCategoryId",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Sales_ItemId",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Purchase_ItemCategoryId",
                table: "Purchase");

            migrationBuilder.DropIndex(
                name: "IX_Purchase_ItemId",
                table: "Purchase");

            migrationBuilder.DropIndex(
                name: "IX_Invoice_InvoiceTypeId",
                table: "Invoice");

            migrationBuilder.DropIndex(
                name: "IX_Income_IncomeTypeId",
                table: "Income");

            migrationBuilder.DropIndex(
                name: "IX_Expense_ExpenseTypeId",
                table: "Expense");

            migrationBuilder.DeleteData(
                table: "Factory",
                keyColumn: "Id",
                keyValue: "34b42c41-09a8-471c-bd78-37cffa8ae531");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "3074f980-94ae-4d62-b44f-63585ba618f7");

            migrationBuilder.DeleteData(
                table: "ItemStatus",
                keyColumn: "Id",
                keyValue: "acd3ab5c-6c71-4716-92f5-8fcd72dfaa79");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "5140f8f0-42f1-4e5a-a741-6d24d6f81be5");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "722dc016-4093-448c-8610-0207a08b265b");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "79a3ff2a-ff6e-49e2-9926-1f89ff99f875");

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "Id",
                keyValue: "bf0385c0-ca07-4a3c-9c90-7127b381c259");

            migrationBuilder.DropColumn(
                name: "OccurranceDate",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "OccurranceDate",
                table: "Purchase");

            migrationBuilder.DropColumn(
                name: "EquipmentId",
                table: "Production");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "Production");

            migrationBuilder.DropColumn(
                name: "AmountPaid",
                table: "Invoice");

            migrationBuilder.RenameColumn(
                name: "UnitPrice",
                table: "Production",
                newName: "RatePerProduct");

            migrationBuilder.AddColumn<string>(
                name: "MachineId",
                table: "Production",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductId",
                table: "Production",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "IncomeTypeId",
                table: "Income",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Factory",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "ImageUrl", "LicenseNo", "Name", "RegNo", "RowStatus", "SubscriptionEnd", "SubscriptionStart", "UpdatedDateTime", "VatRegNo" },
                values: new object[] { "ecd834c4-d468-4f59-aaf5-7c57c21e0856", new DateTime(2020, 3, 31, 21, 26, 27, 722, DateTimeKind.Local).AddTicks(8452), "fe7baa79-f26e-4c29-96b4-1120f2672710", "", "", "Fazlu Loom Factory", "", "ADDED", new DateTime(2022, 12, 26, 21, 26, 27, 723, DateTimeKind.Local).AddTicks(6314), new DateTime(2020, 3, 31, 21, 26, 27, 723, DateTimeKind.Local).AddTicks(4913), new DateTime(2020, 3, 31, 21, 26, 27, 723, DateTimeKind.Local).AddTicks(7607), "" });

            migrationBuilder.InsertData(
                table: "ItemStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "Name", "RowStatus", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "0f0fd2f1-2527-4f68-9814-be250e1e95d9", new DateTime(2020, 3, 31, 15, 26, 27, 763, DateTimeKind.Utc).AddTicks(5727), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "GOOD", "ADDED", new DateTime(2020, 3, 31, 15, 26, 27, 763, DateTimeKind.Utc).AddTicks(8120) },
                    { "a9f1f637-d9f1-4226-8b5d-b9c4fbcc7af4", new DateTime(2020, 3, 31, 15, 26, 27, 763, DateTimeKind.Utc).AddTicks(8169), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "BAD", "ADDED", new DateTime(2020, 3, 31, 15, 26, 27, 763, DateTimeKind.Utc).AddTicks(8214) }
                });

            migrationBuilder.InsertData(
                table: "PaymentStatus",
                columns: new[] { "Id", "CreatedDateTime", "FactoryId", "RowStatus", "Status", "UpdatedDateTime" },
                values: new object[,]
                {
                    { "f97b64a2-bb06-42c8-a522-235f20c318ff", new DateTime(2020, 3, 31, 15, 26, 27, 772, DateTimeKind.Utc).AddTicks(3501), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVED", new DateTime(2020, 3, 31, 21, 26, 27, 772, DateTimeKind.Local).AddTicks(4881) },
                    { "42f8062e-e0ef-4338-9392-e282e5d0446d", new DateTime(2020, 3, 31, 15, 26, 27, 772, DateTimeKind.Utc).AddTicks(4947), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAYABLE", new DateTime(2020, 3, 31, 21, 26, 27, 772, DateTimeKind.Local).AddTicks(5004) },
                    { "e18cda76-5590-44bb-bce2-db9d2b4256d2", new DateTime(2020, 3, 31, 15, 26, 27, 772, DateTimeKind.Utc).AddTicks(5009), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_RECIEVABLE", new DateTime(2020, 3, 31, 21, 26, 27, 772, DateTimeKind.Local).AddTicks(5037) },
                    { "08be1bd0-cf41-4a77-a227-019d4e6a4054", new DateTime(2020, 3, 31, 15, 26, 27, 772, DateTimeKind.Utc).AddTicks(5041), "c90a9cdf-ca6b-4f74-b9f6-d00cd37b1b30", "ADDED", "CASH_PAID", new DateTime(2020, 3, 31, 21, 26, 27, 772, DateTimeKind.Local).AddTicks(5050) }
                });
        }
    }
}
