using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiService.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(nullable: false),
                    FactoryId = table.Column<string>(maxLength: 50, nullable: false),
                    RowStatus = table.Column<string>(maxLength: 50, nullable: false),
                    UniqueId = table.Column<string>(maxLength: 50, nullable: false),
                    RelatedId = table.Column<string>(maxLength: 50, nullable: false),
                    PermanentAddress = table.Column<string>(maxLength: 100, nullable: true),
                    PresentAddress = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(nullable: false),
                    FactoryId = table.Column<string>(maxLength: 50, nullable: false),
                    RowStatus = table.Column<string>(maxLength: 50, nullable: false),
                    UniqueId = table.Column<string>(maxLength: 50, nullable: true),
                    Name = table.Column<string>(maxLength: 150, nullable: true),
                    ImageUrl = table.Column<string>(maxLength: 250, nullable: true),
                    Email = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(nullable: false),
                    FactoryId = table.Column<string>(maxLength: 50, nullable: false),
                    RowStatus = table.Column<string>(maxLength: 50, nullable: false),
                    UniqueId = table.Column<string>(maxLength: 50, nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Equipment",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(nullable: false),
                    FactoryId = table.Column<string>(maxLength: 50, nullable: false),
                    RowStatus = table.Column<string>(maxLength: 50, nullable: false),
                    UniqueId = table.Column<string>(maxLength: 50, nullable: true),
                    Number = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18, 0)", nullable: false),
                    Description = table.Column<string>(maxLength: 50, nullable: true),
                    EquipmentCategoryId = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentCategory",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(nullable: false),
                    FactoryId = table.Column<string>(maxLength: 50, nullable: false),
                    RowStatus = table.Column<string>(maxLength: 50, nullable: false),
                    UniqueId = table.Column<string>(maxLength: 50, nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Expense",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(nullable: false),
                    FactoryId = table.Column<string>(maxLength: 50, nullable: false),
                    RowStatus = table.Column<string>(maxLength: 50, nullable: false),
                    UniqueId = table.Column<string>(maxLength: 50, nullable: true),
                    ExpenseTypeId = table.Column<string>(maxLength: 50, nullable: false),
                    ClientId = table.Column<string>(maxLength: 50, nullable: true),
                    InvoiceId = table.Column<string>(maxLength: 50, nullable: true),
                    Month = table.Column<string>(maxLength: 50, nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18, 0)", nullable: true),
                    Description = table.Column<string>(maxLength: 50, nullable: true),
                    OccurranceDate = table.Column<DateTime>(nullable: true),
                    EmployeeId = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expense", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExpenseType",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(nullable: false),
                    FactoryId = table.Column<string>(maxLength: 50, nullable: false),
                    RowStatus = table.Column<string>(maxLength: 50, nullable: false),
                    UniqueId = table.Column<string>(maxLength: 50, nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpenseType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Factory",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(nullable: false),
                    FactoryId = table.Column<string>(nullable: true),
                    RowStatus = table.Column<string>(maxLength: 50, nullable: false),
                    UniqueId = table.Column<string>(maxLength: 50, nullable: true),
                    SubscriptionStart = table.Column<DateTime>(nullable: true),
                    SubscriptionEnd = table.Column<DateTime>(nullable: true),
                    LicenseNo = table.Column<string>(maxLength: 50, nullable: true),
                    RegNo = table.Column<string>(maxLength: 50, nullable: true),
                    VatRegNo = table.Column<string>(maxLength: 50, nullable: true),
                    Name = table.Column<string>(maxLength: 150, nullable: true),
                    ImageUrl = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IncomeType",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(nullable: false),
                    FactoryId = table.Column<string>(maxLength: 50, nullable: false),
                    RowStatus = table.Column<string>(maxLength: 50, nullable: false),
                    UniqueId = table.Column<string>(maxLength: 50, nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncomeType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Invoice",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(nullable: false),
                    FactoryId = table.Column<string>(maxLength: 50, nullable: false),
                    RowStatus = table.Column<string>(maxLength: 50, nullable: false),
                    UniqueId = table.Column<string>(maxLength: 50, nullable: false),
                    ClientId = table.Column<string>(maxLength: 50, nullable: true),
                    InvoiceId = table.Column<string>(maxLength: 50, nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18, 0)", nullable: true),
                    IsDiscountInPercentage = table.Column<bool>(nullable: true),
                    AmountBeforeDiscount = table.Column<string>(maxLength: 50, nullable: false),
                    AmountAfterDiscount = table.Column<string>(maxLength: 50, nullable: false),
                    InvoiceTypeId = table.Column<string>(maxLength: 50, nullable: true),
                    IsFullyPaid = table.Column<bool>(nullable: true),
                    DateOfOcurrance = table.Column<DateTime>(nullable: true),
                    Due = table.Column<decimal>(type: "decimal(18, 0)", nullable: true),
                    DeliveryCost = table.Column<decimal>(type: "decimal(18, 0)", nullable: true),
                    DeliveryAddress = table.Column<string>(maxLength: 50, nullable: true),
                    OtherCost = table.Column<decimal>(type: "decimal(18, 0)", nullable: true),
                    DeliveryDateTime = table.Column<DateTime>(nullable: true),
                    Comment = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoice", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceType",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(nullable: false),
                    FactoryId = table.Column<string>(maxLength: 50, nullable: false),
                    RowStatus = table.Column<string>(maxLength: 50, nullable: false),
                    UniqueId = table.Column<string>(maxLength: 50, nullable: false),
                    TypeName = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(nullable: false),
                    FactoryId = table.Column<string>(maxLength: 50, nullable: false),
                    RowStatus = table.Column<string>(maxLength: 50, nullable: false),
                    UniqueId = table.Column<string>(maxLength: 50, nullable: false),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    CategoryId = table.Column<string>(maxLength: 150, nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18, 0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemCategory",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(nullable: false),
                    FactoryId = table.Column<string>(maxLength: 50, nullable: false),
                    RowStatus = table.Column<string>(maxLength: 50, nullable: false),
                    UniqueId = table.Column<string>(maxLength: 50, nullable: false),
                    Name = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemStatus",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(nullable: false),
                    FactoryId = table.Column<string>(maxLength: 50, nullable: false),
                    RowStatus = table.Column<string>(maxLength: 50, nullable: false),
                    UniqueId = table.Column<string>(maxLength: 50, nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Payable",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(nullable: false),
                    FactoryId = table.Column<string>(maxLength: 50, nullable: false),
                    RowStatus = table.Column<string>(maxLength: 50, nullable: false),
                    UniqueId = table.Column<string>(maxLength: 50, nullable: false),
                    PurposeTypeId = table.Column<string>(maxLength: 50, nullable: false),
                    ClientId = table.Column<string>(maxLength: 50, nullable: false),
                    InvoiceId = table.Column<string>(maxLength: 50, nullable: false),
                    Month = table.Column<string>(maxLength: 50, nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18, 0)", nullable: false),
                    Description = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentStatus",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(nullable: false),
                    FactoryId = table.Column<string>(maxLength: 50, nullable: false),
                    RowStatus = table.Column<string>(maxLength: 50, nullable: false),
                    UniqueId = table.Column<string>(maxLength: 50, nullable: false),
                    Status = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Phone",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(nullable: false),
                    FactoryId = table.Column<string>(maxLength: 50, nullable: false),
                    RowStatus = table.Column<string>(maxLength: 50, nullable: false),
                    UniqueId = table.Column<string>(maxLength: 50, nullable: false),
                    RelatedId = table.Column<string>(maxLength: 50, nullable: false),
                    Type = table.Column<string>(maxLength: 50, nullable: false),
                    Number = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phone", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Production",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(nullable: false),
                    FactoryId = table.Column<string>(maxLength: 50, nullable: false),
                    RowStatus = table.Column<string>(maxLength: 50, nullable: false),
                    UniqueId = table.Column<string>(maxLength: 50, nullable: false),
                    StaffId = table.Column<string>(maxLength: 50, nullable: false),
                    ProductId = table.Column<string>(maxLength: 50, nullable: false),
                    Quantity = table.Column<long>(nullable: false),
                    MachineId = table.Column<string>(maxLength: 50, nullable: true),
                    EntryDate = table.Column<DateTime>(nullable: false),
                    RatePerProduct = table.Column<decimal>(type: "decimal(18, 0)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18, 0)", nullable: false),
                    IsMadeJointly = table.Column<bool>(nullable: true),
                    ProductionId = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Production", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Purchase",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(nullable: false),
                    FactoryId = table.Column<string>(maxLength: 50, nullable: false),
                    RowStatus = table.Column<string>(maxLength: 50, nullable: false),
                    UniqueId = table.Column<string>(maxLength: 50, nullable: false),
                    ClientId = table.Column<string>(maxLength: 50, nullable: false),
                    InvoiceId = table.Column<string>(maxLength: 50, nullable: false),
                    ProductId = table.Column<string>(maxLength: 50, nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18, 0)", nullable: false),
                    Month = table.Column<string>(maxLength: 50, nullable: false),
                    Quantity = table.Column<long>(nullable: false),
                    AmountBeforeDiscount = table.Column<decimal>(type: "decimal(18, 0)", nullable: false),
                    AmountPaid = table.Column<decimal>(type: "decimal(18, 0)", nullable: false),
                    AmountDue = table.Column<decimal>(type: "decimal(18, 0)", nullable: false),
                    AmountAfterDiscount = table.Column<decimal>(type: "decimal(18, 0)", nullable: false),
                    IsDiscountInPercentage = table.Column<bool>(nullable: true),
                    IsPaid = table.Column<bool>(nullable: true),
                    Description = table.Column<string>(maxLength: 50, nullable: true),
                    SalesDate = table.Column<DateTime>(nullable: false),
                    EmployeeId = table.Column<string>(maxLength: 50, nullable: true),
                    PurchaseId = table.Column<string>(maxLength: 50, nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18, 0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchase", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseType",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(nullable: false),
                    FactoryId = table.Column<string>(maxLength: 50, nullable: false),
                    RowStatus = table.Column<string>(maxLength: 50, nullable: false),
                    UniqueId = table.Column<string>(maxLength: 50, nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recievable",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(nullable: false),
                    FactoryId = table.Column<string>(maxLength: 50, nullable: false),
                    RowStatus = table.Column<string>(maxLength: 50, nullable: false),
                    UniqueId = table.Column<string>(maxLength: 50, nullable: false),
                    PurposeTypeId = table.Column<string>(maxLength: 50, nullable: false),
                    ClientId = table.Column<string>(maxLength: 50, nullable: false),
                    InvoiceId = table.Column<string>(maxLength: 50, nullable: false),
                    Month = table.Column<string>(maxLength: 50, nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18, 0)", nullable: false),
                    Description = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recievable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(nullable: false),
                    FactoryId = table.Column<string>(maxLength: 50, nullable: false),
                    RowStatus = table.Column<string>(maxLength: 50, nullable: false),
                    UniqueId = table.Column<string>(maxLength: 50, nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(nullable: false),
                    FactoryId = table.Column<string>(maxLength: 50, nullable: false),
                    RowStatus = table.Column<string>(maxLength: 50, nullable: false),
                    UniqueId = table.Column<string>(maxLength: 50, nullable: false),
                    ClientId = table.Column<string>(maxLength: 50, nullable: false),
                    InvoiceId = table.Column<string>(maxLength: 50, nullable: false),
                    ProductId = table.Column<string>(maxLength: 50, nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18, 0)", nullable: false),
                    Month = table.Column<string>(maxLength: 50, nullable: false),
                    Quantity = table.Column<long>(nullable: false),
                    AmountBeforeDiscount = table.Column<decimal>(type: "decimal(18, 0)", nullable: false),
                    AmountPaid = table.Column<decimal>(type: "decimal(18, 0)", nullable: false),
                    AmountDue = table.Column<decimal>(type: "decimal(18, 0)", nullable: false),
                    AmountAfterDiscount = table.Column<decimal>(type: "decimal(18, 0)", nullable: false),
                    IsDiscountInPercentage = table.Column<bool>(nullable: true),
                    IsPaid = table.Column<bool>(nullable: true),
                    Description = table.Column<string>(maxLength: 50, nullable: true),
                    SalesDate = table.Column<DateTime>(nullable: false),
                    SellerId = table.Column<string>(maxLength: 50, nullable: true),
                    SaleId = table.Column<string>(maxLength: 50, nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18, 0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(nullable: false),
                    FactoryId = table.Column<string>(maxLength: 50, nullable: false),
                    RowStatus = table.Column<string>(maxLength: 50, nullable: false),
                    UniqueId = table.Column<string>(maxLength: 50, nullable: true),
                    Name = table.Column<string>(maxLength: 150, nullable: true),
                    ImageUrl = table.Column<string>(maxLength: 250, nullable: true),
                    Designation = table.Column<string>(nullable: true),
                    Email = table.Column<string>(maxLength: 50, nullable: true),
                    DepartmentId = table.Column<string>(maxLength: 50, nullable: true),
                    Code = table.Column<string>(maxLength: 50, nullable: true),
                    BasicSalary = table.Column<double>(nullable: true),
                    BirthRegistrationNo = table.Column<string>(maxLength: 50, nullable: true),
                    NationalIdNo = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stock",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(nullable: false),
                    FactoryId = table.Column<string>(maxLength: 50, nullable: false),
                    RowStatus = table.Column<string>(maxLength: 50, nullable: false),
                    UniqueId = table.Column<string>(maxLength: 50, nullable: false),
                    ItemId = table.Column<string>(maxLength: 50, nullable: false),
                    Quantity = table.Column<long>(nullable: true),
                    ItemStatusId = table.Column<string>(maxLength: 50, nullable: false),
                    ExpiryDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stock", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StockIn",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(nullable: false),
                    FactoryId = table.Column<string>(maxLength: 50, nullable: false),
                    RowStatus = table.Column<string>(maxLength: 50, nullable: false),
                    UniqueId = table.Column<string>(maxLength: 50, nullable: false),
                    ItemId = table.Column<string>(maxLength: 50, nullable: false),
                    SupplierId = table.Column<string>(maxLength: 50, nullable: false),
                    InvoiceId = table.Column<string>(maxLength: 50, nullable: false),
                    BatchNumber = table.Column<string>(maxLength: 50, nullable: false),
                    Quantity = table.Column<long>(nullable: true),
                    Unitprice = table.Column<decimal>(type: "decimal(18, 0)", nullable: true),
                    ItemStatusId = table.Column<string>(maxLength: 50, nullable: false),
                    ExpiryDate = table.Column<DateTime>(nullable: false),
                    AddedDateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockIn", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StockOut",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(nullable: false),
                    FactoryId = table.Column<string>(maxLength: 50, nullable: false),
                    RowStatus = table.Column<string>(maxLength: 50, nullable: false),
                    UniqueId = table.Column<string>(maxLength: 50, nullable: false),
                    ItemId = table.Column<string>(maxLength: 50, nullable: false),
                    ExecutorId = table.Column<string>(maxLength: 50, nullable: false),
                    InvoiceId = table.Column<string>(maxLength: 50, nullable: false),
                    BatchNumber = table.Column<string>(maxLength: 50, nullable: false),
                    Quantity = table.Column<long>(nullable: true),
                    ItemStatusId = table.Column<string>(maxLength: 50, nullable: false),
                    ExpiryDate = table.Column<DateTime>(nullable: false),
                    CurrentDateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockOut", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(nullable: false),
                    FactoryId = table.Column<string>(maxLength: 50, nullable: false),
                    RowStatus = table.Column<string>(maxLength: 50, nullable: false),
                    UniqueId = table.Column<string>(maxLength: 50, nullable: true),
                    Name = table.Column<string>(maxLength: 150, nullable: true),
                    ImageUrl = table.Column<string>(maxLength: 250, nullable: true),
                    Email = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transaction",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(nullable: false),
                    FactoryId = table.Column<string>(maxLength: 50, nullable: false),
                    RowStatus = table.Column<string>(maxLength: 50, nullable: false),
                    UniqueId = table.Column<string>(maxLength: 50, nullable: false),
                    InvoiceId = table.Column<string>(maxLength: 50, nullable: true),
                    Amount = table.Column<string>(maxLength: 50, nullable: false),
                    ExecutorId = table.Column<string>(maxLength: 50, nullable: false),
                    ClientId = table.Column<string>(maxLength: 50, nullable: false),
                    PaymentStatusId = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 50, nullable: true),
                    TransactionTypeId = table.Column<string>(maxLength: 50, nullable: false),
                    Month = table.Column<string>(maxLength: 50, nullable: false),
                    Purpose = table.Column<string>(maxLength: 50, nullable: true),
                    TransactionId = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaction", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransactionType",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(nullable: false),
                    FactoryId = table.Column<string>(maxLength: 50, nullable: false),
                    RowStatus = table.Column<string>(maxLength: 50, nullable: false),
                    UniqueId = table.Column<string>(maxLength: 50, nullable: false),
                    TypeName = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserAuthInfo",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(nullable: false),
                    FactoryId = table.Column<string>(maxLength: 50, nullable: false),
                    RowStatus = table.Column<string>(maxLength: 50, nullable: false),
                    UniqueId = table.Column<string>(maxLength: 50, nullable: false),
                    UserId = table.Column<string>(maxLength: 50, nullable: false),
                    UserName = table.Column<string>(maxLength: 50, nullable: false),
                    Password = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAuthInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(nullable: false),
                    FactoryId = table.Column<string>(maxLength: 50, nullable: false),
                    RowStatus = table.Column<string>(maxLength: 50, nullable: false),
                    UniqueId = table.Column<string>(maxLength: 50, nullable: true),
                    UserId = table.Column<string>(maxLength: 50, nullable: false),
                    RoleId = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRole_Factory_FactoryId",
                        column: x => x.FactoryId,
                        principalTable: "Factory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_FactoryId",
                table: "UserRole",
                column: "FactoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "Equipment");

            migrationBuilder.DropTable(
                name: "EquipmentCategory");

            migrationBuilder.DropTable(
                name: "Expense");

            migrationBuilder.DropTable(
                name: "ExpenseType");

            migrationBuilder.DropTable(
                name: "IncomeType");

            migrationBuilder.DropTable(
                name: "Invoice");

            migrationBuilder.DropTable(
                name: "InvoiceType");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "ItemCategory");

            migrationBuilder.DropTable(
                name: "ItemStatus");

            migrationBuilder.DropTable(
                name: "Payable");

            migrationBuilder.DropTable(
                name: "PaymentStatus");

            migrationBuilder.DropTable(
                name: "Phone");

            migrationBuilder.DropTable(
                name: "Production");

            migrationBuilder.DropTable(
                name: "Purchase");

            migrationBuilder.DropTable(
                name: "PurchaseType");

            migrationBuilder.DropTable(
                name: "Recievable");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "Stock");

            migrationBuilder.DropTable(
                name: "StockIn");

            migrationBuilder.DropTable(
                name: "StockOut");

            migrationBuilder.DropTable(
                name: "Supplier");

            migrationBuilder.DropTable(
                name: "Transaction");

            migrationBuilder.DropTable(
                name: "TransactionType");

            migrationBuilder.DropTable(
                name: "UserAuthInfo");

            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.DropTable(
                name: "Factory");
        }
    }
}
