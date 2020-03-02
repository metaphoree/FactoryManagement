using Entities.ViewModels;
using Entities.ViewModels.Item;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.ServiceContracts
{
    public interface IItemService
    {
        Task<WrapperItemListVM> GetListPaged(GetDataListVM dataListVM);
        Task<bool> Add(ItemVM vm);
        Task<bool> Update(string id, ItemVM vm);
        Task<WrapperItemListVM> Delete(ItemVM itemTemp);


    }
}
