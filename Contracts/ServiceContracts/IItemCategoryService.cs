using Entities.ViewModels.ItemCategoryView;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.ServiceContracts
{
    public interface IItemCategoryService
    {
        Task AddItemCategory(AddItemCategoryViewModel addItemCategoryModel);
        Task UpdateItemCategory(string id, UpdateItemCategoryViewModel updateItemCategoryModel);
    }
}
