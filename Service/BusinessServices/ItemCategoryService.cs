using AutoMapper;
using Contracts;
using Contracts.ServiceContracts;
using Entities.DbModels;
using Entities.ViewModels.CustomerView;
using Entities.ViewModels.ItemCategoryView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.BusinessServices
{
    public class ItemCategoryService : IItemCategoryService
    {
        private readonly IRepositoryWrapper _repositoryWrapper;
        private readonly IMapper _mapper;
        public ItemCategoryService(IRepositoryWrapper repositoryWrapper, IMapper mapper)
        {
            this._repositoryWrapper = repositoryWrapper;
            this._mapper = mapper;
        }


        public async Task AddItemCategory(AddItemCategoryViewModel addItemCategoryModel)
        {
            var ItemCategoryUpdated = _mapper.Map<AddItemCategoryViewModel, ItemCategory>(addItemCategoryModel);
            _repositoryWrapper.ItemCategory.Create(ItemCategoryUpdated);
            await _repositoryWrapper.SaveAsync();
        }

        public async Task UpdateItemCategory(string id, UpdateItemCategoryViewModel updateItemCategoryModel)
        {
            Task<IEnumerable<ItemCategory>> ItemCategoryDB = _repositoryWrapper.ItemCategory.FindByConditionAsync(x => x.Id == id && x.FactoryId == updateItemCategoryModel.FactoryId);
            var ItemCategoryUpdated = _mapper.Map<UpdateItemCategoryViewModel, ItemCategory>(updateItemCategoryModel, ItemCategoryDB.Result.ToList().FirstOrDefault());
           _repositoryWrapper.ItemCategory.Update(ItemCategoryUpdated);
            await _repositoryWrapper.SaveAsync();
        }
    }
}
