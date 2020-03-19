using Entities.ViewModels;
using Entities.ViewModels.ExpenseType;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.ServiceContracts
{
    public interface IExpenseTypeService
    {
        Task<WrapperExpenseTypeListVM> GetListPaged(GetDataListVM dataListVM);
        Task<WrapperExpenseTypeListVM> Add(ExpenseTypeVM vm);
        Task<WrapperExpenseTypeListVM> Update(string id, ExpenseTypeVM vm);
        Task<WrapperExpenseTypeListVM> Delete(ExpenseTypeVM itemTemp);
    }
}
