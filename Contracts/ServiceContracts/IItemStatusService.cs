using Entities.ViewModels;
using Entities.ViewModels.ItemStatus;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.ServiceContracts
{
    public interface IItemStatusService
    {
        Task<WrapperItemStatusListVM> Add(ItemStatusVM vm);
        Task<WrapperItemStatusListVM> Delete(ItemStatusVM itemTemp);
        Task<WrapperItemStatusListVM> GetListPaged(GetDataListVM dataListVM);
        Task<WrapperItemStatusListVM> Update(string id, ItemStatusVM vm);
    }
}
