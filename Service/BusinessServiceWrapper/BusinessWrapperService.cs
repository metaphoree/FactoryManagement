using CommonUtils;
using Contracts;
using Contracts.IBusinessServiceWrapper;
using Entities.DbModels;
using Entities.Enums;
using Entities.ViewModels;
using Entities.ViewModels.CustomerView;
using Entities.ViewModels.Expense;
using Entities.ViewModels.Income;
using Entities.ViewModels.Payable;
using Entities.ViewModels.Payment;
using Entities.ViewModels.Production;
using Entities.ViewModels.Recievable;
using Entities.ViewModels.Staff;
using Entities.ViewModels.Supplier;
using Entities.ViewModels.Transaction;
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
        private readonly FactoryManagementContext _context;

        public BusinessWrapperService(IServiceWrapper serviceWrapper,
            IRepositoryWrapper repositoryWrapper,
            IUtilService utilService,
            FactoryManagementContext context)
        {
            this._repositoryWrapper = repositoryWrapper;
            this._serviceWrapper = serviceWrapper;
            this._utilService = utilService;
            this._context = context;
        }

        #region Monthly Report Region
        public async Task<WrapperMonthProductionListVM> MonthlyProduction(MonthlyReport vm)
        {

            WrapperMonthProductionListVM returnData = new WrapperMonthProductionListVM();
            Task<List<Production>> prodT = _repositoryWrapper
                .Production
                .FindAll()
                .Where(x => x.FactoryId == vm.FactoryId)
                .Where(x => x.Month == vm.Month)
                .Include(x => x.Item)
                .Include(x => x.ItemCategory)
                .Include(x => x.Staff)
                .ToListAsync();

            await Task.WhenAll(prodT);

            List<MonthlyProduction> monthlyProductions = new List<MonthlyProduction>();
            monthlyProductions = _utilService.Mapper.Map<List<Production>, List<MonthlyProduction>>(prodT.Result.ToList());


            returnData.TotalRecords = prodT.Result.ToList().Count();
            returnData.ListOfData = monthlyProductions;
            MonthlyProduction lastRow = new MonthlyProduction();
            lastRow.TotalAmount = returnData.ListOfData.Sum(x => (x.Quantity));

            returnData.ListOfData = monthlyProductions
                .Skip((vm.PageNumber - 1) * (vm.PageSize))
                .Take(vm.PageSize)
                .OrderByDescending(x => x.CreatedDateTime)
                .ToList();

            returnData.Total_TillNow = lastRow.TotalAmount;
            returnData.Total_Monthly = returnData.ListOfData.Sum(x => (x.Quantity));

            returnData.ListOfData.Add(lastRow);

            return returnData;
        }
        public async Task<WrapperMonthPayableListVM> MonthlyPayable(MonthlyReport vm)
        {

            WrapperMonthPayableListVM returnData = new WrapperMonthPayableListVM();

            Task<List<Payable>> payableT = _repositoryWrapper
                .Payable
                .FindAll()
                .Where(x => x.FactoryId == vm.FactoryId)
                .Where(x => x.Month == vm.Month)
                .Include(x => x.Supplier)
                .Include(x => x.Customer)
                .ToListAsync();
            Task<List<Payable>> payableT_1 = _repositoryWrapper
                .Payable
                .FindAll()
                .Where(x => x.FactoryId == vm.FactoryId)
                .Where(x => x.Month == vm.Month)
                .Include(x => x.Customer)
                .ToListAsync();
            Task<List<Payable>> payableT_2 = _repositoryWrapper
                .Payable
                .FindAll()
                .Where(x => x.FactoryId == vm.FactoryId)
                .Where(x => x.Month == vm.Month)
                .Include(x => x.Staff)
                .ToListAsync();


           await Task.WhenAll(payableT, payableT_1, payableT_2);
            List<Payable> lst = payableT.Result.ToList();
            lst = _utilService.ConcatList<Payable>(payableT.Result.ToList(), _utilService.ConcatList<Payable>(payableT_1.Result.ToList(), payableT_2.Result.ToList()));
            List<MonthlyPayable> monthlyPayable = new List<MonthlyPayable>();
            monthlyPayable = _utilService.Mapper.Map<List<Payable>, List<MonthlyPayable>>(lst);

            returnData.TotalRecords = payableT.Result.ToList().Count();
            returnData.ListOfData = monthlyPayable;
            MonthlyPayable lastRow = new MonthlyPayable();
            lastRow.Amount = returnData.ListOfData.Sum(x => (x.Amount));

            returnData.ListOfData = monthlyPayable
                .Skip((vm.PageNumber - 1) * (vm.PageSize))
                .Take(vm.PageSize)
                .OrderByDescending(x => x.CreatedDateTime)
                .ToList();

            returnData.Total_TillNow = lastRow.Amount;
            returnData.Total_Monthly = returnData.ListOfData.Sum(x => (x.Amount));

            returnData.ListOfData.Add(lastRow);



            return returnData;
        }
        public async Task<WrapperMonthRecievableVM> MonthlyRecievable(MonthlyReport vm)
        {

            WrapperMonthRecievableVM returnData = new WrapperMonthRecievableVM();
            Task<List<Recievable>> RecievableT = _repositoryWrapper
                .Recievable
                .FindAll()
                .Where(x => x.FactoryId == vm.FactoryId)
                .Where(x => x.Month == vm.Month)
                .Include(x => x.Customer)
                //.Include(x => x.ItemCategory)
                //.Include(x => x.Staff)  
                .ToListAsync();

            await Task.WhenAll(RecievableT);

            List<MonthlyRecievable> monthlyRecievable = new List<MonthlyRecievable>();
            monthlyRecievable = _utilService.Mapper.Map<List<Recievable>, List<MonthlyRecievable>>(RecievableT.Result.ToList());


            returnData.TotalRecords = RecievableT
                .Result
                .ToList()
                .Count();

            MonthlyRecievable lastRow = new MonthlyRecievable();

            returnData.ListOfData = monthlyRecievable;
            lastRow.Amount = returnData.ListOfData.Sum(x => (x.Amount));

            returnData.ListOfData = monthlyRecievable
                .Skip((vm.PageNumber - 1) * (vm.PageSize))
                .Take(vm.PageSize)
                .OrderByDescending(x => x.CreatedDateTime)
                .ToList();

            returnData.Total_TillNow = lastRow.Amount;
            returnData.Total_Monthly = returnData.ListOfData.Sum(x => (x.Amount));

            returnData.ListOfData.Add(lastRow);


            return returnData;
        }
        public async Task<WrapperMonthIncomeVM> MonthlyIncome(MonthlyReport vm)
        {

            WrapperMonthIncomeVM returnData = new WrapperMonthIncomeVM();
            Task<List<Income>> IncomeT = _repositoryWrapper
                .Income
                .FindAll()
                .Where(x => x.FactoryId == vm.FactoryId)
                .Where(x => x.Month == vm.Month)
                .Include(x => x.Customer)
                //.Include(x => x.ItemCategory)
                //.Include(x => x.Staff)  
                .ToListAsync();

            await Task.WhenAll(IncomeT);

            List<MonthlyIncome> monthlyIncome = new List<MonthlyIncome>();
            monthlyIncome = _utilService.Mapper.Map<List<Income>, List<MonthlyIncome>>(IncomeT.Result.ToList());


            returnData.TotalRecords = IncomeT
                .Result
                .ToList()
                .Count();

            MonthlyIncome lastRow = new MonthlyIncome();
            returnData.ListOfData = monthlyIncome;
            lastRow.Amount = returnData.ListOfData.Sum(x => (x.Amount));

            returnData.ListOfData = monthlyIncome
                .Skip((vm.PageNumber - 1) * (vm.PageSize))
                .Take(vm.PageSize)
                .OrderByDescending(x => x.CreatedDateTime)
                .ToList();


            returnData.Total_TillNow = lastRow.Amount;
            returnData.Total_Monthly = returnData.ListOfData.Sum(x => (x.Amount));
            returnData.ListOfData.Add(lastRow);


            return returnData;
        }
        public async Task<WrapperMonthExpenseVM> MonthlyExpense(MonthlyReport vm)
        {

            WrapperMonthExpenseVM returnData = new WrapperMonthExpenseVM();
            Task<List<Expense>> ExpenseT = _repositoryWrapper
                .Expense
                .FindAll()
                .Where(x => x.FactoryId == vm.FactoryId)
                .Where(x => x.Month == vm.Month)
                .Include(x => x.Supplier)
                //.Include(x => x.ItemCategory)
                //.Include(x => x.Staff)  
                .ToListAsync();

            await Task.WhenAll(ExpenseT);

            List<MonthlyExpense> monthlyExpense = new List<MonthlyExpense>();
            monthlyExpense = _utilService.Mapper.Map<List<Expense>, List<MonthlyExpense>>(ExpenseT.Result.ToList());


            returnData.TotalRecords = ExpenseT
                .Result
                .ToList()
                .Count();

            MonthlyExpense lastRow = new MonthlyExpense();
            returnData.ListOfData = monthlyExpense;
            lastRow.Amount = returnData.ListOfData.Sum(x => (x.Amount));

            returnData.ListOfData = monthlyExpense
                .Skip((vm.PageNumber - 1) * (vm.PageSize))
                .Take(vm.PageSize)
                .OrderByDescending(x => x.CreatedDateTime)
                .ToList();

            returnData.Total_TillNow = lastRow.Amount;
            returnData.Total_Monthly = returnData.ListOfData.Sum(x => (x.Amount));
            returnData.ListOfData.Add(lastRow);


            return returnData;
        }
        public async Task<WrapperMonthTransactionVM> MonthlyTransaction(MonthlyReport vm)
        {

            WrapperMonthTransactionVM returnData = new WrapperMonthTransactionVM();
            Task<List<TblTransaction>> ExpenseT = _repositoryWrapper
                .Transaction
                .FindAll()
                .Where(x => x.FactoryId == vm.FactoryId)
                .Where(x => x.Month == vm.Month)
                //.Include(x => x.Supplier)
                //.Include(x => x.ItemCategory)
                //.Include(x => x.Staff)  
                .ToListAsync();

            await Task.WhenAll(ExpenseT);

            List<MonthlyTransaction> monthlyExpense = new List<MonthlyTransaction>();
            monthlyExpense = _utilService.Mapper.Map<List<TblTransaction>, List<MonthlyTransaction>>(ExpenseT.Result.ToList());


            returnData.TotalRecords = ExpenseT
                .Result
                .ToList()
                .Count();

            returnData.TotalTillNow_Credit = returnData.ListOfData.Where(x => x.TransactionType == TRANSACTION_TYPE.CREDIT.ToString()).Sum(x => x.Amount);
            returnData.TotalTillNow_Debit = returnData.ListOfData.Where(x => x.TransactionType == TRANSACTION_TYPE.DEBIT.ToString()).Sum(x => x.Amount);

            returnData.ListOfData = monthlyExpense
                .Skip((vm.PageNumber - 1) * (vm.PageSize))
                .Take(vm.PageSize)
                .OrderByDescending(x => x.CreatedDateTime)
                .ToList();

            returnData.TotalTillNow_Credit = returnData.ListOfData.Where(x => x.TransactionType == TRANSACTION_TYPE.CREDIT.ToString()).Sum(x => x.Amount);
            returnData.TotalTillNow_Debit = returnData.ListOfData.Where(x => x.TransactionType == TRANSACTION_TYPE.DEBIT.ToString()).Sum(x => x.Amount);

            //MonthlyTransaction lastRow = new MonthlyTransaction();
            //lastRow.Amount = returnData.ListOfData.Sum(x => (x.Amount));
            //returnData.ListOfData.Add(lastRow);


            return returnData;
        }
        #endregion

































        #region Payment
        #region Supplier

        #endregion
        #region Staff


        #endregion
        #region Customer
        #endregion
        #endregion
        #region History
        #region Supplier

        #endregion

        #region Customer

        #endregion

        #region Staff

        #endregion

        #endregion



    }
}
