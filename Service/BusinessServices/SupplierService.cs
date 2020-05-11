using AutoMapper;
using Contracts;
using Contracts.ServiceContracts;
using Entities.DbModels;
using Entities.Enums;
using Entities.ViewModels;
using Entities.ViewModels.Payment;
using Entities.ViewModels.Supplier;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.BusinessServices
{
    public class SupplierService : ISupplierService
    {
        private readonly IRepositoryWrapper _repositoryWrapper;

        private readonly IUtilService _utilService;

        public SupplierService(IRepositoryWrapper repositoryWrapper, IUtilService utilService)
        {
            this._repositoryWrapper = repositoryWrapper;

            this._utilService = utilService;

        }
        public async Task<WrapperSupplierListVM> Add(SupplierVM ViewModel)
        {
            var itemToAdd = _utilService.GetMapper().Map<SupplierVM, Supplier>(ViewModel);
            itemToAdd = _repositoryWrapper.Supplier.Create(itemToAdd);
            Task<int> t1 = _repositoryWrapper.Supplier.SaveChangesAsync();
            await Task.WhenAll(t1);
            this._utilService.Log("Successful In Adding Data");

            var dataParam = new GetDataListVM()
            {
                FactoryId = itemToAdd.FactoryId,
                PageNumber = 1,
                PageSize = 10,
                TotalRows = 0
            };
            WrapperSupplierListVM data = await GetListPaged(dataParam, true);
            return data;
        }
        public async Task<WrapperSupplierListVM> Update(string id, SupplierVM ViewModel)
        {
            if (id != ViewModel.Id)
            {
                new WrapperSupplierListVM();
            }

            Task<IEnumerable<Supplier>> itemsDB = _repositoryWrapper.Supplier.FindByConditionAsync(x => x.Id == id && x.FactoryId == ViewModel.FactoryId);
            await Task.WhenAll(itemsDB);

            var itemUpdated = _utilService.GetMapper().Map<SupplierVM, Supplier>(ViewModel, itemsDB.Result.ToList().FirstOrDefault());
            _repositoryWrapper.Supplier.Update(itemUpdated);

            Task<int> t1 = _repositoryWrapper.Supplier.SaveChangesAsync();
            await Task.WhenAll(t1);
            this._utilService.Log("Successful In Updating Data");

            var dataParam = new GetDataListVM()
            {
                FactoryId = ViewModel.FactoryId,
                PageNumber = 1,
                PageSize = 10,
                TotalRows = 0
            };
            WrapperSupplierListVM data = await GetListPaged(dataParam, true);
            return data;
        }
        public async Task<WrapperSupplierListVM> GetListPaged(GetDataListVM dataListVM, bool withHistory)
        {
            IEnumerable<Supplier> ListTask = await _repositoryWrapper.Supplier.FindByConditionAsync(x => x.FactoryId == dataListVM.FactoryId);
            long noOfRecordTask = await _repositoryWrapper.Supplier.NumOfRecord();

            List<Supplier> List = ListTask.ToList().OrderByDescending(x => x.UpdatedDateTime).ToList();//.Skip((dataListVM.PageNumber - 1) * dataListVM.PageSize).Take(dataListVM.PageSize).OrderByDescending(x => x.CreatedDateTime).ToList();

            List<SupplierVM> outputList = new List<SupplierVM>();

            outputList = _utilService.GetMapper().Map<List<Supplier>, List<SupplierVM>>(List);

            if (!string.IsNullOrEmpty(dataListVM.GlobalFilter) && !string.IsNullOrWhiteSpace(dataListVM.GlobalFilter))
            {
                outputList = outputList.Where(output =>
                output.AlternateCellNo != null ? output.AlternateCellNo.Contains(dataListVM.GlobalFilter, StringComparison.OrdinalIgnoreCase) : false
                            || output.CellNo != null ? output.CellNo.Contains(dataListVM.GlobalFilter, StringComparison.OrdinalIgnoreCase) : false
                            || output.Email != null ? output.Email.Contains(dataListVM.GlobalFilter, StringComparison.OrdinalIgnoreCase) : false
                            || output.Name != null ? output.Name.Contains(dataListVM.GlobalFilter, StringComparison.OrdinalIgnoreCase) : false
                             || output.PermanentAddress != null ? output.PermanentAddress.Contains(dataListVM.GlobalFilter, StringComparison.OrdinalIgnoreCase) : false
                              || output.PresentAddress != null ? output.PresentAddress.Contains(dataListVM.GlobalFilter, StringComparison.OrdinalIgnoreCase) : false).ToList();
            }

            outputList = outputList.Skip((dataListVM.PageNumber - 1) * dataListVM.PageSize).Take(dataListVM.PageSize).ToList();
            var data = new WrapperSupplierListVM();
            data.ListOfData = outputList;
            data.TotalRecords = noOfRecordTask;
            this._utilService.Log("Successful In Getting Data");
            if (withHistory)
            {
                data = await SetHistoryOverview(data);
            }


            return data;
        }
        public async Task<WrapperSupplierListVM> Delete(SupplierVM Temp)
        {
            var Task = await _repositoryWrapper.Supplier.FindByConditionAsync(x => x.Id == Temp.Id && x.FactoryId == Temp.FactoryId);
            var datarow = Task.ToList().FirstOrDefault();
            if (datarow == null)
            {
                return new WrapperSupplierListVM();
            }
            _repositoryWrapper.Supplier.Delete(datarow);
            await _repositoryWrapper.Supplier.SaveChangesAsync();
            this._utilService.Log("Successful In Deleting Data");
            var dataParam = new GetDataListVM()
            {
                FactoryId = Temp.FactoryId,
                PageNumber = 1,
                PageSize = 10,
                TotalRows = 0
            };
            WrapperSupplierListVM data = await GetListPaged(dataParam, true);
            return data;
        }
        public async Task<WrapperPaymentListVM> GetSupplierPaymentList(GetPaymentDataListVM vm)
        {
            Task<List<Invoice>> paymentInvoiceListT = _repositoryWrapper
                       .Invoice
                       .FindAll()
                       .Include(x => x.InvoiceType)
                       .Where(x =>
                       (x.InvoiceType.Name == TypeInvoice.SupplierPayment.ToString()
                       || x.InvoiceType.Name == TypeInvoice.Purchase.ToString())
                       && x.ClientId == vm.ClientId
                       && x.FactoryId == vm.FactoryId)
                       .OrderByDescending(x => x.DateOfOcurrance)
                       .Skip((vm.PageNumber - 1) * vm.PageSize)
                       .Take(vm.PageSize)
                       .ToListAsync();
            await paymentInvoiceListT;
            WrapperPaymentListVM wrapperPaymentListVM = new WrapperPaymentListVM();
            wrapperPaymentListVM.ListOfData = _utilService.Mapper.Map<List<Invoice>, List<PaymentVM>>(paymentInvoiceListT.Result.ToList());
            return wrapperPaymentListVM;
        }
        public async Task<WrapperPaymentListVM> DeleteSupplierPayment(PaymentVM vm)
        {
            Task<List<Invoice>> paymentInvoiceListT = _repositoryWrapper
              .Invoice
              .FindAll()
              .Include(x => x.InvoiceType)
              .Where(x =>
               x.InvoiceType.Name == TypeInvoice.SupplierPayment.ToString()
              && x.ClientId == vm.ClientId
              && x.FactoryId == vm.FactoryId
              && vm.InvoiceId == x.Id)
              .ToListAsync();

            Task<List<Expense>> paymentExpenseListT = _repositoryWrapper
              .Expense
              .FindAll()
              .Where(x =>
               x.ClientId == vm.ClientId
              && x.FactoryId == vm.FactoryId
              && x.InvoiceId == vm.InvoiceId)
              .ToListAsync();

            Task<List<TblTransaction>> paymentTransactionListT = _repositoryWrapper
                  .Transaction
                  .FindAll()
                  .Where(x =>
                   x.ClientId == vm.ClientId
                  && x.FactoryId == vm.FactoryId
                  && x.InvoiceId == vm.InvoiceId)
                  .ToListAsync();

            await Task.WhenAll(paymentInvoiceListT, paymentExpenseListT, paymentTransactionListT);


            _repositoryWrapper.Transaction.Delete(paymentTransactionListT.Result.FirstOrDefault());
            _repositoryWrapper.Invoice.Delete(paymentInvoiceListT.Result.FirstOrDefault());
            _repositoryWrapper.Expense.Delete(paymentExpenseListT.Result.FirstOrDefault());

            Task<int> t1 = _repositoryWrapper.Transaction.SaveChangesAsync();
            Task<int> t2 = _repositoryWrapper.Invoice.SaveChangesAsync();
            Task<int> t3 = _repositoryWrapper.Expense.SaveChangesAsync();

            await Task.WhenAll(t1, t2, t3);

            var item = new GetPaymentDataListVM();
            item.ClientId = vm.ClientId;
            item.FactoryId = vm.FactoryId;
            item.PageNumber = 1;
            item.PageSize = 10;

            return await GetSupplierPaymentList(item);

        }
        public async Task<WrapperPaymentListVM> PayToSupplier(PaymentVM paymentVM)
        {
            Invoice invoiceToAdd = new Invoice();
            invoiceToAdd = _utilService.Mapper.Map<PaymentVM, Invoice>(paymentVM);
            _repositoryWrapper.Invoice.Create(invoiceToAdd);

            paymentVM.InvoiceId = invoiceToAdd.Id;

            Expense expenseToAdd = new Expense();
            expenseToAdd = _utilService.Mapper.Map<PaymentVM, Expense>(paymentVM);
            _repositoryWrapper.Expense.Create(expenseToAdd);

            TblTransaction transactionToAdd = new TblTransaction();
            transactionToAdd = _utilService.Mapper.Map<PaymentVM, TblTransaction>(paymentVM);
            transactionToAdd.PaymentStatus = PAYMENT_STATUS.CASH_PAID.ToString();
            transactionToAdd.TransactionType = TRANSACTION_TYPE.DEBIT.ToString();
            _repositoryWrapper.Transaction.Create(transactionToAdd);

            Task<int> t1 = _repositoryWrapper.Invoice.SaveChangesAsync();
            Task<int> t2 = _repositoryWrapper.Expense.SaveChangesAsync();
            Task<int> t3 = _repositoryWrapper.Transaction.SaveChangesAsync();

            await Task.WhenAll(t1, t2, t3);
            var item = new GetPaymentDataListVM();
            item.ClientId = paymentVM.ClientId;
            item.FactoryId = paymentVM.FactoryId;
            item.PageNumber = 1;
            item.PageSize = 10;

            return await GetSupplierPaymentList(item);

        }
        public async Task<WrapperSupplierHistory> GetSupplierHistory(GetDataListHistory supplierVM)
        {

            WrapperSupplierHistory custHist = new WrapperSupplierHistory();
            WrapperSupplierHistory returnCustHist = new WrapperSupplierHistory();
            // Purchase -- Sales Invoice Generated
            // Invoice
            // Expense  -- Payment Invoice Generated

            Task<List<Purchase>> listPurchaseT =
                _repositoryWrapper
                .Purchase
                .FindAll()
                .Where(x => x.FactoryId == supplierVM.FactoryId
                && x.ClientId == supplierVM.ClientId)
                .Include(x => x.Item)
                .Include(x => x.Item.ItemCategory)
                .ToListAsync();

            Task<List<Invoice>> listInvoiceT =
                _repositoryWrapper
                .Invoice
                .FindAll()
                .Where(x => x.FactoryId == supplierVM.FactoryId
                && x.ClientId == supplierVM.ClientId)
                .Include(x => x.InvoiceType)
                .Where(x => x.InvoiceType.Name == TypeInvoice.Purchase.ToString())
                .ToListAsync();

            Task<List<Expense>> listExpenseT =
                _repositoryWrapper
                .Expense
                .FindAll()
                .Where(x => x.FactoryId == supplierVM.FactoryId
                 && x.ClientId == supplierVM.ClientId)
                .Include(x => x.ExpenseType)
                .Where(x => x.ExpenseType.Name == TypeExpense.SupplierPayment.ToString())
                .ToListAsync();

            await Task.WhenAll(listPurchaseT, listInvoiceT, listExpenseT);

            List<SupplierHistory> custHistInvoice = _utilService.Mapper.Map<List<Invoice>, List<SupplierHistory>>(listInvoiceT.Result.ToList());
            List<SupplierHistory> custHistExpense = _utilService.Mapper.Map<List<Expense>, List<SupplierHistory>>(listExpenseT.Result.ToList());
            List<SupplierHistory> custHistPurchase = _utilService.Mapper.Map<List<Purchase>, List<SupplierHistory>>(listPurchaseT.Result.ToList());


            custHist.ListOfData.AddRange(custHistInvoice);
            custHist.ListOfData.AddRange(custHistExpense);
            custHist.ListOfData.OrderByDescending(x => x.OccurranceDate);
            for (int i = 0; i < custHist.ListOfData.Count(); i++)
            {
                IEnumerable<SupplierHistory> tempList = new List<SupplierHistory>();
                if (custHist.ListOfData.ElementAt(i).Type == "InvoiceItem")
                {
                    tempList = custHistPurchase.Where(x => x.InvoiceId == custHist.ListOfData.ElementAt(i).InvoiceId);
                    // custHist.ListOfData.InsertRange(i, tempList);
                    returnCustHist.ListOfData.AddRange(tempList);
                    returnCustHist.ListOfData.Add(custHist.ListOfData.ElementAt(i));
                }
                else
                {
                    returnCustHist.ListOfData.Add(custHist.ListOfData.ElementAt(i));
                }
            }

            var staffHist = GetSupplierHistoryOverview(returnCustHist);
            returnCustHist.ListOfData = returnCustHist.ListOfData
                                    .Skip((supplierVM.PageNumber - 1) * supplierVM.PageSize)
                                    .Take(supplierVM.PageSize)
                                    .ToList();
            returnCustHist.ListOfData.Add(staffHist);
            return returnCustHist;
        }
        public SupplierHistory GetSupplierHistoryOverview(WrapperSupplierHistory list)
        {
            SupplierHistory history = new SupplierHistory();
            for (int i = 0; i < list.ListOfData.Count; i++)
            {
                SupplierHistory temp = list.ListOfData.ElementAt(i);
                if (temp.Type == "InvoiceItem")
                {
                    history.PaidAmount += temp.PaidAmount;
                    history.PayableAmount += temp.PayableAmount;
                }
                else if (temp.Type == "PurchaseItem")
                {

                }
                else if (temp.Type == "ExpenseItem")
                {
                    history.PaidAmount += temp.PaidAmount;
                }
            }
            return history;
        }
        private async Task<WrapperSupplierListVM> SetHistoryOverview(WrapperSupplierListVM vm)
        {
            var data = new GetDataListHistory();
            //Task<WrapperSupplierHistory>[] listOftask = new Task<WrapperSupplierHistory>[vm.ListOfData.Count];
            WrapperSupplierHistory[] listOftask = new WrapperSupplierHistory[vm.ListOfData.Count];
            for (int i = 0; i < vm.ListOfData.Count; i++)
            {
                SupplierVM temp = vm.ListOfData.ElementAt(i);
                data.ClientId = temp.Id;
                data.PageNumber = -1;
                listOftask[i] = await GetSupplierHistory(data);
            }

            // await Task.WhenAll(listOftask);

            for (int i = 0; i < vm.ListOfData.Count; i++)
            {
                //SupplierHistory te = GetSupplierHistoryOverview(listOftask[i].Result);
                SupplierHistory te = GetSupplierHistoryOverview(listOftask[i]);
                vm.ListOfData.ElementAt(i).PaidAmount = te.PaidAmount;
                vm.ListOfData.ElementAt(i).RecievableAmount = te.RecievableAmount;
                vm.ListOfData.ElementAt(i).RecievedAmount = te.RecievedAmount;
                vm.ListOfData.ElementAt(i).PayableAmount = te.PayableAmount;
            }
            return vm;
        }
    }
}
