using Entities.ViewModels;
using Entities.ViewModels.IncomeType;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.ServiceContracts
{
    public interface IIncomeTypeService
    {
        Task<WrapperIncomeTypeListVM> GetListPaged(GetDataListVM dataListVM);
        Task<WrapperIncomeTypeListVM> Add(IncomeTypeVM vm);
        Task<WrapperIncomeTypeListVM> Update(string id, IncomeTypeVM vm);
        Task<WrapperIncomeTypeListVM> Delete(IncomeTypeVM itemTemp);
    }
}
