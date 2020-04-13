using AutoMapper;
using Contracts;
using Contracts.ServiceContracts;
using Entities.DbModels;
using Entities.Enums;
using Entities.ViewModels.Purchase;
using Entities.ViewModels.Stock;
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
        public async Task AddPurchaseAsync(PurchaseVM purchaseVM) {

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
            for (int i = 0; i <  purchaseVM.ItemList.Count; i++) {

                Stock existingStock = stockList.ToList().Where(x => x.ItemId == purchaseVM.ItemList[i].Item.Id).FirstOrDefault();
                
                // IF NOT PRESENT ADD
                if (existingStock == null) {
                    stockToAdd = _utilService.Mapper.Map<PurchaseItemVM, Stock>(purchaseVM.ItemList[i]);
                    _repositoryWrapper.Stock.Create(stockToAdd);
                }
                // IF PRESENT UPDATE
                else {
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


            TblTransaction transactionPayable = new TblTransaction();
            transactionPayable = _utilService.Mapper.Map<PurchaseVM, TblTransaction>(purchaseVM);
            transactionPayable.Amount = purchaseVM.DueAmount;
            transactionPayable.PaymentStatus = PAYMENT_STATUS.CASH_PAYABLE.ToString();
            transactionPayable.TransactionType = TRANSACTION_TYPE.NOT_YET_EXECUTED.ToString();
            transactionPayable.TransactionId = transactionPaid.TransactionId;
            _repositoryWrapper.Transaction.Create(transactionPayable);

            Task<int> Invoice = _repositoryWrapper.Invoice.SaveChangesAsync();
            Task<int> Expense = _repositoryWrapper.Expense.SaveChangesAsync();
            Task<int> Payable = _repositoryWrapper.Payable.SaveChangesAsync();
            Task<int> Purchase = _repositoryWrapper.Purchase.SaveChangesAsync();
            Task<int> Stock = _repositoryWrapper.Stock.SaveChangesAsync();
            Task<int> StockIn = _repositoryWrapper.StockIn.SaveChangesAsync();
            Task<int> Transaction = _repositoryWrapper.Transaction.SaveChangesAsync();
            await Task.WhenAll(Invoice, Expense, Payable, Purchase, Stock, StockIn, Transaction);
        }
    }
}
