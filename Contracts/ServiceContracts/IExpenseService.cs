using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.ServiceContracts
{
    public interface IExpenseService
    {
        System.Threading.Tasks.Task<Entities.ViewModels.Expense.WrapperExpenseListVM> Add(Entities.ViewModels.Expense.ExpenseVM vm);
        System.Threading.Tasks.Task<Entities.ViewModels.Expense.WrapperExpenseListVM> Delete(Entities.ViewModels.Expense.ExpenseVM itemTemp);
        System.Threading.Tasks.Task<Entities.ViewModels.Expense.WrapperExpenseListVM> GetListPaged(Entities.ViewModels.GetDataListVM dataListVM);
        System.Threading.Tasks.Task<Entities.ViewModels.Expense.WrapperExpenseListVM> Update(string id, Entities.ViewModels.Expense.ExpenseVM vm);
    }
}
