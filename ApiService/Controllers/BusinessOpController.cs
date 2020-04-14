using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommonUtils;
using Contracts;
using Entities.DbModels;
using Entities.ViewModels;
using Entities.ViewModels.CustomerView;
using Entities.ViewModels.Payment;
using Entities.ViewModels.Production;
using Entities.ViewModels.Purchase;
using Entities.ViewModels.Sales;
using Entities.ViewModels.Staff;
using Entities.ViewModels.Supplier;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiService.Controllers
{
    [Route("api/business")]
    [ApiController]
    public class BusinessOpController : ControllerBase
    {
        private readonly FactoryManagementContext _context;
        private readonly IRepositoryWrapper _repositoryWrapper;
        private readonly IServiceWrapper _serviceWrapper;
        private readonly ILoggerManager _logger;
        private readonly IUtilService _utilService;
        private readonly IBusinessService _businessService;
        public BusinessOpController(
            FactoryManagementContext context,
            IRepositoryWrapper repositoryWrapper,
            IServiceWrapper serviceWrapper,
            ILoggerManager logger,
            IUtilService utilService,
            IBusinessService businessService)
        {
            _context = context;
            _repositoryWrapper = repositoryWrapper;
            _serviceWrapper = serviceWrapper;
            _logger = logger;
            _utilService = utilService;
            _businessService = businessService;
        }


        #region Purchase
        [HttpPost]
        [Route("purchase/getInitData")]
        public async Task<ActionResult<InitialLoadDataVM>> GetPurchaseInitData([FromBody]GetDataListVM getDataVM)
        {
            return await _businessService.PurchaseServiceWrapper.GetPurchaseInitialData(getDataVM);
        }


        [HttpPost]
        [Route("purchase/add")]
        public async Task AddPurchase([FromBody]PurchaseVM purchase)
        {
             await _serviceWrapper.PurchaseService.AddPurchaseAsync(purchase);       
        }

        #endregion
   
        
        #region Sales
        [HttpPost]
        [Route("sales/getInitData")]
        public async Task<ActionResult<InitialLoadDataVM>> GetSalesInitData([FromBody]GetDataListVM getDataVM)
        {
            return await _businessService.PurchaseServiceWrapper.GetSalesInitialData(getDataVM);
        }

        [HttpPost]
        [Route("sales/add")]
        public async Task AddSales([FromBody]SalesVM sales)
        {
             await _serviceWrapper.SalesService.AddSalesAsync(sales);
        }

        #endregion
        
        
        #region Payment
       
        #region Supplier
        [HttpPost]
        [Route("supplier/payment")]
        public async Task<WrapperPaymentListVM> SupplierPay([FromBody]PaymentVM vm)
        {
            return await _businessService.BusinessWrapperService.PayToSupplier(vm);
        }
        [HttpPost]
        [Route("supplier/payment/list")]
        public async Task<WrapperPaymentListVM> SupplierPaymentList([FromBody]GetPaymentDataListVM vm)
        {
            return await _businessService.BusinessWrapperService.GetSupplierPaymentList(vm);
        }
        [HttpPost]
        [Route("supplier/payment/delete")]
        public async Task<WrapperPaymentListVM> SupplierPaymentDelete([FromBody]PaymentVM vm)
        {
            return await _businessService.BusinessWrapperService.DeleteSupplierPayment(vm);
        }
        #endregion
        #region Staff
        [HttpPost]
        [Route("staff/payment")]
        public async Task<WrapperPaymentListVM> StaffPay([FromBody]PaymentVM vm)
        {
            return await _businessService.BusinessWrapperService.PayToStaff(vm);
        }

        [HttpPost]
        [Route("pay/init_data")]
        public async Task<InitialLoadDataVM> StaffInitData([FromBody]GetDataListVM getDataVM)
        {
            return await _businessService.PurchaseServiceWrapper.GetPaymentInitialData(getDataVM);
        }
        [HttpPost]
        [Route("staff/payment/list")]
        public async Task<WrapperPaymentListVM> StaffPaymentList([FromBody]GetPaymentDataListVM vm)
        {
            return await _businessService.BusinessWrapperService.GetStaffPaymentList(vm);
        }
        [HttpPost]
        [Route("staff/payment/delete")]
        public async Task<WrapperPaymentListVM> StaffPaymentDelete([FromBody]PaymentVM vm)
        {
            return await _businessService.BusinessWrapperService.DeleteStaffPayment(vm);
        }
        #endregion
        #region Customer
        [HttpPost]
        [Route("customer/payment")]
        public async Task<WrapperPaymentListVM> CustomerCash([FromBody]PaymentVM vm)
        {
            return await _businessService.BusinessWrapperService.RecieveFromCustomer(vm);
        }
        [HttpPost]
        [Route("customer/payment/list")]
        public async Task<WrapperPaymentListVM> CustomerPaymentList([FromBody]GetPaymentDataListVM vm)
        {
            return await _businessService.BusinessWrapperService.GetCustomerPaymentList(vm);
        }
        [HttpPost]
        [Route("customer/payment/delete")]
        public async Task<WrapperPaymentListVM> CustomerPaymentDelete([FromBody]PaymentVM vm)
        {
            return await _businessService.BusinessWrapperService.DeleteCustomerPayment(vm);
        }
        #endregion


        #endregion


        #region History
        #region Customer
        [HttpPost]
        [Route("supplier/history")]
        public async Task<WrapperSupplierHistory> SupplierHistory([FromBody]SupplierVM vm)
        {
            return await _businessService.BusinessWrapperService.GetSupplierHistory(vm);
        }
        #endregion

        #region Staff
        [HttpPost]
        [Route("staff/history")]
        public async Task<WrapperStaffHistory> StaffHistory([FromBody]StaffVM vm)
        {
            return await _businessService.BusinessWrapperService.GetStaffHistory(vm);
        }
        #endregion
        #region Supplier
        [HttpPost]
        [Route("customer/history")]
        public async Task<WrapperCustomerHistory> CustomerHistory([FromBody]CustomerVM vm)
        {
            return await _businessService.BusinessWrapperService.GetCustomerHistory(vm);
        }
        #endregion
        #endregion


        #region Production

        [HttpPost]
        [Route("production/getInitData")]
        public async Task<ActionResult<InitialLoadDataVM>> GetProductionInitData([FromBody]GetDataListVM getDataVM)
        {
            return await _businessService.PurchaseServiceWrapper.GetProductionInitialData(getDataVM);
        }

        #endregion



    }
}