﻿using Contracts;
using Contracts.IBusinessServiceWrapper;
using Entities.ViewModels;
using Entities.ViewModels.CustomerView;
using Entities.ViewModels.ExpenseType;
using Entities.ViewModels.IncomeType;
using Entities.ViewModels.Item;
using Entities.ViewModels.ItemCategoryView;
using Entities.ViewModels.ItemStatus;
using Entities.ViewModels.Supplier;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.BusinessServiceWrapper
{
   public class PurchaseWrapperService : IPurchaseWrapperService
    {
        private readonly IServiceWrapper _serviceWrapper;
        private readonly IRepositoryWrapper _repositoryWrapper;
        private readonly IUtilService _utilService;

        public PurchaseWrapperService(IServiceWrapper serviceWrapper,IRepositoryWrapper repositoryWrapper,IUtilService utilService ) {
            this._repositoryWrapper = repositoryWrapper;
            this._serviceWrapper = serviceWrapper;
            this._utilService = utilService; 
        }

        public async Task<InitialLoadDataVM> GetPurchaseInitialData(GetDataListVM getDataListVM) {
            InitialLoadDataVM vm = new InitialLoadDataVM();

            Task<WrapperItemListVM> itemListTask = _serviceWrapper.ItemService.GetListPaged(getDataListVM);
            Task<WrapperItemCategoryListVM> itemCategoryListTask = _serviceWrapper.ItemCategoryService.GetListPaged(getDataListVM);
            Task<WrapperSupplierListVM> supplierListTask = _serviceWrapper.SupplierService.GetListPaged(getDataListVM);
            Task<WrapperExpenseTypeListVM> expenseTypeTask = _serviceWrapper.ExpenseTypeService.GetListPaged(getDataListVM);
            Task<WrapperItemStatusListVM> itemStatusListTask = _serviceWrapper.ItemStatusService.GetListPaged(getDataListVM);

            await Task.WhenAll(itemListTask, itemCategoryListTask, supplierListTask, expenseTypeTask, itemStatusListTask);

            vm.ItemCategoryVMs = itemCategoryListTask.Result.ListOfData;
            vm.ItemVMs = itemListTask.Result.ListOfData;
            vm.SupplierVMs = supplierListTask.Result.ListOfData;
            vm.ExpenseTypeVMs = expenseTypeTask.Result.ListOfData;
            vm.ItemStatusVMs = itemStatusListTask.Result.ListOfData;
            return vm;
        }
        public async Task<InitialLoadDataVM> GetSalesInitialData(GetDataListVM getDataListVM)
        {
            InitialLoadDataVM vm = new InitialLoadDataVM();

            Task<WrapperItemListVM> itemListTask = _serviceWrapper.ItemService.GetListPaged(getDataListVM);
            Task<WrapperItemCategoryListVM> itemCategoryListTask = _serviceWrapper.ItemCategoryService.GetListPaged(getDataListVM);
            Task<WrapperListCustomerVM> customerListTask = _serviceWrapper.CustomerService.GetListPaged(getDataListVM);
            Task<WrapperIncomeTypeListVM> incomeTypeListTask = _serviceWrapper.IncomeTypeService.GetListPaged(getDataListVM);
            Task<WrapperItemStatusListVM> itemStatusListTask = _serviceWrapper.ItemStatusService.GetListPaged(getDataListVM);


            await Task.WhenAll(itemListTask, itemCategoryListTask, customerListTask, incomeTypeListTask, itemStatusListTask);

            vm.ItemCategoryVMs = itemCategoryListTask.Result.ListOfData;
            vm.ItemVMs = itemListTask.Result.ListOfData;
            vm.CustomerVMs = customerListTask.Result.ListOfData;
            vm.IncomeTypeVMs = incomeTypeListTask.Result.ListOfData;
            vm.ItemStatusVMs = itemStatusListTask.Result.ListOfData;
            return vm;
        }
    }
}
