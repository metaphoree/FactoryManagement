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

        #region Monthly Report Region
        public async Task<WrapperMonthProductionListVM> MonthlyProduction(MonthlyReport vm)
        {

            WrapperMonthProductionListVM returnData = new WrapperMonthProductionListVM();
            Task<List<Production>> prodT = _repositoryWrapper
                .Production
                .FindAll()
                .Where(x => x.FactoryId == vm.FactoryId)
                .Where(x => x.EntryDate.ToString(MonthFormat.MMMM.ToString()) == vm.Month)
                .Include(x => x.Item)
                .Include(x => x.ItemCategory)
                .Include(x => x.Staff)
                .ToListAsync();

            await Task.WhenAll(prodT);

            List<MonthlyProduction> monthlyProductions = new List<MonthlyProduction>();
            monthlyProductions = _utilService.Mapper.Map<List<Production>, List<MonthlyProduction>>(prodT.Result.ToList());


            returnData.TotalRecords = prodT.Result.ToList().Count();
            returnData.ListOfData = monthlyProductions
                .Skip((vm.PageNumber - 1) * (vm.PageSize))
                .Take(vm.PageSize)
                .OrderByDescending(x => x.CreatedDateTime)
                .ToList();

            MonthlyProduction lastRow = new MonthlyProduction();
            lastRow.TotalAmount = returnData.ListOfData.Sum(x => (x.Quantity * x.Unitprice));
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
                .Where(x => x.CreatedDateTime.ToString(MonthFormat.MMMM.ToString()) == vm.Month)
                .Include(x => x.Supplier)
                //.Include(x => x.ItemCategory)
                //.Include(x => x.Staff)  
                .ToListAsync();

            await Task.WhenAll(payableT);

            List<MonthlyPayable> monthlyPayable = new List<MonthlyPayable>();
            monthlyPayable = _utilService.Mapper.Map<List<Payable>, List<MonthlyPayable>>(payableT.Result.ToList());


            returnData.TotalRecords = payableT.Result.ToList().Count();
            returnData.ListOfData = monthlyPayable
                .Skip((vm.PageNumber - 1) * (vm.PageSize))
                .Take(vm.PageSize)
                .OrderByDescending(x => x.CreatedDateTime)
                .ToList();

            MonthlyPayable lastRow = new MonthlyPayable();
            lastRow.Amount = returnData.ListOfData.Sum(x => (x.Amount));
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
                .Where(x => x.CreatedDateTime.ToString(MonthFormat.MMMM.ToString()) == vm.Month)
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


            returnData.ListOfData = monthlyRecievable
                .Skip((vm.PageNumber - 1) * (vm.PageSize))
                .Take(vm.PageSize)
                .OrderByDescending(x => x.CreatedDateTime)
                .ToList();


            MonthlyRecievable lastRow = new MonthlyRecievable();
            lastRow.Amount = returnData.ListOfData.Sum(x => (x.Amount));
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
                .Where(x => x.CreatedDateTime.ToString(MonthFormat.MMMM.ToString()) == vm.Month)
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


            returnData.ListOfData = monthlyIncome
                .Skip((vm.PageNumber - 1) * (vm.PageSize))
                .Take(vm.PageSize)
                .OrderByDescending(x => x.CreatedDateTime)
                .ToList();


            MonthlyIncome lastRow = new MonthlyIncome();
            lastRow.Amount = returnData.ListOfData.Sum(x => (x.Amount));
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
                .Where(x => x.CreatedDateTime.ToString(MonthFormat.MMMM.ToString()) == vm.Month)
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


            returnData.ListOfData = monthlyExpense
                .Skip((vm.PageNumber - 1) * (vm.PageSize))
                .Take(vm.PageSize)
                .OrderByDescending(x => x.CreatedDateTime)
                .ToList();

            MonthlyExpense lastRow = new MonthlyExpense();
            lastRow.Amount = returnData.ListOfData.Sum(x => (x.Amount));
            returnData.ListOfData.Add(lastRow);


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
