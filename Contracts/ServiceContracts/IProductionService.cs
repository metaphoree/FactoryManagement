using Entities.ViewModels;
using Entities.ViewModels.Production;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.ServiceContracts
{
    public interface IProductionService
    {
         Task<WrapperProductionListVM> GetListPaged(GetDataListVM dataListVM);
         Task<WrapperProductionListVM> Add(AddProductionVM vm);
         Task<WrapperProductionListVM> Update(string id, EditProductionVM vm);
         Task<WrapperProductionListVM> Delete(AddProductionVM itemTemp);
        Task<WrapperProductionListVM> AddProductions(List<AddProductionVM> vmList);
    }
}
