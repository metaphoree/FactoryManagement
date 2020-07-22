using AutoMapper;
using CommonUtils.Exception.Sales;
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

                Stock existingStock = stockList.ToList().Where(x => x.ItemId == purchaseVM.ItemList[i].Item.Id && x.ItemStatusId == purchaseVM.ItemList[i].ItemStatus.Id).FirstOrDefault();

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
            vm.TotalRecords = invoicesT.Result.ToList().Count;
            return vm;
        }

        // Invoice
        // Expense
        // Payable
        // Purchase
        // Stock
        // StockIn
        // Transaction
        public async Task<WrapperPurchaseListVM> DeletePurchaseAsync(PurchaseVM vm)
        {
            Task<List<Invoice>> invoiceToDelete = _repositoryWrapper
                                .Invoice
                                .FindAll()
                                .Where(x => x.Id == vm.InvoiceId && x.FactoryId == vm.FactoryId)
                                .ToListAsync();
            Task<List<Expense>> expenseToDelete = _repositoryWrapper
                                .Expense
                                .FindAll()
                                .Where(x => x.InvoiceId == vm.InvoiceId && x.FactoryId == vm.FactoryId)
                                .ToListAsync();
            Task<List<Payable>> payableToDelete = _repositoryWrapper
                                .Payable
                                .FindAll()
                                .Where(x => x.InvoiceId == vm.InvoiceId && x.FactoryId == vm.FactoryId)
                                .ToListAsync();
            Task<List<Purchase>> purchaseToDelete = _repositoryWrapper
                                .Purchase
                                .FindAll()
                                .Where(x => x.InvoiceId == vm.InvoiceId && x.FactoryId == vm.FactoryId)
                                .ToListAsync();

            await Task.WhenAll(invoiceToDelete, expenseToDelete, payableToDelete, purchaseToDelete);
            // Stock
            IEnumerable<Stock> stockList = await _repositoryWrapper
                .Stock
                .FindByConditionAsync(
                x => x.FactoryId == vm.FactoryId);
            //&& purchaseToDelete
            //.Result
            //.ToList()
            //.FirstOrDefault(d => d.ItemId == x.ItemId) != null);

            for (int i = 0; i < purchaseToDelete.Result.Count(); i++)
            {

                Purchase purchaseItem = purchaseToDelete.Result.ElementAt(i);
                Stock existingStock = stockList.ToList().Where(x => x.ItemId == purchaseItem.ItemId).FirstOrDefault();
                if (existingStock == null)
                {
                    // _utilService.Log("Stock Is Empty. Not Enough Stock available");
                    // throw new StockEmptyException();

                }
                else
                {
                    if (existingStock.Quantity < purchaseItem.Quantity)
                    {
                        var getDatalistVM2 = new GetDataListVM()
                        {
                            FactoryId = vm.FactoryId,
                            PageNumber = 1,
                            PageSize = 10
                        };


                        WrapperPurchaseListVM vm2 = await GetAllPurchaseAsync(getDatalistVM2);
                        vm2.HasMessage = true;
                        vm2.Message = "Stock hasn't enough item";
                        return vm2;

                    }
                    else
                    {
                        existingStock.Quantity -= purchaseItem.Quantity;
                        _repositoryWrapper.Stock.Update(existingStock);
                    }
                }
            }


            Task<List<StockIn>> stockInToDelete = _repositoryWrapper
                                .StockIn
                                .FindAll()
                                .Where(x => x.InvoiceId == vm.InvoiceId && x.FactoryId == vm.FactoryId)
                                .ToListAsync();

            Task<List<TblTransaction>> transactionToDelete = _repositoryWrapper
                                .Transaction
                                .FindAll()
                                .Where(x => x.InvoiceId == vm.InvoiceId && x.FactoryId == vm.FactoryId)
                                .ToListAsync();



            _repositoryWrapper.Invoice.DeleteAll(invoiceToDelete.Result.ToList());
            _repositoryWrapper.Expense.DeleteAll(expenseToDelete.Result.ToList());
            _repositoryWrapper.Payable.DeleteAll(payableToDelete.Result.ToList());
            _repositoryWrapper.Purchase.DeleteAll(purchaseToDelete.Result.ToList());
            _repositoryWrapper.StockIn.DeleteAll(stockInToDelete.Result.ToList());
            _repositoryWrapper.Transaction.DeleteAll(transactionToDelete.Result.ToList());



            Task<int> Invoice = _repositoryWrapper.Invoice.SaveChangesAsync();
            Task<int> Expense = _repositoryWrapper.Expense.SaveChangesAsync();
            Task<int> Payable = _repositoryWrapper.Payable.SaveChangesAsync();
            Task<int> Purchase = _repositoryWrapper.Purchase.SaveChangesAsync();
            Task<int> StockIn = _repositoryWrapper.StockIn.SaveChangesAsync();
            Task<int> TblTransaction = _repositoryWrapper.Transaction.SaveChangesAsync();
            Task<int> Stock = _repositoryWrapper.Stock.SaveChangesAsync();

            await Task.WhenAll(Invoice, Expense, Payable, Purchase, StockIn, TblTransaction, Stock);


            var getDatalistVM = new GetDataListVM()
            {
                FactoryId = vm.FactoryId,
                PageNumber = 1,
                PageSize = 10
            };


            return await GetAllPurchaseAsync(getDatalistVM);
        }
        public async Task<WrapperPurchaseReturnVM> AddPurchaseReturnAsync(PurchaseReturnVM vm)
        {
            // StockOut
            // Invoice
            // Recievable
            // Stock
            Invoice invoiceToAdd = new Invoice();
            invoiceToAdd = _utilService.Mapper.Map<PurchaseReturnVM, Invoice>(vm);
            _repositoryWrapper.Invoice.Create(invoiceToAdd);
            vm.InvoiceId = invoiceToAdd.Id;

            if (!vm.IsFullyPaid)
            {
                Recievable RecievableToAdd = new Recievable();
                RecievableToAdd = _utilService.Mapper.Map<PurchaseReturnVM, Recievable>(vm);
                _repositoryWrapper.Recievable.Create(RecievableToAdd);
            }

            Stock stockToAdd = new Stock();
            stockToAdd = _utilService.Mapper.Map<PurchaseReturnVM, Stock>(vm);

            // Stock
            IEnumerable<Stock> stockList = await _repositoryWrapper.Stock.FindByConditionAsync(x => x.FactoryId == vm.FactoryId);
            Stock existingStock = stockList
                .ToList()
                .Where(x => x.ItemId == vm.ItemId && x.FactoryId == vm.FactoryId && x.ItemStatusId == vm.ItemStatusId)
                .FirstOrDefault();
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
                if (existingStock.Quantity < vm.Quantity)
                {
                    throw new StockEmptyException();
                }
                else
                {
                    existingStock.Quantity -= vm.Quantity;
                    _repositoryWrapper.Stock.Update(existingStock);
                }

            }

            StockOut stockOutToAdd = new StockOut();
            stockOutToAdd = _utilService.Mapper.Map<PurchaseReturnVM, StockOut>(vm);

            _repositoryWrapper.StockOut.Create(stockOutToAdd);


            if (vm.AmountRecieved > 0)
            {
                TblTransaction tblTransactionToAdd = new TblTransaction();
                tblTransactionToAdd = _utilService.Mapper.Map<PurchaseReturnVM, TblTransaction>(vm);
                _repositoryWrapper.Transaction.Create(tblTransactionToAdd);

                Income incomeToAdd = new Income();
                incomeToAdd = _utilService.Mapper.Map<PurchaseReturnVM, Income>(vm);
                _repositoryWrapper.Income.Create(incomeToAdd);
            }



            Task<int> invT = _repositoryWrapper.Invoice.SaveChangesAsync();
            Task<int> stockInT = _repositoryWrapper.StockOut.SaveChangesAsync();
            Task<int> stockT = _repositoryWrapper.Stock.SaveChangesAsync();
            Task<int> payableT = _repositoryWrapper.Recievable.SaveChangesAsync();
            Task<int> transactionT = _repositoryWrapper.Transaction.SaveChangesAsync();
            Task<int> incomeT = _repositoryWrapper.Income.SaveChangesAsync();

            await Task.WhenAll(invT, stockInT, stockT, payableT, transactionT, incomeT);

            var data = new GetDataListVM()
            {
                FactoryId = vm.FactoryId,
                PageSize = 15,
                PageNumber = 1

            };
            return await GetAllPurchaseReturnAsync(data);
        }
        public async Task<WrapperPurchaseReturnVM> GetAllPurchaseReturnAsync(GetDataListVM getDataListVM)
        {
            // Invoice
            // StockOut
            WrapperPurchaseReturnVM vm = new WrapperPurchaseReturnVM();

            List<PurchaseReturnVM> vmList = new List<PurchaseReturnVM>();

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

            Task<List<StockOut>> stockOutT = _repositoryWrapper
                .StockOut
                .FindAll()
                .Include(x => x.Item)
                .ThenInclude(x => x.ItemCategory)
                .Include(x => x.ItemStatus)
                .Where(x => x.FactoryId == getDataListVM.FactoryId)
                //.Skip((getDataListVM.PageNumber - 1) * (getDataListVM.PageSize))
                //.Take(getDataListVM.PageSize)
                .ToListAsync();

            Task<List<Recievable>> recievableT = _repositoryWrapper
                .Recievable
                .FindAll()
                .Include(x => x.Supplier)
                .Where(x => x.FactoryId == getDataListVM.FactoryId)
                //.Skip((getDataListVM.PageNumber - 1) * (getDataListVM.PageSize))
                //.Take(getDataListVM.PageSize)
                .ToListAsync();




            await Task.WhenAll(invoicesT, stockOutT, recievableT);
            List<Invoice> invoiceList = invoicesT.Result.ToList();
            List<StockOut> stockOutList = stockOutT.Result.ToList();
            List<Recievable> recievableList = recievableT.Result.ToList();

            PurchaseReturnVM vc = new PurchaseReturnVM();
            for (int i = 0; i < invoiceList.Count; i++)
            {
                vc = new PurchaseReturnVM();
                Invoice temp = invoiceList.ElementAt(i);
                vc = _utilService.Mapper.Map<Invoice, PurchaseReturnVM>(temp, vc);
                vc = _utilService.Mapper.Map<StockOut, PurchaseReturnVM>(stockOutList.Where(x => x.InvoiceId ==
                temp.Id).ToList().FirstOrDefault(), vc);


                var recievableAmt = recievableList.Where(x => x.InvoiceId ==
            temp.Id).ToList().FirstOrDefault();
                if (recievableAmt != null)
                {
                    vc = _utilService.Mapper.Map<Recievable, PurchaseReturnVM>(recievableAmt, vc);
                }


                vmList.Add(vc);
            }

            vm.TotalRecords = vmList.Count;
            vm.ListOfData =
                vmList
                .OrderByDescending(x => x.OccurranceDate)
                .Skip((getDataListVM.PageNumber - 1) * (getDataListVM.PageSize))
                .Take(getDataListVM.PageSize)
                .ToList();

            return vm;
        }
        public async Task<WrapperPurchaseReturnVM> DeletePurchaseReturnAsync(PurchaseReturnVM vm)
        {
            // StockOut
            // Invoice
            // Recievable
            // Stock
            Task<List<Invoice>> invoiceToDelete = _repositoryWrapper
                    .Invoice
                    .FindAll()
                    .Where(x => x.Id == vm.InvoiceId && x.FactoryId == vm.FactoryId)
                    .ToListAsync();
            Task<List<StockOut>> stockOutToDelete = _repositoryWrapper
                    .StockOut
                    .FindAll()
                    .Where(x => x.InvoiceId == vm.InvoiceId && x.FactoryId == vm.FactoryId)
                    .ToListAsync();
            Task<List<Recievable>> recievableToDelete = _repositoryWrapper
                    .Recievable
                    .FindAll()
                    .Where(x => x.InvoiceId == vm.InvoiceId && x.FactoryId == vm.FactoryId)
                    .ToListAsync();

            await Task.WhenAll(invoiceToDelete, stockOutToDelete, recievableToDelete);

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
                existingStock.Quantity += vm.Quantity;
                _repositoryWrapper.Stock.Update(existingStock);
            }

            _repositoryWrapper.Invoice.Delete(invoiceToDelete.Result.ToList().FirstOrDefault());
            _repositoryWrapper.StockOut.Delete(stockOutToDelete.Result.ToList().FirstOrDefault());
            _repositoryWrapper.Recievable.Delete(recievableToDelete.Result.ToList().FirstOrDefault());

            Task<int> inv = _repositoryWrapper.Invoice.SaveChangesAsync();
            Task<int> StockIn = _repositoryWrapper.StockIn.SaveChangesAsync();
            Task<int> Stock = _repositoryWrapper.Stock.SaveChangesAsync();
            Task<int> Payable = _repositoryWrapper.Payable.SaveChangesAsync();

            await Task.WhenAll(inv, StockIn, Payable, Stock);


            var data = new GetDataListVM()
            {
                FactoryId = vm.FactoryId,
                PageSize = 15,
                PageNumber = 1

            };
            return await GetAllPurchaseReturnAsync(data);
        }
    }
}
