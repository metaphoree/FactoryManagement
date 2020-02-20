using AutoMapper;
using Contracts;
using Contracts.ServiceContracts;
using Entities.DbModels;
using Entities.ViewModels.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.BusinessServices
{
    public class ItemService : IItemService
    {
        private readonly IRepositoryWrapper _repositoryWrapper;
        private readonly IMapper _mapper;
        public ItemService(IRepositoryWrapper repositoryWrapper, IMapper mapper)
        {
            this._repositoryWrapper = repositoryWrapper;
            this._mapper = mapper;
        }


        public async Task AddItem(AddItemVM addItemModel)
        {
            var addedItem = _mapper.Map<AddItemVM, Item>(addItemModel);
            _repositoryWrapper.Item.Create(addedItem);
            await _repositoryWrapper.SaveAsync();
        }

        public async Task UpdateItem(string id, UpdateItemVM updateItemModel)
        {
            Task<IEnumerable<Item>> ItemDB = _repositoryWrapper.Item.FindByConditionAsync(x => x.Id == id && x.FactoryId == updateItemModel.FactoryId);
            var ItemCategoryUpdated = _mapper.Map<UpdateItemVM, Item>(updateItemModel, ItemDB.Result.ToList().FirstOrDefault());
            _repositoryWrapper.Item.Update(ItemCategoryUpdated);
            await _repositoryWrapper.SaveAsync();
        }




    }
}
