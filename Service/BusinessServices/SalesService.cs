using AutoMapper;
using CommonUtils.Exception.Sales;
using Contracts;
using Contracts.ServiceContracts;
using Entities.DbModels;
using Entities.Enums;
using Entities.ViewModels;
using Entities.ViewModels.Sales;
using Microsoft.EntityFrameworkCore;
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
        public async Task<WrapperSalesListVM> AddSalesAsync(SalesVM salesVM)
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

                    _utilService.Log("Stock Is Empty. Not Enough Stock available");
                    throw new StockEmptyException();
                    //stockToAdd = _utilService.Mapper.Map<SalesItemVM, Stock>(salesVM.ItemList[i]);
                    //_repositoryWrapper.Stock.Create(stockToAdd);


                }
                // IF PRESENT UPDATE
                else
                {
                    if (existingStock.Quantity >= salesVM.ItemList[i].Quantity)
                    {
                        existingStock.Quantity -= salesVM.ItemList[i].Quantity;
                        _repositoryWrapper.Stock.Update(existingStock);
                    }
                    else
                    {

                        _utilService.Log("Stock Is Empty");
                        return new WrapperSalesListVM();
                    }
                }
            }

            // StockOut
            List<StockOut> stockOutsToAdd = new List<StockOut>();
            stockOutsToAdd = _utilService.Mapper.Map<List<SalesItemVM>, List<StockOut>>(salesVM.ItemList);
            _repositoryWrapper.StockOut.CreateAll(stockOutsToAdd);


            // Transaction
            TblTransaction transactionRecieved = new TblTransaction();
            transactionRecieved = _utilService.Mapper.Map<SalesVM, TblTransaction>(salesVM);
            transactionRecieved.Amount = salesVM.PaidAmount;
            transactionRecieved.PaymentStatus = PAYMENT_STATUS.CASH_RECIEVED.ToString();
            transactionRecieved.TransactionType = TRANSACTION_TYPE.CREDIT.ToString();
            _repositoryWrapper.Transaction.Create(transactionRecieved);


            //TblTransaction transactionRecievable = new TblTransaction();
            //transactionRecievable = _utilService.Mapper.Map<SalesVM, TblTransaction>(salesVM);
            //transactionRecievable.Amount = salesVM.DueAmount;
            //transactionRecievable.PaymentStatus = PAYMENT_STATUS.CASH_RECIEVABLE.ToString();
            //transactionRecievable.TransactionType = TRANSACTION_TYPE.NOT_YET_EXECUTED.ToString();
            //transactionRecievable.TransactionId = transactionRecieved.TransactionId;
            //_repositoryWrapper.Transaction.Create(transactionRecievable);

            Task<int> Invoice = _repositoryWrapper.Invoice.SaveChangesAsync();
            Task<int> Income = _repositoryWrapper.Income.SaveChangesAsync();
            Task<int> Recievable = _repositoryWrapper.Recievable.SaveChangesAsync();
            Task<int> Sales = _repositoryWrapper.Sales.SaveChangesAsync();
            Task<int> Stock = _repositoryWrapper.Stock.SaveChangesAsync();
            Task<int> StockOut = _repositoryWrapper.StockOut.SaveChangesAsync();
            Task<int> Transaction = _repositoryWrapper.Transaction.SaveChangesAsync();
            await Task.WhenAll(Invoice, Income, Recievable, Sales, Stock, StockOut, Transaction);





            var getDatalistVM = new GetDataListVM()
            {
                FactoryId = salesVM.FactoryId,
                PageNumber = 1,
                PageSize = 10
            };


            return await GetAllSalesAsync(getDatalistVM);

        }
        public async Task<WrapperSalesListVM> GetAllSalesAsync(GetDataListVM getDataListVM)
        {
            WrapperSalesListVM vm = new WrapperSalesListVM();
            List<SalesVM> vmList = new List<SalesVM>();

            Task<List<Invoice>> invoicesT = _repositoryWrapper
                .Invoice
                .FindAll()
                .Include(x => x.Customer)
                .Include(x => x.InvoiceType)
                .Where(x => x.FactoryId == getDataListVM.FactoryId
                && x.InvoiceType.Name == TypeInvoice.Sales.ToString())
                .Skip((getDataListVM.PageNumber - 1) * (getDataListVM.PageSize))
                .Take(getDataListVM.PageSize)
                .ToListAsync();


            Task<List<Sales>> salesT = _repositoryWrapper
                .Sales
                .FindAll()
                .Where(x => x.FactoryId == getDataListVM.FactoryId)
                .Include(x => x.Item)
                .ThenInclude(s => s.ItemCategory)
                .ToListAsync();

            await Task.WhenAll(invoicesT, salesT);
            List<Sales> dbListSales = salesT.Result.ToList();
            vmList = _utilService.Mapper.Map<List<Invoice>, List<SalesVM>>(invoicesT.Result.ToList());
            List<Sales> temp = new List<Sales>();

            for (int i = 0; i < vmList.Count; i++)
            {
                temp = dbListSales.Where(x => x.InvoiceId == vmList.ElementAt(i).InvoiceId).ToList();
                vmList.ElementAt(i).ItemList = _utilService.Mapper.Map<List<Sales>, List<SalesItemVM>>(temp);
            }
            vm.ListOfData = vmList;
            vm.TotalRecoreds = invoicesT.Result.ToList().Count;
            return vm;
        }


        public async Task<WrapperSalesReturnVM> AddSalesReturn(SalesReturnVM vm)
        {
            // StockIn
            // Invoice
            // Payable
            // Stock
            Invoice invoiceToAdd = new Invoice();
            invoiceToAdd = _utilService.Mapper.Map<SalesReturnVM, Invoice>(vm);
            _repositoryWrapper.Invoice.Create(invoiceToAdd);
            vm.InvoiceId = invoiceToAdd.Id;

            Payable payableToAdd = new Payable();
            payableToAdd = _utilService.Mapper.Map<SalesReturnVM, Payable>(vm);


            Stock stockToAdd = new Stock();
            stockToAdd = _utilService.Mapper.Map<SalesReturnVM, Stock>(vm);

            // Stock
            IEnumerable<Stock> stockList = await _repositoryWrapper.Stock.FindByConditionAsync(x => x.FactoryId == vm.FactoryId);
            Stock existingStock = stockList.ToList().Where(x => x.ItemId == vm.ItemId).FirstOrDefault();
            // IF NOT PRESENT ADD
            if (existingStock == null)
            {
                _utilService.Log("Stock Is Empty. Not Enough Stock available");
                throw new StockEmptyException();
                //stockToAdd = _utilService.Mapper.Map<SalesItemVM, Stock>(salesVM.ItemList[i]);
                //_repositoryWrapper.Stock.Create(stockToAdd);
            }
            // IF PRESENT UPDATE
            else
            {
                existingStock.Quantity += vm.Quantity;
                _repositoryWrapper.Stock.Update(existingStock);
            }

            StockIn stockInToAdd = new StockIn();
            stockInToAdd = _utilService.Mapper.Map<SalesReturnVM, StockIn>(vm);

            _repositoryWrapper.StockIn.Create(stockInToAdd);
            _repositoryWrapper.Payable.Create(payableToAdd);


            if (vm.AmountPaid > 0)
            {
                TblTransaction tblTransactionToAdd = new TblTransaction();
                tblTransactionToAdd = _utilService.Mapper.Map<SalesReturnVM, TblTransaction>(vm);
                _repositoryWrapper.Transaction.Create(tblTransactionToAdd);
            }




            Task<int> invT = _repositoryWrapper.Invoice.SaveChangesAsync();
            Task<int> stockInT = _repositoryWrapper.StockIn.SaveChangesAsync();
            Task<int> stockT = _repositoryWrapper.Stock.SaveChangesAsync();
            Task<int> payableT = _repositoryWrapper.Payable.SaveChangesAsync();
            Task<int> transactionT = _repositoryWrapper.Transaction.SaveChangesAsync();

            await Task.WhenAll(invT, stockInT, stockT, payableT, transactionT);



            var data = new GetDataListVM()
            {
                FactoryId = vm.FactoryId,
                PageSize = 15,
                PageNumber = 1

            };
            return await GetAllSalesReturn(data);

        }
        public async Task<WrapperSalesReturnVM> GetAllSalesReturn(GetDataListVM getDataListVM)
        {
            // Invoice
            // StockOut
            WrapperSalesReturnVM vm = new WrapperSalesReturnVM();

            List<SalesReturnVM> vmList = new List<SalesReturnVM>();

            Task<List<Invoice>> invoicesT = _repositoryWrapper
                .Invoice
                .FindAll()
                .Include(x => x.Supplier)
                .Include(x => x.InvoiceType)
                .Where(x => x.FactoryId == getDataListVM.FactoryId
                && x.InvoiceType.Name == TypeInvoice.PurchaseReturn.ToString())
                //.Skip((getDataListVM.PageNumber - 1) * (getDataListVM.PageSize))
                //.Take(getDataListVM.PageSize)
                .ToListAsync();

            Task<List<StockIn>> stockInT = _repositoryWrapper
                .StockIn
                .FindAll()
                .Include(x => x.Item)
                .ThenInclude(x => x.ItemCategory)
                .Include(x => x.ItemStatus)
                .Where(x => x.FactoryId == getDataListVM.FactoryId)
                //.Skip((getDataListVM.PageNumber - 1) * (getDataListVM.PageSize))
                //.Take(getDataListVM.PageSize)
                .ToListAsync();

            await Task.WhenAll(invoicesT, stockInT);
            List<Invoice> invoiceList = invoicesT.Result.ToList();
            List<StockIn> stockInList = stockInT.Result.ToList();


            SalesReturnVM vc = new SalesReturnVM();
            for (int i = 0; i < invoiceList.Count; i++)
            {
                vc = new SalesReturnVM();
                Invoice temp = invoiceList.ElementAt(i);
                vc = _utilService.Mapper.Map<Invoice, SalesReturnVM>(temp, vc);
                vc = _utilService.Mapper.Map<StockIn, SalesReturnVM>(stockInList.Where(x => x.InvoiceId ==
                temp.Id).ToList().FirstOrDefault(), vc);
                vmList.Add(vc);
            }

            vm.NumberOfRecords = vmList.Count;
            vm.ListOfData =
                vmList
                .OrderByDescending(x => x.OccurranceDate)
                .Skip((getDataListVM.PageNumber - 1) * (getDataListVM.PageSize))
                .Take(getDataListVM.PageSize)
                .ToList();

            return vm;
        }
        public async Task<WrapperSalesReturnVM> DeleteSalesReturn(SalesReturnVM vm)
        {

            Task<List<Invoice>> invoiceToDelete = _repositoryWrapper
                    .Invoice
                    .FindAll()
                    .Where(x => x.Id == vm.InvoiceId && x.FactoryId == vm.FactoryId)
                    .ToListAsync();
            Task<List<StockIn>> stockInToDelete = _repositoryWrapper
                    .StockIn
                    .FindAll()
                    .Where(x => x.InvoiceId == vm.InvoiceId && x.FactoryId == vm.FactoryId)
                    .ToListAsync();
            Task<List<Payable>> payableToDelete = _repositoryWrapper
                    .Payable
                    .FindAll()
                    .Where(x => x.InvoiceId == vm.InvoiceId && x.FactoryId == vm.FactoryId)
                    .ToListAsync();

           await  Task.WhenAll(invoiceToDelete, stockInToDelete, payableToDelete);

            // Stock
            IEnumerable<Stock> stockList = await _repositoryWrapper.Stock.FindByConditionAsync(x => x.FactoryId == vm.FactoryId && x.ItemId == vm.ItemId);

            Stock existingStock = stockList.ToList().Where(x => x.ItemId == vm.ItemId).FirstOrDefault();
            // IF NOT PRESENT ADD
            if (existingStock == null)
            {
                _utilService.Log("Stock Is Empty. Not Enough Stock available");
                throw new StockEmptyException();
                //stockToAdd = _utilService.Mapper.Map<SalesItemVM, Stock>(salesVM.ItemList[i]);
                //_repositoryWrapper.Stock.Create(stockToAdd);
            }
            // IF PRESENT UPDATE
            else
            {
                existingStock.Quantity -= vm.Quantity;
                _repositoryWrapper.Stock.Update(existingStock);
            }

            Invoice invDelete = _repositoryWrapper.Invoice.Delete(invoiceToDelete.Result.ToList().FirstOrDefault());
            StockIn StockInDelete = _repositoryWrapper.StockIn.Delete(stockInToDelete.Result.ToList().FirstOrDefault());
            Payable PayableDelete = _repositoryWrapper.Payable.Delete(payableToDelete.Result.ToList().FirstOrDefault());

            Task<int> inv = _repositoryWrapper.Invoice.SaveChangesAsync();
            Task<int> StockIn = _repositoryWrapper.StockIn.SaveChangesAsync();
            Task<int> Payable = _repositoryWrapper.Payable.SaveChangesAsync();

            await Task.WhenAll(inv, StockIn, Payable);


            var data = new GetDataListVM() { 
            FactoryId = vm.FactoryId,
            PageSize = 15,
            PageNumber = 1
         
            };
            return  await GetAllSalesReturn(data);
        }


    }
}
