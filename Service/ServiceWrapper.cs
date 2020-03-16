using AutoMapper;
using Contracts;
using Contracts.ServiceContracts;
using Service.BusinessServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class ServiceWrapper : IServiceWrapper
    {

        IAddressService _AddressService;
        ICustomerService _CustomerService;
        IDepartmentService _DepartmentService;
        IEquipmentService _EquipmentService;
        IEquipmentCategoryService _EquipmentCategoryService;
        IExpenseService _ExpenseService;
        IExpenseTypeService _ExpenseTypeService;
        IFactoryService _FactoryService;
        IIncomeTypeService _IncomeTypeService;
        IInvoiceService _InvoiceService;
        IInvoiceTypeService _InvoiceTypeService;
        IItemService _ItemService;
        IItemCategoryService _ItemCategoryService;
        IItemStatusService _ItemStatusService;
        IPayableService _PayableService;
        IPaymentStatusService _PaymentStatusService;
        IPhoneService _PhoneService;
        IProductionService _ProductionService;
        IPurchaseService _PurchaseService;
        IPurchaseTypeService _PurchaseTypeService;
        IRecievableService _RecievableService;
        IRoleService _RoleService;
        ISalesService _SalesService;
        IStaffService _StaffService;
        IStockService _StockService;
        IStockInService _StockInService;
        IStockOutService _StockOutService;
        ISupplierService _SupplierService;
        ITransactionService _TransactionService;
        ITransactionTypeService _TransactionTypeService;
        IUserAuthInfoService _UserAuthInfoService;
        IUserRoleService _UserRoleService;
        IRepositoryWrapper _repositoryWrapper;
        IMapper _mapper;
        ILoggerManager _loggerManager;
        IUtilService _utilService;
        public ServiceWrapper(IRepositoryWrapper repositoryWrapper,IMapper mapper,ILoggerManager loggerManager, IUtilService utilService)
        {
            this._repositoryWrapper = repositoryWrapper; 
            this._mapper = mapper;
            this._loggerManager = loggerManager;
            this._utilService = utilService;
        }


        public ICustomerService CustomerService
        {
            get
            {
                if (_CustomerService == null)
                {
                    //return new AddressRepository(dbContext);
                    _CustomerService = new CustomerService(_repositoryWrapper, _mapper,_loggerManager,_utilService);
                }
                return _CustomerService;
            }
        }

        public IAddressService AddressService
        {
            get
            {
                if (_AddressService == null)
                {
                    _AddressService = new AddressService(_repositoryWrapper, _mapper, _utilService);
                }
                return _AddressService;
            }

        }
        public IDepartmentService DepartmentService
        {
            get
            {
                if (_DepartmentService == null)
                {
                    _DepartmentService = new DepartmentService(_repositoryWrapper, _mapper, _utilService);
                }
                return _DepartmentService;
            }

        }
        public IEquipmentService EquipmentService
        {
            get
            {
                if (_EquipmentService == null)
                {
                    _EquipmentService = new EquipmentService(_repositoryWrapper, _mapper, _utilService);
                }
                return _EquipmentService;
            }

        }
        public IEquipmentCategoryService EquipmentCategoryService
        {
            get
            {
                if (_EquipmentCategoryService == null)
                {
                    _EquipmentCategoryService = new EquipmentCategoryService(_repositoryWrapper, _mapper, _utilService);
                }
                return _EquipmentCategoryService;
            }

        }
        public IExpenseService ExpenseService
        {
            get
            {
                if (_ExpenseService == null)
                {
                    _ExpenseService = new ExpenseService(_repositoryWrapper, _mapper, _utilService);
                }
                return _ExpenseService;
            }

        }
        public IExpenseTypeService ExpenseTypeService
        {
            get
            {
                if (_ExpenseTypeService == null)
                {
                    _ExpenseTypeService = new ExpenseTypeService(_repositoryWrapper, _mapper, _utilService);
                }
                return _ExpenseTypeService;
            }

        }
        public IFactoryService FactoryService
        {
            get
            {
                if (_FactoryService == null)
                {
                    _FactoryService = new FactoryService(_repositoryWrapper, _mapper, _utilService);
                }
                return _FactoryService;
            }

        }
        public IIncomeTypeService IncomeTypeService
        {
            get
            {
                if (_IncomeTypeService == null)
                {
                    _IncomeTypeService = new IncomeTypeService(_repositoryWrapper, _mapper, _utilService);
                }
                return _IncomeTypeService;
            }

        }
        public IInvoiceService InvoiceService
        {
            get
            {
                if (_InvoiceService == null)
                {
                    _InvoiceService = new InvoiceService(_repositoryWrapper, _mapper, _utilService);
                }
                return _InvoiceService;
            }

        }
        public IInvoiceTypeService InvoiceTypeService
        {
            get
            {
                if (_InvoiceTypeService == null)
                {
                    _InvoiceTypeService = new InvoiceTypeService(_repositoryWrapper, _mapper, _utilService);
                }
                return _InvoiceTypeService;
            }

        }
        public IItemService ItemService
        {
            get
            {
                if (_ItemService == null)
                {
                    _ItemService = new ItemService(_repositoryWrapper, _mapper, _loggerManager, _utilService);
                }
                return _ItemService;
            }

        }
        public IItemCategoryService ItemCategoryService
        {
            get
            {
                if (_ItemCategoryService == null)
                {
                    _ItemCategoryService = new ItemCategoryService(_repositoryWrapper, _mapper, _loggerManager, _utilService);
                }
                return _ItemCategoryService;
            }

        }
        public IItemStatusService ItemStatusService
        {
            get
            {
                if (_ItemStatusService == null)
                {
                    _ItemStatusService = new ItemStatusService(_repositoryWrapper, _mapper, _utilService);
                }
                return _ItemStatusService;
            }

        }
        public IPayableService PayableService
        {
            get
            {
                if (_PayableService == null)
                {
                    _PayableService = new PayableService(_repositoryWrapper, _mapper, _utilService);
                }
                return _PayableService;
            }

        }
        public IPaymentStatusService PaymentStatusService
        {
            get
            {
                if (_PaymentStatusService == null)
                {
                    _PaymentStatusService = new PaymentStatusService(_repositoryWrapper, _mapper, _utilService);
                }
                return _PaymentStatusService;
            }

        }
        public IPhoneService PhoneService
        {
            get
            {
                if (_PhoneService == null)
                {
                    _PhoneService = new PhoneService(_repositoryWrapper, _mapper, _utilService);
                }
                return _PhoneService;
            }

        }
        public IProductionService ProductionService
        {
            get
            {
                if (_ProductionService == null)
                {
                    _ProductionService = new ProductionService(_repositoryWrapper, _mapper, _utilService);
                }
                return _ProductionService;
            }

        }
        public IPurchaseService PurchaseService
        {
            get
            {
                if (_PurchaseService == null)
                {
                    _PurchaseService = new PurchaseService(_repositoryWrapper, _mapper, _utilService);
                }
                return _PurchaseService;
            }

        }
        public IPurchaseTypeService PurchaseTypeService
        {
            get
            {
                if (_PurchaseTypeService == null)
                {
                    _PurchaseTypeService = new PurchaseTypeService(_repositoryWrapper, _mapper, _utilService);
                }
                return _PurchaseTypeService;
            }

        }
        public IRecievableService RecievableService
        {
            get
            {
                if (_RecievableService == null)
                {
                    _RecievableService = new RecievableService(_repositoryWrapper, _mapper, _utilService);
                }
                return _RecievableService;
            }

        }
        public IRoleService RoleService
        {
            get
            {
                if (_RoleService == null)
                {
                    _RoleService = new RoleService(_repositoryWrapper, _mapper, _utilService);
                }
                return _RoleService;
            }

        }
        public ISalesService SalesService
        {
            get
            {
                if (_SalesService == null)
                {
                    _SalesService = new SalesService(_repositoryWrapper, _mapper, _utilService);
                }
                return _SalesService;
            }

        }
        public IStaffService StaffService
        {
            get
            {
                if (_StaffService == null)
                {
                    _StaffService = new StaffService(_repositoryWrapper, _mapper, _utilService);
                }
                return _StaffService;
            }

        }
        public IStockService StockService
        {
            get
            {
                if (_StockService == null)
                {
                    _StockService = new StockService(_repositoryWrapper, _mapper, _utilService);
                }
                return _StockService;
            }

        }
        public IStockInService StockInService
        {
            get
            {
                if (_StockInService == null)
                {
                    _StockInService = new StockInService(_repositoryWrapper, _mapper, _utilService);
                }
                return _StockInService;
            }

        }
        public IStockOutService StockOutService
        {
            get
            {
                if (_StockOutService == null)
                {
                    _StockOutService = new StockOutService(_repositoryWrapper, _mapper, _utilService);
                }
                return _StockOutService;
            }

        }
        public ISupplierService SupplierService
        {
            get
            {
                if (_SupplierService == null)
                {
                    _SupplierService = new SupplierService(_repositoryWrapper, _mapper, _utilService);
                }
                return _SupplierService;
            }

        }
        public ITransactionService TransactionService
        {
            get
            {
                if (_TransactionService == null)
                {
                    _TransactionService = new TransactionService(_repositoryWrapper, _mapper, _utilService);
                }
                return _TransactionService;
            }

        }
        public ITransactionTypeService TransactionTypeService
        {
            get
            {
                if (_TransactionTypeService == null)
                {
                    _TransactionTypeService = new TransactionTypeService(_repositoryWrapper, _mapper, _utilService);
                }
                return _TransactionTypeService;
            }

        }
        public IUserAuthInfoService UserAuthInfoService
        {
            get
            {
                if (_UserAuthInfoService == null)
                {
                    _UserAuthInfoService = new UserAuthInfoService(_repositoryWrapper, _mapper, _utilService);
                }
                return _UserAuthInfoService;
            }

        }
        public IUserRoleService UserRoleService
        {
            get
            {
                if (_UserRoleService == null)
                {
                    _UserRoleService = new UserRoleService(_repositoryWrapper, _mapper, _utilService);
                }
                return _UserRoleService;
            }

        }

    }
}
