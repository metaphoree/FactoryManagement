using CommonUtils;
using Contracts;
using Contracts.IBusinessServiceWrapper;
using Entities.DbModels;
using Entities.Enums;
using Entities.ViewModels.CustomerView;
using Entities.ViewModels.Payment;
using Entities.ViewModels.Staff;
using Entities.ViewModels.Supplier;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Service.BusinessServiceWrapper
{
    public class BusinessWrapperService : IBusinessWrapperService
    {
        private readonly IServiceWrapper _serviceWrapper;
        private readonly IRepositoryWrapper _repositoryWrapper;
        private readonly IUtilService _utilService;

        public BusinessWrapperService(IServiceWrapper serviceWrapper, IRepositoryWrapper repositoryWrapper, IUtilService utilService)
        {
            this._repositoryWrapper = repositoryWrapper;
            this._serviceWrapper = serviceWrapper;
            this._utilService = utilService;
        }


        public async Task<CommonResponse> PayToSupplier(PaymentVM paymentVM)
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
            return new CommonResponse() { Message = "Successfully Paid from Supplier" };

        }
        public async Task<CommonResponse> PayToWorker(PaymentVM paymentVM)
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
            return new CommonResponse() { Message = "Successfully Paid from Worker" };


        }
        public async Task<CommonResponse> RecieveFromCustomer(PaymentVM paymentVM)
        {
            Invoice invoiceToAdd = new Invoice();
            invoiceToAdd = _utilService.Mapper.Map<PaymentVM, Invoice>(paymentVM);
            _repositoryWrapper.Invoice.Create(invoiceToAdd);
            paymentVM.InvoiceId = invoiceToAdd.Id;


            Income incomeToAdd = new Income();
            incomeToAdd = _utilService.Mapper.Map<PaymentVM, Income>(paymentVM);
            _repositoryWrapper.Income.Create(incomeToAdd);

            TblTransaction transactionToAdd = new TblTransaction();
            transactionToAdd = _utilService.Mapper.Map<PaymentVM, TblTransaction>(paymentVM);
            transactionToAdd.PaymentStatus = PAYMENT_STATUS.CASH_RECIEVED.ToString();
            transactionToAdd.TransactionType = TRANSACTION_TYPE.CREDIT.ToString();
            _repositoryWrapper.Transaction.Create(transactionToAdd);

            Task<int> t1 = _repositoryWrapper.Invoice.SaveChangesAsync();
            Task<int> t2 = _repositoryWrapper.Income.SaveChangesAsync();
            Task<int> t3 = _repositoryWrapper.Transaction.SaveChangesAsync();

            await Task.WhenAll(t1, t2, t3);

            return new CommonResponse() { Message = "Successfully Recieved from Customer " };

        }



        public async Task<WrapperCustomerHistory> GetCustomerHistory(CustomerVM customerVM)
        {
            WrapperCustomerHistory custHist = new WrapperCustomerHistory();
            // Sales -- Sales Invoice Generated
            // Invoice
            // Income -- Payment Invoice Generated
            Task<List<Sales>> listSalesT =
                _repositoryWrapper
                .Sales
                .FindAll()
                .Where(x => x.FactoryId == customerVM.FactoryId
                && x.ClientId == customerVM.CustomerId)
                .Include(x => x.Item)
                .Include(x => x.Item.ItemCategory)
                .ToListAsync();

            Task<List<Invoice>> listInvoiceT =
                _repositoryWrapper
                .Invoice
                .FindAll()
                .Where(x => x.FactoryId == customerVM.FactoryId
                && x.ClientId == customerVM.CustomerId)
                .Include(x => x.InvoiceType)
                .Where(x => x.InvoiceType.Name == TypeInvoice.Sales.ToString())
                .ToListAsync();

            Task<List<Income>> listIncomeT =
                _repositoryWrapper
                .Income
                .FindAll()
                .Where(x => x.FactoryId == customerVM.FactoryId
                 && x.ClientId == customerVM.CustomerId)
                .Include(x => x.IncomeType)
                .Where(x => x.IncomeType.Name == TypeIncome.Sales.ToString())
                .ToListAsync();

            await Task.WhenAll(listSalesT, listInvoiceT, listIncomeT);

            List<CustomerHistory> custHistInvoice = _utilService.Mapper.Map<List<Invoice>, List<CustomerHistory>>(listInvoiceT.Result.ToList());
            List<CustomerHistory> custHistIncome = _utilService.Mapper.Map<List<Income>, List<CustomerHistory>>(listIncomeT.Result.ToList());
            List<CustomerHistory> custHistSales = _utilService.Mapper.Map<List<Sales>, List<CustomerHistory>>(listSalesT.Result.ToList());


            custHist.ListOfData.AddRange(custHistInvoice);
            custHist.ListOfData.AddRange(custHistIncome);
            custHist.ListOfData.OrderByDescending(x => x.OccurranceDate);
            for (int i = 0; i < custHist.ListOfData.Count(); i++)
            {
                IEnumerable<CustomerHistory> tempList = new List<CustomerHistory>();
                if (custHist.ListOfData.ElementAt(i).Type == "InvoiceItem")
                {
                    tempList = custHistSales.Where(x => x.InvoiceId == custHist.ListOfData.ElementAt(i).InvoiceId);
                    custHist.ListOfData.InsertRange(i, tempList);
                }
            }
            return custHist;
        }

        public async Task<WrapperSupplierHistory> GetSupplierHistory(SupplierVM supplierVM)
        {
            WrapperSupplierHistory custHist = new WrapperSupplierHistory();
            // Purchase -- Sales Invoice Generated
            // Invoice
            // Expense  -- Payment Invoice Generated

            Task<List<Purchase>> listPurchaseT =
                _repositoryWrapper
                .Purchase
                .FindAll()
                .Where(x => x.FactoryId == supplierVM.FactoryId
                && x.ClientId == supplierVM.Id)
                .Include(x => x.Item)
                .Include(x => x.Item.ItemCategory)
                .ToListAsync();

            Task<List<Invoice>> listInvoiceT =
                _repositoryWrapper
                .Invoice
                .FindAll()
                .Where(x => x.FactoryId == supplierVM.FactoryId
                && x.ClientId == supplierVM.Id)
                .Include(x => x.InvoiceType)
                .Where(x => x.InvoiceType.Name == TypeInvoice.Purchase.ToString())
                .ToListAsync();

            Task<List<Expense>> listExpenseT =
                _repositoryWrapper
                .Expense
                .FindAll()
                .Where(x => x.FactoryId == supplierVM.FactoryId
                 && x.ClientId == supplierVM.Id)
                .Include(x => x.ExpenseType)
                .Where(x => x.ExpenseType.Name == TypeExpense.Purchase.ToString())
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
                    custHist.ListOfData.InsertRange(i, tempList);
                }
            }
            return custHist;
        }

        public async Task<WrapperStaffHistory> GetStaffHistory(StaffVM staffVM)
        {
            // Production
            // Expense -- Payment Invoice Generated
            // Invoice

            WrapperStaffHistory wrapperStaffHistory = new WrapperStaffHistory();
            Task<List<Production>> listProductionT =
                                    _repositoryWrapper
                                    .Production
                                    .FindAll()
                                    .Where(x => x.FactoryId == staffVM.FactoryId
                                    && x.StaffId == staffVM.Id)
                                    .Include(x => x.Item)
                                    .Include(x => x.Item.ItemCategory)
                                    .ToListAsync();


            Task<List<Expense>> listExpenseT =
                                    _repositoryWrapper
                                    .Expense
                                    .FindAll()
                                    .Where(x => x.FactoryId == staffVM.FactoryId
                                     && x.ClientId == staffVM.Id)
                                    .Include(x => x.ExpenseType)
                                    .Where(x => x.ExpenseType.Name == TypeExpense.StaffSalary.ToString())
                                    .ToListAsync();
            await Task.WhenAll(listProductionT, listExpenseT);

            List<StaffHistory> production = _utilService.Mapper.Map<List<Production>, List<StaffHistory>>(listProductionT.Result.ToList());
            List<StaffHistory> expense = _utilService.Mapper.Map<List<Expense>, List<StaffHistory>>(listExpenseT.Result.ToList());

            wrapperStaffHistory.ListOfData.AddRange(production);
            wrapperStaffHistory.ListOfData.AddRange(expense);
            return wrapperStaffHistory;
        }

    }
}
