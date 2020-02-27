using Contracts;
using Contracts.EntitywiseContracts;
using Entities.DbModels;
using Repository.EntitywiseRepository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        #region Var Declaration
       public FactoryManagementContext dbContext;
        public IAddressRepository _Address;
        ICustomerRepository _Customer;
        IDepartmentRepository _Department;
        IEquipmentRepository _Equipment;
        IEquipmentCategoryRepository _EquipmentCategory;
        IExpenseRepository _Expense;
        IExpenseTypeRepository _ExpenseType;
        IFactoryRepository _Factory;
        IIncomeTypeRepository _IncomeType;
        IInvoiceRepository _Invoice;
        IInvoiceTypeRepository _InvoiceType;
        IItemRepository _Item;
        IItemCategoryRepository _ItemCategory;
        IItemStatusRepository _ItemStatus;
        IPayableRepository _Payable;
        IPaymentStatusRepository _PaymentStatus;
        IPhoneRepository _Phone;
        IProductionRepository _Production;
        IPurchaseRepository _Purchase;
        IPurchaseTypeRepository _PurchaseType;
        IRecievableRepository _Recievable;
        IRoleRepository _Role;
        ISalesRepository _Sales;
        IStaffRepository _Staff;
        IStockRepository _Stock;
        IStockInRepository _StockIn;
        IStockOutRepository _StockOut;
        ISupplierRepository _Supplier;
        ITransactionRepository _Transaction;
        ITransactionTypeRepository _TransactionType;
        IUserAuthInfoRepository _UserAuthInfo;
        IUserRoleRepository _UserRole;
        #endregion
        public RepositoryWrapper(
            FactoryManagementContext context,
            ICustomerRepository customerRepository,
            IAddressRepository addressRepository,
            IPhoneRepository phoneRepository)
        {
            this.dbContext = context;
            this._Address = addressRepository;
            this._Customer = customerRepository;
            this._Phone = phoneRepository;
        }


        public IAddressRepository Address
        {
            get
            {
                if (_Address == null)
                {
                    //return new AddressRepository(dbContext);
                    _Address = new AddressRepository(dbContext);
                }
                return _Address;
            }
        }
        public ICustomerRepository Customer
        {

            get
            {

                if (_Customer == null)
                {
                    //return new CustomerRepository(dbContext);
                    _Customer = new CustomerRepository(dbContext);
                }

                return _Customer;

            }

        }
        public IDepartmentRepository Department
        {

            get
            {

                if (_Department == null)
                {
                    //return new DepartmentRepository(dbContext);
                    _Department = new DepartmentRepository(dbContext);
                }

                return _Department;

            }

        }
        public IEquipmentRepository Equipment
        {

            get
            {

                if (_Equipment == null)
                {
                    //return new EquipmentRepository(dbContext);
                    _Equipment = new EquipmentRepository(dbContext);
                }

                return _Equipment;

            }

        }
        public IEquipmentCategoryRepository EquipmentCategory
        {

            get
            {

                if (_EquipmentCategory == null)
                {
                    //return new EquipmentCategoryRepository(dbContext);
                    _EquipmentCategory = new EquipmentCategoryRepository(dbContext);
                }

                return _EquipmentCategory;

            }

        }
        public IExpenseRepository Expense
        {

            get
            {

                if (_Expense == null)
                {
                    //return new ExpenseRepository(dbContext);
                    _Expense = new ExpenseRepository(dbContext);
                }

                return _Expense;

            }

        }
        public IExpenseTypeRepository ExpenseType
        {

            get
            {

                if (_ExpenseType == null)
                {
                    //return new ExpenseTypeRepository(dbContext);
                    _ExpenseType = new ExpenseTypeRepository(dbContext);
                }

                return _ExpenseType;

            }

        }
        public IFactoryRepository Factory
        {

            get
            {

                if (_Factory == null)
                {
                    //return new FactoryRepository(dbContext);
                    _Factory = new FactoryRepository(dbContext);
                }

                return _Factory;

            }

        }
        public IIncomeTypeRepository IncomeType
        {

            get
            {

                if (_IncomeType == null)
                {
                    //return new IncomeTypeRepository(dbContext);
                    _IncomeType = new IncomeTypeRepository(dbContext);
                }

                return _IncomeType;

            }

        }
        public IInvoiceRepository Invoice
        {

            get
            {

                if (_Invoice == null)
                {
                    //return new InvoiceRepository(dbContext);
                    _Invoice = new InvoiceRepository(dbContext);
                }

                return _Invoice;

            }

        }
        public IInvoiceTypeRepository InvoiceType
        {

            get
            {

                if (_InvoiceType == null)
                {
                    //return new InvoiceTypeRepository(dbContext);
                    _InvoiceType = new InvoiceTypeRepository(dbContext);
                }

                return _InvoiceType;

            }

        }
        public IItemRepository Item
        {

            get
            {

                if (_Item == null)
                {
                    //return new ItemRepository(dbContext);
                    _Item = new ItemRepository(dbContext);
                }

                return _Item;

            }

        }
        public IItemCategoryRepository ItemCategory
        {

            get
            {

                if (_ItemCategory == null)
                {
                    //return new ItemCategoryRepository(dbContext);
                    _ItemCategory = new ItemCategoryRepository(dbContext);
                }

                return _ItemCategory;

            }

        }
        public IItemStatusRepository ItemStatus
        {

            get
            {

                if (_ItemStatus == null)
                {
                    //return new ItemStatusRepository(dbContext);
                    _ItemStatus = new ItemStatusRepository(dbContext);
                }

                return _ItemStatus;

            }

        }
        public IPayableRepository Payable
        {

            get
            {

                if (_Payable == null)
                {
                    //return new PayableRepository(dbContext);
                    _Payable = new PayableRepository(dbContext);
                }

                return _Payable;

            }

        }
        public IPaymentStatusRepository PaymentStatus
        {

            get
            {

                if (_PaymentStatus == null)
                {
                    //return new PaymentStatusRepository(dbContext);
                    _PaymentStatus = new PaymentStatusRepository(dbContext);
                }

                return _PaymentStatus;

            }

        }
        public IPhoneRepository Phone
        {

            get
            {

                if (_Phone == null)
                {
                    //return new PhoneRepository(dbContext);
                    _Phone = new PhoneRepository(dbContext);
                }

                return _Phone;

            }

        }
        public IProductionRepository Production
        {

            get
            {

                if (_Production == null)
                {
                    //return new ProductionRepository(dbContext);
                    _Production = new ProductionRepository(dbContext);
                }

                return _Production;

            }

        }
        public IPurchaseRepository Purchase
        {

            get
            {

                if (_Purchase == null)
                {
                    //return new PurchaseRepository(dbContext);
                    _Purchase = new PurchaseRepository(dbContext);
                }

                return _Purchase;

            }

        }
        public IPurchaseTypeRepository PurchaseType
        {

            get
            {

                if (_PurchaseType == null)
                {
                    //return new PurchaseTypeRepository(dbContext);
                    _PurchaseType = new PurchaseTypeRepository(dbContext);
                }

                return _PurchaseType;

            }

        }
        public IRecievableRepository Recievable
        {

            get
            {

                if (_Recievable == null)
                {
                    //return new RecievableRepository(dbContext);
                    _Recievable = new RecievableRepository(dbContext);
                }

                return _Recievable;

            }

        }
        public IRoleRepository Role
        {

            get
            {

                if (_Role == null)
                {
                    //return new RoleRepository(dbContext);
                    _Role = new RoleRepository(dbContext);
                }

                return _Role;

            }

        }
        public ISalesRepository Sales
        {

            get
            {

                if (_Sales == null)
                {
                    //return new SalesRepository(dbContext);
                    _Sales = new SalesRepository(dbContext);
                }

                return _Sales;

            }

        }
        public IStaffRepository Staff
        {

            get
            {

                if (_Staff == null)
                {
                    //return new StaffRepository(dbContext);
                    _Staff = new StaffRepository(dbContext);
                }

                return _Staff;

            }

        }
        public IStockRepository Stock
        {

            get
            {

                if (_Stock == null)
                {
                    //return new StockRepository(dbContext);
                    _Stock = new StockRepository(dbContext);
                }

                return _Stock;

            }

        }
        public IStockInRepository StockIn
        {

            get
            {

                if (_StockIn == null)
                {
                    //return new StockInRepository(dbContext);
                    _StockIn = new StockInRepository(dbContext);
                }

                return _StockIn;

            }

        }
        public IStockOutRepository StockOut
        {

            get
            {

                if (_StockOut == null)
                {
                    //return new StockOutRepository(dbContext);
                    _StockOut = new StockOutRepository(dbContext);
                }

                return _StockOut;

            }

        }
        public ISupplierRepository Supplier
        {

            get
            {

                if (_Supplier == null)
                {
                    //return new SupplierRepository(dbContext);
                    _Supplier = new SupplierRepository(dbContext);
                }

                return _Supplier;

            }

        }
        public ITransactionRepository Transaction
        {

            get
            {

                if (_Transaction == null)
                {
                    //return new TransactionRepository(dbContext);
                    _Transaction = new TransactionRepository(dbContext);
                }

                return _Transaction;

            }

        }
        public ITransactionTypeRepository TransactionType
        {

            get
            {

                if (_TransactionType == null)
                {
                    //return new TransactionTypeRepository(dbContext);
                    _TransactionType = new TransactionTypeRepository(dbContext);
                }

                return _TransactionType;

            }

        }
        public IUserAuthInfoRepository UserAuthInfo
        {

            get
            {

                if (_UserAuthInfo == null)
                {
                    //return new UserAuthInfoRepository(dbContext);
                    _UserAuthInfo = new UserAuthInfoRepository(dbContext);
                }

                return _UserAuthInfo;

            }

        }
        public IUserRoleRepository UserRole
        {

            get
            {

                if (_UserRole == null)
                {
                    //return new UserRoleRepository(dbContext);
                    _UserRole = new UserRoleRepository(dbContext);
                }

                return _UserRole;

            }

        }
        public void Save()
        {
            dbContext.SaveChanges();
        }

        public async Task SaveAsync()
        {
           await dbContext.SaveChangesAsync();
        }
    }
}
