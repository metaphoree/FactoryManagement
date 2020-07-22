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

        public BusinessWrapperService(IServiceWrapper serviceWrapper,
            IRepositoryWrapper repositoryWrapper,
            IUtilService utilService)
        {
            this._repositoryWrapper = repositoryWrapper;
            this._serviceWrapper = serviceWrapper;
            this._utilService = utilService;
        }

        #region Monthly Report Region
        public async Task<WrapperMonthProductionListVM> MonthlyProduction(MonthlyReport vm)
        {
            vm.To = vm.To.ToLocalTime();
            vm.From = vm.From.ToLocalTime();
            WrapperMonthProductionListVM returnData = new WrapperMonthProductionListVM();
            Task<List<Production>> prodT = _repositoryWrapper
                .Production
                .FindAll()
                .Where(x => x.EntryDate >= vm.From)
                .Where(x => x.EntryDate <= vm.To)
                .Where(x => x.FactoryId == vm.FactoryId)
                // .Where(x => x.Month == vm.Month)
                .Include(x => x.Item)
                .Include(x => x.ItemCategory)
                .Include(x => x.Staff)
                .ToListAsync();

            await Task.WhenAll(prodT);

            List<MonthlyProduction> monthlyProductions = new List<MonthlyProduction>();
            monthlyProductions = _utilService.Mapper.Map<List<Production>, List<MonthlyProduction>>(prodT.Result.ToList());


            returnData.TotalRecords = monthlyProductions.ToList().Count();
            returnData.ListOfData = monthlyProductions;
            MonthlyProduction lastRow = new MonthlyProduction();
            lastRow.TotalAmount = returnData.ListOfData.Sum(x => (x.Quantity));

            returnData.ListOfData = monthlyProductions
                 .OrderByDescending(x => x.CreatedDateTime)
                .Skip((vm.PageNumber - 1) * (vm.PageSize))
                .Take(vm.PageSize)

                .ToList();

            returnData.Total_TillNow = lastRow.TotalAmount;
            returnData.Total_Monthly = returnData.ListOfData.Sum(x => (x.Quantity));

            returnData.ListOfData.Add(lastRow);

            return returnData;
        }
        public async Task<WrapperMonthPayableListVM> MonthlyPayable(MonthlyReport vm)
        {

            vm.To = vm.To.ToLocalTime();
            vm.From = vm.From.ToLocalTime();

            WrapperMonthPayableListVM returnData = new WrapperMonthPayableListVM();

            Task<List<Payable>> payableT = _repositoryWrapper
                .Payable
                .FindAll()
                .Where(x => x.FactoryId == vm.FactoryId)
                //.Where(x => x.Month == vm.Month)
                .Where(x => x.CreatedDateTime >= vm.From)
                .Where(x => x.CreatedDateTime <= vm.To)
                .Include(x => x.Supplier)
                .ToListAsync();
            await payableT;
            Task<List<Payable>> payableT_1 = _repositoryWrapper
                .Payable
                .FindAll()
                .Where(x => x.FactoryId == vm.FactoryId)
                //.Where(x => x.Month == vm.Month)
                .Where(x => x.CreatedDateTime >= vm.From)
                .Where(x => x.CreatedDateTime <= vm.To)
                .Include(x => x.Customer)
                .ToListAsync();
            await payableT_1;
            Task<List<Payable>> payableT_2 = _repositoryWrapper
                .Payable
                .FindAll()
                .Where(x => x.FactoryId == vm.FactoryId)
                .Where(x => x.CreatedDateTime >= vm.From)
                .Where(x => x.CreatedDateTime <= vm.To)
                //.Where(x => x.Month == vm.Month)
                .Include(x => x.Staff)
                .ToListAsync();
            await payableT_2;
            //await Task.WhenAll(payableT, payableT_1, payableT_2);
            List<Payable> lst = payableT.Result.ToList();
            lst = _utilService.ConcatList<Payable>(payableT.Result.ToList(), _utilService.ConcatList<Payable>(payableT_1.Result.ToList(), payableT_2.Result.ToList()));
            List<MonthlyPayable> monthlyPayable = new List<MonthlyPayable>();
            monthlyPayable = _utilService.Mapper.Map<List<Payable>, List<MonthlyPayable>>(lst);



            returnData.TotalRecords = monthlyPayable.ToList().Count();
            returnData.ListOfData = monthlyPayable;
            MonthlyPayable lastRow = new MonthlyPayable();
            lastRow.Amount = returnData.ListOfData.Sum(x => (x.Amount));

            returnData.ListOfData = monthlyPayable
                .OrderByDescending(x => x.CreatedDateTime)
                .Skip((vm.PageNumber - 1) * (vm.PageSize))
                .Take(vm.PageSize)

                .ToList();

            returnData.Total_TillNow = lastRow.Amount;
            returnData.Total_Monthly = returnData.ListOfData.Sum(x => (x.Amount));

            returnData.ListOfData.Add(lastRow);



            return returnData;
        }
        public async Task<WrapperMonthRecievableVM> MonthlyRecievable(MonthlyReport vm)
        {
            vm.To = vm.To.ToLocalTime();
            vm.From = vm.From.ToLocalTime();
            WrapperMonthRecievableVM returnData = new WrapperMonthRecievableVM();
            Task<List<Recievable>> RecievableT = _repositoryWrapper
                .Recievable
                .FindAll()
                .Where(x => x.FactoryId == vm.FactoryId)
                //.Where(x => x.Month == vm.Month)
                .Where(x => x.CreatedDateTime >= vm.From)
                .Where(x => x.CreatedDateTime <= vm.To)
                .Include(x => x.Staff)
                .ToListAsync();
            await RecievableT;
            Task<List<Recievable>> RecievableT_1 = _repositoryWrapper
                .Recievable
                .FindAll()
                .Where(x => x.FactoryId == vm.FactoryId)
                .Where(x => x.CreatedDateTime >= vm.From)
                .Where(x => x.CreatedDateTime <= vm.To)
                // .Where(x => x.Month == vm.Month)
                .Include(x => x.Supplier)
                .ToListAsync();
            await RecievableT_1;

            Task<List<Recievable>> RecievableT_2 = _repositoryWrapper
                .Recievable
                .FindAll()
                .Where(x => x.FactoryId == vm.FactoryId)
                .Where(x => x.CreatedDateTime >= vm.From)
                .Where(x => x.CreatedDateTime <= vm.To)
                // .Where(x => x.Month == vm.Month)
                .Include(x => x.Customer)
                .ToListAsync();
            await RecievableT_2;

            // await Task.WhenAll(RecievableT, RecievableT_1, RecievableT_2);

            List<Recievable> lst = RecievableT.Result.ToList();
            lst = _utilService.ConcatList<Recievable>(RecievableT.Result.ToList(), _utilService.ConcatList<Recievable>(RecievableT_1.Result.ToList(), RecievableT_2.Result.ToList()));

            List<MonthlyRecievable> monthlyRecievable = new List<MonthlyRecievable>();
            monthlyRecievable = _utilService.Mapper.Map<List<Recievable>, List<MonthlyRecievable>>(lst);


            returnData.TotalRecords = monthlyRecievable

                .ToList()
                .Count();

            MonthlyRecievable lastRow = new MonthlyRecievable();

            returnData.ListOfData = monthlyRecievable;
            lastRow.Amount = returnData.ListOfData.Sum(x => (x.Amount));

            returnData.ListOfData = monthlyRecievable
                .OrderByDescending(x => x.CreatedDateTime)
                .Skip((vm.PageNumber - 1) * (vm.PageSize))
                .Take(vm.PageSize)

                .ToList();

            returnData.Total_TillNow = lastRow.Amount;
            returnData.Total_Monthly = returnData.ListOfData.Sum(x => (x.Amount));

            returnData.ListOfData.Add(lastRow);


            return returnData;
        }
        public async Task<WrapperMonthIncomeVM> MonthlyIncome(MonthlyReport vm)
        {
            vm.To = vm.To.ToLocalTime();
            vm.From = vm.From.ToLocalTime();
            WrapperMonthIncomeVM returnData = new WrapperMonthIncomeVM();
            Task<List<Income>> IncomeT = _repositoryWrapper
                .Income
                .FindAll()
                .Where(x => x.FactoryId == vm.FactoryId)
                //.Where(x => x.Month == vm.Month)
                .Where(x => x.CreatedDateTime >= vm.From)
                .Where(x => x.CreatedDateTime <= vm.To)
                .Include(x => x.Staff)
                .Include(x => x.Supplier)
                .Include(x => x.Customer)
                .ToListAsync();
            await IncomeT;
            //Task<List<Income>> IncomeT_1 = _repositoryWrapper
            //    .Income
            //    .FindAll()
            //    .Where(x => x.FactoryId == vm.FactoryId)
            //    .Where(x => x.Month == vm.Month)
            //    .Include(x => x.Customer)
            //    .ToListAsync();
            //await IncomeT_1;
            //Task<List<Income>> IncomeT_2 = _repositoryWrapper
            //    .Income
            //    .FindAll()
            //    .Where(x => x.FactoryId == vm.FactoryId)
            //    .Where(x => x.Month == vm.Month)
            //    .Include(x => x.Supplier)
            //    .ToListAsync();
            //await IncomeT_2;
            // await Task.WhenAll(IncomeT, IncomeT_1, IncomeT_2);

            List<Income> lst = IncomeT.Result.ToList();
            //  lst = _utilService.ConcatList<Income>(IncomeT.Result.ToList(), _utilService.ConcatList<Income>(IncomeT_1.Result.ToList(), IncomeT_2.Result.ToList()));



            List<MonthlyIncome> monthlyIncome = new List<MonthlyIncome>();
            monthlyIncome = _utilService.Mapper.Map<List<Income>, List<MonthlyIncome>>(lst);


            returnData.TotalRecords = monthlyIncome

                .ToList()
                .Count();

            MonthlyIncome lastRow = new MonthlyIncome();
            returnData.ListOfData = monthlyIncome;
            lastRow.Amount = returnData.ListOfData.Sum(x => (x.Amount));

            returnData.ListOfData = monthlyIncome
                .OrderByDescending(x => x.CreatedDateTime)
                .Skip((vm.PageNumber - 1) * (vm.PageSize))
                .Take(vm.PageSize)

                .ToList();


            returnData.Total_TillNow = lastRow.Amount;
            returnData.Total_Monthly = returnData.ListOfData.Sum(x => (x.Amount));
            returnData.ListOfData.Add(lastRow);


            return returnData;
        }
        public async Task<WrapperMonthExpenseVM> MonthlyExpense(MonthlyReport vm)
        {
            vm.To = vm.To.ToLocalTime();
            vm.From = vm.From.ToLocalTime();
            WrapperMonthExpenseVM returnData = new WrapperMonthExpenseVM();
            //Task<List<Expense>> ExpenseT = _repositoryWrapper
            //    .Expense
            //    .FindAll()
            //    .Where(x => x.FactoryId == vm.FactoryId)
            //    .Where(x => x.Month == vm.Month)
            //    .Include(x => x.Staff)
            //    .Include(x => x.Supplier)
            //    .Include(x => x.Customer)
            //    .ToListAsync();
            Task<List<Expense>> ExpenseT = _repositoryWrapper
                    .Expense
                    .FindAll()
                    .Where(x => x.FactoryId == vm.FactoryId)
                    .Where(x => x.OccurranceDate >= vm.From)
                    .Where(x => x.OccurranceDate <= vm.To)
                    .Include(x => x.Staff)
                    .Include(x => x.Supplier)
                    .Include(x => x.Customer)
                    .ToListAsync();






            await ExpenseT;
            //Task<List<Expense>> ExpenseT_1 = _repositoryWrapper
            //      .Expense
            //      .FindAll()
            //      .Where(x => x.FactoryId == vm.FactoryId)
            //      .Where(x => x.Month == vm.Month)
            //      .Include(x => x.Supplier)
            //      .ToListAsync();
            //await ExpenseT_1;
            //Task<List<Expense>> ExpenseT_2 = _repositoryWrapper
            //        .Expense
            //        .FindAll()
            //        .Where(x => x.FactoryId == vm.FactoryId)
            //        .Where(x => x.Month == vm.Month)
            //        .Include(x => x.Staff)
            //        .ToListAsync();



            //await ExpenseT_2;
            // await Task.WhenAll(ExpenseT);


            List<Expense> lst = ExpenseT.Result.ToList();
            // lst = _utilService.ConcatList<Expense>(ExpenseT.Result.ToList(), _utilService.ConcatList<Expense>(ExpenseT_1.Result.ToList(), ExpenseT_2.Result.ToList()));

            List<MonthlyExpense> monthlyExpense = new List<MonthlyExpense>();
            monthlyExpense = _utilService.Mapper.Map<List<Expense>, List<MonthlyExpense>>(lst);


            returnData.TotalRecords = monthlyExpense

                .ToList()
                .Count();

            MonthlyExpense lastRow = new MonthlyExpense();
            returnData.ListOfData = monthlyExpense;
            lastRow.Amount = returnData.ListOfData.Sum(x => (x.Amount));

            returnData.ListOfData = monthlyExpense
                .OrderByDescending(x => x.CreatedDateTime)
                .Skip((vm.PageNumber - 1) * (vm.PageSize))
                .Take(vm.PageSize)

                .ToList();

            returnData.Total_TillNow = lastRow.Amount;
            returnData.Total_Monthly = returnData.ListOfData.Sum(x => (x.Amount));
            returnData.ListOfData.Add(lastRow);


            return returnData;
        }
        public async Task<WrapperMonthTransactionVM> MonthlyTransaction(MonthlyReport vm)
        {
            vm.To = vm.To.ToLocalTime();
            vm.From = vm.From.ToLocalTime();
            WrapperMonthTransactionVM returnData = new WrapperMonthTransactionVM();
            Task<List<TblTransaction>> ExpenseT = _repositoryWrapper
                .Transaction
                .FindAll()
                .Where(x => x.FactoryId == vm.FactoryId)
                //.Where(x => x.Month == vm.Month)
                .Where(x => x.CreatedDateTime >= vm.From)
                .Where(x => x.CreatedDateTime <= vm.To)
                .Include(x => x.Supplier)
                .ToListAsync();
            await ExpenseT;

            Task<List<TblTransaction>> ExpenseT_1 = _repositoryWrapper
                .Transaction
                .FindAll()
                .Where(x => x.FactoryId == vm.FactoryId)
                .Where(x => x.CreatedDateTime >= vm.From)
                .Where(x => x.CreatedDateTime <= vm.To)
                // .Where(x => x.Month == vm.Month)
                .Include(x => x.Customer)
                .ToListAsync();
            await ExpenseT_1;

            Task<List<TblTransaction>> ExpenseT_2 = _repositoryWrapper
                .Transaction
                .FindAll()
                .Where(x => x.FactoryId == vm.FactoryId)
                .Where(x => x.CreatedDateTime >= vm.From)
                .Where(x => x.CreatedDateTime <= vm.To)
                // .Where(x => x.Month == vm.Month)
                .Include(x => x.Staff)
                .ToListAsync();
            await ExpenseT_2;

            // await Task.WhenAll(ExpenseT, ExpenseT_1, ExpenseT_2);
            List<TblTransaction> lst = ExpenseT.Result.ToList();
            lst = _utilService.ConcatList<TblTransaction>(ExpenseT.Result.ToList(), _utilService.ConcatList<TblTransaction>(ExpenseT_1.Result.ToList(), ExpenseT_2.Result.ToList()));




            List<MonthlyTransaction> monthlyExpense = new List<MonthlyTransaction>();
            monthlyExpense = _utilService.Mapper.Map<List<TblTransaction>, List<MonthlyTransaction>>(lst);

            returnData.ListOfData = monthlyExpense;
            returnData.TotalRecords = monthlyExpense
                .ToList()
                .Count();

            returnData.TotalTillNow_Credit = returnData.ListOfData.Where(x => x.TransactionType == TRANSACTION_TYPE.CREDIT.ToString()).Sum(x => x.Amount);
            returnData.TotalTillNow_Debit = returnData.ListOfData.Where(x => x.TransactionType == TRANSACTION_TYPE.DEBIT.ToString()).Sum(x => x.Amount);

            returnData.ListOfData = monthlyExpense

                 .OrderByDescending(x => x.CreatedDateTime)
                 .Skip((vm.PageNumber - 1) * (vm.PageSize))
                .Take(vm.PageSize)

                .ToList();

            returnData.TotalMonthly_Credit = returnData.ListOfData.Where(x => x.TransactionType == TRANSACTION_TYPE.CREDIT.ToString()).Sum(x => x.Amount);
            returnData.TotalMonthly_Debit = returnData.ListOfData.Where(x => x.TransactionType == TRANSACTION_TYPE.DEBIT.ToString()).Sum(x => x.Amount);

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
