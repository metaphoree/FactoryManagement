using Entities.ViewModels.Income;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.ServiceContracts
{
    public interface IIncomeService
    {
        Task<WrapperIncomeListVM> Add(IncomeVM vm);
        Task<WrapperIncomeListVM> Delete(IncomeVM itemTemp);
        Task<WrapperIncomeListVM> GetListPaged(Entities.ViewModels.GetDataListVM dataListVM);
        Task<WrapperIncomeListVM> Update(string id, IncomeVM vm);
    }
}
