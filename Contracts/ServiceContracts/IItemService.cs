using Entities.ViewModels.Item;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.ServiceContracts
{
    public interface IItemService
    {
        Task AddItem(AddItemVM addItemModel);
        Task UpdateItem(string id, UpdateItemVM updateItemModel);
    }
}
