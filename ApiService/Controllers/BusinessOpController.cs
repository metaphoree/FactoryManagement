using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommonUtils;
using Contracts;
using Entities.DbModels;
using Entities.ViewModels;
using Entities.ViewModels.Payment;
using Entities.ViewModels.Production;
using Entities.ViewModels.Purchase;
using Entities.ViewModels.Sales;
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
        [Route("supplier/pay")]
        public async Task<CommonResponse> SupplierPay([FromBody]PaymentVM vm)
        {
            return await _businessService.BusinessWrapperService.PayToSupplier(vm);
        }




        #endregion




        #region Staff
        [HttpPost]
        [Route("staff/pay")]
        public async Task<CommonResponse> StaffPay([FromBody]PaymentVM vm)
        {
            return await _businessService.BusinessWrapperService.PayToWorker(vm);
        }

        [HttpPost]
        [Route("pay/init_data")]
        public async Task<InitialLoadDataVM> StaffInitData([FromBody]GetDataListVM getDataVM)
        {
            return await _businessService.PurchaseServiceWrapper.GetPaymentInitialData(getDataVM);
        }

        #endregion


        #region Customer
        [HttpPost]
        [Route("customer/cash")]
        public async Task<CommonResponse> CustomerCash([FromBody]PaymentVM vm)
        {
            return await _businessService.BusinessWrapperService.RecieveFromCustomer(vm);
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