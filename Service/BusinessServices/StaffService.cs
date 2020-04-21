using AutoMapper;
using Contracts;
using Contracts.ServiceContracts;
using Entities.DbModels;
using Entities.Enums;
using Entities.ViewModels;
using Entities.ViewModels.Payment;
using Entities.ViewModels.Staff;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.BusinessServices
{
    public class StaffService : IStaffService
    {
        private readonly IRepositoryWrapper _repositoryWrapper;

        private readonly IUtilService _utilService;

        public StaffService(IRepositoryWrapper repositoryWrapper, IUtilService utilService)
        {
            this._repositoryWrapper = repositoryWrapper;

            this._utilService = utilService;
        }
        public async Task<WrapperStaffListVM> Add(StaffVM ViewModel)
        {
            var itemToAdd = _utilService.GetMapper().Map<StaffVM, Staff>(ViewModel);
            itemToAdd = _repositoryWrapper.Staff.Create(itemToAdd);
            Task<int> t1 = _repositoryWrapper.Staff.SaveChangesAsync();
            await Task.WhenAll(t1);
            this._utilService.Log("Successful In Adding Data");

            var dataParam = new GetDataListVM()
            {
                FactoryId = itemToAdd.FactoryId,
                PageNumber = 1,
                PageSize = 10,
                TotalRows = 0
            };
            WrapperStaffListVM data = await GetListPaged(dataParam);
            return data;
        }
        public async Task<WrapperStaffListVM> Update(string id, StaffVM ViewModel)
        {
            if (id != ViewModel.Id)
            {
                new WrapperStaffListVM();
            }

            Task<IEnumerable<Staff>> itemsDB = _repositoryWrapper.Staff.FindByConditionAsync(x => x.Id == id && x.FactoryId == ViewModel.FactoryId);
            await Task.WhenAll(itemsDB);

            var itemUpdated = _utilService.GetMapper().Map<StaffVM, Staff>(ViewModel, itemsDB.Result.ToList().FirstOrDefault());
            _repositoryWrapper.Staff.Update(itemUpdated);

            Task<int> t1 = _repositoryWrapper.Staff.SaveChangesAsync();
            await Task.WhenAll(t1);
            this._utilService.Log("Successful In Updating Data");

            var dataParam = new GetDataListVM()
            {
                FactoryId = ViewModel.FactoryId,
                PageNumber = 1,
                PageSize = 10,
                TotalRows = 0
            };
            WrapperStaffListVM data = await GetListPaged(dataParam);
            return data;
        }
        public async Task<WrapperStaffListVM> GetListPaged(GetDataListVM dataListVM)
        {
            IEnumerable<Staff> ListTask = await _repositoryWrapper.Staff.FindByConditionAsync(x => x.FactoryId == dataListVM.FactoryId);
            long noOfRecordTask = await _repositoryWrapper.Staff.NumOfRecord();

            List<Staff> List = ListTask.ToList().OrderByDescending(x => x.UpdatedDateTime).ToList();//.Skip((dataListVM.PageNumber - 1) * dataListVM.PageSize).Take(dataListVM.PageSize).OrderByDescending(x => x.CreatedDateTime).ToList();

            List<StaffVM> outputList = new List<StaffVM>();

            outputList = _utilService.GetMapper().Map<List<Staff>, List<StaffVM>>(List);

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
            var data = new WrapperStaffListVM();
            data.ListOfData = outputList;
            data.TotalRecoreds = noOfRecordTask;
            this._utilService.Log("Successful In Getting Data");
            data = await SetHistoryOverview(data);
            return data;
        }
        public async Task<WrapperStaffListVM> Delete(StaffVM Temp)
        {
            var Task = await _repositoryWrapper.Staff.FindByConditionAsync(x => x.Id == Temp.Id && x.FactoryId == Temp.FactoryId);
            var datarow = Task.ToList().FirstOrDefault();
            if (datarow == null)
            {
                return new WrapperStaffListVM();
            }
            _repositoryWrapper.Staff.Delete(datarow);
            await _repositoryWrapper.Staff.SaveChangesAsync();
            this._utilService.Log("Successful In Deleting Data");
            var dataParam = new GetDataListVM()
            {
                FactoryId = Temp.FactoryId,
                PageNumber = 1,
                PageSize = 10,
                TotalRows = 0
            };
            WrapperStaffListVM data = await GetListPaged(dataParam);
            return data;
        }

        public async Task<WrapperStaffHistory> GetStaffHistory(GetDataListHistory staffVM)
        {
            // Production
            // Expense -- Payment Invoice Generated
            // Invoice

            WrapperStaffHistory wrapperStaffHistory = new WrapperStaffHistory();
            WrapperStaffHistory returnWrapperStaffHistory = new WrapperStaffHistory();
            Task<List<Production>> listProductionT =
                                    _repositoryWrapper
                                    .Production
                                    .FindAll()
                                    .Where(x => x.FactoryId == staffVM.FactoryId
                                    && x.StaffId == staffVM.ClientId)
                                    .Include(x => x.Item)
                                    .Include(x => x.Item.ItemCategory)
                                    .ToListAsync();

            Task<List<Invoice>> listInvoiceT =
                                    _repositoryWrapper
                                    .Invoice
                                    .FindAll()
                                    .Where(x => x.FactoryId == staffVM.FactoryId
                                    && x.ClientId == staffVM.ClientId)
                                    .Include(x => x.InvoiceType)
                                    .Where(x => x.InvoiceType.Name == TypeInvoice.StaffProduction.ToString())
                                    .ToListAsync();
            Task<List<Expense>> listExpenseT =
                                    _repositoryWrapper
                                    .Expense
                                    .FindAll()
                                    .Where(x => x.FactoryId == staffVM.FactoryId
                                     && x.ClientId == staffVM.ClientId)
                                    .Include(x => x.ExpenseType)
                                    .Where(x => x.ExpenseType.Name == TypeExpense.StaffPayment.ToString())
                                    .ToListAsync();
            await Task.WhenAll(listProductionT, listExpenseT);

            List<StaffHistory> production = _utilService.Mapper.Map<List<Production>, List<StaffHistory>>(listProductionT.Result.ToList());
            List<StaffHistory> expense = _utilService.Mapper.Map<List<Expense>, List<StaffHistory>>(listExpenseT.Result.ToList());
            List<StaffHistory> invoice = _utilService.Mapper.Map<List<Invoice>, List<StaffHistory>>(listInvoiceT.Result.ToList());
            wrapperStaffHistory.ListOfData.AddRange(invoice);
            wrapperStaffHistory.ListOfData.AddRange(expense);
            wrapperStaffHistory.ListOfData = wrapperStaffHistory.ListOfData.OrderBy(x => x.OccurranceDate).ToList();
            for (int i = 0; i < wrapperStaffHistory.ListOfData.Count(); i++)
            {
                List<StaffHistory> tempList = new List<StaffHistory>();
                if (wrapperStaffHistory.ListOfData.ElementAt(i).Type == "InvoiceItem")
                {
                    tempList = production.Where(x => x.InvoiceId == wrapperStaffHistory.ListOfData.ElementAt(i).InvoiceId).ToList();
                    returnWrapperStaffHistory.ListOfData.AddRange(tempList);
                    returnWrapperStaffHistory.ListOfData.Add(wrapperStaffHistory.ListOfData.ElementAt(i));
                }
                else
                {
                    returnWrapperStaffHistory.ListOfData.Add(wrapperStaffHistory.ListOfData.ElementAt(i));
                }
            }


            var staffHist = GetStaffHistoryOverview(returnWrapperStaffHistory);
            returnWrapperStaffHistory.ListOfData = returnWrapperStaffHistory.ListOfData
                          .Skip((staffVM.PageNumber - 1) * staffVM.PageSize)
                          .Take(staffVM.PageSize)
                          .ToList();
            returnWrapperStaffHistory.ListOfData.Add(staffHist);
            return returnWrapperStaffHistory;
        }
   
        
        
        public async Task<WrapperPaymentListVM> GetStaffPaymentList(GetPaymentDataListVM vm)
        {
            Task<List<Invoice>> paymentInvoiceListT = _repositoryWrapper
                       .Invoice
                       .FindAll()
                       .Include(x => x.InvoiceType)
                       .Where(x =>
                       x.InvoiceType.Name == TypeInvoice.StaffPayment.ToString()
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
        public async Task<WrapperPaymentListVM> PayToStaff(PaymentVM paymentVM)
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

            return await GetStaffPaymentList(item);


        }
        public async Task<WrapperPaymentListVM> DeleteStaffPayment(PaymentVM vm)
        {
            Task<List<Invoice>> paymentInvoiceListT = _repositoryWrapper
              .Invoice
              .FindAll()
              .Include(x => x.InvoiceType)
              .Where(x =>
               x.InvoiceType.Name == TypeInvoice.StaffPayment.ToString()
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

            return await GetStaffPaymentList(item);
        }


        public StaffHistory GetStaffHistoryOverview(WrapperStaffHistory list)
        {
            StaffHistory history = new StaffHistory();
            for (int i = 0; i < list.ListOfData.Count; i++)
            {
                StaffHistory temp = list.ListOfData.ElementAt(i);
                if (temp.Type == "InvoiceItem")
                {
                    history.PaidAmount += temp.PaidAmount;
                    history.PayableAmount += temp.PayableAmount;
                }
                else if (temp.Type == "ProductionItem")
                {

                }
                else if (temp.Type == "ExpenseItem")
                {
                    history.PaidAmount += temp.PaidAmount;
                }
            }
            return history;
        }


        private async Task<WrapperStaffListVM> SetHistoryOverview(WrapperStaffListVM vm)
        {
            var data = new GetDataListHistory();
            Task<WrapperStaffHistory>[] listOftask = new Task<WrapperStaffHistory>[vm.ListOfData.Count];
            for (int i = 0; i < vm.ListOfData.Count; i++)
            {
                StaffVM temp = vm.ListOfData.ElementAt(i);
                data.ClientId = temp.Id;
                data.PageNumber = -1;
                listOftask[i] = GetStaffHistory(data);
            }

            await Task.WhenAll(listOftask);

            for (int i = 0; i < vm.ListOfData.Count; i++)
            {
                StaffHistory te = GetStaffHistoryOverview(listOftask[i].Result);
                vm.ListOfData.ElementAt(i).PaidAmount = te.PaidAmount;
                vm.ListOfData.ElementAt(i).RecievableAmount = te.RecievableAmount;
                vm.ListOfData.ElementAt(i).RecievedAmount = te.RecievedAmount;
                vm.ListOfData.ElementAt(i).PayableAmount = te.PayableAmount;
            }
            return vm;
        }



    }
}
