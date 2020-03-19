using Entities.ViewModels;
using Entities.ViewModels.EquipmentCategory;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.ServiceContracts
{
    public interface IEquipmentCategoryService
    {
        Task<WrapperEquipmentCategoryListVM> GetListPaged(GetDataListVM dataListVM);
        Task<WrapperEquipmentCategoryListVM> Add(EquipmentCategoryVM vm);
        Task<WrapperEquipmentCategoryListVM> Update(string id, EquipmentCategoryVM vm);
        Task<WrapperEquipmentCategoryListVM> Delete(EquipmentCategoryVM itemTemp);
    }
}
