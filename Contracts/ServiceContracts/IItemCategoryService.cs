﻿using Entities.ViewModels;
using Entities.ViewModels.ItemCategoryView;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.ServiceContracts
{
    public interface IItemCategoryService
    {

        Task<WrapperItemCategoryListVM> GetListPaged(GetDataListVM dataListVM);
        Task<WrapperItemCategoryListVM> Add(ItemCategoryVM vm);
        Task<WrapperItemCategoryListVM> Update(string id, ItemCategoryVM vm);
        Task<WrapperItemCategoryListVM> Delete(ItemCategoryVM itemTemp);
    }
}
