using AutoMapper;
using Contracts;
using Contracts.ServiceContracts;
using Entities.DbModels;
using Entities.Enums;
using Entities.ViewModels;
using Entities.ViewModels.Purchase;
using Entities.ViewModels.Stock;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.BusinessServices
{
    public class PurchaseService : IPurchaseService
    {
        private readonly IRepositoryWrapper _repositoryWrapper;

        private readonly IUtilService _utilService;

        public PurchaseService(IRepositoryWrapper repositoryWrapper, IUtilService utilService)
        {
            this._repositoryWrapper = repositoryWrapper;

            this._utilService = utilService;
        }

        // Invoice
        // Expense
        // Payable
        // Purchase
        // Stock
        // StockIn
        // Transaction
        public async Task<WrapperPurchaseListVM> AddPurchaseAsync(PurchaseVM purchaseVM)
        {

            // Invoice
            Invoice invoiceToAdd = new Invoice();
            invoiceToAdd = _utilService.Mapper.Map<PurchaseVM, Invoice>(purchaseVM);
            _repositoryWrapper.Invoice.Create(invoiceToAdd);

            // Setting Up Invoice Id
            purchaseVM.InvoiceId = invoiceToAdd.Id;
            foreach (var item in purchaseVM.ItemList)
            {
                item.InvoiceId = invoiceToAdd.Id;
            }

            // Expense 
            Expense expenseToAdd = new Expense();
            expenseToAdd = this._utilService.Mapper.Map<PurchaseVM, Expense>(purchaseVM);
            _repositoryWrapper.Expense.Create(expenseToAdd);

            // Payable
            Payable payableToAdd = new Payable();
            payableToAdd = _utilService.Mapper.Map<PurchaseVM, Payable>(purchaseVM);
            _repositoryWrapper.Payable.Create(payableToAdd);

            // Purchase
            List<Purchase> listOfPurchaseToAdd = new List<Purchase>();
            listOfPurchaseToAdd = _utilService.Mapper.Map<List<PurchaseItemVM>, List<Purchase>>(purchaseVM.ItemList);
            _repositoryWrapper.Purchase.CreateAll(listOfPurchaseToAdd);


            // Stock
            Stock stockToAdd = new Stock();
            IEnumerable<Stock> stockList = await _repositoryWrapper.Stock.FindByConditionAsync(x => x.FactoryId == purchaseVM.FactoryId);
            for (int i = 0; i < purchaseVM.ItemList.Count; i++)
            {

                Stock existingStock = stockList.ToList().Where(x => x.ItemId == purchaseVM.ItemList[i].Item.Id).FirstOrDefault();

                // IF NOT PRESENT ADD
                if (existingStock == null)
                {
                    stockToAdd = _utilService.Mapper.Map<PurchaseItemVM, Stock>(purchaseVM.ItemList[i]);
                    _repositoryWrapper.Stock.Create(stockToAdd);
                }
                // IF PRESENT UPDATE
                else
                {
                    existingStock.Quantity += purchaseVM.ItemList[i].Quantity;
                    _repositoryWrapper.Stock.Update(existingStock);
                }
            }

            // StockIn
            List<StockIn> stockInsToAdd = new List<StockIn>();
            stockInsToAdd = _utilService.Mapper.Map<List<PurchaseItemVM>, List<StockIn>>(purchaseVM.ItemList);
            _repositoryWrapper.StockIn.CreateAll(stockInsToAdd);


            // Transaction
            TblTransaction transactionPaid = new TblTransaction();
            transactionPaid = _utilService.Mapper.Map<PurchaseVM, TblTransaction>(purchaseVM);
            transactionPaid.Amount = purchaseVM.PaidAmount;
            transactionPaid.PaymentStatus = PAYMENT_STATUS.CASH_PAID.ToString();
            transactionPaid.TransactionType = TRANSACTION_TYPE.DEBIT.ToString();
            _repositoryWrapper.Transaction.Create(transactionPaid);


            //TblTransaction transactionPayable = new TblTransaction();
            //transactionPayable = _utilService.Mapper.Map<PurchaseVM, TblTransaction>(purchaseVM);
            //transactionPayable.Amount = purchaseVM.DueAmount;
            //transactionPayable.PaymentStatus = PAYMENT_STATUS.CASH_PAYABLE.ToString();
            //transactionPayable.TransactionType = TRANSACTION_TYPE.NOT_YET_EXECUTED.ToString();
            //transactionPayable.TransactionId = transactionPaid.TransactionId;
            //_repositoryWrapper.Transaction.Create(transactionPayable);

            Task<int> Invoice = _repositoryWrapper.Invoice.SaveChangesAsync();
            Task<int> Expense = _repositoryWrapper.Expense.SaveChangesAsync();
            Task<int> Payable = _repositoryWrapper.Payable.SaveChangesAsync();
            Task<int> Purchase = _repositoryWrapper.Purchase.SaveChangesAsync();
            Task<int> Stock = _repositoryWrapper.Stock.SaveChangesAsync();
            Task<int> StockIn = _repositoryWrapper.StockIn.SaveChangesAsync();
            Task<int> Transaction = _repositoryWrapper.Transaction.SaveChangesAsync();
            await Task.WhenAll(Invoice, Expense, Payable, Purchase, Stock, StockIn, Transaction);

            var getDatalistVM = new GetDataListVM()
            {
                FactoryId = purchaseVM.FactoryId,
                PageNumber = 1,
                PageSize = 10
            };


            return await GetAllPurchaseAsync(getDatalistVM);

        }

        public async Task<WrapperPurchaseListVM> GetAllPurchaseAsync(GetDataListVM getDataListVM)
        {
            WrapperPurchaseListVM vm = new WrapperPurchaseListVM();

            List<PurchaseVM> vmList = new List<PurchaseVM>();

            Task<List<Invoice>> invoicesT = _repositoryWrapper
                .Invoice
                .FindAll()
                .Include(x => x.Supplier)
                .Include(x => x.InvoiceType)
                .Where(x => x.FactoryId == getDataListVM.FactoryId
                && x.InvoiceType.Name == TypeInvoice.Purchase.ToString())
                .Skip((getDataListVM.PageNumber - 1) * (getDataListVM.PageSize))
                .Take(getDataListVM.PageSize)
                .ToListAsync();


            Task<List<Purchase>> purchasesT = _repositoryWrapper
                .Purchase
                .FindAll()
                .Where(x => x.FactoryId == getDataListVM.FactoryId)
                .Include(x => x.Item)
                .ThenInclude(s => s.ItemCategory)
                .ToListAsync();

            await Task.WhenAll(invoicesT, purchasesT);
            List<Purchase> dbListPurchase = purchasesT.Result.ToList();
            vmList = _utilService.Mapper.Map<List<Invoice>, List<PurchaseVM>>(invoicesT.Result.ToList());
            List<Purchase> temp = new List<Purchase>();

            for (int i = 0; i < vmList.Count; i++)
            {
                temp = dbListPurchase.Where(x => x.InvoiceId == vmList.ElementAt(i).InvoiceId).ToList();
                vmList.ElementAt(i).ItemList = _utilService.Mapper.Map<List<Purchase>, List<PurchaseItemVM>>(temp);
            }

            vm.ListOfData = vmList;
            vm.TotalRecoreds = invoicesT.Result.ToList().Count;
            return vm;
        }


    }
}
