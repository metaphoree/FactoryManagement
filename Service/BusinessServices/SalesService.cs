using AutoMapper;
using Contracts;
using Contracts.ServiceContracts;
using Entities.DbModels;
using Entities.Enums;
using Entities.ViewModels.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.BusinessServices
{
    public class SalesService : ISalesService
    {
        private readonly IRepositoryWrapper _repositoryWrapper;

        private readonly IUtilService _utilService;

        public SalesService(IRepositoryWrapper repositoryWrapper, IUtilService utilService)
        {
            this._repositoryWrapper = repositoryWrapper;
            this._utilService = utilService;
        }
        // Invoice
        // Income
        // Recievable
        // Sales
        // Stock
        // StockOut
        // Transaction
        public async Task AddSalesAsync(SalesVM salesVM)
        {

            // Invoice
            Invoice invoiceToAdd = new Invoice();
            invoiceToAdd = _utilService.Mapper.Map<SalesVM, Invoice>(salesVM);
            _repositoryWrapper.Invoice.Create(invoiceToAdd);

            // Setting Up Invoice Id
            salesVM.InvoiceId = invoiceToAdd.Id;
            foreach (var item in salesVM.ItemList)
            {
                item.InvoiceId = invoiceToAdd.Id;
            }

            // Income 
            Income incomeToAdd = new Income();
            incomeToAdd = this._utilService.Mapper.Map<SalesVM, Income>(salesVM);
            _repositoryWrapper.Income.Create(incomeToAdd);

            // Recievable
            Recievable recievableToAdd = new Recievable();
            recievableToAdd = _utilService.Mapper.Map<SalesVM, Recievable>(salesVM);
            _repositoryWrapper.Recievable.Create(recievableToAdd);

            // Sales
            List<Sales> listOfSalesToAdd = new List<Sales>();
            listOfSalesToAdd = _utilService.Mapper.Map<List<SalesItemVM>, List<Sales>>(salesVM.ItemList);
            _repositoryWrapper.Sales.CreateAll(listOfSalesToAdd);


            // Stock
            Stock stockToAdd = new Stock();
            IEnumerable<Stock> stockList = await _repositoryWrapper.Stock.FindByConditionAsync(x => x.FactoryId == salesVM.FactoryId);
            for (int i = 0; i < salesVM.ItemList.Count; i++)
            {
                Stock existingStock = stockList.ToList().Where(x => x.ItemId == salesVM.ItemList[i].Item.Id).FirstOrDefault();
                // IF NOT PRESENT ADD
                if (existingStock == null)
                {
                    //stockToAdd = _utilService.Mapper.Map<SalesItemVM, Stock>(salesVM.ItemList[i]);
                    //_repositoryWrapper.Stock.Create(stockToAdd);
                    _utilService.Log("Stock Is Empty");
                    return;
                }
                // IF PRESENT UPDATE
                else
                {
                    if (existingStock.Quantity >= salesVM.ItemList[i].Quantity)
                    {
                        existingStock.Quantity -= salesVM.ItemList[i].Quantity;
                        _repositoryWrapper.Stock.Update(existingStock);
                    }
                    else {

                        _utilService.Log("Stock Is Empty");
                        return;
                    }
                }
            }

            // StockOut
            List<StockOut> stockOutsToAdd = new List<StockOut>();
            stockOutsToAdd = _utilService.Mapper.Map<List<SalesItemVM>, List<StockOut>>(salesVM.ItemList);
            _repositoryWrapper.StockOut.CreateAll(stockOutsToAdd);


            // Transaction
            Transaction transactionRecieved = new Transaction();
            transactionRecieved = _utilService.Mapper.Map<SalesVM, Transaction>(salesVM);
            transactionRecieved.Amount = salesVM.PaidAmount;
            transactionRecieved.PaymentStatus = PAYMENT_STATUS.CASH_RECIEVED.ToString();
            transactionRecieved.TransactionType = TRANSACTION_TYPE.DEBIT.ToString();
            _repositoryWrapper.Transaction.Create(transactionRecieved);


            Transaction transactionRecievable = new Transaction();
            transactionRecievable = _utilService.Mapper.Map<SalesVM, Transaction>(salesVM);
            transactionRecievable.Amount = salesVM.DueAmount;
            transactionRecievable.PaymentStatus = PAYMENT_STATUS.CASH_RECIEVABLE.ToString();
            transactionRecieved.TransactionType = TRANSACTION_TYPE.NOT_YET_EXECUTED.ToString();
            _repositoryWrapper.Transaction.Create(transactionRecievable);

            await _repositoryWrapper.SaveAsync();
        }

    }
}
