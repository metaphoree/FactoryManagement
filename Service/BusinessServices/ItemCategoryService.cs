using AutoMapper;
using Contracts;
using Contracts.ServiceContracts;
using Entities.DbModels;
using Entities.ViewModels;
using Entities.ViewModels.CustomerView;
using Entities.ViewModels.Item;
using Entities.ViewModels.ItemCategoryView;
using Microsoft.EntityFrameworkCore;
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
        private readonly ILoggerManager _logger;
        public ItemCategoryService(IRepositoryWrapper repositoryWrapper, IMapper mapper, ILoggerManager logger)
        {
            this._repositoryWrapper = repositoryWrapper;
            this._mapper = mapper;
            this._logger = logger;
        }


        public async Task<WrapperItemCategoryListVM> GetListPaged(GetDataListVM dataListVM)
        {
            var itemCatagoryList = await _repositoryWrapper.ItemCategory
                .FindAll()
                .Where(x => x.FactoryId == dataListVM.FactoryId)
                .Skip(dataListVM.PageNumber - 1)
                .Take(dataListVM.PageSize)
                .OrderByDescending(x => x.UpdatedDateTime)
                .ToListAsync();

            var dataRowCount = await _repositoryWrapper.ItemCategory.NumOfRecord();
            List<ItemCategoryVM> itemCategoryVMLists = new List<ItemCategoryVM>();
            itemCategoryVMLists = _mapper.Map<List<ItemCategory>, List<ItemCategoryVM>>(itemCatagoryList);
            var wrapper = new WrapperItemCategoryListVM()
            {
                ListOfData = itemCategoryVMLists,
                TotalRecoreds = dataRowCount
            };
            return wrapper;
        }
        public async Task<bool> Add(ItemCategoryVM vm)
        {
            var entityToAdd = _mapper.Map<ItemCategoryVM, ItemCategory>(vm);
            string uniqueIdTask =await _repositoryWrapper.ItemCategory.GetUniqueId();
          
            // Todo  need to aandle unique id from db
            entityToAdd.UniqueId = uniqueIdTask;
            entityToAdd = _repositoryWrapper.ItemCategory.Create(entityToAdd);
            await _repositoryWrapper.ItemCategory.SaveChangesAsync();
            this._logger.LogInfo("Successful In saving  Item Category");
            _logger.LogInfo("-----------------------------------------------------------------");
            _logger.LogInfo("-----------------------------------------------------------------");

            return true;
        }
        public async Task<bool> Update(string id, ItemCategoryVM vm)
        {
            IEnumerable<ItemCategory> ItemDB = await _repositoryWrapper.ItemCategory.FindByConditionAsync(x => x.Id == id && x.FactoryId == vm.FactoryId);
            var ItemUpdated = _mapper.Map<ItemCategoryVM, ItemCategory>(vm, ItemDB.ToList().FirstOrDefault());
            _repositoryWrapper.ItemCategory.Update(ItemUpdated);
            await _repositoryWrapper.ItemCategory.SaveChangesAsync();
            this._logger.LogInfo("Successful In Updating Item Cateory");
            _logger.LogInfo("-----------------------------------------------------------------");
            _logger.LogInfo("-----------------------------------------------------------------");

            return true;
        }
        public async Task<WrapperItemCategoryListVM> Delete(ItemCategoryVM itemTemp)
        {
            var itemTask = await _repositoryWrapper.ItemCategory.FindByConditionAsync(x => x.Id == itemTemp.Id && x.FactoryId == itemTemp.FactoryId);
            var item = itemTask.ToList().FirstOrDefault();
            if (item == null)
            {
                return new WrapperItemCategoryListVM();
            }
            _repositoryWrapper.ItemCategory.Delete(item);
            await _repositoryWrapper.ItemCategory.SaveChangesAsync();
            var dataParam = new GetDataListVM()
            {
                FactoryId = itemTemp.FactoryId,
                PageNumber = 1,
                PageSize = 10,
                TotalRows = 0
            };
            WrapperItemCategoryListVM data = await GetListPaged(dataParam);
            return data;
        }
    
    
    }
}
